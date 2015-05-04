CREATE PROCEDURE [insert_Order Details_1]

(@OrderID_1 [int],

@ProductID_2 [int],

@UnitPrice_3 [money] = NULL,

@Quantity_4 [smallint],

@Discount_5 [real] = 0)

AS

INSERT INTO [Order Details]

( [OrderID], [ProductID], [UnitPrice], [Quantity], [Discount])

VALUES ( @OrderID_1, @ProductID_2, @UnitPrice_3, @Quantity_4, @Discount_5)

