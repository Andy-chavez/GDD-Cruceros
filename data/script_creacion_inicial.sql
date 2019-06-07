USE GD1C2019
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

if exists (select * from sys.schemas where name =  'LEISTE_EL_CODIGO?')
begin

	if exists(select * from sys.tables where object_name(object_id)='Pasaje'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Pasaje
	if exists(select * from sys.tables where object_name(object_id)='PagoDeViaje'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].PagoDeViaje	
	if exists(select * from sys.tables where object_name(object_id)='MedioDePago'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].MedioDePago

	if exists(select * from sys.tables where object_name(object_id)='Reserva'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].Reserva
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
	if exists(select * from sys.tables where object_name(object_id)='AuditoriaDeCruceros'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].AuditoriaDeCruceros
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
	baja_logica char(1) not null default 'N' check(baja_logica in ('S','N')) 
)
go
create table [LEISTE_EL_CODIGO?].Usuario(
	id_usuario nvarchar(50) primary key,
	id_rol smallint references [LEISTE_EL_CODIGO?].Rol, 
	contra varbinary(32),
	intentos_posibles smallint default 3,
	habilitado nchar(1) not null default 'A' check(habilitado in ('A','I'))
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
	id_rol smallint default '3' references [LEISTE_EL_CODIGO?].Rol,
	nombre varchar(255) not null,
	apellido varchar(255) not null,
	dni decimal(18, 0) not null,
	direccion nvarchar(255) NULL,
	telefono int not null,
	mail nvarchar(255) NULL,
	fecha_nacimiento datetime2(3) NULL,
)
go
create table [LEISTE_EL_CODIGO?].Puerto(
	id_puerto nvarchar(255) primary key,
)
go
create table [LEISTE_EL_CODIGO?].Recorrido(
	id_recorrido decimal(18,0) primary key,
	estado char(1) default 'A' check(estado in ('A','I')),
	id_origen nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	id_destino nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
)
go
create table [LEISTE_EL_CODIGO?].Tramo(
	id_tramo smallint identity primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_origen nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	id_destino nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	orden smallint not null check (orden>0),
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
	modelo nvarchar(50) null,
	baja_fuera_de_servicio nchar(1) default 'N' check(baja_fuera_de_servicio in ('S','N')),
	baja_fuera_vida_util nchar(1) default 'N' check(baja_fuera_vida_util in ('S','N')),
	fecha_baja_por_fuera_de_servicio datetime2(3) null,
	fecha_reinicio_servicio datetime2(3) null,
	fecha_baja_por_vida_util datetime2(3) null,
	cantidadDeCabinas int,
)
go
create table [LEISTE_EL_CODIGO?].Servicio(
	id_servicio smallint primary key,
	descripcion nvarchar(255) null
)
go
create table [LEISTE_EL_CODIGO?].TipoCabina(
	id_tipo nvarchar(255) primary key,
	--tipo_cabina varchar(255),
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
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	fecha_inicio datetime2(3) not null,
	fecha_finalizacion_estimada datetime2(3) not null,
	fecha_finalizacion datetime2(3) not null,
)
go
create table [LEISTE_EL_CODIGO?].Reserva(
	id_reserva decimal(18,0) primary key,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	id_cliente int references [LEISTE_EL_CODIGO?].Cliente,
	id_viaje int references [LEISTE_EL_CODIGO?].Viaje,
	id_cabina smallint references [LEISTE_EL_CODIGO?].Cabina,
	fecha_actual datetime2(3) not null,
	vencimiento datetime2(3) null,
)
go
create table [LEISTE_EL_CODIGO?].MedioDePago(
	id_medio_de_pago int primary key identity,
	cuotas_sin_interes smallint not null,
	descuento smallint not null,
	intereses smallint not null,
)
go
create table [LEISTE_EL_CODIGO?].PagoDeViaje(
	id_pago int primary key identity,
	id_cliente int references [LEISTE_EL_CODIGO?].Cliente,
	fecha_pago datetime2(3) null,
	monto_total decimal(8,2) not null,
	cantidad_de_pasajes smallint default 1 check(cantidad_de_pasajes > 0),
	id_medio_de_pago int references [LEISTE_EL_CODIGO?].MedioDePago,
)
go
create table [LEISTE_EL_CODIGO?].Pasaje(
	id_pasaje decimal(18,0) primary key,
	id_viaje int references [LEISTE_EL_CODIGO?].Viaje,
	id_cliente int references [LEISTE_EL_CODIGO?].Cliente,
	id_cabina smallint references [LEISTE_EL_CODIGO?].Cabina,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	id_pago int references [LEISTE_EL_CODIGO?].PagoDeViaje,
	precio decimal(18,2) not null,
	cancelacion nchar(1) default 'N' check(cancelacion in ('S','N')),
	fecha_cancelacion datetime2(3) null,
	fecha_reprogramacion datetime2(3) null,
)
go

create table [LEISTE_EL_CODIGO?].AuditoriaDeCruceros(
	id_auditoria int identity primary key,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	motivo varchar(256)
)
/*--------------------------------------TRIGGERS-----------------------------------------------*/
USE GD1C2019
go
--Trigger de vencimiento para reserva--
--IF OBJECT_ID ('fechaVencimiento', 'TR') IS NOT NULL  
--   DROP TRIGGER fechaVencimiento; nose porque esto no funca
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

-- Trigger para borrar reservas vencidas cada vez que haya un login
USE GD1C2019
go
create trigger eliminarReservasVencidas
on all server for logon
as
	begin
	delete from [LEISTE_EL_CODIGO?].Reserva
	where SYSDATETIME() > vencimiento
	end
go

/*----------STARTUP-----------*/ --@@deberia correr en master
--Procedure de control de reservas vencidas
/*
USE MASTER
GO

create procedure DBO.eliminarReservasVencidas
as
delete from [LEISTE_EL_CODIGO?].Reserva
where SYSDATETIME() > vencimiento
go

USE GD1C2019
go
*/

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
insert into [LEISTE_EL_CODIGO?].Rol(nombre) values('cliente')						--Rol 3 = cliente
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

--Cliente
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(3,7)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values(3,8)
go
----Contraseñas
declare @hash varbinary(32)
select @hash = hashbytes('SHA2_256', 'w23e')
--ADMINISTRADOR GENERAL
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('admin',1,@hash)	
--ADMINISTRADORES
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('adminNuestro',2,@hash)
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('admin2',2,@hash)
--Cliente
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
where id_tipo like 'Cabina Ba%'
go

--Crucero-- (son 37 cruceros, se repiten varias veces por cada viaje)
insert into [LEISTE_EL_CODIGO?].Crucero(id_crucero,id_fabricante,modelo)
select distinct CRUCERO_IDENTIFICADOR,CRU_FABRICANTE,CRUCERO_MODELO
					--(SELECT count(id_cabina)
					--FROM [LEISTE_EL_CODIGO?].Cabina c
					--WHERE c.id_crucero = m.CRUCERO_IDENTIFICADOR)
FROM gd_esquema.Maestra m
go
-------------------Cabinas--------------------------
use GD1C2019
go
insert into [LEISTE_EL_CODIGO?].Cabina (numero,piso,id_crucero,id_tipo)
select CABINA_NRO,CABINA_PISO,CRUCERO_IDENTIFICADOR,CABINA_TIPO
from gd_esquema.Maestra
group by CABINA_NRO,CABINA_PISO,CRUCERO_IDENTIFICADOR,CABINA_TIPO
go

-------------------------cursor para cantidad de cabinas------------
declare @id_crucero nvarchar(50)
declare cursor_cant cursor for
select id_crucero
from [LEISTE_EL_CODIGO?].Crucero

open cursor_cant
fetch next from cursor_cant
into @id_crucero
	while @@FETCH_STATUS =0
		begin
			declare @cant_cabinas int
			select @cant_cabinas = count(id_cabina)
			from [LEISTE_EL_CODIGO?].Cabina c
			where c.id_crucero = @id_crucero
			print @cant_cabinas

			update [LEISTE_EL_CODIGO?].Crucero
			set cantidadDeCabinas = @cant_cabinas
			where id_crucero = @id_crucero

			fetch next from cursor_cant
			into @id_crucero
		end
	close cursor_cant
	deallocate cursor_cant
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
IF OBJECT_ID('tempdb..#tramoTemp') IS NOT NULL DROP TABLE #tramoTemp
go
create table #tramoTemp(
	id_tramo smallint identity primary key,
	id_recorrido decimal(18,0),
	id_origen nvarchar(255),
	id_destino nvarchar(255),
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
------agrego un insert para hacer mas facil la busqueda en recorrido---------------
--- ver si se les ocurre una manera un poco mas linda de hacerlo
update [LEISTE_EL_CODIGO?].Recorrido
set id_origen = t1.id_origen
from [LEISTE_EL_CODIGO?].Tramo t1
where Recorrido.id_recorrido = t1.id_recorrido and t1.orden = 1

update [LEISTE_EL_CODIGO?].Recorrido
set id_destino = t1.id_destino
from [LEISTE_EL_CODIGO?].Tramo t1
where (t1.id_recorrido = 43820864 or t1.id_recorrido = 43820908) and Recorrido.id_recorrido = t1.id_recorrido

update [LEISTE_EL_CODIGO?].Recorrido
set id_destino= t1.id_destino
from [LEISTE_EL_CODIGO?].Tramo t1
where (Recorrido.id_recorrido = t1.id_recorrido and t1.orden = 2)
----------------------------------Medio de Pago--------------------------------- (esta la llenamos nosotros)

----------------------------------------Pago de viaje-------------------------------------------- 
--select PASAJE_CODIGO, count(*) from gd_esquema.Maestra where PASAJE_CODIGO is not null group by PASAJE_CODIGO having count(*)>1
insert into [LEISTE_EL_CODIGO?].PagoDeViaje(fecha_pago,monto_total,id_cliente)
select PASAJE_FECHA_COMPRA,PASAJE_PRECIO,(select id_cliente
										from [LEISTE_EL_CODIGO?].Cliente
									where nombre=m.CLI_NOMBRE and apellido=m.CLI_APELLIDO and dni=m.CLI_DNI and telefono=m.CLI_TELEFONO and fecha_nacimiento = m.CLI_FECHA_NAC)cliente
		 
from gd_esquema.Maestra m
where PASAJE_FECHA_COMPRA is not null and PASAJE_PRECIO is not null
go
-------------------------------------------------Reserva-----------------------------------------
insert into [LEISTE_EL_CODIGO?].Reserva (id_reserva,fecha_actual,id_cliente,id_crucero,id_viaje,id_cabina)
select RESERVA_CODIGO,RESERVA_FECHA,
		(select id_cliente
		from [LEISTE_EL_CODIGO?].Cliente
		where nombre=m.CLI_NOMBRE and apellido=m.CLI_APELLIDO and dni=m.CLI_DNI and telefono=m.CLI_TELEFONO and fecha_nacimiento = m.CLI_FECHA_NAC),
		m.CRUCERO_IDENTIFICADOR,
		(select id_viaje
		from [LEISTE_EL_CODIGO?].Viaje
		where id_recorrido=m.RECORRIDO_CODIGO and fecha_inicio=m.FECHA_SALIDA and fecha_finalizacion= m.FECHA_LLEGADA 
		and fecha_finalizacion_estimada=m.FECHA_LLEGADA_ESTIMADA and id_crucero = m.CRUCERO_IDENTIFICADOR),
		(select id_cabina
		from [LEISTE_EL_CODIGO?].Cabina
		where numero= m.CABINA_NRO and id_crucero= m.CRUCERO_IDENTIFICADOR and piso = m.CABINA_PISO and id_tipo = m.CABINA_TIPO)
from gd_esquema.Maestra m
where RESERVA_CODIGO is not null and RESERVA_FECHA is not null 
go
-------------------------------------------------Viaje------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Viaje (fecha_inicio,fecha_finalizacion,fecha_finalizacion_estimada,id_crucero,id_recorrido)
select distinct FECHA_SALIDA,FECHA_LLEGADA,FECHA_LLEGADA_ESTIMADA,CRUCERO_IDENTIFICADOR,RECORRIDO_CODIGO 
from gd_esquema.Maestra
go
---------------------------------------------Pasaje-----------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Pasaje (id_cabina,id_cliente,id_viaje,id_crucero,precio,id_pasaje)
select distinct(select id_cabina
		from [LEISTE_EL_CODIGO?].Cabina
		where numero= m.CABINA_NRO and id_crucero= m.CRUCERO_IDENTIFICADOR and piso = m.CABINA_PISO and id_tipo = m.CABINA_TIPO)idCabina,
		(select c.id_cliente
		from [LEISTE_EL_CODIGO?].Cliente c
		where nombre=m.CLI_NOMBRE and apellido=m.CLI_APELLIDO and dni=m.CLI_DNI and telefono=m.CLI_TELEFONO and fecha_nacimiento = m.CLI_FECHA_NAC)cliente,
		(select id_viaje
		from [LEISTE_EL_CODIGO?].Viaje
		where id_recorrido=m.RECORRIDO_CODIGO and fecha_inicio=m.FECHA_SALIDA and fecha_finalizacion= m.FECHA_LLEGADA and fecha_finalizacion_estimada=m.FECHA_LLEGADA_ESTIMADA and id_crucero = m.CRUCERO_IDENTIFICADOR),
		m.CRUCERO_IDENTIFICADOR,m.PASAJE_PRECIO,m.PASAJE_CODIGO
from gd_esquema.Maestra m
where m.PASAJE_CODIGO is not null and m.PASAJE_PRECIO is not null

go
update [LEISTE_EL_CODIGO?].Pasaje
set id_pago = p.id_pago
from [LEISTE_EL_CODIGO?].PagoDeViaje p
where Pasaje.id_cliente = p.id_cliente
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
						where fecha_inicio not between @fecha_inicio and @fecha_finalizacion_estimada --fijarse cambiar los between
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
		--CARGAR CRUCERO--
if exists (select * from sys.procedures where name = 'cargarCrucero')
	drop procedure [LEISTE_EL_CODIGO?].cargarCrucero
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].cargarCrucero(@id_crucero nvarchar(50),@id_fabricante nvarchar(255),@modelo nvarchar(50),@cantidadDeCabinas int)
as
	begin
		declare @valor_retorno tinyint
		if not exists( select id_fabricante
						from [LEISTE_EL_CODIGO?].Fabricante 
						where id_fabricante=@id_fabricante)
			begin
				set @valor_retorno = -1 -- no existe el fabricante
			end
		else if (@cantidadDeCabinas < 0)
			begin
				set @valor_retorno = -2 -- cantidad de cabinas invalida
			end
		else
			begin
				insert into [LEISTE_EL_CODIGO?].Crucero(id_crucero,id_fabricante,modelo,cantidadDeCabinas)
				values(@id_crucero,@id_fabricante, @modelo, @cantidadDeCabinas)
				set @valor_retorno = 1 --se cargo el crucero
			end
		return @valor_retorno
	end
go											     
		--DAR CRUCERO DE BAJA DEFINITIVA--
if exists (select * from sys.procedures where name = 'darDeBajaDefinitivaCrucero')
	drop procedure [LEISTE_EL_CODIGO?].darDeBajaDefinitivaCrucero
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].darDeBajaDefinitivaCrucero(@id_crucero nvarchar(50),@fecha_actual datetime2) --@motivo
as
	begin
		update [LEISTE_EL_CODIGO?].Crucero
		set baja_fuera_vida_util = 'S',fecha_baja_por_vida_util = @fecha_actual --fijarse ese fuera
		where id_crucero = @id_crucero
		--exec de procedure y que pase motivo x parametro y id_crucero, idem abajo
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
		set baja_fuera_de_servicio = 'S',fecha_reinicio_servicio = @fecha_reinicio, 
		fecha_baja_por_fuera_de_servicio= GETDATE()
		where id_crucero = @id_crucero
	end
go

--------------------------auditar cancelacion de pasajes ------------------
if exists (select * from sys.procedures where name = 'auditarCancelacion')
	drop procedure [LEISTE_EL_CODIGO?].auditarCancelacion
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].auditarCancelacion(@id_crucero nvarchar(50),@motivo varchar(256))
as
	begin
		insert into [LEISTE_EL_CODIGO?].AuditoriaDeCruceros(id_crucero,motivo)
		values(@id_crucero,@motivo)
	end
go

------------------cancelarPasajes -------------------------------
if exists (select * from sys.procedures where name = 'cancelarPasajes')
	drop procedure [LEISTE_EL_CODIGO?].cancelarPasajes
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].cancelarPasajes(@id_crucero nvarchar(50),@fecha_actual datetime2,@motivo varchar(256))
as
	begin
		update [LEISTE_EL_CODIGO?].Pasaje
		set cancelacion = 'S',fecha_cancelacion = @fecha_actual
		from [LEISTE_EL_CODIGO?].Viaje v
		where Pasaje.id_crucero = @id_crucero and (Pasaje.id_viaje = v.id_viaje and v.fecha_inicio>=@fecha_actual)

		exec [LEISTE_EL_CODIGO?].auditarCancelacion @id_crucero, @motivo
	end
go

------Agregar nueva funcionalidad a un rol-------REQUERIMIENTO: 
		--En la modificación de un rol solo se pueden alterar ambos campos: el nombre y el
		--listado de funcionalidades.
if exists (select * from sys.procedures where name = 'agregarFuncionalidadPorRol')
	drop procedure [LEISTE_EL_CODIGO?].agregarFuncionalidadPorRol
USE GD1C2019
go


create procedure [LEISTE_EL_CODIGO?].agregarFuncionalidadPorRol (@idRol smallint,@idNuevaFuncionalidad smallint,@nuevoNombreRol nvarchar(255))
as
	begin
		declare @valor_retorno smallint
		if(not exists (select id_rol from [LEISTE_EL_CODIGO?].Rol where id_rol= @idRol)) set @valor_retorno = -1 --no existe rol
		else if
		(not exists (select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad where id_funcionalidad= @idNuevaFuncionalidad)) set @valor_retorno = -2 -- no existe funcionalidad
		else if
		(exists (select id_funcionalidad,id_rol from [LEISTE_EL_CODIGO?].FuncionalidadPorRol 
						where id_funcionalidad= @idNuevaFuncionalidad and id_rol = @idRol)) set @valor_retorno = -3 -- el rol ya tiene esa funcionalidad
		else
			begin
				insert into [LEISTE_EL_CODIGO?].Rol(nombre)
				values(@nuevoNombreRol) --agrego rol en la tabla
		
				declare @idNuevoRol smallint
				select @idNuevoRol= id_rol from [LEISTE_EL_CODIGO?].Rol where nombre = @nuevoNombreRol
				insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) -- aca le pongo al nuevo rol las funcionalidades del otro rol
				select @idNuevoRol,id_funcionalidad
				from [LEISTE_EL_CODIGO?].FuncionalidadPorRol
				where id_rol= @idRol

				insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) --aca agrego la nueva funcionalidad
				values(@idNuevoRol, @idNuevaFuncionalidad)
				set @valor_retorno = 1 -- se cargo correctamente el nuevo rol
			end
		return @valor_retorno
	end
go

		-------eliminar funcionalidad de un rol-----------

if exists (select * from sys.procedures where name = 'eliminarFuncionalidadRol')
	drop procedure [LEISTE_EL_CODIGO?].eliminarFuncionalidadRol
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].eliminarFuncionalidadRol (@idRol smallint,@idFuncionalidadAEliminar smallint,@nuevoNombreRol nvarchar(255))
as
	begin
		declare @valor_retorno smallint
		if(not exists (select id_rol from [LEISTE_EL_CODIGO?].Rol where id_rol= @idRol)) set @valor_retorno = -1 --no existe rol
		else if
		(not exists (select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad where id_funcionalidad= @idFuncionalidadAEliminar)) set @valor_retorno = -2 -- no existe funcionalidad
		else if
		(exists (select id_funcionalidad,id_rol from [LEISTE_EL_CODIGO?].FuncionalidadPorRol 
						where id_funcionalidad= @idFuncionalidadAEliminar and id_rol = @idRol)) set @valor_retorno = -3 -- no tiene esa funcionalidad
		
		else
			begin
				insert into [LEISTE_EL_CODIGO?].Rol(nombre)
				values(@nuevoNombreRol) --agrego rol en la tabla
		
				declare @idNuevoRol smallint
				select @idNuevoRol= id_rol from [LEISTE_EL_CODIGO?].Rol where nombre = @nuevoNombreRol
				insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) -- todas menos la funcionalidad a eliminar 
				select @idNuevoRol,id_funcionalidad
				from [LEISTE_EL_CODIGO?].FuncionalidadPorRol
				where id_rol= @idRol and id_funcionalidad <> @idFuncionalidadAEliminar

				set @valor_retorno = 1 -- se cargo correctamente el nuevo rol
			end
		return @valor_retorno
	end
go

		-------- Crear Nuevo Rol --------- deberia usarse dentro de un while, lo hago para uno a la vez por ahora
if exists (select * from sys.procedures where name = 'crearNuevoRol')
	drop procedure [LEISTE_EL_CODIGO?].crearNuevoRol
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].crearNuevoRol (@idFuncionalidad smallint,@NombreRol nvarchar(255))
as
begin
		declare @valor_retorno smallint
		if
		(not exists (select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad where id_funcionalidad= @idFuncionalidad)) set @valor_retorno = -2 -- no existe funcionalidad
		else
			begin
				if(not exists (select nombre from [LEISTE_EL_CODIGO?].Rol where nombre= @NombreRol)) -- si es la primer vez que lo carga
					begin
						insert into [LEISTE_EL_CODIGO?].Rol(nombre)
						values(@NombreRol) --agrego rol en la tabla
					end
		
				declare @idNuevoRol smallint
				select @idNuevoRol= id_rol from [LEISTE_EL_CODIGO?].Rol where nombre = @NombreRol

				if
					(exists (select id_funcionalidad,id_rol from [LEISTE_EL_CODIGO?].FuncionalidadPorRol 
								where id_funcionalidad= @idFuncionalidad and id_rol = @idNuevoRol)) set @valor_retorno = -3 -- ya tiene esa funcionalidad

				insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
				values(@idNuevoRol,@idFuncionalidad)
				set @valor_retorno = 1
			end
		return @valor_retorno
end
go

----------------------------Dar de baja un rol-----------------------------------

if exists (select * from sys.procedures where name = 'darBajaRol')
	drop procedure [LEISTE_EL_CODIGO?].darBajaRol
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].darBajaRol (@idRol smallint)
as
	begin
		declare @valor_retorno smallint
		if
		(not exists (select id_rol from [LEISTE_EL_CODIGO?].Rol where id_rol= @idRol)) set @valor_retorno = -1 -- no existe rol
		else 
			begin
				update [LEISTE_EL_CODIGO?].Rol
				set baja_logica = 'S'
				where id_rol = @idRol

				update [LEISTE_EL_CODIGO?].Usuario
				set id_rol = NULL
				where id_rol = @idRol
				update [LEISTE_EL_CODIGO?].Cliente
				set id_rol = NULL
				where id_rol = @idRol
			end
		return @valor_retorno
	end
go		
	
-------------------------------Habilitar un rol inhabilitado ---------------------------------
if exists (select * from sys.procedures where name = 'darAltaRol')
	drop procedure [LEISTE_EL_CODIGO?].darAltaRol
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].darAltaRol (@idRol smallint)
as
	begin
		declare @valor_retorno smallint
		if
		(not exists (select id_rol from [LEISTE_EL_CODIGO?].Rol where id_rol= @idRol)) set @valor_retorno = -1 -- no existe rol
		else 
			begin
				update [LEISTE_EL_CODIGO?].Rol
				set baja_logica = 'N'
				where id_rol = @idRol	
			end
		return @valor_retorno
	end
go

----------------------------viajes disponibles para esa fecha, junto con las cabinas (y sus tipos) --------
if exists (select * from sys.procedures where name = 'mostrarViajesDisponibles')
	drop procedure [LEISTE_EL_CODIGO?].mostrarViajesDisponibles
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].mostrarViajesDisponibles (@fecha_inicio datetime2(3),@origen nvarchar(255),@destino nvarchar(255))
as
	begin
		select v.id_viaje,v.fecha_inicio,v.id_crucero crucero, ca.id_tipo tipoDeCabina,cr.cantidadDeCabinas -
		(select count(*) 
		from [LEISTE_EL_CODIGO?].Reserva r
		where r.id_viaje = v.id_viaje)-
		(select count(*)
		from [LEISTE_EL_CODIGO?].Pasaje p
		where p.id_viaje = v.id_viaje) cantidadDeCabinasDisponibles
		from [LEISTE_EL_CODIGO?].Viaje v 
		join [LEISTE_EL_CODIGO?].Crucero cr on v.id_crucero = cr.id_crucero
		join [LEISTE_EL_CODIGO?].Cabina ca on v.id_crucero = ca.id_crucero
		join [LEISTE_EL_CODIGO?].Recorrido rec on v.id_recorrido = rec.id_recorrido
		where MONTH(v.fecha_inicio) = MONTH(@fecha_inicio) and YEAR(v.fecha_inicio) = YEAR(@fecha_inicio) and
		DAY(v.fecha_inicio)=DAY(@fecha_inicio) and rec.id_origen = @origen and rec.id_destino = @destino
	end
go

---CVDUGH-82620
--2018-06-22 04:00:00.000   //43820892   PORT LOUIS  NUAKCHOT
--2018-07-05 07:00:00.000   //43820875  EL CAIRO	ASMARA
--declare @fecha_inicio datetime2(3),@origen nvarchar(255),@destino nvarchar(255)
--set @fecha_inicio = '2018-04-23 03:00:00.000'
--set @origen ='LUANDA'
--set @destino = 'ARGEL'

--exec [LEISTE_EL_CODIGO?].mostrarViajesDisponibles @fecha_inicio, @origen, @destino
-------------------------todo despues de seleccionar un viaje----------------- ingresar cliente
if exists (select * from sys.procedures where name = 'ingresarCliente')
	drop procedure [LEISTE_EL_CODIGO?].ingresarCliente
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].ingresarCliente (@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),
													@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255))
as
	begin
		insert into [LEISTE_EL_CODIGO?].Cliente(nombre,apellido,dni,telefono,mail,fecha_nacimiento,direccion)
		values(@nombre,@apellido,@dni,@telefono,@mail,@fecha_nacimiento,@direccion)
	end
go
-----------------------------------buscarPorDni------------------------------------
if exists (select * from sys.procedures where name = 'buscarPorDni')
	drop procedure [LEISTE_EL_CODIGO?].buscarPorDni
USE GD1C2019
go

create procedure [LEISTE_EL_CODIGO?].buscarPorDni (@dni decimal(18, 0)) 
as
	begin
		select id_cliente,nombre,apellido,dni,direccion,telefono,mail,fecha_nacimiento 
		from [LEISTE_EL_CODIGO?].Cliente
		where dni=@dni
	end
go

----------------------------actualizar usuario------------------------------------
if exists (select * from sys.procedures where name = 'actualizarUsuario')
	drop procedure [LEISTE_EL_CODIGO?].actualizarUsuario
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].actualizarUsuario (@idCliente int,@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),
													@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255)) 
as
	begin
		update [LEISTE_EL_CODIGO?].Cliente
		set nombre = coalesce(@nombre,nombre),
		apellido = coalesce(@apellido,apellido),
		dni = coalesce(@dni,dni), telefono = coalesce(@telefono,telefono),
		mail = coalesce(@mail,mail),
		fecha_nacimiento = coalesce(@fecha_nacimiento,fecha_nacimiento),
		direccion= coalesce(@direccion,direccion)
		where id_cliente = @idCliente
	end
go
----------------------------------devolverIdPago--------------------------------
if exists (select * from sys.procedures where name = 'devolverIdPago')
	drop procedure [LEISTE_EL_CODIGO?].devolverIdPago
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].devolverIdPago (@cantidadDePasajes smallint,@idMedioPago int,@montoTotal int)
as	
	begin
		declare @idPago int
		insert into [LEISTE_EL_CODIGO?].PagoDeViaje(fecha_pago,monto_total,cantidad_de_pasajes,id_medio_de_pago)
		values(CAST(SYSDATETIME() as datetime2(3)),@montoTotal,@cantidadDePasajes,@idMedioPago)
		SELECT @idPago= SCOPE_IDENTITY()
		return @idPago
	end
go		

--@#

--Fran dudas: @@@
--			el id de recorrido me lo pasa él o lo tengo q poner yo?
--			creo q el minimo de tramos por recorrido es 1 no 2 como pusieron en el doc
--			no se podrá dar de baja un recorrido que tenga pasajes vendidos sin haber realizado el viaje. : debe estar mal escrito y hablar de modificar
--			error? tanto pasaje como viaje guardan el crucero
--			no toy chequeando q cumpla con lo q dijo en recorrido en cuanto a origen y destino
--			tengo q revisar en la creacion de reserva q el cliente no tenga un viaje en la misma fecha? o eso ya se hace antes?
--			cuando creo la reserva tengo q bloquear la cabina, o eso se hace antes?

----------------------------------crearTramo--------------------------------
--la creacion debe ir en orden, del 1 al  ultimo
if exists (select * from sys.procedures where name = 'crearTramo')
	drop procedure [LEISTE_EL_CODIGO?].cargarTramo
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crearTramo
(@idRecorrido decimal(18,0),@origen nvarchar(255),@destino nvarchar(255),@orden smallint,@precio decimal(18,2))
as
	begin
	--confio que va a cumplir con el origen y destino que indicó en recorrido asi q no chequeo eso
	if @origen = @destino return -1 --origen y destino son el mismo
	else if @orden<>1 and @origen <> (select id_destino from [LEISTE_EL_CODIGO?].Tramo where id_recorrido = @idRecorrido and orden = @orden-1)
		return -2 --el origen de este tramo no es el destino del tramo anterior
	
	insert into [LEISTE_EL_CODIGO?].Tramo(id_recorrido,id_origen,id_destino,orden,precio_base)
	values(@idRecorrido,@origen,@destino,@orden,@precio)
	return 1
	end
go

----------------------------------crearRecorrido--------------------------------
if exists (select * from sys.procedures where name = 'crearRecorrido')
	drop procedure [LEISTE_EL_CODIGO?].crearRecorrido
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crearRecorrido
(@idRecorrido decimal(18,0),@origen nvarchar(255),@destino nvarchar(255))
as
	--begin try
	--if exists(select id_recorrido from [LEISTE_EL_CODIGO?].Recorrido where id_recorrido=@idRecorrido) return -1 --el id ya existe
	insert into [LEISTE_EL_CODIGO?].Recorrido(id_recorrido,estado,id_origen,id_destino)
	values(@idRecorrido,'A',@origen,@destino)
	--return 1 --se creo el recorrido
	--end try
	--begin catch
	--if ERROR_NUMBER()=2627 return -1--el id de recorrido ya esta en uso
	--else if ERROR_NUMBER()=547 return -2 --uno o los dos puertos no existen
	--end catch
go

----------------------------------modificarRecorrido--------------------------------
--si el retorno es correcto entonces podes avanzar a modificar los tramos
if exists (select * from sys.procedures where name = 'modificarRecorrido')
	drop procedure [LEISTE_EL_CODIGO?].modificarRecorrido
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].modificarRecorrido
(@idRecorrido decimal(13,0),@origen nvarchar(255),@destino nvarchar(255))
as
	begin
	if exists(select p.id_viaje from [LEISTE_EL_CODIGO?].Pasaje p 
				join [LEISTE_EL_CODIGO?].Viaje v 
				on p.id_viaje = v.id_viaje and v.fecha_inicio > SYSDATETIME() and (fecha_reprogramacion is null or fecha_reprogramacion>SYSDATETIME())
				where p.cancelacion = 'N'
	) return -1 --no se puede modificar xq todavia hay pasajes vendidos q no hicieron el viaje
	update [LEISTE_EL_CODIGO?].Recorrido
	set id_origen=@origen,id_destino=@destino
	where id_recorrido= @idRecorrido
	return 1
	end
go

----------------------------------modificarTramo--------------------------------
--se debe hacer tmb en orden del 1 al ultimo
if exists (select * from sys.procedures where name = 'modificarTramo')
	drop procedure [LEISTE_EL_CODIGO?].modificarTramo
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].modificarTramo
(@idTramo smallint,@origen nvarchar(255),@destino nvarchar(255),@precio decimal(18,2))
as
	begin
		if @origen = @destino return -1 --origen y destino son el mismo
		else if (select orden from [LEISTE_EL_CODIGO?].Tramo where id_tramo=@idTramo) <> 1 and 
				 @origen <> (select id_destino from [LEISTE_EL_CODIGO?].Tramo 
								where id_recorrido = (select id_recorrido from [LEISTE_EL_CODIGO?].Tramo t where @idTramo = t.id_tramo)
									and orden = (select t2.orden from [LEISTE_EL_CODIGO?].Tramo t2 where @idTramo = t2.id_tramo) -1)
		return -2 --el origen de este tramo no es el destino del tramo anterior  
		update [LEISTE_EL_CODIGO?].Tramo
		set id_origen=@origen,id_destino=@destino,precio_base=@precio
		return 1
	end
go

----------------------------------darDeBajaRecorrido--------------------------------
if exists (select * from sys.procedures where name = 'crearRecorrido')
	drop procedure [LEISTE_EL_CODIGO?].darDeBajaRecorrido
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].darDeBajaRecorrido
(@idRecorrido decimal(18,0))
as
	update [LEISTE_EL_CODIGO?].Recorrido
	set estado = 'I'
	where id_recorrido = @idRecorrido
	--@no se q onda con el tema de si ya tiene pasajes vendidos
go

----------------------------------eliminarTramo--------------------------------
if exists (select * from sys.procedures where name = 'eliminarTramo')
	drop procedure [LEISTE_EL_CODIGO?].eliminarTramo
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].eliminarTramo(@id_tramo smallint)
as
	delete from [LEISTE_EL_CODIGO?].Tramo where id_tramo=@id_tramo
go

----------------------------------crearReserva--------------------------------
if exists (select * from sys.procedures where name = 'crearReserva')
	drop procedure [LEISTE_EL_CODIGO?].reservarViaje
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crearReserva
(@idReserva decimal(18,0),@idCrucero nvarchar(50),@idCliente int,@idViaje int,@idCabina smallint)
as
	begin
	if exists(select id_reserva from [LEISTE_EL_CODIGO?].Reserva where id_reserva = @idReserva) return -1 --ese id ya está en uso
	insert into [LEISTE_EL_CODIGO?].Reserva(id_reserva,id_crucero,id_cliente,id_viaje,id_cabina,fecha_actual)
	values(@idReserva,@idCrucero,@idCliente,@idViaje,@idCabina,CAST(SYSDATETIME() as datetime2(3)))
	return 1 --todo bien
	end
go





--@#


-----------------------------------------ABM 10 <LISTADOS ESTADISTICOS>------------------------------------

--------------TOP RECORRIDOS CON MAS PASAJES VENDIDOS----------------------------
if exists (select * from sys.procedures where name = 'topRecorridosConMasPasajesComprados')
	drop procedure [LEISTE_EL_CODIGO?].topRecorridosConMasPasajesComprados
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].topRecorridosConMasPasajesComprados (@anio int, @semestre int)
as
	declare @mesInicial smallint,@mesFinal smallint
	if @semestre = 1
		begin
			set @mesInicial = 1
			set @mesFinal = 6
		end
	else if @semestre=2
		begin
			set @mesInicial = 6
			set @mesFinal = 12
		end
	begin
		select top 5 r.id_recorrido, count(p.id_pasaje) cantidadDePasajesVendidos, r.id_origen origen, r.id_destino destino
		from [LEISTE_EL_CODIGO?].Recorrido r 
		join [LEISTE_EL_CODIGO?].Viaje v on r.id_recorrido = v.id_recorrido
		join [LEISTE_EL_CODIGO?].Pasaje p on v.id_viaje = p.id_viaje
		join [LEISTE_EL_CODIGO?].PagoDeViaje pa on p.id_pago = pa.id_pago
		where year(pa.fecha_pago) = @anio and MONTH(pa.fecha_pago) between @mesInicial and @mesFinal
		group by r.id_recorrido, r.id_origen, r.id_destino
		order by count(r.id_recorrido) desc
	end
go		
--declare @anio int, @semestre int
--set @anio = 2018
--set @semestre = 1
--exec [LEISTE_EL_CODIGO?].topRecorridosConMasPasajesComprados @anio, @semestre (para testear)

-------------------------------TOP 5 RECORRIDOS CON MAS CABINAS LIBRES EN VIAJES REALIZADOS-------------------
if exists (select * from sys.procedures where name = 'topMasCabinasLibres')
	drop procedure [LEISTE_EL_CODIGO?].topMasCabinasLibres
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].topMasCabinasLibres (@anio int, @semestre int)
as	
	declare @mesInicial smallint,@mesFinal smallint
	if @semestre = 1
		begin
			set @mesInicial = 1
			set @mesFinal = 6
		end
	else if @semestre=2
		begin
			set @mesInicial = 6
			set @mesFinal = 12
		end
	begin
		select top 5 r.id_recorrido, r.id_origen origen, r.id_destino destino,
		sum(cr.cantidadDeCabinas) - (select count(*)
									from [LEISTE_EL_CODIGO?].Pasaje p join [LEISTE_EL_CODIGO?].Viaje v
									on p.id_viaje = v.id_viaje
									where v.id_recorrido = r.id_recorrido and
									year(v.fecha_finalizacion) = @anio and MONTH(v.fecha_finalizacion) between @mesInicial and @mesFinal) cabinasLibres
		from [LEISTE_EL_CODIGO?].Recorrido r 
		join [LEISTE_EL_CODIGO?].Viaje v on r.id_recorrido = v.id_recorrido
		join [LEISTE_EL_CODIGO?].Crucero cr on  v.id_crucero=cr.id_crucero
		where year(v.fecha_finalizacion) = @anio and MONTH(v.fecha_finalizacion) between @mesInicial and @mesFinal
		group by r.id_recorrido, r.id_origen, r.id_destino
		order by 4 desc
	end
go	
--declare @anio int, @semestre int
--set @anio = 2018
--set @semestre = 2
--exec [LEISTE_EL_CODIGO?].topMasCabinasLibres @anio, @semestre (para testear)

-------------------------------TOP 5 CRUCEROS CON MAYOR CANTIDAD DE DIAS FUERA DE SERVICIO-------------------
if exists (select * from sys.procedures where name = 'topCrucerosFueraDeServicio')
	drop procedure [LEISTE_EL_CODIGO?].topCrucerosFueraDeServicio
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].topCrucerosFueraDeServicio (@anio int, @semestre int)
as	
	declare @mesInicial smallint,@mesFinal smallint
	if @semestre = 1
		begin
			set @mesInicial = 1
			set @mesFinal = 6
		end
	else if @semestre=2
		begin
			set @mesInicial = 6
			set @mesFinal = 12
		end
	begin
		select top 5 id_crucero, DATEDIFF(day,c.fecha_baja_por_fuera_de_servicio,c.fecha_reinicio_servicio) CantidadDiasDeBaja
		from [LEISTE_EL_CODIGO?].Crucero c
		where year(c.fecha_baja_por_fuera_de_servicio) = @anio and MONTH(c.fecha_baja_por_fuera_de_servicio) between @mesInicial and @mesFinal
		and year(c.fecha_reinicio_servicio) = @anio and MONTH(c.fecha_reinicio_servicio) between @mesInicial and @mesFinal
		--group by id_crucero
		order by 2 desc
	end
go	
--declare @dia1 datetime2, @dia2 datetime2
--set @dia1 = '2018-06-22 04:00:00.000'
--set @dia2 = '2018-07-05 07:00:00.000'
--print datediff(day, @dia1, @dia2)
--begin transaction
--update [LEISTE_EL_CODIGO?].Crucero
--set fecha_baja_por_fuera_de_servicio = '2018-04-22 04:00:00.000',
--fecha_reinicio_servicio = '2018-05-05 07:00:00.000'
--where id_crucero = 'ASHFLJ-66175'
--declare @anio int, @semestre int
--set @anio = 2018
--set @semestre = 1
--exec [LEISTE_EL_CODIGO?].topCrucerosFueraDeServicio @anio, @semestre --(para testear)
--ROLLBACK TRANSACTION

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
-------------------Vista de roles habilitados--------------------------------
if exists(select * from sys.views where object_name(object_id)='RolesHabilitados' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].RolesHabilitados
	end
go
USE GD1C2019
go

create view [LEISTE_EL_CODIGO?].RolesHabilitados
as
		select id_rol,nombre
		from [LEISTE_EL_CODIGO?].Rol
		where baja_logica = 'N' -- ver despues si es necesario tambien hacer una vista con todos los roles, habilitados o no.
go






