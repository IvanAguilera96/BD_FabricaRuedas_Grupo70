Explicación del Sistema

El sistema permite gestionar el inventario, suministros y comercialización para una fábrica de ruedas, desde el ingreso de materia prima hasta la venta final. Está diseñado para facilitar el control de stock, la administración y la organización jerárquica del personal de planta. 

Funcionalidades principales:

•	Gestión de Suministros: Registro de materiales recibidos.

•	Control de Stock de Ruedas: Monitoreo en tiempo real de modelos, medidas y unidades disponibles. 

•	Administración de Ventas: Registro de transacciones comerciales vinculadas a clientes específicos. 

•	Gestión de Recursos Humanos: Vinculación de empleados operativos con sus respectivos jefes de área. 

El sistema está construido con una base de datos relacional que almacena toda la información necesaria para gestionar estas funcionalidades. Se han implementado tres vistas, tres procedimientos almacenados y tres triggers para mejorar la administración y la integridad de los datos.
Diagrama de Entidad Relación
 
Objetos de Base de Datos clave en el sistema

Vistas 


•	VW_StockCritico: Lista modelos con menos de 50 unidades.

•	VW_AsignacionesPersonal: Muestra empleados, sus legajos y el jefe a cargo. 

•	VW_ResumenVentas: Cruza datos de clientes con montos totales vendidos (Histórico de ventas). 


Procedimientos Almacenados 


•	SP_RegistrarVenta: Inserta la venta y descuenta automáticamente el stock disponible.

•	SP_NuevoEmpleado: Registra personal validando que el jefe asignado exista y los datos sean consistentes. 

•	SP_IngresoSuministro: Registra la llegada de materia prima vinculada a un proveedor.

Triggers


•	TR_ValidarCuitEmpleado: AFTER INSERT - No permite el registro si el formato de cuit ingresado es inválido (11 dígitos numéricos).

•	TR_ValidarIngresoSuministro: AFTER INSERT - No permite el ingreso de suministros si superan la cantidad reservada de almacenaje.

•	TR_RestaurarStockPorCancelacion: AFTER DELETE - Devuelve el stock de un artículo cancelado.

