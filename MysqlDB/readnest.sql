-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2025 at 12:24 AM
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
  `ReadDuration` int(11) DEFAULT 0,
  `IsFavorite` tinyint(1) DEFAULT 0,
  `IsWishlist` tinyint(1) DEFAULT 0,
  `Status` enum('Available','Borrowed','Reading','Finished') DEFAULT 'Available',
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `PhotoPath` varchar(255) DEFAULT NULL,
  `FilePath` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`BookId`, `UserId`, `CategoryId`, `Title`, `Description`, `Pages`, `Author`, `ReadDuration`, `IsFavorite`, `IsWishlist`, `Status`, `CreatedAt`, `PhotoPath`, `FilePath`) VALUES
(1, 1, 5, 'Bibi Gill', 'Bagaimana menjadi petarung terkuat di dunia paralel? Dengan latihan panjang dan pengorbanan. Termasuk kehilangan dan kesedihan. Inilah kisah tentang Bibi Gill, yang sejak kecil berusaha mengalahkan \'monster\' dalam hidupnya.\n\nApakah dia bisa menemukan ja', 686, 'Tere Liye', 0, 1, 1, 'Reading', '2025-04-21 17:49:48', 'BookCovers\\238bc441-9e9a-4a5b-8c42-7494366b14b8.png', 'BookFiles\\c7ed4059-8a36-44ba-b065-0db4eb4934d7.pdf'),
(2, 1, 5, 'Bumi', 'foewaj', 498, 'Tere Liye', 0, 0, 0, 'Reading', '2025-04-21 22:16:36', 'BookCovers\\3985a92d-bf47-4358-8b88-2124753d5587.jpg', 'BookFiles\\1fd98679-0118-49cc-87a0-7fbf093602e5.epub'),
(3, 0, 7, 'Test1', 'tidak ada', 1, 'dika', 0, 0, 0, 'Available', '2025-04-22 01:55:02', 'BookCovers\\accf8bc1-15fa-4e14-b69c-e55784ea1da4.png', 'BookFiles\\8da2460f-3cbe-4221-b588-e833269de5bd.pdf'),
(4, 0, 5, 'test2', 'p', 10, 'test2', 0, 0, 0, 'Available', '2025-04-22 01:55:47', 'BookCovers\\9a9f61fb-ec84-4e39-8cec-90d1c125bd0c.png', 'BookFiles\\40b08c29-00bb-4801-8d8d-afd98e3842c8.pdf'),
(11, 1, 2, 'Laporan ProgDesk', '', 5, 'Andrea', 0, 0, 0, 'Reading', '2025-06-02 18:45:48', 'BookCovers\\c96955e2-0742-4db7-9896-43b48f20bbac.jpeg', 'BookFiles\\5ce44d6d-62e9-4aa5-bcd3-70f4cef07b3b.pdf');

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
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `NoteId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Content` text NOT NULL,
  `BookId` int(11) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT current_timestamp(),
  `ModifiedDate` datetime DEFAULT current_timestamp()
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
  `ReadDuration` int(11) DEFAULT 0 COMMENT 'in seconds',
  `LastOpened` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `ProgressPercent` float DEFAULT NULL
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

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserId`, `Username`, `Email`, `Password`, `CreatedAt`) VALUES
(1, 'andrea', 'andrea.baikole@gmail.com', '5f3d6952c5c5e22077fabf461de80f1ce475752fe75afcf5ca46bac438405619', '2025-04-21 11:07:26'),
(2, 'dika', 'dika@gmail.com', 'dda29d2a069f67bfaa0f505b7bc837c0181b39888926a126e9d707828d12b4b4', '2025-04-22 01:49:32'),
(3, 'kevin', 'kevin@gmail.com', '85f5e10431f69bc2a14046a13aabaefc660103b6de7a84f75c4b96181d03f0b5', '2025-05-29 07:32:41');

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
  ADD UNIQUE KEY `idx_bookid` (`BookId`),
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
-- Indexes for table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`NoteId`),
  ADD KEY `FK_notes_UserId` (`UserId`),
  ADD KEY `IX_notes_BookId` (`BookId`),
  ADD KEY `IX_notes_CreatedDate` (`CreatedDate`);

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
  MODIFY `BookId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

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
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `NoteId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `userbookprogress`
--
ALTER TABLE `userbookprogress`
  MODIFY `ProgressId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `fk_books_category` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`CategoryId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_books_user` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `borrowers`
--
ALTER TABLE `borrowers`
  ADD CONSTRAINT `fk_borrowers_book` FOREIGN KEY (`BookId`) REFERENCES `books` (`BookId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `notes`
--
ALTER TABLE `notes`
  ADD CONSTRAINT `FK_notes_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_notes_book` FOREIGN KEY (`BookId`) REFERENCES `books` (`BookId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_notes_user` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `userbookprogress`
--
ALTER TABLE `userbookprogress`
  ADD CONSTRAINT `fk_progress_book` FOREIGN KEY (`BookId`) REFERENCES `books` (`BookId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_progress_user` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `usersessions`
--
ALTER TABLE `usersessions`
  ADD CONSTRAINT `fk_sessions_user` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
