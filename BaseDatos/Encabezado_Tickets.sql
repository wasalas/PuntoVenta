drop procedure if exists spGuardar_Tickets
drop type if exists Ty_detalle_tickets

go

create type Ty_detalle_tickets as table(
	descripcion_pr	varchar(100),
	precio			decimal(10,2),
	cantidad		decimal(10,2),
	total			decimal(10,2),
	obs             varchar(50),
	codigo_pr		int,
	impresora		varchar(150)
	);

go

create or alter procedure spGuardar_Tickets
	@fecha_trabajo	varchar(10),
	@codigo_cl		int,
	@nrodoc_cl		varchar(30),
	@nombre_cl		varchar(150),
	@codigo_me		int,
	@total_ti		decimal(10,2),
	@codigo_tu		int,
	@codigo_us		int,
	@tDetalle		Ty_detalle_tickets readonly	
as  
	declare @codigo_ti	int
	declare @fecha		datetime
	declare @fecha_tmp	varchar(30)

	declare @codigo_tdp  int
	declare @serie_tdp   varchar(5)
	declare @corr_tdp    varchar(30)
	declare @anulado_ti  bit
	declare @obs_anulado varchar(100)

	set @fecha = CONVERT( datetime, GETDATE())
	set @fecha_tmp = left(@fecha_trabajo,10) + ' ' + left(trim(cast(cast(getdate() as time)as char)),10);
	
	set @codigo_tdp  = 1
	set @serie_tdp   = ''
	set @corr_tdp    = ''
	set @anulado_ti  = 0
	set @obs_anulado = ''
	
	-- cabecera de tickets
	insert into Encabezado_Tickets(
		fecha_trabajo,		codigo_cl,		nrodoc_cl,		nombre_cl,
		codigo_me,			total_ti,		codigo_tu,		codigo_us,		fecha_crea,
		codigo_tdp,			serie_tdp,		corr_tdp,		anulado_ti,		obs_anulado
		) values(
		@fecha_tmp,			@codigo_cl,		@nrodoc_cl,		@nombre_cl,
		@codigo_me,			@total_ti,		@codigo_tu,		@codigo_us,		@fecha,
		@codigo_tdp,		@serie_tdp,		@corr_tdp,		@anulado_ti,	@obs_anulado);

	-- codigo de ticket autogenerado
	set @codigo_ti = @@IDENTITY;

	-- detalla de tickets
	insert into Detalle_Tickets(
				codigo_ti, codigo_pr,	 cantidad,	 precio,   total,   obs,   impresora)
		select	@codigo_ti,	a.codigo_pr, a.cantidad, a.precio, a.total, a.obs, a.impresora
		from @tDetalle a;		

	-- marcar mesa como NO DISPONIBLE (mesa ocupada)
	update Mesas
		set disponible = 0
		where codigo_me = @codigo_me;


	select d.impresora, d.codigo_ti, p.descripcion_pv, e.fecha_trabajo,
			t.descripcion_tu, u.nombre_us, r.descripcion_ca,
			m.descripcion_me,
			e.nombre_cl, e.nrodoc_cl
		from Detalle_Tickets				d
			inner join Encabezado_Tickets	e on e.codigo_ti = d.codigo_ti
			inner join Mesas				m on m.codigo_me = e.codigo_me
			inner join Punto_Venta			p on p.codigo_pv = m.codigo_pv
			inner join Turnos				t on t.codigo_tu = e.codigo_tu
			inner join Usuarios				u on u.codigo_us = e.codigo_us
			inner join Cargos				r on r.codigo_ca = u.codigo_ca
		where e.codigo_ti = @codigo_ti
		group by d.impresora, d.codigo_ti, p.descripcion_pv, e.fecha_trabajo,
			t.descripcion_tu, u.nombre_us, r.descripcion_ca,
			m.descripcion_me,
			e.nombre_cl, e.nrodoc_cl;  
 go

 create or alter procedure spMostrar_Tickets_Mesa
	@codigo_me int
as
	select codigo_ti, nombre_cl, fecha_trabajo, total_ti, nrodoc_cl, codigo_cl
		from Encabezado_Tickets
		where anulado_ti = 0 and codigo_me = @codigo_me
		order by codigo_ti;