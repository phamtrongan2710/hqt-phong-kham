﻿IF NOT EXISTS (SELECT NAME FROM SYS.DATABASES WHERE NAME = 'DBConferenceSearching')
BEGIN
    CREATE DATABASE phongkham
END
GO

USE phongkham
GO


/*
	DELETE ALL TABLES AND CONSTRAINTS
*/
DECLARE @Sql NVARCHAR(500) 
DECLARE @Cursor CURSOR

SET @Cursor = CURSOR FAST_FORWARD FOR
SELECT DISTINCT sql = 'ALTER TABLE [' + tc2.TABLE_SCHEMA + '].[' +  tc2.TABLE_NAME + '] \
					   DROP [' + rc1.CONSTRAINT_NAME + '];'
FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC1 
	 LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS TC2 
	 ON TC2.CONSTRAINT_NAME =RC1.CONSTRAINT_NAME

OPEN @Cursor FETCH NEXT FROM @Cursor INTO @Sql

WHILE (@@FETCH_STATUS = 0)
BEGIN
	EXEC sp_executesql @Sql
	FETCH NEXT FROM @Cursor INTO @Sql
END

CLOSE @Cursor DEALLOCATE @Cursor
GO

EXEC sp_MSforeachtable 'DROP TABLE ?'
GO



-- CREATE TABLES
GO
CREATE TABLE NHAN_VIEN(
	MANV VARCHAR(10) NOT NULL,
	HOTEN NVARCHAR(50) NOT NULL,
	SDT VARCHAR(15) CHECK (SDT LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
	EMAIL VARCHAR(30) CHECK ( EMAIL LIKE '%@gmail.com'),
	VAITRO NVARCHAR(30) NOT NULL,
	MATKHAU VARCHAR(30) NOT NULL,
	IS_ACTIVE INT,
	CONSTRAINT PK_NHAN_VIEN PRIMARY KEY (MANV)
);


GO
CREATE TABLE KHACH_HANG (
    MAKH VARCHAR(10) NOT NULL,
    HOTEN NVARCHAR(50) NOT NULL,
    NGAYSINH DATE,
    DIACHI NVARCHAR(100),
    SDT VARCHAR(15) CHECK (SDT LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
	MATKHAU VARCHAR(30) NOT NULL,
    CONSTRAINT PK_MAKH PRIMARY KEY (MAKH)
);


GO
CREATE TABLE THUOC(
	MATHUOC VARCHAR(10) NOT NULL,
	TENTHUOC VARCHAR(100) NOT NULL,
	DONVI NVARCHAR(20) NOT NULL,
	CHIDINH NVARCHAR(255) NOT NULL,
	SOLUONGTONKHO INT NOT NULL CHECK (SOLUONGTONKHO >= 0),  
	HANSD DATE,
	GIATIEN INT NOT NULL,
	CONSTRAINT PK_THUOC PRIMARY KEY (MATHUOC)
);



GO
CREATE TABLE DICH_VU(
	MADV VARCHAR(10) NOT NULL UNIQUE,
	TENDICHVU NVARCHAR(100),
	GIADICHVU INT NOT NULL,
	CONSTRAINT PK_DICH_VU PRIMARY KEY (MADV)
);


----------------Tables with foreign keys----------------------

GO
CREATE TABLE LICH_HEN
(
	MALICHHEN VARCHAR(10) NOT NULL,
	NGAYKHAM DATE,
	GIOKHAM TIME,
	NGUOIDAT VARCHAR(10) CHECK (NGUOIDAT = 'NS' OR NGUOIDAT = 'KH'),--to specify whether the dentist or the customer book this appointment
	MANHASI VARCHAR(10) NOT NULL,
	MAKH VARCHAR(10) NOT NULL,
	CONSTRAINT PK_LICHHEN PRIMARY KEY (MALICHHEN),

	CONSTRAINT FK_LICH_HEN_NHASI FOREIGN KEY (MANHASI) REFERENCES NHAN_VIEN(MANV),
	CONSTRAINT FK_LICH_HEN_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACH_HANG(MAKH)
);


GO
CREATE TABLE BENH_AN (
    MABA VARCHAR(10) NOT NULL,
    CHUANDOAN NVARCHAR(100),
    MALICHHEN VARCHAR(10) NOT NULL,
    MAKH VARCHAR(10) NOT NULL,
    MANHASI VARCHAR(10) NOT NULL,
	CONSTRAINT PK_BENH_AN PRIMARY KEY (MABA),

	CONSTRAINT FK_BENH_AN_NHASI FOREIGN KEY (MANHASI) REFERENCES NHAN_VIEN(MANV),
	CONSTRAINT FK_BENH_AN_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACH_HANG(MAKH),
	CONSTRAINT FK_BENH_AN_LICHHEN FOREIGN KEY (MALICHHEN) REFERENCES LICH_HEN(MALICHHEN)
);




GO
CREATE TABLE HOA_DON (
    MAHOADON VARCHAR(10) NOT NULL,
    NGAYXUAT DATE,
    TONGTIEN INT CHECK (TONGTIEN > 0),
    MABA VARCHAR(10) NOT NULL,

	CONSTRAINT PK_HOA_DON PRIMARY KEY (MAHOADON),
	CONSTRAINT FK_HOA_DON_BENHAN FOREIGN KEY (MABA) REFERENCES BENH_AN(MABA)
);




GO
CREATE TABLE BENHAN_DICHVU (
    MABA VARCHAR(10) NOT NULL,
    MADV VARCHAR(10) NOT NULL,
	CONSTRAINT PK_BENHAN_DICHVU PRIMARY KEY (MABA, MADV),

    CONSTRAINT FK_BENHAN_DICHVU_BENHAN FOREIGN KEY (MABA) REFERENCES BENH_AN(MABA),
    CONSTRAINT FK_BENHAN_DICHVU_DICHVU FOREIGN KEY (MADV) REFERENCES DICH_VU(MADV)
);



GO
CREATE TABLE BENHAN_THUOC (
	MABA VARCHAR(10) NOT NULL, 
	MATHUOC VARCHAR(10) NOT NULL, 
	SOLUONG INT NOT NULL CHECK (SOLUONG >= 0),
	CONSTRAINT PK_BENHAN_THUOC PRIMARY KEY (MABA, MATHUOC),

	CONSTRAINT FK_BENHAN_THUOC_BENHAN FOREIGN KEY (MABA) REFERENCES BENH_AN(MABA),
	CONSTRAINT FK_BENHAN_THUOC_THUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC(MATHUOC)
);


---------------------INSERT VALUES INTO TABLES--------------------
--NHAN VIEN
INSERT INTO NHAN_VIEN VALUES('NV001',N'Nguyễn Văn A', '123-123-1234','vanA@gmail.com',N'Nha sĩ','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV002',N'Nguyễn Thị B', '123-123-1234','trongan@gmail.com',N'Nha sĩ','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV003',N'Cà Ngọc Lân', '123-123-1234','trongan@gmail.com',N'Nha sĩ','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV004',N'Mầu Bình Nguyên', '123-123-1234','trongan@gmail.com',N'Nha sĩ','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV005',N'Lăng Thành Lợi', '123-123-1234','trongan@gmail.com',N'Nha sĩ','1', 1)

INSERT INTO NHAN_VIEN VALUES('NV006',N'Khuất Phước Nguyên', '123-123-1234','trongan@gmail.com',N'Nhân viên','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV007',N'Đăng Hữu Chiến', '123-123-1234','trongan@gmail.com',N'Nhân viên','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV008',N'Liên Hoài Phong', '123-123-1234','trongan@gmail.com',N'Nhân viên','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV009',N'Thôi Nam Thông', '123-123-1234','trongan@gmail.com','QTV','1', 1)
INSERT INTO NHAN_VIEN VALUES('NV0010',N'Kha Huy Khánh', '123-123-1234','trongan@gmail.com','QTV','1', 1)

--KHACH HANG
INSERT INTO KHACH_HANG VALUES('KH001',N'Điều Thành Ân','01-01-1990',N'Quận 1, TP Hồ Chí Minh', '123-123-1234','1');
INSERT INTO KHACH_HANG VALUES('KH002',N'Ngụy Thế Bình','01-01-1992',N'Quận 4, TP Hồ Chí Minh', '123-123-1234','1');
INSERT INTO KHACH_HANG VALUES('KH003',N'Cầm Quang Anh','02-01-1993',N'Quận 2, TP Hồ Chí Minh', '123-123-1234','1');
INSERT INTO KHACH_HANG VALUES('KH004',N'Ngọc Ðình Cường','05-01-1980',N'Quận Bình Thạnh, TP Hồ Chí Minh', '123-123-1234','1');
INSERT INTO KHACH_HANG VALUES('KH005',N'Lư Hữu Khôi','01-04-1994',N'Thủ Đức, TP Hồ Chí Minh', '123-123-1234','1');

--THUOC
INSERT INTO THUOC VALUES ('TH001','Paracetamol',N'viên',N'người lớn uống 2 viên, trẻ em không uống',1000,'01-01-2025',5000)
INSERT INTO THUOC VALUES ('TH002','Efferalgan',N'viên',N'Hòa tan trước khi uống',2000,'01-01-2025',10000)
INSERT INTO THUOC VALUES ('TH003','Aspirin',N'viên',N'người lớn uống 1 viên, trẻ em không uống',1000,'01-01-2025',5000)
INSERT INTO THUOC VALUES ('TH004','Methorphan ',N'mili lít',N'người lớn uống 10ml mỗi lần, trẻ em không uống',1000,'01-01-2025',5000)
INSERT INTO THUOC VALUES ('TH005','Prospan ',N'mili lít',N'người lớn uống 5ml trước bữa ăn, trẻ em không uống',1000,'01-01-2025',5000)


--DICH VU
INSERT INTO DICH_VU VALUES('DV001',N'Chụp X-quang','200000')
INSERT INTO DICH_VU VALUES('DV002',N'Chụp cắt lớp','300000')
INSERT INTO DICH_VU VALUES('DV003',N'Làm răng xứ','200000')
INSERT INTO DICH_VU VALUES('DV004',N'Nhổ chân răng','500000')
INSERT INTO DICH_VU VALUES('DV005',N'Trám răng sứ','20000')
INSERT INTO DICH_VU VALUES('DV006',N'Lấy tủy răng','250000')
INSERT INTO DICH_VU VALUES('DV007',N'Nhổ răng sữa','30000')


--LICH HEN
INSERT INTO LICH_HEN VALUES ('LH001','01-01-2023','13:30','NS','NV001','KH001')
INSERT INTO LICH_HEN VALUES ('LH002','02-01-2023','09:30','NS','NV002','KH003')
INSERT INTO LICH_HEN VALUES ('LH003','03-01-2023','10:30','NS','NV001','KH002')
INSERT INTO LICH_HEN VALUES ('LH004','04-01-2023','13:50','NS','NV003','KH004')
INSERT INTO LICH_HEN VALUES ('LH005','05-01-2023','13:30','NS','NV005','KH001')

--BENH AN
INSERT INTO BENH_AN VALUES ('BA001',N'sâu răng','LH001','KH001','NV001')
INSERT INTO BENH_AN VALUES ('BA002',N'gãy răng','LH002','KH001','NV002')
INSERT INTO BENH_AN VALUES ('BA003',N'hư răng','LH003','KH003','NV001')
INSERT INTO BENH_AN VALUES ('BA004',N'sâu răng','LH004','KH004','NV002')
INSERT INTO BENH_AN VALUES ('BA005',N'sâu răng','LH005','KH003','NV004')

--HOA DON
INSERT INTO HOA_DON VALUES('HD001','01-02-2023',5000000,'BA001')
INSERT INTO HOA_DON VALUES('HD002','02-02-2023',200000,'BA002')
INSERT INTO HOA_DON VALUES('HD003','03-02-2023',3500000,'BA003')
INSERT INTO HOA_DON VALUES('HD004','05-03-2023',6000000,'BA004')
INSERT INTO HOA_DON VALUES('HD005','06-04-2023',550000,'BA005')

--BENH AN DICH VU
INSERT INTO BENHAN_DICHVU VALUES('BA001','DV001')
INSERT INTO BENHAN_DICHVU VALUES('BA001','DV002')
INSERT INTO BENHAN_DICHVU VALUES('BA002','DV002')
INSERT INTO BENHAN_DICHVU VALUES('BA003','DV001')
INSERT INTO BENHAN_DICHVU VALUES('BA004','DV004')

--BENH AN THUOC
INSERT INTO BENHAN_THUOC VALUES('BA001','TH001',3)
INSERT INTO BENHAN_THUOC VALUES('BA001','TH002',4)
INSERT INTO BENHAN_THUOC VALUES('BA002','TH002',5)
INSERT INTO BENHAN_THUOC VALUES('BA003','TH001',6)
INSERT INTO BENHAN_THUOC VALUES('BA004','TH004',7)