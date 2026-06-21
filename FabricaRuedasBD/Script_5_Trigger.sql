USE TP_FabricaRuedas;
GO

CREATE TRIGGER TR_ValidarIngresoSuministro
ON Suministros
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted 
        WHERE CantdRecibida > 1000
    )
    BEGIN
        RAISERROR ('La cantidad de suministros supera la capacidad máxima de recepción por lote (1000 unidades).', 16, 1);
        
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER TR_ValidarCuitEmpleado
ON Empleados
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted 
        WHERE LEN(Cuit) <> 11 OR ISNUMERIC(Cuit) = 0
    )
    BEGIN
        RAISERROR ('El CUIT debe contener exactamente 11 dígitos numéricos sin guiones.', 16, 1);
        
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER TR_RestaurarStockPorCancelacion
ON DetalleVentas
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        --DEVOLUCIÓN FÍSICA: Sumamos las cantidades al stock de ruedas
        UPDATE sr
        SET sr.CantDisponible = sr.CantDisponible + d.Cantidad
        FROM StockRuedas sr
        INNER JOIN deleted d ON sr.IdRueda = d.IdRueda;

        --DEVOLUCIÓN ECONÓMICA: Restamos el dinero de la factura cancelada en la cabecera
        UPDATE v
        SET v.MontoTotal = v.MontoTotal - (d.Cantidad * d.PrecioUnitario)
        FROM Ventas v
        INNER JOIN deleted d ON v.IdVenta = d.IdVenta;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        RAISERROR ('Error al restaurar el stock y actualizar el monto de la venta.', 16, 1);
    END CATCH
END;
GO


