use Facear

go

alter procedure BuscaNome
(
	@nome varchar(50)
) as begin

Select
	idprofessor
	,nome
	,idade
	,sexo
From
	professor
Where
	nome like @nome+'%'
Order by
	idprofessor desc
end