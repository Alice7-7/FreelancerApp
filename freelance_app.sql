-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 04, 2025 at 05:41 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `freelance_app`
--

-- --------------------------------------------------------

--
-- Table structure for table `bids`
--

CREATE TABLE `bids` (
  `id` int(11) NOT NULL,
  `project_id` int(11) NOT NULL,
  `freelancer_username` varchar(100) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `days` text NOT NULL,
  `proposal` text DEFAULT NULL,
  `status` text NOT NULL,
  `completed_` tinyint(1) NOT NULL,
  `bid_date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bids`
--

INSERT INTO `bids` (`id`, `project_id`, `freelancer_username`, `amount`, `days`, `proposal`, `status`, `completed_`, `bid_date`) VALUES
(1, 24, 'michelle', 12500.00, '2025-10-02', 'I have experienced enough to make this project wonderful . You will be surprised !', 'completed', 1, '2025-08-03 11:26:25'),
(2, 25, 'tony', 22500.00, '2025-10-15', 'I\'\'m good', 'completed', 1, '2025-08-04 02:19:16'),
(3, 26, 'tony', 42500.00, '2025-10-20', 'We are really good at hacking', 'completed', 1, '2025-08-04 02:42:48'),
(4, 1, 'michelle', 25000.00, '2025-12-10', 'I have a team for make secure and strong android application', 'completed', 1, '2025-08-04 10:58:20'),
(5, 4, 'stephan', 73000.00, '2025-11-10', 'I have experienced enough for developing security tools', 'Pending', 0, '2025-08-04 15:09:16');

-- --------------------------------------------------------

--
-- Table structure for table `client_info`
--

CREATE TABLE `client_info` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `org_name` text DEFAULT NULL,
  `b_email` varchar(255) DEFAULT NULL,
  `location` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client_info`
--

INSERT INTO `client_info` (`id`, `username`, `full_name`, `org_name`, `b_email`, `location`) VALUES
(1, 'lucy', 'lucy', 'Mable Inc', 'lucy@mable.org', 'Central London. UK'),
(2, 'quzzle', 'K Khaing', 'Zara Inc', 'quzzle@zara.com', 'London. United Kingdom');

-- --------------------------------------------------------

--
-- Table structure for table `freelancer_pf`
--

CREATE TABLE `freelancer_pf` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `skills` text DEFAULT NULL,
  `expertise` text DEFAULT NULL,
  `past_work` text DEFAULT NULL,
  `bio` text DEFAULT NULL,
  `location` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `freelancer_pf`
--

INSERT INTO `freelancer_pf` (`id`, `username`, `name`, `skills`, `expertise`, `past_work`, `bio`, `location`) VALUES
(1, 'stephan', 'Stephan', 'python , Digital Forensics, Threat Hunt, security tools', 'Digital Forensics', 'Security Analyst', 'Blue Team professional . expertise in Digital Forensic , developing security tools', 'Edinburgh . Scotland'),
(2, 'michelle', 'Michelle', 'Java , Kotlin , Flutter developer', 'Android Developer', 'QA Tester', 'Expertise in Android developing .', 'Sunderland , United Kingdom'),
(3, 'mia', 'Mia', 'React , Next JS , Graph QL , Firebase', 'Web Developer', 'Web Designer', 'Experienced in web developing for 4 yrs +', 'Sydney . Australia');

-- --------------------------------------------------------

--
-- Table structure for table `notifications`
--

CREATE TABLE `notifications` (
  `id` int(11) NOT NULL,
  `receiver_role` varchar(20) DEFAULT NULL,
  `message` text NOT NULL,
  `read_` tinyint(1) DEFAULT 0,
  `created_at` datetime DEFAULT current_timestamp(),
  `sender_role` varchar(50) DEFAULT NULL,
  `receiver_username` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `notifications`
--

INSERT INTO `notifications` (`id`, `receiver_role`, `message`, `read_`, `created_at`, `sender_role`, `receiver_username`) VALUES
(1, 'freelancer', 'Mable \n from Mable Inc', 0, '2025-08-04 17:17:20', NULL, NULL),
(2, 'freelancer', 'Zara \n from Zara Inc', 0, '2025-08-04 17:44:17', NULL, NULL),
(3, 'freelancer', 'Cyberdyne \n from Zara Inc', 0, '2025-08-04 18:05:39', NULL, NULL),
(4, 'freelancer', 'Threat V \n from Mable Inc', 0, '2025-08-04 21:06:20', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

CREATE TABLE `projects` (
  `id` int(11) NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `org_name` varchar(255) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `pj_deadline` text NOT NULL,
  `budget` decimal(10,2) DEFAULT NULL,
  `prerequisites` text NOT NULL,
  `image` varchar(255) DEFAULT NULL,
  `reviewed` tinyint(1) NOT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `projects`
--

INSERT INTO `projects` (`id`, `title`, `org_name`, `description`, `pj_deadline`, `budget`, `prerequisites`, `image`, `reviewed`, `created_by`, `created_at`) VALUES
(1, 'Mable', 'Mable Inc', 'Mobile Application Defender', 'Saturday, December 20, 2025', 24000.00, 'Java , python , Kotlin', 'images/f99c23d4-40bc-4cc5-9b5e-40d45a4b5023.png', 1, 'lucy', '2025-08-04 17:17:20'),
(2, 'Zara', 'Zara Inc', 'E-Commerce Web Application', 'Friday, October 10, 2025', 16000.00, 'React , Next Js ', 'images/6741d08d-2d7a-49f2-836d-cbd13b81d2ed.png', 0, 'quzzle', '2025-08-04 17:44:17'),
(3, 'Cyberdyne', 'Zara Inc', 'End Point Protection', 'Tuesday, Aug 22, 2025', 45000.00, 'C/C++ , python ', 'images/53e25155-441a-4943-adde-14da67a49283.png', 0, 'quzzle', '2025-08-04 18:05:39'),
(4, 'Threat V', 'Mable Inc', 'Forensic automate analysis and Detection', 'Tuesday, Nov 27, 2025', 72000.00, 'C/C++ , python , security tools development', 'images/bb6d05eb-7064-4265-90db-d11c1f0c7789.png', 0, 'lucy', '2025-08-04 21:06:20');

-- --------------------------------------------------------

--
-- Table structure for table `reviews`
--

CREATE TABLE `reviews` (
  `id` int(11) NOT NULL,
  `project_id` int(11) NOT NULL,
  `freelancer_username` varchar(100) NOT NULL,
  `client_username` varchar(100) NOT NULL,
  `rating` int(11) DEFAULT NULL CHECK (`rating` between 1 and 5),
  `comment` text DEFAULT NULL,
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reviews`
--

INSERT INTO `reviews` (`id`, `project_id`, `freelancer_username`, `client_username`, `rating`, `comment`, `created_at`) VALUES
(1, 1, 'michelle', 'lucy', 5, 'We like your project . We appreciated it. ', '2025-08-04 17:31:55');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `salt` varchar(255) NOT NULL,
  `role` varchar(50) NOT NULL,
  `Created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `salt`, `role`, `Created_at`) VALUES
(1, 'lucy', 'eKVb+rK7ZMVTjfB5c4bataxyOB0SsOZN0uh19HJqg5U=', 'cAAJkd+7mSGzgOScbwQ78w==', 'Client', '2025-08-04 17:05:09'),
(2, 'stephan', '2lmRk/i/Fwq981eDH7ABNYl4KdQTiuD7x0hLUCFgQT8=', 'dNF9c0lZlXukPc0QLfukkA==', 'Freelancer', '2025-08-04 17:18:32'),
(3, 'michelle', 'mBhe+LQKV+uwSSmbp41JzcVomKhy3fct7fiErXIez2Y=', 'wXeA4sfu2HwBZY8H4nteCw==', 'Freelancer', '2025-08-04 17:23:29'),
(4, 'quzzle', 'ZCLglcRoRgZECiZTzgpSgAWVHX+vLRHI0jxIE6R46YI=', 'HqwaDa+vNBCupCYItBT3/Q==', 'Client', '2025-08-04 17:36:57'),
(5, 'mia', 'aK5CCPeB4HoSCGhJ77c5QYUXB0IQX9f+UYuRrfXIYT4=', 'uMZLRqUcql2kp/I1utyS3A==', 'Freelancer', '2025-08-04 17:46:37');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bids`
--
ALTER TABLE `bids`
  ADD PRIMARY KEY (`id`),
  ADD KEY `project_id` (`project_id`),
  ADD KEY `freelancer_username` (`freelancer_username`);

--
-- Indexes for table `client_info`
--
ALTER TABLE `client_info`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `freelancer_pf`
--
ALTER TABLE `freelancer_pf`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `notifications`
--
ALTER TABLE `notifications`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `projects`
--
ALTER TABLE `projects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `reviews`
--
ALTER TABLE `reviews`
  ADD PRIMARY KEY (`id`),
  ADD KEY `project_id` (`project_id`),
  ADD KEY `freelancer_username` (`freelancer_username`),
  ADD KEY `client_username` (`client_username`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bids`
--
ALTER TABLE `bids`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `client_info`
--
ALTER TABLE `client_info`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `freelancer_pf`
--
ALTER TABLE `freelancer_pf`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `notifications`
--
ALTER TABLE `notifications`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `projects`
--
ALTER TABLE `projects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `reviews`
--
ALTER TABLE `reviews`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `client_info`
--
ALTER TABLE `client_info`
  ADD CONSTRAINT `client_info_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `freelancer_pf`
--
ALTER TABLE `freelancer_pf`
  ADD CONSTRAINT `freelancer_pf_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`);

--
-- Constraints for table `reviews`
--
ALTER TABLE `reviews`
  ADD CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`project_id`) REFERENCES `projects` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `reviews_ibfk_2` FOREIGN KEY (`freelancer_username`) REFERENCES `users` (`username`) ON DELETE CASCADE,
  ADD CONSTRAINT `reviews_ibfk_3` FOREIGN KEY (`client_username`) REFERENCES `users` (`username`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
