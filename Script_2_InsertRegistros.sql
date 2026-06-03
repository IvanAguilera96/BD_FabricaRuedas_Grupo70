--1. CARGA DE AREAS
INSERT INTO Areas (NombreArea) VALUES 
('Producción'),
('Ventas'),
('Logística'),
('Administracion');

-- 2. CARGA DE JEFES
INSERT INTO Jefes (Nombre, Apellido, Area) VALUES 
('Leandro', 'Lopez', 'Producción'),
('Riccardo', 'Lisei', 'Ventas'),
('Jorge', 'Sanches', 'Logística');


-- 3. CARGA DE EMPLEADOS
INSERT INTO Empleados (IDJefe, Nombre, Apellido, Legajo, FechaIngreso) VALUES 
(1, 'Leonardo', 'Micale', 1001, '2022-04-22'),
(1, 'Ivan', 'Aguilera', 1002, '2024-03-15'),
(2, 'Sofia', 'Garnero', 2001, '2023-10-02'),
(3, 'Lucas', 'Gutierrez', 3001, '2025-05-14');


-- 4. CARGA DE PROVEEDORES
INSERT INTO Proveedores (NombreEmpresa, CUIT, Email) VALUES 
('Michelin', '30-12345678-9', 'Michelin@hotmail.com'),
('Pirelli', '30-87654321-9', 'Pirelli@hotmail.com'),
('Taurus', '30-07542112-9', 'Taurus@hotmail.com');


-- 5. CARGA DE SUMINISTROS (Materia Prima)
INSERT INTO Suministros (IDProveedor, Descripcion, CantdRecibida, FechaEntrega) VALUES 
(1, 'Planchas de Caucho Natural', 500, '2026-05-10'),
(2, 'Alambre de Acero Braid', 200, '2026-05-12'),
(3, 'Azufre e insumos químicos', 50, '2026-05-14');


-- 6. CARGA DE STOCKRUEDAS
INSERT INTO StockRuedas (Modelo, Medida, CantDisponible, PrecioUnitario) VALUES 
('Pista Control', '175/65 R14', 120, 85000.00),
('All Terrain x', '215/65 R16', 80, 145000.00),
('Sport Max', '225/45 R17', 60, 190000.00);


-- 7. CARGA DE CLIENTES (Gomerías / Automotrices)
INSERT INTO Clientes (NombreCliente, CUIT, Telefono) VALUES 
('Gomería El Óvalo', '30-44444444-9', '341-4555555'),
('Distribuidora Santa Fe', '30-55555555-9', '342-4666666'),
('Terminal Automotriz del Litoral', '30-66666666-9', '341-4777777');


-- 8. CARGA DE VENTAS
INSERT INTO Ventas (IDCliente, FechaVenta, MontoTotal) VALUES 
(1, '2026-05-25 10:30:00', 340000.00),
(2, '2026-05-26 15:45:00', 1160000.00),
(3, '2026-05-28 09:00:00', 3800000.00);

-- 9. CARGA DE DETALLES DE VENTA
INSERT INTO DetalleVentas (IdVenta, IdRueda, Cantidad, PrecioUnitario) VALUES
(1, 1, 4, 85000.00),
(2, 2, 4, 290000.00),
(3, 3, 10, 380000.00);