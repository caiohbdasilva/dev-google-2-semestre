CREATE DATABASE VidaPlena;

USE VidaPlena;

---DDL
CREATE TABLE Pacientes(
    ID_Paciente INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email_paciente VARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE Profissionais(
    ID_Profissional INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Endereco VARCHAR(100),
    Email_profissional VARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE Especialidades(
    ID_Especialidade INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao VARCHAR(100) NOT NULL
)

CREATE TABLE Atendimentos(
    ID_Atendimento INT IDENTITY PRIMARY KEY,
    DataCadastro DATETIME NOT NULL,
    DataAgendada DATETIME NOT NULL,
    StatusAtendimento VARCHAR(100),
    ID_Paciente INT,
    ID_Profissional INT,
    ID_Especialidade INT,

	FOREIGN KEY(ID_Paciente)
	REFERENCES Pacientes(ID_Paciente),

	FOREIGN KEY(ID_Profissional)
	REFERENCES Profissionais(ID_Profissional),

	FOREIGN KEY(ID_Especialidade)
	REFERENCES Especialidades(ID_Especialidade)
)


--DML
INSERT INTO Especialidades (Nome, Descricao)
VALUES 
    ('Clínica Geral', 'Atendimento médico de rotina, check-up e diagnósticos primários.'),
    ('Psicologia', 'Acompanhamento psicoterapêutico e cuidados com a saúde mental.'),
    ('Fisioterapia', 'Reabilitação física, tratamento de lesões e prevenção.'),
    ('Nutrição', 'Planejamento alimentar, dietas e reeducação nutricional.');

INSERT INTO Pacientes (Nome, Email_paciente)
VALUES 
    ('Lucas Silva', 'lucas.silva@email.com'),
    ('Mariana Oliveira', 'mariana.oliveira@email.com'),
    ('Pedro Santos', 'pedro.santos@email.com'),
    ('Julia Costa', 'julia.costa@email.com'),
    ('Rafael Almeida', 'rafael.almeida@email.com'),
    ('Beatriz Lima', 'beatriz.lima@email.com'),
    ('Thiago Pereira', 'thiago.pereira@email.com'),
    ('Gabriela Gomes', 'gabriela.gomes@email.com'),
    ('Felipe Martins', 'felipe.martins@email.com'),
    ('Amanda Rocha', 'amanda.rocha@email.com');

INSERT INTO Profissionais (Nome, Endereco, Email_profissional)
VALUES 
    ('Dr. Carlos Mendes', 'Rua das Primaveras, 10', 'carlos.mendes@vidaplena.com'),
    ('Dra. Luiza Carvalho', NULL, 'luiza.carvalho@vidaplena.com'),
    ('Dr. Renato Teixeira', 'Av. Independência, 200', 'renato.teixeira@vidaplena.com'),
    ('Dra. Vanessa Dias', NULL, 'vanessa.dias@vidaplena.com'),
    ('Dr. Bruno Alves', 'Praça da República, 45', 'bruno.alves@vidaplena.com'),
    ('Dra. Aline Moraes', 'Rua XV de Novembro, 80', 'aline.moraes@vidaplena.com'),
    ('Dr. Roberto Castro', NULL, 'roberto.castro@vidaplena.com'),
    ('Dra. Patricia Souza', 'Av. Brasil, 999', 'patricia.souza@vidaplena.com'),
    ('Dr. Ricardo Fernandes', 'Rua dos Pinheiros, 33', 'ricardo.fernandes@vidaplena.com'),
    ('Dra. Camila Ribeiro', NULL, 'camila.ribeiro@vidaplena.com');

INSERT INTO Atendimentos (DataCadastro, DataAgendada, StatusAtendimento, ID_Paciente, ID_Profissional, ID_Especialidade)
VALUES 
    (GETDATE(), '20260610 08:00:00', 'Realizado', 1, 1, 1),  -- Clínica Geral
    (GETDATE(), '20260610 09:00:00', 'Agendado', 2, 2, 2),   -- Psicologia
    (GETDATE(), '20260610 10:30:00', 'Cancelado', 3, 3, 3),  -- Fisioterapia
    (GETDATE(), '20260611 14:00:00', 'Realizado', 4, 4, 4),  -- Nutrição
    (GETDATE(), '20260611 15:00:00', 'Agendado', 5, 5, 1),   -- Clínica Geral
    (GETDATE(), '20260612 09:00:00', 'Agendado', 6, 6, 2),   -- Psicologia
    (GETDATE(), '20260612 11:00:00', 'Realizado', 7, 7, 3),  -- Fisioterapia
    (GETDATE(), '20260613 13:30:00', 'Cancelado', 8, 8, 4),  -- Nutrição
    (GETDATE(), '20260613 16:00:00', 'Agendado', 9, 9, 1),   -- Clínica Geral
    (GETDATE(), '20260614 10:00:00', 'Agendado', 9, 7, 2), -- Psicologia
    (GETDATE(), '20260615 08:30:00', 'Agendado', 1, 5, 3),   -- Fisioterapia
    (GETDATE(), '20260615 14:00:00', 'Realizado', 2, 1, 1);  -- Clínica Geral


--DQL
-- 1. INNER JOIN
SELECT PR.Nome, PA.Nome, E.Nome, A.DataCadastro
FROM Atendimentos A INNER JOIN Profissionais PR 
ON A.ID_Profissional = PR.ID_Profissional
INNER JOIN Pacientes PA 
ON A.ID_Paciente = PA.ID_Paciente
INNER JOIN Especialidades E
ON A.ID_Especialidade = E.ID_Especialidade

-- 2. LEFT JOIN
SELECT PA.Nome, A.DataAgendada
FROM Pacientes PA LEFT JOIN Atendimentos A
ON PA.ID_Paciente = A.ID_Paciente

-- 3. RIGHT JOIN
SELECT PR.Nome, PA.Nome
FROM Atendimentos A RIGHT JOIN Profissionais PR
ON A.ID_Profissional = PR.ID_Profissional
LEFT JOIN Pacientes PA
ON A.ID_Paciente = PA.ID_Paciente

-- 4. GROUP BY
SELECT E.Nome, COUNT (*) AS 'Nº de atendimentos'
FROM Especialidades E LEFT JOIN Atendimentos A
ON E.ID_Especialidade = A.ID_Especialidade
GROUP BY  E.Nome

-- 5. ORDER BY
SELECT A.ID_Atendimento, A.DataAgendada
FROM Atendimentos A
ORDER BY A.DataAgendada DESC




SELECT * FROM Atendimentos

DROP TABLE Atendimentos