CREATE PROCEDURE dbo.sp_Produtos_InsertUpdate

@id int,
@idPessoa int,
@nome varchar(50)

AS

BEGIN 

   Update dbo.Produto  SET nome=@nome
   Where id=@id and pessoa_id=@idPessoa; 
   
   
    IF (@@ROWCOUNT = 0) 
    BEGIN 
         INSERT INTO dbo.Produto([id],[pessoa_id],[nome])
         VALUES (@id, @idPessoa, @nome)
         
    END
END