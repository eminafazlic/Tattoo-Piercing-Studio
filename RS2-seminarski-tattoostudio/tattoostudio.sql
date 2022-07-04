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
 
INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (1, 1002, 2, N'Sophie', N'Hatter', N'sophie@gmail.com', N'061/000-001', N'sophie', N'1SYVXw1e2PVZGmwpyOMGptzztdw=', N'SQIaHfXUDzf8CCffEC0sLg==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)
 
INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (3, 1002, 1, N'Howl', N'Jenkins', N'howl@gmail.com', N'061/000-010', N'howl', N'4Rliw+o5wE8jly6tZrgjIRfx0WY=', N'4Q+7xMKimv8g/qKIs7nvcA==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)
 
INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (4, 1, 1, N'Ashitaka', N'Leap', N'ashitaka@gmail.com', N'061/000-011', N'ashitaka', N'KtNzWZ4wn471WfAyV+RAujoabII=', N'W30vybXEUCBL4IekOf/JMA==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)
 
INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (5, 2, 2, N'San', N'Mononoke', N'san@gmail.com', N'061/000-100', N'san', N'lJMih1m35uDeDruCKVgfMzvszNA=', N'QJFSXnebhAPATpL8uzis6g==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)
 
INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (7, 1003, 1, N'Nigihayami', N'Kohakunushi', N'haku@gmail.com', N'061/000-101', N'haku', N'GU2Ob43rTaMiqMUIvATMP0wnZ/E=', N'nfP0jNhUllPbeXBHfNnkHg==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)
 
INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (8, 1, 2, N'Chihiro', N'Sen', N'chihiro@gmail.com', N'061/000-110', N'chihiro', N'db5UBM0TUN/Ie8Ce9z68WJ9Fcoc=', N'C81JkIRkXB9Fm50eujprvg==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)
 
INSERT [dbo].[Uposlenik] ([UposlenikId], [ZanimanjeId], [SpolId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt], [Slika]) VALUES (1002, 1005, 2, N'asd', N'fgh', N'asf@gmail.com', N'033/411-520', N'asd', N'U091AUpr77L/m7VVVZJSKXCYtqg=', N'cT16zd8tVthpmMKkd7WBPQ==', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303730375F31325F31365F34315F50726F2E6A7067)
 
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
 
INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (1, 1, CAST(15.00 AS Decimal(18, 2)), N'molim te radi', N'Testna naušnica', 0x)
 
INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (2, 2, CAST(10.00 AS Decimal(18, 2)), N'Ja sad kao opisujem neki proizvod ovdje', N'Naziv naziv', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303730375F31325F31365F34315F50726F2E6A7067)
 
INSERT [dbo].[Proizvod] ([ProizvodId], [TipProizvodaId], [Cijena], [Opis], [Naziv], [Slika]) VALUES (4, 2, CAST(15.00 AS Decimal(18, 2)), N'aajdeeeee', N'I šta ćemo sad', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303730375F31325F31365F34315F50726F2E6A7067)
 
SET IDENTITY_INSERT [dbo].[Proizvod] OFF
 
SET IDENTITY_INSERT [dbo].[TipTermina] ON 
 
INSERT [dbo].[TipTermina] ([TipTerminaId], [Naziv]) VALUES (1, N'Tattoo appointment')
 
INSERT [dbo].[TipTermina] ([TipTerminaId], [Naziv]) VALUES (2, N'Piercing appointment')
 
SET IDENTITY_INSERT [dbo].[TipTermina] OFF
 
SET IDENTITY_INSERT [dbo].[Termin] ON 
 
INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (1, 1, 1, CAST(N'2022-02-15' AS Date), N'opis opis neki', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 0, N'test')
 
INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (6, 1, 1002, CAST(N'2022-05-27' AS Date), N'swggggadfsdgfggdfhfgsasdfghkjajaj', CAST(230.00 AS Decimal(18, 2)), 1, 1, 0, 0, N'test')
 
INSERT [dbo].[Termin] ([TerminId], [KlijentId], [UposlenikId], [Datum], [Opis], [Cijena], [TipTerminaId], [IsOdobren], [IsPlacen], [IsOtkazan], [Komentar]) VALUES (7, 2, 1002, CAST(N'2022-05-27' AS Date), N'test test trrr', CAST(0.00 AS Decimal(18, 2)), 1, 0, 0, 1, N'OTKAZAN')
 
SET IDENTITY_INSERT [dbo].[Termin] OFF
 
SET IDENTITY_INSERT [dbo].[Narudzba] ON 
 
INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (4, 2, CAST(N'2022-05-27' AS Date), CAST(20.00 AS Decimal(18, 2)), 0, 0)
 
INSERT [dbo].[Narudzba] ([NarudzbaId], [KlijentId], [Datum], [UkupniIznos], [IsIsporucena], [IsPlacena]) VALUES (5, 2, CAST(N'2022-05-27' AS Date), CAST(20.00 AS Decimal(18, 2)), 1, 0)
 
SET IDENTITY_INSERT [dbo].[Narudzba] OFF
 
SET IDENTITY_INSERT [dbo].[StavkeNarudzbe] ON 
 
INSERT [dbo].[StavkeNarudzbe] ([StavkeNarudzbeId], [NarudzbaId], [ProizvodId], [Kolicina]) VALUES (1, 4, 1, 2)
 
SET IDENTITY_INSERT [dbo].[StavkeNarudzbe] OFF
 
SET IDENTITY_INSERT [dbo].[Izvjestaj] ON 
 
INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (1, 1, CAST(N'2022-02-02' AS Date), N'Do datuma 02/02/2022 16:42:30 ste imali 0 termina, od kojih je 0 otkazano.')
 
INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (2, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:14:10 svi uposlenici su imali ukupno 1 termina, od kojih je 0 otkazano.')
 
INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (3, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:14:55 Vi ste imali 0 termina, od kojih je 0 otkazano.')
 
INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (4, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:18:03 Vi ste imali 0 termina, od kojih je 0 otkazano.')
 
INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (5, 1002, CAST(N'2022-05-27' AS Date), N'Od početka rada do datuma 27/05/2022 12:18:08 svi uposlenici su imali ukupno 1 termina, od kojih je 0 otkazano.')
 
INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (6, 1002, CAST(N'2022-05-27' AS Date), N'Od početka ovog mjeseca do datuma 27/05/2022 17:14:16 Vi ste imali 1 termina, od kojih je 0 otkazano.')
 
INSERT [dbo].[Izvjestaj] ([IzvjestajId], [UposlenikId], [Datum], [Detalji]) VALUES (7, 1002, CAST(N'2022-05-27' AS Date), N'Od početka ove godine do datuma 27/05/2022 22:12:19 Vi ste imali 2 termina, od kojih je 1 otkazano.')
 
SET IDENTITY_INSERT [dbo].[Izvjestaj] OFF
 
SET IDENTITY_INSERT [dbo].[Obavijest] ON 
 
INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (9, 1002, CAST(N'2022-05-27' AS Date), N'Datum', N'Obavještavam vas da samo želim testirati radi li mi sad datum hehehe
Update radiii')
 
INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (10, 1002, CAST(N'2022-05-27' AS Date), N'Test', N'Pažnja pažnja obavještavam vas da radim RS2 heheheh')
 
INSERT [dbo].[Obavijest] ([ObavijestId], [UposlenikId], [Datum], [Naslov], [Sadrzaj]) VALUES (11, 1002, CAST(N'2022-05-27' AS Date), N'ttrla', N'zaobilazimo prepreke hehehe')
 
SET IDENTITY_INSERT [dbo].[Obavijest] OFF
 
SET IDENTITY_INSERT [dbo].[Portfolio] ON 
 
INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (1, N'Lorem ipsum portfolio opis', 1)
 
INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (2, N'Samo da provjerim neštoo', 3)
 
INSERT [dbo].[Portfolio] ([PortfolioId], [Opis], [UposlenikId]) VALUES (5, N'Dobro došli u moj portfolio. Ovdje možete vidjeti šta ja radim. Nadam se da će vam se svidjeti.', 1002)
 
SET IDENTITY_INSERT [dbo].[Portfolio] OFF
 
SET IDENTITY_INSERT [dbo].[StavkePortfolia] ON 
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (1, 1, CAST(N'2022-02-03' AS Date), N'testna slika nešto', 0x)
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (2, 2, CAST(N'2022-05-26' AS Date), N'ne znam nesto', 0x)
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (4, 2, CAST(N'2022-05-25' AS Date), N'trrrrrr', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35365F50726F2E6A7067)
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (5, 2, CAST(N'2022-05-03' AS Date), N'ffdg', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35395F50726F2E6A7067)
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (7, 5, CAST(N'2022-05-04' AS Date), N'Custom made design :)', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303131355F32305F30365F35395F50726F2E6A7067)
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (8, 5, CAST(N'2022-05-26' AS Date), N'Stavka da testiram id IZGLEDA DA SAD RADI HVALA BOGU', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303131355F31385F34345F34345F50726F2E6A7067)
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (10, 5, CAST(N'2022-05-26' AS Date), N'KROZ SWAGGER a editujem u desktop app edit', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303131355F31385F34345F34345F50726F2E6A7067)
 
INSERT [dbo].[StavkePortfolia] ([StavkaPortfoliaId], [PortfolioId], [Datum], [Opis], [Slika]) VALUES (11, 5, CAST(N'2022-04-04' AS Date), N'testichhh moj dijagram aktivnosti <3', 0x433A5C55736572735C757365725C50696374757265735C43616D65726120526F6C6C5C57494E5F32303231303231315F31365F34355F35395F50726F2E6A7067)
 
SET IDENTITY_INSERT [dbo].[StavkePortfolia] OFF
