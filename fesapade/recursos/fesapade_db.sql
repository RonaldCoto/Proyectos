-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-04-2021 a las 23:10:05
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `fesapade_db`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignaciones_cursos`
--

CREATE TABLE `asignaciones_cursos` (
  `id_asignacion_curso` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `asignaciones_cursos`
--

INSERT INTO `asignaciones_cursos` (`id_asignacion_curso`, `id_curso`, `id_empleado`) VALUES
(12, 1, 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias_empleados`
--

CREATE TABLE `categorias_empleados` (
  `id_cate_empleado` int(11) NOT NULL,
  `cargo` varchar(20) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `categorias_empleados`
--

INSERT INTO `categorias_empleados` (`id_cate_empleado`, `cargo`) VALUES
(1, 'ADMINISTRADOR'),
(2, 'INSTRUCTOR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos`
--

CREATE TABLE `cursos` (
  `id_curso` int(11) NOT NULL,
  `nombre` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `descripcion` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `portada` varchar(250) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `estado` varchar(15) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `cursos`
--

INSERT INTO `cursos` (`id_curso`, `nombre`, `descripcion`, `portada`, `estado`) VALUES
(1, 'curso1', 'curso de prueba', NULL, 'INICIADO'),
(13, 'curso 2', 'de prueba', NULL, 'INICIADO'),
(24, 'curso 3', 'prueba de almacen de imagenes', '1619730450123624432_3436219896463843_8828050963999108943_o.jpg', 'FINALIZADO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `id_empleado` int(11) NOT NULL,
  `nombre` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `apellido` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `direccion` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `email` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `password` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `id_cate_empleado` int(11) NOT NULL,
  `estado` varchar(10) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `direccion`, `email`, `password`, `id_cate_empleado`, `estado`) VALUES
(1, 'adonis', 'arevalo', 'soyapango, San Salvador', 'adonisarevalo503@gmail.com', '9ed660a53803d004219f723faa508a7f127a75d2', 1, 'ALTA'),
(6, 'instructor', 'instructor', 'ilopango', 'instructor@fesapade.com', 'f4d2eda974f10ce216198ff16d75d7e4aa2e81fc', 2, 'ALTA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evaluaciones`
--

CREATE TABLE `evaluaciones` (
  `id_evaluacion` int(11) NOT NULL,
  `nombre` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `descripcion` varchar(450) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `porcentaje` double NOT NULL,
  `id_curso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `federados`
--

CREATE TABLE `federados` (
  `id_federado` int(11) NOT NULL,
  `nombre` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `apellido` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `direccion` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `email` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `password` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `estado` varchar(10) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `federados`
--

INSERT INTO `federados` (`id_federado`, `nombre`, `apellido`, `direccion`, `email`, `password`, `estado`) VALUES
(1, 'federado', 'de prueba', 'ilopango, san salvador', 'federado1@hotmail.com', '14068d25a61a2b0755296b0b55b4b7bcddd72473', 'ALTA'),
(2, 'jose', 'perez', 'san salvador', 'joseperez@hotmail.com', '6920cf7d7be6238440a76c44a47969a03fcde487', 'BAJA'),
(6, 'jose', 'martinez', 'asdf', 'as@as.com', '7c222fb2927d828af22f592134e8932480637c0d', 'ALTA'),
(8, 'nuefed', 'nuefed', 'cabañas', 'nuefed@nuefed.com', '7c222fb2927d828af22f592134e8932480637c0d', 'ALTA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matriculas`
--

CREATE TABLE `matriculas` (
  `id_matricula` int(11) NOT NULL,
  `id_federado` int(11) NOT NULL,
  `id_asignacion_curso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `matriculas`
--

INSERT INTO `matriculas` (`id_matricula`, `id_federado`, `id_asignacion_curso`) VALUES
(25, 1, 12),
(33, 8, 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `notas`
--

CREATE TABLE `notas` (
  `id_nota` int(11) NOT NULL,
  `id_evaluacion` int(11) NOT NULL,
  `nota` double NOT NULL,
  `id_matricula` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `publicaciones`
--

CREATE TABLE `publicaciones` (
  `id_publicacion` int(11) NOT NULL,
  `titulo` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `descripcion` varchar(250) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `archivo` varchar(250) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `id_asignacion_curso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asignaciones_cursos`
--
ALTER TABLE `asignaciones_cursos`
  ADD PRIMARY KEY (`id_asignacion_curso`),
  ADD KEY `id_curso` (`id_curso`,`id_empleado`),
  ADD KEY `asignaciones_cursos_ibfk_2` (`id_empleado`);

--
-- Indices de la tabla `categorias_empleados`
--
ALTER TABLE `categorias_empleados`
  ADD PRIMARY KEY (`id_cate_empleado`);

--
-- Indices de la tabla `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`id_curso`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `id_cate_empleado` (`id_cate_empleado`);

--
-- Indices de la tabla `evaluaciones`
--
ALTER TABLE `evaluaciones`
  ADD PRIMARY KEY (`id_evaluacion`),
  ADD KEY `id_curso` (`id_curso`);

--
-- Indices de la tabla `federados`
--
ALTER TABLE `federados`
  ADD PRIMARY KEY (`id_federado`);

--
-- Indices de la tabla `matriculas`
--
ALTER TABLE `matriculas`
  ADD PRIMARY KEY (`id_matricula`),
  ADD KEY `id_federado` (`id_federado`,`id_asignacion_curso`),
  ADD KEY `matriculas_ibfk_1` (`id_asignacion_curso`);

--
-- Indices de la tabla `notas`
--
ALTER TABLE `notas`
  ADD PRIMARY KEY (`id_nota`),
  ADD KEY `id_matricula` (`id_matricula`),
  ADD KEY `id_evaluacion` (`id_evaluacion`);

--
-- Indices de la tabla `publicaciones`
--
ALTER TABLE `publicaciones`
  ADD PRIMARY KEY (`id_publicacion`),
  ADD KEY `id_asignacion_curso` (`id_asignacion_curso`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `asignaciones_cursos`
--
ALTER TABLE `asignaciones_cursos`
  MODIFY `id_asignacion_curso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT de la tabla `categorias_empleados`
--
ALTER TABLE `categorias_empleados`
  MODIFY `id_cate_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `cursos`
--
ALTER TABLE `cursos`
  MODIFY `id_curso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `evaluaciones`
--
ALTER TABLE `evaluaciones`
  MODIFY `id_evaluacion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `federados`
--
ALTER TABLE `federados`
  MODIFY `id_federado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `matriculas`
--
ALTER TABLE `matriculas`
  MODIFY `id_matricula` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de la tabla `notas`
--
ALTER TABLE `notas`
  MODIFY `id_nota` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `publicaciones`
--
ALTER TABLE `publicaciones`
  MODIFY `id_publicacion` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asignaciones_cursos`
--
ALTER TABLE `asignaciones_cursos`
  ADD CONSTRAINT `asignaciones_cursos_ibfk_1` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `asignaciones_cursos_ibfk_2` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `empleados_ibfk_1` FOREIGN KEY (`id_cate_empleado`) REFERENCES `categorias_empleados` (`id_cate_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `matriculas`
--
ALTER TABLE `matriculas`
  ADD CONSTRAINT `matriculas_ibfk_1` FOREIGN KEY (`id_asignacion_curso`) REFERENCES `asignaciones_cursos` (`id_asignacion_curso`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `matriculas_ibfk_2` FOREIGN KEY (`id_federado`) REFERENCES `federados` (`id_federado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `notas`
--
ALTER TABLE `notas`
  ADD CONSTRAINT `notas_ibfk_1` FOREIGN KEY (`id_evaluacion`) REFERENCES `evaluaciones` (`id_evaluacion`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `notas_ibfk_2` FOREIGN KEY (`id_matricula`) REFERENCES `matriculas` (`id_matricula`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `publicaciones`
--
ALTER TABLE `publicaciones`
  ADD CONSTRAINT `publicaciones_ibfk_1` FOREIGN KEY (`id_asignacion_curso`) REFERENCES `asignaciones_cursos` (`id_asignacion_curso`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
