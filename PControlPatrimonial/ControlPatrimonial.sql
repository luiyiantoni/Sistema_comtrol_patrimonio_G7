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
create table Usuarios(
  idUsuario		   Int Identity(1, 1),
  Usuario		   varchar(10),
  Nombres 		   varchar(15),
  APaterno		   varchar(15),
  AMaterno		   varchar(15),
  DNI			   varchar(8),
  Usuario 		   varchar(10),
  Contraseña	  	   varchar(15)
 )
 go

 select *
 from Usuario

---INSERTAR DATOS USUARIOS---
----CONSULTAS EXTRA-----




select * from Usuarios

 INSERT INTO Usuario
  values ('1','admin','123');
delete from Usuarios

ALTER TABLE Usuario ADD Nombres varchar(20);

--TABLA DE USUARIOS
create table Usuario(
  idUsuario		   varchar(40),
  Usuario		   varchar(40),
  Contraseña	  varchar(40),
  Nombres		varchar(20)
 )
 go

create table Usuarios(
  idUsuario		   Int Identity(1, 1),
  Nombres 		   varchar(15),
  APaterno		   varchar(15),
  AMaterno		   varchar(15),
  DNI			   varchar(8),
  Usuario 		   varchar(10),
  Contraseña	  varchar(15)
 )
 go

 Alter Table Usuarios
Add IdUsuario Int Identity(1, 1) 
Go 

 ALTER TABLE Usuarios ALTER COLUMN idUsuario IDENTITY(1,1)
 --INDICES--
 DBCC CHECKIDENT (Usuarios, RESEED,0)
 --TABLA USUARIOS--
  INSERT INTO Usuarios
  values ('Waldo','Ibarra','Castillo','72668173','WAdmin','123');
    INSERT INTO Usuarios
  values ('Jefferson','Farfán','Guadalupe','72668173','Jefry10','FocaRoja');
    INSERT INTO Usuarios
  values ('Paolo','Guerrero ','Gonzales','74079421','Paolo09','BlanquiRoja');
    INSERT INTO Usuarios
  values ('Lionel','Messi','Cuccittini','72759942','Messi9','BarcelonaM');