--SELECT * FROM Clientes

create or alter procedure spListado_cLIENTES
	@estado bit,  
	@texto varchar(30)  
as  
	select c.codigo_cl, d.descripcion_tdi, c.nrodoc_cl, c.nombre_cl, c.telefono_cl, c.celular_cl, c.correo_cl,
		c.direccion_cl, c.estado, c.codigo_tdi
	from Clientes					c
		inner join Tipo_Doc_Ide		d on c.codigo_tdi = d.codigo_tdi
	where c.estado = @estado and
 			trim(c.nrodoc_cl) + upper(trim(c.nombre_cl)) like '%' + upper(trim(@texto)) + '%'  
	order by c.nombre_cl
  
 go

 create or alter procedure spGuardar_Clientes
	@opt_guarda int,
	@codigo_cl int, 
	@codigo_tdi int, 
	@nrodoc_cl varchar(30), 
	@nombre_cl varchar(150), 
	@telefono_cl varchar(30), 
	@celular_cl varchar(30), 
	@correo_cl varchar(150),
	@direccion_cl text, 
	@estado bit
as
	if @opt_guarda = 1
		begin
			insert into Clientes
			(codigo_tdi, nrodoc_cl, nombre_cl, telefono_cl, celular_cl, correo_cl, direccion_cl, estado) 
			values 
			(@codigo_tdi, @nrodoc_cl, @nombre_cl, @telefono_cl, @celular_cl, @correo_cl, @direccion_cl, 1)
		end;
	else
		begin
			update Clientes
				set codigo_tdi =  @codigo_tdi,
					nrodoc_cl = @nrodoc_cl,
					nombre_cl = @nombre_cl,
					telefono_cl = @telefono_cl,
					celular_cl = @celular_cl,
					correo_cl = @correo_cl,
					direccion_cl = @direccion_cl,
					estado = @estado
				where codigo_cl = @codigo_cl
		End;
go

create or alter procedure spEliminar_Clientes
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Clientes
		set estado = 0
		where codigo_cl = @codigo