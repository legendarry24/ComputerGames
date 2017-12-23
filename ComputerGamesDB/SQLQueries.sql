USE ComputerGamesDB
GO

SELECT * FROM GameRequirements gr	-- Вызов View 
WHERE gr.Игра = 'Hearthstone: Heroes of Warcraft'
GO

SELECT * FROM GameRequirements WHERE Платформа <> 'Игровая консоль'
SELECT * FROM GameRequirements

SELECT * FROM SearchGame WHERE Игра LIKE '%Witcher%'
SELECT * FROM SearchGame WHERE Издатель LIKE '%Warner%'
SELECT * FROM SearchGame WHERE Жанр LIKE 'с%'
SELECT * FROM SearchGame WHERE Стилистика LIKE 'П%'
SELECT * FROM SearchGame WHERE цена IS NULL -- free to play games
SELECT * FROM SearchGame WHERE [Наличие мультиплеера] = 1
SELECT * FROM SearchGame WHERE Киберспортивная = 1
SELECT TOP 5 * FROM SearchGame
ORDER BY Рейтинг DESC

EXEC SearchGameByPlatform		    -- Будет использоваться значение по умолчанию
GO

EXEC SearchGameByPlatform 'Windows' -- передаем процедуре входное значение
GO

EXEC SearchGameByPlatform 'Android' 
GO

EXEC SearchGameByPlatform 'Игровая консоль'
GO

EXEC SearchGameByPlatform 'Windows','Mortal'
GO

SELECT COUNT(*) [кол-во бесплатных]
FROM SearchGame WHERE цена IS NULL

SELECT Издатель, COUNT(Игра) [кол-во выпущенных игр]
FROM SearchGame
GROUP BY  Издатель

EXEC FindGame @Publisher = 'Warner'
EXEC FindGame @Developer = 'CD Projekt RED'
EXEC FindGame 'd', 'a'
EXEC FindGame @Genre = 'ККИ'
EXEC FindGame @Stylistics = 'Пост'