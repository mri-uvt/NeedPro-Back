/*Category*/

DECLARE @Pk_Category_name NVARCHAR(255);

SELECT @Pk_Category_name = 'Category.'+name
FROM sys.objects  
WHERE parent_object_id = (OBJECT_ID('Category'))   
AND type IN ( 'PK');  

EXEC sp_rename @Pk_Category_name, 'PK_Category'
GO

/*City*/
DECLARE @Pk_City_name NVARCHAR(255);

SELECT @Pk_City_name = 'City.'+name
FROM sys.objects  
WHERE parent_object_id = (OBJECT_ID('City'))   
AND type IN ( 'PK');  

EXEC sp_rename @Pk_City_name, 'PK_City'
GO  

/*Country*/
DECLARE @Pk_Country_name NVARCHAR(255);

SELECT @Pk_Country_name = 'Country.'+name
FROM sys.objects  
WHERE parent_object_id = (OBJECT_ID('Country'))   
AND type IN ( 'PK');  

EXEC sp_rename @Pk_Country_name, 'PK_Country'
GO

/*Skill*/
DECLARE @Pk_Skill_name NVARCHAR(255);

SELECT @Pk_Skill_name = 'Skill.'+name
FROM sys.objects  
WHERE parent_object_id = (OBJECT_ID('Skill'))   
AND type IN ( 'PK');  

EXEC sp_rename @Pk_Skill_name, 'PK_Skill'
GO

/*User*/
DECLARE @Pk_User_name NVARCHAR(255);

SELECT @Pk_User_name = 'User.'+name
FROM sys.objects  
WHERE parent_object_id = (OBJECT_ID('User'))   
AND type IN ( 'PK');  

EXEC sp_rename @Pk_User_name, 'PK_User'
GO