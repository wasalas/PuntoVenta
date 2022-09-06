
create or alter procedure spListado_Familias
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_fa, descripcion_fa, estado 
	from Familias
	where estado = @estado and
 			trim(cast(codigo_fa as char)) + upper(trim(descripcion_fa)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Familias
	@opt_guarda int,
	@codigo int,
	@descripcion varchar(40),
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Familias (descripcion_fa, estado) values (@descripcion, 1)
		end;
	else
		begin
			update Familias set descripcion_fa = @descripcion, estado = @estado where codigo_fa = @codigo
		End;
go

create or alter procedure spEliminar_Familias
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Familias
		set estado = 0
		where codigo_fa = @codigo
