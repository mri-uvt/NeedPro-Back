
ALTER TABLE		[dbo].[City]
DROP  CONSTRAINT	[FK_City_Country]
ALTER TABLE		[dbo].[City]
ADD  CONSTRAINT [FK_City_Country] 	FOREIGN KEY		(CountryId) REFERENCES Country(Id);

