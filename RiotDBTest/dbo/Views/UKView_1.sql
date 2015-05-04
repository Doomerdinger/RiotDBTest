
CREATE VIEW dbo.UKView AS
SELECT OrderID, CustomerID, Shippers.CompanyName AS CompanyName, ShipName, ShipCity, ShipCountry FROM Orders, Shippers WHERE Orders.ShipVia = Shippers.ShipperID AND Orders.ShipCountry = 'UK' AND Orders.OrderID > 10399 AND Orders.OrderID < 10601