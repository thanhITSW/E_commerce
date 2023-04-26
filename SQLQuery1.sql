Create Database B2B_WEB

Create table tb_ProductCategory (
	id int primary key not null,
	Title nvarchar(150) not null,
	Description nvarchar(500),
	icon nvarchar(150),
	CreatedDate datetime,
	CreatedBy nvarchar(150),
	ModifiedrDate datetime,
	ModifierBy nvarchar(150)
)
Create table tb_Product (
	id int Primary key not null,
	Title nvarchar(500) not null,
	ProductCategoryID int not null,
	Description nvarchar(500),
	Detail nvarchar(150),
	Img image,
	Price decimal(18,2) not null,
	PriceSale decimal(18,2) not null,
	Quantity nvarchar(150),
	CreatedDate datetime,
	CreatedBy nvarchar(150),
	ModifiedrDate datetime,
	ModifierBy nvarchar(150),
	Constraint fproductcate_id foreign key (ProductCategoryID) references tb_ProductCategory (id)
)

Create table tb_Business (
	id nvarchar(150) Primary Key not null,
	BusinessName nvarchar(250) not null,
	Email nvarchar(250) not null,
	Detail nvarchar(250) not null,
	Password nvarchar(100) not null
)


drop table tb_Product
drop table tb_ProductCategory
drop table tb_Business

select *from tb_Product
select *from tb_ProductCategory
select *from tb_Business

insert into tb_ProductCategory values('1', 'Apple', '','','2023-06-04 19:20','','2023-06-04 19:20','')
insert into tb_ProductCategory values('2', 'Samsung', '','','2023-06-04 19:20','','2023-06-04 19:20','')
insert into tb_ProductCategory values('3', 'Oppo', '','','2023-06-04 19:20','','2023-06-04 19:20','')
insert into tb_ProductCategory values('4', 'Realme', '','','2023-06-04 19:20','','2023-06-04 19:20','')
insert into tb_ProductCategory values('5', 'Xiaomi', '','','2023-06-04 19:20','','2023-06-04 19:20','')
insert into tb_ProductCategory values('6', 'Nokia', '','','2023-06-04 19:20','','2023-06-04 19:20','')
insert into tb_ProductCategory values('7', 'Vivo', '','','2023-06-04 19:20','','2023-06-04 19:20','')


insert into tb_Product values('1', 'Samsung Galaxy S23 5G', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-s23-600x600.jpg', '18000000', '19990000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('2', 'Oppo Find N2 Flip', '3', '', '', 'C:\xampp\htdocs\SE_Final\img\oppo-find-n2-flip-purple-thumb-1-600x600-1-600x600.jpg', '18000000', '19990000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('3', 'iPhone 14 Pro Max', '1', '', '', 'C:\xampp\htdocs\SE_Final\img\iphone-14-pro-max-den-thumb-600x600.jpg', '26090000', '27090000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('4', 'iPhone 14 Pro', '1', '', '', 'C:\xampp\htdocs\SE_Final\img\iphone-14-pro-vang-thumb-600x600.jpg', '22500000', '24000000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('5', 'Samsung Galaxy S21 SE 5G', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\Samsung-Galaxy-S21-FE-vang-1-2-600x600.jpg', '9000000', '10990000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('6', 'Xiaomi Redmi 12C', '5', '', '', 'C:\xampp\htdocs\SE_Final\img\Realme-c30s-xanh-temp-600x600.jpg', '2400000', '2990000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('7', 'Samsung Galaxy S23 Ultra 5G', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-s23-plus-600x600.jpg', '25000000', '269900000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('8', 'iPhone 11', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\iPhone-14-plus-thumb-den-600x600.jpg', '9600000', '10390000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('9', 'Vivo Y35', '7', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-z-fold4-kem-256gb-600x600.jpg', '5990000', '6290000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('10', 'Oppo Reno8 T 5G', '3', '', '', 'C:\xampp\htdocs\SE_Final\img\oppo-reno8t-vang1-thumb-600x600.jpg', '9590000', '10990000', '', '2023-06-04 22:20','','2023-06-04 22:20','')

insert into tb_Product values('11', 'Realme C55', '4', '', '', 'C:\xampp\htdocs\SE_Final\img\realme-c35-vang-thumb-600x600.jpg', '4000000', '4590000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('12', 'Samsung Galaxy A23', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-a23-cam-thumb-600x600.jpg', '4000000', '4690000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('13', 'Samsung Galaxy S20 FE', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-s20-fan-edition-xanh-la-thumbnew-600x600.jpeg', '9490000', '8890000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('14', 'iPhone 14', '1', '', '', 'C:\xampp\htdocs\SE_Final\img\iPhone-14-thumb-do-600x600.jpg', '18000000', '19000000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('15', 'Vivo V25 series', '7', '', '', 'C:\xampp\htdocs\SE_Final\img\vivo-v25-5g-vang-thumb-1-1-600x600.jpg', '8890000', '9490000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('16', 'Realme C30s', '4', '', '', 'C:\xampp\htdocs\SE_Final\img\xiaomi-redmi-12c-grey-thumb-600x600.jpg', '2000000', '2190000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('17', 'Samsung Galaxy S23+ 5G', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-s23-ultra-1-600x600.jpg', '21500000', '229900000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('18', 'iPhone 14 Plus', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\iphone-xi-den-600x600.jpg', '20000000', '21890000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('19', 'Samsung Galaxy Z Fold4 5G', '1', '', '', 'C:\xampp\htdocs\SE_Final\img\vivo-y35-thumb-den-600x600.jpg', '34990000', '36990000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('20', 'Xiaomi 12T', '5', '', '', 'C:\xampp\htdocs\SE_Final\img\xiaomi-12t-thumb-600x600.jpg', '8990000', '9490000', '', '2023-06-04 22:20','','2023-06-04 22:20','')

insert into tb_Product values('21', 'iPhone 13 mini 128GB', '1', '', '', 'C:\xampp\htdocs\SE_Final\img\iphone-13-mini-pink-1-600x600.jpg', '4000000', '4590000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('22', 'Vivo Y02s', '7', '', '', 'C:\xampp\htdocs\SE_Final\img\vivo-y02s-thumb-1-2-3-600x600.jpg', '4000000', '4690000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('23', 'Realme 10', '4', '', '', 'C:\xampp\htdocs\SE_Final\img\realme-10-thumb-1-600x600.jpg', '9490000', '8890000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('24', 'Nokia C21 Plus', '6', '', '', 'C:\xampp\htdocs\SE_Final\img\Nokia-C21-Plus-Gray-600x600.jpg', '18000000', '19000000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('25', 'Samsung Galaxy A04s', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-a04s-den-thumb-1-600x600.jpg', '8890000', '9490000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('26', 'Vivo Y21 series', '7', '', '', 'C:\xampp\htdocs\SE_Final\img\vivo-y21-white-01-1-600x600.jpg', '2000000', '2190000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('27', 'Samsung Galaxy S22 Ultra 5G', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\Galaxy-S22-Ultra-Burgundy-600x600.jpg', '21500000', '229900000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('28', 'Oppo A16K', '3', '', '', 'C:\xampp\htdocs\SE_Final\img\OPPO-a16k-den-nhan-thumb-600x600.jpg', '20000000', '21890000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('29', 'Oppo Find X5 Pro 5G', '3', '', '', 'C:\xampp\htdocs\SE_Final\img\oppo-find-x5-pro-den-thumb-600x600.jpg', '34990000', '36990000', '', '2023-06-04 22:20','','2023-06-04 22:20','')
insert into tb_Product values('30', 'Samsung Galaxy Z Flip 5G', '2', '', '', 'C:\xampp\htdocs\SE_Final\img\samsung-galaxy-z-flip4-5g-128gb-thumb-tim-600x600.jpg', '8990000', '9490000', '', '2023-06-04 22:20','','2023-06-04 22:20','')

insert into tb_Business values('BS001', 'Phone World', 'phoneworldcompany@gmail.com', '0988888888', 'BS001888')
insert into tb_Business values('BS002', 'MAD Phone', 'madphone@gmail.com', '0988888965', 'BS002965')
insert into tb_Business values('BS003', 'Vinn Phone', 'vinnphone@gmail.com', '0988888747', 'BS003747')
insert into tb_Business values('BS004', 'Unicast', 'unicast@gmail.com', '0988888656', 'BS004656')
insert into tb_Business values('BS005', 'Telecome Universe', 'Telecomeuni@gmail.com', '0988888995', 'BS005995')


delete from tb_Product where id='20'





