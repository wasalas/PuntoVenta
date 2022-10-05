create or alter procedure spPunto_Venta_ok
@nOpcion int,
@codigo_pr int
as  
	if @nOpcion = 1
		begin
			select descripcion_pv, 0 as ok, codigo_pv 
				from Punto_Venta 
				where estado = 1 
				order by codigo_pv;
		end;
	else
		begin
			select v.descripcion_pv, d.disponible as ok, d.codigo_pv
				from Productos_Disponibles_PV d
				inner join Punto_Venta        v on d.codigo_pv = v.codigo_pv
				where d.codigo_pr = @codigo_pr
				order by d.codigo_pv
		end;  
 go

 