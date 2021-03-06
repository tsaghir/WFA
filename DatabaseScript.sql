USE [16049_DB]
GO
SET IDENTITY_INSERT [dbo].[sifra_zdrv_ustanove] ON 

INSERT [dbo].[sifra_zdrv_ustanove] ([sifra_zdrv_ustanoveID], [naziv], [mjesto], [ulica], [telefon]) VALUES (1, N'Ambulanta1', N'Varaždin', N'Pavlinska 42', N'895-656')
INSERT [dbo].[sifra_zdrv_ustanove] ([sifra_zdrv_ustanoveID], [naziv], [mjesto], [ulica], [telefon]) VALUES (2, N'Ambulanta Sv. Duh', N'Zagreb', N'Varaždinska 34', N'099-343')
INSERT [dbo].[sifra_zdrv_ustanove] ([sifra_zdrv_ustanoveID], [naziv], [mjesto], [ulica], [telefon]) VALUES (3, N'Amb. Čakovec', N'Čakovec', N'Ivana pl. Zajca 3', N'345-344')
INSERT [dbo].[sifra_zdrv_ustanove] ([sifra_zdrv_ustanoveID], [naziv], [mjesto], [ulica], [telefon]) VALUES (4, N'Amb. Varaždin', N'Varaždin', N'Jurja Križanića 33', N'343-323')
SET IDENTITY_INSERT [dbo].[sifra_zdrv_ustanove] OFF
SET IDENTITY_INSERT [dbo].[lijekovi] ON 

INSERT [dbo].[lijekovi] ([lijekoviID], [naziv], [datum_vrijeme_kontrole], [kolicina], [rok_trajanja], [cijena], [sifra_zdrv_ustanoveID]) VALUES (1, N'Penicilin', CAST(N'2016-09-27 00:00:00.000' AS DateTime), 2, CAST(N'2016-05-20' AS Date), 250.0000, 1)
INSERT [dbo].[lijekovi] ([lijekoviID], [naziv], [datum_vrijeme_kontrole], [kolicina], [rok_trajanja], [cijena], [sifra_zdrv_ustanoveID]) VALUES (2, N'Sebamed', CAST(N'2016-08-28 00:00:00.000' AS DateTime), 3, CAST(N'2016-05-29' AS Date), 23.0000, 1)
INSERT [dbo].[lijekovi] ([lijekoviID], [naziv], [datum_vrijeme_kontrole], [kolicina], [rok_trajanja], [cijena], [sifra_zdrv_ustanoveID]) VALUES (4, N'Aspirin', CAST(N'2016-06-19 00:00:00.000' AS DateTime), 10, CAST(N'2017-06-19' AS Date), 75.0000, 1)
INSERT [dbo].[lijekovi] ([lijekoviID], [naziv], [datum_vrijeme_kontrole], [kolicina], [rok_trajanja], [cijena], [sifra_zdrv_ustanoveID]) VALUES (5, N'Neofen', CAST(N'2016-06-19 00:00:00.000' AS DateTime), 16, CAST(N'2019-06-19' AS Date), 65.0000, 1)
INSERT [dbo].[lijekovi] ([lijekoviID], [naziv], [datum_vrijeme_kontrole], [kolicina], [rok_trajanja], [cijena], [sifra_zdrv_ustanoveID]) VALUES (15, N'Mynoxidil', CAST(N'2016-06-21 00:00:00.000' AS DateTime), 2, CAST(N'2019-06-21' AS Date), 2.0000, 1)
INSERT [dbo].[lijekovi] ([lijekoviID], [naziv], [datum_vrijeme_kontrole], [kolicina], [rok_trajanja], [cijena], [sifra_zdrv_ustanoveID]) VALUES (16, N'Penicilin', CAST(N'2016-06-21 00:00:00.000' AS DateTime), 15, CAST(N'2020-06-21' AS Date), 25.0000, 1)
SET IDENTITY_INSERT [dbo].[lijekovi] OFF
SET IDENTITY_INSERT [dbo].[pacijenti] ON 

INSERT [dbo].[pacijenti] ([pacijentiID], [MBO], [OIB], [ime], [prezime], [spol], [mjesto], [adresa], [drzava], [telefon], [mobitel], [email], [sifra_zdrv_ustanoveID]) VALUES (1, 565455455, 54556556, N'Ana', N'Anić', N'Ž', N'Čakovec', N'Ivana pl. Zajca', N'Hrvatska', N'098665336', N'098988999', N'ana@email.hr', 1)
INSERT [dbo].[pacijenti] ([pacijentiID], [MBO], [OIB], [ime], [prezime], [spol], [mjesto], [adresa], [drzava], [telefon], [mobitel], [email], [sifra_zdrv_ustanoveID]) VALUES (2, 454354353, 34233443, N'Marko', N'Marić', N'M', N'Čakovec', N'Vukovarska 3', N'Hrvatska ', N'098343453', N'099343433', N'marko@email.hr', 1)
INSERT [dbo].[pacijenti] ([pacijentiID], [MBO], [OIB], [ime], [prezime], [spol], [mjesto], [adresa], [drzava], [telefon], [mobitel], [email], [sifra_zdrv_ustanoveID]) VALUES (3, 394548549, 38953853, N'Ivan', N'Ivanić', N'M', N'Ivanec', N'Ivanečka 35', N'Hrvatska ', N'090343342', N'098343433', N'ivan@email.hr', 1)
INSERT [dbo].[pacijenti] ([pacijentiID], [MBO], [OIB], [ime], [prezime], [spol], [mjesto], [adresa], [drzava], [telefon], [mobitel], [email], [sifra_zdrv_ustanoveID]) VALUES (4, 934945353, 39448343, N'Petar', N'Panjkota', N'M', N'Zagreb', N'Zagrebačka 45', N'Hrvatska', N'099343483', N'099834493', N'panjkec@email.hr', 1)
INSERT [dbo].[pacijenti] ([pacijentiID], [MBO], [OIB], [ime], [prezime], [spol], [mjesto], [adresa], [drzava], [telefon], [mobitel], [email], [sifra_zdrv_ustanoveID]) VALUES (7, 24214214, 421421, N'Klara', N'Marićić', N'Ž', N'Varaždin', N'Gortanova 23', N'Hrvatska', N'0992543431', N'0992543431', N'klara.maric@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[pacijenti] OFF
SET IDENTITY_INSERT [dbo].[djelatnici] ON 

INSERT [dbo].[djelatnici] ([djelatniciID], [sifra_zdrv_ustanoveID], [OIB], [ime], [prezime], [mjesto], [ulica], [titula], [telefon], [mobitel], [email], [sifra]) VALUES (2, 1, 555622542, N'Ana', N'Anić', N'Varaždin', N'Pavlinska 2', N'med. sestra', N'899-996', N'098-9985-959', N'amb1@email.hr', N'1234')
INSERT [dbo].[djelatnici] ([djelatniciID], [sifra_zdrv_ustanoveID], [OIB], [ime], [prezime], [mjesto], [ulica], [titula], [telefon], [mobitel], [email], [sifra]) VALUES (4, 1, 123456789, N'Mirko', N'Bogdanović', N'Zagreb', N'Vukovarska 1', N'dr. med.', N'123-1234', N'091-111-1234', N'mirko@gmail.com', N'1234')
INSERT [dbo].[djelatnici] ([djelatniciID], [sifra_zdrv_ustanoveID], [OIB], [ime], [prezime], [mjesto], [ulica], [titula], [telefon], [mobitel], [email], [sifra]) VALUES (5, 2, 568615263, N'Marko', N'Marić', N'Čakovec', N'Piškorovečka 22', N'dr.med.', N'445-898', N'098-885-9658', N'marko@mail.hr', N'1234')
SET IDENTITY_INSERT [dbo].[djelatnici] OFF
SET IDENTITY_INSERT [dbo].[recepti] ON 

INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (1, N'Hitno', 2, 5, N'4555cc', 0, 2, 2, 1)
INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (2, N'sdgg', 1, 4, N'56cc', 1, 3, 2, 1)
INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (3, N'fsdf', 2, 2, N'dsfs', 0, 2, 2, 1)
INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (4, N'Hitno', 2, 2, N'350cc', 1, 3, 2, 1)
INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (16, N'wef', NULL, 3, N'ewf', 1, NULL, 4, 1)
INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (18, N'Hitno!', 15, 3, N'45cc', 0, 2, 4, 1)
INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (19, N'ert', 5, 4, N'ret', 0, 2, 2, 1)
INSERT [dbo].[recepti] ([receptID], [slucaj], [lijekoviID], [kolicina], [doziranje], [nadoplata], [pacijentiID], [djelatniciID], [sifra_zdrv_ustanoveID]) VALUES (20, N'erze', 2, 3, N'rz', 1, 2, 2, 3)
SET IDENTITY_INSERT [dbo].[recepti] OFF
SET IDENTITY_INSERT [dbo].[cijepljenje] ON 

INSERT [dbo].[cijepljenje] ([cijepljenjeID], [slucaj], [datume], [vrsta_cijepljenja], [prirava_cjepiva], [broj_doze], [kolicina], [djelatniciID], [pacijentiID]) VALUES (1, N'Hitno', CAST(N'2016-07-05' AS Date), N'Gripa', N'356mg', N'34cc', 1, 2, 1)
INSERT [dbo].[cijepljenje] ([cijepljenjeID], [slucaj], [datume], [vrsta_cijepljenja], [prirava_cjepiva], [broj_doze], [kolicina], [djelatniciID], [pacijentiID]) VALUES (2, N'Hitno', CAST(N'2016-06-18' AS Date), N'za tetanus', N'2mgCL,3mgPH', N'14', 1, 2, 4)
SET IDENTITY_INSERT [dbo].[cijepljenje] OFF
SET IDENTITY_INSERT [dbo].[postupci] ON 

INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (1, CAST(N'2016-03-05' AS Date), 2, N'Abdomen bolovi', N'Lječenje', N'bolovi u abdomenalnom području', N'Aspirin, 2 kutije dnevno', N'mirovanje', 1)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (5, CAST(N'2016-06-19' AS Date), 2, N'q', N'q', N'q', N'q', N'q', NULL)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (6, CAST(N'2016-06-19' AS Date), 2, N'q', N'q', N'q', N'q', N'q', NULL)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (7, CAST(N'2016-06-19' AS Date), 2, N'q', N'q', N'q', N'q', N'q', NULL)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (8, CAST(N'2016-06-19' AS Date), 2, N'q', N'q', N'q', N'q', N'q', NULL)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (9, CAST(N'2016-06-19' AS Date), 2, N'q', N'q', N'q', N'q', N'q', NULL)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (10, CAST(N'2016-06-19' AS Date), 2, N'q', N'q', N'q', N'q', N'q', NULL)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (11, CAST(N'2016-06-19' AS Date), 2, N'qQ', N'qq', N'q', N'q', N'q', 1)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (12, CAST(N'2016-06-19' AS Date), 2, N'ww', N'ww', N'ww', N'ww', N'ww', 1)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (13, CAST(N'2016-06-19' AS Date), 2, N'f', N'f', N'f', N'f', N'f', 1)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (14, CAST(N'2016-06-22' AS Date), 2, N'test', N'test', N'test', N'test', N'test', 3)
INSERT [dbo].[postupci] ([postupciID], [datum], [ljecnikID], [anamneza], [status], [dijagnoza], [terapija], [preporuka], [pacijentiID]) VALUES (15, CAST(N'2016-06-23' AS Date), 2, N'Kašalj', N'.', N'Suhi kašalj', N'Čaj od kamilice', N'Mirovanje', 1)
SET IDENTITY_INSERT [dbo].[postupci] OFF
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (0, CAST(N'2016-06-18' AS Date), NULL, 1, 2, N'radi')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (1, CAST(N'2016-02-04' AS Date), CAST(N'22:55:00' AS Time), 1, 1, N'HAHAHAH')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (3, CAST(N'2016-06-18' AS Date), NULL, 1, 1, N'ad')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (4, CAST(N'2016-06-18' AS Date), NULL, 1, 1, N'21')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (5, CAST(N'2016-06-18' AS Date), NULL, 1, 1, N'ae')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (6, CAST(N'2016-06-18' AS Date), NULL, 1, 1, N'')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (7, CAST(N'2016-06-18' AS Date), NULL, 1, 1, N'')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (8, CAST(N'2016-06-18' AS Date), NULL, 1, 1, N'fff')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (9, CAST(N'2016-06-19' AS Date), NULL, 1, 1, N'bolovi')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (10, CAST(N'2016-06-19' AS Date), NULL, 1, 1, N'test2')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (11, CAST(N'2016-06-19' AS Date), CAST(N'15:15:15' AS Time), 1, 1, N'15')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (12, CAST(N'2016-06-19' AS Date), CAST(N'00:00:00' AS Time), 1, 1, N'test5')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (13, CAST(N'2016-06-19' AS Date), CAST(N'00:00:00' AS Time), 1, 4, N'ff')
INSERT [dbo].[raspored] ([rasporedID], [datum], [vrijeme], [sifra_zdrv_ustanoveID], [pacijentiID], [opis]) VALUES (14, CAST(N'2016-06-20' AS Date), CAST(N'00:00:00' AS Time), 1, 1, N'rr')
SET IDENTITY_INSERT [dbo].[uputnica] ON 

INSERT [dbo].[uputnica] ([uputnicaID], [pacijentID], [sifra_zdrv_ustanoveID], [upucuje_se], [dijagnoza], [trazi_se], [napomena], [datum], [djelatniciID]) VALUES (2, 2, 1, N'Pacijentu na intenzivnoj njezi', N'Slomljeni kuk', N'Dr. Pavić', N'Iznimni bolovi', CAST(N'2016-06-06' AS Date), 2)
INSERT [dbo].[uputnica] ([uputnicaID], [pacijentID], [sifra_zdrv_ustanoveID], [upucuje_se], [dijagnoza], [trazi_se], [napomena], [datum], [djelatniciID]) VALUES (3, NULL, 1, N'Pacijentu', N'Abdomen bolovi', N'Dr. Muskolo', N'Bolovi', CAST(N'2016-04-05' AS Date), 2)
INSERT [dbo].[uputnica] ([uputnicaID], [pacijentID], [sifra_zdrv_ustanoveID], [upucuje_se], [dijagnoza], [trazi_se], [napomena], [datum], [djelatniciID]) VALUES (7, 7, 1, N'Na bioskopiju', N'Teški bolovi', N'Postupak bioskopije', N'Nema', CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[uputnica] ([uputnicaID], [pacijentID], [sifra_zdrv_ustanoveID], [upucuje_se], [dijagnoza], [trazi_se], [napomena], [datum], [djelatniciID]) VALUES (8, 2, 1, N'Na patologiju', N'Smrt', N'Obdukcija', N'Brzo', CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[uputnica] ([uputnicaID], [pacijentID], [sifra_zdrv_ustanoveID], [upucuje_se], [dijagnoza], [trazi_se], [napomena], [datum], [djelatniciID]) VALUES (9, 3, 1, N'Na rengen', N'Bolovi u nozi', N'Pregled', N'Hitno', CAST(N'2016-06-24' AS Date), 2)
INSERT [dbo].[uputnica] ([uputnicaID], [pacijentID], [sifra_zdrv_ustanoveID], [upucuje_se], [dijagnoza], [trazi_se], [napomena], [datum], [djelatniciID]) VALUES (11, NULL, NULL, N'qqqq', N'Test11', N'Test11', N'Test11', CAST(N'2016-06-16' AS Date), NULL)
INSERT [dbo].[uputnica] ([uputnicaID], [pacijentID], [sifra_zdrv_ustanoveID], [upucuje_se], [dijagnoza], [trazi_se], [napomena], [datum], [djelatniciID]) VALUES (14, 4, 1, N'dr.Nemecu', N'alergijska reakcija', N'strucčno mišeljenje', N'hitno', CAST(N'2016-06-19' AS Date), 2)
SET IDENTITY_INSERT [dbo].[uputnica] OFF
SET IDENTITY_INSERT [dbo].[potvrde] ON 

INSERT [dbo].[potvrde] ([potvrdeID], [svrha], [opis], [datum], [djelatniciID], [pacijentiID]) VALUES (2, N'Ispričnica', N'Ispričava se pacijent radi bolesti', CAST(N'2017-06-21' AS Date), 2, 1)
INSERT [dbo].[potvrde] ([potvrdeID], [svrha], [opis], [datum], [djelatniciID], [pacijentiID]) VALUES (13, N'Polaganje vozačkog ispita', N'Pacijent je zdrav', CAST(N'2016-06-21' AS Date), 2, 1)
SET IDENTITY_INSERT [dbo].[potvrde] OFF
INSERT [dbo].[evidencija_hospitalizacije] ([evidencija_hospitalizacijeID], [boravio_od_datuma], [boravio_do_datuma], [naziv_bolnice], [razlog], [pacijentiID]) VALUES (N'13        ', CAST(N'2016-06-21' AS Date), CAST(N'2016-06-23' AS Date), N'Traumatologijaa', N'Ozljede na radu', 1)
INSERT [dbo].[evidencija_hospitalizacije] ([evidencija_hospitalizacijeID], [boravio_od_datuma], [boravio_do_datuma], [naziv_bolnice], [razlog], [pacijentiID]) VALUES (N'16        ', CAST(N'2016-06-22' AS Date), CAST(N'2016-06-22' AS Date), N'Rebro', N'Pregled pluća', 1)
INSERT [dbo].[evidencija_hospitalizacije] ([evidencija_hospitalizacijeID], [boravio_od_datuma], [boravio_do_datuma], [naziv_bolnice], [razlog], [pacijentiID]) VALUES (N'2         ', CAST(N'2016-05-04' AS Date), CAST(N'2016-06-20' AS Date), N'Sv. Marija', N'Noga', 1)
INSERT [dbo].[evidencija_hospitalizacije] ([evidencija_hospitalizacijeID], [boravio_od_datuma], [boravio_do_datuma], [naziv_bolnice], [razlog], [pacijentiID]) VALUES (N'3         ', CAST(N'2016-06-19' AS Date), CAST(N'2016-06-19' AS Date), N'Markovićeva5', N'Marko', 2)
INSERT [dbo].[evidencija_hospitalizacije] ([evidencija_hospitalizacijeID], [boravio_od_datuma], [boravio_do_datuma], [naziv_bolnice], [razlog], [pacijentiID]) VALUES (N'4         ', CAST(N'2016-06-19' AS Date), CAST(N'2016-06-19' AS Date), N'ff', N'ff', NULL)
INSERT [dbo].[evidencija_hospitalizacije] ([evidencija_hospitalizacijeID], [boravio_od_datuma], [boravio_do_datuma], [naziv_bolnice], [razlog], [pacijentiID]) VALUES (N'5         ', CAST(N'2016-06-19' AS Date), CAST(N'2016-06-19' AS Date), N'ff', N'ff', NULL)
INSERT [dbo].[evidencija_hospitalizacije] ([evidencija_hospitalizacijeID], [boravio_od_datuma], [boravio_do_datuma], [naziv_bolnice], [razlog], [pacijentiID]) VALUES (N'6         ', CAST(N'2016-06-19' AS Date), CAST(N'2016-06-20' AS Date), N'Hitna', N'Ozljede na radu', 7)
