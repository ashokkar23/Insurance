CREATE VIEW [dbo].[V_OccupationRatingFactor]
	AS
Select Occupation.Occupation, Rating.Rating, Rating.Factor from Occupation JOIN Rating ON Occupation.RatingId = Rating.Id 