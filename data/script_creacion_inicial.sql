USE GD1C2019
go

if exists (select * from sys.schemas where name =  'LEISTE_EL_CODIGO?')
begin

	if exists(select * from sys.tables where object_name(object_id)='MedioDePago'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].MedioDePago
	if exists(select * from sys.tables where object_name(object_id)='PagoDeViaje'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].PagoDeViaje	
	if exists(select * from sys.tables where object_name(object_id)='Reserva'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Reserva
	if exists(select * from sys.tables where object_name(object_id)='Pasaje'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Pasaje
	if exists(select * from sys.tables where object_name(object_id)='Cliente'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Cliente

	if exists(select * from sys.tables where object_name(object_id)='Usuario' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Usuario
	if exists(select * from sys.tables where object_name(object_id)='FuncionalidadPorRol'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].FuncionalidadPorRol
	if exists(select * from sys.tables where object_name(object_id)='Rol'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Rol
	if exists(select * from sys.tables where object_name(object_id)='Viaje'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Viaje
	if exists(select * from sys.tables where object_name(object_id)='Cabina'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Cabina
	if exists(select * from sys.tables where object_name(object_id)='Crucero'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Crucero
	if exists(select * from sys.tables where object_name(object_id)='Fabricante'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table	[LEISTE_EL_CODIGO?].Fabricante
	if exists(select * from sys.tables where object_name(object_id)='TipoCabina'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].TipoCabina
	if exists(select * from sys.tables where object_name(object_id)='Servicio'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Servicio

	if exists(select * from sys.tables where object_name(object_id)='Tramo'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Tramo
	if exists(select * from sys.tables where object_name(object_id)='Recorrido'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Recorrido
	if exists(select * from sys.tables where object_name(object_id)='Puerto'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Puerto

	if exists(select * from sys.tables where object_name(object_id)='Funcionalidad'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Funcionalidad
end
else
begin
	exec ('create schema [LEISTE_EL_CODIGO?] authorization [gdCruceros2019]')
	print 'Esquema LEISTE_EL_CODIGO? creado'
end
go
/* ---------------------------------------------------- Creacion de tablas ----------------------------------------------------*/
USE GD1C2019
go
create table [LEISTE_EL_CODIGO?].Rol(
	nombre nvarchar(255) not null,
	id_rol smallint identity primary key,
)
go
create table [LEISTE_EL_CODIGO?].Usuario(
	id_usuario nvarchar(50) primary key,
	id_rol smallint references [LEISTE_EL_CODIGO?].Rol, 
	contra varbinary(32),
	intentos_posibles smallint default 3,
	habilitado nchar(1) not null default 'A' check(habilitado in ('A','i'))
)
go
create table [LEISTE_EL_CODIGO?].Funcionalidad(
	id_funcionalidad smallint identity primary key,
	descripcion nvarchar(100) not null
)
go
create table [LEISTE_EL_CODIGO?].FuncionalidadPorRol(
	id_funcionalidad smallint references [LEISTE_EL_CODIGO?].Funcionalidad,
	id_rol smallint references [LEISTE_EL_CODIGO?].Rol,
	primary key (id_rol, id_funcionalidad)
)
go
create table [LEISTE_EL_CODIGO?].Cliente(
	id_cliente int identity primary key,
	id_rol smallint default '4' references [LEISTE_EL_CODIGO?].Rol,
	nombre varchar(255) not null,
	apellido varchar(255) not null,
	dni decimal(18, 0) not null,
	direccion nvarchar(255) NULL,
	telefono int not null,
	mail nvarchar(255) NULL,
	fecha_nacimiento datetime2(3) NULL,
)
go
create table [LEISTE_EL_CODIGO?].Recorrido(
	id_recorrido decimal(18,0) primary key,
	id_funcionalidad smallint default '5' references [LEISTE_EL_CODIGO?].Funcionalidad,
	estado char(1) default 'A' check(estado in ('A','I')) 
)
go
create table [LEISTE_EL_CODIGO?].Puerto(
	id_puerto nvarchar(255) primary key,
)
go
create table [LEISTE_EL_CODIGO?].Tramo(
	id_tramo smallint identity primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_origen nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	id_destino nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	orden smallint,
	precio_base decimal(18,2) not null
)
go
create table [LEISTE_EL_CODIGO?].Fabricante(
	id_fabricante nvarchar(255) primary key
)
go
create table [LEISTE_EL_CODIGO?].Crucero(
	id_crucero nvarchar(50) primary key,
	id_fabricante nvarchar(255) references [LEISTE_EL_CODIGO?].Fabricante, --@
	id_funcionalidad smallint default '2' references [LEISTE_EL_CODIGO?].Funcionalidad,
	modelo nvarchar(50) null,
	baja_fuera_de_servicio nchar(1) default 'N' check(baja_fuera_de_servicio in ('S','N')),
	baja_fuera_vida_util nchar(1) default 'N' check(baja_fuera_vida_util in ('S','N')),
	fecha_baja_definitiva datetime2(3) null,
	fecha_reinicio_servicio datetime2(3) null
)
go
create table [LEISTE_EL_CODIGO?].Servicio(
	id_servicio smallint primary key,
	descripcion nvarchar(255) null
)
go
create table [LEISTE_EL_CODIGO?].TipoCabina(
	id_tipo nvarchar(255) primary key,
	id_servicio smallint references [LEISTE_EL_CODIGO?].Servicio,
	porcentaje_recargo decimal(18, 2) not null
)
go
create table [LEISTE_EL_CODIGO?].Cabina(
	id_cabina smallint identity primary key,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	id_tipo nvarchar(255) references [LEISTE_EL_CODIGO?].TipoCabina,
	numero decimal(18,0) not null,
	piso decimal(18,0) not null
)
go
create table [LEISTE_EL_CODIGO?].Viaje(
	id_viaje int identity primary key,
	id_funcionalidad smallint default '6' references [LEISTE_EL_CODIGO?].Funcionalidad,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	fecha_inicio datetime2(3) not null,
	fecha_finalizacion_estimada datetime2(3) not null,
	fecha_finalizacion datetime2(3) not null,
)
go
create table [LEISTE_EL_CODIGO?].Reserva(
	id_reserva decimal(18,0) primary key,
	id_funcionalidad smallint default '7' references [LEISTE_EL_CODIGO?].Funcionalidad,
	fecha_actual datetime2(3) not null,
	vencimiento datetime2(3) null,
)
go
create table [LEISTE_EL_CODIGO?].Pasaje(
	id_pasaje decimal(18,0) primary key,
	id_viaje int references [LEISTE_EL_CODIGO?].Viaje,
	id_cliente int references [LEISTE_EL_CODIGO?].Cliente,
	id_cabina smallint references [LEISTE_EL_CODIGO?].Cabina,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	precio decimal(18,2) not null,
	cancelacion nchar(1) default 'N' check(cancelacion in ('S','N')),
	fecha_cancelacion datetime2(3) null,
	fecha_reprogramacion datetime2(3) null, 
)
go
create table [LEISTE_EL_CODIGO?].PagoDeViaje(
	id_pago int primary key identity,
	fecha_pago datetime2(3) null,
	monto_total decimal(8,2) not null,
	id_funcionalidad smallint default '8' references [LEISTE_EL_CODIGO?].Funcionalidad,
	cantidad_de_pasajes smallint default 1 check(cantidad_de_pasajes > 0),
	id_reserva decimal(18,0) references [LEISTE_EL_CODIGO?].Reserva,
	id_pasaje decimal(18,0) references [LEISTE_EL_CODIGO?].Pasaje
)
go
create table [LEISTE_EL_CODIGO?].MedioDePago(
	id_medio_de_pago smallint primary key,
	cuotas_sin_interes smallint not null,
	descuento smallint not null,
	intereses smallint not null,
	id_pago int references [LEISTE_EL_CODIGO?].PagoDeViaje
)
go
/*--------------------------------------TRIGGERS-----------------------------------------------*/
USE GD1C2019
go
--Trigger de vencimiento para reserva--
create trigger fechaVencimiento on [LEISTE_EL_CODIGO?].Reserva
after insert
as
begin
	declare @fechaActual datetime2, @id_reserva decimal(18,0)
	declare cursorVencimiento cursor for
	select fecha_actual,id_reserva
	from inserted
	open cursorVencimiento
	fetch next from cursorVencimiento
	into @fechaActual,@id_reserva
	while @@FETCH_STATUS =0
		begin
		update [LEISTE_EL_CODIGO?].Reserva
		set vencimiento = DATEADD(day,4,@fechaActual)
		where id_reserva = @id_reserva
		fetch next from cursorVencimiento
		into @fechaActual,@id_reserva
		end
	close cursorVencimiento
deallocate cursorVencimiento
end
go
/* ---------------------------------------------------- Inserciones ---------------------------------------------------- */

-- Funcionalidad
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('abm de rol')						-- Funcionalidad = 1
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('abm de cruceros')				-- Funcionalidad = 2
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('registro de usuarios')			-- Funcionalidad = 3
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('abm de puertos')					-- Funcionalidad = 4
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('abm de recorrido')				-- Funcionalidad = 5
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('generar viaje')					-- Funcionalidad = 6
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('compra y/o reserva de viaje')	-- Funcionalidad = 7
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('pago de reserva')				-- Funcionalidad = 8
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('listado estadistico')			-- Funcionalidad = 9
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion) values('login y seguridad')				-- Funcionalidad = 10
go

-- Rol
insert into [LEISTE_EL_CODIGO?].Rol(nombre) values('administrador general')			--Rol 1 = administrador general
insert into [LEISTE_EL_CODIGO?].Rol(nombre) values('administrador')					--Rol 2 = administrador
insert into [LEISTE_EL_CODIGO?].Rol(nombre) values('usuario')						--Rol 3 = usuario
insert into [LEISTE_EL_CODIGO?].Rol(nombre) values('cliente')						--Rol 4 = cliente
go
-- Funcionalidad por Rol
--ADMINISTRADOR GENERAL
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,1)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,2)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,3)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,4)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,5)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,6)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,7)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,8)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(1,9)
go
--ADMIN
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,1)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,2)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,3)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,4)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,5)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,6)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,7)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,8)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(2,9)
go

--******************************************creo que estos inserts feos pueden hacerse de otra forma 

--USUARIO
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(3,7)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(3,8)
go
-- Usuario
declare @hash varbinary(32)
select @hash = hashbytes('SHA2_256', 'w23e')
--ADMINISTRADOR GENERAL
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('admin',1,@hash)	
--ADMINISTRADORES
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('adminNuestro',2,@hash)
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('admin2',2,@hash)
--USUARIOS
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol) values('pepe',3)
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol) values('pepita',3)
go
/* ---------------------------------------------------- Migración ---------------------------------------------------- */
--CLIENTE--
insert into [LEISTE_EL_CODIGO?].Cliente(nombre,apellido,dni,direccion,telefono,mail,fecha_nacimiento)
select CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_DIRECCION,CLI_TELEFONO,CLI_MAIL,CLI_FECHA_NAC
from gd_esquema.Maestra
where PASAJE_CODIGO is not null
go
--Fabricante--
insert into [LEISTE_EL_CODIGO?].Fabricante
select distinct CRU_FABRICANTE
from gd_esquema.Maestra
go
--Crucero-- (son 37 cruceros, se repiten varias veces por cada viaje)
insert into [LEISTE_EL_CODIGO?].Crucero(id_crucero,id_fabricante,modelo)
select distinct CRUCERO_IDENTIFICADOR,CRU_FABRICANTE,CRUCERO_MODELO
from gd_esquema.Maestra
go
--Servicio-- (tengo dudas de como deberia ser el orden de insert de las cosas) y las descripciones cambienlas si quieren
--select count(distinct CABINA_TIPO)
--from gd_esquema.Maestra -- hay 5 tipos de cabinas asique hay 5 servicios asociados a ellas
--select distinct CABINA_TIPO
--from gd_esquema.Maestra --cabina exterior, ejecutivo,cabina estandar,suite,cabina balcon

insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion) values(1,'vista al mar') --ni idea jajaj, estoy abierto a sugerencias (para cabina exterior)
insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion) values(2,'desayuno incluido') --(para ejecutivo)
insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion) values(3,'solo habitacion') --(para cabina estandar)
insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion) values(4,'masajes y bebidas incluidas') --(para suite)
insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion) values(5,'vista a la pileta') --(para cabina balcon)
go
--Tipo Cabina --
insert into [LEISTE_EL_CODIGO?].TipoCabina (id_tipo,porcentaje_recargo)
select CABINA_TIPO,CABINA_TIPO_PORC_RECARGO
from gd_esquema.Maestra
group by CABINA_TIPO,CABINA_TIPO_PORC_RECARGO
go
update [LEISTE_EL_CODIGO?].TipoCabina--agregando servicios de cada tipo de cabina
set id_servicio = 1
where id_tipo = 'Cabina Exterior'
go
update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 2
where id_tipo = 'Ejecutivo'
go
update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 3
where id_tipo = 'Cabina estandar'
go
update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 4
where id_tipo = 'Suite'
go
update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 5
where id_tipo = 'Cabina Balcón'
go
-------------------Cabinas--------------------------
insert into [LEISTE_EL_CODIGO?].Cabina (numero,piso,id_crucero,id_tipo)
select CABINA_NRO,CABINA_PISO,CRUCERO_IDENTIFICADOR,CABINA_TIPO from gd_esquema.Maestra
group by CABINA_NRO,CABINA_PISO,CRUCERO_IDENTIFICADOR,CABINA_TIPO
go
-----------------------------Puerto------------------------------- (solo va nombre de puerto en la tabla, no va el campo ciudad, es irrelevante)

--select t.RECORRIDO_CODIGO,count(*)
--from (select distinct RECORRIDO_CODIGO,PUERTO_DESDE,PUERTO_HASTA from gd_esquema.Maestra
--where PUERTO_DESDE in (select distinct PUERTO_HASTA from gd_esquema.Maestra)) t
--group by t.RECORRIDO_CODIGO

insert into [LEISTE_EL_CODIGO?].Puerto
select distinct PUERTO_DESDE from gd_esquema.Maestra where PUERTO_DESDE<> PUERTO_HASTA
go
------------------------------------------ Recorrido -----------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Recorrido (id_recorrido)
select distinct RECORRIDO_CODIGO
from gd_esquema.Maestra
go
-----------------------------------------Tramo-----------------------------------------------------------
create table #tramoTemp(
	id_tramo smallint identity primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_origen nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	id_destino nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	orden smallint,
	precio_base decimal(18,2) not null
);
go
insert into #tramoTemp (id_recorrido,id_origen,id_destino,precio_base)
select distinct RECORRIDO_CODIGO,PUERTO_DESDE,PUERTO_HASTA,RECORRIDO_PRECIO_BASE
from gd_esquema.Maestra
go
insert into [LEISTE_EL_CODIGO?].Tramo (id_recorrido,orden,id_origen,id_destino,precio_base)
SELECT DISTINCT id_recorrido, 
				(CASE 
					WHEN ((SELECT DISTINCT temp1.id_origen 
							FROM #tramoTemp temp1
							WHERE temp.id_recorrido = temp1.id_recorrido AND temp1.id_origen = temp.id_destino) IS NOT NULL )
						OR
						((SELECT COUNT (*)
						FROM #tramoTemp temp2
						WHERE temp.id_recorrido = temp2.id_recorrido AND temp.id_origen <> temp2.id_origen) = 0)
					THEN 1
					ELSE 2 
				END), 
				(SELECT id_puerto 
					FROM [LEISTE_EL_CODIGO?].Puerto
					WHERE temp.id_origen = id_puerto),
				(SELECT id_puerto 
					FROM [LEISTE_EL_CODIGO?].Puerto
					WHERE temp.id_destino = id_puerto),
				precio_base
FROM #tramoTemp temp
go
----------------------------------Medio de Pago--------------------------------- (esta la llenamos nosotros)

----------------------------------------Pago de viaje-------------------------------------------- 
--select PASAJE_CODIGO, count(*) from gd_esquema.Maestra where PASAJE_CODIGO is not null group by PASAJE_CODIGO having count(*)>1
insert into [LEISTE_EL_CODIGO?].PagoDeViaje(id_pasaje,fecha_pago,monto_total)
select PASAJE_CODIGO,PASAJE_FECHA_COMPRA,PASAJE_PRECIO from gd_esquema.Maestra
where PASAJE_FECHA_COMPRA is not null and PASAJE_PRECIO is not null
go
-------------------------------------------------Reserva-----------------------------------------
insert into [LEISTE_EL_CODIGO?].Reserva (id_reserva,fecha_actual)
select distinct RESERVA_CODIGO,RESERVA_FECHA
from gd_esquema.Maestra
where RESERVA_CODIGO is not null and RESERVA_FECHA is not null
go
-------------------------------------------------Viaje------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Viaje (fecha_inicio,fecha_finalizacion,fecha_finalizacion_estimada,id_crucero,id_recorrido)
select distinct FECHA_SALIDA,FECHA_LLEGADA,FECHA_LLEGADA_ESTIMADA,CRUCERO_IDENTIFICADOR,RECORRIDO_CODIGO from gd_esquema.Maestra
go
---------------------------------------------Pasaje-----------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Pasaje (id_cabina,id_cliente,id_viaje,id_crucero,precio,id_pasaje)
select distinct(select id_cabina
		from [LEISTE_EL_CODIGO?].Cabina
		where numero= m.CABINA_NRO and id_crucero= m.CRUCERO_IDENTIFICADOR and piso = m.CABINA_PISO and id_tipo = m.CABINA_TIPO)idCabina,
		(select id_cliente
		from [LEISTE_EL_CODIGO?].Cliente
		where nombre=m.CLI_NOMBRE and apellido=m.CLI_APELLIDO and dni=m.CLI_DNI and telefono=m.CLI_TELEFONO and fecha_nacimiento = m.CLI_FECHA_NAC)cliente,
		(select id_viaje
		from [LEISTE_EL_CODIGO?].Viaje
		where id_recorrido=m.RECORRIDO_CODIGO and fecha_inicio=m.FECHA_SALIDA and fecha_finalizacion= m.FECHA_LLEGADA and fecha_finalizacion_estimada=m.FECHA_LLEGADA_ESTIMADA and id_crucero = m.CRUCERO_IDENTIFICADOR)idViaje,
		m.CRUCERO_IDENTIFICADOR,m.PASAJE_PRECIO,m.PASAJE_CODIGO
from gd_esquema.Maestra m
where m.PASAJE_CODIGO is not null and m.PASAJE_PRECIO is not null
go
/*--------------------------------------PROCEDURES C/DROP-----------------------------------------------*/
		--LOGIN--
if exists (select * from sys.procedures where name = 'sp_login')
	drop procedure [LEISTE_EL_CODIGO?].sp_login
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].sp_login(@id_ingresado nvarchar(50), @contra_ingresada nvarchar(32)) -- aca tengo dudas de si es la contra al todavia no estar hasheada, si es de 32 o no
as
	begin
		declare @intentos_posibles smallint,
				@contra_hasheada varbinary(32), 
				@contra_real varbinary(32),
				@valor_retorno smallint,
				@habilitado nchar(1)
		set @intentos_posibles = (select intentos_posibles from [LEISTE_EL_CODIGO?].Usuario where id_usuario = @id_ingresado)
		set	@contra_hasheada = hashbytes('SHA2_256',@contra_ingresada)
		set @contra_real = (select contra from [LEISTE_EL_CODIGO?].Usuario where id_usuario=@id_ingresado)
		set @habilitado = (select habilitado from [LEISTE_EL_CODIGO?].Usuario where id_usuario=@id_ingresado)
		if not exists(select id_usuario from [LEISTE_EL_CODIGO?].Usuario where id_usuario=@id_ingresado and habilitado = 'A') --veo si no existe el usuario
			set @valor_retorno = -2						--no pudo loggear, no existe el usuario
		else if(@intentos_posibles>0 and @habilitado = 'A')					--usuario existe y puede intentar todavia
			begin 
				if(@contra_real = @contra_hasheada)
				begin
					set @valor_retorno = 1				--logg posible, salio todo bien 
					update [LEISTE_EL_CODIGO?].Usuario 
						set intentos_posibles = 3 
					where id_usuario=@id_ingresado
				end
				else
				begin
					set @valor_retorno = 0				--ingreso mal la contra pero tiene intentos posibles
					update [LEISTE_EL_CODIGO?].Usuario 
						set intentos_posibles = intentos_posibles -1
					where id_usuario=@id_ingresado
				end
			end
		else 
			begin
				update [LEISTE_EL_CODIGO?].Usuario 
				set habilitado = 'I'
				where id_usuario = @id_ingresado
			set @valor_retorno = -1						--El usuario excedio esas tres oportunidades y fue dado de baja (por ahora borrado)
			end
		return @valor_retorno
	end
go
		--CARGAR VIAJE--
if exists (select * from sys.procedures where name = 'cargarViaje')
	drop procedure [LEISTE_EL_CODIGO?].cargarViaje
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].cargarViaje(@id_recorrido decimal(18,0),@id_crucero nvarchar(50),@fecha_inicio datetime2, @fecha_finalizacion_estimada datetime2, @fecha_actual datetime2)
as
	begin
		declare @valor_retorno tinyint
		if(@fecha_actual>@fecha_inicio)
			begin
				set @valor_retorno = -1 --fecha mal ingresada, se quiere generar viaje de fecha anterior a la actual
			end
		else if exists( select id_viaje
						from [LEISTE_EL_CODIGO?].Viaje join [LEISTE_EL_CODIGO?].Crucero cru
						on (cru.id_crucero = @id_crucero)
						where fecha_inicio not between @fecha_inicio and @fecha_finalizacion_estimada
							and fecha_finalizacion_estimada not between @fecha_inicio and @fecha_finalizacion_estimada)
			begin
				set @valor_retorno = -2 -- crucero ocupado
			end
		else if exists(select id_recorrido from [LEISTE_EL_CODIGO?].Recorrido where id_recorrido = @id_recorrido and estado = 'I')
			begin
				set @valor_retorno = -3 --recorrido inhabilitado
			end
		else if exists(select id_crucero from [LEISTE_EL_CODIGO?].Crucero where id_crucero = @id_crucero and baja_fuera_de_servicio ='S' or baja_fuera_vida_util = 'S')
			begin
				set @valor_retorno = -4 --crucero inhabilitado
			end
		else
			begin
				insert into [LEISTE_EL_CODIGO?].Viaje(id_recorrido,id_crucero,fecha_inicio,fecha_finalizacion_estimada)
				values(@id_recorrido,@id_crucero, @fecha_inicio, @fecha_finalizacion_estimada)
				set @valor_retorno = 1 --se cargo viaje
			end
		return @valor_retorno
	end
go
		--DAR CRUCERO DE BAJA DEFINITIVA--
if exists (select * from sys.procedures where name = 'darDeBajaDefinitivaCrucero')
	drop procedure [LEISTE_EL_CODIGO?].darDeBajaDefinitivaCrucero
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].darDeBajaDefinitivaCrucero(@id_crucero nvarchar(50),@fecha_actual datetime2)
as
	begin
		update [LEISTE_EL_CODIGO?].Crucero
		set baja_fuera_vida_util = 'S',fecha_baja_definitiva = @fecha_actual
		where id_crucero = @id_crucero
	end
go
		--DAR CRUCERO DE BAJA TEMPORAL--
if exists (select * from sys.procedures where name = 'darDeBajaTemporalCrucero')
	drop procedure [LEISTE_EL_CODIGO?].darDeBajaTemporalCrucero
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].darDeBajaTemporalCrucero(@id_crucero nvarchar(50),@fecha_reinicio datetime2)
as
	begin
		update [LEISTE_EL_CODIGO?].Crucero
		set baja_fuera_de_servicio = 'S',fecha_reinicio_servicio = @fecha_reinicio
		where id_crucero = @id_crucero
	end
go
/*--------------------------------------VISTAS C/ DROP PREVIO-----------------------------------------------*/
if exists(select * from sys.views where object_name(object_id)='CrucerosDisponibles' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].CrucerosDisponibles
	end
go
USE GD1C2019
go

create view [LEISTE_EL_CODIGO?].CrucerosDisponibles
as
		select id_crucero,id_fabricante,modelo
		from [LEISTE_EL_CODIGO?].Crucero
		where baja_fuera_vida_util = 'N' and baja_fuera_de_servicio = 'N'
go
