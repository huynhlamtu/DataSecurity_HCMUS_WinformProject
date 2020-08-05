
CREATE USER admin_ABC IDENTIFIED BY 123;
grant dba to admin_ABC

-- Dang nhap bang user admin_ABC de tao db ?? 

-- tao bang thanh vien cty ABC
--drop table THANHVIEN CASCADE CONSTRAINTS;
create table THANHVIEN
(
    MATV number(5),
    DONVI number(2),
    HOTEN varchar2(30),
    PHAI varchar2(5),
    FLAG_VANG int,
    QUEQUAN varchar2(50),
    NGAYSINH date,
    QUOCTICH varchar2(20),
    DCTHUONGTRU varchar2(50),
    DCTAMTRU varchar2(50)
);

select * from thanhvien where matv = 1;

-- tao khoa ngoai
ALTER TABLE THANHVIEN
ADD CONSTRAINT PK_THANHVIEN
PRIMARY KEY (MATV);

-- tao bang Vai tro
--drop table VAITRO CASCADE CONSTRAINTS;
create table VAITRO
(
    MATV number(5),
    VAITRO varchar2(20),
    FLAG_TOTRUONG int,
    DVIPHUTRACH number(2)
);

-- tao khoa ngoai
ALTER TABLE VAITRO
ADD CONSTRAINT PK_VAITRO
PRIMARY KEY (MATV, VAITRO);

--drop table DONVI CASCADE CONSTRAINTS;
create table DONVI
(
    MADV number(2),
    TENDONVI varchar2(50)
);

-- tao khoa ngoai
ALTER TABLE DONVI
ADD CONSTRAINT PK_DONVI
PRIMARY KEY (MADV);

--drop table UNGCUVIEN CASCADE CONSTRAINTS;
create table UNGCUVIEN 
(
    MAUCV number(5),
    SOPHIEUBAU int
);

-- tao khoa ngoai
ALTER TABLE UNGCUVIEN
ADD CONSTRAINT PK_UNGCUVIEN
PRIMARY KEY (MAUCV);

--drop table BAUCU CASCADE CONSTRAINTS;
create table BAUCU
(
    MATV number(5),
    MAUCV_1 number(5),
    MAUCV_2 number(5),
    MAUCV_3 number(5)
);

-- tao khoa ngoai
ALTER TABLE BAUCU
ADD CONSTRAINT PK_BAUCU
PRIMARY KEY (MATV);


-- Them khoa ngoai

ALTER TABLE VAITRO
ADD CONSTRAINT FK_VAITRO_THANHVIEN
FOREIGN KEY (MATV)
REFERENCES THANHVIEN(MATV);


ALTER TABLE VAITRO
ADD CONSTRAINT FK_VAITRO_DONVI
FOREIGN KEY (DVIPHUTRACH)
REFERENCES DONVI(MADV);
    

ALTER TABLE THANHVIEN
ADD CONSTRAINT FK_THANHVIEN_DONVI
FOREIGN KEY (DONVI)
REFERENCES DONVI(MADV);


ALTER TABLE UNGCUVIEN
ADD CONSTRAINT FK_UNGCUVIEN_THANHVIEN
FOREIGN KEY (MAUCV)
REFERENCES THANHVIEN(MATV);


ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_THANHVIEN
FOREIGN KEY (MATV)
REFERENCES THANHVIEN(MATV);


ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_UNGCUVIEN_1
FOREIGN KEY (MAUCV_1)
REFERENCES UNGCUVIEN(MAUCV);


ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_UNGCUVIEN_2
FOREIGN KEY (MAUCV_2)
REFERENCES UNGCUVIEN(MAUCV);


ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_UNGCUVIEN_3
FOREIGN KEY (MAUCV_3)
REFERENCES UNGCUVIEN(MAUCV);


-- Them data
-- Them ds cac don vi
INSERT INTO DONVI (MADV,TENDONVI)
    SELECT 1,  'Chi nhanh'    FROM dual UNION ALL
    SELECT 2,  'Van phòng dai dien'    FROM dual UNION ALL
    SELECT 3,  'Dia diem kinh doanh'    FROM dual ;

-- Them ds thanh vien
INSERT INTO THANHVIEN (MATV, DONVI, HOTEN, PHAI, FLAG_VANG, QUEQUAN, NGAYSINH, QUOCTICH, DCTHUONGTRU, DCTAMTRU)
    SELECT 1,   1,  'Y ELI NIE', 'Nam',  'Dak Lak',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Dak Lak',  'TP HCM'    FROM dual UNION ALL
    SELECT 2,   2,  'Nguyen Van Toan', 'Nam',  'Hai Phong',  TO_DATE('02/01/2019','DD/MM/YYYY'),    'Viet Nam', 'Hai Phong',  'TP HCM'    FROM dual UNION ALL
    SELECT 3,   3,  'Bui Tien Dung', 'Nam',  'Dak Lak',  TO_DATE('02/01/2019','DD/MM/YYYY'),    'Viet Nam', 'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 4,   1,  'Truong Van Thai Quy', 'Nam',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 5,   2,  'Nguyen Quang Hai', 'Nam',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 6,   3,  'Nguyen Thanh Chung', 'Nam',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 7,   1,  'Tran Dinh Trong', 'Nam',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 8,   2,  'Bui Hoang Viet Anh', 'Nam',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 9,   3,  'Bui Tien Dung', 'Nam',  'Da Nang',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Da Nang',  'TP HCM'    FROM dual UNION ALL
    SELECT 10,   1,  'Ho Tan Tai', 'Nam',  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 11,   1,  'Nguyen Duc Chien', 'Nam',  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 12,   2,  'Le Ngoc Bao', 'Nam',  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 13,   2,  'Huynh Tan Sinh', 'Nam',  'Quang Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Quang Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 14,   2,  'Vo Thanh Thinh', 'Nam',  'Da Nang',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Da Nang',  'TP HCM'    FROM dual UNION ALL
    SELECT 15,   3,  'Tran Thanh Son', 'Nam',  'Gia Lai',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Gia Lai',  'TP HCM'    FROM dual UNION ALL
    SELECT 16,   3,  'Trieu Viet Hung', 'Nam',  'Gia Lai',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Gia Lai',  'TP HCM'    FROM dual UNION ALL
    SELECT 17,   3,  'Nguyen Trong Dai', 'Nam',  'Nghe An',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Nghe An',  'TP HCM'    FROM dual UNION ALL
    SELECT 18,   2,  'Nguyen Hoang Duc', 'Nam',  'Nghe An',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Nghe An',  'TP HCM'    FROM dual UNION ALL
    SELECT 19,   1,  'Nguyen Huu Thang', 'Nam',  'Nghe An',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Nghe An',  'TP HCM'    FROM dual UNION ALL
    SELECT 20,   2,  'Nguyen Trong Hung', 'Nam',  'Thanh Hoa',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Thanh Hoa',  'TP HCM'    FROM dual UNION ALL
    SELECT 21,   3,  'Ha Duc Chinh', 'Nam',  'Da Nang',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Da Nang',  'TP HCM'    FROM dual UNION ALL
    SELECT 22,   1,  'Nguyen Tien Linh', 'Nam',  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 23,   3,  'Tran Bao Toan', 'Nam',  'Gia Lai',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Gia Lai',  'TP HCM'    FROM dual UNION ALL
    SELECT 24,   1,  'Nham Manh Dung', 'Nam',  'Dak Lak',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Dak Lak',  'TP HCM'    FROM dual UNION ALL
    SELECT 25,   2,  'Nguyen Thi Tuyet Dung', 'Nu',  'Hà Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Hà Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 26,   1,  'Chuong Thi Kieu', 'Nu',  'TP HCM',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 27,   1,  'Nguyen Thi Bich Thuy', 'Nu',  'TP HCM',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam',   'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 28,   1,  'Huynh Nhu', 'Nu',  'TP HCM',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 29,   2,  'Hoang Thi Loan', 'Nu',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 30,   1,  'Vo Thi Nhung', 'Nu',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'   FROM dual UNION ALL
    SELECT 31,   1,  'Thai Thi Thao', 'Nu',  'Quang Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Quang Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 32,   1,  'Pham Hai Yen', 'Nu',  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 33,   1,  'Nguyen Thi Xuyen', 'Nu',  'Quang Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Quang Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 34,   1,  'Nguyen Thi Van', 'Nu',  'Thanh Hoa',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Thanh Hoa',  'TP HCM'    FROM dual UNION ALL
    SELECT 35,   1,  'Pham Thi Tuoi', 'Nu',  'Hà Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Hà Nam',  'TP HCM'    FROM dual;

-- Them 2 nguoi trong ban to chuc
INSERT INTO VAITRO (MATV,VAITRO,FLAG_TOTRUONG,DVIPHUTRACH)
    SELECT 1,  'Ban to chuc',   1,  null    FROM dual UNION ALL
    SELECT 2,  'Ban to chuc',   0,  null    FROM dual UNION ALL
    SELECT 3,  'To lap danh sach',   1,  null    FROM dual UNION ALL
    SELECT 34,  'To lap danh sach',   0,  null    FROM dual UNION ALL
    SELECT 35,  'To lap danh sach',   0,  null    FROM dual UNION ALL
    SELECT 4,  'To theo doi',   1,  null    FROM dual UNION ALL
    SELECT 5,  'To theo doi',   0,  null    FROM dual UNION ALL
    SELECT 6,  'To giam sat',   0,  null    FROM dual UNION ALL
    SELECT 33,  'To giam sat',   1,  null    FROM dual;

--select tv.hoten, tv.matv, vaitro, flag_totruong, dviphutrach
--from vaitro v, thanhvien tv
--where v.matv = tv.matv
--order by vaitro

-- Them ung cu vien
INSERT INTO UNGCUVIEN (MAUCV,SOPHIEUBAU)
    SELECT 7,  11    FROM dual UNION ALL
    SELECT 8,   9    FROM dual UNION ALL
    SELECT 9,   5    FROM dual UNION ALL
    SELECT 32,  7    FROM dual UNION ALL
    SELECT 31,  7    FROM dual;
    
SELECT * FROM UNGCUVIEN;
    
INSERT INTO BAUCU (MATV,MAUCV_1,MAUCV_2,MAUCV_3)
    SELECT 10,   7,  8,   31   FROM dual UNION ALL
    SELECT 11,   7,  8,   32   FROM dual UNION ALL
    SELECT 12,   8,  9,   31   FROM dual UNION ALL
    SELECT 13,   7,  8,   9   FROM dual UNION ALL
    SELECT 14,   7,  9,   32   FROM dual UNION ALL
    SELECT 17,   9,  31,   8   FROM dual UNION ALL
    SELECT 19,   7,  31,   32   FROM dual UNION ALL
    SELECT 20,   31,  8,   7   FROM dual UNION ALL
    SELECT 21,   7,  8,   32   FROM dual UNION ALL
    SELECT 23,   7,  9,   32   FROM dual UNION ALL
    SELECT 24,   8,  31,   7   FROM dual UNION ALL
    SELECT 27,   7,  31,   32   FROM dual UNION ALL
    SELECT 29,   7,  8,   32   FROM dual;
    
SELECT * FROM BAUCU;


--drop table USER_LOGIN CASCADE CONSTRAINTS;
create table USER_LOGIN
(
    username varchar2(20),
    pass_word varchar2(20),
    Role_ABC varchar2(10)
);

ALTER TABLE USER_LOGIN
ADD CONSTRAINT PK_USER_LOGIN
PRIMARY KEY (username);

INSERT INTO USER_LOGIN (username,pass_word, Role_ABC)
    SELECT 'BTC_Ad', '123', 'BTC'   FROM dual UNION ALL
    SELECT 'BTC_1', '123', 'BTC'   FROM dual UNION ALL
    SELECT 'LDS_1', '123', 'LDS'   FROM dual UNION ALL
    SELECT 'LDS_2', '123', 'LDS'   FROM dual UNION ALL
    SELECT 'LDS_3', '123', 'LDS'   FROM dual UNION ALL
    SELECT 'THEODOI_1', '123', 'THEODOI'   FROM dual UNION ALL
    SELECT 'THEODOI_2', '123', 'THEODOI'   FROM dual UNION ALL
    SELECT 'GIAMSAT_1', '123', 'THEODOI'   FROM dual UNION ALL
    SELECT 'GIAMSAT_2', '123', 'THEODOI'   FROM dual ;
    
select * from USER_LOGIN where username = 'BTC_Ad' and pass_word = '123'

grant select on USER_LOGIN to btc_ad;