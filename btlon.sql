create database sangiaodich
go
use sangiaodich
go

--drop table nguoidung
create table nguoidung
(
    [Tên người dùng] NvarChar(100) not null ,
    [Số điện thoại] nvarchar(12) not null,
    [Địa chỉ] nvarchar(160) not null,
    [Số dư] bigint not null,
	[Số tiền nợ] bigint not null,
	[Giới tính] nvarchar (6) not null,
    [Tên tài khoản] nvarchar (160) not null  primary key,
	[Mật khẩu] NvarChar(32) not null,
	[Avatar] nvarchar(320) 
)


--drop table congty
create table congty
(
 [Tên công ty] NvarChar(160) not null ,
 [Địa chỉ công ty] NvarChar(320) not null,
 [Mã kinh doanh] NvarChar(100) not null  primary key,
 [Giá hiện tại] bigint not null,
 [Giá tham chiếu] bigint not null,
 [Giá trần] bigint not null,
 [Giá sàn] bigint not null,
 [Số cổ phần available] bigint not null,
 [Tổng số cổ phần] bigint not null,
 [Tổng số tiền] bigint not null,
)


--drop table lichsu_nd
create table lichsu_nd
(
[Mã Giao Dịch] bigint identity(1000000,1) not null,
[Tên tài khoản gửi] NvarChar(160) not null,
[Ghi chú giao dịch] NvarChar(320) not null,
foreign key ([Tên tài khoản gửi])
references nguoidung([Tên tài khoản]),
primary key ([Mã Giao Dịch])
)

--drop table lichsu_cty
create table lichsu_cty
(
[Mã Giao Dịch] bigint  not null,
[Tên tài khoản] NvarChar(160) not null,
[Ghi chú giao dịch] NvarChar(320) not null,
foreign key ([Tên tài khoản])
	references nguoidung([Tên tài khoản]),
primary key ([Mã Giao Dịch])
)


--drop table chitietgd_co_phieu
create table chitietgd_co_phieu
(
[Mã Giao Dịch] bigint  not null,
[Loại giao dịch] NvarChar(100) not null,
[Mã kinh doanh] nvarchar(100) not null,
[Số cổ phiếu giao dịch] bigint not null,
foreign key ([Mã kinh doanh])
	references congty([Mã kinh doanh]),
foreign key ([Mã Giao Dịch])
	references lichsu_cty([Mã Giao Dịch]),
primary key ([Mã Giao Dịch],[Mã kinh doanh])
)

--drop table chitietgd_nguoi_dung
create table chitietgd_nguoi_dung
(
[Mã Giao Dịch] bigint identity(10000000,1) not null,
[Tên tài khoản nhận] nvarchar(160) not null,
[Số tiền giao dịch] bigint not null,
[Ngày giao dịch] datetime2 not null,
foreign key ([Tên tài khoản nhận])
	references nguoidung([Tên tài khoản]),
foreign key ([Mã Giao Dịch])
	references lichsu_nd([Mã Giao Dịch]),
primary key ([Mã Giao Dịch],[Tên tài khoản nhận])
)


--drop table tongket
create table tongket
(
[Tên tài khoản] NvarChar(160) not null,
[Mã kinh doanh] NvarChar(100) not null,
[Số cổ phiếu] bigint not null,
foreign key ([Tên tài khoản])
	references nguoidung([Tên tài khoản]),
foreign key ([Mã kinh doanh])
	references congty([Mã kinh doanh]),
constraint tg_k
primary key ([Tên tài khoản],[Mã kinh doanh])
)



SELECT DB_NAME() AS DataBaseName


select * from congty
select * from nguoidung
select * from tongket
select * from lichsu_nd
select * from lichsu_cty
select * from chitietgd_co_phieu
select * from chitietgd_nguoi_dung
