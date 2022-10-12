select * from Mesas
select * from Punto_Venta
--
-- Limnpia toda la base de datos
--
delete from Mesas
dbcc checkident(mesas, reseed, 0);

insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 4',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 5',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 6',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 7',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 8',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 9',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 10',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 11',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 12',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 13',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 14',1,1,1)
insert into Mesas (descripcion_me, codigo_pv, disponible, estado) values('RES MESA - 15',1,1,1)

