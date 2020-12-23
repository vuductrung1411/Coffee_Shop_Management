-- Tạo các hàm PROC -----------------------------------------------------------------------------------------------------------------

USE THECOFFEESHOP
GO

SET DATEFORMAT DMY


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

-- Thêm tài khoản (nhân viên) mới của ACCOUNTINFO
CREATE PROC USP_CreateNewInfoAccount
@hoten NVARCHAR(50), @sdt VARCHAR(15), @chucvu NVARCHAR(30), @lvposition INT, @luong INT, @cmnd VARCHAR(50), @ngaysinh SMALLDATETIME, @diachi NVARCHAR(100), @ngvl SMALLDATETIME, @gioitinh NVARCHAR(30)
AS
BEGIN
	INSERT INTO ACCOUNTINFO(HOTEN, SDT, CHUCVU, LVPOSITION, LUONG, CMND, NGAYSINH, DIACHI, NGVL, GIOITINH) VALUES
		(@hoten, @sdt, @chucvu, @lvposition, @luong, @cmnd, @ngaysinh, @diachi, @ngvl, @gioitinh)
END
GO

-- Thêm tài khoản đăng nhập (username, password) mới của ACCOUNT ứng với của ACCOUNTINFO
CREATE PROC USP_CreateNewAccouunt
@id INT, @username VARCHAR(50), @password VARCHAR(200)
AS
BEGIN
	INSERT INTO ACCOUNT(ID, USERNAME, PASSWORD) VALUES
		(@id, @username, @password)
END
GO

-- Thêm món mới
CREATE PROC USP_CreateNewFood
@tenmon NVARCHAR(50), @giaban INT, @dvt NVARCHAR(20), @nuocsx NVARCHAR(30)
AS
BEGIN
	INSERT INTO FOOD(TENMON, GIABAN, DVT, NUOCSX) VALUES
		(@tenmon, @giaban, @dvt, @nuocsx)
END
GO

-- Thêm CTKM mới
CREATE PROC USP_CreateNewDiscount
@name NVARCHAR(300), @percent INT, @minBill INT, @maxValue INT, @ngayBD SMALLDATETIME, @ngayKT SMALLDATETIME, @text NVARCHAR(300)
AS
BEGIN
	INSERT INTO DISCOUNT(DISCOUNTNAME, DISCOUNTVALUE, MINBILLVALUE, MAXDISCOUNTVALUE, NGAYBATDAU, NGAYKETTHUC, DISCOUNTTEXT) VALUES
		(@name, @percent, @minBill, @maxValue, @ngayBD, @ngayKT, @text)
END
GO

-- Lấy ra thông tin nhân viên thông qua username
CREATE PROC USP_GetAccountInfoByUsername
@username VARCHAR(50)
AS
BEGIN
	SELECT info.ID, info.HOTEN, info.SDT, info.CHUCVU, info.LVPOSITION, info.LUONG, info.CMND, info.NGAYSINH, info.DIACHI, info.NGVL, info.GIOITINH
	FROM ACCOUNT acc JOIN ACCOUNTINFO info ON acc.ID = info.ID
	WHERE acc.USERNAME = @username
END
GO
