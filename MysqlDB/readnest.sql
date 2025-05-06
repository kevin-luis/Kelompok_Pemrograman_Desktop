-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 06, 2025 at 04:08 PM
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
  `UserId` int(11) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Description` text DEFAULT NULL,
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

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`BookId`, `UserId`, `CategoryId`, `Title`, `Description`, `Pages`, `Author`, `LastSeen`, `ReadDuration`, `IsFavorite`, `IsWishlist`, `Status`, `CreatedAt`, `PhotoPath`, `FilePath`) VALUES
(1, 0, 5, 'Bibi Gill', 'Bagaimana menjadi petarung terkuat di dunia paralel? Dengan latihan panjang dan pengorbanan. Termasuk kehilangan dan kesedihan. Inilah kisah tentang Bibi Gill, yang sejak kecil berusaha mengalahkan \'monster\' dalam hidupnya.\r\n\r\nApakah dia bisa menemukan ja', 686, 'Tere Liye', NULL, 0, 1, 1, 'Borrowed', '2025-04-21 17:49:48', 'BookCovers\\238bc441-9e9a-4a5b-8c42-7494366b14b8.png', 'BookFiles\\c7ed4059-8a36-44ba-b065-0db4eb4934d7.pdf'),
(2, 0, 5, 'Bumi', 'foewaj', 498, 'Tere Liye', NULL, 0, 0, 0, 'Available', '2025-04-21 22:16:36', 'BookCovers\\3985a92d-bf47-4358-8b88-2124753d5587.jpg', 'BookFiles\\1fd98679-0118-49cc-87a0-7fbf093602e5.epub'),
(3, 0, 7, 'Test1', 'tidak ada', 1, 'dika', NULL, 0, 0, 0, 'Available', '2025-04-22 01:55:02', 'BookCovers\\accf8bc1-15fa-4e14-b69c-e55784ea1da4.png', 'BookFiles\\8da2460f-3cbe-4221-b588-e833269de5bd.pdf'),
(4, 0, 5, 'test2', 'p', 10, 'test2', NULL, 0, 0, 0, 'Available', '2025-04-22 01:55:47', 'BookCovers\\9a9f61fb-ec84-4e39-8cec-90d1c125bd0c.png', 'BookFiles\\40b08c29-00bb-4801-8d8d-afd98e3842c8.pdf'),
(5, 2, 2, 'foia;sjdo', 'f;lewamk;l', 3, 'fssladkm', NULL, 0, 0, 0, 'Available', '2025-05-05 20:33:40', 'BookCovers\\dc6a928e-d827-40e8-83c8-5fcceda6dfb4.png', 'BookFiles\\40b6fe54-4792-4079-a22c-5b5a4fdb62a4.pdf');

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

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`CategoryId`, `CategoryName`) VALUES
(2, 'Academy'),
(1, 'Biography'),
(7, 'Comic'),
(6, 'History'),
(8, 'Horror'),
(5, 'Novel'),
(4, 'Romance'),
(3, 'Techno');

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

--
-- Dumping data for table `userbookprogress`
--

INSERT INTO `userbookprogress` (`ProgressId`, `UserId`, `BookId`, `LastPage`, `ReadDuration`, `LastOpened`) VALUES
(1, 1, 1, 17, 5378, '2025-04-22 01:25:00'),
(5, 1, 2, 1, 5, '2025-04-22 01:21:15'),
(14, 2, 1, 15, 2, '2025-04-22 02:00:58'),
(15, 2, 2, 1, 2, '2025-04-22 02:03:05');

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

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserId`, `Username`, `Email`, `Password`, `CreatedAt`) VALUES
(1, 'andrea', 'andrea.baikole@gmail.com', '5f3d6952c5c5e22077fabf461de80f1ce475752fe75afcf5ca46bac438405619', '2025-04-21 11:07:26'),
(2, 'dika', 'dika@gmail.com', 'dda29d2a069f67bfaa0f505b7bc837c0181b39888926a126e9d707828d12b4b4', '2025-04-22 01:49:32');

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
-- Dumping data for table `usersessions`
--

INSERT INTO `usersessions` (`SessionId`, `UserId`, `LoginTime`, `ExpiryTime`, `LastActivity`, `IsActive`, `IsPersistent`) VALUES
('0c7625e5-1bee-4387-bbf2-906a54eef18e', 1, '2025-05-06 03:34:31', '2025-06-06 03:34:31', '2025-05-06 11:05:56', 0, 1),
('3287bee6-9ae7-40eb-98c3-3483ec98fe37', 1, '2025-05-06 20:50:36', '2025-06-06 20:50:36', '2025-05-06 20:57:50', 0, 1),
('3ce6143a-fe23-4821-a8b0-3e1b68b04605', 1, '2025-04-21 18:07:38', '2025-05-21 18:07:38', '2025-04-22 08:41:46', 0, 1),
('3f8aa9bf-6165-494e-baff-bd2e17013f6c', 2, '2025-05-06 02:57:39', '2025-06-06 02:57:39', '2025-05-06 02:57:39', 0, 1),
('4fdea299-0961-4f71-9d91-a4682c677b4c', 2, '2025-05-06 02:46:00', '2025-06-06 02:46:00', '2025-05-06 02:46:00', 0, 1),
('69126522-f2c3-4238-82f5-6cddf07c9493', 2, '2025-05-06 20:58:11', '2025-06-06 20:58:11', '2025-05-06 20:58:50', 0, 1),
('7903c7f2-e3a4-4d8d-9ae5-095b39223551', 1, '2025-05-06 02:46:42', '2025-06-06 02:46:42', '2025-05-06 02:56:44', 0, 1),
('847e480f-76b4-4b6d-a01e-232637c0729d', 2, '2025-04-22 08:51:45', '2025-05-22 08:51:45', '2025-04-22 09:14:47', 1, 1),
('86280f97-4a60-478b-aa0b-140eebe4d3d7', 2, '2025-04-22 08:50:16', '2025-05-22 08:50:15', '2025-04-22 08:50:16', 0, 1),
('c1fe9b9a-2ee1-415e-ad15-fe302c57e335', 1, '2025-05-06 11:08:11', '2025-06-06 11:08:11', '2025-05-06 11:08:16', 0, 1),
('d0ec7764-3d89-4427-a475-922a18110566', 2, '2025-05-06 03:24:32', '2025-06-06 03:24:32', '2025-05-06 03:29:42', 0, 1),
('e579e489-795b-4b52-a06b-c01a7b7bdb15', 2, '2025-05-06 11:07:55', '2025-06-06 11:07:55', '2025-05-06 11:07:55', 0, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`BookId`),
  ADD KEY `CategoryId` (`CategoryId`),
  ADD KEY `UserId` (`UserId`);

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
  MODIFY `BookId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `borrowers`
--
ALTER TABLE `borrowers`
  MODIFY `BorrowerId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `readingsessions`
--
ALTER TABLE `readingsessions`
  MODIFY `SessionId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `userbookprogress`
--
ALTER TABLE `userbookprogress`
  MODIFY `ProgressId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`CategoryId`) ON DELETE CASCADE,
  ADD CONSTRAINT `books_ibfk_2` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE;

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
