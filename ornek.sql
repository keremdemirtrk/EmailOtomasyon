-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 06, 2017 at 11:24 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ktucec`
--

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `Number` int(11) NOT NULL,
  `Name` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `Surname` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `Class` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Mail` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `Tel_number` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `Ucret` varchar(7) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`Number`, `Name`, `Surname`, `Class`, `Mail`, `Tel_number`, `Ucret`) VALUES
(295046, 'furkan', 'mut', '4. SINIF/2.ÖGRETIM', 'furkan.mut@ceng.ktu.edu.tr', '.....', 'Ödemedi'),
(313931, 'Hasan', 'Yilmaz', '2. SINIF/1.ÖGRETIM', 'hsnylmz2861@gmail.com', '.....', 'Ödedi'),
(3483675, 'kerim', 'demirtürk', '1', 'keremdemirtrk@gmail.com', '0', '');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `Id` int(11) NOT NULL,
  `Username` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  `Pass` varchar(250) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`Id`, `Username`, `Pass`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`Number`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
