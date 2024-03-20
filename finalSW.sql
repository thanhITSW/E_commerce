--create database finalSW
create table accountant(
	idAccountant varchar(50) PRIMARY KEY,
	nameAccountant varchar(50),
	passAccountant varchar(50),
	phoneAccountant varchar(15),
)

create table customer(
	idCustomer varchar(50) PRIMARY KEY,
	nameCustomer varchar(50),
	passCustomer varchar(50),
	phoneCustomer varchar(50)
)

create table item(
	idItem varchar(50) PRIMARY KEY,
	nameItem nvarchar(50),
  priceItem int,
  image varchar(500),
	inventory int
)

create table receipt(
	idReceipt varchar(50) PRIMARY KEY,
	idAccountant varchar(50),
	creationDate date,
	totalPrice int,
	foreign key(idAccountant) references accountant(idAccountant)
)

create table detailReceipt(
	idReceipt varchar(50),
	idItem varchar(50),
	quantity int,
	price int
	foreign key(idReceipt) references receipt(idReceipt),
	foreign key(idItem) references item(idItem),
	primary key (idReceipt, idItem)
)


create table orders(
	idOrder varchar(50) PRIMARY KEY,
	idCustomer varchar(50),
	paymentMethod varchar(50),
	creationDate date,
	totalPrice int,
	foreign key(idCustomer) references customer(idCustomer)
)

create table detailOrder(
	idOrder varchar(50),
	idItem varchar(50),
	quantity int,
	price int,
	foreign key(idItem) references item(idItem),
	foreign key(idOrder) references orders(idOrder),
	primary key (idOrder, idItem)
)

create table deliveryBill(
	idDeliveryBill varchar(50) PRIMARY KEY,
	idOrder varchar(50),
	idAccountant varchar(50),
	creationDate date,
	orderStatus varchar(50),
	paymentStatus varchar(50),
	foreign key(idOrder) references orders(idOrder),
	foreign key(idAccountant) references accountant(idAccountant)
)

--Them du lieu vao db
insert into accountant values ('ac1', 'Ke toan 1','123456', '0123456')
insert into accountant values ('admin', 'Admin','123456', '0123456')
insert into accountant values ('thanh', 'Tan Thanh','123456', '01234567')
insert into accountant values ('an', 'Bao An','123456', '01234568')
insert into accountant values ('baoan', 'Bao An','123456', '01234569')
insert into accountant values ('tanthanh', 'Bao An','123456', '01234562')

insert into customer values ('cus1', 'Khach hang 1','123456', '01234567')

insert into item values ('it1', 'Samsung Galaxy S23 5G', 818, 'it1.jpg', 100)
insert into item values ('it2', 'Samsung Galaxy S23 Ultra 5G', 1400, 'it2.jpg', 100)
insert into item values ('it3', 'Samsung Galaxy S23+ 5G', 1200, 'it3.jpg', 100)
insert into item values ('it4', 'realme C55', 200, 'it4.jpg', 30)
insert into item values ('it5', 'Oppo Find N2', 900, 'it5.jpg', 70)
insert into item values ('it6', 'iPhone 14 Pro Max', 1300, 'it6.jpg', 100)
insert into item values ('it7', 'iPhone 14 Plus', 1000, 'it7.jpg', 100)
insert into item values ('it8', 'realme C30s', 100, 'it8.jpg', 40)
insert into item values ('it9', 'realme 10', 90, 'it9.jpg', 40)

--create receipt
insert into receipt values ('rc1', 'ac1', '1/4/2022', '')
insert into receipt values ('rc2', 'ac1', '12/6/2021', '')

insert into receipt values ('rc3', 'ac1', '2/4/2022', '')
insert into receipt values ('rc4', 'ac1', '5/6/2022', '')
insert into receipt values ('rc5', 'ac1', '8/6/2021', '')
insert into receipt values ('rc6', 'ac1', '6/6/2021', '')


insert into detailReceipt values ('rc1','it1', 2, 10000)
insert into detailReceipt values ('rc1','it2', 3, 20000)
insert into detailReceipt values ('rc1','it3', 4, 40000)
insert into detailReceipt values ('rc1','it4', 5, 50000)
insert into detailReceipt values ('rc1','it5', 21, 60000)
insert into detailReceipt values ('rc2','it1', 2, 10000)
insert into detailReceipt values ('rc2','it2', 3, 20000)
insert into detailReceipt values ('rc2','it3', 4, 40000)
insert into detailReceipt values ('rc2','it4', 5, 50000)
insert into detailReceipt values ('rc2','it5', 21, 60000)
insert into detailReceipt values ('rc2','it7', 32, 100000)

insert into detailReceipt values ('rc3','it1', 2, 10000)
insert into detailReceipt values ('rc3','it2', 3, 20000)
insert into detailReceipt values ('rc3','it3', 4, 40000)
insert into detailReceipt values ('rc4','it4', 5, 50000)
insert into detailReceipt values ('rc4','it5', 21, 60000)
insert into detailReceipt values ('rc4','it1', 2, 10000)
insert into detailReceipt values ('rc5','it2', 3, 20000)
insert into detailReceipt values ('rc5','it8', 4, 40000)
insert into detailReceipt values ('rc5','it4', 5, 50000)
insert into detailReceipt values ('rc5','it5', 21, 60000)
insert into detailReceipt values ('rc3','it9', 32, 100000)

insert into detailReceipt values ('rc6','it8', 7, 30000)
insert into detailReceipt values ('rc6','it7', 2, 20000)
insert into detailReceipt values ('rc6','it5', 18, 40000)
insert into detailReceipt values ('rc6','it4', 25, 10000)

--create order
insert into orders values ('or1', 'cus1', 'Momo', '1/4/2022', 0)
insert into orders values ('or2', 'cus1', 'Momo', '12/6/2021', 0)
insert into orders values ('or3', 'cus1', 'ATM', '2/4/2022', 0)
insert into orders values ('or4', 'cus1', 'VNPAY', '5/6/2022', 0)
insert into orders values ('or5', 'cus1', 'ATM', '8/6/2021', 0)
insert into orders values ('or6', 'cus1', 'ATM', '6/6/2021', 0)

delete from orders
delete from detailOrder
delete from deliveryBill

insert into detailOrder values ('or1', 'it1', 3, 12000)
insert into detailOrder values ('or1', 'it2', 3, 15000)
insert into detailOrder values ('or1', 'it3', 4, 23000)
insert into detailOrder values ('or1', 'it4', 5, 53000)
insert into detailOrder values ('or1', 'it5', 8, 64000)
insert into detailOrder values ('or1', 'it9', 20, 123000)
insert into detailOrder values ('or2', 'it6', 2, 12000)
insert into detailOrder values ('or2', 'it7', 3, 15000)
insert into detailOrder values ('or2', 'it8', 4, 23000)
insert into detailOrder values ('or2', 'it9', 5, 53000)
insert into detailOrder values ('or2', 'it1', 6, 64000)
insert into detailOrder values ('or2', 'it3', 50, 164000)

insert into detailOrder values ('or3', 'it1', 20, 123000)
insert into detailOrder values ('or3', 'it6', 2, 12000)
insert into detailOrder values ('or3', 'it7', 3, 15000)
insert into detailOrder values ('or3', 'it8', 4, 23000)

insert into detailOrder values ('or4', 'it4', 5, 53000)
insert into detailOrder values ('or4', 'it5', 8, 64000)
insert into detailOrder values ('or4', 'it1', 20, 123000)
insert into detailOrder values ('or4', 'it6', 2, 12000)
insert into detailOrder values ('or4', 'it7', 3, 15000)

insert into detailOrder values ('or5', 'it7', 3, 15000)
insert into detailOrder values ('or5', 'it8', 4, 23000)
insert into detailOrder values ('or5', 'it9', 5, 53000)

insert into detailOrder values ('or6', 'it6', 5, 12000)
insert into detailOrder values ('or6', 'it7', 10, 15000)
insert into detailOrder values ('or6', 'it2', 20, 23000)
insert into detailOrder values ('or6', 'it3', 9, 53000)
insert into detailOrder values ('or6', 'it9', 8, 64000)

--create delivery bill 
insert into deliveryBill values ('db1', 'or1', 'ac1', '1/4/2021', 'being transferred' , 'unpaid')

insert into deliveryBill values ('db2', 'or2', 'ac1', '12/6/2021', 'being transferred' , 'paid')

insert into deliveryBill values ('db3', 'or3', 'ac1', '2/4/2022', 'delivered' , 'unpaid')

insert into deliveryBill values ('db4', 'or4', 'ac1', '5/6/2022', 'being transferred' , 'unpaid')

insert into deliveryBill values ('db5', 'or5', 'ac1', '8/6/2021', 'delivered' , 'paid')

insert into deliveryBill values ('db6', 'or6', 'ac1', '6/6/2021', 'delivered' , 'paid')

UPDATE re
    SET totalPrice = COALESCE(de.amount, 0)  
    FROM receipt re LEFT JOIN
         (select r.idReceipt, sum(price*quantity) as amount 
		 from  detailReceipt dr, receipt r 
		 where r.idReceipt = dr.idReceipt 
		 group by r.idReceipt
         ) de
         ON de.idReceipt = re.idReceipt;

UPDATE o
    SET totalPrice = COALESCE(de.amount, 0)  
    FROM orders o LEFT JOIN
         (select ord.idOrder, sum(price*quantity) as amount 
		 from  detailOrder do, orders ord 
		 where ord.idOrder = do.idOrder 
		 group by ord.idOrder
         ) de
         ON de.idOrder = o.idOrder;

delete from detailReceipt where idReceipt = 'rc7'
delete from receipt where idReceipt = 'rc7'
delete from item where idItem = 'it11'
delete from item where idItem ='it10'

select * from item
