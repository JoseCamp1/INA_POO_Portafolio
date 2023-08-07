--DROP DATABASE CAPAS_PRACTICA1
CREATE DATABASE CAPAS_PRACTICA1
GO

USE CAPAS_PRACTICA1
GO

CREATE TABLE PRODUCTOS
(
    ID_PRODUCTO int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	DESCRIPCION VARCHAR(200),
	PRECIOCOMPRA FLOAT,
	PRECIOVENTA FLOAT,
	GRAVADO CHAR(1)
)

CREATE TABLE CLIENTES
(
    ID_CLIENTE int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR(50),
	TELEFONO VARCHAR(8),
	DIRECCION VARCHAR(100)
)

CREATE TABLE ENCABEZADO_FACTURA
(
    ID_FACTURA int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FECHA DATE,
	ID_CLIENTE INT NOT NULL FOREIGN KEY REFERENCES CLIENTES(ID_CLIENTE),
	SUBTOTAL FLOAT,
	IMPUESTO FLOAT,
	MONTODESCUENTO FLOAT
)

CREATE TABLE DETALLE_FACTURA
(
ID_DETALLE_FACTURA int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_FACTURA INT NOT NULL FOREIGN KEY REFERENCES ENCABEZADO_FACTURA(ID_FACTURA),
ID_PRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(ID_PRODUCTO),
CANTIDAD INT
)

INSERT INTO CLIENTES (NOMBRE, TELEFONO, DIRECCION)
VALUES 
    ('Juan', '11111111', 'Calle Principal, 123'),
    ('Mar�a', '22222222', 'Avenida Central, 456'),
    ('Pedro', '33333333', 'Plaza Mayor, 789'),
    ('Ana', '44444444', 'Calle del Sol, 234'),
    ('Luisa', '55555555', 'Avenida Libertad, 567'),
    ('Carlos', '66666666', 'Calle del Carmen, 890'),
    ('Laura', '77777777', 'Paseo de la Victoria, 1234'),
    ('Miguel', '88888888', 'Avenida del Parque, 5678'),
    ('Sof�a', '99999999', 'Calle Real, 9012'),
    ('Javier', '10101010', 'Carrera del Norte, 3456');

INSERT INTO PRODUCTOS (DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO)
VALUES 
    ('ARROZ', 1500, 1700, 'S'),
    ('FRIJOLES', 1500, 1500, 'S'),
    ('ATUN', 1500, 1500, 'N'),
    ('MAZA', 1500, 1500, 'S'),
    ('HUEVOS', 1500, 1500, 'N');



INSERT INTO ENCABEZADO_FACTURA (FECHA, ID_CLIENTE, SUBTOTAL, IMPUESTO, MONTODESCUENTO)
VALUES ('2023-07-20', 1, 5000, 750, 0); -- Factura con ID_CLIENTE = 1, Subtotal = 5000, Impuesto = 750, MontoDescuento = 0

INSERT INTO DETALLE_FACTURA (ID_FACTURA, ID_PRODUCTO, CANTIDAD)
VALUES (1, 1, 2); -- Producto con ID_PRODUCTO = 1, Cantidad = 2 en la factura con ID_FACTURA = 1

--GO

--CREATE VIEW CONSULTA_RESERVA AS
--SELECT  NUMRESERVACION, T2.ID_CLIENTE,NOMBRE,TELEFONO,
--		FECHAINGRESO,FECHASALIDA,DATEDIFF(DD,FECHAINGRESO,FECHASALIDA) AS NOCHES,
--		CANTIDADPERSONAS,TIPOHABITACION,PRECIO_NOCHE,
--		PRECIO_NOCHE*DATEDIFF(DD,FECHAINGRESO,FECHASALIDA)*CANTIDADPERSONAS AS SUBTOTAL,
--		(PRECIO_NOCHE*DATEDIFF(DD,FECHAINGRESO,FECHASALIDA)*CANTIDADPERSONAS)*0.05 AS ICT,
--		(PRECIO_NOCHE*DATEDIFF(DD,FECHAINGRESO,FECHASALIDA)*CANTIDADPERSONAS)*0.13 AS IVA,
--		CANCELADA
--FROM	RESERVACIONES T1 INNER JOIN CLIENTES T2
--ON		T1.ID_CLIENTE=T2.ID_CLIENTE

--GO

--CREATE PROCEDURE ELIMINAR
--		@idcliente int,  --recibe un id
--		@msj varchar(50) out   --devuelve un mensaje
--AS BEGIN
--if (not exists(select * from CLIENTES where ID_CLIENTE=@idcliente))
--	begin
--		set @msj='El cliente no existe'
--		return 0
--	end
--else
--	begin
--		DELETE from CLIENTES where ID_CLIENTE=@idcliente
--		set @msj='Cliente eliminado'
--		return 1
--	end
--END

GO

CREATE OR ALTER PROCEDURE ELIMINAR
		@idcliente int,  --recibe un id
		@msj varchar(50) out   --devuelve un mensaje
AS BEGIN
if (not exists(select * from CLIENTES where ID_CLIENTE=@idcliente))
	begin
		set @msj='El cliente no existe'
		return 0
	end
else
	begin
		if(not exists(select*from ENCABEZADO_FACTURA where ID_CLIENTE = @idcliente))
		begin
			DELETE from CLIENTES where ID_CLIENTE=@idcliente
			set @msj='Cliente eliminado'
			return 1
		end
		else
		begin
			set @msj = 'Cliente tiene reservaciones, no se puede eliminar'
			return 0
		end
	end
END


SELECT * FROM PRODUCTOS;
SELECT * FROM CLIENTES;
SELECT * FROM ENCABEZADO_FACTURA;
SELECT * FROM DETALLE_FACTURA;

--DELETE FROM ENCABEZADO_FACTURA;
