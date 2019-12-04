-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: dbprojetopetshopfix
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
-- Table structure for table `agendamento`
--

DROP TABLE IF EXISTS `agendamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agendamento` (
  `codAgendamento` int(11) NOT NULL AUTO_INCREMENT,
  `animal_codAnimal` int(11) DEFAULT NULL,
  `servico_codServico` int(11) DEFAULT NULL,
  `codVeterinario` int(11) DEFAULT NULL,
  `dataPrevista` date DEFAULT NULL,
  `horaPrevista` time DEFAULT NULL,
  `observacoes` text,
  PRIMARY KEY (`codAgendamento`),
  KEY `funcionario_codFuncionarioAg_idx` (`codVeterinario`),
  KEY `animal_codAnimal_idx` (`animal_codAnimal`),
  KEY `servico_codServico_idx` (`servico_codServico`),
  CONSTRAINT `animal_codAnimal` FOREIGN KEY (`animal_codAnimal`) REFERENCES `animal` (`codAnimal`),
  CONSTRAINT `funcionario_codFuncionarioAg` FOREIGN KEY (`codVeterinario`) REFERENCES `funcionario` (`codFuncionario`),
  CONSTRAINT `servico_codServico` FOREIGN KEY (`servico_codServico`) REFERENCES `servico` (`codServico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `animal`
--

DROP TABLE IF EXISTS `animal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `animal` (
  `codAnimal` int(11) NOT NULL AUTO_INCREMENT,
  `nomeAnimal` varchar(80) DEFAULT NULL,
  `anoNascimento` int(11) DEFAULT NULL,
  `peso` float DEFAULT NULL,
  `grupo` varchar(45) DEFAULT NULL,
  `raca` varchar(45) DEFAULT NULL,
  `genero` varchar(45) DEFAULT NULL,
  `vacinacao` tinyint(4) DEFAULT NULL,
  `comportamento` text,
  `cliente_codCliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`codAnimal`),
  KEY `cliente_codCliente_idx` (`cliente_codCliente`),
  CONSTRAINT `cliente_codCliente` FOREIGN KEY (`cliente_codCliente`) REFERENCES `cliente` (`codCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `dataCadastroCliente` date DEFAULT NULL,
  `dataNascimentoCliente` date DEFAULT NULL,
  `nomeCliente` varchar(100) DEFAULT NULL,
  `rgCliente` varchar(10) DEFAULT NULL,
  `telefoneCliente` varchar(16) DEFAULT NULL,
  `emailCliente` varchar(80) DEFAULT NULL,
  `enderecoCliente` varchar(50) DEFAULT NULL,
  `cidadeCliente` varchar(45) DEFAULT NULL,
  `estadoCliente` varchar(45) DEFAULT NULL,
  `paisCliente` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `execucao`
--

DROP TABLE IF EXISTS `execucao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `execucao` (
  `codExecucao` int(11) NOT NULL AUTO_INCREMENT,
  `animal_codAnimalExec` int(11) DEFAULT NULL,
  `servico_codServicoExec` int(11) DEFAULT NULL,
  `codVeterinarioResp` int(11) DEFAULT NULL,
  `dataExecucao` date DEFAULT NULL,
  `horaExecucao` time DEFAULT NULL,
  `observacoes` text,
  PRIMARY KEY (`codExecucao`),
  KEY `animal_codAnimalExec_idx` (`animal_codAnimalExec`),
  KEY `servico_codServico_idx` (`servico_codServicoExec`),
  KEY `cod_FuncionarioExec_idx` (`codVeterinarioResp`),
  CONSTRAINT `animal_codAnimalExec` FOREIGN KEY (`animal_codAnimalExec`) REFERENCES `animal` (`codAnimal`),
  CONSTRAINT `cod_FuncionarioExec` FOREIGN KEY (`codVeterinarioResp`) REFERENCES `funcionario` (`codFuncionario`),
  CONSTRAINT `servico_codServicoExec` FOREIGN KEY (`servico_codServicoExec`) REFERENCES `servico` (`codServico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcionario` (
  `codFuncionario` int(11) NOT NULL AUTO_INCREMENT,
  `dataCadastro` date DEFAULT NULL,
  `dataNascimento` date DEFAULT NULL,
  `nomeFuncionario` varchar(100) DEFAULT NULL,
  `rgFuncionario` varchar(10) DEFAULT NULL,
  `telefoneFuncionario` varchar(16) DEFAULT NULL,
  `emailFuncionario` varchar(80) DEFAULT NULL,
  `senhaFuncionario` varchar(50) DEFAULT NULL,
  `enderecoFuncionario` varchar(50) DEFAULT NULL,
  `cidadeFuncionario` varchar(45) DEFAULT NULL,
  `estadoFuncionario` varchar(45) DEFAULT NULL,
  `paisFuncionario` varchar(45) DEFAULT NULL,
  `tipoFuncionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`codFuncionario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `servico`
--

DROP TABLE IF EXISTS `servico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servico` (
  `codServico` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) DEFAULT NULL,
  `descricao` text,
  `valor` double DEFAULT NULL,
  PRIMARY KEY (`codServico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-04 16:23:57
