create or alter procedure spListado_SubFamilias
	@codigo_fa int, 
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_sf, descripcion_sf, codigo_fa, estado 
	from Sub_Familias
	where codigo_fa = @codigo_fa and
			estado = @estado and
 			trim(cast(codigo_sf as char)) + upper(trim(descripcion_sf)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_SubFamilias
	@opt_guarda int,
	@codigo_sf int,
	@descripcion varchar(40),
	@codigo_fa int,
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Sub_Familias (descripcion_sf, codigo_fa, estado) values (@descripcion, @codigo_fa, 1)
		end;
	else
		begin
			update Sub_Familias set descripcion_sf = @descripcion, estado = @estado where codigo_sf = @codigo_sf
		End;
go

create or alter procedure spEliminar_SubFamilias
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Sub_Familias
		set estado = 0
		where codigo_sf = @codigo
