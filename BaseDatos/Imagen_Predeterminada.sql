create or alter procedure spMostrar_Imagen_Predeterminada
as  
	select producto from Imagen_Predeterminada
 go

 create or alter procedure spMostrar_Imagen_Estado_Mesa
 @estado int
as  
	select iif(@estado = 1, disponible, nodisponible) as estado_me
		from Imagen_Predeterminada
 go

 