-- Crear la base de datos -- Control Patrimonial
Create DATABASE ControlPatrimonial  -- Creates the Credito_Rural DataBase
on
  (NAME = ControlPatrimonial,    -- Primary data file
  FILENAME = 'C:\Data\ControlPatrimonial.mdf',
  SIZE = 5MB,
  FILEGROWTH = 1MB
  )
  LOG ON
  (NAME = ControlPatrimonial_Log,   -- Log file
  FILENAME = 'C:\Data\ControlPatrimonial.ldf',
  SIZE = 4MB,
  FILEGROWTH = 1MB
  )
go

/* Activar la Base de datos DBCreditoRural */
use ControlPatrimonial
go

/* Crear las tablas */

--TABLA DE USUARIOS
create table Usuario(
  idUsuario		   varchar(40),
  Usuario		   varchar(40),
  Contraseña	  varchar(40),
 )
 go

 select *
 from Usuario

---INSERTAR DATOS USUARIOS---
 INSERT INTO Usuario
  values ('1','admin','123');

 INSERT INTO Usuario
  values ('2','userWidmar','123456');