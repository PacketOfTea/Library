IF (OBJECT_ID('CSV_Export') IS NOT NULL) DROP TABLE dbo.CSV_Export;

CREATE TABLE CSV_Export (
	[id]             INT            IDENTITY (1, 1) NOT NULL,
    [Название книги] NVARCHAR (MAX) NULL,
    [Автор книги]    NVARCHAR (MAX) NULL,
    [Дата издания]   NVARCHAR (4)   NULL,
    [Издательство]   NVARCHAR (MAX) NULL,
    [Обложка]        NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)

BULK INSERT dbo.CSV_Export
FROM 'C:\Users\User\data_books.csv'
WITH (fieldterminator = ';', rowterminator = '\n');

