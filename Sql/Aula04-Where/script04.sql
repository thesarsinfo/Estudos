-- Where
/*
SELECT  coluna1, coluna2
FROM tabela
WHERE condição

operadores logicos = do python

*/

SELECT * 
FROM PERSON.PERSON
WHERE lastName = 'miller' and firstName = 'Anna';

SELECT PP.Name as Nome , PP.ListPrice AS Preço, PP.Color AS Cor
FROM Production.Product AS PP
WHERE (COLOR = 'Black' or Color = 'Blue') and ListPrice >= 100.00 and ListPrice <= 1000.00; 

-- Desafio 1
/*
Todas as peças que pesam mais que 500kg ate 700kg
*/

SELECT PP.Name AS Nome , PP.Weight AS Peso
FROM Production.Product AS PP
WHERE PP.Weight BETWEEN 500.00 AND 700.00;

-- Desafio 2
SELECT *
FROM HumanResources.Employee
WHERE MaritalStatus = 'S' and SalariedFlag = 1

--Desafio 3 Ache o email do caloteiro Peter Krebs

SELECT EmailAddress AS 'Email Caloteiro'
FROM Person.EmailAddress
WHERE BusinessEntityID = (
    SELECT BusinessEntityID 
    FROM Person.Person
    WHERE  FirstName = 'Peter' AND LastName = 'Krebs' )


