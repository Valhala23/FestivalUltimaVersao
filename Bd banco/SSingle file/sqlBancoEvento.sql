-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: evento
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `apresentacao`
--

DROP TABLE IF EXISTS `apresentacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apresentacao` (
  `id_apresentacao` int(11) NOT NULL AUTO_INCREMENT,
  `musica` varchar(250) DEFAULT NULL,
  `artista` varchar(250) DEFAULT NULL,
  `cantor` int(11) NOT NULL,
  `categoria` int(11) NOT NULL,
  PRIMARY KEY (`id_apresentacao`),
  KEY `cantor` (`cantor`),
  KEY `categoria` (`categoria`),
  CONSTRAINT `apresentacao_ibfk_1` FOREIGN KEY (`cantor`) REFERENCES `cantor` (`id_cantor`),
  CONSTRAINT `apresentacao_ibfk_2` FOREIGN KEY (`categoria`) REFERENCES `categoria` (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apresentacao`
--

LOCK TABLES `apresentacao` WRITE;
/*!40000 ALTER TABLE `apresentacao` DISABLE KEYS */;
INSERT INTO `apresentacao` VALUES (1,'Bijuteria','Bruno e marrone',1,3),(2,'Musica 7','Cabo daciolo',1,4),(3,'simfonia da noite','cleiton rasta',1,3),(4,'Music 8','musico',1,3),(5,'Music 8','musico',1,3),(7,'vida vazia','brno e marrone',1,4),(8,'to estou ','pink froid',8,4),(9,'would','alicio chais',11,4),(10,'wqeqwewe','teste',12,4),(11,'comobmocmombo','comovmom',13,3),(12,'comobmocmombo','comovmom',14,3),(13,'teste','quarta',26,4);
/*!40000 ALTER TABLE `apresentacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cantor`
--

DROP TABLE IF EXISTS `cantor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cantor` (
  `id_cantor` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) DEFAULT NULL,
  `email` varchar(250) DEFAULT NULL,
  `contato` varchar(50) DEFAULT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `rg` varchar(11) DEFAULT NULL,
  `observacao` text,
  PRIMARY KEY (`id_cantor`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cantor`
--

LOCK TABLES `cantor` WRITE;
/*!40000 ALTER TABLE `cantor` DISABLE KEYS */;
INSERT INTO `cantor` VALUES (1,'Ricardo','ricardo@email.com','499915445','07995487','569954','1'),(2,'qwewqeqwe','wqewqeq','sadsadasdasdasd','12312','21321','sadas'),(3,'Dibraldo','qweqweqw','sadsadasdasdasd','12312','21321','sadas'),(4,'Matias',NULL,'sadsadasdasdasd','12312','21321','sadas'),(5,'Cara que canta','cantqweasd@email.com',NULL,'123121','1234',NULL),(6,'Ricardo Bscr','ricardohbçaljhslkdhj@gmail.com',NULL,'589865','00789',NULL),(7,'Altair Credi','altair@yahoo.com',NULL,'16024','78421',NULL),(8,'Carinha','caringaguy@gmaeio.com',NULL,'3123123','321123123','gosta de forro'),(9,'Corona cantor','coronacnt@email.com',NULL,'0785462','123455','viralizador pandemico'),(10,'corona','cornaviru@email.com',NULL,'21124','5441','virus'),(11,'corona','coronavi@email.com',NULL,'342343242','1231221','virus'),(12,'teste ultimo','combotetse@email.com',NULL,'432342','35352','teste apresn catego combo'),(13,'sdassdcomvo','comomvomo',NULL,'123123','3123','cocmomodmasodma'),(14,'dsadasdasda','comomvomo',NULL,'123123','3123','cocmomodmasodma'),(15,'Lilith','lli.com',NULL,'2124142','123124124','cantora do cramunhao'),(16,'','lli.com',NULL,'2124142','123124124','cantora do cramunhao'),(17,'liliti','lilithemail.com',NULL,'41421','12412421','capiro cantora'),(18,'','lilithemail.com',NULL,'41421','12412421','capiro cantora'),(19,'qwewqe','qe',NULL,'3121321','12312','we'),(20,'teste terça','asdasdada',NULL,'654','456','terça'),(21,'terca teste','wtewqtqqdq',NULL,'2132312','231','terca'),(22,'','wtewqtqqdq',NULL,'2132312','231','terca'),(23,'qweqwe','qwewqe',NULL,'3123','13231','wqeqwe'),(24,'sasda','sdas',NULL,'das','da','ad'),(25,'qwew','eqw',NULL,'weqw','qwewq','eqw'),(26,'Teste quarta','testecantoq@uarta.com',NULL,'88888888','77777','cansando quarta');
/*!40000 ALTER TABLE `cantor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(250) NOT NULL,
  `dia` datetime DEFAULT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (3,'Grande churras','0001-01-01 00:00:00'),(4,'Seranejo','2020-02-28 00:00:00'),(5,'Musica de crente','2020-07-10 00:00:00'),(6,'roque','2020-07-10 00:00:00');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `festival`
--

DROP TABLE IF EXISTS `festival`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `festival` (
  `id_evento` int(11) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(250) NOT NULL,
  `descricao` varchar(250) DEFAULT NULL,
  `dataInicial` datetime DEFAULT NULL,
  `dataFinal` datetime NOT NULL,
  PRIMARY KEY (`id_evento`,`titulo`,`dataFinal`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `festival`
--

LOCK TABLES `festival` WRITE;
/*!40000 ALTER TABLE `festival` DISABLE KEYS */;
INSERT INTO `festival` VALUES (4,'Frostivos','Festival valve','2016-05-20 00:00:00','2016-05-20 00:00:00'),(5,'Churrasco de inauguração','Grande Churarsco','2020-01-18 00:00:00','0001-01-01 00:00:00'),(6,'Fimusi','Festival da Canção de Irani','2020-10-20 00:00:00','2020-10-24 00:00:00'),(7,'Baile de favela','bailao com tiro e gritaria / foguetorio','2020-01-03 00:00:00','2020-01-10 00:00:00');
/*!40000 ALTER TABLE `festival` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jurado`
--

DROP TABLE IF EXISTS `jurado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jurado` (
  `id_jurado` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) DEFAULT NULL,
  `contato` varchar(255) DEFAULT NULL,
  `documento` varchar(255) DEFAULT NULL,
  `observacao` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_jurado`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jurado`
--

LOCK TABLES `jurado` WRITE;
/*!40000 ALTER TABLE `jurado` DISABLE KEYS */;
INSERT INTO `jurado` VALUES (2,'Jubileu o Corvo','599884355','765473454','Jurado Oficial de eventos pipoca'),(3,'Jubileu Jurado','4998756444','0795884754','Jurado profissional gosta de pipoca doce'),(4,'Outro Carinha','carinhajurado@email.br','887798787','Carinha asdsadsasasdsaqweqw observaço');
/*!40000 ALTER TABLE `jurado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notas`
--

DROP TABLE IF EXISTS `notas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notas` (
  `id_nota` int(11) NOT NULL,
  `jurado` int(11) DEFAULT NULL,
  `apresentacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_nota`),
  KEY `jurado` (`jurado`),
  KEY `apresentacao` (`apresentacao`),
  CONSTRAINT `notas_ibfk_1` FOREIGN KEY (`jurado`) REFERENCES `jurado` (`id_jurado`),
  CONSTRAINT `notas_ibfk_2` FOREIGN KEY (`apresentacao`) REFERENCES `apresentacao` (`id_apresentacao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notas`
--

LOCK TABLES `notas` WRITE;
/*!40000 ALTER TABLE `notas` DISABLE KEYS */;
/*!40000 ALTER TABLE `notas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-25 14:16:12