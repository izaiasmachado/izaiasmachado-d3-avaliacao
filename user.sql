-- Cria o banco de dados da avalia��o
CREATE DATABASE [D3-Avaliacao];
GO

-- Seleciona o banco de dados
USE [D3-Avaliacao];
GO

-- Cria a tabela Users com os campos solicitados
CREATE TABLE Users (
	IdUser					VARCHAR(255) NOT NULL UNIQUE,
	[Name]					VARCHAR(255) NOT NULL,
	[Email]				    VARCHAR(255) NOT NULL,
	[Password]				TEXT NOT NULL
);
GO

-- Insere um registro na tabela de usu�rios
INSERT INTO Users (IdUser, [Name], [Email], [Password])
VALUES				 ('0', 'Administrador', 'admin@email.com', 'admin123');
GO

-- Lista os usu�rios
SELECT * FROM Users;
GO