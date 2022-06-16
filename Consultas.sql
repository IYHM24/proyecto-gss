
 /* Crear tablas y llaves consulta 1*/
CREATE TABLE ALQUILER(
	id_alquiler INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	fecha DATE NOT NULL, 
	tiempo INTEGER NOT NULL,
	valor_total MONEY NOT NULL,
	saldo MONEY NOT NULL,  
	abono_inicial MONEY NOT NULL,
	devuelto BIT NOT NULL,
	id_cliente INTEGER NOT NULL,
	id_carro INTEGER NOT NULL
);


CREATE TABLE CARRO(
	id_carro INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
	placa VARCHAR(6),
	marca VARCHAR(20) NOT NULL, 
	modelo INTEGER NOT NULL, 
	costo MONEY NOT NULL,  
	disponible BIT NOT NULL,
);

CREATE TABLE CLIENTE(
	id_cliente INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	cedula VARCHAR(10) NOT NULL, 
	nombre VARCHAR(30) NOT NULL, 
	telefono1 VARCHAR(10) NOT NULL,  
	telefono2 VARCHAR(10) NOT NULL,
);

CREATE TABLE PAGOS(
	id_pago INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	fecha Date NOT NULL, 
	valor Money NOT NULL,
);


   /* Valores a carro*/
  INSERT INTO CARRO (placa, marca, modelo, costo, disponible)
  VALUES  ('KLX549', 'BMW', 2011, 70000, 0);
  INSERT INTO CARRO (placa, marca, modelo, costo, disponible)
  VALUES  ('PEP242', 'HYUNDAI', 2004, 34000, 1);
  INSERT INTO CARRO (placa, marca, modelo, costo, disponible)
  VALUES  ('ZIP242', 'CHEVROLET', 1999, 1000000, 0);
  INSERT INTO CARRO (placa, marca, modelo, costo, disponible)
  VALUES  ('FOR545', 'FORD', 2022, 50000, 1);
  
  /* Valores a cliente*/
  INSERT INTO CLIENTE(cedula, nombre, telefono1, telefono2)
  VALUES  ('1013695842','Carlos', '3506930989', '6012035053');
  INSERT INTO CLIENTE(cedula, nombre, telefono1, telefono2)
  VALUES  ('1113695842','Andres', '3057643395', '6015452136');
  INSERT INTO CLIENTE(cedula, nombre, telefono1, telefono2)
  VALUES  ('1014675856','Eduardo', '3205487896', '6013648967');
  INSERT INTO CLIENTE(cedula, nombre, telefono1, telefono2)
  VALUES  ('1214875656','Erika', '3158945678', '6015478966');
 INSERT INTO CLIENTE(cedula, nombre, telefono1, telefono2)
  VALUES  ('1234575656','Ricardo', '3048956567', '6013258966');

   /* llave foranea a alquiler*/
  ALTER TABLE ALQUILER ADD CONSTRAINT fk_cliente FOREIGN KEY(id_cliente) REFERENCES CLIENTE(id_cliente);
  ALTER TABLE ALQUILER ADD CONSTRAINT fk_carro FOREIGN KEY(id_carro) REFERENCES CARRO(id_carro);

   /* llave foranea a pagos*/
  ALTER TABLE PAGOS ADD id_alquiler INTEGER;
  ALTER TABLE PAGOS ADD CONSTRAINT fk_alquiler FOREIGN KEY(id_alquiler) REFERENCES ALQUILER(id_alquiler);

  /* Valores a alquiler*/
  INSERT INTO ALQUILER(fecha, tiempo, valor_total, saldo, abono_inicial, devuelto, id_cliente, id_carro)
  VALUES  ('2022-06-12',365,1000000, 500000,500000,0,4,3);
  INSERT INTO ALQUILER(fecha, tiempo, valor_total, saldo, abono_inicial, devuelto, id_cliente, id_carro)
  VALUES  ('2022-01-07',5,34000, 0, 34000,1,5,3);
  INSERT INTO ALQUILER(fecha, tiempo, valor_total, saldo, abono_inicial, devuelto, id_cliente, id_carro)
  VALUES  ('2022-09-07',20,50000, 0, 50000,1,2,3);
    INSERT INTO ALQUILER(fecha, tiempo, valor_total, saldo, abono_inicial, devuelto, id_cliente, id_carro)
  VALUES  ('2022-12-07',50,70000, 10000, 60000,0,3,3);
  INSERT INTO ALQUILER(fecha, tiempo, valor_total, saldo, abono_inicial, devuelto, id_cliente, id_carro)
  VALUES  ('2022-12-07',50,70000, 10000, 60000,0,3,3);
  INSERT INTO ALQUILER(fecha, tiempo, valor_total, saldo, abono_inicial, devuelto, id_cliente, id_carro)
  VALUES  ('2022-04-07',10,70000, 0, 70000,1,6,1);

  DELETE FROM ALQUILER WHERE devuelto = 1;
  ALTER TABLE PAGOS DROP CONSTRAINT fk_alquiler;
  ALTER TABLE ALQUILER DROP CONSTRAINT fk_cliente;
  ALTER TABLE ALQUILER DROP CONSTRAINT fk_carro;

  SELECT * FROM ALQUILER;

   /* Valores a pagos*/
  INSERT INTO PAGOS(fecha, valor, id_alquiler)
  VALUES  ('2022-06-12',1000000, 1);
  INSERT INTO PAGOS(fecha, valor, id_alquiler)
  VALUES  ('2022-01-07',34000, 2);
  INSERT INTO PAGOS(fecha, valor, id_alquiler)
  VALUES  ('2022-09-07',50000, 3);
  INSERT INTO PAGOS(fecha, valor, id_alquiler)
  VALUES  ('2022-12-07',70000, 4);
  INSERT INTO PAGOS(fecha, valor, id_alquiler)
  VALUES  ('2022-12-07',70000, 5);
  INSERT INTO PAGOS(fecha, valor, id_alquiler)
  VALUES  ('2022-04-07',70000, 6);

 /* Consulta 2 */
 SELECT 
	c.placa,
	c.marca,
	COUNT(c.id_carro) AS TOTAL_ALQUILADO_FECHA
FROM 
	ALQUILER a
INNER JOIN 
	carro c
ON 
	c.id_carro = a.id_carro
WHERE 
	fecha >= '2022-07-07'
AND
	c.placa = 'KLX549'
AND
	c.marca = 'BMW'
GROUP BY
	c.placa, c.marca;

/* Consulta 3 */
SELECT 
	SUM(a.saldo) AS Saldo_del_dia
FROM 
	ALQUILER a
WHERE
	a.fecha = '2022-12-07';

/* Consulta 4*/
SELECT 
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

/*Consulta 5*/
SELECT 
	cl.cedula,
	cl.nombre
FROM 
	CLIENTE cl
INNER JOIN
	ALQUILER a
ON
	a.id_cliente = cl.id_cliente
WHERE
	NOT a.fecha BETWEEN '2022-06-01' AND '2022-12-31';

 /* Consulta 6*/
SELECT 
	a.fecha AS Fecha_alquiler,
	COUNT(a.fecha) AS Cuantos_Pagos,
	SUM(a.abono_inicial) AS Total_pagado, 
	MAX(a.abono_inicial) AS Maximo_valor
FROM 
	ALQUILER a
WHERE
	a.fecha = '2022-12-07'
GROUP BY a.fecha;

/*Consulta 7*/
SELECT 
	c.id_carro AS codcarro,
	c.modelo,
	c.marca,
	c.costo,
	COUNT(a.id_carro) AS Cuantos_alquileres,
	(COUNT(a.id_carro)*c.costo) AS Total_en_alquileres
FROM
	ALQUILER a
INNER JOIN 
	CARRO c
ON 
	c.id_carro = a.id_carro
GROUP BY 
	c.id_carro, c.modelo, c.marca, c.costo;


/*Consulta 8*/
SELECT TOP 1
	cl.cedula,
	cl.nombre,
	a.fecha AS Primer_Alquiler
FROM 
	CLIENTE cl
INNER JOIN
	ALQUILER a
ON
	a.id_cliente = cl.id_cliente
WHERE
	cl.nombre = 'Carlos';