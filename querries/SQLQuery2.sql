USE r0850108
GO

SELECT * FROM Tattoo.Tattoo

DELETE FROM Tattoo.Tattoo

SET IDENTITY_INSERT Tattoo.Tattoo ON 
INSERT Tattoo.Tattoo ([Id], Foto, Naam, Descriptie, ArtistId) VALUES (1, N'Phoenix.jpg', N'Phoenix', 'Hier moet nog tekst komen', 1)
INSERT Tattoo.Tattoo ([Id], Foto, Naam, Descriptie, ArtistId) VALUES (2, N'Draak.jpg', N'Draak', 'Hier moet nog tekst komen',2)
INSERT Tattoo.Tattoo ([Id], Foto, Naam, Descriptie, ArtistId) VALUES (3, N'Japan', N'Japan','Hier moet nog tekst komen', 3)
INSERT Tattoo.Tattoo ([Id], Foto, Naam, Descriptie, ArtistId) VALUES (4, N'China', N'China', 'Hier moet nog tekst komen', 4)
INSERT Tattoo.Tattoo ([Id], Foto, Naam, Descriptie, ArtistId) VALUES (5, N'iets', N'iets', 'Hier moet nog tekst komen', 5)

SET IDENTITY_INSERT Tattoo.Tattoo OFF
GO
