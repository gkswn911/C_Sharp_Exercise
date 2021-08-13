--CASE 문의 형식은  

 

--CASE 컬럼  

--WHEN 조건1 THEN 값1 

--WHEN 조건2 THEN 값2 

--ELSE 값3 

--END 



USE AdventureWorks2008R2;  

GO  

SELECT ProductNumber, Category =  

CASE ProductLine  

WHEN 'R' THEN 'Road'  

WHEN 'M' THEN 'Mountain'  

WHEN 'T' THEN 'Touring'  

WHEN 'S' THEN 'Other sale items' 

ELSE 'Not for sale'  

END, Name  

FROM Production.Product  

ORDER BY ProductNumber; GO  

