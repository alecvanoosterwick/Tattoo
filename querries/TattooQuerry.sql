USE r0850108
GO

SELECT * FROM Tattoo.Artist
SELECT * FROM Tattoo.Tattoo
GO

DELETE FROM Tattoo.Artist
DELETE FROM Tattoo.Tattoo
GO

SET IDENTITY_INSERT Tattoo.Artist ON 
INSERT Tattoo.Artist ([Id], [Voornaam], [Achternaam], [Descriptie], [Specialiteiten], [Foto], [Email]) VALUES (1,'Bart','Peeters','6 jaar ervaring, ik maak graag designs, 25 euro per uur','Tribal','Bart.jpg','AljecPeeters@hotmail.com')
INSERT Tattoo.Artist ([Id], [Voornaam], [Achternaam], [Descriptie], [Specialiteiten], [Foto], [Email]) VALUES (2,'Olec','Van Oosterwijck','1O jaar ervaring, ik maak enkel designs van tattoos , 25 euro per uur','Anime','olec.jpg','Aljecvanoosterwijck@hotmail.com' )
INSERT Tattoo.Artist ([Id], [Voornaam], [Achternaam], [Descriptie], [Specialiteiten], [Foto], [Email]) VALUES (3,'Karen','Anders','2 jaar ervaring, ik ben designen van tattoos nog aan het leren maar kan al tattooeren, 20 euro per uur','Dieren','Karen.jpg','AljecAnders@hotmail.com' )
INSERT Tattoo.Artist ([Id], [Voornaam], [Achternaam], [Descriptie], [Specialiteiten], [Foto], [Email]) VALUES (4,'Elise','De Smedt','3 jaar ervaring, ik tattoëer enkel, 20 euro per uur','Cartoons','Elise.jpg','AljecDeSmedt@hotmail.com' )
INSERT Tattoo.Artist ([Id], [Voornaam], [Achternaam], [Descriptie], [Specialiteiten], [Foto], [Email]) VALUES (5,'Bob','De Grootte','Student, Heb op dit moment enkel ervaring op nep huiden, gratis','Schaduw','Bob.jpg','AljecDeGrootte@hotmail.com' )

SET IDENTITY_INSERT Tattoo.Artist OFF
GO

SET IDENTITY_INSERT Tattoo.Tattoo ON
INSERT Tattoo.Tattoo ([Id], [Naam], [Descriptie], [Foto], [ArtistId]) VALUES (1,'Phoenix','Deze tattoo is gebaseerd op het oude mythisch creature de Phoenix, deze tattoo heeft enkele uren gekost maar we zijn blij met de uitkomst!','Phoenix.jpg',1)
INSERT Tattoo.Tattoo ([Id], [Naam], [Descriptie], [Foto], [ArtistId]) VALUES (2,'Draak','Deze tattoo is gebaseerd op een mytisch en fantasierijk oud creature, Deze tattoo heeft 5 uur geduurt om het neer te zetten.','draak.jpg',2 )
INSERT Tattoo.Tattoo ([Id], [Naam], [Descriptie], [Foto], [ArtistId]) VALUES (3,'Illuminati','Deze tattoo is gebaseerd op de illuminati, we hebben handen rond de driehoek gezet dit oogt meer controle op de tattoo. Dit was ook naar de klant zijn wens.','Illuminati.jpg',3 )
INSERT Tattoo.Tattoo ([Id], [Naam], [Descriptie], [Foto], [ArtistId]) VALUES (4,'Mandala','De klant zocht voor een Mandala design, dit heeft enkele uren gekost om te designen. De klant was heel blij met de uitkomst. Het tattoeëren was heel pijnlijk voor de klant','Mandala.jpg',4 )
INSERT Tattoo.Tattoo ([Id], [Naam], [Descriptie], [Foto], [ArtistId]) VALUES (5,'Vogel','Deze tattoo is gebaseerd op de vogel zwaluw, het designen was iets moeilijker omwille van de klant zijn eisen. Maar hij was blij met het eind product.','Vogel.png',5 )
SET IDENTITY_INSERT Tattoo.Tattoo OFF
GO
