using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SAGRE.Migrations
{
    public partial class Migrando_para_o_SQLite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atividade",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeAtividade = table.Column<string>(nullable: true),
                    DescricaoAtividade = table.Column<string>(nullable: true),
                    Inativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Boletim",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeFiscal = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Setor = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Atividade = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Flag = table.Column<int>(nullable: false),
                    Local = table.Column<string>(nullable: false),
                    HoraInicio = table.Column<string>(nullable: true),
                    HoraTermino = table.Column<string>(nullable: true),
                    TempoDuracao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletim", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CheckList_AnaliseCondBio",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoCheckList = table.Column<int>(nullable: false),
                    ID_Boletim = table.Column<int>(nullable: false),
                    Questao01 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao02 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao03 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao04 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao05 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao06 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao07 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao08 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao09 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao10 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao11 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao12 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao13 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao14 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao15 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao16 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao17 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao18 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao19 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao20 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao21 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao22 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao23 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao24 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao25 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao26 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao27 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao28 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao29 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao30 = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList_AnaliseCondBio", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CheckList_AnaliseCondErg",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoCheckList = table.Column<int>(nullable: false),
                    ID_Boletim = table.Column<int>(nullable: false),
                    Questao01 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao02 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao03 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao04 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao05 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao06 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao07 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao08 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao09 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao10 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao11 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao12 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao13 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao14 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao15 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao16 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao17 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao18 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao19 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao20 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao21 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao22 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao23 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao24 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao25 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao26 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao27 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao28 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao29 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao30 = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList_AnaliseCondErg", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClassificacaoOWAS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumCosta = table.Column<int>(nullable: false),
                    NumBraco = table.Column<int>(nullable: false),
                    NumPernas = table.Column<int>(nullable: false),
                    NumForca = table.Column<int>(nullable: false),
                    NumCategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificacaoOWAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GrupoRisco",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Inativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoRisco", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sigla = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Inativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tmp_CheckList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoCheckList = table.Column<int>(nullable: false),
                    ID_Boletim = table.Column<int>(nullable: false),
                    Questao01 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao02 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao03 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao04 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao05 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao06 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao07 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao08 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao09 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao10 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao11 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao12 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao13 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao14 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao15 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao16 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao17 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao18 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao19 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao20 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao21 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao22 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao23 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao24 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao25 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao26 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao27 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao28 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao29 = table.Column<string>(maxLength: 3, nullable: true),
                    Questao30 = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tmp_CheckList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnaliseNASATLX",
                columns: table => new
                {
                    ID_Analise = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID = table.Column<int>(nullable: false),
                    rangeDM = table.Column<string>(nullable: true),
                    rangeDF = table.Column<string>(nullable: true),
                    rangeDT = table.Column<string>(nullable: true),
                    rangeDE = table.Column<string>(nullable: true),
                    rangePE = table.Column<string>(nullable: true),
                    rangeFR = table.Column<string>(nullable: true),
                    escalaFisica = table.Column<string>(nullable: true),
                    escalaTemporal = table.Column<string>(nullable: true),
                    escalaMental = table.Column<string>(nullable: true),
                    escalaPerformace = table.Column<string>(nullable: true),
                    escalaEsforco = table.Column<string>(nullable: true),
                    escalaFrustacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaliseNASATLX", x => x.ID_Analise);
                    table.ForeignKey(
                        name: "FK_AnaliseNASATLX_Boletim_ID",
                        column: x => x.ID,
                        principalTable: "Boletim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalisePostura",
                columns: table => new
                {
                    ID_Analise = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID = table.Column<int>(nullable: false),
                    IB = table.Column<string>(nullable: true),
                    IP = table.Column<string>(nullable: true),
                    IE = table.Column<string>(nullable: true),
                    IC = table.Column<string>(nullable: true),
                    Index = table.Column<int>(nullable: false),
                    IBDescricao = table.Column<string>(nullable: true),
                    IPDescricao = table.Column<string>(nullable: true),
                    IEDescricao = table.Column<string>(nullable: true),
                    ICDescricao = table.Column<string>(nullable: true),
                    AcaoDescricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalisePostura", x => x.ID_Analise);
                    table.ForeignKey(
                        name: "FK_AnalisePostura_Boletim_ID",
                        column: x => x.ID,
                        principalTable: "Boletim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    ID_Local = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID = table.Column<int>(nullable: false),
                    Sigla = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Inativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.ID_Local);
                    table.ForeignKey(
                        name: "FK_Local_Setor_ID",
                        column: x => x.ID,
                        principalTable: "Setor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnaliseNASATLX_ID",
                table: "AnaliseNASATLX",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnalisePostura_ID",
                table: "AnalisePostura",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Local_ID",
                table: "Local",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnaliseNASATLX");

            migrationBuilder.DropTable(
                name: "AnalisePostura");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Atividade");

            migrationBuilder.DropTable(
                name: "CheckList_AnaliseCondBio");

            migrationBuilder.DropTable(
                name: "CheckList_AnaliseCondErg");

            migrationBuilder.DropTable(
                name: "ClassificacaoOWAS");

            migrationBuilder.DropTable(
                name: "GrupoRisco");

            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropTable(
                name: "Tmp_CheckList");

            migrationBuilder.DropTable(
                name: "Boletim");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Setor");
        }
    }
}
