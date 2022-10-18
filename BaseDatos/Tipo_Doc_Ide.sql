create or alter procedure spListado_Tipo_Doc_Ide
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_tdi, descripcion_tdi, estado 
	from Tipo_Doc_Ide
	where estado = @estado and
 			trim(cast(codigo_tdi as char)) + upper(trim(descripcion_tdi)) like '%' + upper(trim(@texto)) + '%'  
	order by 1;  
 go

 create or alter procedure spGuardar_Tipo_Doc_Ide
	@opt_guarda int,
	@codigo int,
	@descripcion varchar(40),
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Tipo_Doc_Ide (descripcion_tdi, estado) values (@descripcion, 1)
		end;
	else
		begin
			update Tipo_Doc_Ide set descripcion_tdi = @descripcion, estado = @estado where codigo_tdi = @codigo
		End;
go

create or alter procedure spEliminar_Tipo_Doc_Ide
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Tipo_Doc_Ide
		set estado = 0
		where codigo_tdi = @codigo
