-- SELECT explicação
 -- qualquer banco de dados de sql
-- coluna1, coluna2, ou função(coluna1)
-- * seleciona tudo 
-- FROM   tabela

SELECT *
FROM    person.Person;

SELECT title
FROM person.person;

-- Exercicio proposto selecionar todos os nomes e sobrenomes

SELECT firstName AS Nome, lastName AS Sobrenome
FROM person.person;