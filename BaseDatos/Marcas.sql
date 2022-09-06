
create or alter procedure spListado_Marcas
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_ma, descripcion_ma, estado 
	from Marcas
	where estado = @estado and
 			trim(cast(codigo_ma as char)) + upper(trim(descripcion_ma)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Marcas
	@opt_guarda int,
	@codigo int,
	@descripcion varchar(40),
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Marcas (descripcion_ma, estado) values (@descripcion, 1)
		end;
	else
		begin
			update Marcas set descripcion_ma = @descripcion, estado = @estado where codigo_ma = @codigo
		End;
go

create or alter procedure spEliminar_Marcas
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Marcas
		set estado = 0
		where codigo_ma = @codigo
