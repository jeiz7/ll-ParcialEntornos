drop database IF EXISTS mantenimientoComputadoras;
GO

create database mantenimientoComputadoras;
GO

USE mantenimientoComputadoras;
GO


create table Direccion(
	id int identity,
	dirEmpleado char(5) primary key not null,
	departamento varchar(25) not null,
	municipio varchar(25) not null,
	barrio varchar(25) null,
	colonia varchar(25) null

);

create table computadorasAsignadas(
	id int identity,
	serviceTag char(10) primary key,
	marca varchar(25) not null,
	modelo varchar(25) not null,
	procesador varchar(25) not null,
	memoriaRAM int not null,
	tipoDisco varchar(25) not null, 
	tarjetaVideo varchar(25) not null,
	teclado varchar(25) not null,
	monitor varchar(25) not null	
	
);
create table empleados(
	id int identity,
	codigoEmpleado char(5) primary key not null,
	idComputadora char(10) not null, 
	identidadEmpleado varchar(25) not null,
	primerNombre varchar(25) not null, 
	segundoNombre varchar(25),
	primerApellido varchar(25),
	segundoApellido varchar(25),
	edadEmpleado Int not null,
	sexoEmpleado char(1) not null,
	puestoTrabajo varchar(25) not null,

	
    FOREIGN KEY (idComputadora) REFERENCES computadorasAsignadas(serviceTag)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

create table historialMantenimientos(
	id int primary key identity,
	id_Compu char(10), 
	dia varchar(25) null,
	tipoMantenimiento varchar(25) not null,
	componentesAfectados varchar(25) not null,
	otrosComponentes varchar(25),
	descripcion varchar(200) not null,


	FOREIGN KEY(id_Compu) references computadorasAsignadas(serviceTag)
	ON DELETE CASCADE
	ON UPDATE CASCADE

);


-- PROCEDIMIENTO PARA REGISTRAR UN NUEVO MANTENIMIENTO
--CREATE procedure registrarMantenimiento(@serialPC char(10), @dia varchar(25), @tipoMant varchar(25), @componentesAfectados varchar(25),@otrosComponentes varchar(25) , @descripcion varchar(200))

--as begin

--Insert into historialMantenimientos(id_Compu, dia, tipoMantenimiento, componentesAfectados, otrosComponentes , descripcion) values (@serialPC, @dia, @tipoMant, @componentesAfectados, @otrosComponentes , @descripcion)

--end


-- PROCEDIMIENTO PARA AGREGAR UN EMPLEADO
--CREATE procedure registrarEmpleado(@codigoEmpleado char(5), @idComputadora char(10), @identidadEmpleado varchar(25), @primerNombre varchar(25), @segundoNombre varchar(25), @primerApellido varchar(25), @segundoApellido varchar(25), @edadEmpleado int, @sexoEmpleado char(1), @puestoTrabajo varchar(25))

--as begin

--Insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) values (@codigoEmpleado, @idComputadora  , @identidadEmpleado, @primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @edadEmpleado, @sexoEmpleado, @puestoTrabajo)

--end

-- PROCEDIMIENTO PARA AGREGAR LA DIRECCION
--CREATE procedure registrarDireccion(@dirEmpleado char(5), @departamento varchar(25), @municipio varchar(25), @barrio varchar(25), @colonia varchar(25))

--as begin

--Insert into Direccion(dirEmpleado, departamento, municipio, barrio, colonia) values (@dirEmpleado, @departamento, @municipio, @barrio, @colonia)

--end


-- PROCEDIMIENTO PARA AGREGAR UNA COMPUTADORA
--CREATE procedure registrarComputadora(@serviceTag char(10), @marca varchar(25), @modelo varchar(25), @procesador varchar(25), @memoriaRAM int, @tipoDisco varchar(25), @tarjetaVideo varchar(25), @teclado varchar(25), @monitor varchar(25))

--as begin

--Insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor) values (@serviceTag, @marca, @modelo, @procesador, @memoriaRAM, @tipoDisco, @tarjetaVideo, @teclado, @monitor)

--end




-- PROCEDIMIENTO PARA ACTUALIZAR LOS DATOS DE LOS EMPLEADOS
--CREATE procedure actualizarEmpleado(@codigoEmpleado char(5), @idComputadora char(10), @identidadEmpleado varchar(25), @primerNombre varchar(25), @segundoNombre varchar(25), @primerApellido varchar(25), @segundoApellido varchar(25), @edadEmpleado int, @sexoEmpleado char(1), @puestoTrabajo varchar(25))

--as begin

--Update empleados Set codigoEmpleado = @codigoEmpleado, idComputadora = @idComputadora, identidadEmpleado = @identidadEmpleado, primerNombre = @primerNombre, segundoNombre = @segundoNombre, primerApellido = @primerApellido, segundoApellido = @segundoApellido, edadEmpleado = @edadEmpleado, sexoEmpleado = @sexoEmpleado, puestoTrabajo = @puestoTrabajo Where codigoEmpleado = @codigoEmpleado

--end

-- PROCEDIMIENTO PARA ACTUALIZAR LOS DATOS DE LA PC
--CREATE procedure actualizarComputadora(@serviceTag char(10), @marca varchar(25), @modelo varchar(25), @procesador varchar(25), @memoriaRAM int, @tipoDisco varchar(25), @tarjetaVideo varchar(25), @teclado varchar(25), @monitor varchar(25))

--as begin

--Update computadorasAsignadas Set serviceTag = @serviceTag, marca = @marca, modelo = @modelo, procesador = @procesador, memoriaRAM = @memoriaRAM,  tipoDisco = @tipoDisco, tarjetaVideo = @tarjetaVideo, teclado = @teclado, monitor = @monitor WHERE serviceTag = @serviceTag
--end

-- PROCEDIMIENTO PARA ACTUALIZAR LOS DATOS DE LA DIRECCION
--CREATE procedure actualizarDireccion(@dirEmpleado char(5), @departamento varchar(25), @municipio varchar(25), @barrio varchar(25), @colonia varchar(25))

--as begin

--Update Direccion Set dirEmpleado = @dirEmpleado, departamento = @departamento, municipio = @municipio, barrio = @barrio, colonia = @colonia WHERE dirEmpleado = @dirEmpleado
--end


--PROCEDIMIENTO PARA ELIMINAR UN REGISTRO DE EMPLEADO
--CREATE PROCEDURE eliminarRegistro(@codigoEmpleado char(5))

--as begin

--Delete from empleados WHERE codigoEmpleado = @codigoEmpleado
--Delete from Direccion WHERE dirEmpleado = @codigoEmpleado

--end

--PROCEDIMIENTO PARA ELIMINAR UN REGISTRO DE COMPUTADORA
--CREATE PROCEDURE eliminarRegistroPC(@serviceTag char(10))

--as begin

--Delete from computadorasAsignadas WHERE serviceTag = @serviceTag
--Delete from historialMantenimientos WHERE id_Compu = @serviceTag

--end
 
 
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC000','DELL','INSPIRON','AMD RYZEN 7',64,'SSD 500GB','AMD RADEON GRAPHICS','MECANICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC001','DELL','LATITUDE','INTEL I5',64,'SSD 2TB','NVIDIA QUADRO ','GENERICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC002','DELL','VOSTRO','AMD RYZEN 5',32,'SSD 2TB','AMD RADEON GRAPHICS','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC003','DELL','LATITUDE','AMD RYZEN 5',64,'SSD 500GB','NVIDIA QUADRO ','GENERICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC004','DELL','LATITUDE','INTEL XEON',32,'HDD 500GB','INTEL HD GRAPHICS','MECANICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC005','DELL','OPTIPLEX','AMD RYZEN 7',32,'SSD 500GB','AMD RADEON GRAPHICS','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC006','DELL','LATITUDE','INTEL XEON',32,'SSD 500GB','NVIDIA QUADRO ','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC007','DELL','INSPIRON','INTEL I7',16,'HDD 1TB','AMD RADEON GRAPHICS','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC008','DELL','OPTIPLEX','INTEL XEON',32,'SSD 2TB','INTEL HD GRAPHICS','MECANICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC009','DELL','VOSTRO','AMD FX 5000',16,'HDD 1TB','INTEL HD GRAPHICS','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC010','DELL','INSPIRON','INTEL I5',16,'HDD 500GB','NVIDIA QUADRO ','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC011','DELL','OPTIPLEX','INTEL XEON',16,'HDD 500GB','INTEL HD GRAPHICS','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC012','DELL','INSPIRON','INTEL I5',64,'HDD 1TB','AMD RADEON GRAPHICS','MECANICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC013','DELL','LATITUDE','INTEL I7',32,'HDD 500GB','NVIDIA QUADRO ','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC014','DELL','VOSTRO','INTEL I5',32,'HDD 500GB','NVIDIA QUADRO ','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC015','DELL','OPTIPLEX','INTEL I7',64,'HDD 500GB','AMD RADEON GRAPHICS','GENERICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC016','DELL','INSPIRON','INTEL I7',64,'HDD 500GB','INTEL HD GRAPHICS','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC017','DELL','INSPIRON','AMD RYZEN 7',16,'HDD 500GB','INTEL HD GRAPHICS','MECANICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC018','DELL','LATITUDE','AMD FX 5000',16,'SSD 2TB','AMD RADEON GRAPHICS','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC019','DELL','VOSTRO','AMD RYZEN 7',32,'SSD 2TB','AMD RADEON GRAPHICS','MECANICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC020','DELL','VOSTRO','INTEL I5',64,'SSD 500GB','NVIDIA QUADRO ','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC021','DELL','OPTIPLEX','INTEL I7',64,'HDD 1TB','NVIDIA QUADRO ','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC022','DELL','VOSTRO','INTEL I7',16,'SSD 500GB','NVIDIA QUADRO ','GENERICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC023','DELL','LATITUDE','AMD FX 5000',32,'HDD 500GB','AMD RADEON GRAPHICS','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC024','DELL','OPTIPLEX','INTEL I5',64,'SSD 2TB','INTEL HD GRAPHICS','MECANICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC025','DELL','INSPIRON','INTEL XEON',64,'HDD 500GB','AMD RADEON GRAPHICS','BACKLIGHT','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC026','DELL','OPTIPLEX','INTEL I5',64,'HDD 1TB','AMD RADEON GRAPHICS','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC027','DELL','OPTIPLEX','INTEL XEON',32,'SSD 500GB','NVIDIA QUADRO ','GENERICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC028','DELL','VOSTRO','AMD RYZEN 7',32,'HDD 500GB','NVIDIA QUADRO ','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC029','DELL','LATITUDE','INTEL I7',32,'SSD 500GB','AMD RADEON GRAPHICS','GENERICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC030','DELL','OPTIPLEX','AMD FX 5000',64,'HDD 500GB','AMD RADEON GRAPHICS','GENERICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC031','DELL','INSPIRON','INTEL XEON',64,'HDD 500GB','INTEL HD GRAPHICS','MEMBRANA','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC032','DELL','OPTIPLEX','AMD FX 5000',64,'HDD 1TB','NVIDIA QUADRO ','MECANICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC033','DELL','VOSTRO','AMD FX 5000',64,'HDD 1TB','NVIDIA QUADRO ','GENERICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC034','HP','PAVILION','AMD RYZEN 5',64,'HDD 500GB','NVIDIA QUADRO ','GENERICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC035','HP','PAVILION','AMD FX 5000',16,'HDD 1TB','NVIDIA QUADRO ','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC036','HP','PAVILION','INTEL XEON',32,'SSD 500GB','INTEL HD GRAPHICS','MEMBRANA','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC037','HP','SPECTRE','AMD RYZEN 5',64,'HDD 1TB','INTEL HD GRAPHICS','MEMBRANA','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC038','HP','SPECTRE','AMD RYZEN 7',32,'HDD 1TB','NVIDIA QUADRO ','GENERICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC039','HP','ENVY','AMD RYZEN 5',16,'SSD 2TB','AMD RADEON GRAPHICS','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC040','HP','PAVILION','INTEL I5',16,'SSD 500GB','NVIDIA QUADRO ','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC041','HP','PAVILION','INTEL I5',16,'SSD 500GB','AMD RADEON GRAPHICS','MEMBRANA','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC042','HP','PAVILION','AMD RYZEN 7',32,'SSD 2TB','AMD RADEON GRAPHICS','GENERICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC043','HP','SPECTRE','AMD RYZEN 5',16,'HDD 1TB','NVIDIA QUADRO ','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC044','HP','SPECTRE','INTEL I7',32,'HDD 500GB','AMD RADEON GRAPHICS','GENERICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC045','HP','ENVY','INTEL I7',32,'SSD 2TB','INTEL HD GRAPHICS','MECANICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC046','HP','SPECTRE','AMD RYZEN 7',16,'SSD 500GB','INTEL HD GRAPHICS','BACKLIGHT','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC047','HP','ENVY','AMD FX 5000',16,'SSD 500GB','INTEL HD GRAPHICS','MEMBRANA','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC048','HP','ENVY','AMD RYZEN 7',64,'SSD 500GB','INTEL HD GRAPHICS','MECANICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC049','HP','PAVILION','INTEL I7',32,'SSD 2TB','AMD RADEON GRAPHICS','BACKLIGHT','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC050','HP','ENVY','AMD FX 5000',16,'SSD 2TB','INTEL HD GRAPHICS','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC051','HP','ENVY','INTEL I7',64,'HDD 1TB','NVIDIA QUADRO ','GENERICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC052','HP','SPECTRE','INTEL I5',32,'SSD 500GB','NVIDIA QUADRO ','MECANICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC053','HP','ENVY','AMD RYZEN 7',32,'SSD 500GB','NVIDIA QUADRO ','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC054','HP','PAVILION','AMD RYZEN 5',64,'SSD 2TB','NVIDIA QUADRO ','MEMBRANA','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC055','HP','SPECTRE','INTEL I5',64,'HDD 500GB','AMD RADEON GRAPHICS','MECANICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC056','HP','PAVILION','AMD RYZEN 7',16,'HDD 500GB','AMD RADEON GRAPHICS','MEMBRANA','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC057','HP','SPECTRE','AMD RYZEN 7',64,'HDD 1TB','INTEL HD GRAPHICS','MEMBRANA','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC058','HP','ENVY','AMD RYZEN 5',64,'HDD 500GB','INTEL HD GRAPHICS','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC059','HP','PAVILION','AMD FX 5000',32,'SSD 500GB','INTEL HD GRAPHICS','BACKLIGHT','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC060','HP','PAVILION','AMD RYZEN 5',64,'HDD 1TB','AMD RADEON GRAPHICS','MECANICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC061','HP','ENVY','AMD RYZEN 5',64,'HDD 1TB','NVIDIA QUADRO ','BACKLIGHT','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC062','HP','ENVY','INTEL I5',32,'HDD 1TB','NVIDIA QUADRO ','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC063','HP','SPECTRE','INTEL I7',32,'HDD 500GB','INTEL HD GRAPHICS','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC064','HP','SPECTRE','INTEL XEON',32,'SSD 2TB','NVIDIA QUADRO ','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC065','HP','PAVILION','AMD RYZEN 5',32,'HDD 500GB','NVIDIA QUADRO ','MECANICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC066','HP','PAVILION','AMD RYZEN 7',32,'HDD 500GB','INTEL HD GRAPHICS','GENERICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC067','LENOVO','THINKCENTRE','AMD RYZEN 5',16,'SSD 500GB','INTEL HD GRAPHICS','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC068','LENOVO','THINKCENTRE','AMD FX 5000',64,'HDD 1TB','NVIDIA QUADRO ','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC069','LENOVO','THINKCENTRE','INTEL XEON',64,'SSD 2TB','AMD RADEON GRAPHICS','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC070','LENOVO','IDEAPAD','INTEL XEON',16,'HDD 1TB','INTEL HD GRAPHICS','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC071','LENOVO','THINKCENTRE','INTEL I7',64,'HDD 500GB','AMD RADEON GRAPHICS','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC072','LENOVO','THINKCENTRE','AMD FX 5000',16,'SSD 500GB','INTEL HD GRAPHICS','BACKLIGHT','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC073','LENOVO','THINKPAD','AMD RYZEN 7',64,'SSD 2TB','AMD RADEON GRAPHICS','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC074','LENOVO','THINKCENTRE','INTEL I7',32,'HDD 1TB','INTEL HD GRAPHICS','GENERICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC075','LENOVO','THINKPAD','INTEL XEON',16,'SSD 2TB','NVIDIA QUADRO ','MECANICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC076','LENOVO','THINKPAD','INTEL XEON',64,'SSD 500GB','NVIDIA QUADRO ','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC077','LENOVO','IDEAPAD','INTEL I5',16,'SSD 2TB','NVIDIA QUADRO ','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC078','LENOVO','IDEAPAD','INTEL I5',32,'HDD 1TB','NVIDIA QUADRO ','BACKLIGHT','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC079','LENOVO','IDEAPAD','INTEL I5',32,'HDD 1TB','AMD RADEON GRAPHICS','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC080','LENOVO','THINKCENTRE','AMD RYZEN 7',64,'SSD 2TB','NVIDIA QUADRO ','MEMBRANA','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC081','LENOVO','THINKCENTRE','INTEL I7',32,'SSD 2TB','AMD RADEON GRAPHICS','MECANICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC082','LENOVO','IDEAPAD','AMD FX 5000',16,'SSD 2TB','INTEL HD GRAPHICS','GENERICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC083','LENOVO','THINKCENTRE','INTEL I7',16,'HDD 500GB','NVIDIA QUADRO ','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC084','LENOVO','THINKPAD','AMD FX 5000',16,'SSD 500GB','NVIDIA QUADRO ','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC085','LENOVO','THINKPAD','INTEL XEON',16,'HDD 500GB','AMD RADEON GRAPHICS','GENERICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC086','LENOVO','THINKCENTRE','INTEL I5',32,'SSD 500GB','INTEL HD GRAPHICS','GENERICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC087','LENOVO','IDEAPAD','AMD FX 5000',64,'SSD 2TB','AMD RADEON GRAPHICS','GENERICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC088','LENOVO','THINKCENTRE','INTEL XEON',32,'SSD 500GB','NVIDIA QUADRO ','MEMBRANA','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC089','LENOVO','THINKPAD','AMD RYZEN 7',64,'SSD 2TB','AMD RADEON GRAPHICS','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC090','LENOVO','THINKCENTRE','INTEL XEON',64,'SSD 2TB','AMD RADEON GRAPHICS','MEMBRANA','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC091','LENOVO','THINKCENTRE','AMD FX 5000',64,'HDD 500GB','NVIDIA QUADRO ','BACKLIGHT','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC092','LENOVO','THINKCENTRE','AMD RYZEN 5',32,'HDD 1TB','AMD RADEON GRAPHICS','BACKLIGHT','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC093','LENOVO','IDEAPAD','INTEL XEON',16,'SSD 2TB','NVIDIA QUADRO ','MECANICO','RETINA');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC094','LENOVO','THINKCENTRE','INTEL I7',16,'HDD 500GB','AMD RADEON GRAPHICS','MEMBRANA','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC095','LENOVO','THINKCENTRE','AMD RYZEN 5',64,'HDD 500GB','INTEL HD GRAPHICS','MECANICO','FHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC096','LENOVO','THINKPAD','AMD RYZEN 7',16,'SSD 500GB','AMD RADEON GRAPHICS','MECANICO','TACTIL');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC097','LENOVO','IDEAPAD','AMD RYZEN 7',64,'HDD 500GB','NVIDIA QUADRO ','MECANICO','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC098','LENOVO','IDEAPAD','AMD RYZEN 7',16,'HDD 1TB','INTEL HD GRAPHICS','BACKLIGHT','UHD');
--insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor)  VALUES('PC099','LENOVO','THINKPAD','INTEL I5',64,'SSD 2TB','NVIDIA QUADRO ','MEMBRANA','RETINA');


--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00000','PC000', '1001200100000', 'NASH','WADE','RODRIGUEZ','POWERS',31,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00001','PC001', '1001200100001', 'RAYMOND','REGAN','GOFF','RASMUSSEN',40,'N','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00002','PC002', '1001200100002', 'XAVIER','GARRETT','SANTOS','MORGAN',27,'M','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00003','PC003', '1001200100003', 'ORLA','FELIX','SPENCER','WALLS',35,'M','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00004','PC004', '1001200100004', 'DANTE','KELLY','AGUILAR','KENNEDY',20,'F','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00005','PC005', '1001200100005', 'PHELAN','OREN','HOLMES','LIVINGSTON',41,'N','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00006','PC006', '1001200100006', 'KADEEM','BRIANNA','OWEN','TUCKER',39,'M','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00007','PC007', '1001200100007', 'CLARE','KYLIE','KANE','HUFFMAN',29,'M','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00008','PC008', '1001200100008', 'TROY','DALE','GUTHRIE','FLEMING',37,'F','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00009','PC009', '1001200100009', 'ARISTOTLE','REESE','CALHOUN','VALDEZ',28,'M','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00010','PC010', '1001200100010', 'KARLY','NASH','JOYNER','COLEMAN',24,'N','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00011','PC011', '1001200100011', 'THANE','ALVIN','FINCH','YOUNG',24,'M','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00012','PC012', '1001200100012', 'DALTON','GIACOMO','MCCARTHY','MALONE',38,'F','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00013','PC013', '1001200100013', 'XYLA','PRISCILLA','PEREZ','HAWKINS',26,'M','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00014','PC014', '1001200100014', 'NOBLE','KELSIE','BURKS','BARRETT',34,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00015','PC015', '1001200100015', 'WARREN','BRENT','MALONE','CLEMENTS',40,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00016','PC016', '1001200100016', 'ZEPHANIA','CONSTANCE','LE','DONOVAN',23,'N','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00017','PC017', '1001200100017', 'KIAYADA','BLAIR','CARNEY','HERMAN',32,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00018','PC018', '1001200100018', 'NOLAN','NOLAN','SHORT','COLLIER',39,'F','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00019','PC019', '1001200100019', 'JUDAH','THEODORE','LE','CASH',25,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00020','PC020', '1001200100020', 'CHANNING','DUNCAN','DELACRUZ','FROST',42,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00021','PC021', '1001200100021', 'BLYTHE','MOHAMMAD','GARRETT','MARQUEZ',28,'N','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00022','PC022', '1001200100022', 'GUY','JADA','BUCKLEY','MCDANIEL',33,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00023','PC023', '1001200100023', 'COLTON','ELMO','BLACKWELL','GLENN',23,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00024','PC024', '1001200100024', 'GIL','JULIE','KEMP','SHARPE',28,'M','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00025','PC025', '1001200100025', 'ALAN','DANIEL','DRAKE','VALENCIA',20,'M','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00026','PC026', '1001200100026', 'MERRILL','SERINA','MORSE','EATON',41,'F','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00027','PC027', '1001200100027', 'HILARY','LILA','WALLACE','DICKSON',32,'N','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00028','PC028', '1001200100028', 'ELIANA','XANDRA','GRAY','HOWE',28,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00029','PC029', '1001200100029', 'LAURA','ELLA','DILLON','LEE',21,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00030','PC030', '1001200100030', 'LEE','CHARITY','BREWER','ADKINS',26,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00031','PC031', '1001200100031', 'AARON','JACKSON','YATES','MUELLER',43,'F','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00032','PC032', '1001200100032', 'KEVYN','SCARLETT','POLLARD','SERRANO',23,'F','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00033','PC033', '1001200100033', 'MELODIE','ALFONSO','MCCONNELL','HAMPTON',42,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00034','PC034', '1001200100034', 'TYLER','XAVIER','MOSES','WARNER',27,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00035','PC035', '1001200100035', 'DEREK','NASH','KIDD','BEACH',43,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00036','PC036', '1001200100036', 'ANJOLIE','MAXWELL','DILLARD','CARR',21,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00037','PC037', '1001200100037', 'OLGA','CANDICE','WALSH','BRAY',21,'F','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00038','PC038', '1001200100038', 'PAUL','EMERALD','MARQUEZ','SNOW',45,'N','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00039','PC039', '1001200100039', 'CASSANDRA','HEDDA','HANCOCK','FULLER',21,'N','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00040','PC040', '1001200100040', 'VENUS','HANNA','GARRISON','BREWER',27,'F','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00041','PC041', '1001200100041', 'GERALDINE','ORLANDO','BLEVINS','MCGEE',44,'N','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00042','PC042', '1001200100042', 'JESCIE','KARLEIGH','LARSEN','SARGENT',21,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00043','PC043', '1001200100043', 'COLETTE','MELISSA','SEXTON','MCCOY',25,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00044','PC044', '1001200100044', 'LACEY','AMAL','GRIFFITH','TERRELL',21,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00045','PC045', '1001200100045', 'KYLE','JENETTE','SPENCER','CARLSON',19,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00046','PC046', '1001200100046', 'TANNER','HAMILTON','DAY','SOLIS',25,'M','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00047','PC047', '1001200100047', 'NITA','SHANNON','CAMPBELL','HAYNES',25,'N','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00048','PC048', '1001200100048', 'AMENA','LYSANDRA','BARRY','LYNCH',43,'N','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00049','PC049', '1001200100049', 'BERK','SERENA','GOOD','VINCENT',33,'F','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00050','PC050', '1001200100050', 'GREGORY','IOLA','PEARSON','DAVID',42,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00051','PC051', '1001200100051', 'TAD','GIACOMO','CANTU','SAVAGE',32,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00052','PC052', '1001200100052', 'KENNETH','YOKO','PEREZ','HUFFMAN',19,'F','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00053','PC053', '1001200100053', 'LINUS','BENJAMIN','SNIDER','MEYERS',28,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00054','PC054', '1001200100054', 'MELODIE','ORA','SUTTON','DICKSON',23,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00055','PC055', '1001200100055', 'URIELLE','CHEROKEE','BARTON','EVERETT',33,'F','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00056','PC056', '1001200100056', 'OLYMPIA','CEDRIC','CONWAY','COBB',33,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00057','PC057', '1001200100057', 'SUSAN','KYLE','RICHMOND','SYKES',37,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00058','PC058', '1001200100058', 'LYNN','AMANDA','OLIVER','VANG',45,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00059','PC059', '1001200100059', 'BREE','LINDA','WRIGHT','BARNES',32,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00060','PC060', '1001200100060', 'FORREST','OCTAVIA','FLYNN','ALVARADO',36,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00061','PC061', '1001200100061', 'FELIX','COOPER','EDWARDS','SAWYER',33,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00062','PC062', '1001200100062', 'KAREEM','HILLARY','TERRY','HERMAN',41,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00063','PC063', '1001200100063', 'ODESSA','ARSENIO','BEAN','VELAZQUEZ',33,'F','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00064','PC064', '1001200100064', 'MARIAM','AQUILA','GENTRY','WILEY',19,'F','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00065','PC065', '1001200100065', 'JAMAL','BEVERLY','MARTIN','GAINES',30,'M','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00066','PC066', '1001200100066', 'MAGGY','CALLUM','ROWLAND','FIELDS',24,'M','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00067','PC067', '1001200100067', 'ABRAHAM','TALON','STEVENS','RASMUSSEN',38,'N','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00068','PC068', '1001200100068', 'JORDAN','INA','STUART','MCLEOD',33,'F','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00069','PC069', '1001200100069', 'REUBEN','IGNACIA','WRIGHT','YANG',25,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00070','PC070', '1001200100070', 'WYLIE','COLBY','MERRITT','DILLON',21,'M','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00071','PC071', '1001200100071', 'GERALDINE','LANCE','ACOSTA','INGRAM',23,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00072','PC072', '1001200100072', 'CHANTALE','WYLIE','LEWIS','WILKINSON',40,'F','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00073','PC073', '1001200100073', 'HASHIM','UNITY','MORSE','LESTER',33,'F','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00074','PC074', '1001200100074', 'RICHARD','AXEL','AYERS','MCKEE',39,'N','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00075','PC075', '1001200100075', 'JONAH','ALFREDA','WOODARD','LLOYD',36,'M','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00076','PC076', '1001200100076', 'THOR','ALEA','REED','PETERSEN',44,'M','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00077','PC077', '1001200100077', 'MAXWELL','MAGGY','NEWMAN','DOUGLAS',36,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00078','PC078', '1001200100078', 'THADDEUS','CLARK','DORSEY','HUNTER',31,'N','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00079','PC079', '1001200100079', 'AUBREY','AUDRA','GALLEGOS','HEATH',41,'N','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00080','PC080', '1001200100080', 'ADELE','EATON','KIM','KIRBY',25,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00081','PC081', '1001200100081', 'COLIN','NOELANI','GREER','KIRK',45,'F','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00082','PC082', '1001200100082', 'STEWART','QUINN','EDWARDS','BROWN',40,'N','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00083','PC083', '1001200100083', 'JOEL','DEAN','BRADY','WEISS',19,'F','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00084','PC084', '1001200100084', 'ROONEY','JACK','LEACH','BEST',30,'M','PUBLICIDAD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00085','PC085', '1001200100085', 'CURRAN','NADINE','MACK','DODSON',32,'N','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00086','PC086', '1001200100086', 'ROSS','RHIANNON','WORKMAN','WADE',29,'F','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00087','PC087', '1001200100087', 'DEXTER','HADASSAH','CALLAHAN','LANDRY',23,'N','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00088','PC088', '1001200100088', 'BARRETT','PORTER','JOSEPH','PHILLIPS',28,'F','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00089','PC089', '1001200100089', 'GARETH','ALEXANDER','ROMAN','ODOM',38,'N','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00090','PC090', '1001200100090', 'YARDLEY','WYATT','SIMON','TERRY',44,'M','MANTENIMIENTO BD')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00091','PC091', '1001200100091', 'BRIAR','YASIR','BARLOW','WALTER',34,'N','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00092','PC092', '1001200100092', 'LACOTA','INEZ','HARPER','COOPER',22,'F','PROGRAMADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00093','PC093', '1001200100093', 'ASPEN','MAXWELL','ORTIZ','HENSLEY',28,'M','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00094','PC094', '1001200100094', 'NATHANIEL','CAMILLA','VINSON','HENDRIX',43,'F','SUPERVISOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00095','PC095', '1001200100095', 'CALLUM','TYLER','RASMUSSEN','MORROW',30,'M','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00096','PC096', '1001200100096', 'COBY','MALACHI','TAYLOR','ROSALES',26,'F','GERENTE')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00097','PC097', '1001200100097', 'EMILY','TANA','WALL','HARMON',37,'M','GERENTE')                                                       
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00098','PC098', '1001200100098', 'FLETCHER','JOEL','DUNLAP','WILLIAM',19,'N','DISENADOR')
--insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) VALUES ('00099','PC099', '1001200100099', 'CARA','CODY','BAKER','HENDRIX',35,'N','GERENTE')


--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00000','EL PARAÍSO','SAN JOSÉ DE COMAYAGUA','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00001','FRANCISCO MORAZÁN','OTORO','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00002','SELECCIONE','ESQUÍAS','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00003','CHOLUTECA','LEJAMANÍ','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00004','BÁRBARA','LAMANÍ','EL TEJAR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00005','LA PAZ','SAN SEBASTIÁN','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00006','BÁRBARA','EL ROSARIO','CENTRO','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00007','BÁRBARA','SAN JOSÉ DE COMAYAGUA','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00008','OCOTEPEQUE','AJUTERIQUE','SAN MIGUEL','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00009','COLÓN','AJUTERIQUE','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00010','LEMPIRA','COMAYAGUA','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00011','YORO','COMAYAGUA','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00012','INTIBUCA','SAN SEBASTIÁN','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00013','YORO','LA TRINIDAD','CENTRO','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00014','COLÓN','LA ESPERANZA','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00015','SELECCIONE','LAMANÍ','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00016','LA PAZ','SAN JOSÉ DEL POTRERO','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00017','CORTÉS','SAN LUIS','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00018','YORO','SAN JOSÉ DEL POTRERO','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00019','VALLE','SAN JERÓNIMO','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00020','EL PARAÍSO','MEÁMBAR','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00021','COLÓN','SAN JOSÉ DEL POTRERO','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00022','COLÓN','LAMANÍ','SAN MIGUEL','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00023','COMAYAGUA','SIGUATEPEQUE','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00024','CORTÉS','EL ROSARIO','CENTRO','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00025','VALLE','SAN SEBASTIÁN','LEMPIRA','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00026','BÁRBARA','ESQUÍAS','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00027','LEMPIRA','LAMANÍ','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00028','VALLE','OTORO','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00029','CHOLUTECA','SAN JOSÉ DEL POTRERO','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00030','CORTÉS','MEÁMBAR','SUR','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00031','OLANCHO','SAN JOSÉ DE COMAYAGUA','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00032','YORO','OTORO','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00033','OLANCHO','SAN JOSÉ DE COMAYAGUA','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00034','BÁRBARA','LEJAMANÍ','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00035','VALLE','LA TRINIDAD','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00036','CORTÉS','OJOS DE AGUA','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00037','COMAYAGUA','MINAS DE ORO','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00038','LA PAZ','LAS LAJAS','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00039','OCOTEPEQUE','SIGUATEPEQUE','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00040','COPÁN','SAN JOSÉ DEL POTRERO','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00041','COPÁN','SAN JOSÉ DEL POTRERO','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00042','SANTA','LAS LAJAS','LEMPIRA','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00043','SANTA','LA TRINIDAD','EL TEJAR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00044','INTIBUCA','LAS LAJAS','LEMPIRA','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00045','INTIBUCA','LAS LAJAS','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00046','LEMPIRA','ESQUÍAS','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00047','OCOTEPEQUE','MEÁMBAR','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00048','LA PAZ','SAN LUIS','SAN MIGUEL','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00049','COMAYAGUA','OTORO','CENTRO','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00050','INTIBUCA','AJUTERIQUE','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00051','COPÁN','LAS LAJAS','EL TEJAR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00052','LEMPIRA','SAN JOSÉ DE COMAYAGUA','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00053','CORTÉS','MINAS DE ORO','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00054','SELECCIONE','SAN LUIS','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00055','LA PAZ','SAN JERÓNIMO','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00056','BÁRBARA','ESQUÍAS','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00057','VALLE','EL ROSARIO','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00058','COMAYAGUA','ESQUÍAS','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00059','OLANCHO','LAMANÍ','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00060','COMAYAGUA','SAN JOSÉ DEL POTRERO','EL TEJAR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00061','COLÓN','OJOS DE AGUA','LEMPIRA','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00062','YORO','LAS LAJAS','CENTRO','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00063','ISLAS DE LA BAHÍA','OTORO','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00064','VALLE','COMAYAGUA','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00065','ATLÁNTIDA','TEGUCIGALPA','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00066','EL PARAÍSO','ESQUÍAS','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00067','YORO','SAN SEBASTIÁN','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00068','EL PARAÍSO','LEJAMANÍ','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00069','FRANCISCO MORAZÁN','SAN LUIS','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00070','COMAYAGUA','LAMANÍ','SAN MIGUEL','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00071','OLANCHO','LAMANÍ','SAN MIGUEL','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00072','FRANCISCO MORAZÁN','LA LIBERTAD','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00073','OCOTEPEQUE','HUMUYA','EL TEJAR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00074','COLÓN','TAULABÉ','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00075','CHOLUTECA','LA LIBERTAD','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00076','YORO','LAS LAJAS','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00077','GRACIAS A DIOS','OTORO','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00078','CORTÉS','MINAS DE ORO','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00079','ISLAS DE LA BAHÍA','LA TRINIDAD','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00080','COPÁN','MINAS DE ORO','SAN MIGUEL','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00081','INTIBUCA','SAN JOSÉ DEL POTRERO','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00082','ISLAS DE LA BAHÍA','TAULABÉ','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00083','SANTA','TEGUCIGALPA','CENTRO','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00084','SANTA','SAN SEBASTIÁN','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00085','BÁRBARA','TEGUCIGALPA','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00086','COMAYAGUA','SAN JOSÉ DEL POTRERO','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00087','OLANCHO','HUMUYA','EL TEJAR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00088','LEMPIRA','LAMANÍ','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00089','INTIBUCA','LAMANÍ','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00090','CORTÉS','LAMANÍ','EL TEJAR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00091','YORO','EL ROSARIO','NORTE','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00092','SANTA','LA TRINIDAD','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00093','VALLE','OTORO','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00094','ATLÁNTIDA','TEGUCIGALPA','','CENTRO');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00095','BÁRBARA','TAULABÉ','SUR','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00096','LEMPIRA','ESQUÍAS','','NORTE');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00097','VALLE','SAN LUIS','LEMPIRA','');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00098','BÁRBARA','YAMARANGUILA','','SUR');
--INSERT INTO Direccion(dirEmpleado, departamento, municipio, barrio, colonia) VALUES('00099','OLANCHO','SAN JERÓNIMO','','NORTE');


