
CREATE PROCEDURE [dbo].[sp_get_paginated_result](
	@offset INT,
	@next INT,
	@search  VARCHAR(100)
)
AS BEGIN
	SELECT 
		sku, p.id, p.name, c.name AS category
	FROM
		Product p
	LEFT JOIN
		Category c ON p.categoryId = c.Id
	WHERE
		(p.name LIKE CONCAT('%', @search, '%') OR
		c.name LIKE CONCAT('%', @search, '%')) AND
		p.discontinued != 1
	ORDER BY
		p.name
	OFFSET @offset ROWS
	FETCH NEXT @next ROWS ONLY;
END