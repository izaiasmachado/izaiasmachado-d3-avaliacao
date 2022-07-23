-- Cria o banco de dados da avaliação
CREATE DATABASE [izaiasmachado-d3-avaliacao];
GO

-- Seleciona o banco de dados
USE [izaiasmachado-d3-avaliacao];
GO

-- Cria a tabela Users com os campos solicitados
CREATE TABLE Users (
	IdUser					VARCHAR(255) NOT NULL UNIQUE,
	[Name]					VARCHAR(255) NOT NULL,
	[Email]				    VARCHAR(255) NOT NULL,
	[Password]				TEXT NOT NULL
);
GO

-- Insere um registro na tabela de usuários
INSERT INTO Users (IdUser, [Name], [Email], [Password])
VALUES				 ('0', 'Administrador', 'admin@email.com', '$2a$11$mQ/7u.5zKuQBvxFCtvxGLeMIMCb.lnHaqMjrsePFsZD8N9lCiQJH6');
GO

--- Registro antigo, sem o hash da senha:
--- VALUES				 ('0', 'Administrador', 'admin@email.com', 'admin123');

-- Lista os usuários
SELECT * FROM Users;
GO