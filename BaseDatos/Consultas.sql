select * from Productos
select * from Imagen_Productos
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
select * from Productos