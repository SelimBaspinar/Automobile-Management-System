-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2022 at 01:24 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `autorepair`
--

-- --------------------------------------------------------

--
-- Table structure for table `car`
--

CREATE TABLE `car` (
  `Id` text NOT NULL,
  `Brand` text NOT NULL,
  `Model` text NOT NULL,
  `Repair_Status` text NOT NULL,
  `Repair_fee` text NOT NULL,
  `Repair_Time` text NOT NULL,
  `Damage_Report` text NOT NULL,
  `Type` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `car_part`
--

CREATE TABLE `car_part` (
  `Id` text NOT NULL,
  `Order_Date` text NOT NULL,
  `Items` text NOT NULL,
  `Count` int(11) NOT NULL,
  `Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `Phone_Number` double NOT NULL,
  `Name` text NOT NULL,
  `Surname` text NOT NULL,
  `Gender` text NOT NULL,
  `Address` text NOT NULL,
  `Email` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Username` text NOT NULL,
  `Role_Id` int(11) NOT NULL,
  `Email` text NOT NULL,
  `Name` text NOT NULL,
  `Surname` text NOT NULL,
  `Gender` text NOT NULL,
  `Address` text NOT NULL,
  `Phone_Number` double NOT NULL,
  `Salary` double NOT NULL,
  `Working_Hours` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `User_Id` int(11) NOT NULL,
  `Username` text NOT NULL,
  `Password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`User_Id`, `Username`, `Password`) VALUES
(0, 'selim587', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `permission`
--

CREATE TABLE `permission` (
  `Role_Id` int(11) NOT NULL,
  `Statistics` int(11) NOT NULL,
  `Salary` int(11) NOT NULL,
  `Car_Part` int(11) NOT NULL,
  `Employee` int(11) NOT NULL,
  `Car` int(11) NOT NULL,
  `Permission` int(11) NOT NULL,
  `Customer` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `statistics`
--

CREATE TABLE `statistics` (
  `Brand` text NOT NULL,
  `Car_Count` int(11) NOT NULL,
  `Repair_Count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
