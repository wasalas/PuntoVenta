create or alter procedure spListado_Punto_Venta
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_pv, descripcion_pv, estado 
	from Punto_Venta
	where estado = @estado and
 			trim(cast(codigo_pv as char)) + upper(trim(descripcion_pv)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Punto_Venta
	@opt_guarda int,
	@codigo int,
	@descripcion varchar(40),
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Punto_Venta (descripcion_pv, estado) values (@descripcion, 1)
		end;
	else
		begin
			update Punto_Venta set descripcion_pv = @descripcion, estado = @estado where codigo_pv = @codigo
		End;
go

create or alter procedure spEliminar_Punto_Venta
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Punto_Venta
		set estado = 0
		where codigo_pv = @codigo
