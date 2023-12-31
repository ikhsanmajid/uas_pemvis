-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 13, 2023 at 11:44 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `warnet`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_user`
--

CREATE TABLE `data_user` (
  `id_user` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `jenis_kelamin` enum('Laki-laki','Perempuan','','') NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_user`
--

INSERT INTO `data_user` (`id_user`, `nama`, `jenis_kelamin`, `alamat`, `username`, `password`) VALUES
(2, 'Putri Anya', 'Perempuan', 'Solo', 'putri', '123'),
(8, 'Theodorus', 'Laki-laki', 'Solo', 'theo', '123'),
(10, 'Rendi Buana', 'Laki-laki', 'Blimbing', 'rendib', '123'),
(11, 'Anya', 'Perempuan', 'Solo', 'anya', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `makanan_minuman`
--

CREATE TABLE `makanan_minuman` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `jenis` enum('makanan','minuman','snack','rokok') NOT NULL,
  `harga` int(10) UNSIGNED NOT NULL,
  `stok` int(10) UNSIGNED NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `makanan_minuman`
--

INSERT INTO `makanan_minuman` (`id`, `nama`, `jenis`, `harga`, `stok`, `status`) VALUES
(1, 'Mie Goreng Sedaap', 'makanan', 1000, 1, 1),
(2, 'Mie Rebus Sedaap', 'snack', 1000, 22, 1),
(6, 'Keripik', 'snack', 10000, 100, 1);

-- --------------------------------------------------------

--
-- Table structure for table `status_client`
--

CREATE TABLE `status_client` (
  `kode_client` varchar(5) NOT NULL,
  `ip_address` varchar(15) NOT NULL,
  `status` tinyint(1) NOT NULL,
  `keterangan` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `status_client`
--

INSERT INTO `status_client` (`kode_client`, `ip_address`, `status`, `keterangan`) VALUES
('PC001', '192.168.100.66', 0, 'Keyboard Rusak'),
('PC003', '192.168.1.112', 0, 'Mouse Rusak'),
('PC004', '192.168.100.2', 1, '');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_makanan_minuman`
--

CREATE TABLE `transaksi_makanan_minuman` (
  `id_transaksi` int(11) NOT NULL,
  `id_makanan_minuman` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `sub_harga` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi_makanan_minuman`
--

INSERT INTO `transaksi_makanan_minuman` (`id_transaksi`, `id_makanan_minuman`, `jumlah`, `sub_harga`) VALUES
(1, 2, 1, 1000),
(2, 1, 1, 1000),
(3, 1, 2, 1000),
(4, 1, 2, 1000),
(5, 1, 2, 1000);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_warnet`
--

CREATE TABLE `transaksi_warnet` (
  `id_transaksi` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `jenis_paket` varchar(255) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `total_harga` int(11) NOT NULL,
  `diskon` int(11) NOT NULL,
  `total_bayar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi_warnet`
--

INSERT INTO `transaksi_warnet` (`id_transaksi`, `username`, `jenis_paket`, `harga`, `jumlah`, `total_harga`, `diskon`, `total_bayar`) VALUES
(3, 'theo', 'VIP', 10000, 20, 200000, 10000, 190000),
(4, 'rendib', 'VIP', 10000, 10, 100000, 5000, 95000),
(5, 'anya', 'Reguler', 6000, 10, 60000, 3000, 57000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_user`
--
ALTER TABLE `data_user`
  ADD PRIMARY KEY (`id_user`);

--
-- Indexes for table `makanan_minuman`
--
ALTER TABLE `makanan_minuman`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `status_client`
--
ALTER TABLE `status_client`
  ADD PRIMARY KEY (`kode_client`);

--
-- Indexes for table `transaksi_warnet`
--
ALTER TABLE `transaksi_warnet`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data_user`
--
ALTER TABLE `data_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `makanan_minuman`
--
ALTER TABLE `makanan_minuman`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `transaksi_warnet`
--
ALTER TABLE `transaksi_warnet`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
