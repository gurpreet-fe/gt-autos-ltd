SET IDENTITY_INSERT [dbo].[tblCustomer] ON
INSERT INTO [dbo].[tblCustomer] ([CustomerID], [CustomerFirstName], [CustomerLastName], [PhoneNumber], [Address], [EmailAddress], [Password], [Postcode], [DateOfBirth], [SecurityQuestion], [SecurityAnswer], [OptInMarketing]) VALUES (1, N'Dave', N'Charles', N'07521325669', N'31 road', N'dave@gmail.com', N'pass123', N'le2 1uu', N'1959-08-11', N'who is me', N'me', 0)
SET IDENTITY_INSERT [dbo].[tblCustomer] OFF
