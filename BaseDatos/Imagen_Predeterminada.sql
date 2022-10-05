select * from Imagen_Productos
select * from Imagen_Predeterminada
select * from Productos


-- inicializar tabla desde IMAGEN_PRODUCTO
delete from Imagen_Predeterminada
insert into Imagen_Predeterminada (producto ) select imagen from Imagen_Productos

create or alter procedure spMostrar_Imagen_Predeterminada
as  
	select producto from Imagen_Predeterminada
 go

 