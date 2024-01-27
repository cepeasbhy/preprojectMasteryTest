CREATE PROCEDURE [dbo].[sp_get_total_search_results](
	@search VARCHAR(100)
)
AS BEGIN
	SELECT 
		COUNT(*) AS totalSearchResult
	FROM
		Product p
	LEFT JOIN
		Category c ON p.categoryId = c.Id
	WHERE
		p.name LIKE CONCAT('%', @search, '%') OR
		c.name LIKE CONCAT('%', @search, '%');
END