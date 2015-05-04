CREATE PROCEDURE [delete_Order Details_1]

(@OrderID_1 [int],

@ProductID_2 [int])

AS

--Delete the row with the given OrderID and ProductID in OrderDetails

DELETE [Order Details]

WHERE ( [OrderID] = @OrderID_1 AND [ProductID]= @ProductID_2)

