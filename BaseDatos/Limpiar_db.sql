select * from Detalle_Tickets
select * from Encabezado_Tickets
select * from mesas

update Mesas set disponible=1
DELETE FROM Detalle_Tickets
DELETE FROM Encabezado_Tickets

--dbcc checkident(Detalle_Tickets, reseed, 0);
dbcc checkident(Encabezado_Tickets, reseed, 0);

select * from Mesas
select * from Punto_Venta
select * from Productos
select * from Cierres_Turnos
