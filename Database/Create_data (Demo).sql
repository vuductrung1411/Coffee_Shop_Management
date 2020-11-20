USE THECOFFEESHOP
GO


DELETE FROM FOOD

INSERT INTO FOOD(TENMON, GIABAN) VALUES
	(N'Cà phê đen', 20000),
	(N'Cà phê sữa', 25000),
	(N'Americano', 30000),
	(N'Cappuccino', 30000),
	(N'Double Espresso', 40000),
	(N'Latte', 35000),
	(N'Macchiato', 45000),
	(N'Mint Chocolate', 50000),
	(N'Mocha', 45000),
	(N'White Mocha', 50000),
	(N'Caramel', 45000),
	(N'Coffee Jelly', 45000),
	(N'Cookies and Cream', 55000),
	(N'Hazalnut Mocha', 65000),
	(N'Mint Chocolate Chip', 65000),
	(N'Strawberry', 55000),
	(N'Vanilla Bean', 45000),
	(N'Earl Gray', 35000),
	(N'English Breakfast', 45000),
	(N'Green Tea', 45000),
	(N'Jasmine Tea', 40000),
	(N'Hot Tea', 30000),
	(N'Ice Thai Tea', 30000),
	(N'Lemon Tea', 30000)



INSERT INTO CUSTOMER(HOTEN, SDT) VALUES
	(N'Nguyễn Văn A', '0909509274242'),
	(N'Trần Văn B', '45678890954567')

INSERT INTO DISCOUNT(DISCOUNTVALUE, DISCOUNTTEXT) VALUES
	(20, N'Sinh nhật lần 3 của quán'),
	(30, N'Nhân dịp quốc khánh 30/4')

INSERT INTO ACCOUNTINFO(HOTEN, CHUCVU) VALUES
	(N'Staff0001', 0),
	(N'Staff0002', 0),
	(N'Staff0003', 0)

INSERT INTO STOCK(TENHANG, GIANHAP) VALUES 
	(N'Bịch cà phê Trung Nguyên 500gr', 1000000),
	(N'Bịch Americano nhập khẩu từ Italy 250gr', 5000000)