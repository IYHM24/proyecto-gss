CREATE PROCEDURE RegistroProcess
AS
SELECT 
	a.id_alquiler,
	cl.cedula,
	cl.nombre,
	a.fecha AS Fecha_Alquiler,
	a.tiempo AS Tiempo_Alquilado,
	a.saldo,
	c.placa,
	c.marca
FROM 
	ALQUILER a
INNER JOIN 
	CARRO c
ON 
	c.id_carro = a.id_carro
INNER JOIN
	CLIENTE cl
ON 
	cl.id_cliente = a.id_cliente;

EXECUTE RegistroProcess;

