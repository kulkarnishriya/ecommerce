Use eWebsitedb

Alter table dbo.WebsiteUser
Add Constraint FK_UserAddress 
FOREIGN KEY (AddressId) REFERENCES [dbo].[Address](Id);

Alter table dbo.History
Add Constraint FK_ProductHistory 
FOREIGN KEY (ProductId) REFERENCES [dbo].[Product](Id);

Alter table dbo.History
Add Constraint FK_UserHistory 
FOREIGN KEY (UserId) REFERENCES [dbo].[WebsiteUser](id);

Alter table dbo.Cart
Add Constraint FK_ProductCart 
FOREIGN KEY (ProductId) REFERENCES [dbo].[Product](Id);

Alter table dbo.Cart
Add Constraint FK_UserCart 
FOREIGN KEY (UserId) REFERENCES [dbo].[WebsiteUser](id);

Alter table dbo.Product
Add Constraint FK_ProductImage 
FOREIGN KEY (ImageId) REFERENCES [dbo].[Img](Id);
