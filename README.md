Ứng dụng quản lý người dùng (Login/Register)

#Thông tin nhóm
  -  MSSV: 24521518 - Lê Minh Sang
  -  MSSV: 24521466 - Lê Minh Quang

#Mô tả
Ứng dụng Windows Forms (C#) kết nối với SQL Server cho phép người dùng:
  -  Đăng ký tài khoản mới với Username, Email, Password (có kiểm tra độ mạnh mật khẩu và xác nhận lại)
  -  Đăng nhập bằng Email hoặc Username + Password
  -  Mật khẩu được băm bằng SHA-256 trước khi lưu trữ vào database
  -  Sau khi đăng nhập thành công, chương trình sẽ mở MainForm hiển thị thông tin người dùng

Ứng dụng minh họa các khái niệm cơ bản về:
  - Windows Forms UI
  - Kết nối cơ sở dữ liệu SQL Server bằng SqlConnection, SqlCommand
  - Hashing mật khẩu bằng SHA-256
  - Kiểm tra hợp lệ của input (email, username, password)

#Hướng dẫn cài đặt:
  - Cài đặt SQL Server và SQL Server Management Studio (SSMS)
  - Tạo cơ sở dữ liệu và bảng Users bằng script sau:
CREATE DATABASE UserManagement;
GO
USE UserManagement;

CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(64) NOT NULL
);
  - Mở project bằng Visual Studio
  - Kiểm tra lại connection string trong các file LoginForm.cs, MainForm.cs, RegisterForm.cs để phù hợp với tên SQL Server instance của máy bạn:
        private string connectionString =
    "Data Source=DESKTOP-xxx\\SQLEXPRESS;Initial Catalog=UserManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


#Hướng dẫn sử dụng

Đăng ký tài khoản:

- Mở ứng dụng, chọn Register.

- Nhập Username, Email, Password và Confirm Password.
  
- Nếu hợp lệ → Lưu vào SQL Server.
  
Đăng nhập:

- Nhập Email hoặc Username và Password.

- Nếu đúng → hiển thị màn hình MainForm với thông tin tài khoản.

Đăng xuất / Quay lại: Trong MainForm bấm nút Back để quay lại LoginForm.
