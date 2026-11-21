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
Apellido varchar(30), 
Cargo varchar(30), 
Usuario varchar(30), 
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
 
insert into PERSONAL (Nombre, Apellido, Cargo, Usuario, Password) values 
('Carlos', 'Mamani', 'Encargado', 'cmamani', 'clave123'), 
('Lucia', 'Quispe', 'Supervisor', 'lquispe', 'clave456'), 
('Diego', 'Flores', 'Operador', 'dflores', 'clave789'), 
('Ana', 'Choque', 'Almacenera', 'achoque', 'clave321'), 
('Pedro', 'Apaza', 'Operador', 'papaza', 'clave654'); 
 
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
 
select * from PROVEEDOR
select * from ALMACEN
select * from PERSONAL
select * from MATERIAL
select * from LOTE_DE_CAUCHO
select * from GENERA
select * from MOVIMIENTO


SELECT @@SERVERNAME AS NombreServidor;


 drop database MAMUT
 DROP TABLE GENERA
 INSERT INTO PERSONAL(Nombre, Apellido, Cargo, Usuario, Password)VALUES('kevin','blanco','tecnico de sistemas','admin','1234');
