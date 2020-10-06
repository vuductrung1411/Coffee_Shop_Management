# Dự án phần mềm quản lý quán cà phê
## Mô tả
- Người sử dụng:
  - Chủ quán cà phê
  - Nhân viên thu ngân
- Mục tiêu: Phần mềm giúp người sử dụng có thể quản lý được các hoạt động cơ bản nhất của một quán cà phê như: bán hàng, quản lý quán, thống kê thu chi,...

## Danh sách tính năng
### 1.  Bán hàng
- Gọi món (thêm món vào hóa đơn)
- Xóa món 
- Thay đổi thông tin: thay đổi loại (size), số lượng
- Tính tiền
- Tìm kiếm món:
    - Tìm kiếm theo tên
	- Tìm kiếm theo id hoặc đánh số
- Giảm giá: theo giá tiền từ 0 - tiền thanh toán
- In ra hóa đơn. Hóa đơn phải ghi rõ:
	- Tên món
	- Số lượng
	- Giá tiền
	- Loại (size)
	- Thông tin về quán:
		- Tên quán
		- SDT
		- Địa chỉ
		- Slogan (nếu có)
		- ...
	- Thông tin Wifi, bao gồm: Tên và password
	- Lời chúc và hẹn gặp lại
	- ...
- Thêm 1 thanh nhắc nhở nhân viên: kiểu như "Luôn tươi cười, nói cảm ơn, nói xin chào",... hoặc gì gì đó.
- ...

### 2. Quản lý quán
- Kiểm tra còn bao nhiêu ghế trống trong quán
- Quản lý quán theo mã id, mỗi khách/nhóm khách sẽ có ID riêng. Được đánh số theo từ 1 -> số lượng ghế.
- ...
	
### 3. Quản lý, thống kê thu chi, tình hình tài chính của quán
- Sẽ bao gồm 2 mục chính là: thu và chi
- Chủ quán sẽ được quán lý phần này
- Thống kê theo kiểu cây, ghi chú, ngày, số tiền,...
- Thống kê được tình hình tài chính theo: ngày, tuần, quý, tháng, năm or Từ ... tới ...
- Thống kê và hiển thị cho người dùng thấy theo dạng các lược đồ: dạng cột, tròn
- Quán lý số lượng khách tới quán
- ...
	
### 4. Đăng nhập, phân quyền
- Sẽ có 2 cấp bậc
- Cấp 1 là người chủ quán, có quyền quyết định toàn bộ về việc: xóa bớt nhân viên, thêm nhân viên, reset mật khẩu cho nhân viên, xem báo cáo tình hình tài chính và quyền thiết lập ở mục 5.
- Cấp 2 là nhân viên thu ngân, có quyền ở mục 1, 2, 6
- ...
	
### 5. Thiết lập
- Thêm/Xóa/Thay đổi thông tin về một món vào trong danh sách món
- Thêm/sửa/xóa/thay đổi thông tin, tài khoản của nhân viên
- ...
	
### 6. Quán lý thông tin khách hàng
- Lưu tên, sdt của khách hàng
- Lưu thông tin về đơn hàng, số tiền, loại món, size khách dùng
- Thêm thẻ thành viên, xóa, thay đổi
- Set về điều kiện để được giảm giá:
Và/hoặc (tức là thỏa hết điều kiện hoặc 1 số):
	- Về số tiền tổi thiểu
	- Số lần tới quán
	- Đi vào dịp sinh nhật quán
	- ...
- Món ăn mà khách hàng thường xuyên sử dụng nhất
- Đánh giá của khách hàng
- Các thông tin cá nhân khác như: sinh nhật,....
- ...
	
### 7. Thông báo
- Thông báo cho chủ quán:
	- Tình hình tài chính cuối tháng (or ngày, or năm, tháng, quý) (Do chủ quán set ngay từ đầu).
	- Thông báo nếu tháng/ngày/quý/năm TĂNG/GIẢM so với tháng/ngày/quý/năm trước. Và tăng/giảm bao nhiêu phần trăm (do chủ quán set) thì mới thông báo.
	- ...
- Thông báo cho nhân viên thu ngân:
	- Món xyz đã hết, size xyz đã hết.
	- Thanh thông báo chương trình giảm giá trong ngày hôm nay.
	- ...
- ...
		
		

## Tác giả
- Vũ Đức Trung (leader)
- Lê Hoàng Phú (developer)
- Trương Vĩnh Thái (developer)
