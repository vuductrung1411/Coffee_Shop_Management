﻿CREATE DATABASE THECOFFEESHOP
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

------------------------------------------------------------------------------------------------------

CREATE TABLE ACCOUNTINFO
(
	ID INT IDENTITY(0, 1) PRIMARY KEY,					-- Bắt đầu từ 0. ID = 0 => admin, ngược lại là Nhân viên và chủ quán
	HOTEN NVARCHAR(50),
	SDT VARCHAR(15),
	CHUCVU NVARCHAR(30),								-- Tên chức vụ
	LVPOSITION INT,										-- 0: nhân viên, 1: chủ quán , 2: Admin
	LUONG INT,
	CMND VARCHAR(50),
	NGAYSINH SMALLDATETIME,
	DIACHI NVARCHAR(100),
	NGVL SMALLDATETIME,										-- NGÀY VÀO LÀM
	GIOITINH NVARCHAR(20),		
	TINHTRANG NVARCHAR(50) DEFAULT N'Đang làm việc'
)
GO

CREATE TABLE ACCOUNT
(
	ID INT PRIMARY KEY,									-- KHÓA NGOẠI CỦA ACCOUNTINFO
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
	DVT NVARCHAR(30)									-- ĐƠN VỊ TÍNH
)
GO

CREATE TABLE CUSTOMER
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	HOTEN NVARCHAR(50),
	SDT VARCHAR(15),
	GIOITINH NVARCHAR(20),								
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
	TIMEGIAODICH SMALLDATETIME,						-- THỜI GIAN GIAO DỊCH

	CONSTRAINT FK_BILL_IDSTAFF FOREIGN KEY (IDSTAFF) REFERENCES ACCOUNTINFO(ID),
	CONSTRAINT FK_BILL_IDCUSTOMER FOREIGN KEY (IDCUSTOMER) REFERENCES CUSTOMER(ID),
	CONSTRAINT FK_BILL_IDDISCOUNT FOREIGN KEY (IDDISCOUNT) REFERENCES DISCOUNT(ID)
)
GO

CREATE TABLE BILLDETAIL
(
	IDBILL INT NOT NULL,				-- ID của hóa đơn
	IDFOOD INT NOT NULL,				-- ID của món ăn
	SL INT								-- Số lượng

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
	TIMENHAPHANG SMALLDATETIME,				-- THỜI GIAN NHẬP HÀNG
	NGAYHETHAN SMALLDATETIME
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
	TEXTCMT NVARCHAR(1000),									-- Ý kiến đóng góp của khách
	TIMECMT SMALLDATETIME									-- Thời gian
)
GO

CREATE TABLE SHOPINFO
(
	TENQUAN NVARCHAR(100),
	SDT VARCHAR(15),
	TENCHUQUAN NVARCHAR(100),
	DIACHI NVARCHAR(200),
	SOGHE INT DEFAULT 100000000,
	SOKHACHTOIDA INT DEFAULT 100000000,
	SOBAN INT DEFAULT 100000000,
	SINHNHATQUAN SMALLDATETIME,
	SLOGAN NVARCHAR(500)
)
GO

CREATE TABLE QUOTESLIST
(
	QUOTES NVARCHAR(300)
)
GO

CREATE TABLE POSITIONLIST
(
	POSITION NVARCHAR(100)
)
GO






