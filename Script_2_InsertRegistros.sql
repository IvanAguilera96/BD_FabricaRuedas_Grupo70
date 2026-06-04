--1. CARGA DE AREAS
INSERT INTO Areas (NombreArea) VALUES 
('Producción'),
('Ventas'),
('Logística'),
('Administracion');


-- 2. CARGA DE EMPLEADOS
INSERT INTO Empleados (Nombre, Apellido, Legajo, FechaIngreso, Telefono, Cargo, IdArea, IdSupervisor) VALUES 
('Leonardo', 'Micale', 1001, '2022-04-22', '302-2321231', 'Supervisor', 2, NULL),
('Ivan', 'Aguilera', 1002, '2024-03-15', '302-65773432', 'Vendedor', 1, 1),
('Sofia', 'Garnero', 2001, '2023-10-02', '302-689421', 'Supervisor', 3, NULL),
('Lucas', 'Gutierrez', 3001, '2025-05-14', '302-416704', 'Operario', 1, 3),
('Emilio', 'Sanches', 5501, '2022-10-01', '302-1231231', 'Operario', 1, 1);


-- 3. CARGA DE PROVEEDORES
INSERT INTO Proveedores (NombreEmpresa, CUIT, Email) VALUES 
('Michelin', '30-12345678-9', 'Michelin@hotmail.com'),
('Pirelli', '30-87654321-9', 'Pirelli@hotmail.com'),
('Taurus', '30-07542112-9', 'Taurus@hotmail.com');


-- 4. CARGA DE SUMINISTROS (Materia Prima)
INSERT INTO Suministros (IDProveedor, Descripcion, CantdRecibida, FechaEntrega) VALUES 
(1, 'Planchas de Caucho Natural', 500, '2026-05-10'),
(2, 'Alambre de Acero Braid', 200, '2026-05-12'),
(3, 'Azufre e insumos químicos', 50, '2026-05-14');


-- 5. CARGA DE STOCKRUEDAS
INSERT INTO StockRuedas (Modelo, Medida, CantDisponible, PrecioUnitario) VALUES 
('Pista Control', '175/65 R14', 120, 85000.00),
('All Terrain x', '215/65 R16', 80, 145000.00),
('Sport Max', '225/45 R17', 60, 190000.00);


-- 6. CARGA DE CLIENTES (Gomerías / Automotrices)
INSERT INTO Clientes (NombreCliente, CUIT, Telefono, Mail, Domicilio, CondicionFiscal) VALUES 
('Gomería El Óvalo', '30-44444444-9', '341-4555555', 'gomeria@gmail.com', 'Saveedra 593', 'Monotributista'),
('Distribuidora Santa Fe', '30-55555555-9', '342-4666666', 'distribuidora@gmail.com', 'San Martin 191', 'Consumidor Final'),
('Terminal Automotriz del Litoral', '30-66666666-9', '341-4777777', 'automotriz@gmail.com', 'Garay 1000', 'Consumidor Final');


-- 7. CARGA DE VENTAS
INSERT INTO Ventas (IDCliente, FechaVenta, MontoTotal) VALUES 
(1, '2026-05-25 10:30:00', 340000.00),
(2, '2026-05-26 15:45:00', 1160000.00),
(3, '2026-05-28 09:00:00', 3800000.00);

-- 8. CARGA DE DETALLES DE VENTA
INSERT INTO DetalleVentas (IdVenta, IdRueda, Cantidad, PrecioUnitario) VALUES
(1, 1, 4, 85000.00),
(2, 2, 8, 145000.00),
(3, 3, 20, 190000.00);