SELECT  *
FROM Person.Person PP
INNER JOIN Person.EmailAddress PE
ON PP.BusinessEntityID = PE.BusinessEntityID
WHERE PP.BusinessEntityID > 0;