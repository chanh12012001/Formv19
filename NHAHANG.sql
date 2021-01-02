create database NHAHANG
USE NHAHANG
set dateformat dmy

create table NGUOIDUNG
(
	TaiKhoan varchar(20) primary key,
	MatKhau varchar(20),
)

insert into NGUOIDUNG values ('user1','123456789')
insert into NGUOIDUNG values ('user2','123456789')