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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table undertale.player: ~4 rows (approximately)
INSERT INTO `player` (`id`, `nickname`) VALUES
	(1, 'Larcane'),
	(2, 'Larcane'),
	(3, 'Larcane'),
	(4, 'LARCANE');

-- Dumping structure for table undertale.scenario
CREATE TABLE IF NOT EXISTS `scenario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `imagePlace` varchar(255) DEFAULT NULL,
  `chapName` varchar(255) DEFAULT NULL,
  `choice1Name` varchar(255) DEFAULT NULL,
  `choice2Name` varchar(255) DEFAULT NULL,
  `choice3Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table undertale.scenario: ~10 rows (approximately)
INSERT INTO `scenario` (`id`, `imagePlace`, `chapName`, `choice1Name`, `choice2Name`, `choice3Name`) VALUES
	(1, '-', 'EnterName', 'Entrer dans le donjon', 'Sortir', '-'),
	(2, '-', 'TalkToGoat', 'Suivre la chèvre', 'Continuer seul', NULL),
	(3, '-', 'ContinueAlone', NULL, NULL, NULL),
	(4, '-', 'FrontOfHouse', 'Aller devant la porte', NULL, NULL),
	(5, '-', 'FrontOfDoor', 'Entrer dans la maison', NULL, NULL),
	(6, '-', 'CandyHouse', 'Continuer d\'explorer', 'Fuir', NULL),
	(7, '-', 'CandyKitchen', 'Aller au salon', 'Aller à la salle de bain', NULL),
	(8, '-', 'CandyLivingRoom', NULL, NULL, NULL),
	(9, '-', 'CandyBathroom', 'Aller dans la bibliotèque', 'Prendre un bain', NULL),
	(10, '-', 'CandyLibrary', NULL, NULL, NULL);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
