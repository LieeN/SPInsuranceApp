
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/08/2018 13:03:36
-- Generated from EDMX file: F:\Dokument\Visual Studio 2015\SU\SUHT18-7\SU-Projekt\DataLayer\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [suht1807];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FörsäkringPrivatansökan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FörsäkringSet] DROP CONSTRAINT [FK_FörsäkringPrivatansökan];
GO
IF OBJECT_ID(N'[dbo].[FK_FöretagsansökanFörsäkringstagareFöretag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FöretagsansökanSet] DROP CONSTRAINT [FK_FöretagsansökanFörsäkringstagareFöretag];
GO
IF OBJECT_ID(N'[dbo].[FK_PrivatansökanFörsäkringstagarePrivat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PrivatansökanSet] DROP CONSTRAINT [FK_PrivatansökanFörsäkringstagarePrivat];
GO
IF OBJECT_ID(N'[dbo].[FK_PrivatansökanPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PrivatansökanSet] DROP CONSTRAINT [FK_PrivatansökanPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_FöretagsansökanPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FöretagsansökanSet] DROP CONSTRAINT [FK_FöretagsansökanPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonalRoll]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalSet] DROP CONSTRAINT [FK_PersonalRoll];
GO
IF OBJECT_ID(N'[dbo].[FK_RollBehörighet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RollSet] DROP CONSTRAINT [FK_RollBehörighet];
GO
IF OBJECT_ID(N'[dbo].[FK_TillvalTillvalGrundbelopp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TillvalGrundbeloppSet] DROP CONSTRAINT [FK_TillvalTillvalGrundbelopp];
GO
IF OBJECT_ID(N'[dbo].[FK_GrundbeloppFörsäkringsTyp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GrundbeloppSet] DROP CONSTRAINT [FK_GrundbeloppFörsäkringsTyp];
GO
IF OBJECT_ID(N'[dbo].[FK_FörsäkringsTypPrivatansökan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PrivatansökanSet] DROP CONSTRAINT [FK_FörsäkringsTypPrivatansökan];
GO
IF OBJECT_ID(N'[dbo].[FK_FörsäkringsTypTillval]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FörsäkringsTypSet] DROP CONSTRAINT [FK_FörsäkringsTypTillval];
GO
IF OBJECT_ID(N'[dbo].[FK_FöretagsansökanFörsäkringFöretag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FörsäkringFöretagSet] DROP CONSTRAINT [FK_FöretagsansökanFörsäkringFöretag];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FörsäkringSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FörsäkringSet];
GO
IF OBJECT_ID(N'[dbo].[PersonalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonalSet];
GO
IF OBJECT_ID(N'[dbo].[FöretagsansökanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FöretagsansökanSet];
GO
IF OBJECT_ID(N'[dbo].[PrivatansökanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PrivatansökanSet];
GO
IF OBJECT_ID(N'[dbo].[FörsäkringstagarePrivatSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FörsäkringstagarePrivatSet];
GO
IF OBJECT_ID(N'[dbo].[FörsäkringstagareFöretagSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FörsäkringstagareFöretagSet];
GO
IF OBJECT_ID(N'[dbo].[RollSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RollSet];
GO
IF OBJECT_ID(N'[dbo].[BehörighetSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BehörighetSet];
GO
IF OBJECT_ID(N'[dbo].[TillvalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TillvalSet];
GO
IF OBJECT_ID(N'[dbo].[TillvalGrundbeloppSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TillvalGrundbeloppSet];
GO
IF OBJECT_ID(N'[dbo].[ProvisionstabellSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProvisionstabellSet];
GO
IF OBJECT_ID(N'[dbo].[SemesterersättningSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SemesterersättningSet];
GO
IF OBJECT_ID(N'[dbo].[GrundbeloppSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GrundbeloppSet];
GO
IF OBJECT_ID(N'[dbo].[FörsäkringsTypSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FörsäkringsTypSet];
GO
IF OBJECT_ID(N'[dbo].[FörsäkringFöretagSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FörsäkringFöretagSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FörsäkringSet'
CREATE TABLE [dbo].[FörsäkringSet] (
    [försäkringsId] int IDENTITY(1,1) NOT NULL,
    [försäkringsNr] nvarchar(max)  NOT NULL,
    [betald] datetime  NOT NULL,
    [provisionsbelopp] int  NULL,
    [Privatansökan_privatAnsökningsId] int  NOT NULL
);
GO

-- Creating table 'PersonalSet'
CREATE TABLE [dbo].[PersonalSet] (
    [anställningsId] int IDENTITY(1,1) NOT NULL,
    [persNr] bigint  NOT NULL,
    [agenturNr] int  NOT NULL,
    [skattesats] float  NOT NULL,
    [fNamn] nvarchar(max)  NOT NULL,
    [eNamn] nvarchar(max)  NOT NULL,
    [gatuAdress] nvarchar(max)  NOT NULL,
    [ort] nvarchar(max)  NOT NULL,
    [postNr] int  NOT NULL,
    [tel1] int  NOT NULL,
    [tel2] int  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [lösenord] nvarchar(max)  NOT NULL,
    [Roll_rollId] int  NOT NULL
);
GO

-- Creating table 'FöretagsansökanSet'
CREATE TABLE [dbo].[FöretagsansökanSet] (
    [företagsAnsökningsId] int IDENTITY(1,1) NOT NULL,
    [försäkringsbolag] nvarchar(max)  NOT NULL,
    [begynnelsedatum] datetime  NOT NULL,
    [förfallodag] datetime  NOT NULL,
    [betalningsform] nvarchar(max)  NOT NULL,
    [premie] int  NOT NULL,
    [Anteckning] nvarchar(max)  NOT NULL,
    [försäkringsTyp] nvarchar(max)  NOT NULL,
    [FörsäkringstagareFöretag_försäkringstagareFöretagId] bigint  NOT NULL,
    [Personal_anställningsId] int  NOT NULL
);
GO

-- Creating table 'PrivatansökanSet'
CREATE TABLE [dbo].[PrivatansökanSet] (
    [privatAnsökningsId] int IDENTITY(1,1) NOT NULL,
    [privatFörsäkradPersNr] bigint  NOT NULL,
    [privatFörsäkradENamn] nvarchar(max)  NOT NULL,
    [privatFörsäkradFNamn] nvarchar(max)  NOT NULL,
    [ankomstdatum] datetime  NOT NULL,
    [betalningsform] nvarchar(max)  NOT NULL,
    [vuxen] nvarchar(max)  NOT NULL,
    [premie] int  NOT NULL,
    [paGatuadress] nvarchar(max)  NOT NULL,
    [paOrt] nvarchar(max)  NOT NULL,
    [paPostnr] int  NOT NULL,
    [tillvalsNamn] nvarchar(max)  NULL,
    [grundBelopp] int  NOT NULL,
    [tvGrundbelopp] int  NULL,
    [försäkringsbolag] nvarchar(max)  NOT NULL,
    [FörsäkringstagarePrivat_försäkringstagarePrivatId] bigint  NOT NULL,
    [Personal_anställningsId] int  NOT NULL,
    [FörsäkringsTyp_försäkringsTypId] int  NOT NULL
);
GO

-- Creating table 'FörsäkringstagarePrivatSet'
CREATE TABLE [dbo].[FörsäkringstagarePrivatSet] (
    [försäkringstagarePrivatId] bigint IDENTITY(1,1) NOT NULL,
    [fNamn] nvarchar(max)  NOT NULL,
    [eNamn] nvarchar(max)  NOT NULL,
    [gatuAdress] nvarchar(max)  NOT NULL,
    [ort] nvarchar(max)  NOT NULL,
    [postNr] int  NOT NULL,
    [tel1] int  NOT NULL,
    [tel2] int  NOT NULL,
    [email1] nvarchar(max)  NOT NULL,
    [email2] nvarchar(max)  NOT NULL,
    [prospekt] bit  NOT NULL,
    [persNr] bigint  NOT NULL
);
GO

-- Creating table 'FörsäkringstagareFöretagSet'
CREATE TABLE [dbo].[FörsäkringstagareFöretagSet] (
    [försäkringstagareFöretagId] bigint IDENTITY(1,1) NOT NULL,
    [företagsNamn] nvarchar(max)  NOT NULL,
    [kFNamn] nvarchar(max)  NOT NULL,
    [kENamn] nvarchar(max)  NOT NULL,
    [ort] nvarchar(max)  NOT NULL,
    [postNr] int  NOT NULL,
    [tel1] int  NOT NULL,
    [faxNr] int  NOT NULL,
    [email1] nvarchar(max)  NOT NULL,
    [gatuAdress] nvarchar(max)  NOT NULL,
    [orgNr] bigint  NOT NULL
);
GO

-- Creating table 'RollSet'
CREATE TABLE [dbo].[RollSet] (
    [rollId] int IDENTITY(1,1) NOT NULL,
    [rollNamn] nvarchar(max)  NOT NULL,
    [Behörighet_behörighetsId] int  NOT NULL
);
GO

-- Creating table 'BehörighetSet'
CREATE TABLE [dbo].[BehörighetSet] (
    [behörighetsId] int IDENTITY(1,1) NOT NULL,
    [behörighetsTyp] int  NOT NULL
);
GO

-- Creating table 'TillvalSet'
CREATE TABLE [dbo].[TillvalSet] (
    [tillvalsId] int IDENTITY(1,1) NOT NULL,
    [datum] datetime  NOT NULL,
    [ackVärdeVariabel] float  NOT NULL,
    [tillvalsNamn] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TillvalGrundbeloppSet'
CREATE TABLE [dbo].[TillvalGrundbeloppSet] (
    [tvGrundbeloppId] int IDENTITY(1,1) NOT NULL,
    [grundBelopp] int  NOT NULL,
    [Tillval_tillvalsId] int  NOT NULL
);
GO

-- Creating table 'ProvisionstabellSet'
CREATE TABLE [dbo].[ProvisionstabellSet] (
    [provisionstabellsId] int IDENTITY(1,1) NOT NULL,
    [totaltMinAckVärde] int  NOT NULL,
    [totaltMaxAckVärde] int  NOT NULL,
    [provisionsAndelBarn] float  NOT NULL,
    [provionsAndelVuxen] float  NOT NULL,
    [period] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SemesterersättningSet'
CREATE TABLE [dbo].[SemesterersättningSet] (
    [semesterersättningsId] int IDENTITY(1,1) NOT NULL,
    [år] nvarchar(max)  NOT NULL,
    [avdrag] float  NOT NULL,
    [procentsats] float  NOT NULL
);
GO

-- Creating table 'GrundbeloppSet'
CREATE TABLE [dbo].[GrundbeloppSet] (
    [grundbeloppsId] int IDENTITY(1,1) NOT NULL,
    [datum] datetime  NOT NULL,
    [grundBelopp] int  NOT NULL,
    [ackVärde] float  NOT NULL,
    [FörsäkringsTyp_försäkringsTypId] int  NOT NULL
);
GO

-- Creating table 'FörsäkringsTypSet'
CREATE TABLE [dbo].[FörsäkringsTypSet] (
    [försäkringsTypId] int IDENTITY(1,1) NOT NULL,
    [försäkringsTyp] nvarchar(max)  NOT NULL,
    [Tillval_tillvalsId] int  NULL
);
GO

-- Creating table 'FörsäkringFöretagSet'
CREATE TABLE [dbo].[FörsäkringFöretagSet] (
    [FöretagsförsäkringsId] int IDENTITY(1,1) NOT NULL,
    [försäkringsNr] nvarchar(max)  NOT NULL,
    [betald] datetime  NOT NULL,
    [provisionsbelopp] int  NOT NULL,
    [Företagsansökan_företagsAnsökningsId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [försäkringsId] in table 'FörsäkringSet'
ALTER TABLE [dbo].[FörsäkringSet]
ADD CONSTRAINT [PK_FörsäkringSet]
    PRIMARY KEY CLUSTERED ([försäkringsId] ASC);
GO

-- Creating primary key on [anställningsId] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [PK_PersonalSet]
    PRIMARY KEY CLUSTERED ([anställningsId] ASC);
GO

-- Creating primary key on [företagsAnsökningsId] in table 'FöretagsansökanSet'
ALTER TABLE [dbo].[FöretagsansökanSet]
ADD CONSTRAINT [PK_FöretagsansökanSet]
    PRIMARY KEY CLUSTERED ([företagsAnsökningsId] ASC);
GO

-- Creating primary key on [privatAnsökningsId] in table 'PrivatansökanSet'
ALTER TABLE [dbo].[PrivatansökanSet]
ADD CONSTRAINT [PK_PrivatansökanSet]
    PRIMARY KEY CLUSTERED ([privatAnsökningsId] ASC);
GO

-- Creating primary key on [försäkringstagarePrivatId] in table 'FörsäkringstagarePrivatSet'
ALTER TABLE [dbo].[FörsäkringstagarePrivatSet]
ADD CONSTRAINT [PK_FörsäkringstagarePrivatSet]
    PRIMARY KEY CLUSTERED ([försäkringstagarePrivatId] ASC);
GO

-- Creating primary key on [försäkringstagareFöretagId] in table 'FörsäkringstagareFöretagSet'
ALTER TABLE [dbo].[FörsäkringstagareFöretagSet]
ADD CONSTRAINT [PK_FörsäkringstagareFöretagSet]
    PRIMARY KEY CLUSTERED ([försäkringstagareFöretagId] ASC);
GO

-- Creating primary key on [rollId] in table 'RollSet'
ALTER TABLE [dbo].[RollSet]
ADD CONSTRAINT [PK_RollSet]
    PRIMARY KEY CLUSTERED ([rollId] ASC);
GO

-- Creating primary key on [behörighetsId] in table 'BehörighetSet'
ALTER TABLE [dbo].[BehörighetSet]
ADD CONSTRAINT [PK_BehörighetSet]
    PRIMARY KEY CLUSTERED ([behörighetsId] ASC);
GO

-- Creating primary key on [tillvalsId] in table 'TillvalSet'
ALTER TABLE [dbo].[TillvalSet]
ADD CONSTRAINT [PK_TillvalSet]
    PRIMARY KEY CLUSTERED ([tillvalsId] ASC);
GO

-- Creating primary key on [tvGrundbeloppId] in table 'TillvalGrundbeloppSet'
ALTER TABLE [dbo].[TillvalGrundbeloppSet]
ADD CONSTRAINT [PK_TillvalGrundbeloppSet]
    PRIMARY KEY CLUSTERED ([tvGrundbeloppId] ASC);
GO

-- Creating primary key on [provisionstabellsId] in table 'ProvisionstabellSet'
ALTER TABLE [dbo].[ProvisionstabellSet]
ADD CONSTRAINT [PK_ProvisionstabellSet]
    PRIMARY KEY CLUSTERED ([provisionstabellsId] ASC);
GO

-- Creating primary key on [semesterersättningsId] in table 'SemesterersättningSet'
ALTER TABLE [dbo].[SemesterersättningSet]
ADD CONSTRAINT [PK_SemesterersättningSet]
    PRIMARY KEY CLUSTERED ([semesterersättningsId] ASC);
GO

-- Creating primary key on [grundbeloppsId] in table 'GrundbeloppSet'
ALTER TABLE [dbo].[GrundbeloppSet]
ADD CONSTRAINT [PK_GrundbeloppSet]
    PRIMARY KEY CLUSTERED ([grundbeloppsId] ASC);
GO

-- Creating primary key on [försäkringsTypId] in table 'FörsäkringsTypSet'
ALTER TABLE [dbo].[FörsäkringsTypSet]
ADD CONSTRAINT [PK_FörsäkringsTypSet]
    PRIMARY KEY CLUSTERED ([försäkringsTypId] ASC);
GO

-- Creating primary key on [FöretagsförsäkringsId] in table 'FörsäkringFöretagSet'
ALTER TABLE [dbo].[FörsäkringFöretagSet]
ADD CONSTRAINT [PK_FörsäkringFöretagSet]
    PRIMARY KEY CLUSTERED ([FöretagsförsäkringsId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Privatansökan_privatAnsökningsId] in table 'FörsäkringSet'
ALTER TABLE [dbo].[FörsäkringSet]
ADD CONSTRAINT [FK_FörsäkringPrivatansökan]
    FOREIGN KEY ([Privatansökan_privatAnsökningsId])
    REFERENCES [dbo].[PrivatansökanSet]
        ([privatAnsökningsId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FörsäkringPrivatansökan'
CREATE INDEX [IX_FK_FörsäkringPrivatansökan]
ON [dbo].[FörsäkringSet]
    ([Privatansökan_privatAnsökningsId]);
GO

-- Creating foreign key on [FörsäkringstagareFöretag_försäkringstagareFöretagId] in table 'FöretagsansökanSet'
ALTER TABLE [dbo].[FöretagsansökanSet]
ADD CONSTRAINT [FK_FöretagsansökanFörsäkringstagareFöretag]
    FOREIGN KEY ([FörsäkringstagareFöretag_försäkringstagareFöretagId])
    REFERENCES [dbo].[FörsäkringstagareFöretagSet]
        ([försäkringstagareFöretagId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FöretagsansökanFörsäkringstagareFöretag'
CREATE INDEX [IX_FK_FöretagsansökanFörsäkringstagareFöretag]
ON [dbo].[FöretagsansökanSet]
    ([FörsäkringstagareFöretag_försäkringstagareFöretagId]);
GO

-- Creating foreign key on [FörsäkringstagarePrivat_försäkringstagarePrivatId] in table 'PrivatansökanSet'
ALTER TABLE [dbo].[PrivatansökanSet]
ADD CONSTRAINT [FK_PrivatansökanFörsäkringstagarePrivat]
    FOREIGN KEY ([FörsäkringstagarePrivat_försäkringstagarePrivatId])
    REFERENCES [dbo].[FörsäkringstagarePrivatSet]
        ([försäkringstagarePrivatId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrivatansökanFörsäkringstagarePrivat'
CREATE INDEX [IX_FK_PrivatansökanFörsäkringstagarePrivat]
ON [dbo].[PrivatansökanSet]
    ([FörsäkringstagarePrivat_försäkringstagarePrivatId]);
GO

-- Creating foreign key on [Personal_anställningsId] in table 'PrivatansökanSet'
ALTER TABLE [dbo].[PrivatansökanSet]
ADD CONSTRAINT [FK_PrivatansökanPersonal]
    FOREIGN KEY ([Personal_anställningsId])
    REFERENCES [dbo].[PersonalSet]
        ([anställningsId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrivatansökanPersonal'
CREATE INDEX [IX_FK_PrivatansökanPersonal]
ON [dbo].[PrivatansökanSet]
    ([Personal_anställningsId]);
GO

-- Creating foreign key on [Personal_anställningsId] in table 'FöretagsansökanSet'
ALTER TABLE [dbo].[FöretagsansökanSet]
ADD CONSTRAINT [FK_FöretagsansökanPersonal]
    FOREIGN KEY ([Personal_anställningsId])
    REFERENCES [dbo].[PersonalSet]
        ([anställningsId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FöretagsansökanPersonal'
CREATE INDEX [IX_FK_FöretagsansökanPersonal]
ON [dbo].[FöretagsansökanSet]
    ([Personal_anställningsId]);
GO

-- Creating foreign key on [Roll_rollId] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [FK_PersonalRoll]
    FOREIGN KEY ([Roll_rollId])
    REFERENCES [dbo].[RollSet]
        ([rollId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonalRoll'
CREATE INDEX [IX_FK_PersonalRoll]
ON [dbo].[PersonalSet]
    ([Roll_rollId]);
GO

-- Creating foreign key on [Behörighet_behörighetsId] in table 'RollSet'
ALTER TABLE [dbo].[RollSet]
ADD CONSTRAINT [FK_RollBehörighet]
    FOREIGN KEY ([Behörighet_behörighetsId])
    REFERENCES [dbo].[BehörighetSet]
        ([behörighetsId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RollBehörighet'
CREATE INDEX [IX_FK_RollBehörighet]
ON [dbo].[RollSet]
    ([Behörighet_behörighetsId]);
GO

-- Creating foreign key on [Tillval_tillvalsId] in table 'TillvalGrundbeloppSet'
ALTER TABLE [dbo].[TillvalGrundbeloppSet]
ADD CONSTRAINT [FK_TillvalTillvalGrundbelopp]
    FOREIGN KEY ([Tillval_tillvalsId])
    REFERENCES [dbo].[TillvalSet]
        ([tillvalsId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TillvalTillvalGrundbelopp'
CREATE INDEX [IX_FK_TillvalTillvalGrundbelopp]
ON [dbo].[TillvalGrundbeloppSet]
    ([Tillval_tillvalsId]);
GO

-- Creating foreign key on [FörsäkringsTyp_försäkringsTypId] in table 'GrundbeloppSet'
ALTER TABLE [dbo].[GrundbeloppSet]
ADD CONSTRAINT [FK_GrundbeloppFörsäkringsTyp]
    FOREIGN KEY ([FörsäkringsTyp_försäkringsTypId])
    REFERENCES [dbo].[FörsäkringsTypSet]
        ([försäkringsTypId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GrundbeloppFörsäkringsTyp'
CREATE INDEX [IX_FK_GrundbeloppFörsäkringsTyp]
ON [dbo].[GrundbeloppSet]
    ([FörsäkringsTyp_försäkringsTypId]);
GO

-- Creating foreign key on [FörsäkringsTyp_försäkringsTypId] in table 'PrivatansökanSet'
ALTER TABLE [dbo].[PrivatansökanSet]
ADD CONSTRAINT [FK_FörsäkringsTypPrivatansökan]
    FOREIGN KEY ([FörsäkringsTyp_försäkringsTypId])
    REFERENCES [dbo].[FörsäkringsTypSet]
        ([försäkringsTypId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FörsäkringsTypPrivatansökan'
CREATE INDEX [IX_FK_FörsäkringsTypPrivatansökan]
ON [dbo].[PrivatansökanSet]
    ([FörsäkringsTyp_försäkringsTypId]);
GO

-- Creating foreign key on [Tillval_tillvalsId] in table 'FörsäkringsTypSet'
ALTER TABLE [dbo].[FörsäkringsTypSet]
ADD CONSTRAINT [FK_FörsäkringsTypTillval]
    FOREIGN KEY ([Tillval_tillvalsId])
    REFERENCES [dbo].[TillvalSet]
        ([tillvalsId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FörsäkringsTypTillval'
CREATE INDEX [IX_FK_FörsäkringsTypTillval]
ON [dbo].[FörsäkringsTypSet]
    ([Tillval_tillvalsId]);
GO

-- Creating foreign key on [Företagsansökan_företagsAnsökningsId] in table 'FörsäkringFöretagSet'
ALTER TABLE [dbo].[FörsäkringFöretagSet]
ADD CONSTRAINT [FK_FöretagsansökanFörsäkringFöretag]
    FOREIGN KEY ([Företagsansökan_företagsAnsökningsId])
    REFERENCES [dbo].[FöretagsansökanSet]
        ([företagsAnsökningsId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FöretagsansökanFörsäkringFöretag'
CREATE INDEX [IX_FK_FöretagsansökanFörsäkringFöretag]
ON [dbo].[FörsäkringFöretagSet]
    ([Företagsansökan_företagsAnsökningsId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------