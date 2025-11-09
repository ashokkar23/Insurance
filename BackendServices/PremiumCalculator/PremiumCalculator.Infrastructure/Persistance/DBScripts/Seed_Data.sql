INSERT INTO [dbo].[Rating] ([Rating], [Factor]) VALUES
	('Low Risk',1.5),
	('Medium Risk',2.25),
	('High Risk',11.50),
	('Very High Risk',31.75);

INSERT INTO [dbo].[Occupation] ([Occupation], [RatingId]) VALUES
	('Cleaner', 3),
	('Doctor', 1),
	('Author', 2),
	('Farmer', 4),
	('Mechanic', 4),
	('Florist', 3),
	('Other',4);