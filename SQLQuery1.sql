Create Table Users(
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(MAX) NULL, 
password VARCHAR(MAX) NULL, 
profile_image VARCHAR(MAX) NULL, 
role VARCHAR(MAX) NULL, 
status VARCHAR(MAX) NULL, 
reg_date DATE NULL
)
SELECT*FROM Users
INSERT INTO Users(username,password,profile_image,role,status,reg_date) VALUES ('Glória','gria33','','Admin','Active','2024-04-05')