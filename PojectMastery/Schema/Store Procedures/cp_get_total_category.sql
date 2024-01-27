CREATE PROCEDURE [dbo].[sp_get_total_category]
AS BEGIN
	SELECT COUNT(*) FROM Category
END