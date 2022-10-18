SELECT * FROM Cargos
SELECT * FROM Roles_Usuarios
SELECT * FROM Usuarios

DELETE FROM Cargos
DELETE FROM Roles_Usuarios
DELETE FROM Usuarios

dbcc checkident(cargos, reseed, 0);
dbcc checkident(Roles_Usuarios, reseed, 0);
dbcc checkident(Usuarios, reseed, 0);

insert into Cargos (descripcion_ca, estado) VALUES('ADMINISTRADOR',1)
insert into Roles_Usuarios(descripcion_ro,estado)values('ROL ADMIN',1)
insert into Usuarios(login_us, password_us, nombre_us, codigo_ca, codigo_ro, estado) values
	('ADMIN', 'ADMIN', 'ADMINSTRADOR', 1,1,1 )