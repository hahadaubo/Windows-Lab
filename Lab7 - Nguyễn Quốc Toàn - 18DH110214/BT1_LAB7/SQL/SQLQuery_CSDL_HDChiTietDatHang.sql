Create table HDChiTietDatHang(
	MSDH varchar(10) ,
	MSHH varchar(10),
	SoLuong int not null,
	TiLeGiam int ,
	PRIMARY KEY (MSDH,MSHH)
);