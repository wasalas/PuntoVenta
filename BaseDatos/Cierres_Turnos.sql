create or alter procedure spEstado_Turno_PV
	@codigo_pv int
as  
	select	top 1 c.fecha_ct,
			c.codigo_tu,
			t.descripcion_tu,
			c.estado_tu,
			iif( c.estado_tu = 1, 'Abierto','Cerrado' ) as estado_pv,
			c.codigo_pv,
			p.descripcion_pv
	from Cierres_Turnos        c
		inner join Turnos      t on c.codigo_tu = t.codigo_tu
		inner join Punto_Venta p on c.codigo_pv = p.codigo_pv
	where c.codigo_pv = @codigo_pv
	group by c.fecha_ct,
			c.codigo_tu,
			t.descripcion_tu,
			c.estado_tu,
			c.codigo_pv,
			p.descripcion_pv
	order by c.fecha_ct desc,
			c.codigo_tu desc,
			c.estado_tu desc
go

create or alter procedure spAbrir
	@fecha_ct date,
	@codigo_pv int,
	@codigo_tu int
as
	declare @fecha date
	set @fecha = CONVERT(date, getdate())

	insert into Cierres_Turnos
		(fecha_ct,  codigo_pv,  codigo_tu,  estado_tu, fecha_crea) values
		(@fecha_ct, @codigo_pv, @codigo_tu, 1,         @fecha);		
go

create or alter procedure spCerrar
	@fecha_ct date,
	@codigo_pv int,
	@codigo_tu int
as
	update Cierres_Turnos
		set estado_tu = 0
		where	fecha_ct  = @fecha_ct and
				codigo_pv = @codigo_pv and
				codigo_tu = @codigo_tu;
go
