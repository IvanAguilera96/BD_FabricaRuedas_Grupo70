USE TP_FabricaRuedas;
GO

CREATE TRIGGER TR_AlertaStockCritico
ON StockRuedas
AFTER UPDATE
AS
BEGIN
    --Si el stock baja de 10 unidades cruzando la línea límite
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

        --Protección contra cadenas vacías o errores de SUBSTRING
        IF LEN(@ModelosAfectados) > 0
        BEGIN
            PRINT 'El stock de los siguientes modelos ha caido por debajo del limite de 10 unidades:';
            PRINT SUBSTRING(@ModelosAfectados, 1, LEN(@ModelosAfectados) - 1);
        END
    END 
END;
GO

CREATE TRIGGER TR_ValidarCuitCliente
ON Clientes
AFTER INSERT, UPDATE
AS
BEGIN
    --Valida si el CUIT ingresado cumple con el patron de 13 caracteres: XX-XXXXXXXX-X
    --[0-9] significa número, el guion es literal
    IF EXISTS (
        SELECT 1 
        FROM Inserted 
        WHERE Cuit NOT LIKE '[0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'
    )
    BEGIN
        ROLLBACK TRANSACTION;
        
        RAISERROR ('Formato de CUIT inválido. Debe respetar la estructura: XX-XXXXXXXX-X.', 16, 1);
        RETURN;
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


