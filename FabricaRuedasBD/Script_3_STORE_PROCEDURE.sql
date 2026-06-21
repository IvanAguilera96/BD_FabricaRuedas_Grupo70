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
		RAISERROR ('La cantidad debe ser mayor a cero.', 16, 1);
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
		RAISERROR ('Stock insuficiente para concretar la venta.', 16, 1);
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

		RAISERROR ('Se produjo un error registrando la venta: ', 16, 1);
	END CATCH
END;
GO

--Procedimiento para registrar un nuevo empleado. 
--Recibe IdJefe, Nombre, Apellido, Legajo.

CREATE PROCEDURE SP_NuevoEmpleado
	@Nombre VARCHAR(100),
	@Apellido VARCHAR(100),
	@Cuit VARCHAR(20),
	@Legajo INT,
	@Telefono VARCHAR(20),
	@Cargo VARCHAR(50),
	@IdArea INT,
	@IdSupervisor INT = NULL --Por defecto null (caso que no tenga jefe)
AS
BEGIN
	--Valida cuit duplicado
	IF EXISTS (SELECT 1 FROM Empleados WHERE Cuit = @Cuit)
    BEGIN
		RAISERROR ('El número de CUIT ya se encuentra registrado para otro empleado.', 16, 1);
        RETURN;
    END

	--Valida legajo duplicado
	IF EXISTS (SELECT 1 FROM Empleados WHERE Legajo = @Legajo)
	BEGIN
		RAISERROR ('El numero de legajo ya se encuentra asignado a otro empleado.', 16, 1);
		RETURN;
	END

	BEGIN TRY
		INSERT INTO Empleados (Nombre, Apellido, Cuit, Legajo, FechaIngreso, Telefono, Cargo, IdArea, IdSupervisor)
		VALUES (@Nombre, @Apellido, @Cuit, @Legajo, GETDATE(), @Telefono, @Cargo, @IdArea, @IdSupervisor);

		RAISERROR ('Empleado registado con exito.', 16, 1);
	END TRY
	BEGIN CATCH
		THROW;
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
	--Valida cantidad positiva
	IF @CantdRecibida <= 0
	BEGIN
		RAISERROR ('La cantidad ingresada debe ser mayor a 0.', 16, 1);
		RETURN;
	END

	BEGIN TRY
		INSERT INTO Suministros (IdProveedor, Descripcion, CantdRecibida, FechaEntrega)
		VALUES (@IdProveedor, @Descripcion, @CantdRecibida, GETDATE());

		RAISERROR ('Ingreso de suministro registrado con exito.', 16, 1);
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END;
GO
