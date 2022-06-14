create database Roles

use Roles

CREATE TABLE ROLES(
	[id] [int] IDENTITY(1,1) primary key NOT NULL,
	[nombre] [varchar](50) NOT NULL
);

insert into roles 
(nombre) values ('recepcionista');

insert into roles 
(nombre) values ('medico');

insert into roles 
(nombre) values ('administrador');