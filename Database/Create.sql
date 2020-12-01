CREATE DATABASE THECOFFEESHOP
GO

USE THECOFFEESHOP
GO

SET DATEFORMAT DMY

-- Drop all table 
DROP TABLE COMMENTS
DROP TABLE STOCK 
DROP TABLE BILLDETAIL 
DROP TABLE BILL 
DROP TABLE DISCOUNT 
DROP TABLE CUSTOMER 
DROP TABLE FOOD 
DROP TABLE ACCOUNT 
DROP TABLE ACCOUNTINFO 
DROP TABLE HISTORY


-- Create table --
	-- ACCOUNTINFO						 -- Thông tin chi tiết của tài khoản
	-- ACCOUNT							 -- Lưu thông tin tài khoản mật khẩu
	-- FOOD								 -- Lưu thông tin món ăn
	-- CUSTOMER							 -- Lưu thông tin về khách hàng
	-- DISCOUNT							 -- Lưu thông tin về chương trình giảm giá
	-- BILL								 -- Lưu thông tin hóa đơn
	-- BILLDETAIL						 -- Chi tiết hóa đơn
	-- STOCK							 -- Quản lý kho, hàng đầu vào
	-- HISTORY							 -- Lịch sử hoạt động

CREATE TABLE ACCOUNTINFO
(
	ID INT IDENTITY(0, 1) PRIMARY KEY,		-- Bắt đầu từ 0. ID = 0 => admin, ngược lại là Nhân viên và chủ quán
	HOTEN NVARCHAR(50),
	SDT VARCHAR(15),
	CHUCVU INT,								-- 0: nhân viên, 1: chủ quán , 2: Admin
	LUONG INT,
	CMND INT,
	NGAYSINH SMALLDATETIME,
	DIACHI NVARCHAR(100),
	NGVL SMALLDATETIME,						-- NGÀY VÀO LÀM
	GIOITINH INT							-- 0: NAM, 1: NỮ
)
GO

CREATE TABLE ACCOUNT
(
	ID INT PRIMARY KEY,						-- KHÓA NGOẠI CỦA ACCOUNTINFO
	USERNAME VARCHAR(50) UNIQUE NOT NULL,
	PASSWORD VARCHAR(200) NOT NULL,

	CONSTRAINT FK_ACCOUNT_ID FOREIGN KEY (ID) REFERENCES ACCOUNTINFO(ID)
)
GO

CREATE TABLE FOOD
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	TENMON NVARCHAR(50) NOT NULL,
	GIABAN INT,
	DVT NVARCHAR(20),				-- ĐƠN VỊ TÍNH
	NUOCSX NVARCHAR(30)				-- NƯỚC SẢN XUẤT
)
GO

CREATE TABLE CUSTOMER
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	HOTEN NVARCHAR(50),
	SDT VARCHAR(15),
	GIOITINH INT,							-- 0: NAM, 1: NỮ, 2: Giấu kín
	NGAYSINH SMALLDATETIME
)
GO

CREATE TABLE DISCOUNT
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	DISCOUNTNAME NVARCHAR(300),
	DISCOUNTVALUE INT CHECK(DISCOUNTVALUE >=0 AND DISCOUNTVALUE <= 100),  	 -- PHẦN TRĂM KHUYẾN MÃI
	MINBILLVALUE INT,														 -- GIÁ TRỊ HÓA ĐƠN TỐI THIỂU ĐỂ NHẬN GIẢM GIÁ
	MAXDISCOUNTVALUE INT,													 -- GIÁ TRỊ TỐI ĐA MÀ CHƯƠNG TRÌNH KHUYẾN MÃI GIẢM GIÁ
	NGAYBATDAU SMALLDATETIME,												 -- NGÀY BẮT ĐẦU KHUYẾN MÃI
	NGAYKETTHUC SMALLDATETIME,												 -- NGÀY KẾT THÚC KHUYẾN MÃI
	DISCOUNTTEXT NVARCHAR(300)												 -- TEXT CHI TIẾT
	-- Ví dụ: 
	-- Giảm 5% tốI đa 30.000 cho đơn hàng có giá trị từ 100.000
	-- Từ xx/yy tớI uu/vv
	-- Text: nhân dịp sinh nhật quán, quán giảm giá giảm 5% tốI đa 30.000 cho đơn hàng có giá trị từ 100.000 từ xx/yy tớI uu/vv
)
GO

CREATE TABLE BILL
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	IDSTAFF INT,									-- MÃ NHÂN VIÊN THU NGÂN
	IDCUSTOMER INT,									-- MÃ KHÁCH HÀNG
	IDDISCOUNT INT,									-- MÃ CHƯƠNG TRÌNH KHUYẾN MÃI
	TONGHOADON INT,									-- TỐNG GIÁ TRỊ HÓA ĐƠN
	GIAMGIA INT,									
	THANHTIEN INT,									-- THÀNH TIỀN
	NGAYGIAODICH SMALLDATETIME,

	CONSTRAINT FK_BILL_IDSTAFF FOREIGN KEY (IDSTAFF) REFERENCES ACCOUNTINFO(ID),
	CONSTRAINT FK_BILL_IDCUSTOMER FOREIGN KEY (IDCUSTOMER) REFERENCES CUSTOMER(ID),
	CONSTRAINT FK_BILL_IDDISCOUNT FOREIGN KEY (IDDISCOUNT) REFERENCES DISCOUNT(ID)
)
GO

CREATE TABLE BILLDETAIL
(
	IDBILL INT NOT NULL,				-- ID của hóa đơn
	IDFOOD INT NOT NULL,				-- ID của món ăn
	SL INT,								-- Số lượng
	NOTE NVARCHAR(1000),

	CONSTRAINT FK_BILLDETAIL_IDBILL FOREIGN KEY (IDBILL) REFERENCES BILL(ID),
	CONSTRAINT FK_BILLDETAIL_IDFOOD FOREIGN KEY (IDFOOD) REFERENCES FOOD(ID),

	-- CONSTRAINT PK_BILLDETAIL PRIMARY KEY (IDBILL, IDFOOD)
)
GO

CREATE TABLE STOCK
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	TENHANG NVARCHAR(200),					-- TÊN MÓN HÀNG NHẬP VÀO
	GIANHAP INT,							-- GIÁ NHẬP VÀO
	SL INT,									-- SỐ LƯỢNG HÀNG CÒN LẠI
	NUOCSX NVARCHAR(200),					-- NƯỚC SẢN XUẤT
	NHACUNGCAP NVARCHAR(200),				-- NHÀ CUNG CẤP
	NGAYNHAPHANG SMALLDATETIME				-- NGÀY NHẬP HÀNG
)
GO


CREATE TABLE HISTORY
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,					
	IDACTION INT,											-- ID của người thực hiện
	IDOBJECT INT,											-- ID của người bị tác động
	NAMEOFACTION NVARCHAR(50),								-- Tên người thực hiện
	NAMEOFOBJECT NVARCHAR(50),								-- Tên người bị tác động
	ACTION NVARCHAR(1000),									-- Loại tác động
	ACTIONTIME SMALLDATETIME										-- Thời gian tác động
)
GO


CREATE TABLE COMMENTS
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,						-- 
	IDCMT INT,												-- ID của khách hàng nêu ý kiến đóng góp		
	NAMECMT NVARCHAR(100),									-- HỌ tên của khách
	TEXTCMT NVARCHAR(1000)									-- Ý kiến đóng góp của khách
)
GO

-- Thêm tài khoản gốc : admin
	-- tk: admin
	-- mk: admin (MD5 Encode - 21232f297a57a5a743894a0e4a801fc3)

INSERT INTO ACCOUNTINFO(HOTEN, CHUCVU) VALUES
	('Admin', 2)

INSERT INTO ACCOUNT(ID, USERNAME, PASSWORD) VALUES
	(0, 'Admin', '21232f297a57a5a743894a0e4a801fc3')


-- Tạo các hàm PROC -----------------------------------------------------------------------------------------------------------------

-- Dùng để login
CREATE PROC USP_Login
@userName varchar(50), @passWord varchar(200)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE USERNAME = @userName AND PASSWORD = @passWord
END
GO


-- Lấy ID account từ username
CREATE PROC USP_GetIDByUsername
@userName varchar(50)
AS
BEGIN
	SELECT ID FROM ACCOUNT WHERE USERNAME = @userName
END
GO


-- Thêm hóa đơn mới (chỉ có id nhân viên và id khách hàng)
CREATE PROC USP_CreateNewBill
@idStaff INT, @idCustomer INT
AS
BEGIN
	Insert into BILL(IDSTAFF, IDCUSTOMER) VALUES
	(@idStaff, @idCustomer)
END
GO

-- Thêm hóa đơn mới (mà không có mã khách hàng, chỉ có mã nhân viên)
CREATE PROC USP_CreateNewBillWithoutCustomer
@idStaff INT
AS
BEGIN
	Insert into BILL(IDSTAFF) VALUES
	(@idStaff)
END
GO

-- Tìm kiếm ID khách hàng thông qua SDT
CREATE PROC USP_GetIDCustomerBySDT
@sdt VARCHAR(15)
AS
BEGIN
	SELECT ID
	FROM CUSTOMER
	WHERE SDT = @sdt
END
GO

-- Thêm dữ liệu vào BILLDETAIL
CREATE PROC USP_InsertFoodIntoBill
@idBill INT, @idFood INT, @sl INT, @note NVARCHAR(1000)
AS
BEGIN
	INSERT INTO BILLDETAIL(IDBILL, IDFOOD, SL, NOTE) VALUES 
		(@idBill, @idFood, @sl, @note)
END
GO

-- Load ra Hóa đơn chi tiết từ mã hóa đơn
CREATE PROC USP_LoadBillDetailsByBillID
@idBill INT
AS
BEGIN
	SELECT f.TENMON AS [Món], cthd.SL AS [Số lượng], cthd.NOTE AS [Lưu ý]
	FROM BILLDETAIL cthd JOIN FOOD f ON f.ID = cthd.IDFOOD
	WHERE cthd.IDBILL = @idBill
END
GO

-- Thêm khách hàng mới
CREATE PROC USP_CreateNewCustomer
@name NVARCHAR(50), @sdt VARCHAR(15), @gioitinh INT, @ngaysinh SMALLDATETIME
AS
BEGIN
	INSERT INTO CUSTOMER(HOTEN, SDT, GIOITINH, NGAYSINH) VALUES (@name, @sdt, @gioitinh, @ngaysinh)
END
GO

SELECT * FROM CUSTOMER WHERE SDT = '006'