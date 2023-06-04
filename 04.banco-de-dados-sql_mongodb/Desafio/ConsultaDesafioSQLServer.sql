USE Filmes

-- DESAFIOS:
-- CONSULTA 1
SELECT 
	Nome,
	FORMAT(Ano, 'F0', 'pt-BR')
FROM
	Filmes

	
-- CONSULTA 2
SELECT 
	Nome,
	FORMAT(Ano, 'F0', 'pt-BR'),
	Duracao
FROM
	Filmes
	
	
-- CONSULTA 3
SELECT 
	Nome,
	FORMAT(Ano, 'F0', 'pt-BR'),
	Duracao
FROM
	Filmes
WHERE 
	Nome = 'De Volta para o Futuro'
	
	
-- CONSULTA 4
SELECT 
	Nome,
	FORMAT(Ano, 'F0', 'pt-BR'),
	Duracao
FROM
	Filmes
WHERE 
	Ano = 1997		
	
	
-- CONSULTA 5
SELECT 
	Nome,
	FORMAT(Ano, 'F0', 'pt-BR'),
	Duracao
FROM
	Filmes
WHERE 
	Ano > 2000


-- CONSULTA 6
SELECT 
	Nome,
	FORMAT(Ano, 'F0', 'pt-BR'),
	Duracao
FROM
	Filmes
WHERE 
	Duracao > 100 AND Duracao < 150
ORDER BY 
	Duracao ASC


-- CONSULTA 7
SELECT 
	FORMAT(Ano, 'F0', 'pt-BR'),
	COUNT(*) Quantidade
FROM
	Filmes
GROUP BY Ano
ORDER BY Quantidade DESC


-- CONSULTA 8
SELECT 
	Id,
	PrimeiroNome,
	UltimoNome,
	Genero
FROM
	Atores
WHERE 
	Genero = 'M'


-- CONSULTA 9
SELECT 
	Id,
	PrimeiroNome,
	UltimoNome,
	Genero
FROM
	Atores
WHERE 
	Genero = 'F'
ORDER BY 
	PrimeiroNome
	
	
-- CONSULTA 10
SELECT 
	f.Nome,
	g.Genero
FROM
	FilmesGenero fg
INNER JOIN 
	Filmes f
	ON fg.IdFilme = f.Id
INNER JOIN 
	Generos g 
	ON fg.IdGenero = g.Id 
	
	
-- CONSULTA 11
SELECT 
	f.Nome,
	g.Genero
FROM
	FilmesGenero fg 
INNER JOIN
	Filmes f 
	ON fg.IdFilme = f.Id 
INNER JOIN 
	Generos g 
	ON fg.IdGenero = g.Id
WHERE 
	g.Genero = 'Mistério'
	

-- CONSULTA 12
SELECT 
	f.Nome,
	a.PrimeiroNome,
	a.UltimoNome,
	ef.Papel
FROM
	ElencoFilme ef 
INNER JOIN
	Filmes f 
	ON ef.IdFilme = f.Id 
INNER JOIN
	Atores a  
	ON ef.IdAtor = a.Id 

