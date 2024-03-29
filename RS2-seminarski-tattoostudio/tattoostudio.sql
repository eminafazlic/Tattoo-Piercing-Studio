USE [TattooStudioRSII]

SET IDENTITY_INSERT [dbo].[Spol] ON 

INSERT [dbo].[Spol] ([SpolId], [Naziv]) VALUES (1, N'Muški')

INSERT [dbo].[Spol] ([SpolId], [Naziv]) VALUES (2, N'Ženski')

INSERT [dbo].[Spol] ([SpolId], [Naziv]) VALUES (3, N'Ostalo')

SET IDENTITY_INSERT [dbo].[Spol] OFF

SET IDENTITY_INSERT [dbo].[Klijent] ON 

INSERT [dbo].[Klijent] ([KlijentId], [SpolId], [Ime], [Prezime], [DatumRodjenja], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (1, 1, N'Marshall', N'Eriksen', CAST(N'1978-01-01' AS Date), N'marshmallow@hotmail.com', N'061/001-000', N'marshmallow', N'wiBMBKZIL6tsB0jtGCoRCmRT080=', N'9eyQRkv+NFWoZRbiVUwZzg==')

INSERT [dbo].[Klijent] ([KlijentId], [SpolId], [Ime], [Prezime], [DatumRodjenja], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (2, 2, N'Lily', N'Aldrin', CAST(N'1978-03-22' AS Date), N'lilypad@hotmail.com', N'061/010-000', N'lilypad', N'h9QKWWSdvAEzd8dwrea2YeASomg=', N'kYXzrFUT8dvKituo+QNnbQ==')

INSERT [dbo].[Klijent] ([KlijentId], [SpolId], [Ime], [Prezime], [DatumRodjenja], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (3, 1, N'Barney', N'Stinson', CAST(N'1976-01-01' AS Date), N'swarley@hotmail.com', N'061/011-000', N'swarley', N'tx9mV5Xnn5bnLekS/sLBx/h/Y+E=', N'1L551vtAGTF0OW4FLoZ/NA==')

INSERT [dbo].[Klijent] ([KlijentId], [SpolId], [Ime], [Prezime], [DatumRodjenja], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (4, 2, N'Robin', N'Scherbatsky', CAST(N'1980-07-23' AS Date), N'sparkles@hotmail.com', N'061/100-000', N'robinSparkles', N'bHQkzpdH+bE/1NV6yaxetvg3nEA=', N'm7DU/TW/NvIq5poLUC3IiQ==')

INSERT [dbo].[Klijent] ([KlijentId], [SpolId], [Ime], [Prezime], [DatumRodjenja], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (5, 1, N'Ted', N'Mosby', CAST(N'1978-04-25' AS Date), N't-mose@hotmail.com', N'061/101-000', N'schmosby', N'mQ9xtEI3VFrAtrztvKHp9H+fY+A=', N'n9chNa53Sf/pKGJsfOAk8g==')

INSERT [dbo].[Klijent] ([KlijentId], [SpolId], [Ime], [Prezime], [DatumRodjenja], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (7, 1, N'Testni', N'Klijent', CAST(N'2000-06-26' AS Date), N'mobile@edu.fit.ba', N'031/123-321', N'mobile', N'rnFGSbqjUTOPWP+6+xVo65A6CRE=', N'tM8ZaCgldR+nc7ChawJ8og==')

INSERT [dbo].[Klijent] ([KlijentId], [SpolId], [Ime], [Prezime], [DatumRodjenja], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (8, 2, N'Edina', N'Kamenjas', CAST(N'1999-08-13' AS Date), N'edina@gmail.com', N'033/456-789', N'edinna2', N'J6MN9JFKO7nyttHu+RmADA+m/EU=', N'Ln7NA0dSPKuwlmvV4JhbMg==')

SET IDENTITY_INSERT [dbo].[Klijent] OFF

SET IDENTITY_INSERT [dbo].[Zanimanje] ON 

INSERT [dbo].[Zanimanje] ([ZanimanjeId], [Naziv]) VALUES (1, N'Piercing artist')

INSERT [dbo].[Zanimanje] ([ZanimanjeId], [Naziv]) VALUES (2, N'Tattoo artist - traditional')

INSERT [dbo].[Zanimanje] ([ZanimanjeId], [Naziv]) VALUES (1002, N'Tattoo artist - neotraditional')

INSERT [dbo].[Zanimanje] ([ZanimanjeId], [Naziv]) VALUES (1003, N'Tattoo artist - watercolor')

INSERT [dbo].[Zanimanje] ([ZanimanjeId], [Naziv]) VALUES (1004, N'Tattoo artist - blackwork')

INSERT [dbo].[Zanimanje] ([ZanimanjeId], [Naziv]) VALUES (1005, N'Tattoo artist - realism / portrait')

INSERT [dbo].[Zanimanje] ([ZanimanjeId], [Naziv]) VALUES (1006, N'Tattoo artist - Japanese')

SET IDENTITY_INSERT [dbo].[Zanimanje] OFF

SET IDENTITY_INSERT [dbo].[Uposlenik] ON 

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (1, 1002, 2, N'Sophie', N'Hatter', N'sophie@gmail.com', N'061/000-001', N'sophie', N'eW/XAZ/W8lBk40ONYTeyD/QEsEw=', N'VLT5DbwMnQuiq2x0r58I5g==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (3, 1002, 1, N'Howl', N'Jenkins', N'howl@gmail.com', N'061/000-010', N'howl', N'eW/XAZ/W8lBk40ONYTeyD/QEsEw=', N'VLT5DbwMnQuiq2x0r58I5g==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (4, 1, 1, N'Ashitaka', N'Leap', N'ashitaka@gmail.com', N'061/000-011', N'ashitaka', N'eW/XAZ/W8lBk40ONYTeyD/QEsEw=', N'VLT5DbwMnQuiq2x0r58I5g==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (5, 2, 2, N'San', N'Mononoke', N'san@gmail.com', N'061/000-100', N'san', N'eW/XAZ/W8lBk40ONYTeyD/QEsEw=', N'VLT5DbwMnQuiq2x0r58I5g==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (7, 1003, 1, N'Nigihayami', N'Kohakunushi', N'haku@gmail.com', N'061/000-101', N'haku', N'eW/XAZ/W8lBk40ONYTeyD/QEsEw=', N'VLT5DbwMnQuiq2x0r58I5g==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (8, 1, 2, N'Chihiro', N'Sen', N'chihiro@gmail.com', N'061/000-110', N'chihiro', N'eW/XAZ/W8lBk40ONYTeyD/QEsEw=', N'VLT5DbwMnQuiq2x0r58I5g==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (1002, 1004, 2, N'Testni', N'Uposlenik', N'desktop@edu.fit.ba', N'031/016-004', N'desktop', N'DsaptxZCKGhqhBWmhC3Jkdh+7PA=', N'BYqTw0kS0w+iAZj1Xys6Sw==', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C677261642E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (1003, 2, 2, N'Emina', N'Fazlić', N'fazlic.emina@hotmail.com', N'061/077-788', N'modra.elegija', N'2F/Agv02J2g9KxuHqAflr/MIMZs=', N'2eqAboKkGver7OSektlTNQ==', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C746D626C2E6A7067)

INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (1006, 1003, 2, N'Azra', N'Kazija', N'kazija.azra@gmail.ba', N'061/112-235', N'_negative_creep_666_', N'eW/XAZ/W8lBk40ONYTeyD/QEsEw=', N'VLT5DbwMnQuiq2x0r58I5g==', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C636869636869726F2E6A7067)

SET IDENTITY_INSERT [dbo].[Uposlenik] OFF

SET IDENTITY_INSERT [dbo].[TipProizvoda] ON 

INSERT [dbo].[TipProizvoda] ([TipProizvodaId], [Naziv]) VALUES (1, N'Nakit za uho')

INSERT [dbo].[TipProizvoda] ([TipProizvodaId], [Naziv]) VALUES (2, N'Proizvodi za čišćenje piercinga')

INSERT [dbo].[TipProizvoda] ([TipProizvodaId], [Naziv]) VALUES (3, N'Proizvodi za njegu tetovaža')

INSERT [dbo].[TipProizvoda] ([TipProizvodaId], [Naziv]) VALUES (1002, N'Nakit za nos')

INSERT [dbo].[TipProizvoda] ([TipProizvodaId], [Naziv]) VALUES (1003, N'Nakit za usnu')

INSERT [dbo].[TipProizvoda] ([TipProizvodaId], [Naziv]) VALUES (1004, N'Nakit za obrvu')

INSERT [dbo].[TipProizvoda] ([TipProizvodaId], [Naziv]) VALUES (1005, N'Nakit za jezik')

SET IDENTITY_INSERT [dbo].[TipProizvoda] OFF

SET IDENTITY_INSERT [dbo].[Proizvod] ON 

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (2, 2, CAST(10.00 AS Decimal(18, 2)), N'Opis proizvoda ovdje.', N'Proizvod 4', 0x433A5C55736572735C757365725C4465736B746F705C696D616765732E706E67)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (4, 2, CAST(15.00 AS Decimal(18, 2)), N'Lorem ipsum dolor sit amet, consectetur', N'Proizvod 5', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303730375F31325F31365F34315F50726F2E6A7067)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (5, 1003, CAST(50.00 AS Decimal(18, 2)), N'Za ovaj komad nakita dostupno je više bo', N'Proizvod 6', 0x433A5C55736572735C757365725C4465736B746F705C696D616765732E706E67)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (6, 1002, CAST(2.00 AS Decimal(18, 2)), N'Na zalihi su veličine od 0.8 mm do 1.6mm', N'Proizvod 1', 0x433A5C55736572735C757365725C4465736B746F705C696D616765732E706E67)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (7, 1005, CAST(2.00 AS Decimal(18, 2)), N'Ček, šta?!', N'Proizvod 2', 0x433A5C55736572735C757365725C4465736B746F705C696D616765732E706E67)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (8, 1, CAST(5.00 AS Decimal(18, 2)), N'Multipurpose. Kuglica 5 mm.', N'Proizvod 3', 0x433A5C55736572735C757365725C4465736B746F705C696D616765732E706E67)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (10, 1, CAST(3.00 AS Decimal(18, 2)), N'Multipurpose nakit od hirurškog čelika.', N'Proizvod 7', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C75322E6A7067)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (11, 1003, CAST(7.00 AS Decimal(18, 2)), N'Dostupno s promjerima od 6 mm do 12 mm.', N'Proizvod 8', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C65332E6A7067)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (12, 1003, CAST(3.00 AS Decimal(18, 2)), N'Multipurpose. Kuglica 5 mm.', N'Proizvod 9', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C75312E6A7067)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (13, 1004, CAST(23.00 AS Decimal(18, 2)), N'Od hirurškog čelika pozlaćen roze zlatom', N'Proizvod 10', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C6F322E6A7067)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (14, 1004, CAST(6.00 AS Decimal(18, 2)), N'Dostupno s promjerima od 6 mm do 12 mm.', N'Proizvod 11', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C6F312E6A7067)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (15, 1005, CAST(3.00 AS Decimal(18, 2)), N'Dostupne različite opcije boja.', N'Proizvod 12', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C6A322E6A7067)

INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (16, 3, CAST(31.00 AS Decimal(18, 2)), N'Umirujući balzam za njegu svježih tetova', N'Proizvod 13', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C74332E6A7067)

SET IDENTITY_INSERT [dbo].[Proizvod] OFF

SET IDENTITY_INSERT [dbo].[TipTermina] ON 

INSERT [dbo].[TipTermina] ([TipTerminaId], [Naziv]) VALUES (1, N'Tattoo appointment')

INSERT [dbo].[TipTermina] ([TipTerminaId], [Naziv]) VALUES (2, N'Piercing appointment')

SET IDENTITY_INSERT [dbo].[TipTermina] OFF

SET IDENTITY_INSERT [dbo].[Termin] ON 

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (1, 1, 1, CAST(N'2022-02-15' AS Date), N'Opis neki', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'test')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (6, 1, 1002, CAST(N'2022-05-27' AS Date), N'asdfghjklqwertzuiop', CAST(230.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'test')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (7, 2, 1002, CAST(N'2022-05-27' AS Date), N'Test', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'OTKAZAN')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (12, 1, 8, CAST(N'2022-09-03' AS Date), N'Ovo bi trebalo da radi.', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'Termin otkazan zbog...')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (13, 1, 3, CAST(N'2022-10-03' AS Date), N'Sta prikazuje?', CAST(0.00 AS Decimal(18, 2)), 2, 0, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (17, 2, 1003, CAST(N'2022-09-15' AS Date), N'Zahtjev', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'Provjera')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (18, 1, 1003, CAST(N'2022-09-16' AS Date), N'Zahtjev 2', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'Test')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (19, 7, 1003, CAST(N'2022-09-17' AS Date), N'Treca sreca', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'Termin otkazan zbog...')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (20, 1, 4, CAST(N'2022-09-21' AS Date), N'Opis', CAST(0.00 AS Decimal(18, 2)), 2, 0, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (21, 8, 1002, CAST(N'2022-10-01' AS Date), N'Moj prvi zahtjev.', CAST(100.00 AS Decimal(18, 2)), 1, 1, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (22, 8, 1002, CAST(N'2022-10-11' AS Date), N'Klijent zeli manju tetovazu na clanku sa cvijetnim motivima...', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (23, 1, 1002, CAST(N'2022-10-02' AS Date), N'Tetovaza dimenzije 15cm sa 10cm na podlaktici', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (24, 2, 1002, CAST(N'2022-10-03' AS Date), N'Full back tattoo', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (25, 3, 1002, CAST(N'2022-09-11' AS Date), N'Horror themed sleeve', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (26, 5, 1002, CAST(N'2022-09-18' AS Date), N'Small lower back butterfly tattoo', CAST(70.00 AS Decimal(18, 2)), 1, 1, 0, 0, N'')

INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (27, 7, 1002, CAST(N'2022-09-15' AS Date), N'Novi zahtjev', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 0, N'')

SET IDENTITY_INSERT [dbo].[Termin] OFF

SET IDENTITY_INSERT [dbo].[Narudzba] ON 

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1009, 7, CAST(N'2022-08-31' AS Date), CAST(27.00 AS Decimal(18, 2)), 1, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1010, 7, CAST(N'2022-08-31' AS Date), CAST(50.00 AS Decimal(18, 2)), 1, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1011, 7, CAST(N'2022-08-31' AS Date), CAST(11.00 AS Decimal(18, 2)), 1, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1012, 7, CAST(N'2022-08-31' AS Date), CAST(7.00 AS Decimal(18, 2)), 1, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1013, 7, CAST(N'2022-08-31' AS Date), CAST(12.00 AS Decimal(18, 2)), 1, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1014, 7, CAST(N'2022-08-31' AS Date), CAST(15.00 AS Decimal(18, 2)), 1, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1015, 2, CAST(N'2022-08-31' AS Date), CAST(2.00 AS Decimal(18, 2)), 1, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1016, 2, CAST(N'2022-08-31' AS Date), CAST(4.00 AS Decimal(18, 2)), 0, 0)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1017, 7, CAST(N'2022-09-01' AS Date), CAST(22.00 AS Decimal(18, 2)), 0, 0)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1018, 8, CAST(N'2022-09-01' AS Date), CAST(87.00 AS Decimal(18, 2)), 0, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1019, 5, CAST(N'2022-09-01' AS Date), CAST(56.00 AS Decimal(18, 2)), 0, 0)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1020, 3, CAST(N'2022-09-01' AS Date), CAST(65.00 AS Decimal(18, 2)), 0, 1)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1021, 1, CAST(N'2022-09-01' AS Date), CAST(85.00 AS Decimal(18, 2)), 0, 0)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1022, 8, CAST(N'2022-09-01' AS Date), CAST(0.00 AS Decimal(18, 2)), 0, 0)

INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (1023, 3, CAST(N'2022-09-01' AS Date), CAST(0.00 AS Decimal(18, 2)), 0, 0)

SET IDENTITY_INSERT [dbo].[Narudzba] OFF

SET IDENTITY_INSERT [dbo].[StavkeNarudzbe] ON 

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (45, 1009, 8, 2)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (46, 1009, 7, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (47, 1009, 4, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (48, 1010, 5, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (49, 1011, 8, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (50, 1011, 6, 3)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (51, 1012, 7, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (52, 1012, 8, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (53, 1013, 8, 2)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (54, 1013, 7, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (55, 1014, 4, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (57, 1015, 6, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (60, 1018, 7, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (61, 1018, 8, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (62, 1018, 5, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (63, 1018, 4, 2)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (64, 1017, 2, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (65, 1017, 8, 2)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (66, 1017, 7, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (67, 1019, 5, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (68, 1019, 7, 2)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (69, 1019, 6, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (70, 1020, 2, 2)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (71, 1020, 4, 3)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (72, 1016, 7, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (73, 1016, 6, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (74, 1021, 4, 2)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (75, 1021, 5, 1)

INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (76, 1021, 8, 1)

SET IDENTITY_INSERT [dbo].[StavkeNarudzbe] OFF

SET IDENTITY_INSERT [dbo].[Izvjestaj] ON 

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (1, 1, CAST(N'2022-02-02' AS Date), N'Do datuma 02/02/2022 16:42:30 ste imali 0 termina, od kojih je 0 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (2, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:14:10 svi uposlenici su imali ukupno 1 termina, od kojih je 0 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (3, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:14:55 Vi ste imali 0 termina, od kojih je 0 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (4, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:18:03 Vi ste imali 0 termina, od kojih je 0 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (5, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:18:08 svi uposlenici su imali ukupno 1 termina, od kojih je 0 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (6, 1002, CAST(N'2022-05-27' AS Date), N'Od početka ovog mjeseca do datuma 27/05/2022 17:14:16 Vi ste imali 1 termina, od kojih je 0 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (7, 1002, CAST(N'2022-05-27' AS Date), N'Od početka ove godine do datuma 27/05/2022 22:12:19 Vi ste imali 2 termina, od kojih je 1 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (8, 1003, CAST(N'2022-08-31' AS Date), N'Od početka ove godine do datuma 08/31/2022 19:12:47 Vi ste imali 3 termina, od kojih je 3 otkazano.')

INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (9, 1003, CAST(N'2022-08-31' AS Date), N'Od početka rada do datuma 08/31/2022 19:13:16 svi uposlenici su imali ukupno 9 termina, od kojih je 7 otkazano.')

SET IDENTITY_INSERT [dbo].[Izvjestaj] OFF

SET IDENTITY_INSERT [dbo].[Obavijest] ON 

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (9, 1, CAST(N'2022-05-27' AS Date), N'Provjera datuma', N'Testiram datum 
Update radiii')

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (10, 1, CAST(N'2022-05-27' AS Date), N'Test', N'Pažnja pažnja obavještavamo vas da...')

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (11, 1, CAST(N'2022-05-27' AS Date), N'Lorem ipsum', N'Tekst obavijesti')

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (12, 1003, CAST(N'2022-07-06' AS Date), N'Obavijest1', N'Tekst obavijesti')

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (14, 1003, CAST(N'2022-08-31' AS Date), N'Debugging', N'Let''s debug. All okay!')

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (15, 1003, CAST(N'2022-08-31' AS Date), N'Obavijest2', N'Okej, sve radi.')

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (16, 1002, CAST(N'2022-09-01' AS Date), N'Godišnji odmor', N'Poštovani, obavještavamo vas da studio neće raditi od 01.09. do 14.09. zbog kolektivnog godišnjeg odmora.')

INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (17, 1002, CAST(N'2022-09-01' AS Date), N'Walk-in day', N'16.09. u našem studiju će se održati walk in day. Klijenti mogu doći bez zakazanog termina.')

SET IDENTITY_INSERT [dbo].[Obavijest] OFF

SET IDENTITY_INSERT [dbo].[Portfolio] ON 

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (1, N'Lorem ipsum portfolio opis', 1)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (2, N'Samo da provjerim neštoo', 3)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (5, N'Portfolio ovog korisnika.', 1002)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (6, N'Dobrodošli! Ovo je moj portfolio.', 1003)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (13, N'Nadam se da radi :)', 1006)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (14, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut', 4)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (15, N'Uposlenik radi pretezno custom made dizajne s fokusom na cvijetnim i prirodnim motivima...', 5)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (16, N'*opis rada ovdje*', 7)

INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (17, N'Portfolio opis uposlenik tetovira pretezno xyz', 8)

SET IDENTITY_INSERT [dbo].[Portfolio] OFF

SET IDENTITY_INSERT [dbo].[StavkePortfolia] ON 

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (4, 2, CAST(N'2022-05-25' AS Date), N'Asd', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (5, 2, CAST(N'2022-05-03' AS Date), N'Fgh', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35395F50726F2E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (7, 5, CAST(N'2022-05-04' AS Date), N'Custom made design po klijentovoj narudžbi.', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C312E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (8, 5, CAST(N'2022-05-26' AS Date), N'Stavka testiranje id-ja', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C322E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (10, 5, CAST(N'2022-05-26' AS Date), N'Ovo je dodano kroz swagger.', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C332E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (11, 5, CAST(N'2022-04-04' AS Date), N'Test test', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C342E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (12, 5, CAST(N'2022-08-30' AS Date), N'Sazviježđe kasiopeja <3', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C352E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (13, 6, CAST(N'2022-07-21' AS Date), N'Hajde da actually debugiramo ovo.', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C31302E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (14, 13, CAST(N'2022-08-31' AS Date), N'Tattoo flash', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C362E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (15, 13, CAST(N'2022-08-30' AS Date), N'Sketch rađen po želji klijenta', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C372E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (16, 13, CAST(N'2022-08-29' AS Date), N'Free-handed tattoo', 0x433A5C55736572735C757365725C4465736B746F705C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C382E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (17, 13, CAST(N'2022-08-11' AS Date), N'Fully healed', 0x2E5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C392E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (19, 13, CAST(N'2022-08-05' AS Date), N'Opis', 0x5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C5253322D73656D696E6172736B692D746174746F6F73747564696F5C777777726F6F745C696D616765735C31302E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (20, 1, CAST(N'2022-06-17' AS Date), N'Custom made design...', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C312E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (21, 14, CAST(N'2022-06-18' AS Date), N'Opis stavke ovdje', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C322E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (22, 15, CAST(N'2022-06-19' AS Date), N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C332E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (23, 16, CAST(N'2022-06-20' AS Date), N'Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C342E6A7067)

INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (24, 17, CAST(N'2022-06-21' AS Date), N'Opis tetovaže ovdje...', 0x433A5C55736572735C757365725C4465736B746F705C696D616765735C392E6A7067)

SET IDENTITY_INSERT [dbo].[StavkePortfolia] OFF