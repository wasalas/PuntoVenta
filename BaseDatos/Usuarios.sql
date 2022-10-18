
create or alter procedure spListado_Usuarios
	@estado bit,  
	@texto varchar(30)  
as  
	select codigo_us, login_us, password_us, nombre_us, codigo_ca, codigo_ro, estado 
	from Usuarios
	where estado = @estado and
 			trim(cast(codigo_us as char)) + upper(trim(nombre_us)) like '%' + upper(trim(@texto)) + '%'  
	order by 1
  
 go

 create or alter procedure spGuardar_Usuarios
	@opt_guarda		int,
	@codigo_us		int,
	@login_us		varchar(30),
	@password_us	varchar(30),
	@nombre_us		varchar(30),
	@codigo_ca		int,
	@codigo_ro		int,
	@estado			bit
as
	if @opt_guarda = 1
		begin
			insert into Usuarios 
				(login_us,  password_us, nombre_us,   codigo_ca,  codigo_ro,  estado) values 
				(@login_us, @password_us, @nombre_us, @codigo_ca, @codigo_ro, 1)
		end;
	else
		begin
			update Usuarios 
				set login_us    = @login_us,
					password_us = @password_us,
					nombre_us   = @nombre_us,
					codigo_ca   = @codigo_ca,
					codigo_ro   = @codigo_ro,
					estado      = @estado 
				where codigo_us = @codigo_us
		End;
go

create or alter procedure spEliminar_Usuarios
	-- 1 = activo
	-- 0 = desactivado
	@codigo int
as
	update Usuarios
		set estado = 0
		where codigo_us = @codigo
go

--select * from Usuarios
create or alter procedure spUsuarios_Administrador
	@codigo_us int
as
	select codigo_us, codigo_ro, nombre_us
		from Usuarios
		where codigo_us = @codigo_us

go

DECLARE @borrar bit
set @borrar = 0

if @borrar = 1
	begin
		SELECT * FROM Cargos
		SELECT * FROM Roles_Usuarios
		SELECT * FROM Usuarios

		DELETE FROM Usuarios
		DELETE FROM Cargos
		DELETE FROM Roles_Usuarios

		dbcc checkident(cargos, reseed, 0);
		dbcc checkident(Roles_Usuarios, reseed, 0);
		dbcc checkident(Usuarios, reseed, 0);

		insert into Cargos (descripcion_ca, estado) VALUES('ADMINISTRADOR',1)
		insert into Cargos (descripcion_ca, estado) VALUES('OFICINAS',1)
		insert into Roles_Usuarios(descripcion_ro,estado)values('ADMINISTRADOR',1)
		insert into Roles_Usuarios(descripcion_ro,estado)values('USUARIO',1)

		insert into Usuarios(login_us, password_us, nombre_us, codigo_ca, codigo_ro, estado) values
			('ADMIN', 'ADMIN', 'ADMINSTRADOR', 1,1,1 )
		insert into Usuarios(login_us, password_us, nombre_us, codigo_ca, codigo_ro, estado) values
			('USUARIO 1', 'USUARIO', 'USUARIO 1', 2,2,1 )
		insert into Usuarios(login_us, password_us, nombre_us, codigo_ca, codigo_ro, estado) values
			('USUARIO 2', 'USUARIO', 'USUARIO 2', 2,2,1 )
		insert into Usuarios(login_us, password_us, nombre_us, codigo_ca, codigo_ro, estado) values
			('USUARIO 3', 'USUARIO', 'USUARIO 3', 2,2,1 )
	end