drop procedure if exists spGuardar_Productos
drop type if exists Ty_prod_pv_ok

go

create type Ty_prod_pv_ok as table(
	descripcion_pv varchar(30),
	ok bit,
	codigo_pv int );

go


create or alter procedure spListado_Productos
	@estado bit,  
	@texto varchar(30)  
as  
	SELECT p.codigo_pr,				p.descripcion_pr,			m.descripcion_ma,
		  u.descripcion_um,			f.descripcion_fa,			s.descripcion_sf,
		  a.descripcion_ad,			p.precio_unitario,			p.observaciones,
		  p.codigo_ma,				p.codigo_um,				p.codigo_fa,
		  p.codigo_sf,				p.codigo_ad,				p.fecha_crea,
		  p.fecha_modi,				p.estado
	FROM Productos p
		inner join Marcas          m on m.codigo_ma = p.codigo_ma
		inner join Unidades_Medida u on u.codigo_um = p.codigo_um
		inner join Familias        f on f.codigo_fa = p.codigo_fa
		inner join Sub_Familias    s on s.codigo_sf = p.codigo_sf
		inner join Area_Despacho   a on a.codigo_ad = p.codigo_ad
	where p.estado = @estado and
 		trim(cast(p.codigo_pr as char)) + upper(trim(p.descripcion_pr)) like '%' + upper(trim(@texto)) + '%'  
	order by 1;  
 go

 create or alter procedure spGuardar_Productos
	@opt_guarda int,
	@codigo_pr  int,
	@descripcion_pr varchar(50),	
	@codigo_ma  int,
	@codigo_um  int,
	@codigo_fa  int,
	@codigo_sf  int,
	@precio_unitario decimal(10,2),
	@codigo_ad  int,
	@observaciones varchar(100),
	@estado     bit,
	@imagen     image,
	@Ty_pv      Ty_prod_pv_ok readonly
as
	declare @fecha datetime	
	set @fecha = convert(datetime, getdate())

	if @opt_guarda = 1
		begin
			INSERT INTO Productos (
				descripcion_pr,			codigo_ma,				codigo_um,			codigo_fa,
				codigo_sf,				precio_unitario,		codigo_ad,			observaciones,
				fecha_crea,				estado)
			VALUES(	
				@descripcion_pr,		@codigo_ma,				@codigo_um,			@codigo_fa,
			    @codigo_sf,				@precio_unitario,		@codigo_ad,			@observaciones,
			    @fecha,					1);

			set @codigo_pr = @@IDENTITY;
			insert Imagen_Productos (codigo_pr, imagen) values (@codigo_pr, @imagen);

		end;
	else
		begin
			update Productos set descripcion_pr   = @descripcion_pr,
								 codigo_ma		  = @codigo_ma,
								 codigo_um		  = @codigo_um,
								 codigo_fa		  = @codigo_fa,
								 codigo_sf		  = @codigo_sf,
								 precio_unitario  = @precio_unitario,
								 codigo_ad		  = @codigo_ad,
								 observaciones	  = @observaciones,
								 fecha_modi       = @fecha,           
								 estado			  = @estado
							where codigo_pr = @codigo_pr;

			update Imagen_Productos set imagen = @imagen where codigo_pr = @codigo_pr;
		End;

	delete from Productos_Disponibles_PV where codigo_pr = @codigo_pr;
	
	insert into Productos_Disponibles_PV  select @codigo_pr, t.codigo_pv, t.ok from @Ty_pv t ;
go

create or alter procedure spEliminar_Productos
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Productos
		set estado = 0
		where codigo_pr = @codigo;
