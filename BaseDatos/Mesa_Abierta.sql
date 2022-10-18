create or alter procedure spListado_SubFamilias_RP
	@codigo_pv int
as
	select s.descripcion_sf, s.codigo_sf
		from Sub_Familias					s
		inner join Productos				p on s.codigo_sf = p.codigo_sf
		inner join Productos_Disponibles_PV d on p.codigo_pr = d.codigo_pr
		where s.estado = 1 and
			  p.estado = 1 and
			  d.disponible = 1 and
			  d.codigo_pv = @codigo_pv
		group by s.descripcion_sf, 
				 s.codigo_sf
		order by s.descripcion_sf;
go

create or alter procedure spListado_Productos_SubFamilia_RP
	@codigo_pv int,
	@codigo_sf int
as
	select p.codigo_pr, p.descripcion_pr, p.precio_unitario,
		   i.imagen,
		   a.impresora
		from Productos								p
			inner join Productos_Disponibles_PV		d on p.codigo_pr = d.codigo_pr
			inner join Imagen_Productos				i on p.codigo_pr = i.codigo_pr
			inner join Area_Despacho				a on p.codigo_ad = a.codigo_ad
			inner join Unidades_Medida				u on p.codigo_um = u.codigo_um
	where p.estado     = 1 and
		  d.disponible = 1 and
		  d.codigo_pv  = @codigo_pv and
		  p.codigo_sf  = @codigo_sf
	order by p.descripcion_pr
