insert into Cierres_Turnos (fecha_ct, codigo_pv, codigo_tu, estado_tu, fecha_crea ) values
	('2022-10-05', 1, 1, 1, '2022-08-06')
update Cierres_Turnos set estado_tu=0

select * from Cierres_Turnos

create or alter procedure spEstado_Turno_PV 1
	@codigo_pv int
as  
	select	top 1 c.fecha_ct,
			c.codigo_tu,
			t.descripcion_tu,
			c.estado_tu,
			iif( c.estado_tu = 1, 'Abierto','Cerrado' ) as estado_pv,
			c.codigo_pv
	from Cierres_Turnos c
		inner join Turnos   t on c.codigo_tu = t.codigo_tu
	where c.codigo_pv = @codigo_pv
	group by c.fecha_ct,
			c.codigo_tu,
			t.descripcion_tu,
			c.estado_tu,
			c.codigo_pv
	order by c.fecha_ct desc,
			c.codigo_tu desc,
			c.estado_tu desc
			
 go

