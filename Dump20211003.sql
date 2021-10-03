CREATE DATABASE  IF NOT EXISTS `urlshortener` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `urlshortener`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: urlshortener
-- ------------------------------------------------------
-- Server version	8.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `url`
--

DROP TABLE IF EXISTS `url`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `url` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LongUrl` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10018 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `url`
--

LOCK TABLES `url` WRITE;
/*!40000 ALTER TABLE `url` DISABLE KEYS */;
INSERT INTO `url` VALUES (10000,'google.com'),(10001,'google.com'),(10002,'https://github.com/'),(10003,'https://stackoverflow.com/questions/11324711/redirect-from-asp-net-web-api-post-action'),(10004,'https://social.msdn.microsoft.com/Forums/vstudio/tr-TR/8e4e6bff-8059-4e48-a714-7dda4777c996/systeminvalidoperationexception-no-connection-string-named-harmansistemientities-could-be-found?forum=csharptr'),(10005,'https://social.msdn.microsoft.com/Forums/vstudio/tr-TR/8e4e6bff-8059-4e48-a714-7dda4777c996/systeminvalidoperationexception-no-connection-string-named-harmansistemientities-could-be-found?forum=csharptr'),(10006,'https://www.w3schools.com/python/python_operators.asp'),(10007,'https://stackoverflow.com/questions/11324711/redirect-from-asp-net-web-api-post-action'),(10008,'https://www.w3schools.com/python/python_operators.asp'),(10009,'https://www.youtube.com/'),(10010,'https://docs.microsoft.com/en-us/xamarin/get-started/tutorials/entry/?tabs=vswin'),(10011,'https://relocateme.eu/'),(10012,'https://github.com/xamarin/docs-archive/tree/master/Recipes/xamarin-forms/Controls/display-pdf'),(10013,'google.com'),(10014,'https://github.com/xamarin/docs-archive/tree/master/Recipes/xamarin-forms/Controls/display-pdf'),(10015,'https://social.msdn.microsoft.com/Forums/vstudio/tr-TR/8e4e6bff-8059-4e48-a714-7dda4777c996/systeminvalidoperationexception-no-connection-string-named-harmansistemientities-could-be-found?forum=csharptr'),(10016,'https://www.google.com'),(10017,'https://docs.microsoft.com/tr-tr/xamarin/xamarin-forms/app-fundamentals/navigation/flyoutpage');
/*!40000 ALTER TABLE `url` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-03 16:10:33
