-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 09, 2025 at 10:53 AM
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
-- Database: `readnest`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `BookId` int(11) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Pages` int(11) DEFAULT NULL,
  `Author` varchar(255) DEFAULT NULL,
  `LastSeen` timestamp NULL DEFAULT NULL,
  `ReadDuration` int(11) DEFAULT 0,
  `IsFavorite` tinyint(1) DEFAULT 0,
  `IsWishlist` tinyint(1) DEFAULT 0,
  `Status` enum('Available','Borrowed','Reading') DEFAULT 'Available',
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `PhotoPath` varchar(255) DEFAULT NULL,
  `FilePath` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `borrowers`
--

CREATE TABLE `borrowers` (
  `BorrowerId` int(11) NOT NULL,
  `BookId` int(11) NOT NULL,
  `BorrowerName` varchar(255) NOT NULL,
  `BorrowDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `ReturnDate` timestamp NULL DEFAULT NULL,
  `IsReturned` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `CategoryId` int(11) NOT NULL,
  `CategoryName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `readingsessions`
--

CREATE TABLE `readingsessions` (
  `SessionId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `BookId` int(11) NOT NULL,
  `StartTime` timestamp NOT NULL DEFAULT current_timestamp(),
  `EndTime` timestamp NULL DEFAULT NULL,
  `Duration` int(11) DEFAULT NULL COMMENT 'in seconds'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `userbookprogress`
--

CREATE TABLE `userbookprogress` (
  `ProgressId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `BookId` int(11) NOT NULL,
  `LastPage` int(11) DEFAULT 1,
  `ReadDuration` int(11) DEFAULT 0 COMMENT 'in minutes',
  `LastOpened` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserId` int(11) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usersessions`
--

CREATE TABLE `usersessions` (
  `SessionId` varchar(36) NOT NULL,
  `UserId` int(11) NOT NULL,
  `LoginTime` datetime NOT NULL,
  `ExpiryTime` datetime NOT NULL,
  `LastActivity` datetime NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `IsPersistent` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`BookId`),
  ADD KEY `CategoryId` (`CategoryId`);

--
-- Indexes for table `borrowers`
--
ALTER TABLE `borrowers`
  ADD PRIMARY KEY (`BorrowerId`),
  ADD KEY `BookId` (`BookId`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`CategoryId`),
  ADD UNIQUE KEY `CategoryName` (`CategoryName`);

--
-- Indexes for table `readingsessions`
--
ALTER TABLE `readingsessions`
  ADD PRIMARY KEY (`SessionId`),
  ADD KEY `UserId` (`UserId`),
  ADD KEY `BookId` (`BookId`);

--
-- Indexes for table `userbookprogress`
--
ALTER TABLE `userbookprogress`
  ADD PRIMARY KEY (`ProgressId`),
  ADD UNIQUE KEY `UserId` (`UserId`,`BookId`),
  ADD KEY `BookId` (`BookId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserId`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `usersessions`
--
ALTER TABLE `usersessions`
  ADD PRIMARY KEY (`SessionId`),
  ADD KEY `UserId` (`UserId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `BookId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `borrowers`
--
ALTER TABLE `borrowers`
  MODIFY `BorrowerId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `readingsessions`
--
ALTER TABLE `readingsessions`
  MODIFY `SessionId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `userbookprogress`
--
ALTER TABLE `userbookprogress`
  MODIFY `ProgressId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`CategoryId`) ON DELETE CASCADE;

--
-- Constraints for table `borrowers`
--
ALTER TABLE `borrowers`
  ADD CONSTRAINT `borrowers_ibfk_1` FOREIGN KEY (`BookId`) REFERENCES `books` (`BookId`) ON DELETE CASCADE;

--
-- Constraints for table `readingsessions`
--
ALTER TABLE `readingsessions`
  ADD CONSTRAINT `readingsessions_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE,
  ADD CONSTRAINT `readingsessions_ibfk_2` FOREIGN KEY (`BookId`) REFERENCES `books` (`BookId`) ON DELETE CASCADE;

--
-- Constraints for table `userbookprogress`
--
ALTER TABLE `userbookprogress`
  ADD CONSTRAINT `userbookprogress_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE,
  ADD CONSTRAINT `userbookprogress_ibfk_2` FOREIGN KEY (`BookId`) REFERENCES `books` (`BookId`) ON DELETE CASCADE;

--
-- Constraints for table `usersessions`
--
ALTER TABLE `usersessions`
  ADD CONSTRAINT `usersessions_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
