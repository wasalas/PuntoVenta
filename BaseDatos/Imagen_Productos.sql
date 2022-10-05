create or alter procedure spMostrar_Imagen_Productos
@codigo_pr int
as  
	select imagen from Imagen_Productos where codigo_pr = @codigo_pr
 go

 