CREATE DATABASE LOGIN1
USE LOGIN1
use loginA

DROP database LOGIN1
CREATE TABLE SECCION(
USUARIO VARCHAR(50) PRIMARY KEY,
CONTRASEÑA VARCHAR(50),
ROLL VARCHAR(50)
)

INSERT INTO SECCION VALUES ('sara123','1','administrador')
INSERT INTO SECCION VALUES ('andre123','2','usuario')
INSERT INTO SECCION VALUES ('jaquy123','3','secretaria')
INSERT INTO SECCION VALUES ('luna123','4','administrador')

CREATE TABLE PARTICIPANTES 
(id int primary key,
nombre varchar(50),
apellido varchar(50),
correo varchar(50),
edad int,
usuario varchar(50),
contraseña varchar(50),
roll varchar(50))

select *from PARTICIPANTES-
select *from seccion