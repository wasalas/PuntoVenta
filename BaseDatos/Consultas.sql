select * from Familias
select * from Sub_Familias
select * from Productos
select * from Imagen_Productos
select * from Imagen_Predeterminada
select * from Punto_Venta

update Imagen_Predeterminada set disponible = (select imagen from Imagen_Productos where codigo_pr=6)
update Imagen_Predeterminada set nodisponible = (select imagen from Imagen_Productos where codigo_pr=7)

select * from Productos_Disponibles_PV

delete from Productos
delete from Imagen_Productos
delete from Productos_Disponibles_PV



declare @estado bit
declare @texto varchar(50)

set @estado = 9
set @texto = '%'


	select codigo_ma, descripcion_ma, estado 
	from Marcas
	where @estado = 9 or estado = @estado
	order by 1

--	and trim(cast(codigo_ma as char)) + upper(trim(descripcion_ma)) like '%' + upper(trim(@texto)) + '%'  

--select * from Marcas

 

DELETE FROM Clientes
dbcc checkident(CLIENTES, reseed, 0);

insert into Clientes
	(codigo_tdi, nrodoc_cl, nombre_cl,        telefono_cl, celular_cl, correo_cl, direccion_cl, fecha_crea, estado)
	values
	(1,          '000000000',       'CLIENTE VARIOS', '',          '',         '',        '',        '2022-14-10',1)
select * from Clientes
