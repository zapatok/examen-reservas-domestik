-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-05-2026 a las 01:34:06
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdreservas`
--
CREATE DATABASE IF NOT EXISTS bdreservas;
USE bdreservas;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pasajero`
--

CREATE TABLE `pasajero` (
  `rut` varchar(10) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `tipo` varchar(10) DEFAULT NULL,
  `puntaje` int(11) DEFAULT NULL,
  PRIMARY KEY (`rut`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vuelo`
--

CREATE TABLE `vuelo` (
  `nrovuelo` varchar(10) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` varchar(5) DEFAULT NULL,
  `destino` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`nrovuelo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reserva`
--

CREATE TABLE `reserva` (
  `codigo` varchar(10) NOT NULL,
  `tipo` varchar(10) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `rut` varchar(10) DEFAULT NULL,
  `nrovuelo` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `fkrut` (`rut`),
  KEY `fknro` (`nrovuelo`),
  CONSTRAINT `fkrut` FOREIGN KEY (`rut`) REFERENCES `pasajero` (`rut`),
  CONSTRAINT `fknro` FOREIGN KEY (`nrovuelo`) REFERENCES `vuelo` (`nrovuelo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control` (Login)
--

CREATE TABLE `control` (
  `usuario` varchar(15) NOT NULL,
  `clave` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Datos de prueba
--

INSERT INTO `control` (`usuario`, `clave`) VALUES ('admin', '1234');

INSERT INTO `pasajero` (`rut`, `nombre`, `apellido`, `tipo`, `puntaje`) VALUES
('12345678-9', 'Juan', 'Pérez', 'Frecuente', 500),
('98765432-1', 'María', 'González', 'Normal', 0),
('11222333-4', 'Pedro', 'López', 'Frecuente', 1200);

INSERT INTO `vuelo` (`nrovuelo`, `fecha`, `hora`, `destino`) VALUES
('VL001', '2026-06-15', '08:30', 'Santiago - Concepción'),
('VL002', '2026-06-16', '14:00', 'Santiago - Antofagasta'),
('VL003', '2026-06-17', '10:15', 'Santiago - Puerto Montt');

INSERT INTO `reserva` (`codigo`, `tipo`, `valor`, `rut`, `nrovuelo`) VALUES
('R001', 'Economica', 35500, '12345678-9', 'VL001'),
('R002', 'Ejecutivo', 70000, '98765432-1', 'VL002'),
('R003', 'Turista', 46000, '11222333-4', 'VL003');

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
