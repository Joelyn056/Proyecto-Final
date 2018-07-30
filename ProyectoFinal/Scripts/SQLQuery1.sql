create database ProyectoDb
go
use ProyectoDb
go


create table Clientes(
ClienteId int identity(1,1) primary key,
Nombres varchar(80),
Sexo varchar(100),
Cedula varchar(100),
Fecha date,
Direccion varchar(255),
NumeroCelular varchar(12),
)

go

create table Productos(
ProductoId int identity(1,1) primary key,
Descripcion varchar(250),
Ganancia decimal,
Costo decimal,
Precio decimal,
FechaIngreso date,
Inventario decimal,
)

go

create table Usuarios(
UsuarioId int identity(1,1) primary key,
Nombres varchar(80),
NombreUsuario varchar(80),
Clave varchar(40),
Cargo varchar(60)
)

go

create table Facturas(
FacturaId int identity(1,1) primary key,
ClienteId int,
Fecha datetime,
SubTotal money,
Itbis money,
Total money
)

go

create table FacturaDetalles(
Id int identity(1,1) primary key,
FacturaId int,
ProductoId int,
Descripcion varchar(max),
Cantidad int,
Precio decimal,
Importe decimal
)
go
