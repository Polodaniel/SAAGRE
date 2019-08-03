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

CREATE TABLE [TmpCheckList] (
    [ID] int NOT NULL IDENTITY,
    [TipoCheckList] int NOT NULL,
    [ID_Boletim] int NOT NULL,
    [Questao01] bit NOT NULL,
    [Questao02] bit NOT NULL,
    [Questao03] bit NOT NULL,
    [Questao04] bit NOT NULL,
    [Questao05] bit NOT NULL,
    [Questao06] bit NOT NULL,
    [Questao07] bit NOT NULL,
    [Questao08] bit NOT NULL,
    [Questao09] bit NOT NULL,
    [Questao10] bit NOT NULL,
    [Questao11] bit NOT NULL,
    [Questao12] bit NOT NULL,
    [Questao13] bit NOT NULL,
    [Questao14] bit NOT NULL,
    [Questao15] bit NOT NULL,
    [Questao16] bit NOT NULL,
    [Questao17] bit NOT NULL,
    [Questao18] bit NOT NULL,
    [Questao19] bit NOT NULL,
    [Questao20] bit NOT NULL,
    CONSTRAINT [PK_TmpCheckList] PRIMARY KEY ([ID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190630234016_Cria_Tabela_TmpCheckList', N'2.1.11-servicing-32099');

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao20');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao20] nvarchar(max) NULL;

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao19');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao19] nvarchar(max) NULL;

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao18');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao18] nvarchar(max) NULL;

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao17');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao17] nvarchar(max) NULL;

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao16');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao16] nvarchar(max) NULL;

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao15');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao15] nvarchar(max) NULL;

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao14');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao14] nvarchar(max) NULL;

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao13');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao13] nvarchar(max) NULL;

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao12');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao12] nvarchar(max) NULL;

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao11');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao11] nvarchar(max) NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao10');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao10] nvarchar(max) NULL;

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao09');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao09] nvarchar(max) NULL;

GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao08');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao08] nvarchar(max) NULL;

GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao07');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao07] nvarchar(max) NULL;

GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao06');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao06] nvarchar(max) NULL;

GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao05');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao05] nvarchar(max) NULL;

GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao04');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao04] nvarchar(max) NULL;

GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao03');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao03] nvarchar(max) NULL;

GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao02');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao02] nvarchar(max) NULL;

GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao01');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao01] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190702234256_Troca_Tipo_Coluna_TmpCheckList', N'2.1.11-servicing-32099');

GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao20');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao20] nvarchar(3) NULL;

GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao19');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao19] nvarchar(3) NULL;

GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao18');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao18] nvarchar(3) NULL;

GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao17');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao17] nvarchar(3) NULL;

GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao16');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao16] nvarchar(3) NULL;

GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao15');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao15] nvarchar(3) NULL;

GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao14');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao14] nvarchar(3) NULL;

GO

DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao13');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao13] nvarchar(3) NULL;

GO

DECLARE @var32 sysname;
SELECT @var32 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao12');
IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var32 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao12] nvarchar(3) NULL;

GO

DECLARE @var33 sysname;
SELECT @var33 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao11');
IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var33 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao11] nvarchar(3) NULL;

GO

DECLARE @var34 sysname;
SELECT @var34 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao10');
IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var34 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao10] nvarchar(3) NULL;

GO

DECLARE @var35 sysname;
SELECT @var35 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao09');
IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var35 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao09] nvarchar(3) NULL;

GO

DECLARE @var36 sysname;
SELECT @var36 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao08');
IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var36 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao08] nvarchar(3) NULL;

GO

DECLARE @var37 sysname;
SELECT @var37 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao07');
IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var37 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao07] nvarchar(3) NULL;

GO

DECLARE @var38 sysname;
SELECT @var38 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao06');
IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var38 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao06] nvarchar(3) NULL;

GO

DECLARE @var39 sysname;
SELECT @var39 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao05');
IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var39 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao05] nvarchar(3) NULL;

GO

DECLARE @var40 sysname;
SELECT @var40 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao04');
IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var40 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao04] nvarchar(3) NULL;

GO

DECLARE @var41 sysname;
SELECT @var41 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao03');
IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var41 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao03] nvarchar(3) NULL;

GO

DECLARE @var42 sysname;
SELECT @var42 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao02');
IF @var42 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var42 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao02] nvarchar(3) NULL;

GO

DECLARE @var43 sysname;
SELECT @var43 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TmpCheckList]') AND [c].[name] = N'Questao01');
IF @var43 IS NOT NULL EXEC(N'ALTER TABLE [TmpCheckList] DROP CONSTRAINT [' + @var43 + '];');
ALTER TABLE [TmpCheckList] ALTER COLUMN [Questao01] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao21] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao22] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao23] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao24] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao25] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao26] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao27] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao28] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao29] nvarchar(3) NULL;

GO

ALTER TABLE [TmpCheckList] ADD [Questao30] nvarchar(3) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190705215804_Add_NovasPerguntas_Tmp_Muda_Tamanho', N'2.1.11-servicing-32099');

GO

