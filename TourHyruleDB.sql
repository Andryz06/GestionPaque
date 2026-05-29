-- 1. Primero creamos la base de datos (Si ya la tienes, puedes borrar estas dos líneas)
CREATE DATABASE TourHyruleDB;
GO

-- 2. Le decimos a SQL que vamos a trabajar adentro de esa base de datos
USE TourHyruleDB;
GO

-- 3. Creamos la tabla con la nueva columna mágica: "Rol"
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY, -- Esto hace que el ID se ponga solo (1, 2, 3...)
    Username NVARCHAR(50) NOT NULL,          -- El nombre con el que inician sesión
    Password NVARCHAR(50) NOT NULL,          -- La contraseña
    Correo NVARCHAR(100) NOT NULL,           -- Para tu formulario de "Olvidé mi contraseña"
    Rol NVARCHAR(20) NOT NULL                -- ¡La columna clave! Aquí dirá 'Admin' o 'Cliente'
);
GO
CREATE TABLE Paquetes (
    IdPaquete INT IDENTITY(1,1) PRIMARY KEY,
    NombrePaquete NVARCHAR(100) NOT NULL,
    Destino NVARCHAR(100) NOT NULL,
    DuracionDias INT NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    CuposDisponibles INT NOT NULL
);
GO

-- ==========================================
-- 4. TABLA DE CLIENTES (Información personal)
-- ==========================================
CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario), -- Conecta el cliente con su cuenta de Login
    NombreCompleto NVARCHAR(150) NOT NULL,
    Telefono NVARCHAR(20),
    Nacionalidad NVARCHAR(50)
);
GO

-- ==========================================
-- 5. TABLA DE RESERVAS (El corazón del negocio)
-- ==========================================
CREATE TABLE Reservas (
    IdReserva INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT FOREIGN KEY REFERENCES Clientes(IdCliente), -- Quién compra
    IdPaquete INT FOREIGN KEY REFERENCES Paquetes(IdPaquete), -- Qué paquete compra
    FechaReserva DATETIME DEFAULT GETDATE(),
    CantidadPersonas INT NOT NULL,
    TotalPagar DECIMAL(10,2) NOT NULL,
    Estado NVARCHAR(20) DEFAULT 'Pendiente' -- (Pendiente, Pagado, Cancelado)
);
GO

-- 4. Insertamos dos usuarios de prueba para que puedas calar tu sistema
INSERT INTO Usuarios (Username, Password, Correo, Rol)
VALUES 
-- Un usuario que abrirá el menú de Administrador
('AdminTour', '12345', 'admin@tourhyrule.com', 'Admin'),

-- Un usuario normal que abrirá el menú de Cliente
('LinkViajero', 'hola123', 'cliente@gmail.com', 'Cliente');
GO
INSERT INTO Paquetes (NombrePaquete, Destino, DuracionDias, Precio, CuposDisponibles)
VALUES 
('Ruta del Volcán', 'Montaña de la Muerte', 3, 150.00, 20),
('Escape a la Playa', 'Bahía Zora', 2, 85.50, 15),
('Tour Arqueológico', 'Ruinas del Templo', 1, 40.00, 30);

-- Insertar un perfil de cliente conectado al usuario 'LinkViajero' (que es el Id 2)
INSERT INTO Clientes (IdUsuario, NombreCompleto, Telefono, Nacionalidad)
VALUES 
(2, 'Link El Héroe', '+503 7777-8888', 'Hyliano');

-- Crear una reserva de prueba para ese cliente
INSERT INTO Reservas (IdCliente, IdPaquete, CantidadPersonas, TotalPagar, Estado)
VALUES 
(1, 1, 2, 300.00, 'Pagado');
GO

UPDATE Usuarios
SET Correo = 'tourhyrule@gmail.com'
WHERE IdUsuario = 1;

Select * from Usuarios;

--DELETE FROM Usuarios
--Where IdUsuario BETWEEN 3 AND 4

ALTER TABLE Usuarios
ADD Nombres NVARCHAR(100),
	Apellidos NVARCHAR (100),
	Telefonos NVARCHAR (20);

EXEC sp_rename 'Usuarios.Telefonos', 'Telefono', 'COLUMN';

ALTER TABLE Usuarios
DROP COLUMN Username;

USE TourHyruleDB;
GO

ALTER TABLE Paquetes
ADD Descripcion NVARCHAR(MAX),    -- Para el texto largo del paquete
    Imagen VARBINARY(MAX);        -- ¡El campo mágico para guardar la foto en bytes!
GO

ALTER TABLE Paquetes
ADD FechaSalida DATETIME; -- Campo para guardar la fecha exacta del calendario
GO

-- Esto transforma la columna de números a fechas para que acepte tu calendario
ALTER TABLE Paquetes ALTER COLUMN DuracionDias DATE;
GO

-- 1. Borramos la columna rebelde que choca con los números
ALTER TABLE Paquetes DROP COLUMN DuracionDias;
GO

-- 2. La volvemos a crear, pero ahora en formato Calendario (DATE)
ALTER TABLE Paquetes ADD DuracionDias DATE;
GO

DELETE FROM Reservas;
GO

-- 2. Ahora sí, borramos todos los paquetes viejos y defectuosos
DELETE FROM Paquetes;
GO

-- 3. ¡EL TRUCO MAESTRO! Reiniciamos el contador de ID para que el próximo paquete sea el #1
DBCC CHECKIDENT ('Paquetes', RESEED, 0);
GO

Select * From Clientes;
Select * From Usuarios;

DELETE FROM Clientes;
GO

-- 3. ¡EL TRUCO MAESTRO! Reiniciamos el contador de ID para que el próximo paquete sea el #1
DBCC CHECKIDENT ('Clientes', RESEED, 0);
GO


-- Agregamos la columna Email a la tabla de Clientes
ALTER TABLE Clientes ADD Email VARCHAR(100);
GO

UPDATE Clientes SET Email = 'andyzelaya06@gmail.com' WHERE IdCliente = 1;

-- Registramos al perfil de cliente genérico (ID 2)
INSERT INTO Clientes (IdUsuario, NombreCompleto, Telefono, Nacionalidad, Email)
VALUES (2, 'Cliente Prueba', '00000000', 'El Salvador', 'cliente@gmail.com');

-- Registramos a Alejandra Sofia (ID 8)
INSERT INTO Clientes (IdUsuario, NombreCompleto, Telefono, Nacionalidad, Email)
VALUES (8, 'Alejandra Sofia Peña Campos', '78672391', 'El Salvador', 'alejandrasofiapenacampos@gmail.com');
GO

UPDATE Usuarios
SET Correo = 'moises6molina@gmail.com'
WHERE IdUsuario = 10;

UPDATE Clientes
SET Email = 'moises6molina@gmail.com'
WHERE IdUsuario = 10;

SELECT * FROM Clientes WHERE IdUsuario = 10;

SELECT * FROM Reservas;
Select * From Clientes;
Select * From Usuarios;

DELETE FROM Reservas;
GO

-- 2. ¡EL TRUCO MÁGICO! Reiniciamos el contador de ID de Reservas a 0 
-- (Así tu próxima venta oficial volverá a ser la Reserva #1)
DBCC CHECKIDENT ('Reservas', RESEED, 0);
GO

-- 3. Borramos el perfil personal de Moisés en la tabla Clientes
-- (Sabemos por tu captura de antes que su IdUsuario era el 10)
DELETE FROM Clientes WHERE IdUsuario = 10;
GO

-- 4. Finalmente, destruimos su cuenta de Login en la tabla Usuarios
DELETE FROM Usuarios WHERE IdUsuario = 10;
GO

UPDATE Usuarios
SET Rol = 'Admin' 
WHERE Correo = 'andyzelaya06@gmail.com';