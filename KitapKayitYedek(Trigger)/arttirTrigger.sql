USE [KitapDB]
GO
/****** Object:  Trigger [dbo].[arttir]    Script Date: 20.07.2022 14:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[arttir]
on [dbo].[Kitaplar]
after insert
as 
update Sayac set adet=adet+1