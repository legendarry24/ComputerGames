ALTER AUTHORIZATION ON DATABASE::[DataBaseName] TO sa; -- устранить ошибку dbo не существует

DBCC CHECKIDENT ("[dbo].[TableName]", RESEED, 0) -- Изменяем значение IDENTITY на 0
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

-- удаление последней строчки
DELETE FROM tableName
WHERE ID = (SELECT MAX(ID) FROM tableName)

-- Добавить к текстовой переменной '%', чтобы его не пришлось вводить при вызове процедуры
SELECT @Name = RTRIM(@Name)	+ '%'; 