
CREATE PROCEDURE sp_update_product
(
    @id				INT,
    @name			VARCHAR(100),
    @description	VARCHAR(MAX),
    @categoryId		INT,
    @sku			CHAR(13),
    @size			CHAR(3),
    @color			CHAR(100),
    @weight			DECIMAL(7, 2),
    @price			DECIMAL(10, 2),
    @urlPhoto		VARCHAR(MAX)
) AS BEGIN
UPDATE dbo.Product
SET
    [name] = @name,
    [description] = @description,
    sku = @sku,
    size = @size,
    color = @color,
    [weight] = @weight,
    price = @price,
    urlPhoto = @urlPhoto
WHERE Id = @id
END;