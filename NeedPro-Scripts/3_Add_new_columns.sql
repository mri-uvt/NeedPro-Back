ALTER TABLE [dbo].[City]
ADD 		CountryId INT

ALTER TABLE	[dbo].[User]
ADD		Pseudo		NVARCHAR(50),
		Sexe		CHAR(1),
		Speciality	NVARCHAR(50),
		YearsOfExperience INT,
		Biography	NVARCHAR(150),
		CountryId	INT,
		CityId		INT,
		CategoryId  INT;