CREATE TABLE [dbo].[Projetablosu] (
    [id]              INT           IDENTITY (1, 1) NOT NULL,
    [Şehir]           NVARCHAR (15) NULL,
    [Üniversite]      NVARCHAR (55) NULL,
    [Bölüm]           NVARCHAR (30) NULL,
    [Puantürü]        NVARCHAR (5)  NOT NULL,
    [Kontenjan]       INT           NULL,
    [Tabansıralaması] FLOAT (53)    NULL,
    [Tabanpuanı]      FLOAT (53)    NULL,
    [Tavansıralaması] FLOAT (53)    NULL,
    [Tavanpuanı]      FLOAT (53)    NULL, 
    CONSTRAINT [PK_Projetablosu] PRIMARY KEY ([id])
);

