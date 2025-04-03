

CREATE DATABASE DBDOCENTE;

USE DBDOCENTE;


CREATE TABLE DOCENTE(
	IdDocente int identity,
	Nombres varchar(100),
	Apellidos varchar(100),
	Telefono varchar(100),
	Correo varchar(100),
	Salario numeric(10, 5),
	FechaNacimiento date
)


INSERT INTO DOCENTE(Nombres, Apellidos, Telefono, Correo, Salario, FechaNacimiento) values
('Jose', 'Perez', '980980567', 'jose@gmail.com', 1000.00, '2023-01-01'),
('Maria', 'Paz', '980456345', 'mar@gmail.com', 1000.00, '2023-01-01'),
('Thalia', 'Quiñon', '978678456', 'thalia@gmail.com', 1000.00, '2023-01-01'),
('Belem', 'Madara', '989845634', 'belem@gmail.com', 1000.00, '2023-01-01'),
('Alex', 'Espinoza', '909067854', 'alex@gmail.com', 1000.00, '2023-01-01')

SELECT * FROM DOCENTE

GO



CREATE PROCEDURE sp_Registrar(
	@Nombres varchar(100),
	@Apellidos varchar(100),
	@Telefono varchar(100),
	@Correo varchar(100),
	@Salario numeric(10, 5),
	@FechaNacimiento date
)
AS
BEGIN
	insert into DOCENTE(Nombres, Apellidos, Telefono, Correo, Salario, FechaNacimiento) values (@Nombres, @Apellidos, @Telefono, @Correo, @Salario, @FechaNacimiento)
END

GO

CREATE PROCEDURE sp_Editar(
	@IdDocente int,
	@Nombres varchar(100),
	@Apellidos varchar(100),
	@Telefono varchar(100),
	@Correo varchar(100),
	@Salario numeric(10, 5),
	@FechaNacimiento date
)
AS
BEGIN
	UPDATE DOCENTE SET Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono, Correo = @Correo, Salario = @Salario, FechaNacimiento = @FechaNacimiento where IdDocente = @IdDocente
END

GO

CREATE PROCEDURE sp_Eliminar(
	@IdDocente int
)
AS
BEGIN
	DELETE FROM DOCENTE WHERE IdDocente = @IdDocente
END