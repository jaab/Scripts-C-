-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 12-Set-2019 às 15:19
-- Versão do servidor: 10.1.38-MariaDB
-- versão do PHP: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `c_clinica`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `consultas`
--

CREATE TABLE `consultas` (
  `id_consulta` int(5) NOT NULL,
  `id_medico` int(3) DEFAULT NULL,
  `id_paciente` int(3) DEFAULT NULL,
  `id_esp` int(2) NOT NULL,
  `data_consulta` varchar(100) NOT NULL,
  `hora_consulta` varchar(100) NOT NULL,
  `estado` enum('S','N') NOT NULL,
  `internamento` enum('S','N','A') NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `consultas`
--

INSERT INTO `consultas` (`id_consulta`, `id_medico`, `id_paciente`, `id_esp`, `data_consulta`, `hora_consulta`, `estado`, `internamento`) VALUES
(42, 1, 2, 2, '7-30-2019', '20:00', 'S', 'N');

-- --------------------------------------------------------

--
-- Estrutura da tabela `especialidades`
--

CREATE TABLE `especialidades` (
  `id_esp` int(2) NOT NULL,
  `descricao` varchar(50) NOT NULL,
  `estado` enum('S','N') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `especialidades`
--

INSERT INTO `especialidades` (`id_esp`, `descricao`, `estado`) VALUES
(1, 'Oftalmologia', 'S'),
(2, 'Cardiologia', 'S'),
(4, 'Ortopedia', 'S'),
(5, 'Pediatria', 'S'),
(6, 'Clinica Geral', 'S');

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

CREATE TABLE `login` (
  `id` int(3) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `acesso` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `login`
--

INSERT INTO `login` (`id`, `username`, `password`, `acesso`) VALUES
(56, 'jaab', 'jaab', 1),
(86, 'manel', 'manel', 3),
(88, 'julio', 'julio', 0),
(94, 'antonia', 'Antonia', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `medicos`
--

CREATE TABLE `medicos` (
  `id_medico` int(3) NOT NULL,
  `nome_medico` varchar(50) NOT NULL,
  `morada` varchar(100) NOT NULL,
  `telefone` int(9) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `nif` varchar(10) NOT NULL,
  `data_nascimento` varchar(10) NOT NULL,
  `sexo` varchar(10) NOT NULL,
  `estado` enum('S','N') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `medicos`
--

INSERT INTO `medicos` (`id_medico`, `nome_medico`, `morada`, `telefone`, `foto`, `nif`, `data_nascimento`, `sexo`, `estado`) VALUES
(1, 'Manuel Albuquerque dos Santos', 'rua da mola, 3500-001 Viseu', 919786389, '07bae89cc784d33fb2c962d580bc46dc.jpg', '208967982', '22-07-1978', 'Masculino', 'S');

-- --------------------------------------------------------

--
-- Estrutura da tabela `med_esp`
--

CREATE TABLE `med_esp` (
  `id_medico` int(3) NOT NULL,
  `id_esp` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `med_esp`
--

INSERT INTO `med_esp` (`id_medico`, `id_esp`) VALUES
(1, 2),
(1, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacientes`
--

CREATE TABLE `pacientes` (
  `id_paciente` int(10) NOT NULL,
  `nome_paciente` varchar(50) NOT NULL,
  `morada` varchar(100) NOT NULL,
  `telefone` int(9) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `nif` varchar(10) NOT NULL,
  `data_nascimento` varchar(10) NOT NULL,
  `sexo` varchar(10) NOT NULL,
  `estado` enum('S','N') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `pacientes`
--

INSERT INTO `pacientes` (`id_paciente`, `nome_paciente`, `morada`, `telefone`, `foto`, `nif`, `data_nascimento`, `sexo`, `estado`) VALUES
(2, 'JÃºlio Moreno Caxias Monteiro', 'Santa comba DÃ£o', 939765432, '136c548535146d790151d23dbf711c6a.jpg', '234567865', '12-07-1982', 'Masculino', 'S'),
(3, 'Antonia maria carneiro lopes', 'viseu', 242423421, '1b0b11d680a8caeffae003ceadac17fd.jpg', '352626236', '20-06-1977', 'Feminino', 'S');

-- --------------------------------------------------------

--
-- Estrutura da tabela `prescricao`
--

CREATE TABLE `prescricao` (
  `id_prescricao` int(5) NOT NULL,
  `id_consulta` int(5) DEFAULT NULL,
  `prescricao` text NOT NULL,
  `observacoes` varchar(255) NOT NULL,
  `estado` enum('S','N') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `consultas`
--
ALTER TABLE `consultas`
  ADD PRIMARY KEY (`id_consulta`),
  ADD KEY `id_medico` (`id_medico`),
  ADD KEY `id_paciente` (`id_paciente`);

--
-- Indexes for table `especialidades`
--
ALTER TABLE `especialidades`
  ADD PRIMARY KEY (`id_esp`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medicos`
--
ALTER TABLE `medicos`
  ADD PRIMARY KEY (`id_medico`);

--
-- Indexes for table `med_esp`
--
ALTER TABLE `med_esp`
  ADD PRIMARY KEY (`id_medico`,`id_esp`),
  ADD KEY `id_esp` (`id_esp`);

--
-- Indexes for table `pacientes`
--
ALTER TABLE `pacientes`
  ADD PRIMARY KEY (`id_paciente`);

--
-- Indexes for table `prescricao`
--
ALTER TABLE `prescricao`
  ADD PRIMARY KEY (`id_prescricao`),
  ADD KEY `id_consulta` (`id_consulta`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `consultas`
--
ALTER TABLE `consultas`
  MODIFY `id_consulta` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `especialidades`
--
ALTER TABLE `especialidades`
  MODIFY `id_esp` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=95;

--
-- AUTO_INCREMENT for table `medicos`
--
ALTER TABLE `medicos`
  MODIFY `id_medico` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `pacientes`
--
ALTER TABLE `pacientes`
  MODIFY `id_paciente` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `prescricao`
--
ALTER TABLE `prescricao`
  MODIFY `id_prescricao` int(5) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `consultas`
--
ALTER TABLE `consultas`
  ADD CONSTRAINT `consultas_ibfk_1` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`id_medico`),
  ADD CONSTRAINT `consultas_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `pacientes` (`id_paciente`);

--
-- Limitadores para a tabela `med_esp`
--
ALTER TABLE `med_esp`
  ADD CONSTRAINT `med_esp_ibfk_1` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`id_medico`),
  ADD CONSTRAINT `med_esp_ibfk_2` FOREIGN KEY (`id_esp`) REFERENCES `especialidades` (`id_esp`);

--
-- Limitadores para a tabela `prescricao`
--
ALTER TABLE `prescricao`
  ADD CONSTRAINT `prescricao_ibfk_1` FOREIGN KEY (`id_consulta`) REFERENCES `consultas` (`id_consulta`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
