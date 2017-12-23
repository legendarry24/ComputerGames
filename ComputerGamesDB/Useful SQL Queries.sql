ALTER AUTHORIZATION ON DATABASE::[DataBaseName] TO sa; -- ��������� ������ dbo �� ����������

DBCC CHECKIDENT ("[dbo].[TableName]", RESEED, 0) -- �������� �������� IDENTITY �� 0
GO

SELECT * FROM INFORMATION_SCHEMA.TABLES;
GO

SELECT * FROM INFORMATION_SCHEMA.COLUMNS;
GO

SELECT 
   ORDINAL_POSITION
  ,TABLE_CATALOG
  ,TABLE_NAME
  ,COLUMN_NAME
  ,DATA_TYPE
  ,CHARACTER_MAXIMUM_LENGTH
  ,IS_NULLABLE
  ,COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS   
  ORDER BY TABLE_NAME
 GO

-- �������� ��������� �������
DELETE FROM tableName
WHERE ID = (SELECT MAX(ID) FROM tableName)

-- �������� � ��������� ���������� '%', ����� ��� �� �������� ������� ��� ������ ���������
SELECT @Name = RTRIM(@Name)	+ '%'; 