-- ====================================================
-- Crear la base de datos
-- ====================================================

use master
go
if exists (select * from sysdatabases where name = 'ControlPatrimonial')
begin
	drop database ControlPatrimonial
end

create database ControlPatrimonial
go

use ControlPatrimonial
go

/* ********************************************************************
                        CREACION DE TABLAS
   ******************************************************************** */
/****************** TABLA USUARIO *************************/
create table Usuarios
(
    Codigo_Usuario           Int Identity(1000, 1),
	Nombres               Varchar(40)   not null,
    Apellido_Paterno      Varchar(30)   not null,
    Apellido_Materno	  Varchar(30)   not null,
	DNI         varchar(8) not null,
	Usuario     varchar(15) not null,
	Contrasenia   varchar(20) not null,

	primary key(Codigo_Usuario) 
)

/****************** TABLA AMBIENTES *************************/
create table Ambientes
(
    Codigo_Ambientes           Varchar(12)   not null,
	Nombre               Varchar(30)   not null,
	Codigo_Usuario       Int not null,

	primary key(Codigo_Ambientes),
	foreign key (Codigo_Usuario) references Usuarios
)
/****************** TABLA TIPO *************************/
create table Tipo
(
    Codigo_Tipo           Varchar(12)   not null,
	Nombre               Varchar(30)   not null,
	primary key(Codigo_Tipo)
)

/****************** TABLA COMPUTO *************************/
create table Computo
(
    Codigo           Varchar(12)   not null,
	Descripcion           Varchar(40)   not null,
	Marca               Varchar(30)   not null,
	Modelo              Varchar(30) not null,
	Caracteristicas           Varchar(40) ,
	Estado           Varchar(10)   not null,
	Observacion           Varchar(45)   ,
	Valor_Historico           numeric(15,2)   not null,
	Depreciacion           numeric(15,2)   not null,
	Valor_Neto           numeric(15,2)   not null,
	Fecha_Compra           datetime   not null,
	Depreciacion_Mensual           numeric(15,2)   not null,
	Tiempo_Vida           numeric(2)   not null,

	primary key(Codigo)
)

/****************** TABLA MUEBLES *************************/
create table Muebles
(
    Codigo           Varchar(12)   not null,
	Descripcion           Varchar(45)   not null,
	Estado               Varchar(15)   not null,	
	Color           Varchar(15) not null,
	Dimensiones           Varchar(50)   not null,
	Observacion           Varchar(50)  ,
	Valor_Historico           numeric(15,2)   not null,
	Depreciacion           numeric(15,2)   not null,
	Valor_Neto           numeric(15,2)   not null,
	Fecha_Compra           datetime   not null,
	Depreciacion_Anual           numeric(15,2)   not null,
	Tiempo_Vida           numeric(2)   not null,

	primary key(Codigo)
)

/****************** TABLA BIENES *************************/
create table Bienes
(
		
    Codigo           Varchar(12)   not null,
	Codigo_Tipo      Varchar(12)   not null,
	Codigo_Ambiente         Varchar(12) not null,

	primary key(Codigo),
	-- foreign key(Codigo) references Computo,
	-- foreign key(Codigo) references Muebles,
	foreign key (Codigo_Tipo) references Tipo,
	foreign key(Codigo_Ambiente) references Ambientes
)