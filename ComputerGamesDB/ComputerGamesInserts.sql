USE ComputerGamesDB
GO
/*
DBCC CHECKIDENT ("[dbo].[TableName]", RESEED, 0) -- Изменяем значение IDENTITY на 0
GO
*/
SELECT * FROM [dbo].[Developer] 
SELECT * FROM [dbo].[Publisher] 
SELECT * FROM [dbo].[Game] 
SELECT * FROM [dbo].[Genre] 
SELECT * FROM [dbo].[Platform] 
SELECT * FROM [dbo].[Stylistics] 
SELECT * FROM [dbo].[SupportedPlatform] 
update Game set Price = 3 where Name = 'Call of Duty'
EXEC [dbo].[DeleteLastGenre] [Real Time Strategy]
EXEC [dbo].[DeleteLastStylistics]
EXEC [dbo].[DeleteLastDev]
EXEC [dbo].[ADDGenre] 'Real Time Strategy', 'Real Time Strategy, RTS - стратегия в реальном времени, в которой все игроки выполняют свои действия одновременно, и ход времени не прерывается.'
EXEC [dbo].[UpdateGenre] 'Real Time Strategy', 'Strategy', 'Стратегия — популярный жанр компьютерных игр, в котором залогом достижения победы является планирование и стратегическое мышление.'

EXEC [dbo].[ADDStylistics] 'ШО ', 'тО УПАЛО'
EXEC [dbo].[ADDDeveloper] 'KTO POPALO','HZ.COM','20001010','SRAN','DRAN'
EXEC [dbo].[ADDGame] 'FARM', '20000202', 70, NULL, 0, 0, 0, 'KTO POPALO', 'Chillingo',
'Strategy', 'ШО '
EXEC [dbo].[UpdateGame] 'FARM', 'FARM 2', '20000202', 70, NULL, 0, 0, 0, 'KTO POPALO', 'Chillingo',
NULL
EXEC [dbo].[UpdateGame] 'FARM 2', 'FARM 3', '20000202', 70, NULL, 0, 0, 0, 'KTO POPALO', 'Chillingo',
@StylisticsName = 'ШО '
INSERT INTO [dbo].[Developer]
VALUES 
('Blizzard Entertainment', 'http://eu.blizzard.com',
 '19910208', 'США', 'Ирвайн', 'Калифорния'),
 ('CD Projekt RED', 'http://en.cdprojektred.com',
 '20020201', 'Польша', 'Варшава', NULL),
( 'Arkane Studios', 'http://www.arkane-studios.com',
	'19990105', 'США', 'Остин', 'Техас'),
( 'NetherRealm Studios', 'http://www.netherrealm.com',
    '20100503', 'США', 'Чикаго', 'Иллинойс'),
( 'Eidos Montreal', 'https://www.eidosmontreal.com',
    '20070611', 'Канада', 'Монреаль', NULL),
( 'FromSoftware', 'http://www.fromsoftware.jp',
    '19861101', 'Япония', 'Токио', NULL),
( 'Valve', 'http://www.valvesoftware.com',
    '19960303', 'США', 'Белвью', 'Вашингтон'),
( '4A Games', 'http://www.4a-games.com',
    '20060313', 'Украина', 'Киев', NULL),
( 'DICE', 'http://www.dice.se',
    '19920410', 'Швеция', 'Стокгольм', NULL),
( 'Infinity Ward', 'http://www.infinityward.com',
    '20020111', 'США', 'Лос-Анджелес', 'Калифорния'),
( 'Ubisoft Montreal', 'https://www.ubisoft.com',
    '19970720', 'Канада', 'Монреаль', NULL),
( 'Rovio Entertainment', 'http://www.rovio.com',
    '20030407', 'Финляндия', 'Эспоо', NULL)
GO

INSERT [dbo].[Publisher]
VALUES 
('Activision Blizzard', 'http://www.activisionblizzard.com',
 '20080401', 'США', 'Санта-Моника', 'Калифорния'),
 ('Warner Bros. Entertainment', 'https://www.warnerbros.com',
 '19930415', 'США', 'Бербанк', 'Калифорния'),
('Bethesda Softworks', 'https://bethesda.net',
	'19860417', 'США', 'Роквилл', 'Мэриленд'),
('Square Enix', 'http://www.square-enix.com',
	'20030401', 'Япония', 'Токио', NULL),
('Bandai Namco Holdings', 'http://www.bandainamco.co.jp',
	'20050929', 'Япония', 'Токио', NULL),
('Valve', 'http://www.valvesoftware.com',
    '19960824', 'США', 'Белвью', 'Вашингтон'),
('Akella', 'http://ru.akella.com',
	'19930402', 'Россия', 'Москва', NULL),
('Electronic Arts', 'https://www.ea.com',
    '19820528', 'США', 'Редвуд-Сити', 'Калифорния'),
('Activision', 'https://www.activision.com',
    '19791001', 'США', 'Санта-Моника', 'Калифорния'),
('Ubisoft', 'https://www.ubisoft.com',
    '19860520', 'Франция', 'Монтрёй', NULL),
('Chillingo', 'https://www.ea.com/studios/chillingo',
	'20101004', 'Великобритания', 'Маклсфилд', NULL)
GO

INSERT INTO [dbo].[Genre]
VALUES 
('ККИ', 'Коллекционная карточная игра — разновидность настольных и компьютерных игр.
  В отличие от традиционных карточных игр, коллекционные карточные игры используют
  специальные карты, схожие с коллекционными карточками. В крупных коллекционных 
  карточных играх могут существовать тысячи различных карт.
  Собственно игра между игроками ведётся с использованием различных правил, 
  которые могут сильно различаться для разных игр.'),
('Action/RPG', 'Action/RPG или реже ролевой боевик (англ. Action role-playing game,
  — поджанр компьютерных ролевых игр, в котором ролевая составляющая сочетается с 
  элементами action. Другими словами, если в классической ролевой игре успех действий 
  персонажа во время боевой ситуации зависит от персональных характеристик героя, то в 
  Action/RPG не меньшую роль играет и скорость реакции самого игрока.'),
('Стелс-экшен', 'Стелс-экшен — это жанр компьютерных игр, в которых игроку требуется 
  незаметно перемещаться, прятаться, скрытно и незаметно убивать врагов, и избегать 
  обнаружения, чтобы выполнить миссию.'),
('Файтинг', 'Файтинг — жанр компьютерных игр, имитирующих рукопашный бой малого числа 
  персонажей в пределах ограниченного пространства, называемого ареной.'),
('Шутер от первого лица', 'Шутер от первого лица — жанр видеоигр, в котором игровой
  процесс основывается на сражениях с использованием огнестрельного и метательного
  оружия с видом от первого лица: игрок воспринимает происходящее глазами главного героя.'),
('Action-adventure', 'Action/Adventure, или приключенческий боевик — жанр компьютерных игр, 
  сочетающий элементы квеста и экшена.'),
('Головоломка', 'Головоломка — жанр компьютерных игр, целью которого является решение
  логических задач, требующих от игрока задействования логики, стратегии и интуиции.')
GO

INSERT INTO [dbo].[Stylistics]
VALUES 
('Фэнтези', 'Фэнтези (от англ. fantasy — «фантазия») — жанр фантастической литературы,
  кинематографа, живописи, компьютерных, ролевых и настольных игр, основанный на 
  использовании мифологических и сказочных мотивов. В таком мире может быть реальным
  существование богов, колдовства, мифических существ (драконы, эльфы, гномы, тролли,
  гоблины, кентавры и тд), привидений и любых других фантастических сущностей.'),
('Стимпанк', 'Стимпанк — направление научной фантастики, моделирующее цивилизацию,
  в совершенстве освоившую механику и технологии паровых машин. Как правило, стимпанк
  подразумевает альтернативный вариант развития человечества с выраженной общей
  стилизацией под эпоху викторианской Англии (вторая половина XIX века) и эпоху
  раннего капитализма с характерным городским пейзажем и контрастным социальным
  расслоением. Возможно, однако, и наличие в произведениях стимпанка большей или 
  меньшей доли элементов фэнтези.'),
('Киберпанк', 'Киберпанк — жанр научной фантастики, отражающий упадок человеческой
  культуры на фоне технологического прогресса в компьютерную эпоху. Обычно произведения,
  относимые к жанру «киберпанк», описывают антиутопический мир будущего, в котором высокое
  технологическое развитие, такое как информационные технологии и кибернетика, сочетается с
  глубоким упадком или радикальными переменами в социальном устройстве'),
('Постапокалиптика', 'Постапокалиптика — жанр научной фантастики, в котором действие
  развивается в мире, пережившем глобальную катастрофу. Постапокалиптическим называют
  также творческий стиль, несущий настроение пустынности, одиночества и ужаса в образах 
  постаревшей и покинутой техники или зданий.'),
('Современная', 'Современная стилистика (от англ. modern), подразумевает события современного
  мира, то есть сегодняшняя временная эпоха'),
('Историческая', 'Историческая стилистика, подразумевает реальные исторические события или
  альтернативную историю')
GO

INSERT INTO [dbo].[Platform] ([Type])
VALUES 
('Windows'), ('Android'), ('Игровая консоль')
GO

-- new
INSERT INTO [dbo].[Game]
VALUES 
('Hearthstone: Heroes of Warcraft', '2014-03-11',
 88, NULL, 1, 1, 1, (SELECT ID FROM Developer WHERE [Name] = 'Blizzard Entertainment'), 1, 1, 1)
GO

INSERT INTO [dbo].[Game] (Name, ReleaseDate, Rating, Price, Multiplatform, 
DeveloperID, PublisherID, GenreID, StylisticsID)
VALUES 
('The Witcher 3: Wild Hunt', '2015-05-19',
93, 19.99, 1, (SELECT ID FROM Developer WHERE [Name] = 'CD Projekt RED'),
(SELECT ID FROM [Publisher] WHERE [Name] = 'Warner Bros. Entertainment'), 2, 1)
GO

INSERT INTO [dbo].[Game] 
VALUES 
('Dishonored', '20121009', 91, 14.96, 0, 0, 1, [dbo].[GetDevID]('Arkane Studios'),
[dbo].[GetPubID]('Bethesda Softworks'),[dbo].[GetGenID]('Стелс-экшен'), [dbo].[GetStID]('Стимпанк')),
('Mortal Kombat X', '20150414', 83, 19.99, 1, 1, 1, [dbo].[GetDevID]('NetherRealm Studios'),
[dbo].[GetPubID]('Warner Bros. Entertainment'),[dbo].[GetGenID]('Файтинг'), [dbo].[GetStID]('Фэнтези')),
('Deus Ex: Human Revolution', '20110823', 90, 11.99, 0, 0, 1, [dbo].[GetDevID]('Eidos Montreal'),
[dbo].[GetPubID]('Square Enix'),[dbo].[GetGenID]('Стелс-экшен'), [dbo].[GetStID]('Киберпанк')),
('Dark Souls', '20110922', 89, 19.98, 1, 0, 1, [dbo].[GetDevID]('FromSoftware'),
[dbo].[GetPubID]('Bandai Namco Holdings'),[dbo].[GetGenID]('Action/RPG'), [dbo].[GetStID]('Фэнтези')),
('Counter-Strike: Global Offensive', '20120821', 81, 9.99, 1, 1, 1, [dbo].[GetDevID]('Valve'),
[dbo].[GetPubID]('Valve'),[dbo].[GetGenID]('Шутер от первого лица'), [dbo].[GetStID]('Современная')),
('Метро 2033', '20100320', 81, 12.59, 0, 0, 1, [dbo].[GetDevID]('4A Games'),
[dbo].[GetPubID]('Akella'),[dbo].[GetGenID]('Шутер от первого лица'), [dbo].[GetStID]('Постапокалиптика')),
('Battlefield 3', '20110302', 90, 17.52, 1, 1, 1, [dbo].[GetDevID]('DICE'),
[dbo].[GetPubID]('Electronic Arts'),[dbo].[GetGenID]('Шутер от первого лица'), [dbo].[GetStID]('Современная')),
('Call of Duty', '20031029', 91, 9.99, 1, 0, 1, [dbo].[GetDevID]('Infinity Ward'),
[dbo].[GetPubID]('Activision'),[dbo].[GetGenID]('Шутер от первого лица'), [dbo].[GetStID]('Современная')),
('Assassin’s Creed', '20080411', 80, 9.99, 0, 0, 1, [dbo].[GetDevID]('Ubisoft Montreal'),
[dbo].[GetPubID]('Ubisoft'),[dbo].[GetGenID]('Action-adventure'), [dbo].[GetStID]('Историческая')),
('Angry Birds', '20091210', 87, NULL, 0, 0, 0, [dbo].[GetDevID]('Rovio Entertainment'),
[dbo].[GetPubID]('Chillingo'),[dbo].[GetGenID]('Головоломка'), NULL)
GO

INSERT INTO [dbo].[SupportedPlatform]
VALUES 
(1, 1, 'Отлично', 2.2, 2, 3, 'Windows 7'),
(1, 2, 'Нормально', 1.5, 1, 3, 'Android 4.4.2'),
(2, 1, 'Отлично', 3.3, 6, 40, 'Windows 7'),
(2, 3, 'Отлично', NULL, NULL, 35, NULL),
([dbo].[GetGameID]('Dishonored'), [dbo].[GetPlID]('Windows'), 'Отлично', 2.4, 3, 9, 'Windows 7'),
([dbo].[GetGameID]('Dishonored'), [dbo].[GetPlID]('Игровая консоль'), 'Отлично', NULL, NULL, 8, NULL),
([dbo].[GetGameID]('Mortal Kombat X'), [dbo].[GetPlID]('Windows'), 'Нормально', 2.67, 3, 36, 'Windows 7'),
([dbo].[GetGameID]('Mortal Kombat X'), [dbo].[GetPlID]('Игровая консоль'), 'Отлично', NULL, NULL, 30, NULL),
([dbo].[GetGameID]('Mortal Kombat X'), [dbo].[GetPlID]('Android'), 'Нормально',  NULL, 1, 1.5, 'Android 4.0'),
([dbo].[GetGameID]('Deus Ex: Human Revolution'), [dbo].[GetPlID]('Windows'), 'Отлично', 2, 2, 17, 'Windows XP'),
([dbo].[GetGameID]('Deus Ex: Human Revolution'), [dbo].[GetPlID]('Игровая консоль'), 'Отлично', NULL, NULL, 15, NULL),
([dbo].[GetGameID]('Dark Souls'), [dbo].[GetPlID]('Windows'), 'Ужасно', 3, 2, 8, 'Windows XP'),
([dbo].[GetGameID]('Dark Souls'), [dbo].[GetPlID]('Игровая консоль'), 'Отлично', NULL, NULL, 6, NULL),
([dbo].[GetGameID]('Counter-Strike: Global Offensive'), [dbo].[GetPlID]('Windows'), 'Отлично', 2.2, 2, 15, 'Windows XP'),
([dbo].[GetGameID]('Counter-Strike: Global Offensive'), [dbo].[GetPlID]('Игровая консоль'), 'Нормально', NULL, NULL, 12, NULL),
([dbo].[GetGameID]('Метро 2033'), [dbo].[GetPlID]('Windows'), 'Нормально', 2.2, 1, 12, 'Windows XP'),
([dbo].[GetGameID]('Метро 2033'), [dbo].[GetPlID]('Игровая консоль'), 'Нормально', NULL, NULL, 11, NULL),
([dbo].[GetGameID]('Battlefield 3'), [dbo].[GetPlID]('Windows'), 'Отлично', 2.4, 2, 20, 'Windows Vista'),
([dbo].[GetGameID]('Battlefield 3'), [dbo].[GetPlID]('Игровая консоль'), 'Нормально', NULL, NULL, 15, NULL),
([dbo].[GetGameID]('Call of Duty'), [dbo].[GetPlID]('Windows'), 'Отлично', 0.6, 0.128, 1.4, 'Windows XP'),
([dbo].[GetGameID]('Call of Duty'), [dbo].[GetPlID]('Игровая консоль'), 'Нормально', NULL, NULL, 1, NULL),
([dbo].[GetGameID]('Assassin’s Creed'), [dbo].[GetPlID]('Windows'), 'Нормально', 2.2, 1, 8, 'Windows Vista'),
([dbo].[GetGameID]('Assassin’s Creed'), [dbo].[GetPlID]('Игровая консоль'), 'Отлично', NULL, NULL, 6, NULL),
([dbo].[GetGameID]('Angry Birds'), [dbo].[GetPlID]('Android'), 'Отлично',  NULL, 0.512, 0.171, 'Android 2.3')
GO

INSERT INTO [dbo].[Platform] ([Type])
VALUES 
('Утюг')
GO