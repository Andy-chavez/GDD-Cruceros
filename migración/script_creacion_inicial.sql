USE GD1C2019

if exists (select * from sys.schemas where name =  'LEISTE_EL_CODIGO?')
begin
	drop table  [LEISTE_EL_CODIGO?].Operacion
	drop table  [LEISTE_EL_CODIGO?].Login
	drop table  [LEISTE_EL_CODIGO?].Usuario
	drop table  [LEISTE_EL_CODIGO?].FuncionalidadPorRol
	drop table  [LEISTE_EL_CODIGO?].Rol
	drop table  [LEISTE_EL_CODIGO?].Funcionalidad

	drop table  [LEISTE_EL_CODIGO?].Voucher
	drop table  [LEISTE_EL_CODIGO?].Pasaje
	drop table  [LEISTE_EL_CODIGO?].Cliente
	drop table  [LEISTE_EL_CODIGO?].Reserva
	drop table  [LEISTE_EL_CODIGO?].PagoDeViaje	
	drop table  [LEISTE_EL_CODIGO?].MedioDePago

	drop table  [LEISTE_EL_CODIGO?].Viaje
	drop table  [LEISTE_EL_CODIGO?].Cabina
	drop table  [LEISTE_EL_CODIGO?].Crucero
	drop table  [LEISTE_EL_CODIGO?].TipoCabina
	drop table  [LEISTE_EL_CODIGO?].Servicio

	drop table  [LEISTE_EL_CODIGO?].Tramo
	drop table  [LEISTE_EL_CODIGO?].Recorrido
	drop table  [LEISTE_EL_CODIGO?].Puerto

end
go

if not exists (select * from sys.schemas where name = 'LEISTE_EL_CODIGO?')
begin
	EXEC ('CREATE SCHEMA [LEISTE_EL_CODIGO?] AUTHORIZATION [gdCruceros2019]')
	print 'Esquema LEISTE_EL_CODIGO? creado'
end
go


/* Por si necesitamoss*/


create table [LEISTE_EL_CODIGO?].Rol(
	nombre nvarchar(255) not null,
	id_rol smallint primary key,
	
);

create table [LEISTE_EL_CODIGO?].Usuario(
	id_usuario smallint primary key,
	nombre nvarchar(255) not null,
	id_rol smallint references [LEISTE_EL_CODIGO?].Rol, 
	contraseña nchar(64) not null /*sha256*/ /*preguntar*/
);

create table [LEISTE_EL_CODIGO?].Funcionalidad(
	id_funcionalidad smallint primary key
);

create table [LEISTE_EL_CODIGO?].FuncionalidadPorRol(
	id_funcionalidad smallint references [LEISTE_EL_CODIGO?].Funcionalidad,
	id_rol smallint references [LEISTE_EL_CODIGO?].Rol
	primary key (id_rol, id_funcionalidad)
);

create table [LEISTE_EL_CODIGO?].Login(
	id_login smallint primary key,
	id_usuario smallint references [LEISTE_EL_CODIGO?].Usuario,
	intentos_fallidos smallint
);

create table [LEISTE_EL_CODIGO?].Cliente(
	id_cliente smallint primary key,
	nombre varchar(255) not null,
	apellido varchar(255) not null,
	dni decimal(18, 0) not null,
	direccion nvarchar(255) NULL,
	telefono int not null,
	mail nvarchar(255) NULL,
	fecha_nacimiento datetime2(3) NULL,
);

create table [LEISTE_EL_CODIGO?].Recorrido(
	id_recorrido decimal(18,0) primary key,
	origen nvarchar(255) not null,
	destino nvarchar(255) not null,
	estado nchar(1) check(estado in ('A','I'))
);

create table [LEISTE_EL_CODIGO?].Puerto(
	id_puerto smallint primary key,
	nombre nvarchar(255) null,
	ciudad nvarchar(255) null
);

create table [LEISTE_EL_CODIGO?].Tramo(
	id_tramo smallint primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_origen smallint references [LEISTE_EL_CODIGO?].Puerto,
	id_destino smallint references [LEISTE_EL_CODIGO?].Puerto,
	precio_base decimal(18,2) not null
);


create table [LEISTE_EL_CODIGO?].Crucero(
	id_crucero nvarchar(50) primary key,
	fabricante nvarchar(255) null,
	modelo nvarchar(50) null,
	baja_fuera_de_servicio nchar(1) check(baja_fuera_de_servicio in ('A','I')), /*ver si por default podemos poner 'A' */
	baja_fuera_vida_util nchar(1) check(baja_fuera_vida_util in ('A','I')),
	fecha_baja_definitiva datetime2(3) null,
	fecha_reinicio_servicio datetime2(3) null
);
create table [LEISTE_EL_CODIGO?].Servicio(
	id_servicio smallint primary key,
	descripcion nvarchar(255) null
);

create table [LEISTE_EL_CODIGO?].TipoCabina(
	id_tipo nvarchar(255) primary key,
	id_servicio smallint references [LEISTE_EL_CODIGO?].Servicio,
	porcentaje_recargo decimal(18, 2) not null
);

create table [LEISTE_EL_CODIGO?].Cabina(
	id_cabina smallint primary key,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	id_tipo nvarchar(255) references [LEISTE_EL_CODIGO?].TipoCabina,
	numero decimal(18,0) not null,
	piso decimal(18,0) not null
);

create table [LEISTE_EL_CODIGO?].Viaje(
	id_viaje smallint primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	fecha_inicio datetime2(3) not null,
	fecha_finalizacion_estimada datetime2(3) not null,
	fecha_finalizacion datetime2(3) not null,
);

create table [LEISTE_EL_CODIGO?].Operacion(
	id_operacion smallint primary key,
	id_login smallint references [LEISTE_EL_CODIGO?].Login,
	id_cliente smallint references [LEISTE_EL_CODIGO?].Cliente,
	id_usuario smallint references [LEISTE_EL_CODIGO?].Usuario,
	id_viaje smallint references [LEISTE_EL_CODIGO?].Viaje
);

create table [LEISTE_EL_CODIGO?].MedioDePago(
	id_medio_de_pago smallint primary key,
	cuotas_sin_interes smallint not null,
	descuento smallint not null,
	intereses smallint not null
);

create table [LEISTE_EL_CODIGO?].PagoDeViaje(
	id_pago smallint primary key,
	fecha_pago datetime2(3) null,
	id_medio_de_pago smallint references [LEISTE_EL_CODIGO?].MedioDePago,
	detalle nvarchar(255) null,
	monto_total decimal(8,2) not null,
	cantidad_de_pasajes smallint check(cantidad_de_pasajes > 0)
);

create table [LEISTE_EL_CODIGO?].Reserva(
	id_reserva decimal(18,0) primary key,
	vencimiento datetime2(3) not null,
	fecha_actual datetime2(3) not null,
	id_pago smallint references [LEISTE_EL_CODIGO?].PagoDeViaje
);
create table [LEISTE_EL_CODIGO?].Pasaje(
	id_pasaje decimal(18,0) primary key,
	id_viaje smallint references [LEISTE_EL_CODIGO?].Viaje,
	id_cliente smallint references [LEISTE_EL_CODIGO?].Cliente,
	id_cabina smallint references [LEISTE_EL_CODIGO?].Cabina,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	precio decimal(18,2) not null,
	cancelacion nchar(1) check(cancelacion in ('S','N')),
	fecha_cancelacion datetime2(3) null,
	motivo_cancelacion nvarchar(255) null, /*necesario?*/
	fecha_reprogramacion datetime2(3) null, 
);
create table [LEISTE_EL_CODIGO?].Voucher(
	id_voucher smallint primary key,
	id_cliente smallint references [LEISTE_EL_CODIGO?].Cliente,
	id_pasaje decimal(18,0) references [LEISTE_EL_CODIGO?].Pasaje,
	id_reserva decimal(18,0) references [LEISTE_EL_CODIGO?].Reserva
);

