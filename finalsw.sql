-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 10, 2023 at 01:36 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `finalsw`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `idCustomer` varchar(50) NOT NULL,
  `nameCustomer` varchar(50) NOT NULL,
  `passCustomer` varchar(50) NOT NULL,
  `phoneCustomer` varchar(50) NOT NULL,
  `addressCustomer` varchar(255) NOT NULL,
  `emailCustomer` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`idCustomer`, `nameCustomer`, `passCustomer`, `phoneCustomer`, `addressCustomer`, `emailCustomer`) VALUES
('cus1', 'Khach hang 1', 'e10adc3949ba59abbe56e057f20f883e', '01234567', '77 Hùng Vương phường 1 quận 10 HCM', 'goila.an12@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `detailorder`
--

CREATE TABLE `detailorder` (
  `id` int(255) NOT NULL,
  `idItem` varchar(50) NOT NULL,
  `idOrder` int(50) NOT NULL,
  `quantity` int(255) NOT NULL,
  `price` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `detailorder`
--

INSERT INTO `detailorder` (`id`, `idItem`, `idOrder`, `quantity`, `price`) VALUES
(24, 'it9', 23, 2, 90),
(25, 'it9', 24, 2, 90),
(26, 'it9', 25, 2, 90),
(27, 'it6', 26, 4, 1300),
(28, 'it8', 26, 2, 100),
(29, 'it7', 27, 2, 1000),
(30, 'it8', 27, 5, 100),
(31, 'it4', 28, 2, 200),
(32, 'it7', 29, 2, 1000),
(33, 'it9', 30, 2, 90),
(34, 'it9', 31, 1, 90),
(35, 'it9', 32, 1, 90),
(36, 'it9', 33, 2, 90),
(37, 'it9', 34, 5, 90),
(38, 'it9', 35, 2, 90),
(39, 'it9', 36, 2, 90),
(40, 'it9', 37, 1, 90),
(41, 'it8', 38, 4, 100),
(42, 'it9', 39, 1, 90),
(43, 'it8', 40, 4, 100),
(44, 'it8', 41, 4, 100),
(45, 'it9', 42, 3, 90);

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `idItem` varchar(50) NOT NULL,
  `nameItem` varchar(50) NOT NULL,
  `priceItem` int(255) NOT NULL,
  `image` varchar(500) NOT NULL,
  `inventory` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`idItem`, `nameItem`, `priceItem`, `image`, `inventory`) VALUES
('it1', 'Samsung Galaxy S23 5G', 818, 'it1.jpg', 100),
('it2', 'Samsung Galaxy S23 Ultra 5G', 1400, 'it2.jpg', 100),
('it3', 'Samsung Galaxy S23+ 5G', 1200, 'it3.jpg', 100),
('it4', 'realme C55', 200, 'it4.jpg', 30),
('it5', 'Oppo Find N2', 900, 'it5.jpg', 70),
('it6', 'iPhone 14 Pro Max', 1300, 'it6.jpg', 100),
('it7', 'iPhone 14 Plus', 1000, 'it7.jpg', 100),
('it8', 'realme C30s', 100, 'it8.jpg', 40),
('it9', 'realme 10', 90, 'it9.jpg', 40);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `idOrder` int(50) NOT NULL,
  `idCustomer` varchar(50) NOT NULL,
  `paymentMethod` enum('q','m') NOT NULL,
  `creationDate` date NOT NULL,
  `totalPrice` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`idOrder`, `idCustomer`, `paymentMethod`, `creationDate`, `totalPrice`) VALUES
(23, 'cus1', 'q', '0000-00-00', 180),
(24, 'cus1', 'q', '0000-00-00', 180),
(25, 'cus1', 'q', '0000-00-00', 180),
(26, 'cus1', 'q', '0000-00-00', 5400),
(27, 'cus1', 'q', '0000-00-00', 2500),
(28, 'cus1', 'm', '0000-00-00', 400),
(29, 'cus1', 'q', '0000-00-00', 2000),
(30, 'cus1', 'q', '0000-00-00', 180),
(31, 'cus1', 'q', '0000-00-00', 90),
(32, 'cus1', 'q', '0000-00-00', 90),
(33, 'cus1', 'm', '0000-00-00', 180),
(34, 'cus1', 'q', '0000-00-00', 450),
(35, 'cus1', 'q', '0000-00-00', 180),
(36, 'cus1', 'q', '0000-00-00', 180),
(37, 'cus1', 'q', '0000-00-00', 90),
(38, 'cus1', 'm', '0000-00-00', 400),
(39, 'cus1', 'q', '0000-00-00', 90),
(40, 'cus1', 'q', '0000-00-00', 400),
(41, 'cus1', 'q', '0000-00-00', 400),
(42, 'cus1', 'q', '0000-00-00', 270);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`idCustomer`);

--
-- Indexes for table `detailorder`
--
ALTER TABLE `detailorder`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idItem` (`idItem`),
  ADD KEY `idOrder` (`idOrder`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`idItem`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`idOrder`),
  ADD KEY `idCustomer` (`idCustomer`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detailorder`
--
ALTER TABLE `detailorder`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `idOrder` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detailorder`
--
ALTER TABLE `detailorder`
  ADD CONSTRAINT `idItem` FOREIGN KEY (`idItem`) REFERENCES `item` (`idItem`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `idOrder` FOREIGN KEY (`idOrder`) REFERENCES `orders` (`idOrder`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `idCustomer` FOREIGN KEY (`idCustomer`) REFERENCES `customer` (`idCustomer`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
