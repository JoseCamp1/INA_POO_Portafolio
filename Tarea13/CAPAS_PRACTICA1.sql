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
	GRAVADO CHAR(2)
)

CREATE TABLE CLIENTES
(
    ID_CLIENTE int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR(8),
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
ID_FACTURA INT NOT NULL FOREIGN KEY REFERENCES ENCABEZADO_FACTURA(ID_FACTURA),
ID_PRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(ID_PRODUCTO),
CANTIDAD INT
)


SELECT * FROM PRODUCTOS;
SELECT * FROM CLIENTES;
SELECT * FROM ENCABEZADO_FACTURA;
SELECT * FROM DETALLE_FACTURA;