CREATE TABLE [dbo].[Transaksi] (
    [Id_transaksi]  INT         IDENTITY (1, 1) NOT NULL,
    [Id_barang]     INT         NULL,
    [nama_barang]   NCHAR (100) NULL,
    [harga_barang]  INT         NULL,
    [jumlah_barang] INT         NULL,
    PRIMARY KEY CLUSTERED ([Id_transaksi] ASC),
    CONSTRAINT [FK_Barang] FOREIGN KEY ([Id_barang]) REFERENCES [dbo].[Barang] ([Id])
);

