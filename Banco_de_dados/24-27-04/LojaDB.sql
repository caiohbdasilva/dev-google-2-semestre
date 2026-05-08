CREATE DATABASE LojaBD;

USE LojaBD;

CREATE TABLE Cliente(
	ClienteID INT IDENTITY PRIMARY KEY,
	Nome VARCHAR (100) NOT NULL,
	Email VARCHAR (100)
)

CREATE TABLE Pedidos(
	PedidoID INT IDENTITY PRIMARY KEY,
	DataPedido DATE,
	ValorTotal DECIMAL (10,2),
	ClienteID INT,

	FOREIGN KEY(ClienteID)
	REFERENCES Cliente(ClienteID)
)


INSERT INTO Cliente (Nome, Email) VALUES
('Mariana Torres', 'mariana@email.com'),   
('Paulo Mendes', 'paulo@email.com'),       
('Renata Alves', NULL),                    
('Thiago Pires', 'thiago@email.com'),      
('Vanessa Nogueira', 'vanessa@email.com'), 
('Wallace Freitas', NULL);                 

INSERT INTO Pedidos(DataPedido, ValorTotal, ClienteId) VALUES
('2026-04-01', 180.00, 1),  
('2026-04-03', 75.00, 1),   
('2026-04-05', 220.00, 2),  
('2026-04-08', 410.00, 4),  
('2026-04-10', 95.00, 4),   
('2026-04-12', 60.00, 6);   

INSERT INTO Pedidos (DataPedido, ValorTotal, ClienteId) VALUES
('2026-04-15', 130.00, NULL),  
('2026-04-18', 55.00, NULL); 

-- Ex. 1
SELECT * FROM Cliente

--Ex. 2
SELECT Nome, Email FROM Cliente

--Ex.3
SELECT * FROM Cliente
WHERE ClienteID = 1

--Ex. 4
SELECT * FROM Cliente
ORDER BY Nome

--Ex. 5
SELECT * FROM Pedidos
ORDER BY ValorTotal DESC

--Ex. 6
SELECT * FROM Pedidos
ORDER BY DataPedido DESC

--Ex.7
SELECT c.Nome, p.DataPedido, p.ValorTotal 
FROM Cliente c INNER JOIN Pedidos p
ON c.ClienteID = p.ClienteID

--Ex.8
SELECT c.Nome, p.DataPedido, p.ValorTotal 
FROM Cliente c INNER JOIN Pedidos p
ON c.ClienteID = p.ClienteID
WHERE c.ClienteID = 2

--Ex. 9
SELECT c.Nome, p.PedidoID 
FROM Cliente c LEFT JOIN Pedidos p
ON c.ClienteID = p.ClienteID

--Ex. 10
SELECT c.Nome, p.PedidoID 
FROM Cliente c RIGHT JOIN Pedidos p
ON c.ClienteID = p.ClienteID

--Ex. 11
SELECT c.Nome, p.PedidoID 
FROM Cliente c FULL OUTER JOIN Pedidos p
ON c.ClienteID = p.ClienteID

--Ex. 12
SELECT c.Nome, c.ClienteID, COUNT(*) AS 'Total de itens'
FROM Cliente c JOIN Pedidos p
ON c.ClienteID = p.ClienteID
GROUP BY c.ClienteID, c.Nome

--Ex. 13
SELECT c.ClienteID, SUM(p.ValorTotal) AS 'Total Gasto'
FROM Cliente c RIGHT JOIN Pedidos p
ON c.ClienteID = p.ClienteID
GROUP BY c.ClienteID

-- Ex. 14
SELECT c.Nome, c.ClienteID, SUM(p.ValorTotal) AS 'Total Gasto'
FROM Cliente c INNER JOIN Pedidos p
ON c.ClienteID = p.ClienteID
GROUP BY c.Nome, c.ClienteID

-- Ex. 15
SELECT c.Nome, c.ClienteID, SUM(p.ValorTotal) AS 'Total Gasto'
FROM Cliente c INNER JOIN Pedidos p
ON c.ClienteID = p.ClienteID
GROUP BY c.Nome, c.ClienteID
ORDER BY [Total Gasto] DESC

SELECT *
FROM Pedidos

SELECT *
FROM Cliente