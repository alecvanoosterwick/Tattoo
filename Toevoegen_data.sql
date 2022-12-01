Use [r0850108]
go

Delete From [Tattoo].[Artist]
Delete From [Tattoo].[OrderLijn]
Delete From [Tattoo].[Orders]
Delete From [Tattoo].[Product]
Delete From [Tattoo].[Tattoo]
Delete From [Tattoo].[TattooKlant]
GO

Set IDENTITY_INSERT [Tattoo].[Artist] ON
INSERT [Tattoo].[Artist] ([id],[Foto],[Voornaam],[Achternaam],[Descriptie],[Specialiteiten]) values (1,'bart.jpg','Bart','Peeters','6 jaar ervaring, ik maak graag designs, 25 euro per uur','Tribal')
INSERT [Tattoo].[Artist] ([id],[Foto],[Voornaam],[Achternaam],[Descriptie],[Specialiteiten]) values (2,'bob.jpg','Bob','De Groote','Student, Heb op dit moment enkel ervaring op nep huiden, gratis','Dieren')
INSERT [Tattoo].[Artist] ([id],[Foto],[Voornaam],[Achternaam],[Descriptie],[Specialiteiten]) values (3,'Elise.jpg','Elise','Anders','3 jaar ervaring, ik tattoëer enkel, 20 euro per uur','Anime')
INSERT [Tattoo].[Artist] ([id],[Foto],[Voornaam],[Achternaam],[Descriptie],[Specialiteiten]) values (4,'Karen.jpg','Karen','De Smedt','1O jaar ervaring, ik maak enkel designs van tattoos , 25 euro per uur','Dieren')
INSERT [Tattoo].[Artist] ([id],[Foto],[Voornaam],[Achternaam],[Descriptie],[Specialiteiten]) values (5,'Olec.jpg','Olec','Van Oosterwijck','2 jaar ervaring, ik ben designen van tattoos nog aan het leren maar kan al tattooeren, 20 euro per uur','Shaduw')
SET IDENTITY_INSERT [Tattoo].[Artist] OFF
GO

Set IDENTITY_INSERT [Tattoo].[Tattoo] ON
INSERT [Tattoo].[Tattoo] ([id],[Foto],[Naam],[Descriptie],[ArtistId]) values (1,'phoenix.jpg','Phoenix','Dit is een tattoo gebaseerd op het mytisch beest de Phoenix, onze artiest heeft er 5 uur aan gewerkt.',1)
INSERT [Tattoo].[Tattoo] ([id],[Foto],[Naam],[Descriptie],[ArtistId]) values (2,'vogel.jpg','Zwaluw','Deze tattoo is gebaseerd op een zwaluw, het is een kleine tattoo dat enkele uren heeft geduurt.',2)
INSERT [Tattoo].[Tattoo] ([id],[Foto],[Naam],[Descriptie],[ArtistId]) values (3,'draak.jpg','Draak','Het designen van de draak heeft op zichzelf al 3 uur genomen van onze artiest. Maar we zijn fier op het resultaat van de tattoo.',3)
INSERT [Tattoo].[Tattoo] ([id],[Foto],[Naam],[Descriptie],[ArtistId]) values (4,'illuminati.jpg','Illuminati','Als designer hadden we een tattoo mogen designen op deze vereisten, Controleren, illuminati, bezittelijk en kwamen we op dit design.',4)
INSERT [Tattoo].[Tattoo] ([id],[Foto],[Naam],[Descriptie],[ArtistId]) values (5,'trippie.jpg','Trippie','Onze klant wouw een tattoo met een patroon, we hebben er enkele gemaakt en dit was het eindproduct.',5)
SET IDENTITY_INSERT [Tattoo].[Tattoo] OFF
GO

Set IDENTITY_INSERT [Tattoo].[Product] ON
INSERT [Tattoo].[Product] ([id],[Foto],[Naam],[Descriptie],[Prijs],[Merk]) values (1,'inktroze.jpg','Roze inkt','Radiant Colors is een bedrijf dat gespecialiseerd is in de kunst van het tatoeëren. Ze werken nauw samen met gerenommeerde tattoo-artiesten van over de hele wereld.Deze ervaring heeft ze in staat gesteld een inkt te lanceren die gebruik maakt van de nieuwste technologie.Radiant Colors heeft een puur pigment gecreëerd die gemakkelijk is aan te brengen. De homogene vloeibare mix geeft een stevige, langdurige, heldere kleur.',19.99,'Radiant Colors')
INSERT [Tattoo].[Product] ([id],[Foto],[Naam],[Descriptie],[Prijs],[Merk]) values (2,'inktgeel.jpg','Gele inkt','Radiant Colors is een bedrijf dat gespecialiseerd is in de kunst van het tatoeëren. Ze werken nauw samen met gerenommeerde tattoo-artiesten van over de hele wereld.Deze ervaring heeft ze in staat gesteld een inkt te lanceren die gebruik maakt van de nieuwste technologie.Radiant Colors heeft een puur pigment gecreëerd die gemakkelijk is aan te brengen. De homogene vloeibare mix geeft een stevige, langdurige, heldere kleur.',19.99,'Radiant Colors')
INSERT [Tattoo].[Product] ([id],[Foto],[Naam],[Descriptie],[Prijs],[Merk]) values (3,'inktblauw.jpg','Blauwe inkt','Radiant Colors is een bedrijf dat gespecialiseerd is in de kunst van het tatoeëren. Ze werken nauw samen met gerenommeerde tattoo-artiesten van over de hele wereld.Deze ervaring heeft ze in staat gesteld een inkt te lanceren die gebruik maakt van de nieuwste technologie.Radiant Colors heeft een puur pigment gecreëerd die gemakkelijk is aan te brengen. De homogene vloeibare mix geeft een stevige, langdurige, heldere kleur.',19.99,'Radiant Colors')
INSERT [Tattoo].[Product] ([id],[Foto],[Naam],[Descriptie],[Prijs],[Merk]) values (4,'inktzwart.jpg','Zwarte inkt','Radiant Colors is een bedrijf dat gespecialiseerd is in de kunst van het tatoeëren. Ze werken nauw samen met gerenommeerde tattoo-artiesten van over de hele wereld.Deze ervaring heeft ze in staat gesteld een inkt te lanceren die gebruik maakt van de nieuwste technologie.Radiant Colors heeft een puur pigment gecreëerd die gemakkelijk is aan te brengen. De homogene vloeibare mix geeft een stevige, langdurige, heldere kleur.',19.99,'Radiant Colors')
INSERT [Tattoo].[Product] ([id],[Foto],[Naam],[Descriptie],[Prijs],[Merk]) values (5,'inktpaars.jpg','Paarse inkt','Radiant Colors is een bedrijf dat gespecialiseerd is in de kunst van het tatoeëren. Ze werken nauw samen met gerenommeerde tattoo-artiesten van over de hele wereld.Deze ervaring heeft ze in staat gesteld een inkt te lanceren die gebruik maakt van de nieuwste technologie.Radiant Colors heeft een puur pigment gecreëerd die gemakkelijk is aan te brengen. De homogene vloeibare mix geeft een stevige, langdurige, heldere kleur.',19.99,'Radiant Colors')
SET IDENTITY_INSERT [Tattoo].[Product] OFF
GO