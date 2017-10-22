/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


insert  into dbo.Item   values
('Computer'),
('Telly'),
('Phone');


insert  into dbo.Orders  values
('John'),
('Ivan');

insert into  dbo.OrdersItem  values
(1,1),
(2,1),
(3,2);
