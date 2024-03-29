using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace adminpanel.Migrations
{
    /// <inheritdoc />
    public partial class createdNewTableSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aperatifler");

            migrationBuilder.DropTable(
                name: "cerezler");

            migrationBuilder.DropTable(
                name: "cinler");

            migrationBuilder.DropTable(
                name: "corbalar");

            migrationBuilder.DropTable(
                name: "etler");

            migrationBuilder.DropTable(
                name: "ficibiralar");

            migrationBuilder.DropTable(
                name: "kokteylshotlar");

            migrationBuilder.DropTable(
                name: "likörler");

            migrationBuilder.DropTable(
                name: "makarnalar");

            migrationBuilder.DropTable(
                name: "pizzalar");

            migrationBuilder.DropTable(
                name: "salatalar");

            migrationBuilder.DropTable(
                name: "sandvicler");

            migrationBuilder.DropTable(
                name: "saraplar");

            migrationBuilder.DropTable(
                name: "sicakicecekler");

            migrationBuilder.DropTable(
                name: "sisebiralar");

            migrationBuilder.DropTable(
                name: "sogukicecekler");

            migrationBuilder.DropTable(
                name: "tatlilar");

            migrationBuilder.DropTable(
                name: "tavuklar");

            migrationBuilder.DropTable(
                name: "vermutlar");

            migrationBuilder.DropTable(
                name: "viskiler");

            migrationBuilder.DropTable(
                name: "vodkalar");

            migrationBuilder.CreateTable(
                name: "tablolar",
                columns: table => new
                {
                    tabloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tabloName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablolar", x => x.tabloId);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    tabloId = table.Column<int>(type: "int", nullable: false),
                    kategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_urunler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_urunler_tablolar_tabloId",
                        column: x => x.tabloId,
                        principalTable: "tablolar",
                        principalColumn: "tabloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_urunler_kategoriId",
                table: "urunler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_urunler_tabloId",
                table: "urunler",
                column: "tabloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "urunler");

            migrationBuilder.DropTable(
                name: "tablolar");

            migrationBuilder.CreateTable(
                name: "aperatifler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aperatifler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aperatifler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cerezler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cerezler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cerezler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cinler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cinler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "corbalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_corbalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_corbalar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_etler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ficibiralar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ficibiralar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ficibiralar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kokteylshotlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kokteylshotlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kokteylshotlar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "likörler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likörler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_likörler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "makarnalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_makarnalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_makarnalar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pizzalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizzalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pizzalar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "salatalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salatalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_salatalar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sandvicler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sandvicler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sandvicler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saraplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saraplar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_saraplar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sicakicecekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sicakicecekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sicakicecekler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sisebiralar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sisebiralar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sisebiralar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sogukicecekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sogukicecekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sogukicecekler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tatlilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tatlilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tatlilar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tavuklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tavuklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tavuklar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vermutlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vermutlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vermutlar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "viskiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viskiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_viskiler_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vodkalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vodkalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vodkalar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aperatifler_kategoriId",
                table: "aperatifler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_cerezler_kategoriId",
                table: "cerezler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_cinler_kategoriId",
                table: "cinler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_corbalar_kategoriId",
                table: "corbalar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_etler_kategoriId",
                table: "etler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_ficibiralar_kategoriId",
                table: "ficibiralar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_kokteylshotlar_kategoriId",
                table: "kokteylshotlar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_likörler_kategoriId",
                table: "likörler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_makarnalar_kategoriId",
                table: "makarnalar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_pizzalar_kategoriId",
                table: "pizzalar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_salatalar_kategoriId",
                table: "salatalar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_sandvicler_kategoriId",
                table: "sandvicler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_saraplar_kategoriId",
                table: "saraplar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_sicakicecekler_kategoriId",
                table: "sicakicecekler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_sisebiralar_kategoriId",
                table: "sisebiralar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_sogukicecekler_kategoriId",
                table: "sogukicecekler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_tatlilar_kategoriId",
                table: "tatlilar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_tavuklar_kategoriId",
                table: "tavuklar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_vermutlar_kategoriId",
                table: "vermutlar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_viskiler_kategoriId",
                table: "viskiler",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_vodkalar_kategoriId",
                table: "vodkalar",
                column: "kategoriId");
        }
    }
}
