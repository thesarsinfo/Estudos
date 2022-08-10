-- Order By server para ordenar pelo coluna em ordem crescente ou descrecente

-- Sintaxe
/*
 SELECT COLUNA1,COLUNA2 ...
 FROM TABELA
 ORDER BY COLUNA1 ASC OR DESC
*/

SELECT FirstName,LastName
FROM Person.Person
ORDER BY FirstName ASC, LastName DESC -- dentro do order by  evite usar coluna nao usado no select

-- Desafio 01 Obter ID dos 10 maiores preços do mais caro ao mais barato
SELECT TOP 10 PRODUCTID,ListPrice 
FROM Production.Product
ORDER BY ListPrice DESC
-- Desafio 2 Obter o nome e o numero do produtos que tem ID entre 1 a 4
SELECT PRPR.ProductID,PRPR.Name,PRPR.ProductNumber
FROM Production.Product AS PRPR
WHERE PRPR.ProductID BETWEEN 1 AND 4
ORDER BY PRPR.ProductID DESC

