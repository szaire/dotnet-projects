-- Os comandos no SQL são chamados de "cláusulas".
-- São como se fossem funções prederteminadas pelo SQL
-- que saõ escritas ao longo do código, interpretadas e
-- executadas.

-- Fazendo consultas de todas as linhas com o SELECT
-- Selecionando todos as colunas com *
-- Indicando de que tabela irei puxar dados com FROM
-- Selecionando a Tabela que irei fazer a consulta
SELECT * FROM Clientes
-- Ordenando as consultas realizadas pelo Nome (Alfabético)
ORDER BY Nome

-- É possível aplicar ordenação nas consultas como:
--	Do menor pro maior (ASC)
SELECT * FROM Clientes
ORDER BY Sobrenome ASC -- (Alfabeticamente)

--	Do maior pro menor (DESC)
SELECT * FROM Clientes
ORDER BY Id DESC	   -- (Numericamente)

--	Múltipla consulta (Mais de um parâmetro)
SELECT * FROM Clientes
ORDER BY Nome, Sobrenome

-- Mostrando apenas as colunas que são selecionadas:
SELECT Id, Email, AceitaComunicados FROM Clientes

-- Realizando um filtro com WHERE
SELECT * FROM Clientes
WHERE AceitaComunicados = 1
ORDER BY Nome, Sobrenome DESC

-- Filtrando com WHERE e Condicionais (AND e OR)
SELECT * FROM Clientes
-- Aqui é feita um condicionamento onde se filtra todos
-- os clientes que aceitam comunicados E possuem nome de
-- Jeff
WHERE AceitaComunicados = 1 AND Nome = 'Jeff'
ORDER BY Nome, Sobrenome DESC

SELECT * FROM Clientes
-- Aqui é feita um condicionamento onde se filtra todos
-- os clientes que aceitam comunicados OU possuem nome de
-- Jeff. Dessa forma o SQL ignora a segunda proposta caso
-- a primeira seja verdadeira. Haverá apenas uma ocorrência
-- onde AceitaComunicados = 0 pois há um cliente chamado
-- Jeff que não aceita comunicados.
WHERE AceitaComunicados = 1 OR Nome = 'Jeff'
ORDER BY Nome, Sobrenome DESC

-- Filtrando com cláusula de comparação LIKE
-- Maneira errada de filtrar:
SELECT * FROM Clientes
WHERE Nome = 'A' -- Não existe nome igual a A, mas...

-- Maneira Certa de filtrar com LIKE:
SELECT * FROM Clientes
WHERE Nome LIKE 'A%' -- ...Existem nomes que começam com A...

-- ...e também há nomes que contenham a letra A no meio
-- da palavra
SELECT * FROM Clientes
WHERE Nome LIKE '%A%'

-- Cláusula INSERT: Acrescentando dados à tabela
-- Indico a tabela que quero adicionar com INSERT INTO
-- Entre parênteses coloco os campos que quero adicionar na
-- ordem que quero adicionar
-- defino os valores do novo elemento com VALUES
INSERT INTO Clientes (Sobrenome, Nome, Email, AceitaComunicados, DataCadastro)
VALUES ('Samuel', 'Zaire', 'samzai@email.com', 1, GETDATE())

-- É possível fazer o INSERT sem depender da ordem das colunas
INSERT INTO Clientes VALUES ('Pedro', 
							 'Quinhas', 
							 'pedro@quinhas.com', 
							 0, 
							 GETDATE())

-- Não é necessário passar o valor da coluna ID pois ela é
-- entendida como um identificador único da tabela (chave
-- primária), o qual será incrementado sempre que houver
-- adição de linhas.

SELECT * FROM Clientes
WHERE DataCadastro LIKE '2023%'

-- Cláusula UPDATE: Alteração de um valor dentro da tabela
-- Atualização do email de Zaire Samuel
SELECT * FROM Clientes
WHERE Id = 1004

-- Sintaxe do UPDATE:
-- Sinalizo qual tabela quero alterar com UPDATE
-- Sinalizo quais campos (colunas) quero alterar com SET
-- Filtro o elemento que quero alterar com WHERE (IMPORTANTE!)
--		OBS: Fazer a alteração em base do ID, nunca com base
--			 em outro campo. Pois ID é uma identificação
--			 única, logo, estarei alterando apenas um
--			 elemento como no caso abaixo.
UPDATE Clientes
SET Email = 'updated@email.com',
	AceitaComunicados = 0
WHERE Id = 1004

-- Realizando UPDATEs sem a clausula WHERE
-- OBS: Na maioria dos casos, isso não poderá ser reproduzido
-- pois pode gerar consequências gigantescas

-- Para tornar esse tipo de UPDATE mais seguro para a
-- consistência do banco de dados, é necessário usar:
BEGIN TRAN -- ou BEGIN TRANSACTION
-- Esse comando irá salvar o estado atual do banco de dados
-- para possíveis futuros backups

UPDATE Clientes
SET Email = 'updated@email.com',
	AceitaComunicados = 0
GO

SELECT * FROM Clientes
	
ROLLBACK
-- Esse comando irá "rodar para trás", ou seja
-- retornar ao backup feito anteriormente pelo BEGIN TRAN antes
-- de qualquer alteração brusca no banco de dados

-- Clausula DELETE
-- Outro caso em que a clausula WHERE tem de estar presente
-- para que não ocorram desastres no banco de dados
SELECT * FROM Clientes
WHERE Nome = 'Pedro'

































