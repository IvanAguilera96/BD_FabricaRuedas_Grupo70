USE TP_FabricaRuedas
GO

--Procedimiento para registrar una venta y actualizar el stock del producto vendido.
--Recibe IdCliente, IdRueda y Cantidad. 

CREATE PROCEDURE SP_RegistrarVenta
	@IdCliente INT,
	@IdRueda INT,
	@Cantidad INT,
	@IdVenta INT OUTPUT
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
	DECLARE @PrecioUnitario DECIMAL(18,2);
	DECLARE @MontoTotal DECIMAL(18,2);

	SET @StockActual = (SELECT CantDisponible FROM StockRuedas WHERE IdRueda = @IdRueda);
	SET @PrecioUnitario = (SELECT PrecioUnitario FROM StockRuedas WHERE IdRueda = @IdRueda);

	IF @StockActual < @Cantidad
	BEGIN
		PRINT 'Stock insuficiente.';
		RETURN;
	END

	SET @MontoTotal = @PrecioUnitario * @Cantidad

	--Transacción para insertar la venta y setear el stock en conjunto
	BEGIN TRY
		BEGIN TRANSACTION;

		-- Si @IdVenta viene en 0 o NULL, es el primer producto, se crea la venta.
        IF ISNULL(@IdVenta, 0) = 0
        BEGIN
            INSERT INTO Ventas (IdCliente, FechaVenta, MontoTotal)
            VALUES (@IdCliente, GETDATE(), @MontoTotal);
            
            SET @IdVenta = SCOPE_IDENTITY(); -- Guarda el ID de la nueva venta
        END
        ELSE
        BEGIN
            -- Si la venta ya existe, actualiza el monto total.
            UPDATE Ventas SET MontoTotal = MontoTotal + @MontoTotal WHERE IdVenta = @IdVenta;
        END

        -- Inserta el detalle de la venta
        INSERT INTO DetalleVentas (IdVenta, IdRueda, Cantidad, PrecioUnitario)
        VALUES (@IdVenta, @IdRueda, @Cantidad, @PrecioUnitario);

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

--Procedimiento para registrar un nuevo empleado. 
--Recibe IdJefe, Nombre, Apellido, Legajo.

CREATE PROCEDURE SP_NuevoEmpleado
	@Nombre VARCHAR(100),
	@Apellido VARCHAR(100),
	@Legajo INT,
	@Telefono VARCHAR(20),
	@Cargo VARCHAR(50),
	@IdArea INT,
	@IdSupervisor INT = NULL --Por defecto null (caso que no tenga jefe)
AS
BEGIN
	--Valida área existente
	IF NOT EXISTS (SELECT 1 FROM Areas WHERE IdArea = @IdArea)
	BEGIN
		PRINT 'El área especificada no existe.';
		RETURN;
	END

	--Valida supervisor existente
	IF @IdSupervisor IS NOT NULL
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM Empleados WHERE IdEmpleado = @IdSupervisor)
		BEGIN
			PRINT 'El supervisor especificado no existe.';
			RETURN;
		END
	END

	--Valida legajo duplicado
	IF EXISTS (SELECT 1 FROM Empleados WHERE Legajo = @Legajo)
	BEGIN
		PRINT 'El numero de legajo ya se encuentra asignado a otro empleado.';
		RETURN;
	END

	BEGIN TRY
		INSERT INTO Empleados (Nombre, Apellido, Legajo, FechaIngreso, Telefono, Cargo, IdArea, IdSupervisor)
		VALUES (@Nombre, @Apellido, @Legajo, GETDATE(), @Telefono, @Cargo, @IdArea, @IdSupervisor);

		PRINT 'Empleado registado con exito.';
	END TRY
	BEGIN CATCH
		PRINT 'No se pudo registrar el empleado.';
	END CATCH
END;
GO

--Procedimiento para registrar una entrada de suministros. 
--Recibe IdProveedor, Descripcion, CantdRecibida.

CREATE PROCEDURE SP_IngresoSuministro
	@IdProveedor INT,
	@Descripcion VARCHAR(100),
	@CantdRecibida INT
AS
BEGIN
	--Valida proveedor existente
	IF NOT EXISTS (SELECT 1 FROM Proveedores Where IdProveedor = @IdProveedor)
	BEGIN
		PRINT 'El proveedor no está registrado en la fabrica.';
		RETURN;
	END

	--Valida cantidad positiva
	IF @CantdRecibida <= 0
	BEGIN
		PRINT 'La cantidad ingresada debe ser mayor a 0.';
		RETURN;
	END

	BEGIN TRY
		INSERT INTO Suministros (IdProveedor, Descripcion, CantdRecibida, FechaEntrega)
		VALUES (@IdProveedor, @Descripcion, @CantdRecibida, GETDATE());

		PRINT 'Ingreso de suministro registrado con exito.';
	END TRY
	BEGIN CATCH
		PRINT 'Error ingresando el suministro: ' + ERROR_MESSAGE();
	END CATCH
END;
GO


