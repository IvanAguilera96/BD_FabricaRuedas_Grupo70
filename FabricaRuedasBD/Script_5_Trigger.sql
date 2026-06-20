USE TP_FabricaRuedas;
GO

CREATE TRIGGER TR_AlertaStockCritico
ON StockRuedas
AFTER UPDATE
AS
BEGIN
    --Si el stock baja de 10 unidades
    IF EXISTS (
        SELECT 1 
        FROM Inserted i 
        INNER JOIN Deleted d ON i.IdRueda = d.IdRueda
        WHERE i.CantDisponible < 10 AND d.CantDisponible >= 10
    )
    BEGIN
        --Obtiene los nombres de los modelos afectados para el reporte
        DECLARE @ModelosAfectados VARCHAR(250) = '';
        
        SELECT @ModelosAfectados = @ModelosAfectados + i.Modelo + ' (' + i.Medida + '), '
        FROM Inserted i
        WHERE i.CantDisponible < 10;

        IF LEN(@ModelosAfectados) > 0
        BEGIN
            DECLARE @MensajeFinal VARCHAR(500);
            SET @MensajeFinal = 'STOCK CRÍTICO: Los siguientes modelos bajaron de 10 unidades: ' + @ModelosAfectados;

            RAISERROR (@MensajeFinal, 16, 1);
        END
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

        -- 1. DEVOLUCIÓN FÍSICA: Sumamos las cantidades al stock de ruedas
        UPDATE sr
        SET sr.CantDisponible = sr.CantDisponible + d.Cantidad
        FROM StockRuedas sr
        INNER JOIN deleted d ON sr.IdRueda = d.IdRueda;

        -- 2. DEVOLUCIÓN ECONÓMICA: Restamos el dinero de la factura cancelada en la cabecera
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


