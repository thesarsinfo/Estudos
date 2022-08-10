SELECT DISTINCT FirstName AS NomeNaoRepetido
FROM Person.Person
-- result 1018
SELECT DISTINCT FirstName AS Nome, lastName AS Sobrenome
FROM Person.Person; 
-- result 19k
SELECT FIRSTNAME AS NOME
FROM Person.Person; 
-- RESULT 20K
-- CHALLENGE
SELECT DISTINCT lastName AS Sobrenome
FROM Person.Person;
-- 1206 LASTNAMES