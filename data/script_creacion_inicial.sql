USE GD1C2019

if exists (select * from sys.schemas where name =  'LEISTE_EL_CODIGO?')
begin
	drop table  [LEISTE_EL_CODIGO?].Usuario
	drop table  [LEISTE_EL_CODIGO?].FuncionalidadPorRol
	drop table  [LEISTE_EL_CODIGO?].Rol
	drop table  [LEISTE_EL_CODIGO?].Funcionalidad

	drop table  [LEISTE_EL_CODIGO?].MedioDePago
	drop table  [LEISTE_EL_CODIGO?].PagoDeViaje	
	drop table  [LEISTE_EL_CODIGO?].Reserva
	drop table  [LEISTE_EL_CODIGO?].Pasaje
	drop table  [LEISTE_EL_CODIGO?].Cliente

	drop table  [LEISTE_EL_CODIGO?].Viaje
	drop table  [LEISTE_EL_CODIGO?].Cabina
	drop table  [LEISTE_EL_CODIGO?].Crucero
	drop table	[LEISTE_EL_CODIGO?].Fabricante
	drop table  [LEISTE_EL_CODIGO?].TipoCabina
	drop table  [LEISTE_EL_CODIGO?].Servicio

	drop table  [LEISTE_EL_CODIGO?].Tramo
	drop table  [LEISTE_EL_CODIGO?].Recorrido
	drop table  [LEISTE_EL_CODIGO?].Puerto

end
go

if not exists (select * from sys.schemas where name = 'LEISTE_EL_CODIGO?')
begin
	exec ('create schema [LEISTE_EL_CODIGO?] authorization [gdCruceros2019]')
	print 'Esquema LEISTE_EL_CODIGO? creado'
end
go

/* ---------------------------------------------------- Creacion de tablas ----------------------------------------------------*/
create table [LEISTE_EL_CODIGO?].Rol(
	nombre nvarchar(255) not null,
	id_rol smallint identity primary key,
);

create table [LEISTE_EL_CODIGO?].Usuario(
	id_usuario nvarchar(50) primary key,
	id_rol smallint references [LEISTE_EL_CODIGO?].Rol, 
	contraseña varbinary(32),
	intentos_fallidos smallint default 0
);

create table [LEISTE_EL_CODIGO?].Funcionalidad(
	id_funcionalidad smallint identity primary key,
	descripcion nvarchar(100) not null
);

create table [LEISTE_EL_CODIGO?].FuncionalidadPorRol(
	id_funcionalidad smallint references [LEISTE_EL_CODIGO?].Funcionalidad,
	id_rol smallint references [LEISTE_EL_CODIGO?].Rol
	primary key (id_rol, id_funcionalidad)
);


create table [LEISTE_EL_CODIGO?].Cliente(
	id_cliente int identity primary key,
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
	estado char(1) default 'A' check(estado in ('A','I')) 
);

create table [LEISTE_EL_CODIGO?].Puerto(
	id_puerto nvarchar(255) primary key,
);

create table [LEISTE_EL_CODIGO?].Tramo(
	id_tramo smallint identity primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_origen nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	id_destino nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	orden smallint,
	precio_base decimal(18,2) not null
);

create table [LEISTE_EL_CODIGO?].Fabricante(
	id_fabricante nvarchar(255) primary key
);

create table [LEISTE_EL_CODIGO?].Crucero(
	id_crucero nvarchar(50) primary key,
	id_fabricante nvarchar(255) references [LEISTE_EL_CODIGO?].Fabricante, --@
	modelo nvarchar(50) null,
	baja_fuera_de_servicio nchar(1) default 'N' check(baja_fuera_de_servicio in ('S','N')),
	baja_fuera_vida_util nchar(1) default 'N' check(baja_fuera_vida_util in ('S','N')),
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
	id_cabina smallint identity primary key,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	id_tipo nvarchar(255) references [LEISTE_EL_CODIGO?].TipoCabina,
	numero decimal(18,0) not null,
	piso decimal(18,0) not null
);

create table [LEISTE_EL_CODIGO?].Viaje(
	id_viaje int identity primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_crucero nvarchar(50) references [LEISTE_EL_CODIGO?].Crucero,
	fecha_inicio datetime2(3) not null,
	fecha_finalizacion_estimada datetime2(3) not null,
	fecha_finalizacion datetime2(3) not null,
);

create table [LEISTE_EL_CODIGO?].Reserva(
	id_reserva decimal(18,0) primary key,
	fecha_actual datetime2(3) not null,
	vencimiento datetime2(3) null,
);


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
);
create table [LEISTE_EL_CODIGO?].PagoDeViaje(
	id_pago int primary key identity,
	fecha_pago datetime2(3) null,
	monto_total decimal(8,2) not null,
	cantidad_de_pasajes smallint default 1 check(cantidad_de_pasajes > 0),
	id_reserva decimal(18,0) references [LEISTE_EL_CODIGO?].Reserva,
	id_pasaje decimal(18,0) references [LEISTE_EL_CODIGO?].Pasaje
);
create table [LEISTE_EL_CODIGO?].MedioDePago(
	id_medio_de_pago smallint primary key,
	cuotas_sin_interes smallint not null,
	descuento smallint not null,
	intereses smallint not null,
	id_pago int references [LEISTE_EL_CODIGO?].PagoDeViaje
);
--------------------TRIGGERS-------------------
--Trigger de vencimiento para reserva--
--create trigger fechaVencimiento on [LEISTE_EL_CODIGO?].Reserva
--after insert
--as
--begin
--	declare @fechaActual datetime2, @id_reserva decimal(18,0)
--	declare cursorVencimiento cursor for
--	select fecha_actual,id_reserva
--	from inserted
--	open cursorVencimiento
--	fetch next from cursorVencimiento
--	into @fechaActual,@id_reserva
--	while @@FETCH_STATUS =0
--		begin
--		update [LEISTE_EL_CODIGO?].Reserva
--		set vencimiento = DATEADD(day,4,@fechaActual)
--		where id_reserva = @id_reserva
--		fetch next from cursorVencimiento
--		into @fechaActual,@id_reserva
--		end
--	close cursorVencimiento
--	deallocate cursorVencimiento
--end
--go;
/* ---------------------------------------------------- Inserciones ---------------------------------------------------- */


-- Funcionalidad
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('abm de rol')					-- Funcionalidad = 1
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('abm de cruceros')				-- Funcionalidad = 2
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('registro de usuarios')			-- Funcionalidad = 3
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('abm de puertos')				-- Funcionalidad = 4
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('abm de recorrido')				-- Funcionalidad = 5
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('generar viaje')					-- Funcionalidad = 6
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('compra y/o reserva de viaje')	-- Funcionalidad = 7
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('pago de reserva')				-- Funcionalidad = 8
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('listado estadistico')			-- Funcionalidad = 9
insert into [LEISTE_EL_CODIGO?].Funcionalidad(descripcion)
values('login y seguridad')				-- Funcionalidad = 10


-- Rol
insert into [LEISTE_EL_CODIGO?].Rol(nombre)
values('administrador general')					--Rol 1 = administrador general
insert into [LEISTE_EL_CODIGO?].Rol(nombre)
values('administrador')							--Rol 2 = administrador
insert into [LEISTE_EL_CODIGO?].Rol(nombre)
values('usuario')								--Rol 3 = usuario

-- Funcionalidad por Rol
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)	--ADMINISTRADOR GENERAL
values(1,1)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,2)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,3)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,4)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,5)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,6)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,7)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,8)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(1,9)

insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)	--ADMIN
values(2,1)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,2)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,3)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,4)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,5)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,6)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,7)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,8)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(2,9)

insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)	--USUARIO
values(3,7)
insert into [LEISTE_EL_CODIGO?].FuncionalidadPorRol(id_rol,id_funcionalidad)
values(3,8)

-- Usuario
declare @hash varbinary(32)
select @hash = hashbytes('SHA2_256', 'w23e');
insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contraseña)		--ADMINISTRADOR GENERAL
values('admin',1,@hash)

insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contraseña)		--ADMINISTRADOR
values('adminNuestro',2,@hash)

insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol,contraseña)
values('admin2',2,@hash)

insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol)					--USUARIO
values('pepe',3)

insert into [LEISTE_EL_CODIGO?].Usuario(id_usuario,id_rol)
values('pepita',3)

/* ---------------------------------------------------- Migración ---------------------------------------------------- */
--CLIENTE--
insert into [LEISTE_EL_CODIGO?].Cliente(nombre,apellido,dni,direccion,telefono,mail,fecha_nacimiento)
select CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_DIRECCION,CLI_TELEFONO,CLI_MAIL,CLI_FECHA_NAC
from gd_esquema.Maestra
where PASAJE_CODIGO is not null


--Fabricante--
insert into [LEISTE_EL_CODIGO?].Fabricante
select distinct CRU_FABRICANTE
from gd_esquema.Maestra
--Crucero-- (son 37 cruceros, se repiten varias veces por cada viaje)
select CRUCERO_IDENTIFICADOR,CRU_FABRICANTE,CRUCERO_MODELO,count(*) from gd_esquema.Maestra
group by  CRUCERO_IDENTIFICADOR,CRU_FABRICANTE,CRUCERO_MODELO --para ver la cantidad y corroborar que este bien,despues borrar
insert into [LEISTE_EL_CODIGO?].Crucero(id_crucero,id_fabricante,modelo)
select distinct CRUCERO_IDENTIFICADOR,CRU_FABRICANTE,CRUCERO_MODELO
from gd_esquema.Maestra

--Servicio-- (tengo dudas de como deberia ser el orden de insert de las cosas) y las descripciones cambienlas si quieren
select count(distinct CABINA_TIPO)
from gd_esquema.Maestra -- hay 5 tipos de cabinas asique hay 5 servicios asociados a ellas
select distinct CABINA_TIPO
from gd_esquema.Maestra --cabina exterior, ejecutivo,cabina estandar,suite,cabina balcon

insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion)
values(1,'vista al mar') --ni idea jajaj, estoy abierto a sugerencias (para cabina exterior)

insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion)
values(2,'desayuno incluido') --(para ejecutivo)

insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion)
values(3,'solo habitacion') --(para cabina estandar)

insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion)
values(4,'masajes y bebidas incluidas') --(para suite)

insert into [LEISTE_EL_CODIGO?].Servicio (id_servicio,descripcion)
values(5,'vista a la pileta') --(para cabina balcon)

--Tipo Cabina --
insert into [LEISTE_EL_CODIGO?].TipoCabina (id_tipo,porcentaje_recargo)
select CABINA_TIPO,CABINA_TIPO_PORC_RECARGO
from gd_esquema.Maestra
group by CABINA_TIPO,CABINA_TIPO_PORC_RECARGO


update [LEISTE_EL_CODIGO?].TipoCabina--agregando servicios de cada tipo de cabina
set id_servicio = 1
where id_tipo = 'Cabina Exterior'

update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 2
where id_tipo = 'Ejecutivo'

update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 3
where id_tipo = 'Cabina estandar'

update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 4
where id_tipo = 'Suite'

update [LEISTE_EL_CODIGO?].TipoCabina
set id_servicio = 5
where id_tipo = 'Cabina Balcón'

-------------------Cabinas--------------------------
insert into [LEISTE_EL_CODIGO?].Cabina (numero,piso,id_crucero,id_tipo)
select CABINA_NRO,CABINA_PISO,CRUCERO_IDENTIFICADOR,CABINA_TIPO from gd_esquema.Maestra
group by CABINA_NRO,CABINA_PISO,CRUCERO_IDENTIFICADOR,CABINA_TIPO

-----------------------------Puerto------------------------------- (solo va nombre de puerto en la tabla, no va el campo ciudad, es irrelevante)

select t.RECORRIDO_CODIGO,count(*)
from (select distinct RECORRIDO_CODIGO,PUERTO_DESDE,PUERTO_HASTA from gd_esquema.Maestra
where PUERTO_DESDE in (select distinct PUERTO_HASTA from gd_esquema.Maestra)) t
group by t.RECORRIDO_CODIGO

select * from [LEISTE_EL_CODIGO?].Puerto
insert into [LEISTE_EL_CODIGO?].Puerto
select distinct PUERTO_DESDE from gd_esquema.Maestra where PUERTO_DESDE<> PUERTO_HASTA

------------------------------------------ Recorrido -----------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Recorrido (id_recorrido)
select distinct RECORRIDO_CODIGO
from gd_esquema.Maestra

-----------------------------------------Tramo-----------------------------------------------------------
create table #tramoTemp(
	id_tramo smallint identity primary key,
	id_recorrido decimal(18,0) references [LEISTE_EL_CODIGO?].Recorrido,
	id_origen nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	id_destino nvarchar(255) references [LEISTE_EL_CODIGO?].Puerto,
	orden smallint,
	precio_base decimal(18,2) not null
);
insert into #tramoTemp (id_recorrido,id_origen,id_destino,precio_base)
select distinct RECORRIDO_CODIGO,PUERTO_DESDE,PUERTO_HASTA,RECORRIDO_PRECIO_BASE
from gd_esquema.Maestra

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


--Medio de Pago-- (esta la llenamos nosotros)

----------------------------------------Pago de viaje-------------------------------------------- 
select PASAJE_CODIGO, count(*) from gd_esquema.Maestra where PASAJE_CODIGO is not null group by PASAJE_CODIGO having count(*)>1
insert into [LEISTE_EL_CODIGO?].PagoDeViaje(id_pasaje,fecha_pago,monto_total)
select PASAJE_CODIGO,PASAJE_FECHA_COMPRA,PASAJE_PRECIO from gd_esquema.Maestra
where PASAJE_FECHA_COMPRA is not null and PASAJE_PRECIO is not null
-------------------------------------------------Reserva-----------------------------------------
insert into [LEISTE_EL_CODIGO?].Reserva (id_reserva,fecha_actual)
select distinct RESERVA_CODIGO,RESERVA_FECHA
from gd_esquema.Maestra
where RESERVA_CODIGO is not null and RESERVA_FECHA is not null
-------------------------------------------------Viaje------------------------------------------------
insert into [LEISTE_EL_CODIGO?].Viaje (fecha_inicio,fecha_finalizacion,fecha_finalizacion_estimada,id_crucero,id_recorrido)
select distinct FECHA_SALIDA,FECHA_LLEGADA,FECHA_LLEGADA_ESTIMADA,CRUCERO_IDENTIFICADOR,RECORRIDO_CODIGO from gd_esquema.Maestra

---------------------------------------------Pasaje-----------------------------------------------------
--falta ver cabina cliente y viaje del pasaje
--insert into [LEISTE_EL_CODIGO?].Pasaje (id_pasaje,id_crucero,precio
--select PASAJE_CODIGO,CRUCERO_IDENTIFICADOR,PASAJE_PRECIO,
--from gd_esquema.Maestra