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
    -3: el rol ya tiene esa funcionalidad (esto no seria necesario si le tiramos una lista)
# ...: VIEWS :...

#### ~ CrucerosDisponibles
