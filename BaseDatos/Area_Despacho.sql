
create or alter procedure spListado_Area_Despacho
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_ad, descripcion_ad, impresora, estado 
	from Area_Despacho
	where estado = @estado and
 			trim(cast(codigo_ad as char)) + upper(trim(descripcion_ad)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Area_Despacho
	@opt_guarda int,
	@codigo int,
	@descripcion varchar(40),
	@impresora varchar(150),
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Area_Despacho (descripcion_ad, impresora, estado) values (@descripcion, @impresora, 1)
		end;
	else
		begin
			update Area_Despacho 
				set descripcion_ad = @descripcion, impresora = @impresora, estado = @estado 
				where codigo_ad = @codigo
		End;
go

create or alter procedure spEliminar_Area_Despacho
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Area_Despacho
		set estado = 0
		where codigo_ad = @codigo
