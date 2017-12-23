USE ComputerGamesDB
GO

SELECT * FROM GameRequirements gr	-- ����� View 
WHERE gr.���� = 'Hearthstone: Heroes of Warcraft'
GO

SELECT * FROM GameRequirements WHERE ��������� <> '������� �������'
SELECT * FROM GameRequirements

SELECT * FROM SearchGame WHERE ���� LIKE '%Witcher%'
SELECT * FROM SearchGame WHERE �������� LIKE '%Warner%'
SELECT * FROM SearchGame WHERE ���� LIKE '�%'
SELECT * FROM SearchGame WHERE ���������� LIKE '�%'
SELECT * FROM SearchGame WHERE ���� IS NULL -- free to play games
SELECT * FROM SearchGame WHERE [������� ������������] = 1
SELECT * FROM SearchGame WHERE ��������������� = 1
SELECT TOP 5 * FROM SearchGame
ORDER BY ������� DESC

EXEC SearchGameByPlatform		    -- ����� �������������� �������� �� ���������
GO

EXEC SearchGameByPlatform 'Windows' -- �������� ��������� ������� ��������
GO

EXEC SearchGameByPlatform 'Android' 
GO

EXEC SearchGameByPlatform '������� �������'
GO

EXEC SearchGameByPlatform 'Windows','Mortal'
GO

SELECT COUNT(*) [���-�� ����������]
FROM SearchGame WHERE ���� IS NULL

SELECT ��������, COUNT(����) [���-�� ���������� ���]
FROM SearchGame
GROUP BY  ��������

EXEC FindGame @Publisher = 'Warner'
EXEC FindGame @Developer = 'CD Projekt RED'
EXEC FindGame 'd', 'a'
EXEC FindGame @Genre = '���'
EXEC FindGame @Stylistics = '����'