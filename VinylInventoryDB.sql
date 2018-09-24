
Create Table Colors (
	ID bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name varchar(32) NOT NULL,
	ColorNum int NULL
)

Create Table Supplier (
	ID bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name varchar(128) NOT NULL,
	ItemLink varchar(1024) NULL
)

CREATE TABLE VinylType (
	ID bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name varchar(128) NULL
)

Create Table Vinyl (
	ID bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ColorID bigint Foreign Key references Colors(ID),
	CostperSqFt decimal(5,2) NOT NULL,
	FullSheet int NOT NULL,
	ThreeQuarterSheet int NOT NULL,
	HalfSheet int NOT NULL,
	QuarterSheet int NOT NULL,
	NotificationLevel int NULL,
	VinylType bigint Foreign Key references VinylType(ID),
	SupplierID bigint Foreign Key references Supplier(ID)
)


Create Table ShippingItems (
	ID bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name varchar(128) NOT NULL,
	Quantity int NOT NULL,
	Cost decimal(5,2) NOT NULL,
	NotificationLevel int NULL,
	SupplierID bigint Foreign Key references Supplier(ID),
	ApplicationKit bit
)


Create Table ShirtColors (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	Name varchar(32) NOT NULL
)


Create Table ShirtStyles (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	Name varchar(128) NOT NULL
)


Create Table ShirtSizes (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	Name varchar(8) NOT NULL
)


Create Table Shirts (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	Quantity int NOT NULL,
	Cost decimal(5,2) NOT NULL,
	ColorID bigint NOT NULL Foreign Key references ShirtColors(ID),
	StyleID bigint NOT NULL Foreign Key references ShirtStyles(ID),
	SizeID bigint NOT NULL Foreign Key references ShirtSizes(ID),
)

Create Table Stickers (
	ID bigint IDENTITY(1,1) NOT NULL Primary Key,
	Name varchar(128) NOT NULL,
	Quantity int NOT NULL,
	Cost decimal(5, 2) NOT NULL,
	NotificationLevel int NULL,
	SupplierID bigint Foreign Key references Supplier(ID),
)

Create Table Orders (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	OrderDate DateTime NOT NULL,
	OrderPrice decimal(5,2) NULL,
	QuantityInOrder int NULL,
	Fees decimal(5,2) NULL
)


Create Table VinylOrderItems (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	OrderID bigint NOT NULL Foreign Key references Orders(ID),
	VinylID bigint NULL Foreign Key references Vinyl(ID),
	Quantity int NOT NULL
)

Create Table ShippingOrderItems (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	OrderID bigint NOT NULL Foreign Key references Orders(ID),
	ShippingID bigint NULL Foreign Key references ShippingItems(ID),
	Quantity int NOT NULL
)

Create Table StickerOrderItems (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	OrderID bigint NOT NULL Foreign Key references Orders(ID),
	StickerID bigint NULL Foreign Key references Stickers(ID),
	Quantity int NOT NULL
)

Create Table ShirtOrderItems (
	ID bigint NOT NULL IDENTITY(1,1) Primary Key,
	OrderID bigint NOT NULL Foreign Key references Orders(ID),
	ShirtID bigint NOT NULL Foreign Key references Stickers(ID),
	Quantity int NOT NULL
)
GO


CREATE VIEW [dbo].[v_ProductTotals] AS
	SELECT c.Name as 'Color'
		,p.FullSheet as 'Full Sheets'
		,p.ThreeQuarterSheet as '3/4 Sheets'
		,p.HalfSheet as '1/2 Sheets'
		,p.QuarterSheet as '1/4 Sheets' 
		,p.FullSheet + p.ThreeQuarterSheet*.75 + p.HalfSheet*.5 + p.QuarterSheet*.25 as 'Total Sheets'
		,(p.FullSheet*p.CostperSqFt + p.ThreeQuarterSheet*p.CostperSqFt*.75 + p.HalfSheet*p.CostperSqFt*.5 + p.QuarterSheet*p.CostperSqFt*.25) as 'Total cost'
	FROM colors as c, Products as p, VinylType as v
	WHERE c.ID = p.ColorID AND v.ID = p.VinylType		
GO


CREATE VIEW [dbo].[v_OrderItems] AS
SELECT o.ID as 'Order Number'
	, soi.ShippingID as 'Item ID'
	, si.Name as 'Item Name'
	, soi.Quantity
	, (soi.Quantity * si.Cost) as 'Material Cost'
FROM Orders o
	LEFT JOIN ShippingOrderItems soi on o.ID = soi.OrderID
	LEFT JOIN ShippingItems si on soi.ShippingID = si.ID
UNION
	SELECT o.ID
	, voi.ProductID
	, c.Name
	, voi.Quantity
	, (voi.Quantity * p.CostperSqFt)
	FROM Orders o
		LEFT JOIN VinylOrderItems voi on o.ID = voi.OrderID
		LEFT JOIN Products p on voi.ProductID = p.ID
		LEFT JOIN Colors c on p.ColorID = c.ID
UNION
	SELECT o.ID
		, stoi.StickerID
		, sti.Name
		, stoi.Quantity
		, (stoi.Quantity * sti.Cost)
	FROM Orders o
		LEFT JOIN StickerOrderItems stoi on o.ID = stoi.OrderID
		LEFT JOIN Stickers sti on stoi.StickerID = sti.ID
UNION
	SELECT o.ID
		, shirtoi.ShirtID
		, scol.Name
		, shirtoi.Quantity
		, (shirtoi.Quantity * shirts.Cost)
	FROM Orders o
		LEFT JOIN ShirtOrderItems shirtoi on o.ID = shirtoi.OrderID
		LEFT JOIN Shirts on shirtoi.ShirtID = Shirts.ID
		LEFT JOIN ShirtColors scol on shirts.ColorID = scol.ID
GO		

CREATE VIEW [dbo].[v_Color_Type] 
AS
SELECT        dbo.Products.ID AS ProdID, dbo.Colors.Name + ' - ' + dbo.VinylType.TypeName AS Color_type
FROM            dbo.Colors INNER JOIN
                         dbo.Products ON dbo.Colors.ID = dbo.Products.ColorID INNER JOIN
                         dbo.VinylType ON dbo.Products.VinylType = dbo.VinylType.ID
GO