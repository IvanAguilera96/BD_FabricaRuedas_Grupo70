USE TP_FabricaRuedas;
GO
--DROP VIEW IF EXISTS VW_StockCritico;
--GO

--DROP VIEW IF EXISTS VW_AsignacionesPersonal;
----    GO

--  DROP VIEW IF EXISTS VW_ResumenVentas;
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
    j.IdJefe,
    j.Nombre AS NombreJefe,
    j.Apellido AS ApellidoJefe,
    j.Area,
    e.FechaIngreso
FROM Empleados e
INNER JOIN Jefes j
    ON e.IdJefe = j.IdJefe;
GO

CREATE VIEW VW_ResumenVentas AS
SELECT
    c.IdCliente,
    c.NombreCliente,
    c.Cuit,
    c.Telefono,
    COUNT(v.IdVenta) AS CantidadVentas,
    SUM(v.Cantidad) AS TotalUnidadesVendidas,
    SUM(v.MontoTotal) AS MontoTotalVendido
FROM Clientes c
INNER JOIN Ventas v
    ON c.IdCliente = v.IdCliente
GROUP BY
    c.IdCliente,
    c.NombreCliente,
    c.Cuit,
    c.Telefono;
GO