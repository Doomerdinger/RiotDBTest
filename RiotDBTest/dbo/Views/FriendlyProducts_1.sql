
CREATE VIEW dbo.FriendlyProducts AS
SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice, CompanyName, CategoryName FROM Products, Suppliers, Categories WHERE Products.Discontinued = 0 AND Products.SupplierID = Suppliers.SupplierID AND Products.CategoryID = Categories.CategoryID