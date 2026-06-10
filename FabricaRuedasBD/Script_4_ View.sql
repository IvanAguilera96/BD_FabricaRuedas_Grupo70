USE TP_FabricaRuedas;
GO

--DROP VIEW IF EXISTS VW_StockCritico;
--GO

DROP VIEW IF EXISTS VW_AsignacionesPersonal;
--GO

--DROP VIEW IF EXISTS VW_ResumenVentas;
--GO        

CREATE VIEW VW_StockCritico AS
SELECT
    sc.IdRueda,
    sc.Modelo,
    sc.Medida,
    sc.CantDisponible,
    sc.PrecioUnitario
FROM StockRuedas sc
WHERE sc.CantDisponible < 50;
GO

CREATE VIEW VW_AsignacionesPersonal AS
SELECT
    e.IdEmpleado,
    e.Legajo,
    e.Nombre AS NombreEmpleado,
    e.Apellido AS ApellidoEmpleado,
    e.Cargo,
    e.Telefono AS TelefonoEmpleado,
    e.FechaIngreso,
    a.NombreArea AS Area,
    s.IdEmpleado AS IdSupervisor,
    s.Nombre AS NombreSupervisor,
    s.Apellido AS ApellidoSupervisor
FROM Empleados e
LEFT JOIN Areas a ON e.IdArea = a.IdArea
LEFT JOIN Empleados s ON e.IdSupervisor = s.IdEmpleado;
GO

CREATE VIEW VW_ResumenVentas AS
SELECT
    c.IdCliente,
    c.NombreCliente,
    c.Cuit,
    c.Telefono,
    c.Mail,
    
    --Cantidad de facturas del cliente
    COUNT(DISTINCT v.IdVenta) AS CantidadVentas,
    
    --Cantidad de unidades totales en el detalle de la venta
    ISNULL((
        SELECT SUM(dv.Cantidad) 
        FROM DetalleVentas dv 
        INNER JOIN Ventas v2 ON dv.IdVenta = v2.IdVenta 
        WHERE v2.IdCliente = c.IdCliente
    ), 0) AS TotalUnidadesVendidas,
    
    ISNULL(SUM(v.MontoTotal), 0) AS MontoTotalVendido

FROM Clientes c
INNER JOIN Ventas v ON c.IdCliente = v.IdCliente
GROUP BY
    c.IdCliente,
    c.NombreCliente,
    c.Cuit,
    c.Telefono,
    c.Mail;
GO

