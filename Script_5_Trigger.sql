
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

        PRINT 'El stock de los siguientes modelos ha caido por debajo del limite de 10 unidades:';
        PRINT SUBSTRING(@ModelosAfectados, 1, LEN(@ModelosAfectados) - 1);
    END
END;
GO

--CREATE TRIGGER TR_ValidadCuitCliente 



--CREATE TRIGGER TR_RestaurarStockPorCancelacion