/*
Team 10

Members:
1)  Full Name:  Nguyen Trung Kien
    StudentID:  18127010
    Email:      18127010@student.hcmus.edu.vn

2)  Full Name:  Tran Quoc Tuan
    StudentID:  18127246
    Email:      18127246@student.hcmus.edu.vn

3)  Full Name:  Dinh Phi Long
    StudentID:  18127263
    Email:      18127263@student.hcmus.edu.vn
*/

--------------------------------------------------------------------------------
--Set rule
alter session set "_ORACLE_SCRIPT"=true;
set serveroutput on
set wrap off

--------------------------------------------------------------------------------
--Create user sec_mgr as a dba
begin
    execute immediate 'drop user sec_mgr cascade';
exception
    when others then
        if SQLCODE != -1918 then raise;
        end if;
end;
/

create user sec_mgr identified by mgr;
grant all privileges to sec_mgr;
grant execute on dbms_rls to sec_mgr;
grant execute on dbms_utility to sec_mgr;
grant execute on dbms_session to sec_mgr;
grant execute on DBMS_CRYPTO to sec_mgr with grant option;
grant execute on DBMS_CRYPTO_FFI to sec_mgr with grant option;
grant all privileges on dba_role_privs to sec_mgr;
grant all privileges on dba_sys_privs to sec_mgr;
grant all privileges on dba_tab_privs to sec_mgr;
grant all privileges on dba_col_privs to sec_mgr;
grant all privileges on role_tab_privs to sec_mgr;
grant all privileges on dba_users to sec_mgr;
grant all privileges on dba_roles to sec_mgr;
grant audit system to sec_mgr;
grant audit any to sec_mgr;
grant select on DBA_AUDIT_TRAIL to sec_mgr;
grant select, delete on SYS.AUD$ to sec_mgr;
grant execute on DBMS_FGA to sec_mgr;
grant select on DBA_FGA_AUDIT_TRAIL to sec_mgr;
grant select, delete on SYS.FGA_LOG$ to sec_mgr;

--SELECT * FROM dba_tab_privs where grantee = UPPER('TaiVu');
--------------------------------------------------------------------------------
--Connect to sec_mgr
conn sec_mgr/mgr;
alter session set "_ORACLE_SCRIPT"=true;

--------------------------------------------------------------------------------
--Some Drop Function
create or replace procedure DropTable_IfExisted (tab_name varchar2) as
    begin
        execute immediate 'DROP TABLE ' || tab_name;
    exception
        when others then
            if SQLCODE != -942 then raise;
            end if;
    end;
/

create or replace procedure DropRole_IfExisted (role_name varchar2) as
    begin
        execute immediate 'DROP ROLE ' || role_name;
    exception
        when others then
            if SQLCODE != -1919 then raise;
            end if;
    end;
/

create or replace procedure DropUser_IfExisted (user_name varchar2) as
    begin
        execute immediate 'DROP USER ' || user_name;
    exception
        when others then
            if SQLCODE != -1918 then raise;
            end if;
    end;
/

create or replace procedure DropView_IfExisted (view_name varchar2) as
    begin
        execute immediate 'DROP VIEW ' || view_name;
    exception
        when others then
            if SQLCODE != -942 then raise;
            end if;
    end;
/

create or replace procedure DropProcedure_IfExisted (proc_name varchar2) as
    begin
        execute immediate 'DROP PROCEDURE ' || proc_name;
    exception
        when others then
            if SQLCODE != -4043 then raise;
            end if;
    end;
/

create or replace procedure DropFunction_IfExisted (func_name varchar2) as
    begin
        execute immediate 'DROP FUNCTION ' || func_name;
    exception
        when others then
            if SQLCODE != -4043 then raise;
            end if;
    end;
/

create or replace procedure DropTrigger_IfExisted (trig_name varchar2) as
    BEGIN
        EXECUTE IMMEDIATE 'DROP TRIGGER ' || trig_name;
    EXCEPTION
        WHEN OTHERS THEN
            IF SQLCODE != -4080 THEN RAISE;
            END IF;
END;
/

--------------------------------------------------------------------------------
--ChiTietHoaDon
exec DropTable_IfExisted ('ChiTietHoaDon');

create table ChiTietHoaDon
(
    MaHD int,
    MaKB int,
    MaDV int,
    
    constraint PK_ChiTietHoaDon primary key (MAHD, MaKB, MaDV)
);
/

--HoaDon
exec DropTable_IfExisted ('HoaDon');

create table HoaDon
(
    MaHD int,
    NgayLap date,
    TongTien int,
    NguoiLap varchar2(5),
    MaKB int,
    
    constraint PK_HoaDon primary key (MAHD)
);
/

-- ChiTietDonThuoc
exec DropTable_IfExisted ('ChiTietDonThuoc');

create table ChiTietDonThuoc
(
    MaKB int, 
    MaThuoc int,
    SoLuong varchar(32),
    LieuDung varchar2(72),
    MoTa varchar2(100),
    
    constraint PK_ChiTietDonThuoc primary key (MAKB, MaThuoc)
);
/

-- Thuoc
exec DropTable_IfExisted ('Thuoc');

create table Thuoc
(
    MaThuoc int,
    TenThuoc varchar2(30),
    DonViTinh varchar2(10),
    DonGia number(8,0),
    LuuY varchar2(30),
    
    constraint PK_Thuoc primary key (MaThuoc)
);
/

-- DonThuoc
exec DropTable_IfExisted ('DonThuoc');

create table DonThuoc
(
    MaKB int,
    NhanVienPhatThuoc varchar2(5),
    
    constraint PK_DonThuoc primary key (MAKB)
);
/

-- HoSoDichVu
exec DropTable_IfExisted ('HoSoDichVu');

create table HoSoDichVu
(
    MaKB int,
    MaDV int,
    NgayGio date,
    KetLuan varchar2(100),
    NguoiThucHien varchar2(5),
    
    constraint PK_HoSoDichVu primary key (MaKB, MaDV)
);
/

-- HoSoBenhAn
exec DropTable_IfExisted ('HoSoBenhAn');

create table HoSoBenhAn
(
    MaKB int,
    NgayKB date,
    TinhTrangBanDau varchar2(100),
    KetLuanBacSi varchar2(100),
    MaBN int,
    MaTT varchar2(5),
    MaBS varchar2(5),
    
    constraint PK_HoSoBenhAn primary key (MaKB)
);
/

--ChamCong
exec DropTable_IfExisted ('ChamCong');

create table ChamCong
(
    MaNV varchar2(5),
    TenPK varchar2(30),
    NgayTruc timestamp,
    
    constraint PK_ChamCong primary key (MaNV, TenPK)
);
/

-- NhanVien
exec DropTable_IfExisted ('NhanVien');

create table NhanVien
(
    MaNV varchar2(5),
    HoTenNV varchar2(30),
    DiaChi varchar2(100),
    SDT varchar2(40),
    LuongCoBan varchar2(32),
    MaKhoa int,
    MaPB int,
    
    constraint PK_NhanVien primary key (MaNV)
);
/

-- PhongBan
exec DropTable_IfExisted ('PhongBan');

create table PhongBan
(
    MaPB int,
    TenPB varchar2(30),
    
    constraint PK_PhongBan primary key (MaPB)
);
/

-- DichVu
exec DropTable_IfExisted ('DichVu');

create table DichVu
(
    MaDV int,
    TenDV varchar2(30),
    DonGia number(10,0),
    
    constraint PK_DichVu primary key (MaDV)
);
/

-- BenhNhan
exec DropTable_IfExisted ('BenhNhan');

create table BenhNhan
(
    MaBN int,
    HoTenBN varchar2(50),
    DiaChi varchar2(104),
    SDT varchar2(50),
    NamSinh varchar2(50),
    
    constraint PK_BenhNhan primary key (MaBN)
);
/

-- Khoa
exec DropTable_IfExisted ('Khoa');

create table Khoa
(
    MaKhoa int,
    TenKhoa varchar2(30),
    
    constraint PK_Khoa primary key (MaKhoa)
);
/

-- PhongKham
exec DropTable_IfExisted ('PhongKham');

create table PhongKham
(
    TenPK varchar2(30),
    MoTa varchar2(30),
    
    constraint PK_PhongKham primary key (TenPK)
);
/

--------------------------------------------------------------------------------
--FOREIGN KEY CONSTRAINT

alter table NhanVien 
add constraint FK_NhanVien_PhongBan 
foreign key (MaPB) references PhongBan(MaPB);

alter table NhanVien 
add constraint FK_NhanVien_Khoa
foreign key (MaKhoa) references Khoa(MaKhoa);

alter table ChamCong
add constraint FK_ChamCong_NhanVien
foreign key (MaNV) references NhanVien (MaNV);

alter table ChamCong
add constraint FK_ChamCong_PhongKham
foreign key (TenPK) references PhongKham (TenPK);

alter table HoSoBenhAn 
add constraint FK_HoSoBenhAn_BenhNhan 
foreign key (MaBN) references BenhNhan(MaBN);

alter table HoSoBenhAn 
add constraint FK_HoSoBenhAn_NhanVien 
foreign key (MaTT) references NhanVien(MaNV);

alter table HoSoBenhAn 
add constraint FK_HoSoBenhAn_BacSi 
foreign key (MaBS) references NhanVien(MaNV);

alter table HoSoDichVu 
add constraint FK_HoSoDichVu_HoSoBenhAn 
foreign key (MaKB) references HoSoBenhAn(MaKB);

alter table HoSoDichVu 
add constraint FK_HoSoDichVu_DichVu 
foreign key (MaDV) references DichVu(MaDV);

alter table HoSoDichVu 
add constraint FK_HoSoDichVu_NhanVien
foreign key (NguoiThucHien) references NhanVien(MaNV);

alter table DonThuoc 
add constraint FK_DonThuoc_HoSoBenhAn 
foreign key (MaKB) references HoSoBenhAn(MaKB);

alter table DonThuoc 
add constraint FK_DonThuoc_NhanVien 
foreign key (NhanVienPhatThuoc) references NhanVien(MaNV);

alter table ChiTietDonThuoc 
add constraint FK_ChiTietDonThuoc_HoSoBenhAn 
foreign key (MaKB) references HoSoBenhAn(MaKB);

alter table ChiTietDonThuoc 
add constraint FK_ChiTietDonThuoc_Thuoc 
foreign key (MaThuoc) references Thuoc(MaThuoc);

alter table HoaDon 
add constraint FK_HoaDon_HoSoBenhAn 
foreign key (MaKB) references HoSoBenhAn(MaKB);

alter table HoaDon 
add constraint FK_HoaDon_NhanVien 
foreign key (NguoiLap) references NhanVien(MaNV);

alter table ChiTietHoaDon
add constraint FK_ChiTietHoaDon_HoaDon 
foreign key (MaHD) references HoaDon(MaHD);

alter table ChiTietHoaDon
add constraint FK_ChiTietHoaDon_HoSoDichVu 
foreign key (MaKB, MaDV) references HoSoDichVu(MaKB, MaDV);

--------------------------------------------------------------------------------

--INSERT DATA FOR PhongKham
insert into PhongKham values ('A1', 'Khoa Tai mui hong');
insert into PhongKham values ('A2', 'Khoa Tai mui hong');
insert into PhongKham values ('A3', 'Khoa Rang Ham Mat');
insert into PhongKham values ('A4', 'Khoa Rang Ham Mat');
insert into PhongKham values ('A5', 'Kham Tong Quat');
insert into PhongKham values ('A6', 'Kham Tong Quat');

--INSERT DATA FOR Khoa
insert into Khoa values (1, 'Khoa Tai mui hong');
insert into Khoa values (2, 'Khoa Rang Ham Mat');

--INSERT DATA FOR BenhNhan
insert into BenhNhan values (1001, 'Vu Duc An', '113 An Phu, P8, Go Vap', '0226356987', '2000');
insert into BenhNhan values (1002, 'Nguyen Duc Phuc', '225 An Duong Vuong, P10, Q6', '0123456789', '1997');
insert into BenhNhan values (1003, 'Le Tien Dat', '227 Nguyen Thien Thuat, P5, Phu Nhuan', '0908561432', '1996');
insert into BenhNhan values (1004, 'Tat Thanh Sang', '325 Cong Hoa, P10, Tan Binh', '0123654879', '1997');
insert into BenhNhan values (1005, 'Tat Tang Toan', '665 Cong Hoa, P11, Tan Binh', '0123654879', '1990');

--INSERT DATA FOR DichVu
insert into DichVu values (2001, 'Kham Tong Quat', 50000);
insert into DichVu values (2002, 'Kham Benh BHYT', 34500);
insert into DichVu values (2003, 'Noi Soi', 200000);
insert into DichVu values (2004, 'Tram Rang Su', 200000);

--INSERT DATA FOR PhongBan
insert into PhongBan values (3001, 'Phong Nhan Su');
insert into PhongBan values (3002, 'Phong Tai Vu');
insert into PhongBan values (3003, 'Tiep Tan');
insert into PhongBan values (3004, 'Ke Toan');
insert into PhongBan values (3005, 'Quan Ly');

--INSERT DATA FOR NhanVien
insert into NhanVien values ('NS001', 'Dinh Van Luc', '252 Phan Chu Trinh, Ben Thanh, Q1', '0321456789', '8000000', null, 3001);
insert into NhanVien values ('NS002', 'Nguyen Dinh Thuc', '365 CMT8, P5, Q3', '0321456722', '8000000', null, 3001);
insert into NhanVien values ('TV001', 'Nguyen Ngoc Mai', '219 Nguyen Van Nghi, P11, Go Vap', '0333456789', '8000000', null, 3002);
insert into NhanVien values ('TV002', 'Tran Phi Hung', '552 Au Co, P5, Q3', '0213456722', '8000000', null, 3002);
insert into NhanVien values ('TT001', 'Hua Minh Thien', '325 Nguyen Van Nghi, P11, Go Vap', '0123623789', '8000000', null, 3003);
insert into NhanVien values ('TT002', 'Pham Quang Vu', '214 Lac Long Quan, P5, Q3', '0665456722', '8000000', null, 3003);
insert into NhanVien values ('KT001', 'Tran Ngoc Khanh Vy', '1183 Phan Huy Ich, P5, Go Vap', '0152634789', '10000000', null, 3004);
insert into NhanVien values ('KT002', 'Quach Phu Hien', '562 Hong Bang, P5, Phu Nhuan', '0344456722', '10000000', null, 3004);
insert into NhanVien values ('QLTV1', 'Tran Ngoc Vy Dan', '852 Nguyen Binh Khiem, P2, Q1', '0526489789', '12000000', null, 3005);
insert into NhanVien values ('QLTV2', 'La Thanh Long', '25 Truong Quoc Dung, P5, Phu Nhuan', '0111156722', '12000000', null, 3005);
insert into NhanVien values ('QLCM1', 'Tran Hai Yen', '5 Nguyen Binh Khiem, P2, Q1', '0396854789', '12000000', null, 3005);
insert into NhanVien values ('QLCM2', 'La Phuong Thanh', '45 Le Loi, P3, Q1', '0105268722', '12000000', null, 3005);

insert into NhanVien values ('BS001', 'Nguyen Quang Thien', '52 3 Thang 2, P5, Q5', '0122268722', '12000000', 1, null);
insert into NhanVien values ('BS002', 'Phan Ngoc Han', '46 Binh Trieu, P9, Q7', '0156268722', '12000000', 1, null);
insert into NhanVien values ('BS003', 'Dinh Phi Dung', '52 Khuc Thua Du, P5, Q5', '0365268722', '12000000', 2, null);
insert into NhanVien values ('BS004', 'Tran Quoc Khanh', '2 Dinh Tien Hoang, P15, Q1', '0198528722', '12000000', 2, null);

insert into NhanVien values ('BT001', 'Tran Tien An', '25 Khuc Thua Du, P5, Q5', '0568268722', '12000000', null, null);
insert into NhanVien values ('BT002', 'Pham Quang Thinh', '47 Dinh Tien Hoang, P15, Q1', '0198528722', '12000000', null, null);

--INSERT DATA FOR ChamCong
insert into ChamCong values ('BS001', 'A1', to_date('20-04-2021','dd/mm/yyyy'));
insert into ChamCong values ('BS002', 'A1', to_date('21-01-2021','dd/mm/yyyy'));
insert into ChamCong values ('BS003', 'A2', to_date('10-05-2021','dd/mm/yyyy'));
insert into ChamCong values ('BS004', 'A2', to_date('11-05-2021','dd/mm/yyyy'));

--INSERT DATA FOR HoSoBenhAn*
insert into HoSoBenhAn values (4001, to_date('20-05-2021','dd/mm/yyyy'), 'Sot nhe', 'Viem hong', 1001, 'TT001', 'BS001');
insert into HoSoBenhAn values (4002, to_date('21-05-2021','dd/mm/yyyy'), 'Dau tai', 'Viem tai', 1002, 'TT002', 'BS002');
insert into HoSoBenhAn values (4003, to_date('20-05-2021','dd/mm/yyyy'), 'Sot nang', 'Can theo doi them', 1002, 'TT001', 'BS002');
insert into HoSoBenhAn values (4004, to_date('21-05-2021','dd/mm/yyyy'), 'Cao huyet ap', 'Suc khoe tot', 1003, 'TT002', 'BS003');
insert into HoSoBenhAn values (4005, to_date('21-05-2021','dd/mm/yyyy'), 'Duong huyet', 'Can theo doi them', 1004, 'TT001', 'BS004');

--INSERT DATA FOR HoSoDichVu
insert into HoSoDichVu values (4001, 2002, to_date('20-05-2021','dd/mm/yyyy'), 'Can Noi Soi', 'BS001');
insert into HoSoDichVu values (4001, 2003, to_date('20-05-2021','dd/mm/yyyy'), 'Viem Amidan', 'BS002');
insert into HoSoDichVu values (4002, 2003, to_date('21-05-2021','dd/mm/yyyy'), 'Viem Tai', 'BS002');

--INSERT DATA FOR DonThuoc
insert into DonThuoc values (4001, 'BT001');
insert into DonThuoc values (4002, 'BT002');

--INSERT DATA FOR Thuoc
insert into Thuoc values (5001, 'blabla', 'Chai', 45000, null);
insert into Thuoc values (5002, 'MybaCin', 'Chai', 85000, null);
insert into Thuoc values (5003, 'Eryrothmisin', 'Chai', 75000, null);
insert into Thuoc values (5004, 'Amoxicillin', 'Chai', 75000, '90mg/kg/ngay - chia 2 lan');

--INSERT DATA FOR ChiTietDonThuoc
insert into ChiTietDonThuoc values (4001, 5001, 1, 'Ngam sau khi an', null);
insert into ChiTietDonThuoc values (4001, 5002, 1, 'Uong chung voi Dorithricin', null);
insert into ChiTietDonThuoc values (4001, 5003, 2, 'Ngam buoi toi', null);
insert into ChiTietDonThuoc values (4002, 5004, 1, '90mg/kg/ngay - chia 2 lan', null);

--INSERT DATA FOR HoaDon
insert into HoaDon values(6001, to_date('20-05-2021','dd/mm/yyyy'), 234500, 'TV001', 4001);
insert into HoaDon values(6002, to_date('21-05-2021','dd/mm/yyyy'), 200000, 'TV002', 4002);

--INSERT DATA FOR ChiTietHoaDon
insert into ChiTietHoaDon values (6001, 4001, 2002);
insert into ChiTietHoaDon values (6001, 4001, 2003);
insert into ChiTietHoaDon values (6002, 4002, 2003);

--------------------------------------------------------------------------------
--ENCRYPTION
CREATE OR REPLACE PACKAGE encrypt_decrypt
IS
    FUNCTION encrypt_data(p_data IN VARCHAR2)
        RETURN RAW DETERMINISTIC;
    FUNCTION decrypt_data(p_data IN RAW)
        RETURN VARCHAR2 DETERMINISTIC;
END;
/

CREATE OR REPLACE PACKAGE BODY encrypt_decrypt
IS
    encryption_type    PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_DES

                                     + DBMS_CRYPTO.CHAIN_CBC

                                     + DBMS_CRYPTO.PAD_PKCS5;
                                     
    v_key RAW(128) := utl_raw.cast_to_raw('nhom10');
    
    FUNCTION encrypt_data(p_data IN VARCHAR2)
        RETURN RAW DETERMINISTIC
    IS
        l_data RAW(2048) := utl_raw.cast_to_raw(p_data);
        l_encrypted RAW(2048);
    BEGIN
        l_encrypted := dbms_crypto.ENCRYPT(src => l_data,
            typ => encryption_type,
            key => v_key);
        RETURN l_encrypted;
    END encrypt_data;

    FUNCTION decrypt_data(p_data IN RAW)
        RETURN VARCHAR2 DETERMINISTIC
    IS
        l_decrypted RAW(2048);
    BEGIN
        l_decrypted := dbms_crypto.DECRYPT(src => p_data,
            typ => encryption_type,
            key => v_key);
        RETURN utl_raw.cast_to_varchar2(l_decrypted);
    END  decrypt_data;
END encrypt_decrypt;
/

grant execute on encrypt_decrypt to BacSi, NhanSu;

drop public synonym encrypt_decrypt force;
create public synonym encrypt_decrypt for sec_mgr.encrypt_decrypt;

exec DropTrigger_IfExisted('tr_EncryptBenhNhan');

create or replace trigger tr_EncryptBenhNhan
after insert
    on sec_mgr.BenhNhan
begin
    update sec_mgr.BenhNhan set SDT = encrypt_decrypt.encrypt_data(SDT) where MaBN = (select max(MaBN) from sec_mgr.BenhNhan);
    update sec_mgr.BenhNhan set DiaChi = encrypt_decrypt.encrypt_data(DiaChi) where MaBN = (select max(MaBN) from sec_mgr.BenhNhan);
end;
/

/*
exec DropTrigger_IfExisted('tr_EncryptNhanVien');

create or replace trigger tr_EncryptNhanVien
after insert
    on sec_mgr.NhanVien
begin
    update sec_mgr.NhanVien set SDT = encrypt_decrypt.encrypt_data(SDT) where MaBN = (select max(MaBN) from sec_mgr.NhanVien);
    update sec_mgr.NhanVien set DiaChi = encrypt_decrypt.encrypt_data(DiaChi);
    update sec_mgr.NhanVien set DiaChi = encrypt_decrypt.encrypt_data(DiaChi);
end;
/
*/

exec DropTrigger_IfExisted('tr_EncryptHSBA');

create or replace trigger tr_EncryptHSBA
after insert
    on sec_mgr.HoSoBenhAn
begin
    update sec_mgr.HoSoBenhAn set TinhTrangBanDau = encrypt_decrypt.encrypt_data(TinhTrangBanDau) where MaKB = (select max(MaKB) from sec_mgr.HoSoBenhAn);
    update sec_mgr.HoSoBenhAn set KetLuanBacSi = encrypt_decrypt.encrypt_data(KetLuanBacSi) where MaKB = (select max(MaKB) from sec_mgr.HoSoBenhAn);
end;
/

--------------------------------------------------------------------------------
--create roles
exec DropRole_IfExisted ('NhanSu');
create role NhanSu not identified;
exec DropRole_IfExisted ('TaiVu');
create role TaiVu not identified;
exec DropRole_IfExisted ('TiepTan');
create role TiepTan not identified;
exec DropRole_IfExisted ('KeToan');
create role KeToan not identified;
exec DropRole_IfExisted ('QuanLyTaiVu');
create role QuanLyTaiVu not identified;
exec DropRole_IfExisted ('QuanLyChuyenMon');
create role QuanLyChuyenMon not identified;
exec DropRole_IfExisted ('BacSi');
create role BacSi not identified;
exec DropRole_IfExisted ('BanThuoc');
create role BanThuoc not identified;
grant create session to BacSi, BanThuoc, NhanSu, TaiVu, TiepTan, KeToan, QuanLyTaiVu, QuanLyChuyenMon;

--------------------------------------------------------------------------------
--Create user
exec DropUser_IfExisted ('NS001');
create user NS001 identified by NS001 
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('NS002');
create user NS002 identified by NS002
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('TV001');
create user TV001 identified by TV001 
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('TV002');
create user TV002 identified by TV002
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('TT001');
create user TT001 identified by TT001 
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('TT002');
create user TT002 identified by TT002
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('KT001');
create user KT001 identified by KT001 
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('KT002');
create user KT002 identified by KT002
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('QLTV1');
create user QLTV1 identified by QLTV1 
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('QLTV2');
create user QLTV2 identified by QLTV2
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('QLCM1');
create user QLCM1 identified by QLCM1 
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('QLCM2');
create user QLCM2 identified by QLCM2
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('BS001');
create user BS001 identified by BS001
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('BS002');
create user BS002 identified by BS002
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('BS003');
create user BS003 identified by BS003
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('BS004');
create user BS004 identified by BS004
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('BT001');
create user BT001 identified by BT001
Default tablespace system 
Quota 10M on system;

exec DropUser_IfExisted ('BT002');
create user BT002 identified by BT002
Default tablespace system 
Quota 10M on system;

--------------------------------------------------------------------------------
--Grant role

grant NhanSu to NS001, NS002;
grant TaiVu to TV001, TV002;
grant TiepTan to TT001, TT002;
grant KeToan to KT001, KT002;
grant QuanLyTaiVu to QLTV1, QLTV2;
grant QuanLyChuyenMon to QLCM1, QLCM2;
grant BacSi to BS001, BS002, BS003, BS004;
grant BanThuoc to BT001, BT002;

--------------------------------------------------------------------------------
-- Grant priviledge to roles

-- Grant priviledges to role KeToan

grant select on ChamCong to KeToan;
grant select, update on NhanVien to KeToan;

-- Grant priviledges to role BanThuoc

grant select on DonThuoc to BanThuoc;

exec DropView_IfExisted ('ToaThuoc');

create or replace view ToaThuoc
as
    select NhanVienPhatThuoc, DonThuoc.MaKB, Thuoc.MaThuoc, TenThuoc, DonViTinh, DonGia, SoLuong, 
           LieuDung, LuuY
    from DonThuoc, Thuoc, ChiTietDonThuoc
    where DonThuoc.MaKB = ChiTietDonThuoc.MaKB 
          and ChiTietDonThuoc.MaThuoc = Thuoc.MaThuoc;
/

grant select on ToaThuoc to BanThuoc;

exec DropFunction_IfExisted ('Owner_BanThuoc');

create or replace function Owner_BanThuoc (p_schema in varchar2, p_object in varchar2)
    return varchar2
    as
        username varchar2(100);
        begin
            username := SYS_CONTEXT('userenv', 'session_user');
            if username = upper('sec_mgr') then
                return '1=1';
            else 
                if substr(username, 1, 2) = 'BT' then
                    return 'NhanVienPhatThuoc = USER';
                else
                    return '';
                end if;
            end if;
        end;
/

begin dbms_rls.add_policy
(
    object_schema => 'SEC_MGR',
    object_name   => 'DonThuoc',
    policy_name   => 'DoctorPrivilege',
    policy_function => 'Owner_BanThuoc',
    statement_types => 'SELECT',
    update_check  => True
);
end;
/

-- Grant privileges to role BacSi (VPD)
grant select on Thuoc to BacSi;
grant select on DichVu to BacSi;
grant select, insert, update on HoSoBenhAn to BacSi;
grant select on HoSoDichVu to BacSi;
grant select on DonThuoc to BacSi;
grant select on ChiTietDonThuoc to BacSi;
grant execute on DBMS_CRYPTO to BacSi;

exec DropFunction_IfExisted ('Owner');

create or replace function Owner (p_schema in varchar2, p_object in varchar2)
    return varchar2
    as
        username varchar2(100);
        begin
            username := SYS_CONTEXT('userenv', 'session_user');
            if username = upper('sec_mgr') then
                return '1=1';
            else 
                if substr(username, 1, 2) = 'BS' then
                    return 'HoSoBenhAn.MaBS = USER';
                else
                    return '';
                end if;
            end if;
        end;
/

begin dbms_rls.add_policy
(
    object_schema => 'SEC_MGR',
    object_name   => 'HoSoBenhAn',
    policy_name   => 'DoctorPrivilege',
    policy_function => 'Owner',
    statement_types => 'SELECT,UPDATE,INSERT',
    update_check  => True
);
end;
/

-- Grant privileges to role TaiVu

grant select, update, insert on HoaDon to TaiVu;
grant select, update on DichVu to TaiVu;

exec DropView_IfExisted ('CacDichVuCuaBenhNhan');
create or replace view CacDichVuCuaBenhNhan
as
    select HoSoBenhAn.MaKB, HoSoBenhAn.MaBN, HoTenBN, NgayKB, MaBS, HoSoDichVu.MaDV, TenDV, NgayGio, DonGia
    from HoSoBenhAn, HoSoDichVu, DichVu, BenhNhan
    where HoSoBenhAn.MaKB = HoSoDichVu.MaKB
          and HoSoDichVu.MaDV = DichVu.MaDV
          and HoSoBenhAn.MaBN = BenhNhan.MaBN;
/
grant select on CacDichVuCuaBenhNhan to TaiVu;

-- Grant privileges to TiepTan

grant select, insert, update, delete on BenhNhan to TiepTan;
grant select on PhongKham to TiepTan;
grant select on Khoa to TiepTan;

exec DropView_IfExisted ('DanhSachDichVu');
create or replace view DanhSachDichVu
as
    select MaDV, TenDV
    from DichVu;
/
grant select on DanhSachDichVu to TiepTan;

-- Grant privileges to QuanLyChuyenMon 
grant select on DichVu to QuanLyChuyenMon;
grant select on Thuoc to QuanLyChuyenMon;
grant select on PhongBan to QuanLyChuyenMon;
grant select on NhanVien to QuanLyChuyenMon;
grant select on ChamCong to QuanLyChuyenMon;
grant select on PhongKham to QuanLyChuyenMon;
grant select on Khoa to QuanLyChuyenMon;
grant select on BenhNhan to QuanLyChuyenMon;
grant select on HoSoBenhAn to QuanLyChuyenMon;
grant select on HoSoDichVu to QuanLyChuyenMon;
grant select on DonThuoc to QuanLyChuyenMon;
grant select on ChiTietDonThuoc to QuanLyChuyenMon;
grant select on HoaDon to QuanLyChuyenMon;
grant select on ChiTietHoaDon to QuanLyChuyenMon;

-- Grant privileges to QuanLyTaiVu

grant select, update, insert on DichVu to QuanLyTaiVu;
grant select, update, insert on Thuoc to QuanLyTaiVu;
grant select on PhongBan to QuanLyTaiVu;
grant select on NhanVien to QuanLyTaiVu;
grant select on ChamCong to QuanLyTaiVu;
grant select on PhongKham to QuanLyTaiVu;
grant select on Khoa to QuanLyTaiVu;
grant select on BenhNhan to QuanLyTaiVu;
grant select on HoSoBenhAn to QuanLyTaiVu;
grant select on HoSoDichVu to QuanLyTaiVu;
grant select on DonThuoc to QuanLyTaiVu;
grant select on ChiTietDonThuoc to QuanLyTaiVu;
grant select on HoaDon to QuanLyTaiVu;
grant select on ChiTietHoaDon to QuanLyTaiVu;

-- Grant privileges to NhanSu

grant insert, select, update, delete on PhongBan to NhanSu;
grant insert, select, update, delete on NhanVien to NhanSu;
grant insert, select, update, delete on ChamCong to NhanSu;
grant select on PhongKham to NhanSu;
grant select on Khoa to NhanSu;
grant select on BenhNhan to NhanSu;
grant select on DichVu to NhanSu;
grant select on HoSoBenhAn to NhanSu;
grant select on HoSoDichVu to NhanSu;
grant select on DonThuoc to NhanSu;
grant select on Thuoc to NhanSu;
grant select on ChiTietDonThuoc to NhanSu;
grant select on HoaDon to NhanSu;
grant select on ChiTietHoaDon to NhanSu;

--------------------------------------------------------------------------------
--AUDIT

alter system set audit_trail =db scope=SPFILE;
audit select table, update table by KT001, KT002;

create or replace procedure sp_Audit
as
    ptr sys_refcursor;
begin
    open ptr for
    select os_username,username, extended_timestamp, action_name, obj_name, priv_used, obj_privilege, 
        sys_privilege, admin_option
    from dba_audit_trail 
    where owner = upper('sec_mgr')
    order by extended_timestamp desc;
    
    dbms_sql.return_result(ptr);
end;
/


--------------------------------------------------------------------------------
--FGA

BEGIN
    DBMS_FGA.ADD_POLICY(
    object_schema => 'sec_mgr',
    object_name => 'ChamCong',
    policy_name => 'check_secmgr_chamcong', 
    audit_column => 'ngaytruc',
    statement_types=>'insert,update,delete,select');
END;
/

create or replace procedure sp_FGA
as
    ptr sys_refcursor;
begin
    open ptr for
    select extended_timestamp, OS_USER, DB_USER, USERHOST, OBJECT_NAME, 
        POLICY_NAME, SQL_TEXT, STATEMENT_TYPE
    from DBA_FGA_AUDIT_TRAIL;
    
    dbms_sql.return_result(ptr);
end;
/

--------------------------------------------------------------------------------
--DBA UI

CREATE OR REPLACE PROCEDURE sp_ViewUser
IS
    c_ViewUser  SYS_REFCURSOR;
BEGIN
    OPEN c_ViewUser FOR
        SELECT *
        FROM dba_users
        ORDER BY created;
    dbms_sql.return_result(c_ViewUser);
END;
/

-- View Table List
CREATE OR REPLACE PROCEDURE sp_ViewTable (tableowner in varchar2)
IS
    c_ViewUser  SYS_REFCURSOR;
BEGIN
    OPEN c_ViewUser FOR
        SELECT owner, table_name
        FROM all_tables
        where owner = upper(tableowner)
        ORDER BY table_name;
    dbms_sql.return_result(c_ViewUser);
END;
/

grant execute on sp_ViewTable to NhanSu;

create or replace procedure sp_KeToan(tableowner varchar2)
as
    c_ViewUser  SYS_REFCURSOR;
BEGIN
    OPEN c_ViewUser FOR
        SELECT distinct table_name
        FROM dba_tab_privs
        where owner = upper(tableowner) and grantee = 'KETOAN' and type = 'TABLE';
    dbms_sql.return_result(c_ViewUser);
END;
/

grant execute on sp_KeToan to KeToan;

create or replace procedure sp_TaiVu(tableowner varchar2)
as
    c_ViewUser  SYS_REFCURSOR;
BEGIN
    OPEN c_ViewUser FOR
        SELECT distinct table_name
        FROM dba_tab_privs
        where owner = upper(tableowner) and grantee = 'TAIVU' and (type = 'TABLE' or type = 'VIEW');
    dbms_sql.return_result(c_ViewUser);
END;
/

grant execute on sp_TaiVu to TaiVu;

create or replace procedure sp_TiepTan(tableowner varchar2)
as
    c_ViewUser  SYS_REFCURSOR;
BEGIN
    OPEN c_ViewUser FOR
        SELECT distinct table_name
        FROM dba_tab_privs
        where owner = upper(tableowner) and grantee = 'TIEPTAN' and (type = 'TABLE' or type = 'VIEW');
    dbms_sql.return_result(c_ViewUser);
END;
/

grant execute on sp_TiepTan to TiepTan;

create or replace procedure sp_TimBenhNhan(patient varchar2)
as
    c_ViewUser  SYS_REFCURSOR;
BEGIN
    OPEN c_ViewUser FOR
        SELECT *
        FROM BenhNhan
        where HoTenBN like '%' || patient || '%';
    dbms_sql.return_result(c_ViewUser);
END;
/

grant execute on sp_TimBenhNhan to TiepTan;

create or replace procedure sp_Bang_BacSi
IS
    c_SysRole  SYS_REFCURSOR;
BEGIN
    OPEN c_SysRole FOR
        SELECT DISTINCT grantee, table_name
        FROM dba_tab_privs
        WHERE grantee = 'BACSI' and (type = 'TABLE' or type = 'VIEW');
    dbms_sql.return_result(c_SysRole);
END;
/

grant execute on sp_Bang_BacSi to BACSI;


create or replace procedure sp_Bang_BanThuoc
IS
    c_SysRole  SYS_REFCURSOR;
BEGIN
    OPEN c_SysRole FOR
        SELECT DISTINCT grantee, table_name
        FROM dba_tab_privs
        WHERE grantee = 'BANTHUOC' and (type = 'TABLE' or type = 'VIEW');
    dbms_sql.return_result(c_SysRole);
END;
/

grant execute on sp_Bang_BanThuoc to BANTHUOC;


create or replace procedure sp_Bang_QuanLyChuyenMon
IS
    c_SysRole  SYS_REFCURSOR;
BEGIN
    OPEN c_SysRole FOR
        SELECT DISTINCT grantee, table_name
        FROM dba_tab_privs
        WHERE grantee = 'QUANLYCHUYENMON' and (type = 'TABLE' or type = 'VIEW');
    dbms_sql.return_result(c_SysRole);
END;
/

grant execute on sp_Bang_QuanLyChuyenMon to QUANLYCHUYENMON;


create or replace procedure sp_Bang_QuanLyTaiVu
IS
    c_SysRole  SYS_REFCURSOR;
BEGIN
    OPEN c_SysRole FOR
        SELECT DISTINCT grantee, table_name
        FROM dba_tab_privs
        WHERE grantee = 'QUANLYTAIVU' and (type = 'TABLE' or type = 'VIEW');
    dbms_sql.return_result(c_SysRole);
END;
/

grant execute on sp_Bang_QuanLyTaiVu to QUANLYTAIVU;

