

CREATE PROCEDURE sp_delete_product(@Id INT)
AS BEGIN
	UPDATE Product
		SET dateDeleted = GETDATE(),
		discontinued = 1
	WHERE Id = @Id
END