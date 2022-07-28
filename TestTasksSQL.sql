--Я запросы не проверял на данных в бд, так что могут быть мелкие косяки

--Первое задание
SELECT C1.Name 
FROM Cars C1,
	(SELECT C.ID i, C.BrandID b
	From Cars C
	WHERE C.Name = "Qashqai") AS Base
WHERE C1.BaseID = Base.i 
AND Cl.BrandID = Base.b

--Второе задание
SELECT B.Name 
FROM Brands B JOIN
(SELECT C.BrandID b FROM Cars C GROUP BY C.BrandID HAVING COUNT(*) > 3) Ca
ON Ca.b = B.ID

--Третье задание
SELECT B.Name, Ca.Pr
FROM Brands B JOIN
(SELECT C.BrandID b, SUM(C.Price) Pr FROM Cars C GROUP BY C.BrandID) Ca
ON Ca.b = B.ID

--Четвёртое задание
SELECT TOP (2) WITH TIES BrCo.N CoName, AVG(C.Pow) AvPow
FROM Cars C JOIN
(SELECT Co.ID Id, Co.Name N FROM Countries Co JOIN Brands B ON Co.ID = B.CountryID) BrCo
ON C.BrandID = BrCo.Id
GROUP BY BrCo.N
ORDER BY AvPow

--Пятое задание
SELECT C.Name Name, B.Name Brand
FROM Cars C JOIN Brands B
ON C.BrandID = B.ID
GROUP BY C.BrandID
HAVING MIN(C.Price)