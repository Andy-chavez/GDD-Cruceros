# TPGDD-1C2019
# ...: PROCEDURES :...

#### sp_login(@id_ingresado nvarchar(50), @contra_ingresada nvarchar(32))

  Valores de retorno:
  
     1 : Se realizo el loggeo
     0 : Contra mal ingresada pero hay intentos todavia
    -1 : El usuario excede las tres oportunidades y es dado de baja
    -2 : El usuario no existe en la base de datos

##### buscarPorDni (@dni decimal(18, 0))

### Crucero:

#### darDeBajaDefinitivaCrucero(@id_crucero nvarchar(50),@fecha_actual datetime2)
#### darDeBajaTemporalCrucero(@id_crucero nvarchar(50),@fecha_reinicio datetime2)
#### cargarCrucero(@id_crucero nvarchar(50),@id_fabricante nvarchar(255),@modelo nvarchar(50),@cantidadDeCabinas int)

  Valores de retorno:
  
     1 : Se cargo crucero
    -1 : No existe ese fabricante
    -2 : cantidad de cabinas menor a cero

#### posponerPasajes(@id_crucero nvarchar(50),@diasCorrimiento int)

#### reemplazarViajesCruceroPorOtro(@id_crucero nvarchar(50))

#### modificarCrucero (@idCrucero,@id_nuevo_fabricante)

### Viaje:

#### mostrarViajesDisponibles (@fecha_inicio datetime2(3),@origen nvarchar(255),@destino nvarchar(255)) 
cuando lo selecciones me tenes que pasar despues el id de viaje,el id de de recorrido y el id de cabina para poder generar el pasaje
#### cargarViaje(@id_recorrido decimal(18,0),@id_crucero nvarchar(50),@fecha_inicio datetime2, @fecha_finalizacion_estimada datetime2, @fecha_actual datetime2)

  Valores de retorno:
  
     1 : Se cargo viaje
    -1 : Fecha mal ingresada, se quiere generar viaje de fecha anterior a la actual
    -2 : Crucero ocupado entre esas fechas
    -3 : Recorrido inhabilitado
    -4 : Crucero inhabilitado

### Rol:

#### agregarFuncionalidadPorRol (@idRolAImitar nvarchar(255),@idNuevaFuncionalidad smallint,@nuevoNombreRol nvarchar(255))
#### eliminarFuncionalidadRol (@idRol smallint,@idFuncionalidadAEliminar smallint,@nuevoNombreRol nvarchar(255))

  Valores de retorno:

    1: se cargo todo joya
    -1: no existe el rol
    -2: No existe funcionalidad
    -3: el rol ya tiene esa funcionalidad(agregar) o no tiene esa funcionalidad(eliminar)

#### crearNuevoRol (@idFuncionalidad smallint,@NombreRol nvarchar(255))

  Valores de retorno:

    1: se cargo todo joya
    -2: No existe funcionalidad
    -3: el rol ya tiene esa funcionalidad
#### darAltaRol (@idRol smallint)
#### darBajaRol (@idRol smallint)

   Valores de retorno:

    1: se cargo todo joya
    -1: no existe el rol

### Pasaje:

#### cargarMedioDePago (@cuotas smallint,@tipoTarjeta varchar(256),@nombreTarjeta varchar(256))

#### devolverIdPago (@idMedioPago int) -- mas facil asi, cargo desde la base de datos el total y la cantidad, cuando compras el pasaje.

#### comprarPasaje (@idCliente int,@idViaje int,@idCabina int,@idCrucero int,@idPago,)
Valores de retorno:

    1: se cargo todo joya
    -1: el cliente que quiere comprar ya tiene un viaje en esa fecha
#### calcularPrecioPasaje (@idPasaje int,@precio decimal (18,2) out)

#### actualizarMontoTotal (@idPago) esto lo hago apenas se completa la compra de un pasaje, para no tener que hacer desde aplicativo la cantidad y el monto total

#### verVoucher (@idPago int) -- (esto es lo ultimo que se hace)pasarle el mismo idPago que se usa en comprarPasajes para mostrar todos los pasajes de esa compra

#### ingresarCliente (@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255))
                seria el caso que tenes que cargar un cliente de cero
#### cancelarPasajes(@id_crucero nvarchar(50),@fecha_actual datetime2,@motivo varchar(256))

#### auditarCancelacion(@id_crucero nvarchar(50),@motivo varchar(256)) -- este se usa desde la base de datos

### Usuario:
#### actualizarUsuario (@idCliente int,@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),	@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255)) 
                        Nota: ingresa los atributos que quieras modificar y los demas dejalos en NULL.
                         EXCEPTO ID_CLIENTE ESE ES OBLIGATORIO.
                         Porque no se puede buscar por DNI
        
### Recorrido:

#### crearRecorrido(@origen nvarchar(255),@destino nvarchar(255))
    Valores de retorno:
    el idRecorrido

Nota: primero creás el recorrido, después los tramos que lo componen

#### modificarRecorrido(@idRecorrido decimal(13,0),@origen nvarchar(255),@destino nvarchar(255))
Nota: tenés que usarlo antes de modificar sus tramos

  Valores de retorno:
  
    -1: no se puede mofificar porque todavía hay pasajes vendidos que no hicieron el viaje, tampoco podés modificar sus tramos
     1: todo bien, ya podés modificar los tramos

#### darDeBajaRecorrido(@idRecorrido decimal(18,0))

### Tramo:

#### crearTramo(@idRecorrido decimal(18,0),@origen nvarchar(255),@destino nvarchar(255),@orden smallint,@precio decimal(18,2))
Nota: la creacion debe ir en orden, arrancando en 1 y hasta el ultimo

  Valores de retorno:
  
    -1: error,origen y destino son iguales
    -2: el origen de este tramo no es el destino del tramo anterior
     1: todo bien, ya podés ingresar el próximo tramo

#### modificarTramo(@idTramo smallint,@origen nvarchar(255),@destino nvarchar(255),@precio decimal(18,2))
Nota: se debe hacer en orden del orden mas chico q quieras cambiar al ultimo

  Valores de retorno:
  
    -1: error,origen y destino son iguales 
    -2: el origen de este tramo no es el destino del tramo anterior
     1: todo bien, ya podés modificar el próximo tramo

#### eliminarTramo(@id_tramo smallint)

### Reserva:

#### crearReserva(@idReserva decimal(18,0),@idCrucero nvarchar(50),@idCliente int,@idViaje int,@idCabina smallint)

  Valores de retorno:
  
    -1: el cliente ya tiene un viaje en esa fecha
     numero mayor a 0: el id de la reserva

#### mostrarReserva(@idReserva decimal(18,0))

#### comprarPasajeReservado(@idReserva decimal(18,0),@idPago int)

  Valores de retorno:
      -2 : no existe una reserva o la reserva se vencio
      -1: el cliente ya tiene viajes en esa fecha
      1: todo bien, se compró el pasaje reservado

# LISTADO ESTADISTICOS:

#### topRecorridosConMasPasajesComprados (@anio int, @semestre int)
#### topMasCabinasLibres (@anio int, @semestre int)
#### topCrucerosFueraDeServicio (@anio int, @semestre int)

# ...: VIEWS :...


#### ~ CrucerosDisponibles
#### ~ RolesHabilitados
#### ~ PuertosDisponibles
#### ~ RecorridosDisponibles
#### ~ TramosDisponibles
