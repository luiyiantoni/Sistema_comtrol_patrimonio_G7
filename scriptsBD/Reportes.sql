Use ControlPatrimonial
go

/* Numero de bienes por Estado */
SELECT B.Codigo, C.Estado as Estado, B.Codigo_Tipo
	INTO #BComputo
	FROM (Bienes B RIGHT JOIN Computo C ON B.Codigo=C.Codigo)
SELECT B.Codigo, M.Estado as Estado, B.Codigo_Tipo
	INTO #BMuebles
	FROM Bienes B RIGHT JOIN Muebles M ON B.Codigo=M.Codigo

SELECT *
	INTO #BResult 
	FROM #BComputo UNION SELECT *FROM #BMuebles

SELECT
	"Buen Estado" = count(case when BR.Estado = 'BUEN' then BR.Estado else null end),
	"Estado Regular" = count(case when BR.Estado = 'REGULAR' then BR.Estado else null end),
	"Mal Estado" = count(case when BR.Estado = 'MAL' then BR.Estado else null end),
	"Nro Muebles" = count(case when BR.Codigo_Tipo = '2' then BR.Codigo_Tipo else null end),
	"Nro Computo" = count(case when BR.Codigo_Tipo = '1' then BR.Codigo_Tipo else null end),
	"Nro Bienes" = count(BR.Codigo)
	FROM #BResult BR
	DROP TABLE #BComputo DROP TABLE #BMuebles DROP TABLE #BResult

--SELECT *FROM Muebles
--SELECT *FROM Tipo