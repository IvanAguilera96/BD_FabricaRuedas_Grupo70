USE TP_FabricaRuedas;
GO

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
    e.Cuit,
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
    v.IdVenta,
    c.IdCliente,
    c.NombreCliente,
    c.Cuit,
    c.Telefono,
    c.Mail,
    
    ISNULL((
        SELECT SUM(dv.Cantidad) 
        FROM DetalleVentas dv 
        WHERE dv.IdVenta = v.IdVenta
    ), 0) AS TotalUnidadesVendidas,
    
    ISNULL(v.MontoTotal, 0) AS MontoTotalVendido

FROM Ventas v
INNER JOIN Clientes c ON v.IdCliente = c.IdCliente;
GO

