IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(128) NOT NULL,
    [ProviderKey] nvarchar(128) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(128) NOT NULL,
    [Name] nvarchar(128) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'00000000000000_CreateIdentitySchema', N'2.1.11-servicing-32099');

GO

CREATE TABLE [AtividadesModel] (
    [ID] int NOT NULL IDENTITY,
    [NomeAtividade] nvarchar(max) NULL,
    [DescricaoAtividade] nvarchar(max) NULL,
    [Inativo] bit NOT NULL,
    CONSTRAINT [PK_AtividadesModel] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [BoletimModel] (
    [ID] int NOT NULL IDENTITY,
    [NomeFiscal] nvarchar(max) NOT NULL,
    [Data] datetime2 NOT NULL,
    [Setor] nvarchar(max) NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [Status] int NOT NULL,
    [Flag] int NOT NULL,
    CONSTRAINT [PK_BoletimModel] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [ClassificaoOWAS] (
    [ID] int NOT NULL IDENTITY,
    [NumCosta] int NOT NULL,
    [NumBraco] int NOT NULL,
    [NumPernas] int NOT NULL,
    [NumForca] int NOT NULL,
    CONSTRAINT [PK_ClassificaoOWAS] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [GruposRiscoModel] (
    [ID] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [Inativo] bit NOT NULL,
    CONSTRAINT [PK_GruposRiscoModel] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [SetorModel] (
    [ID] int NOT NULL IDENTITY,
    [Sigla] nvarchar(max) NULL,
    [Nome] nvarchar(max) NOT NULL,
    [Descricao] nvarchar(max) NULL,
    [Inativo] bit NOT NULL,
    CONSTRAINT [PK_SetorModel] PRIMARY KEY ([ID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190608033002_Cria_Banco_Dados_e_Tabelas_Iniciais', N'2.1.11-servicing-32099');

GO

ALTER TABLE [ClassificaoOWAS] ADD [NumCategoria] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190608173254_Adiciona_Coluna_Classificacao', N'2.1.11-servicing-32099');

GO

CREATE TABLE [AnalisePosturaModel] (
    [ID_Analise] int NOT NULL IDENTITY,
    [ID] int NOT NULL,
    [IB] int NOT NULL,
    [IP] int NOT NULL,
    [IE] int NOT NULL,
    [IC] int NOT NULL,
    [Index] int NOT NULL,
    [IBDescricao] nvarchar(max) NULL,
    [IPDescricao] nvarchar(max) NULL,
    [IEDescricao] nvarchar(max) NULL,
    [ICDescricao] nvarchar(max) NULL,
    [AcaoDescricao] nvarchar(max) NULL,
    CONSTRAINT [PK_AnalisePosturaModel] PRIMARY KEY ([ID_Analise]),
    CONSTRAINT [FK_AnalisePosturaModel_BoletimModel_ID] FOREIGN KEY ([ID]) REFERENCES [BoletimModel] ([ID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_AnalisePosturaModel_ID] ON [AnalisePosturaModel] ([ID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190611012043_Cria_Tabela_AnalisePostura', N'2.1.11-servicing-32099');

GO

ALTER TABLE [BoletimModel] ADD [Atividade] nvarchar(max) NOT NULL DEFAULT N'';

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AnalisePosturaModel]') AND [c].[name] = N'IP');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AnalisePosturaModel] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [AnalisePosturaModel] ALTER COLUMN [IP] nvarchar(max) NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AnalisePosturaModel]') AND [c].[name] = N'IE');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [AnalisePosturaModel] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [AnalisePosturaModel] ALTER COLUMN [IE] nvarchar(max) NULL;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AnalisePosturaModel]') AND [c].[name] = N'IC');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [AnalisePosturaModel] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [AnalisePosturaModel] ALTER COLUMN [IC] nvarchar(max) NULL;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AnalisePosturaModel]') AND [c].[name] = N'IB');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [AnalisePosturaModel] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [AnalisePosturaModel] ALTER COLUMN [IB] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190612221947_Cria_Coluna_Atividade', N'2.1.11-servicing-32099');

GO

CREATE TABLE [AnaliseNASATLXModel] (
    [ID_Analise] int NOT NULL IDENTITY,
    [ID] int NOT NULL,
    [rangeDM] nvarchar(max) NULL,
    [rangeDF] nvarchar(max) NULL,
    [rangeDT] nvarchar(max) NULL,
    [rangeDE] nvarchar(max) NULL,
    [rangePE] nvarchar(max) NULL,
    [rangeFR] nvarchar(max) NULL,
    [escalaFisica] nvarchar(max) NULL,
    [escalaTemporal] nvarchar(max) NULL,
    [escalaMental] nvarchar(max) NULL,
    [escalaPerformace] nvarchar(max) NULL,
    [escalaEsforco] nvarchar(max) NULL,
    [escalaFrustacao] nvarchar(max) NULL,
    CONSTRAINT [PK_AnaliseNASATLXModel] PRIMARY KEY ([ID_Analise]),
    CONSTRAINT [FK_AnaliseNASATLXModel_BoletimModel_ID] FOREIGN KEY ([ID]) REFERENCES [BoletimModel] ([ID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_AnaliseNASATLXModel_ID] ON [AnaliseNASATLXModel] ([ID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190622133940_Cria_Tabela_Analise_NASATLX', N'2.1.11-servicing-32099');

GO

DROP INDEX [IX_AnaliseNASATLXModel_ID] ON [AnaliseNASATLXModel];

GO

ALTER TABLE [BoletimModel] ADD [HoraInicio] nvarchar(max) NULL;

GO

ALTER TABLE [BoletimModel] ADD [HoraTermino] nvarchar(max) NULL;

GO

ALTER TABLE [BoletimModel] ADD [Local] nvarchar(max) NOT NULL DEFAULT N'';

GO

ALTER TABLE [BoletimModel] ADD [TempoDuracao] nvarchar(max) NULL;

GO

CREATE UNIQUE INDEX [IX_AnaliseNASATLXModel_ID] ON [AnaliseNASATLXModel] ([ID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190626225548_Add_Colunas_Tempo_Local', N'2.1.11-servicing-32099');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190627000834_Cria_Tabela_Local', N'2.1.11-servicing-32099');

GO

CREATE TABLE [Local] (
    [ID_Local] int NOT NULL IDENTITY,
    [ID] int NOT NULL,
    [Sigla] nvarchar(max) NULL,
    [Nome] nvarchar(max) NOT NULL,
    [Descricao] nvarchar(max) NULL,
    [Inativo] bit NOT NULL,
    CONSTRAINT [PK_Local] PRIMARY KEY ([ID_Local]),
    CONSTRAINT [FK_Local_SetorModel_ID] FOREIGN KEY ([ID]) REFERENCES [SetorModel] ([ID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Local_ID] ON [Local] ([ID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190627001234_Cria_Tabela_Local_Empresa', N'2.1.11-servicing-32099');

GO

