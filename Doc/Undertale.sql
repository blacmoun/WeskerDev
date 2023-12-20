-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.34 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.6.0.6781
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for undertale
CREATE DATABASE IF NOT EXISTS `undertale` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `undertale`;

-- Dumping structure for table undertale.player
CREATE TABLE IF NOT EXISTS `player` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nickname` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table undertale.player: ~0 rows (approximately)

-- Dumping structure for table undertale.scenario
CREATE TABLE IF NOT EXISTS `scenario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `imagePlace` varchar(255) DEFAULT NULL,
  `chapName` varchar(255) DEFAULT NULL,
  `choice1Name` varchar(255) DEFAULT NULL,
  `choice2Name` varchar(255) DEFAULT NULL,
  `choice3Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table undertale.scenario: ~16 rows (approximately)
INSERT INTO `scenario` (`id`, `imagePlace`, `chapName`, `choice1Name`, `choice2Name`, `choice3Name`) VALUES
	(1, '-', 'EnterName', 'Entrer dans le donjon', 'Sortir', '-'),
	(2, '-', 'TalkToGoat', 'Suivre la chèvre', 'Continuer seul', NULL),
	(3, '-', 'Lost', 'Faire un feu et pleurer autour', 'Continuer jusqu\'au bout du chemin', NULL),
	(4, '-', 'CampFire', 'Retourner à l\'aventure', NULL, NULL),
	(5, '-', 'StrangeDoor', 'Enter', NULL, NULL),
	(6, '-', 'EnterMarkerPlace', 'Visiter le marché', NULL, NULL),
	(7, '-', 'VisitMarketPlace', NULL, NULL, NULL),
	(8, '-', NULL, NULL, NULL, NULL),
	(9, '-', NULL, NULL, NULL, NULL),
	(10, '-', NULL, NULL, NULL, NULL),
	(11, '-', 'FrontOfHouse', 'Suivant', NULL, NULL),
	(12, '-', 'FrontOfDoor', 'Entrer', NULL, NULL),
	(13, '-', 'CandyHouse', 'Aller dans la salle de bain', 'Aller au salon', NULL),
	(14, '-', 'Bathroom', 'Revenir au Hall', NULL, NULL),
	(15, '-', 'Livingroom', 'Revenir au Hall', 'Aller dans la cuisine', NULL),
	(16, '-', 'Kitchen', 'Revenir au salon', NULL, NULL);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
