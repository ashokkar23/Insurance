CREATE VIEW [dbo].[V_OccupationRating]
	AS
Select Occupation.Occupation, Rating.Rating from Occupation JOIN Rating ON Occupation.RatingId = Rating.Id;