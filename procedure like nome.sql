use Facear

go

alter procedure BuscaUsuarioNome
(
	@login varchar(50)
) as begin

Select
	idusuario
	,login
	,senha
From
	Usuario
Where
	login like @login+'%'
Order by
	idUsuario desc
end