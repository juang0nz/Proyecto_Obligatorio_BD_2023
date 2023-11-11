#INICIO
CREATE DATABASE obligatorio;
USE obligatorio;

CREATE TABLE Logins(
    LogId VARCHAR(200) not null,
    Password VARCHAR(200) not null
);

CREATE TABLE Funcionarios(
    Ci INTEGER not null, #Primary key
    nombre VARCHAR(50) not null,
    apellido VARCHAR(50) not null,
    fecha_nacimiento VARCHAR(50) not null,
    direccion VARCHAR(50) not null,
    Telefono INTEGER not null,
    email VARCHAR(50) not null,
    LogId VARCHAR(200) not null #Foreign key
);

#Comandos de prueba

INSERT INTO Funcionarios(Ci, nombre, apellido, fecha_nacimiento, direccion, Telefono, email, LogId) VALUES
            (12345678, 'juan', 'perez', '1-1-2001', 'a 123 esq c', '123456789', 'a@a.sdf.com', '12345');

INSERT INTO Funcionarios(Ci, nombre, apellido, fecha_nacimiento, direccion, Telefono, email, LogId) VALUES
            (098765432, 'ana', 'perez', '1-1-2001', 'a 123 esq c', '123456789', 'a@a.sdf.com', '12345');


alter table Funcionarios
    add constraint Funcionarios_Ci_pk
        primary key (Ci);

alter table Funcionarios
    add constraint Funcionarios_LogId_fk
        foreign key (LogId) references Logins (LogId);

CREATE TABLE Agenda(
    Nro INTEGER not null,
    Ci INTEGER not null,
    Fch_Agenda VARCHAR(200) not null
);

CREATE TABLE Carnet_Salud(
    Ci INTEGER not null,
    Fch_Emision VARCHAR(200) not null,
    Fch_Vencimiento VARCHAR(200) not null,
    Comprobante VARCHAR(200) not null #Link a imagen/PATH
);

CREATE TABLE Periodos_Actualizacion(
    Year VARCHAR(200) not null,
    Semestre VARCHAR(200) not null,
    Fch_Inicio VARCHAR(200) not null,
    Fch_Fin VARCHAR(200) not null
);