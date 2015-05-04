
CREATE PROC dbo.OverdueOrders

AS

SELECT CONVERT(char(8), RequiredDate, 1) RequiredDate,

  CONVERT(char(8), OrderDate, 1) OrderDate,

  OrderID, CustomerID, EmployeeID

  FROM Orders

WHERE RequiredDate < GETDATE() AND ShippedDate IS Null

ORDER BY RequiredDate

