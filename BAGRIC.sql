CREATE TABLE DEPARTAMENTO(
IDDEPARTAMENTO INT IDENTITY (1,1) PRIMARY KEY,
CODDEPARTAMENTO NVARCHAR (50),
DEPARTAMENTO NVARCHAR (100)
)
GO

CREATE TABLE EMPLEADO(
IDEMPLEADO INT IDENTITY (1,1) PRIMARY KEY,
CODEMPLEADO NVARCHAR(100),
NOMBRE NVARCHAR(100),
APELLIDO NVARCHAR(100),
EDAD NVARCHAR(100),
CORREO NVARCHAR(100),
CONTACTO NVARCHAR(100),
DIRECCION NVARCHAR(100),
SALARIO FLOAT,
IDDEPARTAMENTO INT
--RELACIONES 
CONSTRAINT RELACION_A_DEPARTAMENTO FOREIGN KEY (IDDEPARTAMENTO) REFERENCES DEPARTAMENTO (IDDEPARTAMENTO)
)
GO

CREATE TABLE MES(
IDMES INT IDENTITY (1,1) PRIMARY KEY,
MES NVARCHAR (100)
)
GO

insert into MES values 
('ENERO'),
('FEBRERO'),
('MARZO'),
('ABRIL'),
('MAYO'),
('JUNIO'),
('JULIO'),
('AGOSTO'),
('SEPTIEMBRE'),
('OCTUBRE'),
('NOVIEMBRE'),
('DICIEMBRE')
GO

SELECT * FROM MES

CREATE TABLE RENDIMIENTO(
IDRENDIMIENTO INT IDENTITY (1,1) PRIMARY KEY,
IDMES INT,
IDEMPLEADO INT,
EVALUACION NVARCHAR (10)
--RELACIONES 
CONSTRAINT RELACION_A_EMPLEADO FOREIGN KEY (IDEMPLEADO) REFERENCES EMPLEADO (IDEMPLEADO),
CONSTRAINT RELACION_A_MES FOREIGN KEY (IDMES) REFERENCES MES (IDMES)
)
GO
SELECT * FROM RENDIMIENTO

-----------------------------------PROCEDIMIENTOS ALMACENADOS DEPARTAMENTOS---------------------- 
-----LISTAR DEPARTAMENTO
create proc MostrarDepartamento
as
select *from DEPARTAMENTO order by DEPARTAMENTO asc
go

--------------------------INSERTAR 
create proc InsertarDepartamento
@codigodep nvarchar (50),
@departamento nvarchar (100)
as
insert into DEPARTAMENTO values (@codigodep,@departamento)
go

------------------EDITAR
create proc EditarDepartamento
@codigodep nvarchar (50),
@departamento nvarchar (100),
@id int
as
update DEPARTAMENTO set CODDEPARTAMENTO=@codigodep, DEPARTAMENTO=@departamento where IDDEPARTAMENTO=@id
go

------------------------ELIMINAR
create proc EliminarDepartamento
@iddep int
as
delete from DEPARTAMENTO where IDDEPARTAMENTO=@iddep
go


exec MostrarDepartamento
/*exec InsertarDepartamento 'Ing','Ingenieria'
exec EditarDepartamento 'Tec','Tecnico',1
exec EliminarDepartamento 1*/


-----------------------------------PROCEDIMIENTOS ALMACENADOS EMPLEADO---------------------- 
-----LISTAR DEP_EMPLEADO
create proc MostrarDepartamentoEmp 
as
select DEPARTAMENTO from DEPARTAMENTO order by DEPARTAMENTO asc
go

exec MostrarDepartamentoEmp

-----LISTAR DEP
create proc ListarDepaEmp
as
select *from DEPARTAMENTO order by DEPARTAMENTO asc
go

select *from DEPARTAMENTO order by DEPARTAMENTO asc


exec ListarDepaEmp

-----AGREGAR EMPLEADO
create proc AgregarEmpleado
@CodEmp nvarchar (100),
@Nombre nvarchar (100),
@Apellido nvarchar (100),
@Edad nvarchar (100),
@Correo nvarchar (100),
@Contacto nvarchar (100),
@Direccion nvarchar (100),
@Salario float,
@idDepartament int
as
insert into EMPLEADO values (@CodEmp,@Nombre,@Apellido,@Edad,@Correo,@Contacto,@Direccion,@Salario,@idDepartament)
go

------------------EDITAR
create proc EditarEmpleado
@CodEmp nvarchar (100),
@Nombre nvarchar (100),
@Apellido nvarchar (100),
@Edad nvarchar (100),
@Correo nvarchar (100),
@Contacto nvarchar (100),
@Direccion nvarchar (100),
@Salario float,
@idDepartament int,
@id int
as
update EMPLEADO set CODEMPLEADO=@CodEmp, NOMBRE=@Nombre, APELLIDO=@Apellido, EDAD=@Edad,CORREO=@Correo, 
CONTACTO=@Contacto,DIRECCION=@Direccion, SALARIO=@Salario, IDDEPARTAMENTO=@idDepartament where IDEMPLEADO=@id
go

------------------------ELIMINAR
create proc EliminarEmpleado
@idemp int
as
delete from EMPLEADO where IDEMPLEADO=@idemp
go

-----LISTAR EMPLEADOS
create proc MostrarEmpleado
as
select IDEMPLEADO AS ID, CODEMPLEADO, NOMBRE, APELLIDO, EDAD, CORREO, CONTACTO, DIRECCION, SALARIO, DEPARTAMENTO.DEPARTAMENTO
 from EMPLEADO 
INNER JOIN DEPARTAMENTO ON EMPLEADO.IDDEPARTAMENTO=DEPARTAMENTO.IDDEPARTAMENTO
go

/*exec MostrarDepartamentoEmp
exec AgregarEmpleado 'Tec','Tecnico','Tec','Tecnico','Tec','Tecnico','Tec',300,5
exec MostrarEmpleado
exec EliminarEmpleado 2*/

/**/

-----------------------------------PROCEDIMIENTOS ALMACENADOS RENDIMIENTOS---------------------- 


-----LISTAR RENDIMIENTO_EMP
create proc MostrarRendimiento
as
select IDRENDIMIENTO AS ID, MES.MES,EMPLEADO.NOMBRE,EVALUACION
 from RENDIMIENTO 
INNER JOIN MES ON RENDIMIENTO.IDMES=MES.IDMES
INNER JOIN EMPLEADO ON RENDIMIENTO.IDEMPLEADO=EMPLEADO.IDEMPLEADO
go

exec MostrarRendimiento

-----LISTAR MES
create proc MostrarMes
as
select MES from MES
go

exec MostrarMes

create proc MostrarMesR
as
select *from MES
go

exec MostrarMesR

-----LISTAR EMP
create proc MostrarMesEmp
as
select *from EMPLEADO order by NOMBRE asc
go

select *from EMPLEADO order by NOMBRE asc


exec MostrarMesEmp

-----AGREGAR R_MES
create proc AgregarRendimiento
@idMes int,
@idEmpleado int,
@Evaluacion nvarchar (10)
as
insert into RENDIMIENTO values (@idMes,@idEmpleado,@Evaluacion)
go

------------------EDITAR
create proc EditarRendimiento
@idMes int,
@idEmpleado int,
@Evaluacion nvarchar (10),
@id int
as
update RENDIMIENTO set IDMES=@idMes, IDEMPLEADO=@idEmpleado, EVALUACION=@Evaluacion where IDRENDIMIENTO=@id
go

------------------------ELIMINAR
create proc EliminarRendimiento
@idren int
as
delete from RENDIMIENTO where IDRENDIMIENTO=@idren
go