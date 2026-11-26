create database MAMUT  
use MAMUT  
create table PROVEEDOR( 
IdProveedor int identity(1,1) primary key, 
Nombre varchar(40), 
Telefono varchar(30), 
Direccion varchar(40), 
TipoProv varchar(30) 
);  
create table ALMACEN( 
IdAlmacen int identity(1,1) primary key, 
Nombre varchar(40), 
Ubicacion varchar(40), 
Descripcion varchar(40) 
);  
create table PERSONAL( 
IdPersonal int identity(1,1) primary key, 
Nombre varchar(30), 
Apellido_Paterno varchar(30), 
Apellido_Materno varchar(30), 
Cargo varchar(30), 
Usuario varchar(30) unique, 
Password varchar(40) 
);  
create table MATERIAL( 
IdMaterial int identity(1,1) primary key, 
IdProveedor int, 
IdPersonal int, 
TipoMaterial varchar(40), 
Estado varchar(30), 
CantidadKg decimal(10,2), FechaRecep date, 
foreign key(IdProveedor) references PROVEEDOR(IdProveedor), foreign key(IdPersonal) references PERSONAL(IdPersonal) 
);  
create table LOTE_DE_CAUCHO( 
IdLote varchar(10) primary key, 
IdAlmacen int, 
Calidad varchar(30), PesoKg decimal(10,2), 
foreign key(IdAlmacen) references ALMACEN(IdAlmacen) 
);  
create table GENERA( 
IdMaterial int, 
IdLote varchar(10), 
FechaElabo date, 
primary key(IdMaterial, IdLote), 
foreign key(IdMaterial) references MATERIAL(IdMaterial), foreign key(IdLote) references LOTE_DE_CAUCHO(IdLote) 
);  
create table MOVIMIENTO( 
IdMovimiento varchar(10) primary key, 
IdLote varchar(10), 
IdPersonal int, 
CantidadMovida decimal(10,2), 
FechaMovimiento datetime, TipoMovimiento varchar(30), 
foreign key(IdLote) references LOTE_DE_CAUCHO(IdLote), foreign key(IdPersonal) references PERSONAL(IdPersonal) 
); 
create table REPORTES(
COD_reporte int identity (1,1) primary key,
IdPersonal int, --
usuario varchar (30),--
Tipo_de_reporte varchar(30) not null,
nombre_de_reporte varchar(100) not null,
detalle_de_reporte varchar(500)not null,
Fecha date not null,
CONSTRAINT FK_REPORTES_PERSONAL FOREIGN KEY (IdPersonal) REFERENCES PERSONAL(IdPersonal)
);


---inserts de cada tabla ---- 
  
insert into PROVEEDOR (Nombre, Telefono, Direccion, TipoProv)
values ('Luis Mamani', '71234567', 'Calle 12 de Octubre #10', 'Mecánico'), 
('Mario Quispe', '79876543', 'Av. Panorámica #500', 'Mecánico'), 
('Llantería El Rápido', '70011223', 'Carretera a Viacha km 4', 'Llantería'), 
('Jorge Condori', '72345678', 'Av. 6 de Marzo #890', 'Mecánico'), 
('Llantería San José', '73456789', 'Av. Sucre #215', 'Llantería'); 
 
insert into ALMACEN (Nombre, Ubicacion, Descripcion) values 
('Almacen Principal', 'Planta Norte', 'Recepcion y acopio de llantas'), 
('Almacen Despacho', 'Planta Sur', 'Lotes listos para distribucion'), 
('Almacen Triturado', 'Planta Norte', 'Caucho triturado en proceso'), 
('Almacen Insumos', 'Planta Central', 'Aditivos y materiales auxiliares'), 
('Almacen Reserva', 'Planta Sur', 'Stock de seguridad de caucho'); 
 
insert into PERSONAL (Nombre, Apellido_Paterno, Apellido_Materno, Cargo, Usuario, Password) values 
('Kevin','choquetarqui','Blanco','tecnico de sistemas','admin','1234'),
('Carlos', 'Mamani', 'Ticona', 'Encargado', 'cmamani', 'clave123'), 
('Lucia', 'Quispe', 'Mamani', 'Supervisor', 'lquispe', 'clave456'), 
('Diego', 'Flores', 'Choque', 'Operador', 'dflores', 'clave789'), 
('Ana', 'Choque', 'Colque', 'Almacenera', 'achoque', 'clave321'), 
('Pedro', 'Apaza', 'Gutierrez', 'Operador', 'papaza', 'clave654'); 

 
insert into MATERIAL (IdProveedor, IdPersonal, TipoMaterial, Estado, CantidadKg, 
FechaRecep) values 
(1, 1, 'Neumatico usado', 'Disponible', 180.00, '2026-11-10'), 
(2, 1, 'Neumatico usado', 'Disponible', 140.50, '2026-11-11'), 
(3, 4, 'Neumatico usado', 'Disponible', 320.00, '2026-11-12'), 
(4, 3, 'Caucho molido', 'En proceso', 95.25, '2026-11-13'), 
(5, 4, 'Neumatico usado', 'Disponible', 210.75, '2026-11-14'); 
 
insert into LOTE_DE_CAUCHO values 
('L1', 1, 'Alta', 150.00), 
('L2', 2, 'Media', 120.00), 
('L3', 3, 'Alta', 250.00), 
('L4', 2, 'Baja', 85.50), 
('L5', 5, 'Alta', 190.00); 
 
insert into GENERA values (1, 'L1', '2026-11-15'), 
(2, 'L2', '2026-11-15'), 
(3, 'L3', '2026-11-16'), 
(4, 'L4', '2026-11-16'), 
(5, 'L5', '2026-11-17'); 
 
insert into MOVIMIENTO values 
('MO1', 'L1', 2, 75.00, '2026-11-17 09:30:00', 'Salida'), 
('MO2', 'L2', 2, 50.00, '2026-11-17 11:00:00', 'Traslado'), 
('MO3', 'L3', 1, 100.00, '2026-11-18 08:45:00', 'Ingreso'), 
('MO4', 'L4', 4, 40.50, '2026-11-18 15:20:00', 'Salida'), 
('MO5', 'L5', 2, 90.00, '2026-11-19 10:10:00', 'Traslado'); 

INSERT INTO REPORTES VALUES
(1,'admin', 'REPORTE DE ERROR DE SISTEMA', 'error al cerrar sesion', 'al cerrar sesion el sistema cierra el programa', '2026-11-11'),
(1,'admin', 'REPORTE DE ERROR DE SISTEMA', 'Error al cerrar sesion', 'Al cerrar sesion el sistema cierra el programa de forma inesperada.', '2026-11-11'),
(1,'admin', 'REPORTE DE ERROR DE SISTEMA', 'Fallo de conexion a BD', 'Se perdio la conexion con SQL Server al intentar guardar los cambios.', '2026-11-12'),
(2,'jperez', 'REPORTE DE ERROR DE SISTEMA', 'Tiempo de espera agotado', 'La consulta de inventario tardo demasiado y arrojo un error de tiempo de espera agotado.', '2026-11-13'),
(3,'mlopez', 'REPORTE DE MATERIAL', 'Stock bajo de materia prima', 'El material seleccionado esta por debajo del stock minimo permitido en almacen.', '2026-11-12'),
(1,'jperez', 'REPORTE DE MATERIAL', 'Diferencia en conteo fisico', 'Se detecto una diferencia entre el stock del sistema y el conteo fisico realizado.', '2026-11-14'),
(2,'mlopez', 'REPORTE DE MATERIAL', 'Material proximo a vencer', 'Existen unidades de material que requieren revision por proximidad a fecha de vencimiento.', '2026-11-15'),
(5,'rgarcia', 'REPORTE DE LOTE', 'Observacion en lote de caucho', 'El lote de caucho registro variacion en la inspeccion de calidad inicial.', '2026-11-13'),
(5,'rgarcia', 'REPORTE DE LOTE', 'Lote retenido en almacen', 'El lote quedo retenido temporalmente hasta confirmar resultados de control de calidad.', '2026-11-16'),
(2,'jperez', 'REPORTE DE LOTE', 'Cierre de produccion de lote', 'Se completo el registro y cierre del lote en el sistema sin incidencias.', '2026-11-17'),
(2,'cmendoza', 'REPORTE DE PROVEEDOR', 'Retraso en entrega de pedido', 'El proveedor entrego el pedido fuera de la fecha acordada en la orden de compra.', '2026-11-14'),
(1,'cmendoza', 'REPORTE DE PROVEEDOR', 'Incidencia en factura o guia', 'La guia de remision no coincide con las cantidades facturadas por el proveedor.', '2026-11-16'),
(1,'admin', 'REPORTE DE PROVEEDOR', 'Actualizacion de datos de proveedor', 'Se actualizaron datos de contacto y condiciones comerciales del proveedor.', '2026-11-18');
 
select * from PROVEEDOR
select * from ALMACEN
select * from PERSONAL
select * from MATERIAL
select * from LOTE_DE_CAUCHO
select * from GENERA
select * from MOVIMIENTO
select * from REPORTES


SELECT COUNT(*) AS TotalReportes FROM REPORTES WHERE COD_reporte = 13;

SELECT @@SERVERNAME AS NombreServidor;

UPDATE REPORTES SET nombre_de_reporte = 'Error al abrir gestion de material', detalle_de_reporte = 'Al intentar abrir la getsion de material no se abre la ventana que deberia y solo se queda en el menu inicial' where COD_reporte = 1;

select * from REPORTES where Tipo_de_reporte = 'REPORTE DE LOTE'
SELECT * FROM REPORTES ORDER BY COD_reporte desc


DROP TABLE REPORTES
use master
drop database MAMUT
 