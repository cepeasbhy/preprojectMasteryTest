CREATE PROCEDURE [dbo].[sp_get_total_products]
AS BEGIN
	SELECT 
		COUNT(*) AS totalProducts
	FROM
		Product
END
