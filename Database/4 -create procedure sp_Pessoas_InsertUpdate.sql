CREATE PROCEDURE dbo.sp_Pessoas_InsertUpdate

@id int = -1,
@nome varchar(50),
@sobreNome varchar(50),
@nascimento datetime,
@sexo varchar(15),
@email varchar(50),
@ativo bit

AS

BEGIN 

   Update dbo.Pessoa  SET nome=@nome, sobreNome=@sobreNome, nascimento=@nascimento,  sexo=@sexo, email=@email,
   ativo=@ativo
   Where id=@id; 
   
   
    IF (@@ROWCOUNT = 0) 
    BEGIN 
         INSERT INTO dbo.Pessoa([id],[nome],[sobreNome],[nascimento],[sexo],[email],[ativo])
         VALUES (@id, @nome, @sobrenome,@nascimento,@sexo,@email,@ativo)
         
    END
END