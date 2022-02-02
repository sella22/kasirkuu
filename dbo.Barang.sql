CREATE TABLE [dbo].[Barang] (
    [Id]            INT         IDENTITY (1, 1) NOT NULL,
    [nama_barang]   NCHAR (100) NULL,
    [harga_barang]  INT         NULL,
    [jumlah_barang] INT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

