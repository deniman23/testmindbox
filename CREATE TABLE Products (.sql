CREATE TABLE Products (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Products
VALUES
(1, 'meat'),
(2, 'milk'),
(3, 'ice-cream');

CREATE TABLE Categories (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Categories
VALUES
(1, 'meat'),
(2, 'dairy_products'),
(3, 'sweets');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 3),
	(2, 2);


SELECT Prod.Name , Cat.Name
FROM Products Prod
LEFT JOIN ProductCategories prodcat on Prod.Id = prodcat.ProductId
inner JOIN Categories Cat on Cat.Id = prodcat.CategoryId
order by Prod.Name