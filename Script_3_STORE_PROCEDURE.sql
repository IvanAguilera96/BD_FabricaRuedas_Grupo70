USE TP_FabricaRuedas
GO

--Procedimiento para registrar una venta (Ventas) y descontar el stock (StockRuedas).

CREATE PROCEDURE SP_RegistrarVenta
	@IdCliente INT,
	@IdRueda INT,
	@Cantidad INT,
	@MontoTotal DECIMAL(18,2)
AS
BEGIN
	--Valida cantidad mayor a 0
	IF @Cantidad <= 0
	BEGIN
		PRINT 'La cantidad debe ser mayor a cero.';
		RETURN;
	END

	--Valida cliente existente
	IF NOT EXISTS (SELECT 1 FROM Clientes WHERE IdCliente = @IdCliente)
	BEGIN
		PRINT 'El cliente indicado no existe.';
		RETURN;
	END

	--Valida producto existente
	IF NOT EXISTS (SELECT 1 FROM StockRuedas WHERE IdRueda = @IdRueda)
	BEGIN
		PRINT 'El producto seleccionado no existe.';
		RETURN;
	END

	--Valida stock disponible
	DECLARE @StockActual INT;
	SET @StockActual = (SELECT CantDisponible FROM StockRuedas WHERE IdRueda = @IdRueda);

	IF @StockActual < @Cantidad
	BEGIN
		PRINT 'Stock insuficiente.';
		RETURN;
	END

	--Transacción para insertar la venta y setear el stock en conjunto
	BEGIN TRY
		BEGIN TRANSACTION;

		INSERT INTO Ventas (IdCliente, IdRueda, FechaVenta, Cantidad, MontoTotal)
		VALUES (@IdCliente, @IdRueda, GETDATE(), @Cantidad, @MontoTotal);

		UPDATE StockRuedas
		SET CantDisponible = CantDisponible - @Cantidad
		WHERE IdRueda = @IdRueda

		COMMIT TRANSACTION;

		PRINT 'Venta registrada con éxito.';
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;

		PRINT 'Se produjo un error registrando la venta: ' + ERROR_MESSAGE();
	END CATCH
END;
GO

--Procedimiento para registrar un nuevo empleado (Empleados)

CREATE PROCEDURE SP_NuevoEmpleado
	@IdJefe INT,
	@Nombre VARCHAR(50),
	@Apellido VARCHAR(50),
	@Legajo INT,
	@FechaIngreso DATE
AS
BEGIN
	--Valida jefe existente en la tabla Jefes
	IF NOT EXISTS (SELECT 1 FROM Jefes WHERE IdJefe = @IdJefe)
	BEGIN
		PRINT 'No existe el jefe especificado. Elija uno existente.';
		RETURN;
	END

	--Valida legajo existente en la tabla Empleados
	IF EXISTS (SELECT 1 FROM Empleados WHERE Legajo = @Legajo)
	BEGIN
		PRINT 'El numero de legajo ya se encuentra asignado a otro empleado.';
		RETURN;
	END

	BEGIN TRY
		INSERT INTO Empleados (IdJefe, Nombre, Apellido, Legajo, FechaIngreso)
		VALUES (@IdJefe, @Nombre, @Apellido, @Legajo, @FechaIngreso);

		PRINT 'Empleado registado con exito.';
	END TRY
	BEGIN CATCH
		PRINT 'No se pudo registrar el empleado.';
	END CATCH
END;
GO



		
		


