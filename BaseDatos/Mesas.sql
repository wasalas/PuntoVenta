create or alter procedure spListado_Mesas
	@codigo_pv int, 
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_me, descripcion_me, codigo_pv, estado 
	from Mesas
	where codigo_pv = @codigo_pv and
			estado = @estado and
 			trim(cast(codigo_me as char)) + upper(trim(descripcion_me)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Mesas
	@opt_guarda int,
	@codigo_me int,
	@descripcion varchar(40),
	@codigo_pv int,
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Mesas (descripcion_me, codigo_pv, estado) values (@descripcion, @codigo_pv, 1)
		end;
	else
		begin
			update Mesas set descripcion_me = @descripcion, estado = @estado where codigo_pv = @codigo_pv
		End;
go

create or alter procedure spEliminar_Mesas
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Mesas
		set estado = 0
		where codigo_me = @codigo
