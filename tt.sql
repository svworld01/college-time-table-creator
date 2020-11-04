-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 28, 2018 at 01:54 PM
-- Server version: 10.1.8-MariaDB
-- PHP Version: 5.6.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tt`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`) VALUES
(1, 'admin', '123');

-- --------------------------------------------------------

--
-- Table structure for table `branch`
--

CREATE TABLE `branch` (
  `bcode` int(11) NOT NULL,
  `bname` varchar(50) NOT NULL,
  `byear` int(11) DEFAULT NULL,
  `bshift` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `branch`
--

INSERT INTO `branch` (`bcode`, `bname`, `byear`, `bshift`) VALUES
(100, 'Information Technology', 3, 1),
(120, 'Mechanical Engineering', 3, 1),
(1234, 'ssshftkugn', 1, 1),
(12345, 'dasyudhklah', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `scode` int(11) NOT NULL,
  `sname` varchar(50) NOT NULL,
  `bcode` int(11) DEFAULT NULL,
  `years` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`scode`, `sname`, `bcode`, `years`) VALUES
(120, 'ak', 1234, 3),
(121, 'ka', 12345, 12),
(130, 'DDD', 1234, 3),
(301, 'DLD', 100, 1),
(302, 'DM', 100, 1),
(303, 'DS', 100, 1),
(304, 'CO', 100, 1),
(305, 'EE', 100, 1),
(306, 'MP', 100, 1),
(307, 'MATH3', 100, 2),
(308, 'TOC', 100, 2),
(309, 'ITC', 100, 2),
(310, 'OS', 100, 2),
(311, 'SE', 100, 2),
(312, 'HVPE', 100, 2),
(900, 'SUB1', 120, 1),
(901, 'SUB2', 120, 1),
(903, 'SUB3', 120, 1),
(907, 'njs', 120, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tchsub`
--

CREATE TABLE `tchsub` (
  `tid` int(11) NOT NULL,
  `scode` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tchsub`
--

INSERT INTO `tchsub` (`tid`, `scode`) VALUES
(4, 120),
(4, 121),
(4, 130),
(100, 120),
(100, 121),
(101, 120),
(500, 301),
(500, 302),
(500, 900),
(501, 303),
(501, 308),
(501, 901),
(502, 304),
(502, 309),
(503, 305),
(503, 312),
(503, 903),
(504, 306),
(504, 307),
(504, 312),
(505, 310),
(505, 311);

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `tid` int(11) NOT NULL,
  `tname` varchar(50) NOT NULL,
  `tshort` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`tid`, `tname`, `tshort`) VALUES
(4, 'Hello', 'S'),
(100, 'jjjj', 'jj'),
(101, 'kkkk', 'kk'),
(500, 'Mohan Singh', 'MS'),
(501, 'Shravan Pandey', 'SP'),
(502, 'Ramesh Upadhyay', 'RU'),
(503, 'Rani Singh', 'RS'),
(504, 'John Sain', 'JS'),
(505, 'Varunn Singh', 'VS'),
(506, 'John ', 'JN'),
(507, 'John2', 'JN2');

-- --------------------------------------------------------

--
-- Table structure for table `timetable`
--

CREATE TABLE `timetable` (
  `ttid` int(11) NOT NULL,
  `bcode` int(11) NOT NULL,
  `day` int(11) NOT NULL,
  `lect` int(11) NOT NULL,
  `scode` int(11) NOT NULL,
  `tid` int(11) NOT NULL,
  `years` int(11) NOT NULL,
  `bshift` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `timetable`
--

INSERT INTO `timetable` (`ttid`, `bcode`, `day`, `lect`, `scode`, `tid`, `years`, `bshift`) VALUES
(1, 100, 6, 1, 307, 504, 2, 1),
(2, 100, 1, 1, 301, 500, 1, 1),
(3, 100, 1, 2, 302, 500, 1, 1),
(4, 100, 1, 3, 303, 501, 1, 1),
(5, 100, 1, 4, 304, 502, 1, 1),
(6, 100, 1, 5, 305, 503, 1, 1),
(7, 100, 1, 6, 306, 504, 1, 1),
(8, 100, 2, 1, 306, 504, 1, 1),
(9, 100, 2, 2, 305, 503, 1, 1),
(10, 100, 2, 3, 304, 502, 1, 1),
(11, 100, 2, 4, 303, 501, 1, 1),
(12, 100, 2, 5, 302, 500, 1, 1),
(13, 100, 2, 6, 301, 500, 1, 1),
(14, 100, 3, 1, 301, 500, 1, 1),
(15, 100, 3, 2, 302, 500, 1, 1),
(16, 100, 3, 3, 303, 501, 1, 1),
(17, 100, 3, 4, 304, 502, 1, 1),
(18, 100, 3, 5, 305, 503, 1, 1),
(19, 100, 3, 6, 306, 504, 1, 1),
(20, 100, 4, 1, 301, 500, 1, 1),
(21, 100, 4, 2, 302, 500, 1, 1),
(22, 100, 4, 3, 303, 501, 1, 1),
(23, 100, 4, 4, 304, 502, 1, 1),
(24, 100, 4, 5, 305, 503, 1, 1),
(25, 100, 4, 6, 306, 504, 1, 1),
(26, 100, 5, 1, 306, 504, 1, 1),
(27, 100, 5, 2, 305, 503, 1, 1),
(28, 100, 5, 3, 304, 502, 1, 1),
(29, 100, 5, 4, 303, 501, 1, 1),
(30, 100, 5, 5, 302, 500, 1, 1),
(31, 100, 5, 6, 301, 500, 1, 1),
(32, 100, 6, 1, 301, 500, 1, 1),
(33, 100, 6, 2, 302, 500, 1, 1),
(34, 100, 6, 3, 303, 501, 1, 1),
(35, 100, 6, 4, 304, 502, 1, 1),
(36, 100, 6, 5, 305, 503, 1, 1),
(37, 100, 6, 6, 306, 504, 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `branch`
--
ALTER TABLE `branch`
  ADD PRIMARY KEY (`bcode`),
  ADD UNIQUE KEY `bname` (`bname`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`scode`),
  ADD UNIQUE KEY `sname` (`sname`),
  ADD KEY `branch_bcode_fk` (`bcode`);

--
-- Indexes for table `tchsub`
--
ALTER TABLE `tchsub`
  ADD PRIMARY KEY (`tid`,`scode`),
  ADD KEY `scode` (`scode`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`tid`),
  ADD UNIQUE KEY `tshort` (`tshort`);

--
-- Indexes for table `timetable`
--
ALTER TABLE `timetable`
  ADD PRIMARY KEY (`ttid`),
  ADD KEY `scode` (`scode`),
  ADD KEY `tid` (`tid`),
  ADD KEY `bcode` (`bcode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `teacher`
--
ALTER TABLE `teacher`
  MODIFY `tid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=508;
--
-- AUTO_INCREMENT for table `timetable`
--
ALTER TABLE `timetable`
  MODIFY `ttid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `subject`
--
ALTER TABLE `subject`
  ADD CONSTRAINT `branch_bcode_fk` FOREIGN KEY (`bcode`) REFERENCES `branch` (`bcode`);

--
-- Constraints for table `tchsub`
--
ALTER TABLE `tchsub`
  ADD CONSTRAINT `tchsub_ibfk_1` FOREIGN KEY (`tid`) REFERENCES `teacher` (`tid`),
  ADD CONSTRAINT `tchsub_ibfk_2` FOREIGN KEY (`scode`) REFERENCES `subject` (`scode`);

--
-- Constraints for table `timetable`
--
ALTER TABLE `timetable`
  ADD CONSTRAINT `timetable_ibfk_1` FOREIGN KEY (`scode`) REFERENCES `subject` (`scode`),
  ADD CONSTRAINT `timetable_ibfk_2` FOREIGN KEY (`tid`) REFERENCES `teacher` (`tid`),
  ADD CONSTRAINT `timetable_ibfk_3` FOREIGN KEY (`bcode`) REFERENCES `branch` (`bcode`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
