create table pegawai(
	id_pegawai serial PRIMARY key,
	nama VARCHAR(20) not null,
	email VARCHAR(30) not null,
	password VARCHAR(16) not null
)


CREATE table login(
	id_login serial PRIMARY KEY,
	password varchar (20),
	id_pegawai int not null,
	constraint fk_pegawai foreign Key(id_pegawai) references pegawai(id_pegawai)
)

CREATE table jenis_pembayaran(
	id_pembayaran serial PRIMARY KEY,
	jenis_pembayaran varchar(25) not null
)

create table detail_transaksi(
	id_detail_transaksi serial primary key,
	jumlah_produk int not null,
	jumlah_harga int not null,
	id_produk int not null,
	id_pegawai int not null,
	CONSTRAINT fk_produk foreign KEY(id_produk) references produk(id_produk),
	CONSTRAINT fk_pegawai foreign KEY(id_pegawai) references pegawai(id_pegawai)
)

create table riwayat_transaksi(
	id_riwayat serial PRIMARY key,
	tanggal_transaksi date not null,
	id_pembayaran int not null,
	id_detail_pembayaran int not null,
	CONSTRAINT fk_jenis_pembayaran foreign KEY(id_pembayaran) references jenis_pembayaran(id_pembayaran),
	CONSTRAINT fk_detail_pembayaran foreign KEY(id_detail_pembayaran) references detail_pembayaran(id_detail_pembayaran)
)

create table produk(
	id_produk serial primary key,
	nama varchar(25) not null,
	no_seri varchar(50) not null,
	harga int not null,
	stok int not null
)
