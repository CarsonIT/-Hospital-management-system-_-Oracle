
alter session set "_ORACLE_SCRIPT"=true; --khi dang nhap phai chay dong nay

/*
---- drop table DONVI CASCADE CONSTRAINTS; xoa bang k so vi pham khoa ngoai
drop table BENHNHAN CASCADE CONSTRAINTS;
drop table CHAMCONG CASCADE CONSTRAINTS;
drop table CT_DONTHUOC CASCADE CONSTRAINTS;
drop table CT_HOADONDICHVU CASCADE CONSTRAINTS;
drop table DICHVU CASCADE CONSTRAINTS;
drop table DONTHUOC CASCADE CONSTRAINTS;
drop table DONVI CASCADE CONSTRAINTS;
drop table HOADONDICHVU CASCADE CONSTRAINTS;
drop table HOADONTIENTHUOC CASCADE CONSTRAINTS;
drop table HOSOBENHAN CASCADE CONSTRAINTS;
drop table HOSODICHVU CASCADE CONSTRAINTS;
drop table NHANVIEN CASCADE CONSTRAINTS;
drop table PHIEULUONG CASCADE CONSTRAINTS;
drop table THONGBAO CASCADE CONSTRAINTS;
drop table THUOC CASCADE CONSTRAINTS;

-- drop role
drop role BoPhanQuanLyTaiNguyenVaNhanSu;
drop role BoPhanQuanLyTaiVu;
drop role BoPhanQuanLyChuyenMon;
drop role BoPhanTiepTan;
drop role BoPhanTaiVu;
drop role BacSi;
drop role BoPhanBanThuoc;
drop role BoPhanKeToan;
drop role KyThuatVien;

-- DROP USER
DROP USER QLTNNS1 ;
DROP USER QLTV1;
DROP USER QLCM1;
DROP USER TT1;
DROP USER TT2;
DROP USER TV1;
DROP USER TV2;
DROP USER BS1;
DROP USER BS2;
DROP USER BT1;
DROP USER BT2;
DROP USER KT1;
DROP USER KT2;
DROP USER KTV1;
DROP USER KTV2;
*/

create table BenhNhan (
MaBenhNhan varchar2(10) not null,
HoTen nvarchar2(50) not null,
NgaySinh date not null,
DiaChi nvarchar2(50) not null,
SoDienThoai char(10) not null,
CMND varchar2(12) not null,
BHYT char(15) not null,
CONSTRAINT BenhNhan_pk PRIMARY KEY (MaBenhNhan) 
);

create table HoSoBenhAn (
MaKhamBenh varchar2(10) not null,
NgayKhamBenh timestamp not null,
TinhTrangBanDau nvarchar2(50) not null,
KetLuanCuaBacSi nvarchar2(50),
BenhNhan varchar2(10) not null,
NhanVienDieuPhoi varchar2(10) not null,
BacSiDieuTri varchar2(10)not null,
CONSTRAINT HoSoBenhAn_pk PRIMARY KEY (MaKhamBenh) 
);

create table Thuoc(
MaThuoc varchar2(10) not null,
TenThuoc nvarchar2(50) not null,
DonGia number,
LuuY nvarchar2(50),
DonViTinh nvarchar2(10),
CONSTRAINT Thuoc_pk PRIMARY KEY (MaThuoc)
);

create table DonThuoc(
MaDonThuoc varchar2(10) not null,
MaKhamBenh varchar2(10) not null,
CONSTRAINT DonThuoc_pk PRIMARY KEY (MaDonThuoc)
);
 
create table CT_DonThuoc(
MaDonThuoc varchar2(10) not null,
MaThuoc varchar2(10) not null,
SoLuong number not null,
LieuDung nvarchar2(50) not null,
MoTa nvarchar2(50),
CONSTRAINT CT_DonThuoc_pk PRIMARY KEY (MaDonThuoc, MaThuoc)
);

create table NhanVien (
MaNhanVien varchar2(10) not null,
HoTen nvarchar2(50) not null,
DiaChi nvarchar2(50) not null,
NgaySinh date not null,
CMND varchar2(12) not null,
Luong number not null,
GioiTinh nvarchar2(3) not null check(GioiTinh in ('Nam', N'Nu')),
PhuCap number not null,
DonVi varchar2(10) not null,
CONSTRAINT NhanVien_pk PRIMARY KEY (MaNhanVien) 
);

create table ChamCong (
MaNhanVien varchar2(10) not null,
Thang number not null check(Thang in (1,2,3,4,5,6,7,8,9,10,11,12)), 
Nam number not null,
SoNgayCong number not null,
CONSTRAINT ChamCong_pk PRIMARY KEY (MaNhanVien,Thang,Nam)
);

create table PhieuLuong(
MaNhanVien varchar2(10) not null,
Thang number not null check(Thang in (1,2,3,4,5,6,7,8,9,10,11,12)), 
Nam number not null,
TongLuong number not null,
NgayLap timestamp not null,
NVLP varchar2(10) not null,
CONSTRAINT PhieuLuong_pk PRIMARY KEY (MaNhanVien,Thang,Nam)
);

create table HoaDonDichVu(
MaHDDV varchar2(10) not null,
NgayLapHoaDon timestamp not null,
TongTien number not null,
MaKhamBenh varchar2(10) not null,
NVPT varchar2(10) not null,
CONSTRAINT HoaDon_pk PRIMARY KEY (MaHDDV)
);

create table HoaDonTienThuoc(
MaHDTT varchar2(10) not null,
MaDonThuoc varchar2(10) not null,
NgayLapHoaDon timestamp not null,
TongTien number not null,
NVPT varchar2(10) not null,
CONSTRAINT CT_HoaDonTienThuoc PRIMARY KEY (MaHDTT)
);

create table CT_HoaDonDichVu(
MaHDDV varchar2(10) not null,
MaDichVu varchar2(10) not null,
CONSTRAINT CT_HoaDon_pk PRIMARY KEY (MaHDDV,MaDichVu)
);

create table DichVu(
MaDichVu varchar2(10) not null,
TenDichVu nvarchar2(50) not null,
DonGia number not null,
CONSTRAINT DichVu_pk PRIMARY KEY (MaDichVu)
);

create table DonVi(
MaDonVi varchar2(10) not null,
TenDonVi nvarchar2(50) not null,
CONSTRAINT DonVi_pk PRIMARY KEY (MaDonVi)
);


create table HoSoDichVu (
MaKhamBenh varchar2(10)not null,
MaDichVu varchar2(10)not null,
NgayGio timestamp,
KetLuan nvarchar2(50),
KyThuatVien varchar2(10),
CONSTRAINT HoSo_DichVu_pk PRIMARY KEY (MaKhamBenh, MaDichVu, NgayGio)
);



----FOREIGN KEY--------
-- NhanVien---
alter table NhanVien
add constraint FK_NhanVien_DonVi
foreign key (DonVi) references DonVi(MaDonVi);

---HoSoBenhAn---
alter table HoSoBenhAn
add constraint FK_HSBA_BenhNhan
foreign key (BenhNhan) references BenhNhan(MaBenhNhan);

alter table HoSoBenhAn
add constraint FK_HSBA_NhanVienDieuPhoi
foreign key (NhanVienDieuPhoi) references NhanVien(MaNhanVien);

alter table HoSoBenhAn
add constraint FK_HSBA_BacSiDieuTri
foreign key (BacSiDieutri) references NhanVien(MaNhanVien);

--DonThuoc--
alter table DonThuoc
add constraint FK_DonThuoc_HSBA
foreign key (MaKhamBenh) references HoSoBenhAn(MaKhamBenh);


--CT_DonThuoc---
alter table CT_DonThuoc
add constraint FK_CTDonThuoc_Thuoc
foreign key (MaThuoc) references Thuoc(MaThuoc);

alter table CT_DonThuoc
add constraint FK_CTDonThuoc_DonThuoc
foreign key (MaDonThuoc) references DonThuoc(MaDonThuoc);

--HoaDonDichVu--
alter table HoaDonDichVu
add constraint FK_HDDV_HSBA
foreign key (MaKhamBenh) references HoSoBenhAn(MaKhamBenh);

alter table HoaDonDichVu
add constraint FK_HDDV_NhanVienPhuThu
foreign key (NVPT) references NhanVien(MaNhanVien);

--CT_HoaDonDichVu--
alter table CT_HoaDonDichVu
add constraint FK_CTHDDV_DichVu
foreign key (MaDichVu) references DichVu(MaDichVu);

alter table CT_HoaDonDichVu
add constraint FK_CTHDDV_HDDV
foreign key (MaHDDV) references HoaDonDichVu(MaHDDV);

-- HoaDonTienThuoc --
alter table HoaDonTienThuoc
add constraint FK_HDTT_NhanVienPhatThuoc
foreign key (NVPT) references NhanVien(MaNhanVien);

--HoSoDichVu--
alter table HoSoDichVu
add constraint FK_HSDV_HSBA
foreign key (MaKhamBenh) references HoSoBenhAn(MaKhamBenh);

alter table HoSoDichVu
add constraint FK_HSDV_DichVu
foreign key (MaDichVu) references DichVu(MaDichVu);

alter table HoSoDichVu
add constraint FK_HSDV_KyThuatVien
foreign key (KyThuatVien) references NhanVien(MaNhanVien);

--ChamCong--
alter table ChamCong
add constraint FK_ChamCong_NhanVien
foreign key (MaNhanVien) references NhanVien(MaNhanVien);

--PhieuLuong--
alter table PhieuLuong
add constraint FK_PhieuLuong_NhanVien
foreign key (MaNhanVien,Thang,Nam) references ChamCong(MaNhanVien,Thang,Nam);

alter table PhieuLuong
add constraint FK_PhieuLuong_NVLapPhieu
foreign key (NVLP) references NhanVien(MaNhanVien);



-------------------------------------------------------------
--------- NHAP DU LIEU MAU ---------------------

INSERT INTO DONVI VALUES ('DV1','Bo phan quan ly tai nguyen va nhan su');
INSERT INTO DONVI VALUES ('DV2','Bo phan quan ly tai vu');
INSERT INTO DONVI VALUES ('DV3','Bo phan quan ly chuyen mon');
INSERT INTO DONVI VALUES ('DV4','Bo phan tiep tan');
INSERT INTO DONVI VALUES ('DV5','Bo phan tai vu');
INSERT INTO DONVI VALUES ('DV6','Bac si');
INSERT INTO DONVI VALUES ('DV7','Bo phan ban thuoc');
INSERT INTO DONVI VALUES ('DV8','Bo phan ke toan');
INSERT INTO DONVI VALUES ('DV9','Ky thuat vien');


INSERT INTO NHANVIEN VALUES('QLTNNS1','Nguyen Van Hung','Ha Noi',TO_DATE('15/07/1970', 'DD/MM/YYYY'),'023456001', 45000000,'Nam',5000000,'DV1');
INSERT INTO NHANVIEN VALUES('QLTV1','Pham An Nhien','Ha Noi',TO_DATE('08/08/1975', 'DD/MM/YYYY'),'033367002', 45000000,'Nu',5000000,'DV2');
INSERT INTO NHANVIEN VALUES('QLCM1','Pham Huong','Ha Noi',TO_DATE('01/08/1972', 'DD/MM/YYYY'),'078951003',45000000,'Nu',5000000,'DV3');
INSERT INTO NHANVIEN VALUES('TT1','Le Thi Hong','Ho Chi Minh',TO_DATE('10/11/1990', 'DD/MM/YYYY'),'078924004',15000000,'Nu',500000,'DV4');
INSERT INTO NHANVIEN VALUES('TT2','Phan Tran Khanh Vy','Ho Chi Minh',TO_DATE('01/11/1990', 'DD/MM/YYYY'),'012367005',12000000,'Nu',500000,'DV4');
INSERT INTO NHANVIEN VALUES('TV1','Phan Thi Thu Thao','Ho Chi Minh',TO_DATE('01/10/1980', 'DD/MM/YYYY'),'099884423',20000000,'Nu',500000,'DV5');
INSERT INTO NHANVIEN VALUES('TV2','Hoang Dung','Ho Chi Minh',TO_DATE('01/10/1989', 'DD/MM/YYYY'),'089658740',15000000,'Nam',500000,'DV5');
INSERT INTO NHANVIEN VALUES('BS1','Tran Dang Khoa','Ho Chi Minh',TO_DATE('12/12/1980', 'DD/MM/YYYY'),'012380006',35000000,'Nam',5000000,'DV6');
INSERT INTO NHANVIEN VALUES('BS2','Nguyen Xuan','Ho Chi Minh',TO_DATE('10/01/1975', 'DD/MM/YYYY'),'007254807',40000000,'Nu',6000000,'DV6');
INSERT INTO NHANVIEN VALUES('BT1','Pham Thi Mai','Ho Chi Minh',TO_DATE('09/05/1990', 'DD/MM/YYYY'),'078954008',20000000,'Nu',500000,'DV7');
INSERT INTO NHANVIEN VALUES('BT2','Nguyen Van Nam','Ho Chi Minh',TO_DATE('19/01/1987', 'DD/MM/YYYY'),'007420009',25000000,'Nam',700000,'DV7');
INSERT INTO NHANVIEN VALUES('KT1','Tran Anh Huy','Ho Chi Minh',TO_DATE('18/01/1987', 'DD/MM/YYYY'),'007120010',20000000,'Nam',3000000,'DV8');
INSERT INTO NHANVIEN VALUES('KT2','Phan Thi Hong','Ho Chi Minh',TO_DATE('11/04/1990', 'DD/MM/YYYY'),'044004611',15000000,'Nu',7000000,'DV8');
INSERT INTO NHANVIEN VALUES('KTV1','Tran Anh Tuan','Ho Chi Minh',TO_DATE('02/01/1987', 'DD/MM/YYYY'),'007130012',30000000,'Nam',3000000,'DV9');
INSERT INTO NHANVIEN VALUES('KTV2','Phan Huy','Ho Chi Minh',TO_DATE('30/04/1986', 'DD/MM/YYYY'),'000425013',20000000,'Nam',3000000,'DV9');



INSERT INTO BENHNHAN VALUES('BN1','Phan Thi Hang',TO_DATE('11/01/1977', 'DD/MM/YYYY'),'Thu Duc, TP HCM','0123456789','011125579','DN123654789751');
INSERT INTO BENHNHAN VALUES('BN2','Tran Dung',TO_DATE('21/08/1980', 'DD/MM/YYYY'),'Quan 5, TP HCM','0364587922','123784590','AT4521876321444');
INSERT INTO BENHNHAN VALUES('BN3','Nguyen Duc Duy',TO_DATE('01/01/1966', 'DD/MM/YYYY'),'Quan 3,TP HCM','0333444666','248754127','SV1236471247890');
INSERT INTO BENHNHAN VALUES('BN4','Pham Thi Anh Tho',TO_DATE('19/03/1990', 'DD/MM/YYYY'),'Go Vap, TP HCM','0111222333','348975624','HS3698745217841');
INSERT INTO BENHNHAN VALUES('BN5','Le Thi Ngoc',TO_DATE('11/11/2003', 'DD/MM/YYYY'),'Thu Duc, TP HCM','0999888777','452158713','HS0123789412547');

INSERT INTO CHAMCONG VALUES('QLTNNS1',1,2021,30);
INSERT INTO CHAMCONG VALUES('QLTNNS1',2,2021,25);
INSERT INTO CHAMCONG VALUES('QLTNNS1',3,2021,29);
INSERT INTO CHAMCONG VALUES('QLTV1',1,2021,30);
INSERT INTO CHAMCONG VALUES('QLTV1',2,2021,25);
INSERT INTO CHAMCONG VALUES('QLTV1',3,2021,29);
INSERT INTO CHAMCONG VALUES('QLCM1',1,2021,30);
INSERT INTO CHAMCONG VALUES('QLCM1',2,2021,25);
INSERT INTO CHAMCONG VALUES('QLCM1',3,2021,29);
INSERT INTO CHAMCONG VALUES('TV1',1,2021,30);
INSERT INTO CHAMCONG VALUES('TV1',2,2021,25);
INSERT INTO CHAMCONG VALUES('TV1',3,2021,29);
INSERT INTO CHAMCONG VALUES('TV2',1,2021,30);
INSERT INTO CHAMCONG VALUES('TV2',2,2021,25);
INSERT INTO CHAMCONG VALUES('TV2',3,2021,29);
INSERT INTO CHAMCONG VALUES('TT1',1,2021,28);
INSERT INTO CHAMCONG VALUES('TT1',2,2021,28);
INSERT INTO CHAMCONG VALUES('TT1',3,2021,30);
INSERT INTO CHAMCONG VALUES('TT2',1,2021,25);
INSERT INTO CHAMCONG VALUES('TT2',2,2021,28);
INSERT INTO CHAMCONG VALUES('TT2',3,2021,25);
INSERT INTO CHAMCONG VALUES('BS1',1,2021,25);
INSERT INTO CHAMCONG VALUES('BS1',2,2021,25);
INSERT INTO CHAMCONG VALUES('BS2',3,2021,25);
INSERT INTO CHAMCONG VALUES('BS2',1,2021,25);
INSERT INTO CHAMCONG VALUES('BS2',2,2021,23);
INSERT INTO CHAMCONG VALUES('BS1',3,2021,25);
INSERT INTO CHAMCONG VALUES('BT1',1,2021,28);
INSERT INTO CHAMCONG VALUES('BT1',2,2021,28);
INSERT INTO CHAMCONG VALUES('BT1',3,2021,29);
INSERT INTO CHAMCONG VALUES('BT2',1,2021,27);
INSERT INTO CHAMCONG VALUES('BT2',2,2021,28);
INSERT INTO CHAMCONG VALUES('BT2',3,2021,29);
INSERT INTO CHAMCONG VALUES('KT1',1,2021,28);
INSERT INTO CHAMCONG VALUES('KT1',2,2021,27);
INSERT INTO CHAMCONG VALUES('KT1',3,2021,28);
INSERT INTO CHAMCONG VALUES('KT2',1,2021,21);
INSERT INTO CHAMCONG VALUES('KT2',2,2021,28);
INSERT INTO CHAMCONG VALUES('KT2',3,2021,28);
INSERT INTO CHAMCONG VALUES('KTV1',1,2021,27);
INSERT INTO CHAMCONG VALUES('KTV1',2,2021,27);
INSERT INTO CHAMCONG VALUES('KTV1',3,2021,27);
INSERT INTO CHAMCONG VALUES('KTV2',1,2021,26);
INSERT INTO CHAMCONG VALUES('KTV2',2,2021,27);
INSERT INTO CHAMCONG VALUES('KTV2',3,2021,27);

INSERT INTO PHIEULUONG VALUES('QLTNNS1',1,2021,30000000,TO_DATE('28/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLTNNS1',2,2021,25000000,TO_DATE('28/02/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLTNNS1',3,2021,29000000,TO_DATE('28/03/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLTV1',1,2021,30000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLTV1',2,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLTV1',3,2021,29000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLCM1',1,2021,30000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLCM1',2,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('QLCM1',3,2021,29000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('TV1',1,2021,30000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('TV1',2,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('TV1',3,2021,29000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT1');
INSERT INTO PHIEULUONG VALUES('TV2',1,2021,30000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TV2',2,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TV2',3,2021,29000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TT1',1,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TT1',2,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TT1',3,2021,30000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TT2',1,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TT2',2,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('TT2',3,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BS1',1,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BS1',2,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BS2',3,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BS2',1,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BS2',2,2021,23000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BS1',3,2021,25000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BT1',1,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BT1',2,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BT1',3,2021,29000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BT2',1,2021,27000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BT2',2,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('BT2',3,2021,29000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KT1',1,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KT1',2,2021,27000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KT1',3,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KT2',1,2021,21000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KT2',2,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KT2',3,2021,28000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KTV1',1,2021,27000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KTV1',2,2021,27000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KTV1',3,2021,27000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KTV2',1,2021,26000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KTV2',2,2021,27000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');
INSERT INTO PHIEULUONG VALUES('KTV2',3,2021,27000000,TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'KT2');

INSERT INTO DICHVU VALUES('DichVu1','Xet nghiem ADN',4000000);
INSERT INTO DICHVU VALUES('DichVu2','Sieu am thai nhi',1000000);
INSERT INTO DICHVU VALUES('DichVu3','Sieu am o bung',650000);
INSERT INTO DICHVU VALUES('DichVu4','Xet nghiem mau',150000);

INSERT INTO THUOC VALUES('THUOC1','Paracetamol','21000','Giam sot, dau hong, nhuc dau','Vi');
INSERT INTO THUOC VALUES('THUOC2','Xylometazolin','10000','Giam ngat mui','Chai');
INSERT INTO THUOC VALUES('THUOC3','Naphazolin','11000','Giam ngat mui','Chai');
INSERT INTO THUOC VALUES('THUOC4','Dextromethorphan','25000','Giam ho','Vi');
INSERT INTO THUOC VALUES('THUOC5','Phosphalugel','25000','Thuoc da day chu P','Bit');
INSERT INTO THUOC VALUES('THUOC6','Yumangel','28000','Thuoc da day chu Y','Bit');

INSERT INTO HOSOBENHAN VALUES('HSBA1',TO_DATE('15/01/2021 08:20','DD/MM/YYYY HH24:MI'),'Sot, ho','Cam cum','BN1','TT1','BS1');
INSERT INTO HOSOBENHAN VALUES('HSBA2',TO_DATE('15/01/2021 10:44','DD/MM/YYYY HH24:MI'),'Sot, ho, so mui','Cam cum','BN2','TT2','BS1');
INSERT INTO HOSOBENHAN VALUES('HSBA3',TO_DATE('16/01/2021 15:20','DD/MM/YYYY HH24:MI'),'Dau da day','Day da day','BN3','TT1','BS2');
INSERT INTO HOSOBENHAN VALUES('HSBA4',TO_DATE('16/01/2021 11:11','DD/MM/YYYY HH24:MI'),'Dau da day','Loet da day cap 1','BN4','TT2','BS2');
INSERT INTO HOSOBENHAN VALUES('HSBA5',TO_DATE('16/01/2021 08:55','DD/MM/YYYY HH24:MI'),'Dau bung','Viem ruot thua','BN5','TT2','BS2');

INSERT INTO DONTHUOC VALUES('DT1','HSBA1');
INSERT INTO DONTHUOC VALUES('DT2','HSBA2');
INSERT INTO DONTHUOC VALUES('DT3','HSBA3');
INSERT INTO DONTHUOC VALUES('DT4','HSBA4');

INSERT INTO CT_DONTHUOC VALUES('DT1','THUOC1',2,'Ngay 3 lan sau bua an sang trua toi, lan 1 vien','aaa');
INSERT INTO CT_DONTHUOC VALUES('DT1','THUOC4',2,'Ngay 3 lan sau bua an sang trua toi, lan 1 vien','aaa');
INSERT INTO CT_DONTHUOC VALUES('DT2','THUOC1',2,'Ngay 3 lan sau bua an sang trua toi, lan 1 vien','aaa');
INSERT INTO CT_DONTHUOC VALUES('DT2','THUOC2',2,'Ngay 3 lan sau bua an sang trua toi, lan 1 vien','aaa');
INSERT INTO CT_DONTHUOC VALUES('DT2','THUOC4',2,'Ngay 3 lan sau bua an sang trua toi, lan 1 vien','aaa');
INSERT INTO CT_DONTHUOC VALUES('DT3','THUOC5',10,'Uong sau bua an hay co trieu chung dau','aaa');
INSERT INTO CT_DONTHUOC VALUES('DT4','THUOC6',10,'Uong sau bua an hay co trieu chung dau','aaa');

INSERT INTO HOADONDICHVU VALUES('HDDV1',TO_DATE('15/01/2021 15:20','DD/MM/YYYY HH24:MI'),300000,'HSBA1','TV1');
INSERT INTO HOADONDICHVU VALUES('HDDV2',TO_DATE('16/01/2021 08:10','DD/MM/YYYY HH24:MI'),450000,'HSBA2','TV1');
INSERT INTO HOADONDICHVU VALUES('HDDV3',TO_DATE('16/01/2021 15:10','DD/MM/YYYY HH24:MI'),500000,'HSBA3','TV2');
INSERT INTO HOADONDICHVU VALUES('HDDV4',TO_DATE('16/01/2021 09:55','DD/MM/YYYY HH24:MI'),1000000,'HSBA4','TV2');
INSERT INTO HOADONDICHVU VALUES('HDDV5',TO_DATE('15/01/2021 16:04','DD/MM/YYYY HH24:MI'),1500000,'HSBA5','TV2');

INSERT INTO CT_HOADONDICHVU VALUES('HDDV1','DichVu1');
INSERT INTO CT_HOADONDICHVU VALUES('HDDV1','DichVu2');
INSERT INTO CT_HOADONDICHVU VALUES('HDDV3','DichVu3');
INSERT INTO CT_HOADONDICHVU VALUES('HDDV4','DichVu1');
INSERT INTO CT_HOADONDICHVU VALUES('HDDV5','DichVu2');
INSERT INTO CT_HOADONDICHVU VALUES('HDDV5','DichVu4');
INSERT INTO CT_HOADONDICHVU VALUES('HDDV2','DichVu3');

INSERT INTO HOADONTIENTHUOC VALUES('HDTT1','DT1',TO_DATE('15/01/2021 15:20','DD/MM/YYYY HH24:MI'),300000,'BT1');
INSERT INTO HOADONTIENTHUOC VALUES('HDTT2','DT2',TO_DATE('16/01/2021 08:10','DD/MM/YYYY HH24:MI'),450000,'BT1');
INSERT INTO HOADONTIENTHUOC VALUES('HDTT3','DT3',TO_DATE('16/01/2021 09:55','DD/MM/YYYY HH24:MI'),500000,'BT2');
INSERT INTO HOADONTIENTHUOC VALUES('HDTT4','DT4',TO_DATE('16/01/2021 14:23','DD/MM/YYYY HH24:MI'),1000000,'BT2');

INSERT INTO HOSODICHVU VALUES('HSBA4','DichVu3',TO_DATE('16/01/2021 08:20','DD/MM/YYYY HH24:MI'),'Co o loet da day 1cm','KTV1');
INSERT INTO HOSODICHVU VALUES('HSBA5','DichVu3',TO_DATE('16/01/2021 14:55','DD/MM/YYYY HH24:MI'),'Viem ruot thua cap tinh','KTV2');
INSERT INTO HOSODICHVU VALUES('HSBA3','DichVu3',TO_DATE('16/01/2021 09:55','DD/MM/YYYY HH24:MI'),'Viem ruot thua cap tinh','KTV2');

------- ROLE

create role BoPhanQuanLyTaiNguyenVaNhanSu;
create role BoPhanQuanLyTaiVu;
create role BoPhanQuanLyChuyenMon;
create role BoPhanTiepTan;
create role BoPhanTaiVu;
create role BacSi;
create role BoPhanBanThuoc;
create role BoPhanKeToan;
create role KyThuatVien;

CREATE USER QLTNNS1 IDENTIFIED BY QLTNNS1;
CREATE USER QLTV1 IDENTIFIED BY QLTV1;
CREATE USER QLCM1 IDENTIFIED BY QLCM1;
CREATE USER TT1 IDENTIFIED BY TT1;
CREATE USER TT2 IDENTIFIED BY TT2;
CREATE USER TV1 IDENTIFIED BY TV1;
CREATE USER TV2 IDENTIFIED BY TV2;
CREATE USER BS1 IDENTIFIED BY BS1;
CREATE USER BS2 IDENTIFIED BY BS2;
CREATE USER BT1 IDENTIFIED BY BT1;
CREATE USER BT2 IDENTIFIED BY BT2;
CREATE USER KT1 IDENTIFIED BY KT1;
CREATE USER KT2 IDENTIFIED BY KT2;
CREATE USER KTV1 IDENTIFIED BY KTV1;
CREATE USER KTV2 IDENTIFIED BY KTV2;
GRANT CREATE SESSION TO QLTNNS1,QLTV1,QLCM1,TT1,TT2,TV1,TV2,BS1,BS2,BT1,BT2,KT1,KT2,KTV1,KTV2;

GRANT BoPhanQuanLyTaiNguyenVaNhanSu TO QLTNNS1;
GRANT BOPHANQUANLYTAIVU TO QLTV1;
GRANT BOPHANQUANLYCHUYENMON TO QLCM1;
GRANT BOPHANTIEPTAN TO TT1;
GRANT BOPHANTIEPTAN TO TT2;
GRANT BOPHANTAIVU TO TV1;
GRANT BOPHANTAIVU TO TV2;
GRANT BACSI TO BS1;
GRANT BACSI TO BS2;
GRANT BOPHANBANTHUOC TO BT1;
GRANT BOPHANBANTHUOC TO BT2;
GRANT BOPHANKETOAN TO KT1;
GRANT BOPHANKETOAN TO KT2;
GRANT KYTHUATVIEN TO KTV1;
GRANT KYTHUATVIEN TO KTV2;
--------

--------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------RBAC VPD --------------------------------------------------------------------------


------------------------------------------------------------------------------------------------------------------
-- TAT CA ROLE
-- 1. Nhan vien chi duoc xem thong tin cua ho. Bo phan quan ly duoc xem het bang NhanVien
-- 2. Nhan vien chi duoc sua ho ten, diachi, ngaysinh, gioitinh cua ho. Bo phan quan ly duoc toan quyen tren bang NhanVien
-- 3. Nhan vien chi duoc xem thong tin cham cong cua ho. Bo phan ke toan duoc toan quyen tren bang ChamCong

-----------------------------------------------------------------------------------
-- doan code nay nham muc dich lay ra duoc ten don vi cua user
CREATE CONTEXT nhanvien_ctx USING nhanvien_ctx_mgr; 
CREATE OR REPLACE PACKAGE nhanvien_ctx_mgr 
AS 
PROCEDURE set_donvi; 
PROCEDURE clear_donvi;
END; 
/
CREATE OR REPLACE PACKAGE BODY nhanvien_ctx_mgr 
AS 
PROCEDURE set_donvi
AS 
dv nvarchar2(100); 
BEGIN 
SELECT TENDONVI INTO dv FROM  NHANVIEN, DONVI
WHERE MANHANVIEN = SYS_CONTEXT ('userenv', 'session_user') AND DONVI=MADONVI;
DBMS_SESSION.set_context (namespace => 'nhanvien_ctx', ATTRIBUTE => 'donvi', VALUE => dv); 
END set_donvi; 
---
PROCEDURE clear_donvi 
AS 
BEGIN 
DBMS_SESSION.clear_context (namespace => 'nhanvien_ctx', ATTRIBUTE => 'donvi'); 
END clear_donvi; 
END nhanvien_ctx_mgr; 
/
CREATE OR REPLACE TRIGGER set_nhanvien_donvi 
AFTER LOGON ON DATABASE 
BEGIN 
nhanvien_ctx_mgr.set_donvi;
EXCEPTION 
WHEN NO_DATA_FOUND 
THEN 
-- If user is not in table, 
-- a no_data_found is raised 
-- If exception is not handled, then users not in table 
-- will be unable to log on 
NULL;
END;
/
/* test: User dang nhap, chay lenh nay de xem dung don vi khong
 SELECT SYS_CONTEXT ('nhanvien_ctx','donvi') Donvi FROM DUAL;
*/
-----
----------------------------------------------------------------------------------------------
------                   BANG NHAN VIEN
-- 1. Nhan vien chi duoc xem thong tin cua ho. Quan Ly Tai Nguyen Va Nhan Su, Quan ly Chuyen Mon, Quan Ly Tai Vu, Ke toan duoc xem het bang NHAN VIEN
-- 2. Nhan vien chi duoc sua ho ten, diachi, ngaysinh, gioitinh, cmnd cua ho. 
-- 3. Quan Ly Tai Nguyen Va Nhan Su duoc toan them, xem, xoa, sua tren bang NHAN VIEN

GRANT SELECT ON NHANVIEN TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANTIEPTAN, BOPHANTAIVU,BACSI,BOPHANBANTHUOC,BOPHANKETOAN,KYTHUATVIEN;
GRANT UPDATE(HOTEN,DIACHI,NGAYSINH,GIOITINH,CMND) ON NHANVIEN TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANTIEPTAN, BOPHANTAIVU,BACSI,BOPHANBANTHUOC,BOPHANKETOAN,KYTHUATVIEN;
GRANT SELECT, INSERT, UPDATE, DELETE ON NHANVIEN TO  BOPHANQUANLYTAINGUYENVANHANSU;

Create OR REPLACE function f_xemthongtinnhanvien(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv NVARCHAR2(100);
Begin 
dv:= SYS_CONTEXT('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER');
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv ='Bo phan ke toan') then
    return '1=1';
else 
    return 'MANHANVIEN = '''|| user ||'''';  -- Nhung nhan vien khac (khong phai quan ly) chi duoc thuc hien tren dong cua minh
end if;
End;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'NHANVIEN',
policy_name => 'policy_xemthongtinnhanvien',
policy_function => 'f_xemthongtinnhanvien',
statement_types => 'select'
);
end;
/

/* Xoa policy
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'NHANVIEN',
policy_name => 'policy_thongtinnhanvien'
);
END;
*/
Create OR REPLACE function f_suathongtinnhanvien(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv NVARCHAR2(100);
Begin 
dv:= SYS_CONTEXT('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER');
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su') then
    return '1=1';
else 
    return 'MANHANVIEN = '''|| user ||'''';  -- Nhung nhan vien khac (khong phai quan ly tai nguyen nhan su) chi duoc thuc hien tren dong cua minh
end if;
End;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'NHANVIEN',
policy_name => 'policy_suathongtinnhanvien',
policy_function => 'f_suathongtinnhanvien',
statement_types => 'update'
);
end;
/
/* Xoa policy
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'NHANVIEN',
policy_name => 'policy_suathongtinnhanvien'
);
END;
*/
----------------------------------------------------------------------
--------------          BANG CHAM CONG
-- 1. Nhan vien chi duoc xem thong tin cham cong cua ho. Quan Ly Tai Nguyen Va Nhan Su, Quan ly Chuyen Mon, Quan Ly Tai Vu, Ke toan duoc xem het bang CHAM CONG
--2. Quan Ly Tai Nguyen Va Nhan Su duoc them, xem, xoa, sua tren bang CHAM CONG
GRANT SELECT ON CHAMCONG TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANTIEPTAN, BOPHANTAIVU,BACSI,BOPHANBANTHUOC,BOPHANKETOAN,KYTHUATVIEN;
GRANT INSERT, UPDATE, DELETE ON CHAMCONG TO BOPHANQUANLYTAINGUYENVANHANSU;
/
Create OR REPLACE function f_xemthongtinchamcong(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv NVARCHAR2(100);
Begin 
dv:= SYS_CONTEXT('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER');
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv ='Bo phan ke toan') then return '1=1'; -- Nhan vien quan ly duoc toan quyen tren bang NhanVien
else 
    return 'MANHANVIEN = '''|| user ||''''; 
end if;
End;
/

begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'CHAMCONG',
policy_name => 'policy_xemthongtinchamcong',
policy_function => 'f_xemthongtinchamcong',
statement_types => 'select'
);
end;
/
/*
BEGIN 
dbms_rls.drop_policy (
object_schema => 'QLBV',
object_name => 'CHAMCONG',
policy_name => 'POLICY_NHANVIEN_CHAMCONG'
);
END;
*/

---------------------------------------------------------------------
-------------          Bang DON VI
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon duoc xem bang DON VI
-- 2. Quan Ly Tai Nguyen Va Nhan Su duoc I, S, U, D tren bang DON VI
GRANT SELECT ON DONVI TO BOPHANQUANLYTAINGUYENVANHANSU, BOPHANQUANLYTAIVU, BOPHANQUANLYCHUYENMON;
GRANT INSERT, UPDATE, DELETE ON DONVI TO BOPHANQUANLYTAINGUYENVANHANSU;
------------------------------------------------------------------------
--------         Bang BENH NHAN
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon, Tiep Tan, NV Tai Vu, Ban Thuoc duoc xem bang BENH NHAN
-- 2. Tiep Tan duoc  S, I, U, D bang BENH NHAN
GRANT SELECT ON BENHNHAN TO BOPHANQUANLYTAINGUYENVANHANSU, BOPHANQUANLYTAIVU, BOPHANQUANLYCHUYENMON, BOPHANTAIVU,BOPHANBANTHUOC;
GRANT INSERT, SELECT, UPDATE, DELETE ON BENHNHAN TO BOPHANTIEPTAN;
----------------------------------------------------------------------
---------        Bang HO SO BENH AN
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon, Tiep Tan duoc xem bang HOSOBENHAN
-- 2. TIEP TAN duoc Insert(tru KetLuanCuaBacSi) bang HSBA
-- 3.  TIEP TAN duoc Update (tru KetLuanCuaBacSi) cua HSBA ma minh tiep nhan
-- 4. TIEP TAN duoc Delete HSBA ma minh tiep nhan
-- 5. BAC SI duoc Select HSBA ma minh tiep nhan dieu tri
-- 6. BAC SI duoc Update ( KetLuanCuaBacSi) cua HSBA ma minh dieu tri
GRANT SELECT ON HOSOBENHAN TO BOPHANQUANLYTAINGUYENVANHANSU, BOPHANQUANLYTAIVU, BOPHANQUANLYCHUYENMON, BOPHANTIEPTAN;
grant insert(MaKhamBenh, NgayKhamBenh, TinhTrangBanDau,BenhNhan, NhanVienDieuPhoi, BacSiDieuTri)   on HoSoBenhAn to BoPhanTiepTan;
grant update (MaKhamBenh, NgayKhamBenh,TINHTRANGBANDAU,BENHNHAN, NhanVienDieuPhoi, BACSIDIEUTRI) ON HOSOBENHAN TO BoPhanTiepTan;
GRANT DELETE ON HOSOBENHAN TO BoPhanTiepTan;
grant select on HOSOBENHAN TO BACSI;
GRANT UPDATE(KETLUANCUABACSI) ON HOSOBENHAN TO BACSI;
/
Create OR REPLACE function f_xem_hsba(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv:= SYS_CONTEXT('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER');
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv ='Bo phan tiep tan') then return '1=1'; end if;
if( dv = 'Bac si') then return 'BACSIDIEUTRI = '''|| user ||''''; 
ELSE RETURN '1=0';
END IF;
End;
/
Create OR REPLACE function f_sua_hsba(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv:= SYS_CONTEXT('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER');
if (user ='ADMINBV') THEN return '1=1'; end if;
if (dv = 'Bo phan tiep tan') then return 'NHANVIENDIEUPHOI = '''|| user ||'''';
END IF;
if( dv = 'Bac si') then return 'BACSIDIEUTRI = '''|| user ||''''; 
ELSE RETURN '1=0';
END IF;
End;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'HOSOBENHAN',
policy_name => 'policy_xem_hsba',
policy_function => 'f_xem_hsba', 
statement_types => 'select'
); 
END;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'HOSOBENHAN',
policy_name => 'policy_sua_hsba',
policy_function => 'f_sua_hsba', 
statement_types => 'insert, update, delete',
update_check => true

); 
END;
/
/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'HOSOBENHAN',
policy_name => 'policy_sua_hsba'
);
END;
*/
-----------------------------------------------------------------
----          Bang HO SO DICH VU
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon, Bo Phan Tai Vu duoc xem bang HSDV
-- 2. Tiep Tan duoc xem HSDV cua hsba minh dieu phoi
-- 3. Tiep Tan duoc sua HSDV (Ky Thuat Vien) cua hsba minh dieu phoi
-- 4. Bac si duoc xem, them sua( MaKhamBenh, MaDichVu), xÃƒÂ³a HSDV ma minh tiep nhan
-- 5. Ky Thuat Vien duoc xem, sua ( KetLuan) cua HSDV ma minh tiep nhan
GRANT SELECT ON HOSODICHVU TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANTIEPTAN, BACSI, BOPHANTAIVU, KYTHUATVIEN;
GRANT UPDATE (KYTHUATVIEN) ON HOSODICHVU TO BoPhanTiepTan;
GRANT INSERT (MAKHAMBENH, MADICHVU, NGAYGIO) ON HOSODICHVU TO BacSi;
GRANT UPDATE (MAKHAMBENH, MADICHVU, NGAYGIO) ON HOSODICHVU TO BacSi;
GRANT DELETE ON HOSODICHVU TO BACSI;
GRANT UPDATE (KETLUAN) ON HOSODICHVU TO KYTHUATVIEN;
/
Create OR REPLACE function f_hsdv(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv ='Bo phan tai vu') then 
    return '1=1'; 
end if;
if ( dv = 'Bo phan tiep tan')then 
    RETURN 'EXISTS (SELECT * FROM ADMINBV.HOSOBENHAN BA WHERE BA.MAKHAMBENH=ADMINBV.HOSODICHVU.MAKHAMBENH AND NHANVIENDIEUPHOI= '''|| user ||''')';
end if;
if ( dv ='Bac si') then 
    RETURN 'EXISTS (SELECT * FROM ADMINBV.HOSOBENHAN BA WHERE BA.MAKHAMBENH=ADMINBV.HOSODICHVU.MAKHAMBENH AND BACSIDIEUTRI= '''|| user ||''')';
end if;
if ( dv='Ky thuat vien') then
    RETURN 'KYTHUATVIEN = '''||user|| '''';
ELSE RETURN '1=0';
end if;
End;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'HOSODICHVU',
policy_name => 'policy_hsdv',
policy_function => 'f_hsdv', 
statement_types => 'insert, select, update, delete',
update_check => true
); 
END;
/
/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'AD',
object_name => 'HOSODICHVU',
policy_name => 'policy_tieptan_hsdv'
);
END;
*/
-------------------------------------------------------------
----------       Bang DON THUOC
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon, Ban Thuoc duoc xem bang DONTHUOC
-- 2. Bac Si them, xem, xoa, sua DONTHUOC cua benh nhan ma minh dieu tri
GRANT SELECT ON DONTHUOC TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANBANTHUOC, BACSI;
GRANT INSERT, UPDATE, DELETE ON DONTHUOC TO BACSI;
Create OR REPLACE function f_donthuoc(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv ='Bo phan ban thuoc') then 
    return '1=1'; 
end if;
if ( dv ='Bac si') then 
    RETURN 'EXISTS (SELECT * FROM ADMINBV.HOSOBENHAN BA WHERE BA.MAKHAMBENH=ADMINBV.DONTHUOC.MAKHAMBENH AND BACSIDIEUTRI= '''|| user ||''')';
ELSE RETURN '1=0';
end if;
End;
/
----------------
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'DONTHUOC',
policy_name => 'policy_donthuoc',
policy_function => 'f_donthuoc', 
statement_types  => 'select, insert, update, delete',
update_check => true
); 
END;
/

/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'AD',
object_name => 'DONTHUOC',
policy_name => 'policy_themdonthuoc'
);

END;
*/
-------------------------------------------------------------------
-----                Bang CT DON THUOC 
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon, Ban Thuoc duoc xem bang CT_DON THUOC
-- 2. Bac Si duoc them, xem, xoa, sua  bang CT_DONTHUOC cua Benh Nhan ma minh dieu tri
GRANT SELECT ON CT_DONTHUOC TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANBANTHUOC;
GRANT SELECT, INSERT, UPDATE, DELETE ON CT_DONTHUOC TO BACSI;
Create OR REPLACE function f_ctdonthuoc(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv ='Bo phan ban thuoc') then 
    return '1=1'; 
end if;
if ( dv ='Bac si') then 
    RETURN 'EXISTS (SELECT * FROM ADMINBV.HOSOBENHAN BA, ADMINBV.DONTHUOC DT WHERE BA.MAKHAMBENH=DT.MAKHAMBENH AND ADMINBV.CT_DONTHUOC.MADONTHUOC = DT.MADONTHUOC AND BACSIDIEUTRI= '''|| user ||''')';
ELSE RETURN '1=0';
end if;
End;
/
----------------
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'CT_DONTHUOC',
policy_name => 'policy_ctdonthuoc',
policy_function => 'f_ctdonthuoc', 
statement_types  => 'select, insert, update, delete',
update_check => true
); 
END;

/
/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'AD',
object_name => 'CT_DONTHUOC',
policy_name => 'policy_ctdonthuoc'
);

END;
*/
--------------------------------------------------------------------
----------  Bang HOA DON DICH VU
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon duoc xem bang HOADONDICHVU
-- 2. Tai Vu duoc them vao HOADONDICHVU
-- 3. Tai Vu duoc xem, sua, xoa HOADONDICHVU ma minh lap
GRANT SELECT ON HOADONDICHVU TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU;
GRANT INSERT, SELECT, UPDATE, DELETE ON HOADONDICHVU TO BOPHANTAIVU;

Create OR REPLACE function f_hddv(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon') then 
    return '1=1'; 
end if;
if ( dv='Bo phan tai vu') then
    RETURN 'NVPT = '''||user|| '''';
ELSE RETURN '1=0';
end if;
End;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'HOADONDICHVU',
policy_name => 'policy_hddv',
policy_function => 'f_hddv', 
statement_types  => 'select, insert, update, delete',
update_check => true); 
END;
/
/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'HOADONDICHVU',
policy_name => 'policy_hddv'
);
END;
*/
------------------------------------------------------------------
---------        Bang CT HOA DON DICH VU
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon duoc xem bang CT_HOADONDICHVU
-- 2. NV Tai Vu duoc them CT_HOADONDICHVU cua HOADONDICHVU ma minh lap
-- 3. NV Tai Vu duoc xem, xoa, sua CT_HOADONDICHVU ma minh lap
GRANT SELECT ON CT_HOADONDICHVU TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU;
GRANT INSERT, SELECT, UPDATE, DELETE ON CT_HOADONDICHVU TO BOPHANTAIVU;
Create OR REPLACE function f_ct_hddv(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' ) then 
    return '1=1'; 
end if;
if ( dv ='Bo phan tai vu') then 
    RETURN 'EXISTS (SELECT * FROM ADMINBV.HOADONDICHVU HD WHERE HD.MAHDDV= ADMINBV.CT_HOADONDICHVU.MAHDDV AND NVPT= '''|| user ||''')';
ELSE RETURN '1=0';
end if;
End;
/
----------------
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'CT_HOADONDICHVU',
policy_name => 'policy_ct_hddv',
policy_function => 'f_ct_hddv', 
statement_types  => 'select, insert, update, delete',
update_check => true
); 
END;
/
/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'CT_HOADONDICHVU',
policy_name => 'policy_cthddv'
);
END;
*/
-------------------------------------------------------------------

--------------      Bang HOA DON TIEN THUOC
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon duoc xem bang HOADONTIENTHUOC
-- 2. NV Ban Thuoc them HOADONTIENTHUOC
-- 3. NV Ban Thuoc xem, xoa, sua HOADONTIENTHUOC ma minh lap
GRANT SELECT ON HOADONTIENTHUOC TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU;
GRANT SELECT, INSERT, UPDATE, DELETE ON HOADONTIENTHUOC TO BOPHANBANTHUOC;

Create OR REPLACE function f_hdtt(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon') then 
    return '1=1'; 
end if;
if ( dv='Bo phan ban thuoc') then
    RETURN 'NVPT = '''||user|| '''';
ELSE RETURN '1=0';
end if;
End;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'HOADONTIENTHUOC',
policy_name => 'policy_hdtt',
policy_function => 'f_hdtt', 
statement_types => 'insert, select, update, delete',
update_check => true
); 
END;
/
/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'HOADONTIENTHUOC',
policy_name => 'policy_hdtt'
);
END;
*/
----------------------------------------------------------------------
---------           Bang PHIEU LUONG
-- 1. Nhan vien chi duoc xem PHIEU LUONG cua ho. Quan Ly Tai Nguyen Va Nhan Su, Quan ly Chuyen Mon, Quan Ly Tai Vu duoc xem het bang PHIEU LUONG
-- 2. Ke Toan duoc them vao bang PHIEU LUONG
-- 3. Ke Toan duoc xem, xoa, sua PHIEU LUONG ma minh lap
GRANT SELECT ON PHIEULUONG TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANTIEPTAN, BOPHANTAIVU,BACSI,BOPHANBANTHUOC,BOPHANKETOAN,KYTHUATVIEN;
GRANT SELECT, INSERT, UPDATE, DELETE ON PHIEULUONG TO BOPHANKETOAN;
-- neu xem Phieu Luong thi Ke Toan co the xem phieu luong cua minh va phieu luong minh lap
-- neu sua, xoa Phieu Luong thi Ke Toan chi co the sua phieu luong minh lap
Create OR REPLACE function f_xemphieuluong(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon') then 
    return '1=1'; 
end if;
if( dv='Bo phan ke toan') then
    return 'NVLP = '''|| user ||''' OR MANHANVIEN = '''|| user ||'''';
else
    return 'MANHANVIEN = '''|| user ||'''';
end if;
End;
/
Create OR REPLACE function f_suaphieuluong(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
IF(user ='ADMINBV') THEN RETURN '1=1'; END IF;
if( dv='Bo phan ke toan') then
    return 'NVLP = '''|| user ||'''';
else
    return '1=0';
end if;
End;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'PHIEULUONG',
policy_name => 'policy_xemphieuluong',
policy_function => 'f_xemphieuluong', 
statement_types => 'select'
); 
END;
/
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'PHIEULUONG',
policy_name => 'policy_suaphieuluong',
policy_function => 'f_suaphieuluong', 
statement_types => 'insert, update, delete',
update_check => true
); 
END;
/
/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'PHIEULUONG',
policy_name => 'policy_phieuluong'
);
END;
*/
--------------------------------------------------------------------
-----------      Bang DICH VU
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan Ly Tai Vu, Quan Ly Chuyen Mon, Tai Vu duoc xem bang DICHVU
-- 2. Quan Ly Tai Vu xem, them, xoa, sua DICHVU
-- 3. Bac Si duoc xem bang DICHVU ( tru DonGia)
-- 4. Ky Thuat Vien duoc xem bang DICHVU ( tru DonGia)
GRANT SELECT ON DICHVU TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANTAIVU, BACSI, KYTHUATVIEN;
GRANT SELECT, INSERT, UPDATE, DELETE ON DICHVU TO BOPHANQUANLYTAIVU;
/
Create OR REPLACE function f_xemdichvu(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv = 'Bo phan tai vu') then 
    return '1=1'; 
else
    return '1=0';
end if;
End;
/

----------------
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'DICHVU',
policy_name => 'policy_xemdichvu',
policy_function => 'f_xemdichvu', 
statement_types  => 'select',
sec_relevant_cols =>'DONGIA',
sec_relevant_cols_opt => DBMS_RLS.ALL_ROWS
); 
END;

/

/* -- XOA POLICY
BEGIN 
dbms_rls.drop_policy (
object_schema => 'ADMINBV',
object_name => 'DICHVU',
policy_name => 'policy_xemdichvu'
);
END;
*/

-------------------------------------------------------------------
---------     Bang THUOC
-- 1. Quan Ly Tai Nguyen Va Nhan Su, Quan ly Chuyen Mon, Quan Ly Tai Vu, Ban Thuoc duoc xem het bang THUOC
-- 2. Quan Ly Tai Vu duoc xem, them, xoa, sua THUOC
-- 3. Bac Si duoc xem bang Thuoc ( tru DonGia)
GRANT SELECT ON THUOC TO BOPHANQUANLYTAINGUYENVANHANSU,BOPHANQUANLYCHUYENMON, BOPHANQUANLYTAIVU, BOPHANBANTHUOC, BACSI;
GRANT SELECT, INSERT, UPDATE, DELETE ON THUOC TO BOPHANQUANLYTAIVU;
/
Create OR REPLACE function f_xemthuoc(p_schema varchar2, p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
dv varchar2(100);
Begin 
dv := SYS_CONTEXT ('nhanvien_ctx','donvi');
user := SYS_CONTEXT('userenv', 'SESSION_USER'); 
if (user ='ADMINBV' OR dv = 'Bo phan quan ly tai nguyen va nhan su' or dv = 'Bo phan quan ly tai vu' or dv = 'Bo phan quan ly chuyen mon' or dv = 'Bo phan ban thuoc') then 
    return '1=1'; 
else
    return '1=0';
end if;
End;
/

----------------
begin
dbms_rls.add_policy (
object_schema => 'ADMINBV',
object_name => 'THUOC',
policy_name => 'policy_xemthuoc',
policy_function => 'f_xemthuoc', 
statement_types  => 'select',
sec_relevant_cols =>'DONGIA',
sec_relevant_cols_opt => DBMS_RLS.ALL_ROWS
); 
END;

/
--------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------MA HOA --------------------------------------------------------------------------

----         MA HOA
-- Tao table BenhNhan_ENC thay the bang BenhNhan
create table BenhNhan_ENC (
MaBenhNhan varchar2(10) not null,
HoTen nvarchar2(50) not null,
NgaySinh date not null,
DiaChi nvarchar2(50) not null,
SoDienThoai char(10) not null,
CMND varchar2(2000) not null,
BHYT char(15) not null,
CONSTRAINT BenhNhanENC_pk PRIMARY KEY (MaBenhNhan) 
);
-- tao bang Khoa de luu key
create table Khoa(
MaBN varchar2(10),
Key raw(32),
PRIMARY KEY (MaBN) 
);

-- Dung thuat toan ENCRYPT_AES256 voi CHAIN_CBC vÃ  PAD_PKCS
create or replace package package_Crypt as
function f_encrypt (p_str in varchar2, p_key in raw) return  varchar2;
function f_decrypt (p_data in varchar2, p_key in raw) return varchar2;
end;
/
create or replace package body package_Crypt  
as         
    --- ma hoa
    function f_encrypt (p_str in varchar2, p_key in raw)  
    return varchar2
    as  
        encrypted_str varchar2(200);
        encrypted_raw RAW (2000); -- stores encrypted binary text
        encryption_type PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_AES256+ DBMS_CRYPTO.CHAIN_CBC+ DBMS_CRYPTO.PAD_PKCS5;
    begin  
        encrypted_raw := DBMS_CRYPTO.ENCRYPT
        ( src => UTL_I18N.STRING_TO_RAW (p_str, 'AL32UTF8'),
          typ => encryption_type,
          key => p_key
         );
         encrypted_str:= UTL_RAW.CAST_TO_VARCHAR2(UTL_ENCODE.base64_encode(encrypted_raw));
    return encrypted_str;
    end;  
       
    --- giai ma
    function f_decrypt (p_data in varchar2 , p_key in raw)  
    return varchar2  
    as   
        decrypted_raw RAW (2000); -- stores decrypted binary text
        encryption_type PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_AES256+ DBMS_CRYPTO.CHAIN_CBC+ DBMS_CRYPTO.PAD_PKCS5;                                                                                                     
    begin
        decrypted_raw := DBMS_CRYPTO.DECRYPT(
                    src => UTL_ENCODE.base64_decode (UTL_RAW.CAST_TO_RAW (p_data)),
                    typ => encryption_type,
                    key => p_key
        );
        return UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    end;
end package_Crypt;

-- tao trigger khi insert bang BenhNhan
create or replace trigger crypted_BENHNHAN
before insert on ADMINBV.BENHNHAN_ENC
for each row
declare  key_raw RAW(32);
begin    
    key_raw  := DBMS_CRYPTO.RANDOMBYTES (32);
    INSERT INTO KHOA VALUES (:new.MaBenhNhan , key_raw);
    :new.CMND := package_Crypt.f_encrypt(:new.CMND, key_raw);
end;

-- view chua du lieu giai ma
create or replace view VIEW_BENHNHAN as 
select MABENHNHAN, HOTEN  , ngaysinh , diachi , SODIENTHOAI , cast( ADMINBV.package_Crypt.f_decrypt(CMND,KEY) as varchar2(200)) CMND
from BENHNHAN_ENC, khoa
where MaBN= MaBenhNhan

-- test
--delete from BENHNHAN_ENC
--DELETE FROM KHOA
INSERT INTO BENHNHAN_ENC VALUES('BN1','Phan Thi Hang',TO_DATE('11/01/1977', 'DD/MM/YYYY'),'Thu Duc, TP HCM','0123456789','011125579','DN123654789751');
INSERT INTO BENHNHAN_ENC VALUES('BN2','Tran Dung',TO_DATE('21/08/1980', 'DD/MM/YYYY'),'Quan 5, TP HCM','0364587922','123784590','AT4521876321444');
INSERT INTO BENHNHAN_ENC VALUES('BN3','Nguyen Duc Duy',TO_DATE('01/01/1966', 'DD/MM/YYYY'),'Quan 3,TP HCM','0333444666','248754127','SV1236471247890');
INSERT INTO BENHNHAN_ENC VALUES('BN4','Pham Thi Anh Tho',TO_DATE('19/03/1990', 'DD/MM/YYYY'),'Go Vap, TP HCM','0111222333','348975624','HS3698745217841');
INSERT INTO BENHNHAN_ENC VALUES('BN5','Le Thi Ngoc',TO_DATE('11/11/2003', 'DD/MM/YYYY'),'Thu Duc, TP HCM','0999888777','452158713','HS0123789412547');
INSERT INTO BENHNHAN_ENC VALUES('BN6','Le Thi Mai',TO_DATE('11/11/1980', 'DD/MM/YYYY'),'Thu Duc, TP HCM','0999888111','452158000','HS0123789412575');
--
SELECT * FROM ADMINBV.BENHNHAN_ENC
SELECT * FROM VIEW_BENHNHAN
select * from khoa

-- Sua doi khoa
-- Ta giai ma du lieu voi key cu va ma hoa lai bang key moi
create or replace trigger UpdateKey
before update OF key on ADMINBV.KHOA
for each row
declare  newcmnd varchar2(2000);
begin
    select CMND into newcmnd from ADMINBV.BENHNHAN_ENC where mabenhnhan=:new.mabn;   
    update BENHNHAN_ENC set CMND= package_Crypt.f_encrypt(package_Crypt.f_decrypt(newcmnd, :old.key), :new.key) where MaBenhNhan= :new.MaBN;
end;

-- proc update bang khoa 1 dong
create or replace procedure p_updatekey(mbn in varchar2, newkey in raw)
as
begin
UPDATE KHOA SET KEY = newkey WHERE MABN=mbn;
end;
--exec p_updatekey('BN1',DBMS_CRYPTO.RANDOMBYTES (32));

-- reset key hang loat
create or replace procedure p_resetkey
as
    cursor c_khoa is select * from khoa;
    v_khoa c_khoa%rowtype;
begin
    open c_khoa;
    loop
        fetch c_khoa into v_khoa;
        exit when c_khoa%notfound;
        update Khoa set key=DBMS_CRYPTO.RANDOMBYTES (32) where mabn=v_khoa.mabn;
    end loop;
    close c_khoa;
end;
--exec p_resetkey


--------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------OLS --------------------------------------------------------------------------

-- Dang nhap vao ADMINBV (DBA)
CREATE TABLE ThongBao(
NoiDung VARCHAR2(4000)
);
GRANT SELECT ON THONGBAO TO QLTNNS1,QLTV1,QLCM1,TT1,TT2,TV1,TV2,BS1,BS2,BT1,BT2,KT1,KT2,KTV1,KTV2;

-- Dang nhap vao LBACSYS
BEGIN
  SA_SYSDBA.CREATE_POLICY(
    policy_name => 'XemThongBao',
    column_name => 'label_tb');
END;
GRANT xemthongbao_dba TO ADMINBV;
GRANT EXECUTE ON sa_components TO ADMINBV;
GRANT EXECUTE ON sa_user_admin TO ADMINBV;
GRANT EXECUTE ON sa_user_admin TO ADMINBV;
GRANT EXECUTE ON sa_label_admin TO ADMINBV;
GRANT EXECUTE ON sa_policy_admin TO ADMINBV;
GRANT EXECUTE ON to_lbac_data_label TO ADMINBV;

-- Dang nhap vao ADMINBV (DBA)
-- 1. Tao level
BEGIN
sa_components.create_level
(policy_name => 'xemthongbao',
long_name => 'Dieu hanh',
short_name => 'DH',
level_num => 9000);
sa_components.create_level
(policy_name => 'xemthongbao',
long_name => 'Quan ly',
short_name => 'QL',
level_num => 8000);
sa_components.create_level
(policy_name => 'xemthongbao',
long_name => 'Nhan vien',
short_name => 'NV',
level_num => 7000);
END;
/
-- 2. Tao compartment
BEGIN
sa_components.create_compartment
(policy_name => 'xemthongbao',
long_name => 'Tai nguyen nhan su',
short_name => 'NS',
comp_num => 5000);
sa_components.create_compartment
(policy_name => 'xemthongbao',
long_name => 'Tai vu',
short_name => 'TV',
comp_num => 1000);
sa_components.create_compartment
(policy_name => 'xemthongbao',
long_name => 'Ke toan',
short_name => 'KT',
comp_num => 100);
sa_components.create_compartment
(policy_name => 'xemthongbao',
long_name => 'Chuyen mon',
short_name => 'CM',
comp_num => 10);
end;
/
-- 3. Tao group
BEGIN
sa_components.CREATE_GROUP
(policy_name => 'xemthongbao',
long_name => 'Ho Chi Minh',
short_name => 'HCM',
group_num => 110,
parent_name => null);
sa_components.CREATE_GROUP
(policy_name => 'xemthongbao',
long_name => 'Ha Noi',
short_name => 'HN',
group_num => 120,
parent_name => null);
END;
/

-- 4. Tao label ( Cho cac thong bao )
begin
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag =>10000 ,
label_value => 'NV'); -- TB1
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 11000,
label_value => 'NV:KT'); -- TB2
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 11100,
label_value => 'NV:NS'); -- TB3
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag =>11200 ,
label_value => 'NV:TV'); -- TB4
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 11010,
label_value => 'NV:KT:HN'); -- TB5
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 11110,
label_value => 'NV:TV:HN'); -- TB6
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 20000,
label_value => 'QL'); -- TB7
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 21000,
label_value => 'QL:KT'); -- TB8
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 21100,
label_value => 'QL:NS'); -- TB9
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 21210,
label_value => 'QL:TV:HN'); -- TB10
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 30000,
label_value => 'DH'); -- TB11
--user
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 32000,
label_value => 'DH:CM,KT,TV,NS:HCM,HN'); -- QLCM1
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 21020,
label_value => 'QL:KT:HCM'); -- KT1
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 21110,
label_value => 'QL:NS:HN'); -- QLTNNS1
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 11020,
label_value => 'NV:KT:HCM '); -- KT2
sa_label_admin.create_label
(policy_name => 'xemthongbao',
label_tag => 11220,
label_value => 'NV:TV:HCM'); -- TV1
END;
/

-- 6. Cai dat user label

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao',
user_name => 'ADMINBV', -- Dieu hanh
max_read_label => 'DH:CM,KT,TV,NS:HCM,HN'); 
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao',
user_name => 'QLCM1', -- Dieu hanh
max_read_label => 'DH:CM,KT,TV,NS:HCM,HN');
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao',
user_name => 'QLTV1', -- Quan ly tai vu HN
max_read_label => 'QL:TV:HN');
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao',
user_name => 'KT1', -- Quan ly phong ke toan hcm
max_read_label => 'QL:KT:HCM');
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao',
user_name => 'QLTNNS1', -- Quan ly phong nhan su HN
max_read_label => 'QL:NS:HN');
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao', 
user_name => 'KT2', --NV Ke toan hcm
max_read_label => 'NV:KT:HCM');
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao',
user_name => 'TV1', -- NV tai vu HCM
max_read_label => 'NV:TV:HCM');
sa_user_admin.set_user_labels
(policy_name => 'xemthongbao',
user_name => 'TV2', -- NV tai vu HN
max_read_label => 'NV:TV:HN');
END;
/

-- AP DUNG POLICY 
begin 
sa_policy_admin.apply_table_policy
(policy_name => 'xemthongbao',
schema_name => 'ADMINBV',
table_name => 'ThongBao',
table_options => 'NO_CONTROL');
end;
/
--- INSERT DU LIEU TEST
INSERT INTO ADMINBV.THONGBAO VALUES('Thong bao hop ban Dieu hanh',char_to_label('xemthongbao', 'DH'));
INSERT INTO ADMINBV.THONGBAO VALUES('Cac quan ly gui bao cao ve nhu cau tuyen them nhan su cua phong minh',char_to_label('xemthongbao', 'QL'));
INSERT INTO ADMINBV.THONGBAO VALUES('Thong bao lich nghi tet Nguyen dan nam 2022',char_to_label('xemthongbao', 'NV'));
INSERT INTO ADMINBV.THONGBAO VALUES('Quan ly tai nguyen nhan su gui bao cao nhan su nam 2021',char_to_label('xemthongbao', 'QL:NS'));
INSERT INTO ADMINBV.THONGBAO VALUES('Quan ly phong Ke toan gui bao cao luong thang 8',char_to_label('xemthongbao', 'QL:KT'));
INSERT INTO ADMINBV.THONGBAO VALUES('Nhan vien phong Ke toan tien hanh tinh luong thang 8',char_to_label('xemthongbao', 'NV:KT'));
INSERT INTO ADMINBV.THONGBAO VALUES('Nhan vien phong Tai Nguyen Nhan Su chuan bi dot tuyen dung',char_to_label('xemthongbao', 'NV:NS'));
INSERT INTO ADMINBV.THONGBAO VALUES('Nhan vien phong Tai Vu gui bao cao thong ke chi phi dich vu',char_to_label('xemthongbao', 'NV:TV'));
INSERT INTO ADMINBV.THONGBAO VALUES('Danh sach nhan vien duoc tang luong phong Ke toan co so Ha Noi',char_to_label('xemthongbao', 'NV:KT:HN'));
INSERT INTO ADMINBV.THONGBAO VALUES('Nhan vien Tai vu co so Ha Noi hop thuong nien',char_to_label('xemthongbao', 'NV:TV:HN'));
INSERT INTO ADMINBV.THONGBAO VALUES('Quan ly phong Tai Vu co so Ha Noi hop gap',char_to_label('xemthongbao', 'QL:TV:HN'));

-- XOA VA AP DUNG LAI POLICY
begin
sa_policy_admin.remove_table_policy
(policy_name => 'xemthongbao',
schema_name => 'ADMINBV',
table_name => 'THONGBAO');
end;
/
begin
sa_policy_admin.apply_table_policy
(policy_name => 'xemthongbao',
schema_name => 'ADMINBV',
table_name => 'THONGBAO',
table_options => 'LABEL_DEFAULT,READ_CONTROL');
end;

-- Dang nhap vao tung nhan vien va test
SELECT NOIDUNG, label_to_char(label_tb) from adminbv.thongbao;


--------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------AUDIT --------------------------------------------------------------------------
--Standard Audit
--Vì b?ng b?nh nhân ch?a thông tin nh?y c?m nên c?n audit l?i t?t c? các hành ??ng 
--select,insert, update và delete cho t?t c? các user( c? thành công và th?t b?i)
AUDIT SELECT, UPDATE, INSERT, DELETE ON ADMINBV.BenhNhan;

--Vì trong ??n thu?c có tính ch?t quan tr?ng c?n ???c theo dõi nên c?n audit l?i các hành ??ng nh? delete, update, insert( c? thành công và th?t b?i)
AUDIT UPDATE, INSERT, DELETE ON ADMINBV.DONTHUOC;

--Ch?m công và tính l??ng nhân viên là nh?ng thông tin c?n ph?i chính xác c?n ph?i theo dõi các hành ??ng trên 2 b?ng này và ng??i th?c hi?n thay ??i trên 2 b?ng này là QL1 (ghi l?i nh?ng ho?t ??ng th?c hi?n thành công)
AUDIT UPDATE, INSERT ON CHAMCONG WHENEVER SUCCESSFUL;
AUDIT UPDATE, INSERT ON PHIEULUONG WHENEVER SUCCESSFUL;

--Th?c hi?n audit trên các thao tác trên role ?? theo dõi các role b? delete, hay ???c create
AUDIT ROLE;

--Th?c hi?n audit các thao tác t?o xóa các th? t?c
AUDIT PROCEDURE;

--Th?c hi?n giám sát ??ng nh?p
AUDIT SESSION;

------------------- FGA -----
-- CS1: Audit cac hanh dong them xoa sua tren bang Phieu Luong, ma nguoi thuc hien khong phai la Ke Toan Vien
create or replace function dk_audit_phieuluong
return number
as
    dv nvarchar2(50);
begin
    dv:= SYS_CONTEXT('nhanvien_ctx','donvi');
if(  dv = 'Bo phan ke toan')
then return 0;
else return 1; 
end if;
end;
/
BEGIN
DBMS_FGA.add_policy
(object_schema => 'ADMINBV',
object_name => 'PHIEULUONG',
policy_name => 'AUDIT_PHIEULUONG',
audit_condition => 'ADMINBV.dk_audit_phieuluong=1',
statement_types    =>  'INSERT, UPDATE, DELETE'
);
END;
/

-- CS2: ghi nhan lai nhung hanh vi cap nhat cot Luong trong NhanVien 
create or replace function DK_AUDIT_LUONG
return number
as
begin
if( SYS_CONTEXT('nhanvien_ctx','donvi') = 'Bo phan quan ly tai nguyen va nhan su')
then return 0;
else return 1; 
end if;
end;
/
BEGIN
DBMS_FGA.add_policy
(object_schema => 'ADMINBV',
object_name => 'NHANVIEN',
policy_name => 'AUDIT_LUONG',
audit_condition => 'ADMINBV.DK_AUDIT_LUONG=1',
audit_column => 'LUONG',
statement_types    =>  'UPDATE'
);
END;

