CREATE DATABASE QLTTN
go

use QLTTN
go

CREATE TABLE NguoiDung
(
	manguoidung varchar(10) PRIMARY KEY NOT NULL
)

CREATE TABLE giaoVien (
    ma varchar(10) PRIMARY KEY,
    ten varchar(255),
	ngaySinh datetime,
	FOREIGN KEY (ma) REFERENCES NguoiDung(manguoidung)
)
go	

CREATE TABLE khoi (
    ma varchar(10) PRIMARY KEY,
    ten varchar(255)
)
go

CREATE TABLE lop (
    ma varchar(10) PRIMARY KEY,
    ten varchar(255),
    GVCN varchar(10),
	makhoi varchar (10),
    siSo int,
	FOREIGN KEY (GVCN) REFERENCES giaoVien(ma),
	FOREIGN KEY (maKhoi) REFERENCES khoi(ma)
)
go



CREATE TABLE hocSinh (
    ma varchar(10)  PRIMARY KEY,
    ten varchar(255),
    ngaySinh datetime,
    maLop varchar(10),
    maKhoi varchar(10),
	FOREIGN KEY (maLop) REFERENCES lop(ma),
	FOREIGN KEY (maKhoi) REFERENCES khoi(ma),
	FOREIGN KEY (ma) REFERENCES NguoiDung(manguoidung)
)
go




CREATE TABLE adminn (
    ma varchar(10) PRIMARY KEY,
	ten varchar(255),
	ngaySinh datetime,
	FOREIGN KEY (ma) REFERENCES NguoiDung(manguoidung)
)
go



CREATE TABLE taiKhoan (
    username varchar(255),
    _password varchar(255),
    idNguoiSoHuu varchar(10),
	PRIMARY KEY (username, _password),
	FOREIGN KEY (idNguoiSoHuu) REFERENCES NguoiDung(manguoidung)
)
go



CREATE TABLE monHoc (
    ma varchar(10) PRIMARY KEY ,
    ten nvarchar(255)
)
go


CREATE TABLE cauHoi (
    ma varchar(10)  PRIMARY KEY ,
	noiDung nvarchar(2000),
	goiY nvarchar(500),
	doKho nvarchar(10),
	maMonHoc  varchar(10),
	makhoi varchar (10),
	loaiCauHoi nvarchar(50),--'THI' / 'LUYENTAP'
	FOREIGN KEY (maKhoi) REFERENCES khoi(ma),
	FOREIGN KEY (maMonHoc) REFERENCES monHoc (ma)
)
go

CREATE TABLE cauHoiLuyentap (
    maCauHoi varchar(10)  PRIMARY KEY,
	daDuocDuyet int, --1 DADUYET/ 0 CHUA ( câu nào giáo viên duyệt mà không đồng ý câu đó thì xóa luôn)
	FOREIGN KEY (maCauHoi) REFERENCES cauHoi(ma)
)
go


create table dapAnCauhoi(
	maCauHoi varchar (10) ,
	dapAn nvarchar(2000),
	laDapAnDung int,
	PRIMARY KEY (maCauHoi,dapAn),
	FOREIGN KEY (maCauHoi) REFERENCES cauHoi(ma)
)
go



CREATE TABLE kyThi (
    ma varchar(10) PRIMARY KEY,
	maMonHoc varchar(10),
	FOREIGN KEY (maMonHoc) REFERENCES monHoc (ma)
)
go	

CREATE TABLE kyThiChinhThuc (
    maKyThi varchar(10) PRIMARY KEY,
	ngayDienRa datetime,
	FOREIGN KEY (maKyThi) REFERENCES kyThi(ma),
)
go	

CREATE TABLE kyThiThu (
    maKyThi varchar(10) PRIMARY KEY,
	ngayGioiHan datetime,
	FOREIGN KEY (maKyThi) REFERENCES kyThi(ma)
)
go	

CREATE TABLE deThi (
    ma varchar(10)  PRIMARY KEY,
	slCauHoi int,
	maMonHoc  varchar(10),
	thoiGianLamBai_phut int,
	FOREIGN KEY (maMonHoc) REFERENCES monHoc (ma),
)
go

CREATE TABLE chiTietDethi(
    maDethi varchar(10),
	maCauHoi varchar(10),
	diem float,-- diem từng câu hỏi trong đề thi.
	PRIMARY KEY (maDethi,maCauHoi),
	FOREIGN KEY (maCauHoi) REFERENCES cauHoi(ma),
	FOREIGN KEY (maDethi) REFERENCES deThi(ma)
)
go

CREATE TABLE thamGiaKyThi (
    maHs varchar(10),
	maKyThi varchar (10),
    maDe varchar(10),
	PRIMARY KEY (maHs, maKyThi,maDe),
	FOREIGN KEY (maHs) REFERENCES hocSinh(ma),
	FOREIGN KEY (maKyThi) REFERENCES kyThi(ma),
	FOREIGN KEY (maDe) REFERENCES deThi(ma)
)
go	




CREATE TABLE ketQua (
    maHs varchar(10),
    maDe varchar(10),
	maKythi varchar(10),
	soCauDung int,
	diem float,-- điểm sinh viên đạt được.
	PRIMARY KEY (maHs, maDe, maKythi),
	FOREIGN KEY (maHs) REFERENCES hocSinh(ma),
	FOREIGN KEY (maKyThi) REFERENCES kyThi(ma),
	FOREIGN KEY (maDe) REFERENCES deThi(ma)
)
go	

CREATE TABLE chiTietBaiThi (
    maHs varchar(10),
    maDe varchar(10),
	maKythi varchar(10),
	maCauHoi varchar(10),
	dung_Sai int,
	PRIMARY KEY (maHs, maDe, maKythi, maCauHoi),
	FOREIGN KEY (maHs) REFERENCES hocSinh(ma),
	FOREIGN KEY (maKyThi) REFERENCES kyThi(ma),
	FOREIGN KEY (maDe) REFERENCES deThi(ma),
	FOREIGN KEY (maCauHoi) REFERENCES cauHoi(ma)
)
go	


CREATE TABLE tinhTrangBaiLam(
    maHs varchar(10),
    maDe varchar(10),
	maKythi varchar(10),
	diem int,
	thoiGianUpdate datetime ,
	PRIMARY KEY (mahs, maDe, maKythi),
	FOREIGN KEY (maHs) REFERENCES hocSinh(ma),
	FOREIGN KEY (maKyThi) REFERENCES kyThi(ma),
	FOREIGN KEY (maDe) REFERENCES deThi(ma)
)
go	
