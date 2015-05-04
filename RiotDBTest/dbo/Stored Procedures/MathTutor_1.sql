CREATE PROCEDURE dbo.MathTutor

   @m1 smallint,

   @m2 smallint,

   @result smallint OUTPUT

AS

   SET @result = @m1 * @m2

