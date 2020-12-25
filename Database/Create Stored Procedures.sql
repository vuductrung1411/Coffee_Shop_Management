-- Tạo các hàm PROC -----------------------------------------------------------------------------------------------------------------

USE THECOFFEESHOP
GO

SET DATEFORMAT DMY


-- Dùng để login
CREATE PROC USP_Login
@userName varchar(50), @passWord varchar(200)
AS
BEGIN
	SELECT * 
	FROM ACCOUNT acc JOIN ACCOUNTINFO accinfo ON acc.ID = accinfo.ID
	WHERE acc.USERNAME = @userName AND acc.PASSWORD = @passWord AND accinfo.TINHTRANG = N'Đang làm việc'
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
@name NVARCHAR(50), @sdt VARCHAR(15), @gioitinh NVARCHAR(20), @ngaysinh SMALLDATETIME
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
@tenmon NVARCHAR(50), @giaban INT, @dvt NVARCHAR(30)
AS
BEGIN
	INSERT INTO FOOD(TENMON, GIABAN, DVT) VALUES
		(@tenmon, @giaban, @dvt)
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
	SELECT info.ID, info.HOTEN, info.SDT, info.CHUCVU, info.LVPOSITION, info.LUONG, info.CMND, info.NGAYSINH, info.DIACHI, info.NGVL, info.GIOITINH, info.TINHTRANG
	FROM ACCOUNT acc JOIN ACCOUNTINFO info ON acc.ID = info.ID
	WHERE acc.USERNAME = @username
END
GO

-- Update thông tin của nhân viên
CREATE PROC USP_UpdateAccountInfo
@id INT, 
@hoten NVARCHAR(50), @sdt VARCHAR(15), @gioitinh NVARCHAR(20), @ngaysinh SMALLDATETIME, @diachi NVARCHAR(100), @cmnd VARCHAR(50),
@chucvu NVARCHAR(30), @ngayvaolam SMALLDATETIME, @luong INT
AS
BEGIN
	UPDATE ACCOUNTINFO
	SET 
		HOTEN = @hoten,
		SDT = @sdt,
		GIOITINH = @gioitinh,
		NGAYSINH = @ngaysinh,
		DIACHI = @diachi,
		CMND = @cmnd,
		CHUCVU = @chucvu,
		NGVL = @ngayvaolam,
		LUONG = @luong
	WHERE ID = @id
END
GO

EXEC USP_UpdateAccountInfo @id = 1 , @hoten = N'Nhân viên 001' , @sdt = '090001' , @gioitinh = 'Nam', 
							@ngaysinh = '14/11/2001' , @diachi = N'Địa chỉ của nhân viên 000001' ,
							@cmnd = '00000000001' , @chucvu = 'Nhân viên thu ngân', 
							@ngayvaolam = '24/12/2020', @luong = 1000000

-- Lấy ra USERNAME thông qua ID
CREATE PROC USP_GetUsernameByID
@id INT
AS
BEGIN
	SELECT USERNAME
	FROM ACCOUNT
	WHERE ID = @id	
END
GO

EXEC USP_GetUsernameByID @id = 1

-- Lấy ra PASSWORD thông qua ID
CREATE PROC USP_GetPasswordByID
@id INT
AS
BEGIN
	SELECT PASSWORD
	FROM ACCOUNT
	WHERE ID = @id	
END
GO

EXEC USP_GetPasswordByID @id = 1

-- Update lại mật khẩu cho Account thông qua ID
CREATE PROC USP_UpdatePasswordByID
@id INT, @password VARCHAR(200)
AS
BEGIN
	UPDATE ACCOUNT
	SET PASSWORD = @password
	WHERE ID = @id
END
GO

-- Cho nhân viên nghỉ việc (Sa thải)
CREATE PROC USP_LayOffStaffByID
@id INT, @tinhtrang NVARCHAR(50)
AS
BEGIN
	UPDATE ACCOUNTINFO 
	SET TINHTRANG = N'Đã nghỉ việc'
	WHERE ID = @id
END
GO

-- Update thông tin của khách hàng
CREATE PROC USP_UpdateCustomerInfo
@id INT, @hoten NVARCHAR(50), @sdt VARCHAR(15), @gioitinh NVARCHAR(20), @ngaysinh SMALLDATETIME
AS
BEGIN
	UPDATE CUSTOMER
	SET
		HOTEN = @hoten,
		SDT = @sdt,
		GIOITINH = @gioitinh,
		NGAYSINH = @ngaysinh
	WHERE ID = @id
END
GO

-- Xóa món khỏi danh sách thông qua Tên món
CREATE PROC USP_DeleteFoodByName
@tenmon NVARCHAR(50)
AS
BEGIN
	DELETE FROM FOOD
	WHERE TENMON = @tenmon
END
GO

-- Lấy ra thông tin món từ Tên món
CREATE PROC USP_GetFoodByName
@tenmon NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM FOOD
	WHERE TENMON = @tenmon
END
GO

-- Update thông tin món thông qua ID
CREATE PROC USP_UpdateFoodInfoByID
@id INT, @tenmon NVARCHAR(50), @giaban INT, @dvt NVARCHAR(30)
AS
BEGIN
	UPDATE FOOD
	SET
		TENMON = @tenmon,
		GIABAN = @giaban,
		DVT = @dvt
	WHERE ID = @id
END
GO

-- Kiểm tra xem đã tồn tại món ăn này hay chưa thông qua tên món
CREATE PROC USP_CheckExistsFoodName
@tenmon NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM FOOD
	WHERE TENMON = @tenmon
END
GO

-- Xóa món ra khỏi danh sách thông qua ID
CREATE PROC USP_DeleteFoodByID
@id INT
AS
BEGIN
	DELETE FROM FOOD
	WHERE ID = @id
END
GO

-- Tạo thêm hàng mới trong kho hàng
CREATE PROC USP_NewImport
@tenhang NVARCHAR(200), @gianhap INT, @sl INT, @nuocsx NVARCHAR(200), @nhacungcap NVARCHAR(200), @timenhaphang SMALLDATETIME, @hsd SMALLDATETIME
AS
BEGIN
	INSERT INTO STOCK(TENHANG, GIANHAP, SL, NUOCSX, NHACUNGCAP, TIMENHAPHANG, NGAYHETHAN) VALUES
		(@tenhang, @gianhap, @sl, @nuocsx, @nhacungcap, @timenhaphang, @hsd)
END
GO

-- Lấy ra thông tin của Stock từ ID
CREATE PROC USP_GetStockByID
@id INT
AS
BEGIN
	SELECT * 
	FROM STOCK
	WHERE ID = @id
END
GO

-- Giảm số lượng hàng của Stock thông qua ID
CREATE PROC USP_DecreaseSLStockByID
@id INT
AS
BEGIN
	UPDATE STOCK
	SET SL = SL - 1
	WHERE ID = @id
END
GO