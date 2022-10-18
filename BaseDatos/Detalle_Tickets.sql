create or alter procedure spListado_Detalle_Tickets
	@impresora varchar(50),
	@codigo_ti int
as
	select d.cantidad, p.descripcion_pr, d.obs
		from Detalle_Tickets		d
			inner join Productos	p on p.codigo_pr = d.codigo_pr
		where d.codigo_ti = @codigo_ti and
			  upper(trim(d.impresora)) = upper(trim(@impresora));