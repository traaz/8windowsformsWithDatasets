USE [KitapDB]
GO
/****** Object:  Trigger [dbo].[azalt]    Script Date: 20.07.2022 14:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[azalt]
on [dbo].[Kitaplar]
after delete
as
update Sayac set adet=adet-1


