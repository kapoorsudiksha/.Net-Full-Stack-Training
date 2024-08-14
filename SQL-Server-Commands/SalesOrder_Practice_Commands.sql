
SELECT * FROM [dbo].[Customer];
SELECT * FROM [dbo].[Order];
SELECT * FROM [dbo].[OrderItem];
SELECT * FROM [dbo].[Product];
SELECT * FROM [dbo].[Supplier];

-- List all Orders, sorted by amount (largest first) within each year

	SELECT 
	ID,
	OrderDate, 
	OrderNumber, 
	CustomerID, 
	TotalAmount
	FROM 
	dbo.[Order]
	ORDER BY 
	YEAR(OrderDate) DESC, 
	TotalAmount DESC;

-- List the top 10 most expensive products sorted by price

	SELECT TOP 10 Id, ProductName, SupplierId, UnitPrice, Package, IsDiscontinued
	FROM Product
	ORDER BY UnitPrice DESC;

-- List the 10th to 15th most expensive products sorted by price.

   SELECT Id, ProductName, UnitPrice, Package
   FROM Product
   ORDER BY UnitPrice DESC
   OFFSET 10 ROWS
   FETCH NEXT 5 ROWS ONLY

-- Find the number of unique supplier countries

	SELECT COUNT(DISTINCT Country) UniqueCountries
	FROM dbo.Supplier;

-- List all orders with product name, quantity and price sorted by order number.

	select a.OrderNumber, c.ProductName, b.Quantity, c.UnitPrice from 
	[Order] a join OrderItem b 
	on a.Id = b.OrderId
	join Product c 
	on b.ProductId = c.Id 
	order by a.orderNumber;

-- List all customers and the total amount they sent irrespective whether they placed any orders or not.

	select c.*, TotalAmount 
	from [dbo].[Customer] c left join [dbo].[Order] s 
	on s.CustomerId = c.Id;

-- List customers that have not placed orders

	select * from [dbo].[Customer] c
	where c.Id not in (select CustomerId from [dbo].[Order] )

-- Match all customers and suppliers by country.

	SELECT c.firstName, c.country as CustomerCountry, s.country as SupplierCountry
	FROM customer c inner JOIN Supplier s
	ON c.Country = s.Country

-- Match suppliers that are from the same country

 	SELECT s.CompanyName as CompanyOne, ss.CompanyName as CountryTwo, s.Country
	FROM [dbo].[Supplier] s JOIN [dbo].[Supplier]  ss
	on s.Country = ss.Country AND S.ID <> SS.ID;

-- INcrease the unit price by 10% for all products that have been sold before.

	update p
	set p.unitprice=p.unitprice+(p.unitprice*10/100)
	FROM [Product] as p join [OrderItem] as o 
	on p.Id=o.ProductId

-- Delete products that have not sold.

	delete p 
	FROM [Product] as p join [OrderItem] as 
	o on p.Id <> o.ProductId

-- List all supplier with the number of products they offer.

-- List products with order quantities greater than 100.

-- List all products that have sold over Unit price 45.

-- List customers who placed orders that are larger than the avergage of each customer order.



