create or alter procedure spListado_Detalle_Tickets_PRN
	@impresora varchar(50),
	@codigo_ti int
as
	select d.cantidad, p.descripcion_pr, d.obs
		from Detalle_Tickets		d
			inner join Productos	p on p.codigo_pr = d.codigo_pr
		where d.codigo_ti = @codigo_ti and
			  upper(trim(d.impresora)) = upper(trim(@impresora));
go
create or alter procedure spListado_Detalle_Tickets
	@codigo_ti int
as
	select	p.descripcion_pr,		d.precio,			d.cantidad,			d.total,
			d.obs,					d.codigo_ti,		d.codigo_pr,		d.impresora
		from Detalle_Tickets		d
			inner join Productos	p on p.codigo_pr = d.codigo_pr
		where d.codigo_ti = @codigo_ti;
go
create or alter procedure spListado_Detalle_Tickets2
	@codigo_ti int
as
	select d.impresora, d.codigo_ti, p.descripcion_pv, e.fecha_trabajo,
				t.descripcion_tu, u.nombre_us, c.descripcion_ca,
				m.descripcion_me,
				e.nombre_cl, e.nrodoc_cl
			from Detalle_Tickets				d
				inner join Encabezado_Tickets	e on e.codigo_ti = d.codigo_ti
				inner join Mesas				m on m.codigo_me = e.codigo_me
				inner join Punto_Venta			p on p.codigo_pv = m.codigo_pv
				inner join Turnos				t on t.codigo_tu = e.codigo_tu
				inner join Usuarios				u on u.codigo_us = e.codigo_us
				inner join Cargos				c on c.codigo_ca = u.codigo_ca
			where e.codigo_ti = @codigo_ti
			group by d.impresora, d.codigo_ti, p.descripcion_pv, e.fecha_trabajo,
				t.descripcion_tu, u.nombre_us, c.descripcion_ca,
				m.descripcion_me,
				e.nombre_cl, e.nrodoc_cl
			order by d.impresora;