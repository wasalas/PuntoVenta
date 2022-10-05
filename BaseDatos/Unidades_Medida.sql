
create or alter procedure spListado_Unidades_Medida
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_um, descripcion_um, estado 
	from Unidades_Medida
	where estado = @estado and
 			trim(cast(codigo_um as char)) + upper(trim(descripcion_um)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Unidades_Medida
	@opt_guarda int,
	@codigo int,
	@descripcion varchar(40),
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Unidades_Medida (descripcion_um, estado) values (@descripcion, 1)
		end;
	else
		begin
			update Unidades_Medida set descripcion_um = @descripcion, estado = @estado where codigo_um = @codigo
		End;
go

create or alter procedure spEliminar_Unidades_Medida
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Unidades_Medida
		set estado = 0
		where codigo_um = @codigo
