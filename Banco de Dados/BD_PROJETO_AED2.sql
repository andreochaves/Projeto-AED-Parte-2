CREATE DATABASE projeto_aed2;

USE projeto_aed2;

CREATE TABLE Cliente(
	id INT IDENTITY NOT NULL,
	nome VARCHAR(255) NOT NULL,
	cpf VARCHAR(15) NOT NULL,
	endereco VARCHAR(255) NOT NULL,
	idade INT NOT NULL,
	qtd_pontos_fidelidade INT NOT NULL
);

CREATE TABLE Funcionario(
	id INT IDENTITY NOT NULL,
	nome VARCHAR(255) NOT NULL,
	cpf VARCHAR(15) NOT NULL,
	endereco VARCHAR(255) NOT NULL,
	idade INT NOT NULL,
	usuario VARCHAR(255) NOT NULL,
	senha VARCHAR(255) NOT NULL
);

CREATE TABLE Carro(
	id INT IDENTITY NOT NULL,
	marca VARCHAR(255) NOT NULL,
	modelo VARCHAR(255) NOT NULL,
	placa VARCHAR(255) NOT NULL,
	cor VARCHAR(255) NOT NULL,
	cavalos VARCHAR(255) NOT NULL,
	torque_motor VARCHAR(255) NOT NULL
	);

CREATE TABLE Moto(
	id INT IDENTITY NOT NULL,
	marca VARCHAR(255) NOT NULL,
	modelo VARCHAR(255) NOT NULL,
	placa VARCHAR(255) NOT NULL,
	cor VARCHAR(255) NOT NULL,
	cilindradas INT NOT NULL
	);

CREATE TABLE Servico(
	id INT IDENTITY NOT NULL,
	nome VARCHAR(255) NOT NULL,
	valor float NOT NULL
);

CREATE TABLE Orcamento(
	id INT IDENTITY NOT NULL,
	nome VARCHAR(255) NOT NULL,
	valor_total float NOT NULL
);

CREATE TABLE Cliente_Veiculo_Sevico(
	id INT IDENTITY NOT NULL,
	cpf_cliente VARCHAR(15) NOT NULL,
	placa_veiculo VARCHAR(255) NOT NULL,
	id_servico INT NOT NULL
);