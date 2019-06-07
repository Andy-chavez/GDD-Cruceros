# TPGDD-1C2019
# ...: PROCEDURES :...

#### sp_login(@id_ingresado nvarchar(50), @contra_ingresada nvarchar(32))

  Valores de retorno:
  
     1 : Se realizo el loggeo
     0 : Contra mal ingresada pero hay intentos todavia
    -1 : El usuario excede las tres oportunidades y es dado de baja
    -2 : El usuario no existe en la base de datos

#### darDeBajaDefinitivaCrucero(@id_crucero nvarchar(50),@fecha_actual datetime2)
#### darDeBajaTemporalCrucero(@id_crucero nvarchar(50),@fecha_reinicio datetime2)
#### cargarCrucero(@id_crucero nvarchar(50),@id_fabricante nvarchar(255),@modelo nvarchar(50),@cantidadDeCabinas int)

  Valores de retorno:
  
     1 : Se cargo crucero
    -1 : No existe ese fabricante
    -2 : cantidad de cabinas menor a cero
    
#### cargarViaje(@id_recorrido decimal(18,0),@id_crucero nvarchar(50),@fecha_inicio datetime2, @fecha_finalizacion_estimada datetime2, @fecha_actual datetime2)

  Valores de retorno:
  
     1 : Se cargo viaje
    -1 : Fecha mal ingresada, se quiere generar viaje de fecha anterior a la actual
    -2 : Crucero ocupado entre esas fechas
    -3 : Recorrido inhabilitado
    -4 : Crucero inhabilitado

#### agregarFuncionalidadPorRol (@idRol smallint,@idNuevaFuncionalidad smallint,@nuevoNombreRol nvarchar(255))
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
    
#### mostrarViajesDisponibles (@fecha_inicio datetime2(3),@origen nvarchar(255),@destino nvarchar(255))
#### ingresarCliente (@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255))
                seria el caso que tenes que cargar un cliente de cero
#### actualizarUsuario (@idCliente int,@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),	@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255)) 
                        Nota: ingresa los atributos que quieras modificar y los demas dejalos en NULL.
                         EXCEPTO ID_CLIENTE ESE ES OBLIGATORIO.
                         Porque no se puede buscar por DNI
        
#### mostrarViajesDisponibles (@fecha_inicio datetime2(3),@origen nvarchar(255),@destino nvarchar(255))
#### cancelarPasajes(@id_crucero nvarchar(50),@fecha_actual datetime2,@motivo varchar(256))
#### auditarCancelacion(@id_crucero nvarchar(50),@motivo varchar(256)) -- este se usa desde la base de datos

####Recorrido:

####crearRecorrido(@idRecorrido decimal(18,0),@origen nvarchar(255),@destino nvarchar(255))

Nota: primero creás el recorrido, después los tramos que lo componen

####modificarRecorrido(@idRecorrido decimal(13,0),@origen nvarchar(255),@destino nvarchar(255))
Nota: tenés que usarlo antes de modificar sus tramos

  Valores de retorno:
    -1: no se puede mofificar porque todavía hay pasajes vendidos que no hicieron el viaje, tampoco podés modificar sus tramos
     1: todo bien, ya podés modificar los tramos

####darDeBajaRecorrido(@idRecorrido decimal(18,0))

####Tramo:

####crearTramo(@idRecorrido decimal(18,0),@origen nvarchar(255),@destino nvarchar(255),@orden smallint,@precio decimal(18,2))
Nota: la creacion debe ir en orden, arrancando en 1 y hasta el ultimo

  Valores de retorno:
    -1: error,origen y destino son iguales
    -2: el origen de este tramo no es el destino del tramo anterior
     1: todo bien, ya podés ingresar el próximo tramo

####modificarTramo(@idTramo smallint,@origen nvarchar(255),@destino nvarchar(255),@precio decimal(18,2))
Nota: la creacion debe ir en orden, arrancando en 1 y hasta el ultimo

  Valores de retorno:
    -1: error,origen y destino son iguales
    -2: el origen de este tramo no es el destino del tramo anterior
     1: todo bien, ya podés modificar el próximo tramo

####eliminarTramo(@id_tramo smallint)

####Reserva:

####crearReserva(@idReserva decimal(18,0),@idCrucero nvarchar(50),@idCliente int,@idViaje int,@idCabina smallint)

  Valores de retorno:
    -1: el id de reserva ya está en uso
     1: todo bien


# LISTADO ESTADISTICOS:

#### topRecorridosConMasPasajesComprados (@anio int, @semestre int)
#### topMasCabinasLibres (@anio int, @semestre int)
#### topCrucerosFueraDeServicio (@anio int, @semestre int)

# ...: VIEWS :...


#### ~ CrucerosDisponibles
#### ~ RolesHabilitados
