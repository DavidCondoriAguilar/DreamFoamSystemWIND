-- DREAMFOAM_DB Version 3.0 

-- TABLAS  

USE master;

IF EXISTS ( SELECT name FROM sysdatabases WHERE name = 'DreamFoam_DB_v2' )
	DROP DATABASE DreamFoam_DB_v2;

CREATE DATABASE DreamFoam_DB_v2;
GO

USE DreamFoam_DB_v2;

CREATE TABLE Tb_UserSystem(
	codUser integer IDENTITY(1,1) PRIMARY KEY,
	nomUser varchar(50) not null,
	passUser varchar(25) not null,
	estdUser int not null,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) null,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) null
);

INSERT INTO Tb_UserSystem(nomUser,passUser,estdUser) VALUES ('admin','admin','1');

CREATE TABLE Tb_Horario(
	codHorario integer IDENTITY(1,1)  PRIMARY KEY,
	desHorario varchar(50) not null,
	ingLUN TIME null,
	salLUN TIME null,
	ingMAR TIME null,
	salMAR TIME null,
	ingMIE TIME null,
	salMIE TIME null,
	ingJUE TIME null,
	salJUE TIME null,
	ingVIE TIME null,
	salVIE TIME null,
	ingSAB TIME null,
	salSAB TIME null,
	ingDOM TIME null,
	salDOM TIME null,
	refriger TIME not null,
	tolernc TIME not null,
	diaDesc int not null,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) null,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) null
);

INSERT INTO Tb_Horario VALUES
('ADMINISTRATIVO'	,'08:30','19:00','08:30','19:00','08:30','19:00','08:30','19:00','08:30','18:15','00:00','00:00','00:00','00:00','01:00','00:15',2,GETDATE(),'SYSTEM',null,null),
('HOR_ALMACEN'		,'06:30','16:15','06:30','16:15','06:30','16:15','06:30','16:15','06:30','16:15','06:30','09:30','00:00','00:00','01:00','00:00',1,GETDATE(),'SYSTEM',null,null),
('HOR_ASISTECNICO'	,'07:00','16:45','07:00','16:45','07:00','16:45','07:00','16:45','07:00','16:45','07:00','10:00','00:00','00:00','01:00','00:00',1,GETDATE(),'SYSTEM',null,null),
('HOR_TRANSPORTE'	,'07:00','17:25','07:00','17:25','07:00','17:25','07:00','17:25','07:00','17:25','00:00','00:00','00:00','00:00','01:00','00:00',2,GETDATE(),'SYSTEM',null,null),
('HOR_PART1'		,'13:00','22:00','00:00','00:00','13:00','22:00','13:00','22:00','13:00','22:00','12:00','20:00','10:00','18:00','01:00','00:00',1,GETDATE(),'SYSTEM',null,null),
('HOR_PART2'		,'00:00','00:00','13:00','22:00','04:00','13:00','04:00','13:00','04:00','13:00','05:00','12:00','00:00','00:00','01:00','00:00',2,GETDATE(),'SYSTEM',null,null),
('HOR_GENDIA1'		,'07:00','16:00','07:00','16:00','07:00','16:00','07:00','16:00','07:00','16:00','07:00','12:00','00:00','00:00','01:00','00:00',1,GETDATE(),'SYSTEM',null,null),
('HOR_GENDIA2'		,'07:00','16:00','07:00','16:00','07:00','16:00','07:00','16:00','07:00','16:00','00:00','00:00','07:00','12:00','01:00','00:00',1,GETDATE(),'SYSTEM',null,null),
('HOR_GENNOC1'		,'16:00','12:00','16:00','12:00','16:00','12:00','16:00','12:00','16:00','12:00','16:00','20:00','00:00','00:00','01:00','00:00',1,GETDATE(),'SYSTEM',null,null),
('HOR_GENNOC1'		,'16:00','12:00','16:00','12:00','16:00','12:00','16:00','12:00','16:00','12:00','00:00','00:00','16:00','20:00','01:00','00:00',1,GETDATE(),'SYSTEM',null,null);


CREATE TABLE Tb_Sede(
	codSede integer IDENTITY(1,1) PRIMARY KEY,
	nomSede varchar(30) not null,
	direccion varchar(50) not null
);

INSERT INTO Tb_Sede VALUES	
('DREAMFOAM PUENTE-PIEDRA','Av. Juan Lecaros 11868, Puente Piedra 15121'),
('DREAMFOAM ATE','Av. Prol. Javier Prado Este 8680, Ate 15494'),
('DREAMFOAM ANCASH','Jirón Juan de la Cruz Romero 210, Huaraz 02001'),
('DREAMFOAM CERCADO','Av. Amezaga, Lima 15081'),
('DREAMFOAM SANMIGUEL','Av. la Marina 2000, San Miguel 15088');

CREATE TABLE Tb_Area (
    codArea INT IDENTITY (1,1) PRIMARY KEY,
    nomArea VARCHAR(100)
);

INSERT INTO Tb_Area VALUES
('ADMINISTRACION'),
('CONTABILIDAD'),
('ASISTENCIA TECNICA'),
('SISTEMAS'),
('CAPACITACION'),
('TRANSPORTE'),
('ALMACEN'),
('SERVICIO ATENCION AL CLIENTE'),
('CALL CENTER'),
('PRODUCCION'),
('MARKETING');

CREATE TABLE Tb_Cargo (
    codCargo INT IDENTITY (1,1) PRIMARY KEY,
    nomCargo VARCHAR(100)
);

INSERT INTO Tb_Cargo VALUES
('ASISTENTE ADM-FACTURACION'),
('ASISTENTE ADMINISTRATIVO'),
('AUXILIAR DE LIQUIDACIONES'),
('COORDNIDOR DE GENRENCIA GENERAL'),
('RECEPCIONISTA'),
('AUXILIAR ADMINISTRATIVO'),
('TECNICO DE MANTENIMIENTO'),
('ASISTENTE DE IMPORTACIONES'),
('ANALISTA DE ADMINISTRACION DE PROCESOS'),
('ASISTENTE DE COMPRAS'),
('GERENTE DE ADMINISTRACION Y FINANZAS'),
('ASISTENTE DE DESPACHO'),
('ASISTENTE DE RECEPCION'),
('JEFE DE ALMACEN'),
('ENCARGADO DE SECCION'),
('COORDINADOR DE OPERACIONES'),
('AUXILIAR DE ALMACEN'),
('ASISTENTE DE INVENTARIOS'),
('TECNICO DE MAQUINAS'),
('TECNICO OPERARIO'),
('COORDINADOR DE ASISTENCIA TECNICA'),
('TECNICO ELECTRONICO'),
('EJECUTIVO(A) DE ATENCION AL CLIENTE SENIOR'),
('JEFE DE SERVICIO AL CLIENTE'),
('COORDINADORA DE SERVICIO TECNICO'),
('EJECUTIVO(A) DE CALLCENTER'),
('EJECUTIVO(A) DE ATENCION AL CLIENTE'),
('ASESOR DE VENTAS SENIOR'),
('COORDINADOR OPERATIVO'),
('SUPERVISOR GENERAL DE CALLCENTER'),
('COORDINADOR ENTRAMIENTO, CALIDAD Y VERIFICACION'),
('ASISTENTE CALLCENTER'),
('COORDINADOR DE VENTAS'),
('COORDINADOR OPERATIVO SUCURSAL'),
('ASISTENTE PEDIDOS PROVINCIA'),
('ASISTENTE SUCURSAL'),
('ASESORA DE VENTAS ECOMMERCE'),
('COORDINADOR DE VENTAS'),
('ASISTENTE DE PEDIDOS LIMA'),
('ANALISTA DE CALIDAD'),
('ASESOR(A) DE VENTAS'),
('ASESOR(A) DE REDES SOCIALES'),
('AUDITOR INTERNO'),
('CONTADOR'),
('ASISTENTE DE COBRANZAS'),
('ASISTENTE DE PLANILLAS'),
('ANALISTA CONTABLE'),
('ASISTENTA SOCIAL'),
('AUXILIAR DE CONTABILIDAD'),
('ASISTENTE DE TESORERIA'),
('ASISTENTE DE RECUT Y SELEC'),
('ANALISTA CONTABLE SENIOR'),
('ASISTENTE DE CONTABILIDAD'),
('FORMADOR - CAPACITADOR'),
('GERENTE COMERCIAL Y MARKETING'),
('COORDINADORA COMERCIAL'),
('POST PRODUCTOR'),
('PRODUCTOR GUIONISTA'),
('DISEÑADOR(A) GRAFICO(A)'),
('ANALISTA DIGITAL'),
('EDITOR'),
('JEFE DE MARKETING Y PUBLICIDAD'),
('ASISTENTE DE MARKETING'),
('JEFE DE SISTEMAS'),
('ADMINISTRADOR DE REDES'),
('ANALISTA DE SISTEMAS'),
('SOPORTE TECNICO'),
('SUPERVISOR GENERAL DE VENTAS'),
('SUPERVISOR(A) JUNIOR'),
('ADMINISTRADOR SENIOR'),
('ADMINISTRADOR JUNIOR'),
('CHOFER REPARTIDOR'),
('ASISTENTE DE TRANSPORTE'),
('COORDINADOR DE TRANSPORTE'),
('AUXILIAR DE TRANSPORTE'),
('ASISTENTE DE TRANSPORTE'),
('COORDINADOR DE TRANSPORTE'),
('CHOFER'),
('ASISTENTE ADM- LIQUIDACIONES'),
('GERENTE DE OPERACIONES'),
('ASISTENTE DE SS.GG.'),
('ASISTENTE DE PUBLICIDAD'),
('ASISTENTE DE PRODUCCION'),
('PRAC - CONTABILIDAD'),
('PRAC - SISTEMAS'),
('PRAC - MARKETING'),
('AUXILIAR DE INVENTARIO');

CREATE TABLE Tb_Documento(
	codDoc varchar(2) PRIMARY KEY NOT NULL,
	descrCorta varchar(15) NOT NULL,
	descrLarga varchar(70) NOT NULL,
	longitud int NOT NULL
);

INSERT INTO Tb_Documento (codDoc,descrCorta,descrLarga,longitud)
VALUES
('01','L.E/DNI','LIBRETA ELECTORAL O DNI',08),
('04','CARNET EXT.','CARNET DE EXTRANJERIA',12),
('06','RUC','REG. UNICO DE CONTRIBUYENTES',11),
('07','PASAPORTE','PASAPORTE',12),
('11','P.NAC.','PART. DE NACIMIENTO-IDENTIDAD',15),
('00','OTROS','OTROS',15);


CREATE TABLE Tb_Empleado(
	codEmpleado integer IDENTITY (1001,1) PRIMARY KEY,
	numroDoc nvarchar(15) NOT NULL,
	tipoDoc varchar(2) NOT NULL FOREIGN KEY REFERENCES Tb_Documento(codDoc),
	apellidos nvarchar (50) NOT NULL,
	nombres nvarchar(50) NOT NULL,
	fecNacimiento DATE NOT NULL, 
	genero nvarchar(1) NOT NULL,
	correo nvarchar(150) NULL,
	direccion nvarchar(100) NOT NULL,
	telefono integer NULL,
	fecIngreso DATE NOT NULL,
	codCargo integer NOT NULL FOREIGN KEY REFERENCES Tb_Cargo(codCargo),
	codArea integer NOT NULL FOREIGN KEY REFERENCES Tb_Area(codArea),
	codSede integer NOT NULL FOREIGN KEY REFERENCES Tb_Sede(codSede),
	codHorario integer NOT NULL FOREIGN KEY REFERENCES Tb_Horario(codHorario),
	foto image NULL,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) NULL,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) NULL,
	estado int null
);

CREATE TABLE Tb_Marcas(
	codMarc integer IDENTITY (1000,1) PRIMARY KEY,
	empleado integer NOT NULL FOREIGN KEY REFERENCES Tb_Empleado(codEmpleado),
	fecha DATETIME NOT NULL,
	hora TIME NOT NULL,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) NULL,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) NULL
);

CREATE TABLE Tb_Diario(
	codDiar  integer IDENTITY (1000,1) PRIMARY KEY,
	fecha DATE NOT NULL,
	empleado integer NOT NULL FOREIGN KEY REFERENCES Tb_Empleado(codEmpleado),
	horario integer NOT NULL,
	hIngreso  DATETIME NOT NULL,
	hSalida DATETIME NOT NULL,
	hora1 DATETIME NULL,
	hora2 DATETIME NULL,
	hora3 DATETIME NULL,
	hora4 DATETIME NULL,
	ingrTard TIME NULL,
	exeRefr TIME NULL,
	exeJornd TIME NULL,
	observ VARCHAR(25) NULL,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) NULL,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) NULL
);


CREATE TABLE Tb_Calendario2024(
	codCal integer IDENTITY (1,1) PRIMARY KEY,
	fecha DATE not null,	
);

DECLARE @startDate DATE = '2024-01-01';
DECLARE @endDate DATE = '2024-12-31';
DECLARE @currentDate DATE = @startDate;

WHILE @currentDate <= @endDate
BEGIN
    INSERT INTO Tb_Calendario2024 (fecha) VALUES (@currentDate);
    SET @currentDate = DATEADD(DAY, 1, @currentDate);
END;


CREATE TABLE Tb_Feriados(
	codFeriado integer IDENTITY (1,1) PRIMARY KEY,
	fecha DATE not null,
	descrip varchar(50) null,
);

INSERT INTO Tb_Feriados (fecha, descrip) VALUES
('2024-01-01', 'Año Nuevo'),
('2024-04-05', 'Viernes Santo'),
('2024-05-01', 'Día del Trabajo'),
('2024-07-28', 'Fiestas Patrias'),
('2024-07-29', 'Fiestas Patrias'),
('2024-08-30', 'Día de Santa Rosa de Lima'),
('2024-10-08', 'Combate de Angamos'),
('2024-11-01', 'Día de Todos los Santos'),
('2024-12-08', 'Día de la Inmaculada Concepción'),
('2024-12-25', 'Navidad');

-- TABLAS AUDITORIAS

CREATE TABLE Tb_UserSystem_Audit(
	codUser integer PRIMARY KEY,
	nomUser varchar(50) not null,
	passUser varchar(25) not null,
	estdUser int not null,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) null,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) null,

	accion VARCHAR(50)NULL, 
	fec_HorAccion DATETIME NULL
);

CREATE TABLE Tb_Horario_Audit(
	codHorario integer PRIMARY KEY,
	desHorario varchar(50) not null,
	ingLUN TIME not null,
	salLUN TIME not null,
	ingMAR TIME not null,
	salMAR TIME not null,
	ingMIE TIME not null,
	salMIE TIME not null,
	ingJUE TIME not null,
	salJUE TIME not null,
	ingVIE TIME not null,
	salVIE TIME not null,
	ingSAB TIME not null,
	salSAB TIME not null,
	ingDOM TIME not null,
	salDOM TIME not null,
	refriger TIME not null,
	tolernc TIME not null,
	diaDesc int not null,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) null,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) null,

	accion VARCHAR(50)NULL, 
	fec_HorAccion DATETIME NULL

);

CREATE TABLE Tb_Empleado_Audit(
	codEmpleado integer PRIMARY KEY,
	numroDoc nvarchar(15) NOT NULL,
	tipoDoc varchar(2) NOT NULL,
	apellidos nvarchar (50) NOT NULL,
	nombres nvarchar(50) NOT NULL,
	fecNacimiento DATE NOT NULL, 
	genero nvarchar(1) NOT NULL,
	correo nvarchar(150) NULL,
	direccion nvarchar(100) NOT NULL,
	telefono integer NULL,
	fecIngreso DATE NOT NULL,
	codCargo integer NOT NULL,
	codArea integer NOT NULL,
	codSede integer NOT NULL,
	codHorario integer NOT NULL,
	foto image NULL,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) NULL,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) NULL,
	estado int null,

	accion VARCHAR(50)NULL, 
	fec_HorAccion DATETIME NULL
);

CREATE TABLE Tb_Marcas_Audit(
	codMarc integer PRIMARY KEY,
	empleado integer NOT NULL,
	fecha DATETIME NOT NULL,
	hora TIME NOT NULL,

	fec_Reg  datetime NULL,
	usu_Reg varchar(20) NULL,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) NULL,

	accion VARCHAR(50) NULL, 
	fec_HorAccion DATETIME NULL	
);

CREATE TABLE Tb_Diario_Audit(
	codDiar  integer PRIMARY KEY,
	fecha DATE NOT NULL,
	empleado integer NOT NULL,
	horario integer NOT NULL,
	hIngreso  DATETIME NOT NULL,
	hSalida DATETIME NOT NULL,
	hora1 DATETIME NULL,
	hora2 DATETIME NULL,
	hora3 DATETIME NULL,
	hora4 DATETIME NULL,
	ingrTard TIME NULL,
	exeRefr TIME NULL,
	exeJornd TIME NULL,
	observ VARCHAR(25) NULL,
	
	fec_Reg  datetime NULL,
	usu_Reg varchar(20) NULL,
	fec_UltMod datetime NULL,
	usu_UltMod varchar(20) NULL,

	accion VARCHAR(50)NULL, 
	fec_HorAccion DATETIME NULL
);


-- VISTAS 
GO 
CREATE VIEW vw_VistaUserSystem
	AS
	SELECT 
		codUser,
		nomUser,
		passUser,
		estdUser
	FROM Tb_UserSystem
GO
CREATE VIEW vw_VistaHorario
	AS
	SELECT 
		codHorario,
		desHorario,
		ingLUN,
		salLUN,
		ingMAR,
		salMAR,
		ingMIE,
		salMIE,
		ingJUE,
		salJUE,
		ingVIE,
		salVIE,
		ingSAB,
		salSAB,
		ingDOM,
		salDOM,
		refriger,
		tolernc,
		diaDesc
	FROM Tb_Horario
GO
CREATE VIEW vw_VistaEmpleado
	AS
	SELECT 
		codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento, 
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		foto,
		estado
	FROM Tb_Empleado
GO

CREATE VIEW vw_VistaMarcas
	AS
	SELECT 
		codMarc,
		empleado,
		fecha,
		hora
	FROM Tb_Marcas
GO
CREATE VIEW vw_VistaDiario
	AS
	SELECT
		codDiar,
		fecha,
		empleado,
		horario,
		hIngreso,
		hSalida,
		hora1,
		hora2,
		hora3,
		hora4,
		ingrTard,
		exeRefr,
		exeJornd,
		observ
	FROM Tb_Diario

-- PROCEDIMIENTOS ALMACENADOS	

-- EMPLEADOS
go
CREATE PROCEDURE usp_EliminarEmpleado
	@codEmpleado INTEGER  
	AS 
	BEGIN
	DELETE FROM Tb_Empleado
	WHERE codEmpleado = @codEmpleado;
END;

go
CREATE PROCEDURE usp_ConsultarEmpleado
	@codEmpleado INTEGER
	AS
	BEGIN
	SELECT * FROM vw_VistaEmpleado
	WHERE codEmpleado = @codEmpleado;
END;

go
CREATE PROCEDURE usp_ListarEmpleados
	AS
	BEGIN
	SELECT 
		codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento, 
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		foto,
		estado
	FROM vw_VistaEmpleado
	ORDER BY codEmpleado
END;

go	
CREATE PROCEDURE usp_InsertarEmpleado
	@numroDoc nvarchar(15),
	@tipoDoc nvarchar(2),
	@apellidos nvarchar (50),
	@nombres nvarchar(50),
	@fecNacimiento DATE, 
	@genero nvarchar(1),
	@correo nvarchar(150),
	@direccion nvarchar(100),
	@telefono integer,
	@fecIngreso DATE,
	@codCargo integer,
	@codArea integer,
	@codSede integer,
	@codHorario integer,
	@foto image,

	@fec_Reg  datetime,
	@usu_Reg varchar(20),

	@estado integer
	AS
	BEGIN 
	SET @fec_Reg = GETDATE();
	INSERT INTO Tb_Empleado
	(
	numroDoc,
	tipoDoc,
	apellidos,
	nombres,
	fecNacimiento,
	genero,
	correo,
	direccion,
	telefono,
	fecIngreso,
	codCargo,
	codArea,
	codSede,
	codHorario,
	foto,
	fec_Reg,
	usu_Reg,
	estado
	) VALUES
	(@numroDoc,
	@tipoDoc,
	@nombres,
	@apellidos,
	@fecNacimiento,
	@genero,
	@correo,
	@direccion,
	@telefono,
	@fecIngreso,
	@codCargo,
	@codArea,
	@codSede,
	@codHorario,
	@foto,
	@fec_Reg,
	@usu_Reg,
	@estado
	);
END;

go
CREATE PROCEDURE usp_ActualizarEmpleado
	@codEmpleado integer,
	@numroDoc nvarchar(15),
	@tipoDoc nvarchar(2),
	@apellidos nvarchar (50),
	@nombres nvarchar(50),
	@fecNacimiento DATE, 
	@genero nvarchar(1),
	@correo nvarchar(150),
	@direccion nvarchar(100),
	@telefono integer,
	@fecIngreso DATE,
	@codCargo integer,
	@codArea integer,
	@codSede integer,
	@codHorario integer,
	@foto image,

	@usu_UltMod varchar(20),
	@estado integer
	AS
	UPDATE Tb_Empleado SET 
		numroDoc = @numroDoc,
		tipoDoc = @tipoDoc,
		nombres = @nombres,
		apellidos = @apellidos,
		fecNacimiento = @fecNacimiento,
		genero = @genero,
		correo = @correo,
		direccion = @direccion,
		telefono = @telefono,
		fecIngreso = @fecIngreso,
		codCargo = @codCargo,
		codArea = @codArea,
		codSede = @codSede,
		codHorario = @codHorario,
		foto = @foto,
		fec_UltMod = GETDATE(),
		usu_UltMod = @usu_UltMod,
		estado = @estado
	WHERE codEmpleado = @codEmpleado;
-- VARIOS

GO
CREATE PROCEDURE usp_ListarHorarios
	AS
	BEGIN
	SELECT
		*	
	FROM vw_VistaHorario
	ORDER BY codHorario;
END;

GO
CREATE PROCEDURE usp_ListarSede
	AS
	BEGIN
	SELECT
		*	
	FROM Tb_Sede
	ORDER BY codSede;
END;
GO

CREATE PROCEDURE usp_ListarArea
	AS
	BEGIN
	SELECT
		*	
	FROM Tb_Area
	ORDER BY codArea;
END;

GO
CREATE PROCEDURE usp_ListarCargo
	AS
	BEGIN
	SELECT
		*	
	FROM Tb_Cargo
	ORDER BY codCargo;
END;

GO 
CREATE PROCEDURE usp_ListarDocumentos
	AS
	BEGIN
	SELECT
	*
	FROM Tb_Documento
	ORDER BY codDoc;
END;


-- UserSystem

GO 
CREATE PROCEDURE  usp_EliminarUserSystem
	@codUser INTEGER
	AS
	BEGIN 
	DELETE FROM Tb_UserSystem
	WHERE codUser = @codUser;
END;

GO 
CREATE PROCEDURE usp_ConsultarUserSystem
	@codUser INTEGER 
	AS 
	BEGIN 
	SELECT*FROM vw_VistaUserSystem
	WHERE codUser = @codUser;
END;

GO
CREATE PROCEDURE usp_ValidarUserSystem
	@nomUser VARCHAR(50),
	@passUser VARCHAR(25)
	AS
	BEGIN 
	SELECT * FROM vw_VistaUserSystem
	WHERE nomUser = @nomUser AND passUser = @passUser;
END;

GO
CREATE PROCEDURE usp_ListarUserSystem
	AS 
	BEGIN 
	SELECT 
		codUser,
		nomUser,
		passUser,
		estdUser
	FROM vw_VistaUserSystem
	ORDER BY codUser;
END;

GO
CREATE PROCEDURE usp_InsertarUserSystem
	@nomUser VARCHAR(50),
	@passUser VARCHAR(25),
	@estdUser int,

	@fec_Reg datetime,
	@usu_Reg varchar(20)
	AS
	BEGIN
	SET @fec_Reg = GETDATE();
	INSERT INTO Tb_UserSystem
	(nomUser,
	passUser,
	estdUser,
	fec_Reg,
	usu_Reg
	)VALUES
	(
	@nomUser,
	@passUser,
	@estdUser,
	@fec_Reg,
	@usu_Reg
	);
END;

GO
CREATE PROCEDURE usp_ActualizarUserSystem
	@codUser integer, 
	@nomUser VARCHAR(50),
	@passUser VARCHAR(25),
	@estdUser int,
	@usu_UltMod varchar(20)
	AS
	UPDATE Tb_UserSystem SET
		nomUser = @nomUser,
		passUser = @passUser,
		estdUser = @estdUser,
		fec_UltMod = GETDATE(),
		usu_UltMod = @usu_UltMod
	WHERE codUser = @codUser;

-- MARCAS 
GO	
CREATE PROCEDURE usp_EliminarMarca
	@codMarc integer
	AS
	BEGIN
	DELETE FROM Tb_Marcas
	WHERE codMarc = @codMarc;
	END;

GO 
CREATE PROCEDURE usp_ConsultarMarca
	@codMarc integer
	AS
	BEGIN
	SELECT * FROM vw_VistaMarcas
	WHERE codMarc = @codMarc;
END;

GO
CREATE PROCEDURE usp_ListarMarcas
	AS
	BEGIN 
	SELECT 
		*
	FROM vw_VistaMarcas
	ORDER BY codMarc;
	END;


GO
CREATE PROCEDURE usp_InsertarMarca
	@empleado integer, 

	@usu_Reg varchar(20)
	AS
	BEGIN 
	INSERT INTO Tb_Marcas
	(empleado,
	fecha,
	hora,
	fec_Reg,
	usu_Reg)
	VALUES
	(@empleado,
	GETDATE(),
	CAST(GETDATE() AS TIME),
	GETDATE(),
	@usu_Reg);
END;

GO
CREATE PROCEDURE usp_ActualizarMarca
	@codMarc integer,
	@empleado integer,
	@fecha datetime,
	@hora time,

	@usu_UltMod varchar(20)
	AS
	UPDATE Tb_Marcas SET
		empleado = @empleado,
		fecha = @fecha,
		hora = @hora,
		fec_UltMod = GETDATE(),
		usu_UltMod = @usu_UltMod
	WHERE codMarc = @codMarc;

-- DIARIO

GO 
CREATE PROCEDURE usp_EliminarDiario
	@codDiar integer
	AS
	BEGIN 
	DELETE FROM Tb_Diario
	WHERE codDiar = @codDiar;
	END;
	
GO 
CREATE PROCEDURE usp_ConsultarDiario
	@codDiar integer
	AS
	BEGIN
	SELECT * FROM vw_VistaDiario
	WHERE codDiar = @codDiar;
	END;

GO
CREATE PROCEDURE usp_ListarDiario
	AS
	BEGIN
	SELECT 
		*
	FROM vw_VistaDiario
	ORDER BY fecha;
END;

GO
CREATE PROCEDURE usp_InsertarDiario
	@fecha date,
	@empleado integer,
	@horario integer,
	@hIngreso datetime,
	@hSalida datetime,
	@hora1 datetime,
	@hora2 datetime,
	@hora3 datetime,
	@hora4 datetime,
	@ingrTard TIME,
	@exeRefr TIME,
	@exeJornd TIME,
	@observ varchar(25),

	@usu_Reg varchar(20)
	AS
	BEGIN 
	INSERT INTO Tb_Diario
	(fecha,
	empleado,
	horario,
	hIngreso,
	hSalida,
	hora1,
	hora2,
	hora3,
	hora4,
	ingrTard,
	exeRefr,
	exeJornd,
	observ,
	fec_Reg,
	usu_Reg)
	VALUES
	(@fecha,
	@empleado,
	@horario,
	@hIngreso,
	@hSalida,
	@hora1,
	@hora2,
	@hora3,
	@hora4,
	@ingrTard,
	@exeRefr,
	@exeJornd,
	@observ,
	GETDATE(),
	@usu_Reg
	);
	END;

GO
CREATE PROCEDURE  usp_ActualizarDiario
	@codDiar integer,
	@fecha date,
	@empleado integer,
	@horario integer,
	@hIngreso datetime,
	@hSalida datetime,
	@hora1 datetime,
	@hora2 datetime,
	@hora3 datetime,
	@hora4 datetime,
	@ingrTard TIME,
	@exeRefr TIME,
	@exeJornd TIME,
	@observ varchar(25),

	@usu_UltMod varchar(20)
	AS
	UPDATE Tb_Diario SET	
		fecha = @fecha,
		empleado = @empleado,
		horario = @horario,
		hora1 = @hora1,
		hora2 = @hora2,
		hora3 = @hora3,
		hora4 = @hora4,
		ingrTard = @ingrTard,
		exeRefr = @exeRefr,
		exeJornd = @exeJornd,
		observ = @observ,

		fec_UltMod = GETDATE(),
		usu_UltMod = @usu_UltMod
	WHERE codDiar = @codDiar;

-- HORARIOS
GO
CREATE PROCEDURE usp_EliminarHorario	
	@codHorario integer
	AS
	BEGIN
	DELETE FROM  Tb_Horario
	WHERE codHorario = @codHorario;
END;

GO
CREATE PROCEDURE usp_ConsultarHorario
	@codHorario integer 
	AS
	BEGIN
	SELECT * FROM vw_VistaHorario
	WHERE codHorario = @codHorario;
	END;

GO 
CREATE PROCEDURE usp_InsertarHorario
	@desHorario varchar(50),
	@ingLUN TIME,
	@salLUN TIME,
	@ingMAR TIME,
	@salMAR TIME,
	@ingMIE TIME,
	@salMIE TIME,
	@ingJUE TIME,
	@salJUE TIME,
	@ingVIE TIME,
	@salVIE TIME,
	@ingSAB TIME,
	@salSAB TIME,
	@ingDOM TIME,
	@salDOM TIME,
	@refriger TIME,
	@tolernc TIME,
	@diaDesc int,

	@usu_Reg varchar(20)
	AS
	BEGIN
	INSERT INTO Tb_Horario
	(desHorario,
	ingLUN,
	salLUN,
	ingMAR,
	salMAR,
	ingMIE,
	salMIE,
	ingJUE,
	salJUE,
	ingVIE,
	salVIE,
	ingSAB,
	salSAB,
	ingDOM,
	salDOM,
	refriger,
	tolernc,
	diaDesc,

	fec_Reg,
	usu_Reg
	)VALUES	 
	(@desHorario,
	@ingLUN,
	@salLUN,
	@ingMAR,
	@salMAR,
	@ingMIE,
	@salMIE,
	@ingJUE,
	@salJUE,
	@ingVIE,
	@salVIE,
	@ingSAB,
	@salSAB,
	@ingDOM,
	@salDOM,
	@refriger,
	@tolernc,
	@diaDesc,
	GETDATE(),
	@usu_Reg 
	);
	END;

GO
CREATE PROCEDURE usp_ActualizarHorario
	@codHorario integer,
	@desHorario varchar(50),
	@ingLUN TIME,
	@salLUN TIME,
	@ingMAR TIME,
	@salMAR TIME,
	@ingMIE TIME,
	@salMIE TIME,
	@ingJUE TIME,
	@salJUE TIME,
	@ingVIE TIME,
	@salVIE TIME,
	@ingSAB TIME,
	@salSAB TIME,
	@ingDOM TIME,
	@salDOM TIME,
	@refriger TIME,
	@tolernc TIME,
	@diaDesc int,

	@usu_UltMod varchar(20)
	AS
	UPDATE Tb_Horario SET	 
		desHorario = @desHorario,
		ingLUN = @ingLUN,
		salLUN = @salLUN,
		ingMAR = @ingMAR,
		salMAR = @salMAR,
		ingMIE = @ingMIE,
		salMIE = @salMIE,
		ingJUE = @ingJUE,
		salJUE = @salJUE,
		ingVIE = @ingVIE,
		salVIE = @salVIE,
		ingSAB = @ingSAB,
		salSAB = @salSAB,
		ingDOM = @ingDOM,
		salDOM = @salDOM,
		refriger = @refriger,
		tolernc = @tolernc,
		diaDesc = @diaDesc,

		fec_UltMod = GETDATE(),
		usu_UltMod = @usu_UltMod
		WHERE codHorario = @codHorario;


-- EMPLEADOS
GO 
CREATE TRIGGER tr_EmpleadoInsertar
	ON Tb_Empleado
	AFTER INSERT
	AS
	BEGIN 
		INSERT INTO Tb_Empleado_Audit
		(codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento,
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		foto,

		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		estado,
		accion,
		fec_HorAccion
		)
		SELECT 
		codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento,
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		null,

		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		estado,
		'INSERT',
		GETDATE()
		FROM inserted;
END;

GO 
CREATE TRIGGER tr_EmpleadoActualizar
	ON  Tb_Empleado
	AFTER UPDATE
	AS
	BEGIN
		INSERT INTO Tb_Empleado_Audit
		(codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento,
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		foto,

		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		estado,
		accion,
		fec_HorAccion
		)
		SELECT 
		codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento,
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		null,

		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		estado,
		'UPDATE',
		GETDATE()
		FROM deleted;
END;

GO
CREATE TRIGGER tr_EmpleadoEliminar
	ON Tb_Empleado
	AFTER DELETE
	AS
	BEGIN
		INSERT INTO Tb_Empleado_Audit
		(codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento,
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		foto,

		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		estado,
		accion,
		fec_HorAccion
		)
		SELECT 
		codEmpleado,
		numroDoc,
		tipoDoc,
		apellidos,
		nombres,
		fecNacimiento,
		genero,
		correo,
		direccion,
		telefono,
		fecIngreso,
		codCargo,
		codArea,
		codSede,
		codHorario,
		null,

		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		estado,
		'DELETE',
		GETDATE()
		FROM deleted;
END;

-- UserSystem
GO
CREATE TRIGGER tr_UserSystemInsertar
	ON Tb_UserSystem
	AFTER INSERT
	AS 
	BEGIN
		INSERT INTO Tb_UserSystem_Audit
		(codUser,
		nomUser,
		passUser,
		estdUser,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
	
		accion, 
		fec_HorAccion
		)
		SELECT
		codUser,
		nomUser,
		passUser,
		estdUser,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
	
		'INSERT', 
		GETDATE()
		FROM inserted;
END;

GO 
CREATE TRIGGER tr_UserSystemActualizar
	ON Tb_UserSystem
	AFTER UPDATE
	AS
	BEGIN
		INSERT INTO Tb_UserSystem_Audit
		(codUser,
		nomUser,
		passUser,
		estdUser,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
	
		accion, 
		fec_HorAccion
		)
		SELECT
		codUser,
		nomUser,
		passUser,
		estdUser,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
	
		'UPDATE', 
		GETDATE()
		FROM deleted;
END;

GO
CREATE TRIGGER tr_UserSystemEliminar
	ON Tb_UserSystem
	AFTER DELETE 
	AS
	BEGIN 
		INSERT INTO Tb_UserSystem_Audit
		(codUser,
		nomUser,
		passUser,
		estdUser,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
	
		accion, 
		fec_HorAccion
		)
		SELECT
		codUser,
		nomUser,
		passUser,
		estdUser,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
	
		'DELETE', 
		GETDATE()
		FROM deleted;
END;

-- Horario

GO 
CREATE TRIGGER tr_HorarioInsertar
	ON Tb_Horario
	AFTER INSERT 
	AS
	BEGIN 
		INSERT INTO Tb_Horario_Audit
		(codHorario,
		desHorario,
		ingLUN,
		salLUN,
		ingMAR,
		salMAR,
		ingMIE,
		salMIE,
		ingJUE,
		salJUE,
		ingVIE,
		salVIE,
		ingSAB,
		salSAB,
		ingDOM,
		salDOM,
		refriger,
		tolernc,
		diaDesc,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		accion, 
		fec_HorAccion)
		SELECT
		codHorario,
		desHorario,
		ingLUN,
		salLUN,
		ingMAR,
		salMAR,
		ingMIE,
		salMIE,
		ingJUE,
		salJUE,
		ingVIE,
		salVIE,
		ingSAB,
		salSAB,
		ingDOM,
		salDOM,
		refriger,
		tolernc,
		diaDesc,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		'INSERT', 
		GETDATE()
		FROM inserted;
END;

GO
CREATE TRIGGER tr_HorarioActualizar
	ON Tb_Horario
	AFTER UPDATE
	AS
	BEGIN
		INSERT INTO Tb_Horario_Audit
		(codHorario,
		desHorario,
		ingLUN,
		salLUN,
		ingMAR,
		salMAR,
		ingMIE,
		salMIE,
		ingJUE,
		salJUE,
		ingVIE,
		salVIE,
		ingSAB,
		salSAB,
		ingDOM,
		salDOM,
		refriger,
		tolernc,
		diaDesc,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		accion, 
		fec_HorAccion)
		SELECT
		codHorario,
		desHorario,
		ingLUN,
		salLUN,
		ingMAR,
		salMAR,
		ingMIE,
		salMIE,
		ingJUE,
		salJUE,
		ingVIE,
		salVIE,
		ingSAB,
		salSAB,
		ingDOM,
		salDOM,
		refriger,
		tolernc,
		diaDesc,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		'UPDATE', 
		GETDATE()
		FROM deleted;
END;

GO
CREATE TRIGGER tr_HorarioEliminar
	ON Tb_Horario
	AFTER DELETE
	AS
	BEGIN
		INSERT INTO Tb_Horario_Audit
		(codHorario,
		desHorario,
		ingLUN,
		salLUN,
		ingMAR,
		salMAR,
		ingMIE,
		salMIE,
		ingJUE,
		salJUE,
		ingVIE,
		salVIE,
		ingSAB,
		salSAB,
		ingDOM,
		salDOM,
		refriger,
		tolernc,
		diaDesc,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		accion, 
		fec_HorAccion)
		SELECT
		codHorario,
		desHorario,
		ingLUN,
		salLUN,
		ingMAR,
		salMAR,
		ingMIE,
		salMIE,
		ingJUE,
		salJUE,
		ingVIE,
		salVIE,
		ingSAB,
		salSAB,
		ingDOM,
		salDOM,
		refriger,
		tolernc,
		diaDesc,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		'DELETE', 
		GETDATE()
		FROM deleted;
END;

-- MARCAS

GO
CREATE TRIGGER tr_MarcasInsertar
	ON Tb_Marcas
	AFTER INSERT
	AS
	BEGIN 
		INSERT INTO Tb_Marcas_Audit
		(codMarc,
		empleado,
		fecha,
		hora,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		accion, 
		fec_HorAccion
		)
		SELECT
		codMarc,
		empleado,
		fecha,
		hora,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		'INSERT', 
		GETDATE()
		FROM inserted;
	END;

GO
CREATE TRIGGER tr_MarcasActualizar
	ON Tb_Marcas
	AFTER UPDATE
	AS
	BEGIN 
		INSERT INTO Tb_Marcas_Audit
		(codMarc,
		empleado,
		fecha,
		hora,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		accion, 
		fec_HorAccion
		)
		SELECT
		codMarc,
		empleado,
		fecha,
		hora,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		'UPDATE', 
		GETDATE()
		FROM deleted;
	END;

GO
CREATE TRIGGER tr_MarcasEliminar
	ON Tb_Marcas
	AFTER DELETE
	AS
	BEGIN 
		INSERT INTO Tb_Marcas_Audit
		(codMarc,
		empleado,
		fecha,
		hora,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		accion, 
		fec_HorAccion
		)
		SELECT
		codMarc,
		empleado,
		fecha,
		hora,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod,
		'DELETE', 
		GETDATE()
		FROM deleted;
	END;
-- DIARIO	

GO 
CREATE TRIGGER tr_DiarioInsertar
	ON Tb_Diario
	AFTER INSERT 
	AS
	BEGIN 
		INSERT INTO Tb_Diario_Audit
		(codDiar,
		fecha,
		empleado,
		horario,
		hIngreso,
		hSalida,
		hora1,
		hora2,
		hora3,
		hora4,
		ingrTard,
		exeRefr,
		exeJornd,
		observ,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod ,
		accion, 
		fec_HorAccion)
		SELECT 
		codDiar,
		fecha,
		empleado,
		horario,
		hIngreso,
		hSalida,
		hora1,
		hora2,
		hora3,
		hora4,
		ingrTard,
		exeRefr,
		exeJornd,
		observ,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod ,
		'INSERT', 
		GETDATE()
		FROM inserted;
END;

GO 
CREATE TRIGGER tr_DiarioActualizar
	ON Tb_Diario
	AFTER UPDATE 
	AS
	BEGIN 
		INSERT INTO Tb_Diario_Audit
		(codDiar,
		fecha,
		empleado,
		horario,
		hIngreso,
		hSalida,
		hora1,
		hora2,
		hora3,
		hora4,
		ingrTard,
		exeRefr,
		exeJornd,
		observ,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod ,
		accion, 
		fec_HorAccion)
		SELECT 
		codDiar,
		fecha,
		empleado,
		horario,
		hIngreso,
		hSalida,
		hora1,
		hora2,
		hora3,
		hora4,
		ingrTard,
		exeRefr,
		exeJornd,
		observ,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod ,
		'UPDATE', 
		GETDATE()
		FROM deleted;
END;

GO
CREATE TRIGGER tr_DiarioEliminar
	ON Tb_Diario
	AFTER DELETE 
	AS
	BEGIN 
		INSERT INTO Tb_Diario_Audit
		(codDiar,
		fecha,
		empleado,
		horario,
		hIngreso,
		hSalida,
		hora1,
		hora2,
		hora3,
		hora4,
		ingrTard,
		exeRefr,
		exeJornd,
		observ,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod ,
		accion, 
		fec_HorAccion)
		SELECT 
		codDiar,
		fecha,
		empleado,
		horario,
		hIngreso,
		hSalida,
		hora1,
		hora2,
		hora3,
		hora4,
		ingrTard,
		exeRefr,
		exeJornd,
		observ,
		fec_Reg,
		usu_Reg,
		fec_UltMod,
		usu_UltMod ,
		'DELETE', 
		GETDATE()
		FROM deleted;
END;