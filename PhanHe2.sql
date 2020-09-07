
-------------- Tao user admin_ABC va gan role dba cho admin_ABC bang session sys ---------------
alter session set "_ORACLE_SCRIPT"=true;
CREATE USER admin_ABC IDENTIFIED BY 123;
grant create session to public;
grant dba to admin_ABC;

--------------------Tao bang thanh vien cty ABC --------------------
--drop table THANHVIEN CASCADE CONSTRAINTS;
create table THANHVIEN
(
    MATV int,
    DONVI int,
    HOTEN varchar2(30),
    PHAI varchar2(5),
    FLAG_VANG int,
    QUEQUAN varchar2(50),
    NGAYSINH date,
    QUOCTICH varchar2(20),
    DCTHUONGTRU varchar2(50),
    DCTAMTRU varchar2(50)
);

-------------------- Tao khoa ngoai --------------------
ALTER TABLE THANHVIEN
ADD CONSTRAINT PK_THANHVIEN
PRIMARY KEY (MATV);

-------------------- Tao bang Vai tro --------------------
-- drop table VAITRO CASCADE CONSTRAINTS;
create table VAITRO
(
    MATV int,
    VAITRO varchar2(20),
    FLAG_TOTRUONG int,
    DVIPHUTRACH int
);

select * from vaitro

-------------------- Tao khoa ngoai --------------------
ALTER TABLE VAITRO
ADD CONSTRAINT PK_VAITRO
PRIMARY KEY (MATV, VAITRO);

-- drop table DONVI CASCADE CONSTRAINTS;
create table DONVI
(
    MADV int,
    TENDONVI varchar2(50)
);

-------------------- Tao khoa ngoai --------------------
ALTER TABLE DONVI
ADD CONSTRAINT PK_DONVI
PRIMARY KEY (MADV);

-- drop table UNGCUVIEN CASCADE CONSTRAINTS;
create table UNGCUVIEN 
(
    MAUCV int,
    SOPHIEUBAU int,
    MATV int
);

-------------------- Tao khoa ngoai --------------------
ALTER TABLE UNGCUVIEN
ADD CONSTRAINT PK_UNGCUVIEN
PRIMARY KEY (MAUCV);


-- drop table BAUCU CASCADE CONSTRAINTS;
create table BAUCU
(
    MABAUCU int,
    MATV int,
    MAUCV_1 int,
    MAUCV_2 int,
    MAUCV_3 int
);

-- drop table USER_LOGIN CASCADE CONSTRAINTS;
create table USER_LOGIN
(
    owner_member int,
    username varchar2(20),
    pass_word varchar2(20),
    Role_ABC varchar2(10)
);

ALTER TABLE USER_LOGIN
ADD CONSTRAINT PK_USER_LOGIN
PRIMARY KEY (owner_member, username);

-------------------- Tao khoa ngoai
ALTER TABLE BAUCU
ADD CONSTRAINT PK_BAUCU
PRIMARY KEY (MABAUCU);

-------------------- Them khoa ngoai
ALTER TABLE VAITRO
ADD CONSTRAINT FK_VAITRO_THANHVIEN
FOREIGN KEY (MATV)
REFERENCES THANHVIEN(MATV)
ON DELETE CASCADE;

ALTER TABLE VAITRO
ADD CONSTRAINT FK_VAITRO_DONVI
FOREIGN KEY (DVIPHUTRACH)
REFERENCES DONVI(MADV)
ON DELETE CASCADE;
    
ALTER TABLE THANHVIEN
ADD CONSTRAINT FK_THANHVIEN_DONVI
FOREIGN KEY (DONVI)
REFERENCES DONVI(MADV)
ON DELETE CASCADE;

ALTER TABLE UNGCUVIEN
ADD CONSTRAINT FK_UNGCUVIEN_THANHVIEN
FOREIGN KEY (MATV)
REFERENCES THANHVIEN(MATV)
ON DELETE CASCADE;

ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_THANHVIEN
FOREIGN KEY (MATV)
REFERENCES THANHVIEN(MATV)
ON DELETE CASCADE;

ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_UNGCUVIEN_1
FOREIGN KEY (MAUCV_1)
REFERENCES UNGCUVIEN(MAUCV)
ON DELETE CASCADE;

ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_UNGCUVIEN_2
FOREIGN KEY (MAUCV_2)
REFERENCES UNGCUVIEN(MAUCV)
ON DELETE CASCADE;

ALTER TABLE BAUCU
ADD CONSTRAINT FK_BAUCU_UNGCUVIEN_3
FOREIGN KEY (MAUCV_3)
REFERENCES UNGCUVIEN(MAUCV)
ON DELETE CASCADE;

ALTER TABLE USER_LOGIN
ADD CONSTRAINT FK_USER_LOGIN_THANHVIEN
FOREIGN KEY (owner_member)
REFERENCES THANHVIEN(MATV)
ON DELETE CASCADE;

-------------------- Them data --------------------
-------------------- Them ds cac don vi --------------------
INSERT INTO DONVI (MADV,TENDONVI)
    SELECT 1,  'Chi nhanh'    FROM dual UNION ALL
    SELECT 2,  'Van phòng dai dien'    FROM dual UNION ALL
    SELECT 3,  'Dia diem kinh doanh'    FROM dual ;

-- Them ds thanh vien
INSERT INTO THANHVIEN (MATV, DONVI, HOTEN, PHAI, FLAG_VANG, QUEQUAN, NGAYSINH, QUOCTICH, DCTHUONGTRU, DCTAMTRU)
    SELECT 1,   1,  'Y ELI NIE', 'Nam', 0,  'Dak Lak',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Dak Lak',  'TP HCM'    FROM dual UNION ALL
    SELECT 2,   2,  'Nguyen Van Toan', 'Nam', 0,  'Hai Phong',  TO_DATE('02/01/2019','DD/MM/YYYY'),    'Viet Nam', 'Hai Phong',  'TP HCM'    FROM dual UNION ALL
    SELECT 3,   3,  'Bui Tien Dung', 'Nam', 0,  'Dak Lak',  TO_DATE('02/01/2019','DD/MM/YYYY'),    'Viet Nam', 'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 4,   1,  'Truong Van Thai Quy', 'Nam', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 5,   2,  'Nguyen Quang Hai', 'Nam', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 6,   3,  'Nguyen Thanh Chung', 'Nam', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 7,   1,  'Tran Dinh Trong', 'Nam', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 8,   2,  'Bui Hoang Viet Anh', 'Nam', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 9,   3,  'Bui Tien Dung', 'Nam', 0,  'Da Nang',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Da Nang',  'TP HCM'    FROM dual UNION ALL
    SELECT 10,   1,  'Ho Tan Tai', 'Nam', 0,  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 11,   1,  'Nguyen Duc Chien', 'Nam', 0,  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 12,   2,  'Le Ngoc Bao', 'Nam', 0,  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 13,   2,  'Huynh Tan Sinh', 'Nam', 0,  'Quang Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Quang Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 14,   2,  'Vo Thanh Thinh', 'Nam', 0,  'Da Nang',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Da Nang',  'TP HCM'    FROM dual UNION ALL
    SELECT 15,   3,  'Tran Thanh Son', 'Nam', 0,  'Gia Lai',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Gia Lai',  'TP HCM'    FROM dual UNION ALL
    SELECT 16,   3,  'Trieu Viet Hung', 'Nam', 1,  'Gia Lai',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Gia Lai',  'TP HCM'    FROM dual UNION ALL
    SELECT 17,   3,  'Nguyen Trong Dai', 'Nam', 0,  'Nghe An',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Nghe An',  'TP HCM'    FROM dual UNION ALL
    SELECT 18,   2,  'Nguyen Hoang Duc', 'Nam', 1,  'Nghe An',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Nghe An',  'TP HCM'    FROM dual UNION ALL
    SELECT 19,   1,  'Nguyen Huu Thang', 'Nam', 0,  'Nghe An',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Nghe An',  'TP HCM'    FROM dual UNION ALL
    SELECT 20,   2,  'Nguyen Trong Hung', 'Nam', 1,  'Thanh Hoa',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Thanh Hoa',  'TP HCM'    FROM dual UNION ALL
    SELECT 21,   3,  'Ha Duc Chinh', 'Nam', 0,  'Da Nang',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Da Nang',  'TP HCM'    FROM dual UNION ALL
    SELECT 22,   1,  'Nguyen Tien Linh', 'Nam', 0,  'Binh Duong',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Binh Duong',  'TP HCM'    FROM dual UNION ALL
    SELECT 23,   3,  'Tran Bao Toan', 'Nam', 0,  'Gia Lai',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Gia Lai',  'TP HCM'    FROM dual UNION ALL
    SELECT 24,   1,  'Nham Manh Dung', 'Nam', 0,  'Dak Lak',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Dak Lak',  'TP HCM'    FROM dual UNION ALL
    SELECT 25,   2,  'Nguyen Thi Tuyet Dung', 'Nu', 0,  'Hà Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Hà Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 26,   1,  'Chuong Thi Kieu', 'Nu', 0,  'TP HCM',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 27,   1,  'Nguyen Thi Bich Thuy', 'Nu', 0,  'TP HCM',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam',   'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 28,   1,  'Huynh Nhu', 'Nu', 1,  'TP HCM',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'TP HCM',  'TP HCM'    FROM dual UNION ALL
    SELECT 29,   2,  'Hoang Thi Loan', 'Nu', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 30,   1,  'Vo Thi Nhung', 'Nu', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'   FROM dual UNION ALL
    SELECT 31,   1,  'Thai Thi Thao', 'Nu', 0,  'Quang Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Quang Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 32,   1,  'Pham Hai Yen', 'Nu', 0,  'Ha Noi',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Ha Noi',  'TP HCM'    FROM dual UNION ALL
    SELECT 33,   1,  'Nguyen Thi Xuyen', 'Nu', 0,  'Quang Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Quang Nam',  'TP HCM'    FROM dual UNION ALL
    SELECT 34,   1,  'Nguyen Thi Van', 'Nu', 0,  'Thanh Hoa',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Thanh Hoa',  'TP HCM'    FROM dual UNION ALL
    SELECT 35,   2,  'Pham Thi Tuoi', 'Nu', 0,  'Hà Nam',  TO_DATE('02/01/2019','DD/MM/YYYY'),     'Viet Nam', 'Hà Nam',  'TP HCM'    FROM dual;

INSERT INTO VAITRO (MATV,VAITRO,FLAG_TOTRUONG,DVIPHUTRACH)
    SELECT 1,  'Ban to chuc',   1,  null    FROM dual UNION ALL
    SELECT 2,  'Ban to chuc',   0,  null    FROM dual UNION ALL
    SELECT 3,  'To lap danh sach',   1,  1    FROM dual UNION ALL
    SELECT 34,  'To lap danh sach',   0,  2    FROM dual UNION ALL
    SELECT 35,  'To lap danh sach',   0,  3    FROM dual UNION ALL
    SELECT 4,  'To theo doi',   1,  null    FROM dual UNION ALL
    SELECT 5,  'To theo doi',   0,  null    FROM dual UNION ALL
    SELECT 6,  'To giam sat',   0,  null    FROM dual UNION ALL
    SELECT 33,  'To giam sat',   1,  null    FROM dual;

-------------------- Them ung cu vien --------------------
INSERT INTO UNGCUVIEN (MAUCV,SOPHIEUBAU,MATV)
    SELECT 1 ,  11 ,  7   FROM dual UNION ALL
    SELECT 2 ,   9,   8    FROM dual UNION ALL
    SELECT 3 ,   5,   9    FROM dual UNION ALL
    SELECT 4 ,  7,   32    FROM dual UNION ALL
    SELECT 5 ,  7,   31    FROM dual;

    
INSERT INTO BAUCU (MABAUCU,MATV,MAUCV_1,MAUCV_2,MAUCV_3)
    SELECT 1,     10,   1,  2,   5   FROM dual UNION ALL
    SELECT 2,     11,   1,  2,   4   FROM dual UNION ALL
    SELECT 3,     12,   2,  3,   5   FROM dual UNION ALL
    SELECT 4,     13,   1,  2,   3   FROM dual UNION ALL
    SELECT 5,     14,   1,  3,   4   FROM dual UNION ALL
    SELECT 6,     17,   3,  5,   2   FROM dual UNION ALL
    SELECT 7,     19,   1,  5,   4   FROM dual UNION ALL
    SELECT 8,     20,   5,  2,   1   FROM dual UNION ALL
    SELECT 9,     21,   1,  2,   4   FROM dual UNION ALL
    SELECT 10,    23,   1,  3,   4   FROM dual UNION ALL
    SELECT 11,    24,   2,  5,   1   FROM dual UNION ALL
    SELECT 12,    27,   1,  5,   4   FROM dual UNION ALL
    SELECT 13,    29,   1,  2,   4   FROM dual;

INSERT INTO USER_LOGIN (owner_member, username, pass_word, Role_ABC)
    SELECT 1, 'TV01', '1', 'BTC'   FROM dual UNION ALL
    SELECT 2, 'TV02', '2', 'BTC'   FROM dual UNION ALL
    SELECT 3, 'TV03', '3', 'LDS'   FROM dual UNION ALL
    SELECT 34, 'TV34', '34', 'LDS'   FROM dual UNION ALL
    SELECT 35, 'TV35', '35', 'LDS'   FROM dual UNION ALL
    SELECT 4, 'TV04', '4', 'THEODOI'   FROM dual UNION ALL
    SELECT 5, 'TV05', '5', 'THEODOI'   FROM dual UNION ALL
    
    SELECT 6, 'TV06', '6', 'GIAMSAT'   FROM dual UNION ALL
    SELECT 33, 'TV33', '33', 'GIAMSAT'   FROM dual UNION ALL
    SELECT 7, 'TV07', '7', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 8, 'TV08', '8', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 9, 'TV09', '9', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 10, 'TV10', '10', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 11, 'TV11', '11', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 12, 'TV12', '12', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 13, 'TV13', '13', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 14, 'TV14', '14', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 15, 'TV15', '15', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 16, 'TV16', '16', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 17, 'TV17', '17', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 18, 'TV18', '18', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 19, 'TV19', '19', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 20, 'TV20', '20', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 21, 'TV21', '21', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 22, 'TV22', '22', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 23, 'TV23', '23', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 24, 'TV24', '24', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 25, 'TV25', '25', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 26, 'TV26', '26', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 27, 'TV27', '27', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 28, 'TV28', '28', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 29, 'TV29', '29', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 30, 'TV30', '30', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 31, 'TV31', '31', 'THANHVIEN'   FROM dual UNION ALL
    SELECT 32, 'TV32', '32', 'THANHVIEN'   FROM dual;

-------------------------- proc xac thuc dang nhap ------------------------------
create or replace procedure users_login ( para_username varchar2, para_pass_word varchar2, para_hoten out varchar2, para_role out varchar2)
as
begin
    select ul.role_abc, tv.hoten into para_role, para_hoten from admin_abc.user_login ul, admin_abc.thanhvien tv
    where ul.username = para_username and pass_word = para_pass_word and tv.matv = ul.owner_member;
end;

select * from thanhvien

DECLARE
    amount varchar2(20);
    amount2 varchar2(20);
BEGIN
    users_login('TV01', '1', amount, amount2);
    dbms_output.put_line(amount);
    dbms_output.put_line(amount2);
END;

------------------------ proc xoa vaitro -------------------------------------
create or replace procedure del_roler( para_matv int, para_vaitro varchar2, para_role varchar2)
as
    para_username varchar2(30);
begin
    select username into para_username from user_login where owner_member = para_matv;
    
    DELETE
    FROM admin_abc.vaitro
    WHERE matv = para_matv and para_vaitro = vaitro;

    execute IMMEDIATE('revoke ' || para_role || ' from ' || para_username);
    
    execute IMMEDIATE('grant R_THANHVIEN to ' || para_username);
    
    update admin_abc.user_login
    set role_abc = 'THANHVIEN'
    where owner_member = para_matv;
end;

------------------------ proc xoa vaitro cua to lap danh sach -------------------------------------
create or replace procedure del_roler_lds( para_matv int, para_donvi int)
as
    para_username varchar2(30);
begin
    select username into para_username from user_login where owner_member = para_matv;
    
    DELETE
    FROM admin_abc.vaitro
    WHERE matv = para_matv and vaitro = 'To lap danh sach';
    
    if para_donvi = 1 then
        execute IMMEDIATE('revoke select on view_lapds_to1 from ' || para_username);
    elsif para_donvi = 2 then
        execute IMMEDIATE('revoke select on view_lapds_to2 from ' || para_username);
    else
        execute IMMEDIATE('revoke select on view_lapds_to3 from ' || para_username);
    end if;
    execute IMMEDIATE('grant R_THANHVIEN to ' || para_username);
    
    update admin_abc.user_login
    set role_abc = 'THANHVIEN'
    where owner_member = para_matv;
end;

-------------------- proc them vaitro --------------------
create or replace procedure add_roler(para_matv int, para_vaitro varchar2, para_role varchar2, para_flag int)
as
para_username varchar2(30);
begin
    select username into para_username from user_login where owner_member = para_matv;
    
    INSERT INTO admin_abc.vaitro (matv,vaitro,flag_totruong,dviphutrach)
    SELECT para_matv, para_vaitro, para_flag, null    FROM dual;
    
    execute IMMEDIATE('grant ' || para_role || ' to ' || para_username);
    
    update admin_abc.user_login
    set role_abc = para_role
    where owner_member = para_matv;
end;

-------------------- proc them vaitro To lap danh sach --------------------
create or replace procedure add_roler_lds(para_matv int, para_flag int, para_donvi int)
as
para_username varchar2(30);
begin
    select username into para_username from user_login where owner_member = para_matv;
    
    INSERT INTO admin_abc.vaitro (matv,vaitro,flag_totruong,dviphutrach)
    SELECT para_matv, 'To lap danh sach', para_flag, para_donvi    FROM dual;
    
    if para_donvi = 1 then
        execute IMMEDIATE('grant select on view_lapds_to1 to ' || para_username);
    elsif para_donvi = 2 then
        execute IMMEDIATE('grant select on view_lapds_to2 to ' || para_username);
    else
        execute IMMEDIATE('grant select on view_lapds_to3 to ' || para_username);
    end if;
    
    update admin_abc.user_login
    set role_abc = 'LDS'
    where owner_member = para_matv;
end;

-------------------- proc them ungcuvien --------------------
create or replace procedure add_ucv(para_matv int)
as
para_maucv int;
begin
    select max(maucv) + 1 into para_maucv 
    from admin_abc.ungcuvien;
    
    INSERT INTO admin_abc.ungcuvien (maucv, sophieubau, matv)
    SELECT para_maucv, 0, para_matv    FROM dual;
end;

-------------------- proc xoa ungcuvien --------------------
create or replace procedure del_ucv(para_maucv int)
as
begin
    DELETE
    FROM admin_abc.ungcuvien
    where maucv = para_maucv;
end;

-------------------- proc kiem tra ton tai thanh vien --------------------
create or replace procedure check_exist_member(para_matv number, para_name varchar2, para_check out number)
as
begin
    select count(*) into para_check
    from admin_abc.thanhvien
    where matv = para_matv and hoten = para_name;
end;

-------------------- proc kiem tra ton tai to truong cua 1 To --------------------
create or replace procedure check_exist_totruong(para_role varchar2, para_check out number)
as
begin
    select count(*) into para_check
    from admin_abc.vaitro
    where vaitro = para_role and flag_totruong = 1;
end;

-------------------- proc kiem tra 1 don vi da co nguoi nhan lap danh sach --------------------
create or replace procedure check_dvi_lds(para_dvi number, para_check out number)
as
begin
    select count(*) into para_check
    from admin_abc.vaitro
    where dviphutrach = para_dvi;
end;

-------------------- proc xuat ra don vi nguoi lap danh sach dang dam nhan --------------------
create or replace procedure get_dvi_lds(para_matv number, para_dvi out number)
as
begin
    select dviphutrach into para_dvi
    from admin_abc.vaitro
    where matv = para_matv;
end;

-------------------- proc kiem tra 1 ma thanh vien co match voi vai tro --------------------
create or replace procedure check_matv_role(para_matv number, para_role varchar2, para_check out number)
as
begin
    select count(*) into para_check
    from admin_abc.vaitro
    where matv = para_matv and vaitro = para_role;
end;

-------------------- proc kiem tra 1 ma thanh vien da tung bau cu lan nao --------------------
create or replace procedure check_da_baucu(para_matv number, para_check out number)
as
begin
    select count(*) into para_check
    from admin_abc.baucu
    where matv = para_matv;
end;

select * from ungcuvien;

-------------------- proc lay thong tin 1 thanh vien trong to vai tro --------------------
create or replace procedure get_roler(para_matv number, para_name out varchar2, para_role out varchar2, para_flag out number, para_dvi out number)
as
begin
    select tv.hoten, vt.vaitro, vt.flag_totruong, vt.dviphutrach into para_name, para_role, para_flag, para_dvi
    from admin_abc.vaitro vt, admin_abc.thanhvien tv
    where vt.matv = para_matv and tv.matv = vt.matv;
end;

-------------------- proc bau cu --------------------
create or replace procedure proc_baucu(para_matv int, para_ucv1 int, para_ucv2 int, para_ucv3 int)
as
para_maphieubau int; para_ucv_old1 int; para_ucv_old2 int; para_ucv_old3 int;
begin
    select max(MABAUCU) + 1 into para_maphieubau from admin_abc.BAUCU;
        
            INSERT INTO admin_abc.BAUCU (MABAUCU,MATV,MAUCV_1,MAUCV_2,MAUCV_3)
            values (para_maphieubau, para_matv, para_ucv1, para_ucv2, para_ucv3);
            
            update admin_abc.UNGCUVIEN
            set SOPHIEUBAU = SOPHIEUBAU + 1
            where maucv = para_ucv1 or maucv = para_ucv2 or maucv = para_ucv3;
end;
/

BEGIN
    proc_baucu(25, 1, 2, 5);
END;

select * from baucu;

-------------------- proc thay doi lua chon bau cu --------------------
create or replace procedure proc_baucu_edit(para_matv int, para_ucv1 int, para_ucv2 int, para_ucv3 int)
as
para_ucv_old1 int; para_ucv_old2 int; para_ucv_old3 int;
begin
    select baucu.maucv_1, baucu.maucv_2, baucu.maucv_3 into para_ucv_old1, para_ucv_old2, para_ucv_old3
    from baucu
    where baucu.matv = para_matv;

    update admin_abc.UNGCUVIEN
    set SOPHIEUBAU = SOPHIEUBAU - 1
    where maucv = para_ucv_old1 or maucv = para_ucv_old2 or maucv = para_ucv_old3;

    update admin_abc.BAUCU
    set MAUCV_1 = para_ucv1, MAUCV_2 = para_ucv2, MAUCV_3 = para_ucv3
    where matv = para_matv;
    
    update admin_abc.UNGCUVIEN
    set SOPHIEUBAU = SOPHIEUBAU + 1
    where maucv = para_ucv1 or maucv = para_ucv2 or maucv = para_ucv3;
end;
/

------------------------- VPD ------------------------------
--create or replace function sec_function (p_schema varchar2, p_obj varchar2)
--return varchar2
--as
--user varchar2(100);
--begin
--if (sys_context(`userenv`,`ISDBA`)) then return ``;
--else
  --  (user:= sys_context(`userenv`,`session_user`)
   -- return `MATV = ` || user;
--end if;
--end;

                            ------------------------------- #TC01 -------------------------------
                            --------------------- Tao ngu canh cho #TC01 ------------------------

create package set_emp_env is
    procedure set set_job_position is
    jp varchar(100);
    begin 
        select VAITRO into jp from VAITRO
        where MATV = sys_context ('USERENV','SESSION_USER');
        DBMS_SESSION.SET_CONTEXT ('emp_env','VAITRO',jp);
        end;
    end;

create context emp_env using emp_env_context;
    
create or replace trigger Emp_trig
after logon on database
    begin
        emp_env_context.set_job_position;
    end;
    
------------------------------------
create or replace function #TC01 (p_schema varchar2, p_obj varchar2)
return varchar2
as
begin
    if(SYS_CONTEXT('emp_env','vaitro')='Ban to chuc')
        return '';
    else
        return '1=0';
    end if;
end;

execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'UNG CU VIEN',
    policy_name => 'fuction1',
    policy_function => '#TC01',
    statement_types => 'select, update, insert',
    update_check => TRUE
)

                            ------------------------------- #TC02 -------------------------------
                            --------------------- Tao ngu canh cho #TC02 ------------------------
                            
create package set_emp_env2 is
    procedure set set_job_position2 is
    dvpt varchar(100);
    begin 
        select VAITRO into jp from VAITRO
        where MATV = sys_context ('USERENV','SESSION_USER');
        DBMS_SESSION.SET_CONTEXT ('emp_env2','DVIPHUTRACH',dvpt);
        end;
    end;

create context emp_env2 using emp_env2_context;
    
create or replace trigger Emp_trig2
after logon on database
    begin
        emp_env2_context.set_job_position2;
    end;

create or replace function #TC02_DV (p_schema varchar2, p_obj varchar2)
return varchar2
as
begin
    if(SYS_CONTEXT('emp_env','DVIPHUTRACH')='1')
        return 'DONVI=1';
    else if (SYS_CONTEXT('emp_env','DVIPHUTRACH')='2')
        return 'DONVI=2';
    else if (SYS_CONTEXT('emp_env','DVIPHUTRACH')='3')
        return 'DONVI=3';
    end if;
end;

create or replace function #TC02 (p_schema varchar2, p_obj varchar2)
return varchar2
as
begin
    if(SYS_CONTEXT('emp_env','vaitro')='To lap danh sach')
        return '';
    else
        return '1=0';
    end if;
end;

execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'THANH VIEN',
    policy_name => 'fuction2',
    policy_function => '#TC02',
    statement_types => 'select'
)

execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'THANH VIEN',
    policy_name => 'fuction2_dv',
    policy_function => '#TC02_DV',
    statement_types => 'select'
)


                            ------------------------------- #TC03 -------------------------------
                            --------------------- Tao ngu canh cho #TC03 ------------------------
    
create or replace function #TC03 (p_schema varchar2, p_obj varchar2)
return varchar2
as
begin
    if(SYS_CONTEXT('emp_env','vaitro')='To theo doi')
        return '';
    else
        return '1=0';
    end if;
end;


execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'BAU CU',
    policy_name => 'fuction3',
    policy_function => '#TC03',
    statement_types => 'select'
)

                                ------------------------------- #TC04 -------------------------------
                                ----------------------- Tao ngu canh cho TC#04 ------------------------

create or replace function #TC04 (p_schema varchar2, p_obj varchar2)
return varchar2
as
begin
    if(SYS_CONTEXT('emp_env','vaitro')='To giam sat')
        return '';
    else
        return '1=0';
    end if;
end;


execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'BAU CU',
    policy_name => 'fuction4',
    policy_function => '#TC04',
    statement_types => 'select'
)

execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'VAI TRO',
    policy_name => 'fuction4',
    policy_function => '#TC04',
    statement_types => 'select'
)


execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'THANH VIEN',
    policy_name => 'fuction4',
    policy_function => '#TC04',
    statement_types => 'select'
)

execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'DON VI',
    policy_name => 'fuction4',
    policy_function => '#TC04',
    statement_types => 'select'
)

execute dbms_rls.add_function
(
    object_schema => 'system',
    object_name => 'UNG CU VIEN',
    policy_name => 'fuction4',
    policy_function => '#TC04',
    statement_types => 'select'
)

-------------------- DAC - RBAC --------------------
alter session set "_ORACLE_SCRIPT"=true;
CREATE USER TV01 IDENTIFIED BY 1;
CREATE USER TV02 IDENTIFIED BY 2;
CREATE USER TV03 IDENTIFIED BY 3;
CREATE USER TV04 IDENTIFIED BY 4;
CREATE USER TV05 IDENTIFIED BY 5;
CREATE USER TV06 IDENTIFIED BY 6;
CREATE USER TV07 IDENTIFIED BY 7;
CREATE USER TV08 IDENTIFIED BY 8;
CREATE USER TV09 IDENTIFIED BY 9;
CREATE USER TV10 IDENTIFIED BY 10;
CREATE USER TV11 IDENTIFIED BY 11;
CREATE USER TV12 IDENTIFIED BY 12;
CREATE USER TV13 IDENTIFIED BY 13;
CREATE USER TV14 IDENTIFIED BY 14;
CREATE USER TV15 IDENTIFIED BY 15;
CREATE USER TV16 IDENTIFIED BY 16;
CREATE USER TV17 IDENTIFIED BY 17;
CREATE USER TV18 IDENTIFIED BY 18;
CREATE USER TV19 IDENTIFIED BY 19;
CREATE USER TV20 IDENTIFIED BY 20;
CREATE USER TV21 IDENTIFIED BY 21;
CREATE USER TV22 IDENTIFIED BY 22;
CREATE USER TV23 IDENTIFIED BY 23;
CREATE USER TV24 IDENTIFIED BY 24;
CREATE USER TV25 IDENTIFIED BY 25;
CREATE USER TV26 IDENTIFIED BY 26;
CREATE USER TV27 IDENTIFIED BY 27;
CREATE USER TV28 IDENTIFIED BY 28;
CREATE USER TV29 IDENTIFIED BY 29;
CREATE USER TV30 IDENTIFIED BY 30;
CREATE USER TV31 IDENTIFIED BY 31;
CREATE USER TV32 IDENTIFIED BY 32;
CREATE USER TV33 IDENTIFIED BY 33;
CREATE USER TV34 IDENTIFIED BY 34;
CREATE USER TV35 IDENTIFIED BY 35;

                            -----------------------------------------------------------------------------------------------------
                            ----------------------------- Tao Role va gan quyen cho cac user Thanh vien ----------------------------
CREATE ROLE R_THANHVIEN;

create view view_ds_ucv as
select maucv from admin_abc.ungcuvien;

grant select on view_ds_ucv to R_THANHVIEN;

grant execute on CHECK_DA_BAUCU to R_THANHVIEN;

grant execute on proc_baucu to R_THANHVIEN;

select * from ungcuvien;

grant execute on proc_baucu_edit to R_THANHVIEN;

grant R_THANHVIEN to TV01;
grant R_THANHVIEN to TV02;
grant R_THANHVIEN to TV03;
grant R_THANHVIEN to TV04;
grant R_THANHVIEN to TV05;
grant R_THANHVIEN to TV06;
grant R_THANHVIEN to TV07;
grant R_THANHVIEN to TV08;
grant R_THANHVIEN to TV09;
grant R_THANHVIEN to TV10;
grant R_THANHVIEN to TV11;
grant R_THANHVIEN to TV12;
grant R_THANHVIEN to TV13;
grant R_THANHVIEN to TV14;
grant R_THANHVIEN to TV15;
grant R_THANHVIEN to TV16;
grant R_THANHVIEN to TV17;
grant R_THANHVIEN to TV18;
grant R_THANHVIEN to TV19;
grant R_THANHVIEN to TV20;
grant R_THANHVIEN to TV21;
grant R_THANHVIEN to TV22;
grant R_THANHVIEN to TV23;
grant R_THANHVIEN to TV24;
grant R_THANHVIEN to TV25;
grant R_THANHVIEN to TV26;
grant R_THANHVIEN to TV27;
grant R_THANHVIEN to TV28;
grant R_THANHVIEN to TV29;
grant R_THANHVIEN to TV30;
grant R_THANHVIEN to TV31;
grant R_THANHVIEN to TV32;
grant R_THANHVIEN to TV33;
grant R_THANHVIEN to TV34;
grant R_THANHVIEN to TV35;

                            -----------------------------------------------------------------------------------------------------
                            ----------------------------- Tao Role va gan quyen cho cac user thuoc Ban to chuc ----------------------------
CREATE ROLE BTC;

create view show_list_vaitro as
select vt.matv, tv.hoten, vaitro, flag_totruong, dviphutrach
from ADMIN_ABC.vaitro vt, ADMIN_ABC.thanhvien tv
where vt.matv = tv.matv order by vt.vaitro

create view show_list_ungcuvien as
select uv.maucv, uv.matv, tv.hoten, uv.sophieubau
from admin_abc.thanhvien tv, admin_abc.ungcuvien uv
where tv.matv = uv.maucv

grant select on show_list_vaitro to BTC;

grant select on show_list_ungcuvien to BTC;

grant select, insert, update on UNGCUVIEN TO BTC;

grant select, insert, update on vaitro TO BTC;

grant execute on del_roler to BTC;

grant execute on del_roler_lds to BTC;

grant execute on add_roler to BTC;

grant execute on add_roler_lds to BTC;

grant execute on get_dvi_lds to BTC;

grant execute on add_ucv to BTC;

grant execute on del_ucv to BTC;

grant execute on check_exist_member to BTC;

grant execute on check_exist_totruong to BTC;

grant execute on check_dvi_lds to BTC;

grant execute on check_matv_role to BTC;

grant execute on proc_baucu to BTC;

grant execute on proc_baucu_edit to BTC;

grant execute on get_roler to BTC;

grant BTC to TV01;
grant BTC to TV02;

select vt.dviphutrach from vaitro vt, user_login ul where ul.owner_member = vt.matv and ul.username = 'TV03';

                            -----------------------------------------------------------------------------------------------------------------
                            ----------------------------- Tao view va gan quyen cho cac user thuoc To lap danh sach -------------------------

CREATE VIEW view_lapds_to1 AS 
SELECT MATV, DONVI,HOTEN,PHAI,QUEQUAN,NGAYSINH,QUOCTICH,DCTHUONGTRU,DCTAMTRU
FROM THANHVIEN
WHERE DONVI= '1' AND FLAG_VANG='0';

CREATE VIEW view_lapds_to2 AS 
SELECT MATV, DONVI,HOTEN,PHAI,QUEQUAN,NGAYSINH,QUOCTICH,DCTHUONGTRU,DCTAMTRU
FROM THANHVIEN
WHERE DONVI= '2' AND FLAG_VANG='0';

CREATE VIEW view_lapds_to3 AS 
SELECT MATV, DONVI,HOTEN,PHAI,QUEQUAN,NGAYSINH,QUOCTICH,DCTHUONGTRU,DCTAMTRU
FROM THANHVIEN
WHERE DONVI= '3' AND FLAG_VANG='0';

grant select on view_lapds_to1 to TV03;
grant select on view_lapds_to2 to TV34;
grant select on view_lapds_to3 to TV035;

select * from user_login;
select * from vaitro;

                            -----------------------------------------------------------------------------------------------------------------
                            ----------------------------- Tao view va gan quyen cho cac user thuoc to Theo doi ------------------------------
create role THEODOI;

CREATE VIEW view_theodoi_kq AS 
SELECT ucv.maucv, tv.hoten, ucv.sophieubau
FROM UNGCUVIEN ucv, thanhvien tv
where ucv.matv = tv.matv;

create view chuadibau_list
as
select admin_abc.thanhvien.matv, admin_abc.thanhvien.hoten
from admin_abc.thanhvien
where not exists (select null
				  from admin_abc.baucu
				  where admin_abc.baucu.matv = admin_abc.thanhvien.matv);
				  
create view dadibau_list
as
select admin_abc.thanhvien.matv, admin_abc.thanhvien.hoten
from admin_abc.thanhvien
where exists (select null
				  from admin_abc.baucu
				  where admin_abc.baucu.matv = admin_abc.thanhvien.matv);

-------------------- Gan quyen select view cho Role to theo doi --------------------

grant select on view_theodoi_kq to THEODOI;

grant select on chuadibau_list to THEODOI;

grant select on dadibau_list to THEODOI;

-------------------- Gan Role To theo cho user thuoc to theo doi --------------------
grant THEODOI to TV04;
grant THEODOI to TV05;

                            ----------------------------------------------------------------------------------------
                            ---------------------- Tao Role va gan quyen cac user thuoc To giam sat ----------------
create role GIAMSAT;

-------------------- Gan quyen cho Role to Giam sat --------------------
grant select on THANHVIEN to GIAMSAT;
grant select on DONVI to GIAMSAT;
grant select on VAITRO to GIAMSAT;
grant select on UNGCUVIEN to GIAMSAT;
grant select on BAUCU to GIAMSAT;
--revoke select on USER_LOGIN from GIAMSAT;

-------------------- Gan Role To giam sat cho user thuoc to giam sat --------------------
grant GIAMSAT to TV06;
grant GIAMSAT to TV33;