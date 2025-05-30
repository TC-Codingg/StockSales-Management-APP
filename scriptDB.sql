USE [master]
GO
/****** Object:  Database [db_gestion_stock]    Script Date: 26/5/2025 03:23:42 p. m. ******/
CREATE DATABASE [db_gestion_stock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_gestion_stock', FILENAME = N'C:\Users\Equipo\db_gestion_stock.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_gestion_stock_log', FILENAME = N'C:\Users\Equipo\db_gestion_stock_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_gestion_stock] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_gestion_stock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_gestion_stock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_gestion_stock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_gestion_stock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_gestion_stock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_gestion_stock] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_gestion_stock] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_gestion_stock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_gestion_stock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_gestion_stock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_gestion_stock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_gestion_stock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_gestion_stock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_gestion_stock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_gestion_stock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_gestion_stock] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_gestion_stock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_gestion_stock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_gestion_stock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_gestion_stock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_gestion_stock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_gestion_stock] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_gestion_stock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_gestion_stock] SET RECOVERY FULL 
GO
ALTER DATABASE [db_gestion_stock] SET  MULTI_USER 
GO
ALTER DATABASE [db_gestion_stock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_gestion_stock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_gestion_stock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_gestion_stock] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_gestion_stock] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_gestion_stock] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_gestion_stock] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_gestion_stock] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_gestion_stock]
GO
/****** Object:  Table [dbo].[tb_cargos]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_cargos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cargo] [varchar](50) NULL,
	[activo_cargo] [bit] NULL,
 CONSTRAINT [PK_tb_cargos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_departamentos]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_departamentos](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_departamento] [varchar](50) NULL,
	[activo_departamento] [bit] NULL,
 CONSTRAINT [PK_tb_departamentos] PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_empleados]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_empleados](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [varchar](100) NULL,
	[cantidad] [int] NOT NULL,
	[fecha_nacimiento_empleado] [date] NULL,
	[telefono_empleado] [varchar](80) NULL,
	[salario_empleado] [money] NULL,
	[id_departamento] [int] NOT NULL,
	[id_cargo] [int] NOT NULL,
	[activo_empleado] [bit] NULL,
 CONSTRAINT [PK_tb_empleados] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_empleados]  WITH CHECK ADD  CONSTRAINT [FK_tb_empleados_tb_cargos] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[tb_cargos] ([id])
GO
ALTER TABLE [dbo].[tb_empleados] CHECK CONSTRAINT [FK_tb_empleados_tb_cargos]
GO
ALTER TABLE [dbo].[tb_empleados]  WITH CHECK ADD  CONSTRAINT [FK_tb_empleados_tb_departamentos] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[tb_departamentos] ([id_departamento])
GO
ALTER TABLE [dbo].[tb_empleados] CHECK CONSTRAINT [FK_tb_empleados_tb_departamentos]
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZAR_EMPLEADOS]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ACTUALIZAR_EMPLEADOS]
@nIdEmpleado int,
@cNombre varchar (100),
@cDireccion varchar(150),
@dFechaNacimiento date,
@cTelefono varchar (80),
@nSalario money,
@nIdDepartamento int,
@nIdCargo int

AS
	UPDATE tb_empleados SET nombre_empleado = @cNombre,
							cantidad = @cDireccion,
							fecha_nacimiento_empleado = @dFechaNacimiento,
							telefono_empleado = @cTelefono,
							salario_empleado = @nSalario,
							id_departamento = @nIdDepartamento,
							id_cargo = @nIdCargo

	WHERE id_empleado = @nIdEmpleado
GO
/****** Object:  StoredProcedure [dbo].[SP_DESACTIVAR_EMPLEADOS]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DESACTIVAR_EMPLEADOS]
@nIdEmpleado int
AS
	UPDATE tb_empleados SET activo_empleado = 0
	WHERE id_empleado = @nIdEmpleado

GO
/****** Object:  StoredProcedure [dbo].[SP_GUARDAR_EMPLEADOS]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GUARDAR_EMPLEADOS]
@cNombre varchar (100),
@cDireccion varchar(150),
@dFechaNacimiento date,
@cTelefono varchar (80),
@nSalario money,
@nIdDepartamento int,
@nIdCargo int
AS
	INSERT INTO tb_empleados(
								nombre_empleado,
								cantidad,
								fecha_nacimiento_empleado,
								telefono_empleado,
								salario_empleado,
								id_departamento,
								id_cargo,
								activo_empleado)
					VALUES (
								@cNombre,
								@cDireccion,
								@dFechaNacimiento,
								@cTelefono,
								@nSalario,
								@nIdDepartamento,
								@nIdCargo,
								1)
							


GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_CARGOS]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LISTAR_CARGOS]
AS
	SELECT id, nombre_cargo FROM tb_cargos
	WHERE activo_cargo = 1;
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_DEPARTAMENTOS]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LISTAR_DEPARTAMENTOS]
AS
	SELECT id_departamento, nombre_departamento FROM tb_departamentos
	WHERE activo_departamento = 1;
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_EMPLEADOS]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LISTAR_EMPLEADOS]
@cBusqueda varchar(100) = ''
AS

SELECT e.id_empleado AS [ID],
		e.telefono_empleado AS [Código],
		e.nombre_empleado AS [Nombre],
		d.nombre_departamento AS [Marca],
		c.nombre_cargo AS [Tipo],
		e.cantidad AS [Cantidad],
		e.salario_empleado AS [Precio],
		e.fecha_nacimiento_empleado AS [Fecha Ingreso]

FROM tb_empleados e
INNER JOIN tb_departamentos d ON e.id_departamento = d.id_departamento
INNER JOIN tb_cargos c ON e.id_cargo = c.id
WHERE e.activo_empleado = 1 AND 
UPPER(e.nombre_empleado) +
UPPER(d.nombre_departamento) +
UPPER(c.nombre_cargo) +
UPPER(e.telefono_empleado)
LIKE '%'+UPPER(@cBusqueda)+'%'
GO
/****** Object:  StoredProcedure [dbo].[SP_VENDER_PRODUCTO]    Script Date: 26/5/2025 03:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_VENDER_PRODUCTO]
	@cCodigo VARCHAR(15),
	@iCantidad INT,
	@Resultado NVARCHAR(100) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (
		SELECT 1 FROM tb_empleados 
		WHERE telefono_empleado = @cCodigo AND cantidad >= @iCantidad
	)
	BEGIN
		UPDATE tb_empleados 
		SET cantidad = cantidad - @iCantidad
		WHERE telefono_empleado = @cCodigo;

		SET @Resultado = 'OK';
	END
	ELSE
	BEGIN
		SET @Resultado = 'Stock insuficiente o producto no encontrado';
	END
END
GO
USE [master]
GO
ALTER DATABASE [db_gestion_stock] SET  READ_WRITE 
GO
