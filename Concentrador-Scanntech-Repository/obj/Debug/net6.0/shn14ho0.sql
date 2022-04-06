CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `BeneficioScanntech` (
    `BeneficioId` bigint NOT NULL AUTO_INCREMENT,
    CONSTRAINT `PK_BeneficioScanntech` PRIMARY KEY (`BeneficioId`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `CondicaoScanntech` (
    `CondicaoId` bigint NOT NULL AUTO_INCREMENT,
    CONSTRAINT `PK_CondicaoScanntech` PRIMARY KEY (`CondicaoId`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `DefinicoesScanntech` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `DataDeIntegração` datetime(6) NOT NULL,
    `HorarioDeEnvioFechamento` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Usuario` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Senha` longtext CHARACTER SET utf8mb4 NOT NULL,
    `SincronizacaoPromocoes` int NOT NULL,
    `SincronizacaoVendas` int NOT NULL,
    `SincronizacaoManual` int NOT NULL,
    `IdCompanhia` int NOT NULL,
    `IdLocal` int NOT NULL,
    `QuantidadeDeEnviosParaScanntech` int NOT NULL,
    `EstadoDaPromocao` int NOT NULL,
    CONSTRAINT `PK_DefinicoesScanntech` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `BeneficioItemScanntech` (
    `BeneficioItemId` bigint NOT NULL AUTO_INCREMENT,
    `Quantidade` int NOT NULL,
    `BeneficioScanntechBeneficioId` bigint NULL,
    CONSTRAINT `PK_BeneficioItemScanntech` PRIMARY KEY (`BeneficioItemId`),
    CONSTRAINT `FK_BeneficioItemScanntech_BeneficioScanntech_BeneficioScanntech~` FOREIGN KEY (`BeneficioScanntechBeneficioId`) REFERENCES `BeneficioScanntech` (`BeneficioId`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `CondicaoItemScanntech` (
    `CondicaoItemId` bigint NOT NULL AUTO_INCREMENT,
    `Quantidade` int NOT NULL,
    `CondicaoScanntechCondicaoId` bigint NULL,
    CONSTRAINT `PK_CondicaoItemScanntech` PRIMARY KEY (`CondicaoItemId`),
    CONSTRAINT `FK_CondicaoItemScanntech_CondicaoScanntech_CondicaoScanntechCon~` FOREIGN KEY (`CondicaoScanntechCondicaoId`) REFERENCES `CondicaoScanntech` (`CondicaoId`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `DetalhesPromocaoScanntech` (
    `DetalhePromocaoScanntechId` bigint NOT NULL AUTO_INCREMENT,
    `BeneficioScanntechId` bigint NULL,
    `CondicaoScanntechId` bigint NULL,
    `PrecoValorFixo` decimal(65,30) NULL,
    `Desconto` decimal(65,30) NULL,
    `QuantidadeItensLevaEPaga` int NULL,
    CONSTRAINT `PK_DetalhesPromocaoScanntech` PRIMARY KEY (`DetalhePromocaoScanntechId`),
    CONSTRAINT `FK_DetalhesPromocaoScanntech_BeneficioScanntech_BeneficioScannt~` FOREIGN KEY (`BeneficioScanntechId`) REFERENCES `BeneficioScanntech` (`BeneficioId`),
    CONSTRAINT `FK_DetalhesPromocaoScanntech_CondicaoScanntech_CondicaoScanntec~` FOREIGN KEY (`CondicaoScanntechId`) REFERENCES `CondicaoScanntech` (`CondicaoId`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `URLs` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `UrlConnection` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DefinicoesScanntechId` bigint NULL,
    CONSTRAINT `PK_URLs` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_URLs_DefinicoesScanntech_DefinicoesScanntechId` FOREIGN KEY (`DefinicoesScanntechId`) REFERENCES `DefinicoesScanntech` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `BeneficioArtigoScanntech` (
    `ArtigoId` bigint NOT NULL AUTO_INCREMENT,
    `ApiId` bigint NOT NULL,
    `QuantidadeParaAtivarPromocao` int NOT NULL,
    `Nome` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CodigoDeBarras` longtext CHARACTER SET utf8mb4 NOT NULL,
    `BeneficioItemScanntechBeneficioItemId` bigint NULL,
    CONSTRAINT `PK_BeneficioArtigoScanntech` PRIMARY KEY (`ArtigoId`),
    CONSTRAINT `FK_BeneficioArtigoScanntech_BeneficioItemScanntech_BeneficioIte~` FOREIGN KEY (`BeneficioItemScanntechBeneficioItemId`) REFERENCES `BeneficioItemScanntech` (`BeneficioItemId`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `CondicaoArtigoScanntech` (
    `ArtigoId` bigint NOT NULL AUTO_INCREMENT,
    `ApiId` bigint NOT NULL,
    `QuantidadeParaAtivarPromocao` int NOT NULL,
    `Nome` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CodigoDeBarras` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CondicaoItemScanntechCondicaoItemId` bigint NULL,
    CONSTRAINT `PK_CondicaoArtigoScanntech` PRIMARY KEY (`ArtigoId`),
    CONSTRAINT `FK_CondicaoArtigoScanntech_CondicaoItemScanntech_CondicaoItemSc~` FOREIGN KEY (`CondicaoItemScanntechCondicaoItemId`) REFERENCES `CondicaoItemScanntech` (`CondicaoItemId`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `PromocoesScanntech` (
    `PromocaoId` bigint NOT NULL AUTO_INCREMENT,
    `ApiId` bigint NOT NULL,
    `LimiteDePromocoesPorTicket` int NULL,
    `CargaPdv` tinyint(1) NOT NULL,
    `Titulo` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Descricao` longtext CHARACTER SET utf8mb4 NOT NULL,
    `TipoPromocao` longtext CHARACTER SET utf8mb4 NOT NULL,
    `VigenciaDe` datetime(6) NOT NULL,
    `VigenciaAte` datetime(6) NOT NULL,
    `DataEnvioPdv` datetime(6) NOT NULL,
    `DetalhePromocaoScanntechId` bigint NOT NULL,
    CONSTRAINT `PK_PromocoesScanntech` PRIMARY KEY (`PromocaoId`),
    CONSTRAINT `FK_PromocoesScanntech_DetalhesPromocaoScanntech_DetalhePromocao~` FOREIGN KEY (`DetalhePromocaoScanntechId`) REFERENCES `DetalhesPromocaoScanntech` (`DetalhePromocaoScanntechId`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_BeneficioArtigoScanntech_BeneficioItemScanntechBeneficioItem~` ON `BeneficioArtigoScanntech` (`BeneficioItemScanntechBeneficioItemId`);

CREATE INDEX `IX_BeneficioItemScanntech_BeneficioScanntechBeneficioId` ON `BeneficioItemScanntech` (`BeneficioScanntechBeneficioId`);

CREATE INDEX `IX_CondicaoArtigoScanntech_CondicaoItemScanntechCondicaoItemId` ON `CondicaoArtigoScanntech` (`CondicaoItemScanntechCondicaoItemId`);

CREATE INDEX `IX_CondicaoItemScanntech_CondicaoScanntechCondicaoId` ON `CondicaoItemScanntech` (`CondicaoScanntechCondicaoId`);

CREATE INDEX `IX_DetalhesPromocaoScanntech_BeneficioScanntechId` ON `DetalhesPromocaoScanntech` (`BeneficioScanntechId`);

CREATE INDEX `IX_DetalhesPromocaoScanntech_CondicaoScanntechId` ON `DetalhesPromocaoScanntech` (`CondicaoScanntechId`);

CREATE INDEX `IX_PromocoesScanntech_DetalhePromocaoScanntechId` ON `PromocoesScanntech` (`DetalhePromocaoScanntechId`);

CREATE INDEX `IX_URLs_DefinicoesScanntechId` ON `URLs` (`DefinicoesScanntechId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20220405142505_mysql', '6.0.1');

COMMIT;

