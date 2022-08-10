-- COUNT RETORNA O NUMERO DE LINHA OU A SOMA AGRUPADA
/*
SELECT COUNT(*)
FROM TABELA 

SELECT COUNT(COLUNA1 OU DISTINCT COLUNA1)
*/
SELECT COUNT(*)
FROM Person.Person; 
-- retorna 19,9k
SELECT COUNT(Title)
FROM Person.Person;
-- retorna todos menos os null
SELECT COUNT(DISTINCT Title)
FROM Person.Person;
--retorna somente a contagem dos diferentes

--Desafio 01 Quantos produtos cadatrastos

SELECT COUNT(PRPR.Name)
FROM Production.Product AS PRPR
-- RETORN 504
-- Desafio 2 Quantos tipos de tamanho de produtos temos
SELECT COUNT(Size)
FROM Production.Product -- retorna 211
--dESAFIO  3 Quantos tamanos diferentes
SELECT COUNT(Distinct Size)
FROM Production.Product -- retorna 18
