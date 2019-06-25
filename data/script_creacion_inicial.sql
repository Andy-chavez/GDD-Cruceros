USE GD1C2019
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--........................................ DROPS POR SI EXISTEN PREVIAMENTE ......................................................
if exists (select * from sys.schemas where name =  'LEISTE_EL_CODIGO?')
begin
	if exists(select * from sys.tables where object_name(object_id)='ReservasPagadas'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].ReservasPagadas
	if exists(select * from sys.tables where object_name(object_id)='AuditoriaReservasVencidas'and schema_name(schema_id)='LEISTE_EL_CODIGO?')
		drop table  [LEISTE_EL_CODIGO?].AuditoriaReservasVencidas
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
if exists (select * from sys.procedures where name = 'sp_login')
	drop procedure [LEISTE_EL_CODIGO?].sp_login
if exists (select * from sys.procedures where name = 'cargarViaje')
	drop procedure [LEISTE_EL_CODIGO?].cargarViaje
if exists (select * from sys.procedures where name = 'cargarCrucero')
	drop procedure [LEISTE_EL_CODIGO?].cargarCrucero
if exists (select * from sys.procedures where name = 'darDeBajaDefinitivaCrucero')
	drop procedure [LEISTE_EL_CODIGO?].darDeBajaDefinitivaCrucero
if exists (select * from sys.procedures where name = 'darDeBajaTemporalCrucero')
	drop procedure [LEISTE_EL_CODIGO?].darDeBajaTemporalCrucero
if exists (select * from sys.procedures where name = 'auditarCancelacion')
	drop procedure [LEISTE_EL_CODIGO?].auditarCancelacion
if exists (select * from sys.procedures where name = 'posponerPasajes')
	drop procedure [LEISTE_EL_CODIGO?].posponerPasajes
if exists (select * from sys.procedures where name = 'calcularCabinaPorTipo')
	drop procedure [LEISTE_EL_CODIGO?].calcularCabinaPorTipo
if exists (select * from sys.procedures where name = 'reemplazarViajesCruceroPorOtro')
	drop procedure [LEISTE_EL_CODIGO?].reemplazarViajesCruceroPorOtro
if exists (select * from sys.procedures where name = 'cancelarPasajes')
	drop procedure [LEISTE_EL_CODIGO?].cancelarPasajes
if exists (select * from sys.procedures where name = 'agregarFuncionalidadPorRol')
	drop procedure [LEISTE_EL_CODIGO?].agregarFuncionalidadPorRol
if exists (select * from sys.procedures where name = 'eliminarFuncionalidadRol')
	drop procedure [LEISTE_EL_CODIGO?].eliminarFuncionalidadRol
if exists (select * from sys.procedures where name = 'crearNuevoRol')
	drop procedure [LEISTE_EL_CODIGO?].crearNuevoRol
if exists (select * from sys.procedures where name = 'darBajaRol')
	drop procedure [LEISTE_EL_CODIGO?].darBajaRol
if exists (select * from sys.procedures where name = 'darAltaRol')
	drop procedure [LEISTE_EL_CODIGO?].darAltaRol
if exists (select * from sys.procedures where name = 'crearTramo')
	drop procedure [LEISTE_EL_CODIGO?].crearTramo
if exists (select * from sys.procedures where name = 'crearRecorrido')
	drop procedure [LEISTE_EL_CODIGO?].crearRecorrido
if exists (select * from sys.procedures where name = 'modificarRecorrido')
	drop procedure [LEISTE_EL_CODIGO?].modificarRecorrido
if exists (select * from sys.procedures where name = 'modificarTramo')
	drop procedure [LEISTE_EL_CODIGO?].modificarTramo
if exists (select * from sys.procedures where name = 'darDeBajaRecorrido')
	drop procedure [LEISTE_EL_CODIGO?].darDeBajaRecorrido
if exists (select * from sys.procedures where name = 'eliminarTramo')
	drop procedure [LEISTE_EL_CODIGO?].eliminarTramo
if exists (select * from sys.procedures where name = 'crearReserva')
	drop procedure [LEISTE_EL_CODIGO?].crearReserva
if exists (select * from sys.procedures where name = 'pasajeroYaTieneViajeEnLaFecha')
	drop procedure [LEISTE_EL_CODIGO?].pasajeroYaTieneViajeEnLaFecha
if exists (select * from sys.procedures where name = 'mostrarViajesDisponibles')
	drop procedure [LEISTE_EL_CODIGO?].mostrarViajesDisponibles
if exists (select * from sys.procedures where name = 'ingresarCliente')
	drop procedure [LEISTE_EL_CODIGO?].ingresarCliente
if exists (select * from sys.procedures where name = 'buscarPorDni')
	drop procedure [LEISTE_EL_CODIGO?].buscarPorDni 
if exists (select * from sys.procedures where name = 'actualizarUsuario')
	drop procedure [LEISTE_EL_CODIGO?].actualizarUsuario
if exists (select * from sys.procedures where name = 'cargarMedioDePago')
	drop procedure [LEISTE_EL_CODIGO?].cargarMedioDePago
if exists (select * from sys.procedures where name = 'devolverIdPago')
	drop procedure [LEISTE_EL_CODIGO?].devolverIdPago
if exists (select * from sys.procedures where name = 'comprarPasaje')
	drop procedure [LEISTE_EL_CODIGO?].comprarPasaje
if exists (select * from sys.procedures where name = 'verVoucher')
	drop procedure [LEISTE_EL_CODIGO?].verVoucher
if exists (select * from sys.procedures where name = 'modificarCrucero')
	drop procedure [LEISTE_EL_CODIGO?].modificarCrucero
if exists (select * from sys.procedures where name = 'topRecorridosConMasPasajesComprados')
	drop procedure [LEISTE_EL_CODIGO?].topRecorridosConMasPasajesComprados
if exists (select * from sys.procedures where name = 'topMasCabinasLibres')
	drop procedure [LEISTE_EL_CODIGO?].topMasCabinasLibres
if exists (select * from sys.procedures where name = 'topCrucerosFueraDeServicio')
	drop procedure [LEISTE_EL_CODIGO?].topCrucerosFueraDeServicio
if exists (select * from sys.procedures where name = 'eliminarReservasVencidas')
	drop procedure [LEISTE_EL_CODIGO?].eliminarReservasVencidas
if exists (select * from sys.procedures where name = 'actualizarMontoTotal')
	drop procedure [LEISTE_EL_CODIGO?].actualizarMontoTotal
if exists (select * from sys.procedures where name = 'calcularPrecioPasaje')
	drop procedure [LEISTE_EL_CODIGO?].calcularPrecioPasaje
if exists (select * from sys.procedures where name = 'mostrarReserva')
	drop procedure [LEISTE_EL_CODIGO?].mostrarReserva
if exists (select * from sys.procedures where name = 'comprarPasajeReservado')
	drop procedure [LEISTE_EL_CODIGO?].comprarPasajeReservado
if exists (select * from sys.procedures where name = 'crucerosDisponiblesParaViaje')
	drop procedure [LEISTE_EL_CODIGO?].crucerosDisponiblesParaViaje
if exists (select * from sys.procedures where name = 'obtenerIdCliente')
	drop procedure [LEISTE_EL_CODIGO?].obtenerIdCliente
go
 if exists(select * from sys.views where object_name(object_id)='CrucerosDisponibles' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].CrucerosDisponibles
	end
go
 if exists(select * from sys.views where object_name(object_id)='MediosDePagosDisponibles' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].MediosDePagosDisponibles
	end
go
if exists(select * from sys.views where object_name(object_id)='RolesHabilitados' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].RolesHabilitados
	end
go
if exists(select * from sys.views where object_name(object_id)='ViajesConRecorridosHabilitados' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].ViajesConRecorridosHabilitados
	end
go
if exists (select * from sys.triggers where object_name(object_id)='fechaVencimiento') --and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	drop trigger [LEISTE_EL_CODIGO?].fechaVencimiento
go
if exists (select * from sys.triggers where object_name(object_id)='auditarReservas') 
	drop trigger [LEISTE_EL_CODIGO?].auditarReservas
go
IF OBJECT_ID('tempdb..#tramoTemp') IS NOT NULL 
	DROP TABLE #tramoTemp
go
--........................................ CREACION DE TABLAS ......................................................
USE GD1C2019
go
create table [LEISTE_EL_CODIGO?].Rol(
	id_rol nvarchar(255) primary key,
	baja_logica char(1) not null default 'N' check(baja_logica in ('S','N')) 
)
go
create table [LEISTE_EL_CODIGO?].Usuario(
	id_usuario nvarchar(50) primary key,
	id_rol nvarchar(255) references [LEISTE_EL_CODIGO?].Rol, 
	contra varbinary(32),
	intentos_posibles smallint default 3,
	habilitado nchar(1) not null default 'A' check(habilitado in ('A','I'))
)
go
create table [LEISTE_EL_CODIGO?].Funcionalidad(
	id_funcionalidad nvarchar(100) primary key,
)
go
create table [LEISTE_EL_CODIGO?].FuncionalidadPorRol(
	id_funcionalidad nvarchar(100) references [LEISTE_EL_CODIGO?].Funcionalidad,
	id_rol nvarchar(255) references [LEISTE_EL_CODIGO?].Rol,
	primary key (id_rol, id_funcionalidad)
)
go
create table [LEISTE_EL_CODIGO?].Cliente(
	id_cliente int identity primary key,
	id_rol nvarchar(255) default 'cliente' references [LEISTE_EL_CODIGO?].Rol,
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
	id_servicio smallint references [LEISTE_EL_CODIGO?].Servicio,
	porcentaje_recargo decimal(18, 2) not null
)
go
create table [LEISTE_EL_CODIGO?].Cabina(
	id_cabina int identity primary key,
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
	fecha_finalizacion datetime2(3) null,
)
go
create table [LEISTE_EL_CODIGO?].Reserva(
	id_reserva decimal(18,0) identity primary key,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	id_cliente int references [LEISTE_EL_CODIGO?].Cliente,
	id_viaje int references [LEISTE_EL_CODIGO?].Viaje,
	id_cabina int references [LEISTE_EL_CODIGO?].Cabina,
	fecha_actual datetime2(3) not null,
	vencimiento datetime2(3) null,
)
go
create table [LEISTE_EL_CODIGO?].MedioDePago(
	id_medio_de_pago varchar(256) primary key,
	cuotas_sin_interes smallint not null,
)
go
create table [LEISTE_EL_CODIGO?].PagoDeViaje(
	id_pago int primary key identity,
	id_cliente int references [LEISTE_EL_CODIGO?].Cliente,
	fecha_pago datetime2(3) null,
	monto_total decimal(18,2),
	cantidad_de_pasajes smallint default 1 check(cantidad_de_pasajes > 0),
	id_medio_de_pago varchar(256) references [LEISTE_EL_CODIGO?].MedioDePago,
)
go
create table [LEISTE_EL_CODIGO?].Pasaje(
	id_pasaje decimal(18,0) primary key identity,
	id_viaje int references [LEISTE_EL_CODIGO?].Viaje,
	id_cliente int references [LEISTE_EL_CODIGO?].Cliente,
	id_cabina int references [LEISTE_EL_CODIGO?].Cabina,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	id_pago int references [LEISTE_EL_CODIGO?].PagoDeViaje,
	precio decimal(18,2),
	cancelacion nchar(1) default 'N' check(cancelacion in ('S','N')),
	fecha_cancelacion datetime2(3) null,
)
go
create table [LEISTE_EL_CODIGO?].AuditoriaDeCruceros(
	id_auditoria int identity primary key,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	motivo varchar(256)
)
go
create table [LEISTE_EL_CODIGO?].AuditoriaReservasVencidas(
	id_reservaVencida decimal(18,0) primary key,
	id_crucero nvarchar(50),
	id_cliente int,
	id_viaje int,
	id_cabina int,
	fecha_actual datetime2(3) not null,
	vencimiento datetime2(3) null,
)
go
create table [LEISTE_EL_CODIGO?].ReservasPagadas(
	id_reserva decimal(18,0) primary key,
	id_cliente int,
)
go
--........................................ TRIGGERS ......................................................
USE GD1C2019
go
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

--------------------------------trigger para auditar las reservas vencidas-----------------------(porque sino a la primera que se ejecuta el
																							-----aplicativo se borran todas las reservas porque estan vencidas
--create trigger auditarReservas on [LEISTE_EL_CODIGO?].Reserva
--after delete
--as
--	begin
--		insert into [LEISTE_EL_CODIGO?].AuditoriaReservasVencidas(id_reservaVencida,id_cabina,id_cliente,id_crucero,id_viaje,fecha_actual,vencimiento)
--		select id_reserva,id_cabina,id_cliente,id_crucero,id_viaje,fecha_actual,vencimiento
--		from deleted
--		where id_reserva not in (select id_reserva
--									from [LEISTE_EL_CODIGO?].ReservasPagadas)
--	end
--go

--........................................ INSERCIONES ......................................................
-- Funcionalidad
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('abm de rol')						-- Funcionalidad = 1
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('abm de cruceros')				-- Funcionalidad = 2
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('registro de usuarios')			-- Funcionalidad = 3
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('abm de puertos')					-- Funcionalidad = 4
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('abm de recorrido')				-- Funcionalidad = 5
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('generar viaje')					-- Funcionalidad = 6
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('compra y/o reserva de viaje')	-- Funcionalidad = 7
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('pago de reserva')				-- Funcionalidad = 8
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('listado estadistico')			-- Funcionalidad = 9
insert into [LEISTE_EL_CODIGO?].Funcionalidad(id_funcionalidad) values('login y seguridad')				-- Funcionalidad = 10
go
-- Rol
insert into [LEISTE_EL_CODIGO?].Rol(id_rol) values('administrador general')			--Rol 1 = administrador general
insert into [LEISTE_EL_CODIGO?].Rol(id_rol) values('administrador')					--Rol 2 = administrador
insert into [LEISTE_EL_CODIGO?].Rol(id_rol) values('cliente')						--Rol 3 = cliente
go
-- Funcionalidad por Rol
--ADMINISTRADOR GENERAL
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','abm de rol')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','abm de cruceros')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','registro de usuarios')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','abm de puertos')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','abm de recorrido')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','generar viaje')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','compra y/o reserva de viaje')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','pago de reserva')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador general','listado estadistico')
go
--ADMIN
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','abm de rol')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','abm de cruceros')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','registro de usuarios')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','abm de puertos')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','abm de recorrido')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','generar viaje')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','compra y/o reserva de viaje')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','pago de reserva')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('administrador','listado estadistico')
go

--******************************************creo que estos inserts feos pueden hacerse de otra forma 
--Cliente
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('cliente','compra y/o reserva de viaje')
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) values('cliente','pago de reserva')
go
----Contraseñas
declare @algo nvarchar(32)
set @algo = 'w23e'
declare @hash varbinary(32)
set @hash = hashbytes('SHA2_256', @algo)
--ADMINISTRADOR GENERAL
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('admin','administrador general',@hash)	
--ADMINISTRADORES
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('adminNuestro','administrador',@hash)
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contra) values('admin2','administrador',@hash)
go
--........................................ MIGRACION ......................................................
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

--------------------------------------Medio de pago--------------------------------------
insert into [LEISTE_EL_CODIGO?].MedioDePago(id_medio_de_pago,cuotas_sin_interes)
values('Efectivo',0)

insert into [LEISTE_EL_CODIGO?].MedioDePago(id_medio_de_pago,cuotas_sin_interes)
values('Debito',6)

insert into [LEISTE_EL_CODIGO?].MedioDePago(id_medio_de_pago,cuotas_sin_interes)
values('Credito',3)
--Servicio--
-- hay 5 tipos de cabinas asique hay 5 servicios asociados a ellas
--cabina exterior, ejecutivo,cabina estandar,suite,cabina balcon
insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion) values(1,'vista al mar') --(para cabina exterior)
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
where id_tipo like 'Cabina Balc%'
go
--Crucero-- (son 37 cruceros, se repiten varias veces por cada viaje)
insert into [LEISTE_EL_CODIGO?].Crucero(id_crucero,id_fabricante,modelo)
select distinct CRUCERO_IDENTIFICADOR,CRU_FABRICANTE,CRUCERO_MODELO
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

			update [LEISTE_EL_CODIGO?].Crucero
			set cantidadDeCabinas = @cant_cabinas
			where id_crucero = @id_crucero

			fetch next from cursor_cant
			into @id_crucero
		end
	close cursor_cant
	deallocate cursor_cant
go
-----------------------------Puerto------------------------------- no va nombre de puerto en la tabla, no va el campo ciudad, es irrelevante)
insert into [LEISTE_EL_CODIGO?].Puerto
select distinct PUERTO_DESDE from gd_esquema.Maestra where PUERTO_DESDE<> PUERTO_HASTA --corroborado
go
------------------------------------------ Recorrido ----------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Recorrido (id_recorrido)
select distinct RECORRIDO_CODIGO
from gd_esquema.Maestra
go
-----------------------------------------Tramo----------------------------------------------------------
create table #tramoTemp(
	id_tramo smallint identity primary key,
	id_recorrido decimal(18,0),
	id_origen nvarchar(255),
	id_destino nvarchar(255),
	orden smallint,
	precio_base decimal(18,2) not null
)
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
go
----------------------------------Medio de Pago--(esta la llenamos nosotros)
----------------------------------------Pago de viaje--
--select PASAJE_CODIGO, count(*) from gd_esquema.Maestra where PASAJE_CODIGO is not null group by PASAJE_CODIGO having count(*)>1
insert into [LEISTE_EL_CODIGO?].PagoDeViaje(fecha_pago,monto_total,id_cliente)
select PASAJE_FECHA_COMPRA,PASAJE_PRECIO,(select id_cliente
										from [LEISTE_EL_CODIGO?].Cliente
									where nombre=m.CLI_NOMBRE and apellido=m.CLI_APELLIDO and dni=m.CLI_DNI and telefono=m.CLI_TELEFONO and fecha_nacimiento = m.CLI_FECHA_NAC)cliente
from gd_esquema.Maestra m
where PASAJE_FECHA_COMPRA is not null and PASAJE_PRECIO is not null
go
-------------------------------------------------Viaje---------------------------------------
insert into [LEISTE_EL_CODIGO?].Viaje (fecha_inicio,fecha_finalizacion,fecha_finalizacion_estimada,id_crucero,id_recorrido)
select distinct FECHA_SALIDA,FECHA_LLEGADA,FECHA_LLEGADA_ESTIMADA,CRUCERO_IDENTIFICADOR,RECORRIDO_CODIGO 
from gd_esquema.Maestra
go
-------------------------------------------------Reserva-----------------------
SET IDENTITY_INSERT [LEISTE_EL_CODIGO?].Reserva  ON
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
SET IDENTITY_INSERT [LEISTE_EL_CODIGO?].Reserva  OFF
go

---------------------------------------------Pasaje--
SET IDENTITY_INSERT [LEISTE_EL_CODIGO?].Pasaje  ON
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
SET IDENTITY_INSERT [LEISTE_EL_CODIGO?].Pasaje  OFF 
go
update [LEISTE_EL_CODIGO?].Pasaje
set id_pago = p.id_pago
from [LEISTE_EL_CODIGO?].PagoDeViaje p
where Pasaje.id_cliente = p.id_cliente
go
-----------------------------------------RESERVAS PAGADAS-------------------------------------
insert into [LEISTE_EL_CODIGO?].ReservasPagadas(id_reserva,id_cliente)
select r.id_reserva,r.id_cliente
from [LEISTE_EL_CODIGO?].Reserva r 
where exists(select id_pasaje
				from [LEISTE_EL_CODIGO?].Pasaje p join [LEISTE_EL_CODIGO?].PagoDeViaje pv ON p.id_pago = pv.id_pago
				where r.id_cabina = p.id_cabina and r.id_cliente = p.id_cliente and r.id_crucero = p.id_crucero
				and r.id_viaje = p.id_viaje and (pv.fecha_pago between r.fecha_actual and DATEADD(day,3,r.fecha_actual)))
delete from [LEISTE_EL_CODIGO?].Reserva
where id_reserva in (select id_reserva
						from [LEISTE_EL_CODIGO?].ReservasPagadas)
--........................................VISTAS PARA APLICATIVO......................................................
--Vista de CRUCEROS DISPONIBLES--
USE GD1C2019
go
create view [LEISTE_EL_CODIGO?].CrucerosDisponibles
as
		select id_crucero,id_fabricante,modelo
		from [LEISTE_EL_CODIGO?].Crucero
		where baja_fuera_vida_util = 'N' and baja_fuera_de_servicio = 'N'
go
--Vista de ROLES HABILITADOS--
USE GD1C2019
go
create view [LEISTE_EL_CODIGO?].RolesHabilitados
as
		select id_rol
		from [LEISTE_EL_CODIGO?].Rol
		where baja_logica = 'N' -- ver despues si es necesario tambien hacer una vista con todos los roles, habilitados o no.
go
if exists(select * from sys.views where object_name(object_id)='RecorridosDisponibles' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].RecorridosDisponibles
	end
go
USE GD1C2019
go
create view [LEISTE_EL_CODIGO?].RecorridosDisponibles --che esto me parece innecesario
as
		select *
		from [LEISTE_EL_CODIGO?].Recorrido
		where estado = 'A'
go
if exists(select * from sys.views where object_name(object_id)='TramosDisponibles' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].TramosDisponibles
	end
go
USE GD1C2019
go
create view [LEISTE_EL_CODIGO?].TramosDisponibles --che esto me parece innecesario
as
		select *
		from [LEISTE_EL_CODIGO?].Tramo
go
if exists(select * from sys.views where object_name(object_id)='PuertosDisponibles' and schema_name(schema_id)='LEISTE_EL_CODIGO?')
	begin
		drop view [LEISTE_EL_CODIGO?].PuertosDisponibles
	end
go
USE GD1C2019
go
create view [LEISTE_EL_CODIGO?].PuertosDisponibles --che esto me parece innecesario
as
		select *
		from [LEISTE_EL_CODIGO?].Puerto
go

create view [LEISTE_EL_CODIGO?].ViajesConRecorridosHabilitados
as
		select v.id_viaje,v.fecha_inicio,v.fecha_finalizacion_estimada,r.id_origen, r.id_destino destinoFinal
		from [LEISTE_EL_CODIGO?].Viaje v join [LEISTE_EL_CODIGO?].Recorrido r
		ON v.id_recorrido = r.id_recorrido
		and r.estado = 'A'
go

create view [LEISTE_EL_CODIGO?].MediosDePagosDisponibles
as
		select id_medio_de_pago
		from [LEISTE_EL_CODIGO?].MedioDePago
go
--........................................ PROCEDURES ......................................................
--........................................<ABM 1> ROL				......................................................
------Agregar nueva funcionalidad a un rol-------REQUERIMIENTO: 
		--En la modificación de un rol solo se pueden alterar ambos campos: el nombre y el
		--listado de funcionalidades.
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].agregarFuncionalidadPorRol (@idRolAImitar nvarchar(255),@idNuevaFuncionalidad nvarchar(100),@nuevoNombreRol nvarchar(255))
as
	begin
		declare @valor_retorno smallint
		if(not exists (select id_rol from [LEISTE_EL_CODIGO?].Rol where id_rol= @idRolAImitar )) set @valor_retorno = -1 --no existe rol
		else if
		(not exists (select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad where id_funcionalidad= @idNuevaFuncionalidad)) set @valor_retorno = -2 -- no existe funcionalidad
		else if
		(exists (select id_funcionalidad,id_rol from [LEISTE_EL_CODIGO?].FuncionalidadPorRol 
						where id_funcionalidad= @idNuevaFuncionalidad and id_rol = @idRolAImitar )) set @valor_retorno = -3 -- el rol ya tiene esa funcionalidad
		else
			begin
				insert into [LEISTE_EL_CODIGO?].Rol(id_rol)
				values(@nuevoNombreRol) --agrego rol en la tabla
		
				insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) -- aca le pongo al nuevo rol las funcionalidades del otro rol
				select @nuevoNombreRol,id_funcionalidad
				from [LEISTE_EL_CODIGO?].FuncionalidadPorRol
				where id_rol= @idRolAImitar 

				insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) --aca agrego la nueva funcionalidad
				values(@nuevoNombreRol, @idNuevaFuncionalidad)
				set @valor_retorno = 1 -- se cargo correctamente el nuevo rol
			end
		return @valor_retorno
	end
go
--eliminar funcionalidad de un rol--
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].eliminarFuncionalidadRol (@idRol nvarchar(255),@idFuncionalidadAEliminar nvarchar(100),@nuevoNombreRol nvarchar(255))
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
				insert into [LEISTE_EL_CODIGO?].Rol(id_rol)
				values(@nuevoNombreRol) --agrego rol en la tabla
		

				insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad) -- todas menos la funcionalidad a eliminar 
				select @nuevoNombreRol,id_funcionalidad
				from [LEISTE_EL_CODIGO?].FuncionalidadPorRol
				where id_rol= @idRol and id_funcionalidad <> @idFuncionalidadAEliminar

				set @valor_retorno = 1 -- se cargo correctamente el nuevo rol
			end
		return @valor_retorno
	end
go

--Crear Nuevo Rol -- deberia usarse dentro de un while, lo hago para uno a la vez por ahora
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crearNuevoRol (@NombreRol nvarchar(255),@idFuncionalidad1 nvarchar(100),
@idFuncionalidad2 nvarchar(100)=NULL,@idFuncionalidad3 nvarchar(100)=NULL,
@idFuncionalidad4 nvarchar(100)=NULL,@idFuncionalidad5 nvarchar(100)=NULL,
@idFuncionalidad6 nvarchar(100)=NULL,@idFuncionalidad7 nvarchar(100)=NULL,
@idFuncionalidad8 nvarchar(100)=NULL,@idFuncionalidad9 nvarchar(100)=NULL,
@idFuncionalidad10 nvarchar(100)=NULL)
as
begin
		declare @valor_retorno smallint
		if
		(not exists (select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad where id_funcionalidad= @idFuncionalidad1)) 
			begin
			set @valor_retorno = -2 -- no existe funcionalidad
			return @valor_retorno
			end
		else
			begin
				if(exists (select id_rol from [LEISTE_EL_CODIGO?].Rol where id_rol= @NombreRol)) 
					begin
						set @valor_retorno = -4 --existe un rol con ese nombre
						return @valor_retorno
					end
				insert into [LEISTE_EL_CODIGO?].Rol (id_rol)
				values (@NombreRol)

				if
					(exists (select id_funcionalidad,id_rol from [LEISTE_EL_CODIGO?].FuncionalidadPorRol 
								where id_funcionalidad= @idFuncionalidad1 and id_rol = @NombreRol)) 
							begin
								set @valor_retorno = -3 -- ya tiene esa funcionalidad
								return @valor_retorno
							end
				begin try
				begin transaction
					if(@idFuncionalidad1 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad1))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad1)
					end
				if(@idFuncionalidad2 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad2))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad2)
					end
				if(@idFuncionalidad3 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad3))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad3)
					end
				if(@idFuncionalidad4 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad4))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad4)
					end
				if(@idFuncionalidad5 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad5))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad5)
					end
				if(@idFuncionalidad6 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad6))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad6)
					end
				if(@idFuncionalidad7 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad7))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad7)
					end
				if(@idFuncionalidad8 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad8))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad8)
					end
				if(@idFuncionalidad9 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad9))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad9)
					end
				if(@idFuncionalidad10 is not null and exists (select id_funcionalidad
																	from [LEISTE_EL_CODIGO?].Funcionalidad
																	where id_funcionalidad = @idFuncionalidad10))
					begin
						insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
						values(@NombreRol,@idFuncionalidad10)
					end

				set @valor_retorno = 1
				commit transaction
				end try
				begin catch
					rollback transaction
					set @valor_retorno = -5;
					throw 50000,'Hubo un error en la transaccion', 1
				end catch
			end
		return @valor_retorno
end
go
--pruebas
--begin transaction 
--exec [LEISTE_EL_CODIGO?].crearNuevoRol 'facu','generar viaje','abm rol','abm de cruceros',NULL,NULL,NULL,NULL,NULL,NULL,'registro de usuarios'
--select * from [LEISTE_EL_CODIGO?].FuncionalidadPorRol
--rollback transaction
--Dar de baja un rol--
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].darBajaRol (@idRol nvarchar(255))
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

				set @valor_retorno = 1
			end
		return @valor_retorno
	end
go		
	
--Habilitar un rol inhabilitado --
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].darAltaRol (@idRol nvarchar(255))
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
				set @valor_retorno = 1
			end
		return @valor_retorno
	end
go	
--........................................<ABM 2> LOGIN Y SEGURIDAD		......................................................
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].eliminarReservasVencidas(@fechaConfig datetime)
as
	begin
		begin transaction
		insert into [LEISTE_EL_CODIGO?].AuditoriaReservasVencidas(id_reservaVencida,id_crucero,id_cliente,id_viaje,id_cabina,fecha_actual,vencimiento)
		select id_reserva,id_crucero,id_cliente,id_viaje,id_cabina,fecha_actual,vencimiento
		from [LEISTE_EL_CODIGO?].Reserva
		where @fechaConfig > CAST(vencimiento as datetime)
		delete from [LEISTE_EL_CODIGO?].Reserva
		where @fechaConfig >  CAST(vencimiento as datetime)
		commit transaction
	end
go
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
--........................................<ABM 3> REGISTRO DE USUARIOS-no se hace......................................................
--........................................<ABM 4> PUERTOS-no se hace		......................................................
--........................................<ABM 5> RECORRIDO			......................................................

--crearTramo--
--la creacion debe ir en orden, del 1 al ultimo
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crearTramo
(@idRecorrido decimal(18,0),@origen nvarchar(255),@destino nvarchar(255),@orden smallint,@precio decimal(18,2))
as
	begin
	--confio que va a cumplir con el destino que indicó en recorrido asi q no chequeo eso
	if @origen = @destino return -1 --origen y destino son el mismo
	else if @orden<>1 and @origen <> (select id_destino from [LEISTE_EL_CODIGO?].Tramo where id_recorrido = @idRecorrido and orden = @orden-1)
		return -2 --el origen de este tramo no es el destino del tramo anterior
	
	insert into [LEISTE_EL_CODIGO?].Tramo(id_recorrido,id_origen,id_destino,orden,precio_base)
	values(@idRecorrido,@origen,@destino,@orden,@precio)
	return 1
	end
go
--modificarTramo--
--se debe hacer tmb en orden del 1ero q quieras cambiar al ultimo
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].modificarTramo
(@idTramo smallint,@origen nvarchar(255),@destino nvarchar(255),@precio decimal(18,2))
as
	begin
		if @origen = @destino return -1 --origen y destino son el mismo
		if (select orden from [LEISTE_EL_CODIGO?].Tramo where id_tramo=@idTramo) <> 1 and 
				 @origen <> (select id_destino from [LEISTE_EL_CODIGO?].Tramo 
								where id_recorrido = (select id_recorrido from [LEISTE_EL_CODIGO?].Tramo t where @idTramo = t.id_tramo)
									and orden = (select t2.orden from [LEISTE_EL_CODIGO?].Tramo t2 where @idTramo = t2.id_tramo) -1)
		return -2 --el origen de este tramo no es el destino del tramo anterior  
		update [LEISTE_EL_CODIGO?].Tramo
		set id_origen=@origen,id_destino=@destino,precio_base=@precio
		where id_tramo = @idTramo

		
		return 1
	end
go
--eliminarTramo--
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].eliminarTramo(@id_tramo smallint)
as
	delete from [LEISTE_EL_CODIGO?].Tramo where id_tramo=@id_tramo
go
--crearRecorrido--
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crearRecorrido
(@origen nvarchar(255),@destino nvarchar(255))
as
	--begin try
	declare @idRecorrido decimal(18,0)
	--if exists(select id_recorrido from [LEISTE_EL_CODIGO?].Recorrido where id_recorrido=@idRecorrido) return -1 --el id ya existe
	insert into [LEISTE_EL_CODIGO?].Recorrido(estado,id_origen,id_destino)
	values('A',@origen,@destino)
	set @idRecorrido = SCOPE_IDENTITY()
	return @idRecorrido
	--return 1 --se creo el recorrido
	--end try
	--begin catch
	--if ERROR_NUMBER()=2627 return -1--el id de recorrido ya esta en uso
	--else if ERROR_NUMBER()=547 return -2 --uno o los dos puertos no existen
	--end catch
go

--modificarRecorrido--
--si el retorno es correcto entonces podes avanzar a modificar los tramos


USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].modificarRecorrido
(@idRecorrido decimal(13,0),@origen nvarchar(255),@destino nvarchar(255),@fechaConfig datetime)
as
	begin
	if exists(select p.id_viaje from [LEISTE_EL_CODIGO?].Pasaje p 
				join [LEISTE_EL_CODIGO?].Viaje v 
				on p.id_viaje = v.id_viaje and CAST(v.fecha_inicio as datetime) > @fechaConfig
				where p.cancelacion = 'N'
	) return -1 --no se puede modificar xq todavia hay pasajes vendidos q no hicieron el viaje
	update [LEISTE_EL_CODIGO?].Recorrido
	set id_origen=@origen,id_destino=@destino
	where id_recorrido= @idRecorrido
	return 1
	end
go
--darDeBajaRecorrido--
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

--........................................<ABM 6> CRUCEROS......................................................
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].modificarCrucero(@id_crucero nvarchar(50),@id_fabricante nvarchar(255))
as
	begin
		update [LEISTE_EL_CODIGO?].Crucero
		set id_fabricante = @id_fabricante
		where id_crucero = @id_crucero
	end
go
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
--auditar cancelacion de pasajes --
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].auditarCancelacion(@id_crucero nvarchar(50),@motivo varchar(256))
as
	begin
		insert into [LEISTE_EL_CODIGO?].AuditoriaDeCruceros(id_crucero,motivo)
		values(@id_crucero,@motivo)
	end
go
--Posponer por baja de crucero --
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].posponerPasajes(@id_crucero nvarchar(50),@diasCorrimiento int)
as
	begin
		update [LEISTE_EL_CODIGO?].Viaje
		set fecha_inicio = DATEADD(DAY,@diasCorrimiento,fecha_inicio),
		fecha_finalizacion_estimada = DATEADD(DAY,@diasCorrimiento,fecha_inicio)
		where id_crucero = @id_crucero
	end
go
--calcular cabinas por tipo --
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].calcularCabinaPorTipo (@idCrucero nvarchar(50),@tipoCabina nvarchar(255),@retorno int out)
as
	begin
		if(@tipoCabina like 'Cabina Balc%') --por el acento a veces no lo agarra el batch
			begin
				select retorno = count(*)
				from [LEISTE_EL_CODIGO?].Cabina 
				where id_crucero = @idCrucero and id_tipo = @tipoCabina
			end
		else
			begin
				select retorno = count(*)
				from [LEISTE_EL_CODIGO?].Cabina 
				where id_crucero = @idCrucero and id_tipo = @tipoCabina
			end
	end
go
--reemplazarViajesCruceroPorOtro--
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].reemplazarViajesCruceroPorOtro(@id_crucero nvarchar(50))
as 
	begin--cambiar los de ahora en mas
		declare @idCruceroReemplazante nvarchar(50),@cantidadCabinasBalcon int, @cantidadEstandar int, @cantidadExterior int,
		@cantidadEjecutivo int, @cantidadSuite int,@cantidadCabinasBalcon2 int, @cantidadEstandar2 int, @cantidadExterior2 int,
		@cantidadEjecutivo2 int, @cantidadSuite2 int
		exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Cabina Balcón',@cantidadCabinasBalcon out
		exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Cabina Estandar',@cantidadEstandar out
		exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Cabina Exterior',@cantidadExterior out
		exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Ejecutivo',@cantidadEjecutivo out
		exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Suite',@cantidadSuite out

		declare cursorCrucero cursor for
		select id_crucero from [LEISTE_EL_CODIGO?].Crucero

		open cursorCrucero
		fetch next from cursorCrucero
		into @idCruceroReemplazante
		while @@FETCH_STATUS = 0
			begin
				exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Cabina Balcón',@cantidadCabinasBalcon2 out
				exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Cabina Estandar',@cantidadEstandar2 out
				exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Cabina Exterior',@cantidadExterior2 out
				exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Ejecutivo',@cantidadEjecutivo2 out
				exec [LEISTE_EL_CODIGO?].calcularCabinaPorTipo @id_crucero, 'Suite',@cantidadSuite2 out

				if(@cantidadCabinasBalcon = @cantidadCabinasBalcon2 and @cantidadEjecutivo = @cantidadEjecutivo2
				and @cantidadEstandar = @cantidadEstandar2 and @cantidadSuite = @cantidadSuite2 and @cantidadExterior = @cantidadExterior2)
				begin
					declare @cantidad int
					select @cantidad =count(*)
					from (
					select fecha_inicio, fecha_finalizacion_estimada
					from [LEISTE_EL_CODIGO?].Crucero cr join [LEISTE_EL_CODIGO?].Viaje v
					on cr.id_crucero = v.id_crucero
					where cr.id_crucero = @id_crucero
					intersect
					select fecha_inicio, fecha_finalizacion_estimada
					from [LEISTE_EL_CODIGO?].Crucero cr join [LEISTE_EL_CODIGO?].Viaje v
					on cr.id_crucero = v.id_crucero
					where cr.id_crucero = @idCruceroReemplazante
					)interseccionDeTablas
						if(@cantidad=0)
							begin
								update [LEISTE_EL_CODIGO?].Viaje
								set id_crucero = @idCruceroReemplazante
								where id_crucero = @id_crucero

								update [LEISTE_EL_CODIGO?].Pasaje
								set id_crucero = @idCruceroReemplazante
								where id_crucero = @id_crucero
								
								break
							end
				end
			end
	end
go
--cancelarPasajes --
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
--........................................<ABM 7> GENERAR VIAJE	......................................................
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].cargarViaje(@id_recorrido decimal(18,0),@id_crucero nvarchar(50),@fecha_inicio datetime2, @fecha_finalizacion_estimada datetime2,@fechaConfig datetime)
as
	begin
		declare @valor_retorno int
		if(@fechaConfig>CAST(@fecha_inicio as datetime))
			begin
				set @valor_retorno = -1 --fecha mal ingresada, se quiere generar viaje de fecha anterior a la actual
			end
		else if exists( select id_viaje
						from [LEISTE_EL_CODIGO?].Viaje v join [LEISTE_EL_CODIGO?].Crucero cru
						on (v.id_crucero = @id_crucero and v.id_crucero = cru.id_crucero)
						where fecha_inicio between @fecha_inicio and @fecha_finalizacion_estimada --fijarse cambiar los between
							and fecha_finalizacion_estimada between @fecha_inicio and @fecha_finalizacion_estimada)
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
-----------------------------------Cruceros disponibles, habilitados para esa fecha--------------------------------
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crucerosDisponiblesParaViaje(@fecha_inicio datetime2,@fecha_finalizacion_estimada datetime2)
as
	begin
		select c.id_crucero,id_fabricante,modelo
			from [LEISTE_EL_CODIGO?].CrucerosDisponibles c join [LEISTE_EL_CODIGO?].Viaje v
			On c.id_crucero = v.id_crucero
			where v.fecha_inicio <> @fecha_inicio and v.fecha_finalizacion_estimada <>@fecha_inicio 
				and v.fecha_inicio <> @fecha_finalizacion_estimada and v.fecha_finalizacion_estimada <> @fecha_finalizacion_estimada
	end
go
--.......................................<ABM 8> COMPRA Y/O RESERVA DE VIAJE	......................................................
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].pasajeroYaTieneViajeEnLaFecha
(@fecha datetime2(3),@idPasajero int,@idCrucero nvarchar(50),@idViaje int,@idCabina int)
as
	begin
	if(exists(select id_cliente
				from [LEISTE_EL_CODIGO?].Pasaje p
				join [LEISTE_EL_CODIGO?].Viaje v ON p.id_viaje = v.id_viaje
				where id_cliente= @idPasajero and v.fecha_inicio=@fecha and p.id_crucero = @idCrucero
				and p.id_viaje = @idViaje and p.id_cabina = @idCabina))  --tenemos que poner este caso por si el cliente compra mas de un pasaje
	return 0
	else if (exists(select id_cliente from [LEISTE_EL_CODIGO?].Pasaje p 
					join [LEISTE_EL_CODIGO?].Viaje v on p.id_viaje=v.id_viaje
					where id_cliente=@idPasajero and v.fecha_inicio=@fecha
		) )
		return 1
	return 0
	end
go

--crearReserva--
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].crearReserva
(@idCrucero nvarchar(50),@idCliente int,@idViaje int,@idCabina int,@fechaConfig datetime)
as
	begin
	declare @fecha datetime2(3)
	declare @retorno int
	
	select @fecha = fecha_inicio
	from [LEISTE_EL_CODIGO?].Viaje
	where id_viaje=@idViaje

	exec @retorno = [LEISTE_EL_CODIGO?].pasajeroYaTieneViajeEnLaFecha @fecha,@idCliente,@idCrucero,@idViaje,@idCabina
	
	if( @retorno = 1) return -1 --el cliente ya tiene un viaje en esa fecha
	insert into [LEISTE_EL_CODIGO?].Reserva(id_crucero,id_cliente,id_viaje,id_cabina,fecha_actual)
	values(@idCrucero,@idCliente,@idViaje,@idCabina,convert(datetime2(3),@fechaConfig))
	return SCOPE_IDENTITY()--todo bien
	end
go
--viajes disponibles para esa fecha, junto con las cabinas (y sus tipos) --
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].mostrarViajesDisponibles (@fecha_inicio datetime2(3),@origen nvarchar(255),@destino nvarchar(255),@fechaConfig datetime)
as
	begin
		select v.id_viaje,v.fecha_inicio,v.id_crucero crucero, ca.id_tipo,rec.id_recorrido,rec.id_origen origen,rec.id_destino destino, ca.id_cabina,
		cr.cantidadDeCabinas -
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
		and cr.baja_fuera_de_servicio = 'N' and cr.baja_fuera_vida_util = 'N'
		and CAST(v.fecha_inicio as datetime) > @fechaConfig
	end
go --fijarse si hay que hacer un return id_viaje
--todo despues de seleccionar un viaje--ingresar cliente
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].ingresarCliente (@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),
													@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255))
as
	begin
		declare @idCLiente int 
		insert into [LEISTE_EL_CODIGO?].Cliente(nombre,apellido,dni,telefono,mail,fecha_nacimiento,direccion)
		values(@nombre,@apellido,@dni,@telefono,@mail,@fecha_nacimiento,@direccion)
		select @idCLiente = SCOPE_IDENTITY()
		return @idCLiente
	end
go
--buscarPorDni--
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
--actualizar usuario--
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].actualizarUsuario (@idCliente int,@nombre varchar(255)=NULL,@apellido varchar(255)=NULL,@dni decimal(18, 0)=NULL,
													@telefono int=NULL,@mail nvarchar(255)=NULL,@fecha_nacimiento datetime2(3)=NULL,@direccion nvarchar(255)=NULL) 
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
------------------------------------------cargarMedioDePago--------------------------------
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].cargarMedioDePago (@cuotas smallint,@idMedio varchar(256))
as
	begin
		insert into [LEISTE_EL_CODIGO?].MedioDePago(cuotas_sin_interes,id_medio_de_pago)
		values (@cuotas,@idMedio)
	end
go --hacerlo la cantidad de veces que quiera el usuario pero despues elegir con cual pagar
-------------------------------------------devolverIdPago----------------------------------------------
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].devolverIdPago (@idMedioPago varchar(256),@id_cliente int,@fechaConfig datetime)
as	
	begin
		declare @idPago int
		insert into [LEISTE_EL_CODIGO?].PagoDeViaje(fecha_pago,id_medio_de_pago,id_cliente)
		values(CONVERT(DATETIME2(3), @fechaConfig),@idMedioPago,@id_cliente)
		SELECT @idPago= SCOPE_IDENTITY()
		return @idPago
	end
go

---------------------------------actualizarMontoTotal-----------------------------
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].actualizarMontoTotal (@idPago int)
as	
	begin
		declare @cantidadDePasajes smallint, @montoTotal  decimal(18,2), @precio decimal(18,2)

		declare sumador cursor for
		select precio
		from [LEISTE_EL_CODIGO?].Pasaje
		where id_pago = @idPago
		
		open sumador
		fetch next from sumador
		into @precio
			while @@FETCH_STATUS = 0
				begin
					set @cantidadDePasajes = @cantidadDePasajes+1
					set @montoTotal = @montoTotal+@precio
					
					fetch next from sumador
					into @precio
				end
			close sumador
			deallocate sumador
		update [LEISTE_EL_CODIGO?].PagoDeViaje
		set cantidad_de_pasajes = @cantidadDePasajes,
		monto_total = @montoTotal*@cantidadDePasajes
		where id_pago=@idPago
	end
go
-------------------------------VER VOUCHER FINALIZADA LA COMPRA(ultimo que se hace)-------------------------------
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].verVoucher (@idPago int) 
as

	begin
		exec [LEISTE_EL_CODIGO?].actualizarMontoTotal @idPago --porque cuando se ejecuta voucher es que se termino la compra
		select @idPago voucher,c.nombre +',' + c.apellido nombrePasajero,v.fecha_inicio,v.id_crucero Crucero,r.id_origen Origen,r.id_destino Destino,p.precio precioPasaje,pv.monto_total
		from [LEISTE_EL_CODIGO?].Pasaje p join [LEISTE_EL_CODIGO?].Cliente c
		ON p.id_cliente = c.id_cliente
		join [LEISTE_EL_CODIGO?].PagoDeViaje pv
		ON p.id_pago = pv.id_pago
		join [LEISTE_EL_CODIGO?].Viaje v 
		on p.id_viaje = v.id_viaje
		join [LEISTE_EL_CODIGO?].Recorrido r on v.id_recorrido = r.id_recorrido
		where p.id_pago = @idPago
	end
go
-------------------------------CALCULAR PRECIO PASAJE------------------------------
USE GD1C2019
go
create procedure [LEISTE_EL_CODIGO?].calcularPrecioPasaje (@idPasaje int,@precio decimal (18,2) out)
as
	begin
		declare @precioTramo decimal (18,2) 
		declare @recargoCabina decimal (18,2)
		declare cursorPrecio cursor for
		select t.precio_base
		from [LEISTE_EL_CODIGO?].Pasaje p join [LEISTE_EL_CODIGO?].Viaje v
		on p.id_viaje = v.id_viaje
		join [LEISTE_EL_CODIGO?].Recorrido r on v.id_recorrido = r.id_recorrido
		join [LEISTE_EL_CODIGO?].Tramo t on r.id_recorrido = t.id_tramo 
		where p.id_pasaje = @idPasaje

		open cursorPrecio
		fetch next from cursorPrecio
		into @precioTramo
			while @@FETCH_STATUS = 0
				begin
					set @precio = @precio + @precioTramo
					fetch next from cursorPrecio
					into @precioTramo
				end
			close cursorPrecio
			deallocate cursorPrecio
		select @recargoCabina = tc.porcentaje_recargo
		from [LEISTE_EL_CODIGO?].Pasaje p join [LEISTE_EL_CODIGO?].Cabina c ON p.id_cabina = c.id_cabina
		join [LEISTE_EL_CODIGO?].TipoCabina tc ON c.id_tipo = tc.id_tipo
		where p.id_pasaje = @idPasaje

		set @precio = @precio*@recargoCabina
	end
go
---------------------COMPRAR PASAJE-#----------------------- ver tema de seleccionar viaje y devolver voucher
USE GD1C2019
go 
create procedure [LEISTE_EL_CODIGO?].comprarPasaje (@idCliente int,@idViaje int,@idCabina int,@idCrucero nvarchar(50),@idPago int)
as
	begin
		declare @fecha datetime2(3),@retorno int,@idPasaje int
		declare @precioPasaje decimal (18,2)
		select @fecha = fecha_inicio
		from [LEISTE_EL_CODIGO?].Viaje
		exec @retorno = [LEISTE_EL_CODIGO?].pasajeroYaTieneViajeEnLaFecha @fecha,@idCliente,@idCrucero,@idViaje,@idCabina
		if(@retorno =1)
			return -1 -- ya tiene viajes en esa fecha, ERROR

		insert into [LEISTE_EL_CODIGO?].Pasaje (id_cliente,id_viaje,id_cabina,id_crucero,id_pago)
		values(@idCliente,@idViaje,@idCabina,@idCrucero,@idPago)
		set @idPasaje = SCOPE_IDENTITY()
		
		exec [LEISTE_EL_CODIGO?].calcularPrecioPasaje @idPasaje,@precioPasaje out
		update [LEISTE_EL_CODIGO?].Pasaje
		set precio = @precioPasaje
		where id_pasaje = @idPasaje -- para poner el precio ya aca automaticamente.
		return 1
	end
go

--........................................<ABM 9> PAGO DE RESERVA		......................................................
use GD1C2019
go
create proc [LEISTE_EL_CODIGO?].obtenerIdCLiente(@idReserva decimal(18,0))
as
	begin
		declare @idCliente int
		select @idCliente=id_cliente from [LEISTE_EL_CODIGO?].Reserva where id_reserva=@idReserva
		return @idCliente
	end
go

use GD1C2019
go
create proc [LEISTE_EL_CODIGO?].mostrarReserva(@idReserva decimal(18,0))
as
	select * from [LEISTE_EL_CODIGO?].Reserva where id_reserva=@idReserva
go

use GD1C2019
go
create proc [LEISTE_EL_CODIGO?].comprarPasajeReservado
(@idReserva decimal(18,0),@idPago int)
as
begin
	declare @idCliente int,@idViaje int,@idCabina int,@idCrucero nvarchar(50)
	declare @retorno int
	if(not exists (select *
					from [LEISTE_EL_CODIGO?].Reserva
					where id_reserva = @idReserva))
		begin
			set @retorno = -2
			return @retorno
		end
	select @idCliente=id_cliente,@idViaje=id_viaje,@idCabina=id_cabina,@idCrucero=id_crucero
	from [LEISTE_EL_CODIGO?].Reserva where id_reserva = @idReserva
	
	exec @retorno= [LEISTE_EL_CODIGO?].comprarPasaje @idCliente,@idViaje,@idCabina,@idCrucero,@idPago

	if(@retorno=1)
	begin
		insert into [LEISTE_EL_CODIGO?].ReservasPagadas(id_reserva,id_cliente)
		select id_reserva, id_cliente
		from [LEISTE_EL_CODIGO?].Reserva
		delete from [LEISTE_EL_CODIGO?].Reserva where id_reserva=@idReserva
	end
	return @retorno -- -1:ya tiene viajes en esa fecha, 1 se compró el pasaje reservado
end
go

--........................................<ABM 10> LISTADOS ESTADISTICOS	......................................................							  					  
--TOP RECORRIDOS CON MAS PASAJES VENDIDOS--
USE GD1C2019
go --consideramos que si no fueron compradas siguen libres (no tenemos en cuenta las reservas)
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
		select top 5 r.id_recorrido, count(distinct p.id_pasaje) cantidadDePasajesVendidos, r.id_origen origen, r.id_destino destino
		from [LEISTE_EL_CODIGO?].Recorrido r 
		join [LEISTE_EL_CODIGO?].Viaje v on r.id_recorrido = v.id_recorrido
		join [LEISTE_EL_CODIGO?].Pasaje p on v.id_viaje = p.id_viaje
		join [LEISTE_EL_CODIGO?].PagoDeViaje pa on p.id_pago = pa.id_pago
		where year(pa.fecha_pago) = @anio and MONTH(pa.fecha_pago) between @mesInicial and @mesFinal
		group by r.id_recorrido, r.id_origen, r.id_destino
		order by count(r.id_recorrido) desc
	end
go
--TOP 5 RECORRIDOS CON MAS CABINAS LIBRES EN VIAJES REALIZADOS--
USE GD1C2019 -- consideramos que si no fueron compradas siguen libres (no tenemos en cuenta las reservas)
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
		sum(cr.cantidadDeCabinas) - (select count(distinct p.id_pasaje)
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
--TOP 5 CRUCEROS CON MAYOR CANTIDAD DE DIAS FUERA DE SERVICIO--
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
