CREATE PROCEDURE [update_Order Details_1]

(@OrderID_1 [int],

@ProductID_2 [int],

@NewUnitPrice_3 [money] = NULL,

@NewQuantity_4 [smallint]= NULL,

@NewDiscount_5 [real] = NULL)

AS

-- Update Order Detail values

UPDATE [Order Details]

SET [Quantity] = @NewQuantity_4, [UnitPrice] = @NewUnitPrice_3,

[Discount] = @NewDiscount_5

WHERE ( [OrderID] = @OrderID_1 AND [ProductID] = @ProductID_2)

