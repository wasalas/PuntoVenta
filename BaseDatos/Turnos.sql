select * from Turnos
go

create or alter procedure spListado_Turnos
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_tu, descripcion_tu, estado 
	from Turnos
	where estado = @estado and
 			trim(cast(codigo_tu as char)) + upper(trim(descripcion_tu)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Turnos
	@opt_guarda int,
	@codigo int,
	@descripcion varchar(40),
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Turnos (descripcion_tu, estado) values (@descripcion, 1)
		end;
	else
		begin
			update Turnos set descripcion_tu = @descripcion, estado = @estado where codigo_tu = @codigo
		End;
go

create or alter procedure spEliminar_Turnos
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Turnos
		set estado = 0
		where codigo_tu = @codigo
