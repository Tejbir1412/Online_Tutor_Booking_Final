INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0a030c5f-8609-4cda-bc7f-343463182175', N'student', N'student', N'49346f11-93b4-44ff-b328-fef524c94ed7')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'354adc5b-350e-46b1-899a-f92a422eee13', N'tutor_admin', N'tutor_admin', N'12a1d927-770e-4646-9bba-bf9625ccaae8')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'14212c96-61e9-4c18-af42-4a03b7b5d485', N'james@gmail.com', N'JAMES@GMAIL.COM', N'james@gmail.com', N'JAMES@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEKDldhzDrZ/L+tOAuqjQKtDd5+NX3L2IFH+uVCDGPF1IGakNTeooN2iaCQeI/UX0ww==', N'OGCWCGSEXJZQUOO26ZSJUMSSB4ATUTVH', N'20164479-4d81-483e-8c94-970fd5087cd8', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c95df686-71bd-42fe-b863-49b9151cbc51', N'pamela@gmail.com', N'PAMELA@GMAIL.COM', N'pamela@gmail.com', N'PAMELA@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDxtevZIfK8ZpYZ8Lw33rTclt9jPBAdvEDbxP9TiMxp1yhgG5aUUqU8fsIoZTRJa4Q==', N'WRPTFAWHYNWQ2NARONRJK6TTT6636CTJ', N'327bc3c2-ed78-4b4c-83fb-01aff39ede89', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f0dcf6cc-1b06-48c3-a24c-41b8d3bf7d19', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDLNo4zxJeVjRf17zK1vhkbc6YjZ9Qi1ICdE6xx9Lm1nxMU2SGqMc+n7gOjbUKNQbA==', N'34MGIZOA77BZKTANRZTZDQFVTCT6QLXF', N'a4debfc8-c37b-4bd1-b988-ceb9e70797da', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'14212c96-61e9-4c18-af42-4a03b7b5d485', N'0a030c5f-8609-4cda-bc7f-343463182175')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c95df686-71bd-42fe-b863-49b9151cbc51', N'0a030c5f-8609-4cda-bc7f-343463182175')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f0dcf6cc-1b06-48c3-a24c-41b8d3bf7d19', N'354adc5b-350e-46b1-899a-f92a422eee13')
SET IDENTITY_INSERT [dbo].[Tutor] ON
INSERT INTO [dbo].[Tutor] ([Id], [Name], [MobileNumber], [Email]) VALUES (1, N'Jack Pence', N'0218886542', N'jackpence@gmail.com')
INSERT INTO [dbo].[Tutor] ([Id], [Name], [MobileNumber], [Email]) VALUES (2, N'Ethan Gray', N'021888823456', N'ethan@gmail.com')
SET IDENTITY_INSERT [dbo].[Tutor] OFF
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([Id], [Name], [Email]) VALUES (1, N'James Fox', N'james@gmail.com')
INSERT INTO [dbo].[Student] ([Id], [Name], [Email]) VALUES (2, N'Pamela Parker', N'pamela@gmail.com')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[BookingRequest] ON
INSERT INTO [dbo].[BookingRequest] ([Id], [StudentId], [TutorId], [BookingDate]) VALUES (1, 1, 1, N'2020-01-23 00:00:00')
INSERT INTO [dbo].[BookingRequest] ([Id], [StudentId], [TutorId], [BookingDate]) VALUES (2, 1, 2, N'2020-01-30 00:00:00')
INSERT INTO [dbo].[BookingRequest] ([Id], [StudentId], [TutorId], [BookingDate]) VALUES (3, 2, 1, N'2020-01-28 00:00:00')
INSERT INTO [dbo].[BookingRequest] ([Id], [StudentId], [TutorId], [BookingDate]) VALUES (4, 2, 2, N'2020-01-23 00:00:00')
SET IDENTITY_INSERT [dbo].[BookingRequest] OFF
