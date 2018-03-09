-- MySQL dump 10.13  Distrib 5.7.20, for Win64 (x86_64)
--
-- Host: localhost    Database: attendance_system
-- ------------------------------------------------------
-- Server version	5.7.20-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departments` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `department_name` varchar(50) NOT NULL,
  `department_description` varchar(250) DEFAULT NULL,
  `start_mon` time DEFAULT NULL,
  `end_mon` time DEFAULT NULL,
  `start_tue` time DEFAULT NULL,
  `end_tue` time DEFAULT NULL,
  `start_wed` time DEFAULT NULL,
  `end_wed` time DEFAULT NULL,
  `start_thurs` time DEFAULT NULL,
  `end_thurs` time DEFAULT NULL,
  `start_fri` time DEFAULT NULL,
  `end_fri` time DEFAULT NULL,
  `start_sat` time DEFAULT NULL,
  `end_sat` time DEFAULT NULL,
  `start_sun` time DEFAULT NULL,
  `end_sun` time DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (7,'HR Department','','12:00:00','17:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employees` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `firstname` varchar(50) DEFAULT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) DEFAULT NULL,
  `deparment_id` int(10) unsigned DEFAULT NULL,
  `position` varchar(50) DEFAULT NULL,
  `address` varchar(250) DEFAULT NULL,
  `sex` varchar(6) DEFAULT NULL,
  `birthdate` date DEFAULT NULL,
  `date_employed` date DEFAULT NULL,
  `tin` varchar(12) DEFAULT NULL,
  `ssn` varchar(9) DEFAULT NULL,
  `philhealth` varchar(12) DEFAULT NULL,
  `pagibig` varchar(12) DEFAULT NULL,
  `contact` varchar(15) DEFAULT NULL,
  `rate` decimal(11,2) DEFAULT NULL,
  `fingerprint` text,
  `imglocation` text,
  PRIMARY KEY (`id`),
  KEY `deparment_id` (`deparment_id`),
  CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`deparment_id`) REFERENCES `departments` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (6,'Juan ','Dela Cruz','Masipag',7,'Admin','','Male','2018-03-10','2018-03-10','123456','123456','123456','123456','09123456789',1234.00,'mspY1neKnIdAggmLCj7BCIOLOAEEDQ9NQQqKl0vBCYidTkELh6MrgQzqpDFBFnCpIMEL2ytiggaTMiuCDd2yNIEeYTVSwQaYNyiCCFI4HAENyzhMAgmRuBCBBUy6P4ImdD4uAQpJvz3BJi1BN8ERPMMVwQjBwyLBBb/EFcEQS8YvAQ1MxyaBCcPINcEWSck7gRExzClBCsbPKEELzk9tQROdT2+BEyJPOcI7hdFkAQ2ZLjTvDraQUw0CDltdYWp1CBEWGRwdHx0BDlVVV1xmcwgTGRwgISIiAg1eYGNsdggPExcZGhsBDlFSVFhfbggVGyEjJCMkAg1hY2VtdwcNEhUYGBkBDkxOUVRZZQcXHyMlJSUkAw1kaXEBBgoQFRcYGQEOSUtMUFJYDBshJCYmJiUDDWlwdQIGChIXFxgYAQ9ISktMS0k1JSUmKCgnJiMEDXR3BAkMERQVFxcBD0pLSUpHQjcsKCgpKSgmJQQMcwMHDA8TFRYYAg9MTExIQDYtKiopKCYlJgUMCAsPEhQUFhgCD05QUUs/MywqKCcoKCgpBQsLDxIVFxcYAg9QU1VVRSwlJSUlJiUmKQYKDhMWGBcDDldZXgEYICMkIyYlKQgJFxsEDVxnAQoaHyMiJR8=','C:\\Users\\ianga\\Desktop\\pinang.png');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-10  5:11:32
