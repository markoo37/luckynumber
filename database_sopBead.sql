-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 22, 2024 at 12:39 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `u4ufuk_test`
--

-- --------------------------------------------------------

--
-- Table structure for table `game`
--

CREATE TABLE `game` (
  `game_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `price_to_play` int(11) NOT NULL,
  `reward` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `game`
--

INSERT INTO `game` (`game_id`, `name`, `price_to_play`, `reward`) VALUES
(1, 'number_guess', 500, 3000);

-- --------------------------------------------------------

--
-- Table structure for table `game_switch`
--

CREATE TABLE `game_switch` (
  `user_id` int(11) NOT NULL,
  `game_id` int(11) NOT NULL,
  `win` varchar(255) NOT NULL,
  `date` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `game_switch`
--

INSERT INTO `game_switch` (`user_id`, `game_id`, `win`, `date`) VALUES
(59, 1, 'no', '2024. 01. 18. 20:08:04'),
(59, 1, 'no', '2024. 01. 18. 20:08:09'),
(59, 1, 'no', '2024. 01. 18. 20:08:10'),
(59, 1, 'yes', '2024. 01. 18. 20:08:12'),
(59, 1, 'no', '2024. 01. 18. 20:08:22'),
(59, 1, 'no', '2024. 01. 18. 20:08:28'),
(59, 1, 'yes', '2024. 01. 18. 20:08:30'),
(59, 1, 'no', '2024. 01. 18. 20:08:34'),
(59, 1, 'no', '2024. 01. 18. 20:08:40'),
(59, 1, 'no', '2024. 01. 18. 20:08:42'),
(59, 1, 'no', '2024. 01. 18. 20:08:44'),
(59, 1, 'no', '2024. 01. 18. 20:08:46'),
(59, 1, 'no', '2024. 01. 18. 20:08:47'),
(59, 1, 'yes', '2024. 01. 18. 20:08:49'),
(59, 1, 'no', '2024. 01. 18. 20:08:58'),
(59, 1, 'no', '2024. 01. 18. 20:09:06'),
(59, 1, 'no', '2024. 01. 18. 20:09:07'),
(59, 1, 'no', '2024. 01. 18. 20:09:09'),
(59, 1, 'no', '2024. 01. 18. 20:09:11'),
(59, 1, 'no', '2024. 01. 18. 20:09:13'),
(59, 1, 'no', '2024. 01. 18. 20:09:15'),
(59, 1, 'no', '2024. 01. 18. 20:09:17'),
(59, 1, 'no', '2024. 01. 18. 20:09:20'),
(59, 1, 'no', '2024. 01. 18. 20:09:22'),
(59, 1, 'yes', '2024. 01. 18. 20:09:24'),
(55, 1, 'no', '2024. 01. 21. 23:07:05'),
(55, 1, 'no', '2024. 01. 21. 23:07:09'),
(55, 1, 'no', '2024. 01. 21. 23:07:11'),
(55, 1, 'no', '2024. 01. 21. 23:07:14'),
(55, 1, 'no', '2024. 01. 21. 23:07:16'),
(55, 1, 'no', '2024. 01. 21. 23:07:18'),
(55, 1, 'no', '2024. 01. 21. 23:07:20'),
(55, 1, 'no', '2024. 01. 21. 23:07:22'),
(55, 1, 'no', '2024. 01. 21. 23:07:24'),
(55, 1, 'yes', '2024. 01. 21. 23:07:26'),
(59, 1, 'no', '2024. 01. 21. 23:08:41'),
(59, 1, 'no', '2024. 01. 21. 23:08:47'),
(59, 1, 'no', '2024. 01. 21. 23:08:50'),
(59, 1, 'no', '2024. 01. 21. 23:08:52'),
(59, 1, 'no', '2024. 01. 21. 23:08:54'),
(59, 1, 'no', '2024. 01. 21. 23:08:56'),
(59, 1, 'yes', '2024. 01. 21. 23:08:58');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `balance` int(11) NOT NULL,
  `user_type_id` int(11) NOT NULL,
  `how_many_wins` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `balance`, `user_type_id`, `how_many_wins`) VALUES
(1, 'mark', '5d41402abc4b2a76b9719d911017c592', 0, 2, 0),
(55, 'Test', '900150983cd24fb0d6963f7d28e17f72', 48000, 1, 1),
(59, 'Genious', '900150983cd24fb0d6963f7d28e17f72', 9000, 1, 5);

-- --------------------------------------------------------

--
-- Table structure for table `user_type`
--

CREATE TABLE `user_type` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_type`
--

INSERT INTO `user_type` (`id`, `name`) VALUES
(1, 'user'),
(2, 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `game`
--
ALTER TABLE `game`
  ADD PRIMARY KEY (`game_id`);

--
-- Indexes for table `game_switch`
--
ALTER TABLE `game_switch`
  ADD KEY `u` (`user_id`),
  ADD KEY `g` (`game_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `type` (`user_type_id`);

--
-- Indexes for table `user_type`
--
ALTER TABLE `user_type`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `game`
--
ALTER TABLE `game`
  MODIFY `game_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;

--
-- AUTO_INCREMENT for table `user_type`
--
ALTER TABLE `user_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `game_switch`
--
ALTER TABLE `game_switch`
  ADD CONSTRAINT `g` FOREIGN KEY (`game_id`) REFERENCES `game` (`game_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `u` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `type` FOREIGN KEY (`user_type_id`) REFERENCES `user_type` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
