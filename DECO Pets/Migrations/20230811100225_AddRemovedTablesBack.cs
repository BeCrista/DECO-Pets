using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DECO_Pets.Migrations
{
    /// <inheritdoc />
    public partial class AddRemovedTablesBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogRaces = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatRaces = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Seguradoras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualidade = table.Column<int>(type: "int", nullable: false),
                    QualidadeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coberturas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destaque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagemSeguradora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEdicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Responsabilidade_Civil_LimiteAnual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsabilidade_Civil_Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Despesas_Veterinarias_LimiteAnual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Despesas_Veterinarias_Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacinas_LimiteAnual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacinas_Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cirurgia_LimiteAnual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cirurgia_Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eutanasia_Funeral_LimiteAnual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eutanasia_Funeral_Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desaparecimento_LimiteAnual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desaparecimento_Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guarda_LimiteAnual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guarda_Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguradoras", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSpecies = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeightDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Dados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesID = table.Column<int>(type: "int", nullable: false),
                    RaceID = table.Column<int>(type: "int", nullable: false),
                    WeightID = table.Column<int>(type: "int", nullable: true),
                    AgeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dados", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dados_Ages_AgeID",
                        column: x => x.AgeID,
                        principalTable: "Ages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dados_Races_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Races",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dados_Species_SpeciesID",
                        column: x => x.SpeciesID,
                        principalTable: "Species",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dados_Weights_WeightID",
                        column: x => x.WeightID,
                        principalTable: "Weights",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Premios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DadosID = table.Column<int>(type: "int", nullable: false),
                    SeguradoraID = table.Column<int>(type: "int", nullable: false),
                    Premio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Premios_Dados_DadosID",
                        column: x => x.DadosID,
                        principalTable: "Dados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Premios_Seguradoras_SeguradoraID",
                        column: x => x.SeguradoraID,
                        principalTable: "Seguradoras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ages",
                columns: new[] { "ID", "AgeDescription" },
                values: new object[,]
                {
                    { 1, "Entre 0 e 6 Meses" },
                    { 2, "Entre 6 Meses e 1,5 Anos" },
                    { 3, "Entre 1,5 Anos e 2 Anos" },
                    { 4, "Entre 2 e 4 Anos" },
                    { 5, "Entre 4 e 6 Anos" },
                    { 6, "Entre 6 e 7 Anos" },
                    { 7, "Entre 7 e 8 Anos" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "ID", "CatRaces", "DogRaces" },
                values: new object[,]
                {
                    { 1, "Europeu comum/Sem raça definida", "Sem raça definida" },
                    { 2, "", "Beagle" },
                    { 3, "", "Bichon Maltês" },
                    { 4, "", "Border Collie" },
                    { 5, "", "Bouledogue Francês" },
                    { 6, "", "Boxer" },
                    { 7, "", "Poodle" },
                    { 8, "", "Cão da Serra da Estrela" },
                    { 9, "", "Cão de Água Português" },
                    { 10, "", "Pastor Alemão" },
                    { 11, "", "Chihuahua" },
                    { 12, "", "Chow-Chow" },
                    { 13, "", "Cocker Spaniel Inglês" },
                    { 14, "", "Golden Retriever" },
                    { 15, "", "Jack Russel Terrier" },
                    { 16, "", "Labrador Retriever" },
                    { 17, "", "Pinscher Miniatura" },
                    { 18, "", "Podengo Português" },
                    { 19, "", "Spitz Alemão" },
                    { 20, "", "Yorkshire Terrier" },
                    { 21, "Britânico Pêlo Longo", "" },
                    { 22, "Gato Bosques da Noruega", "" },
                    { 23, "Maine Coon", "" },
                    { 24, "Persa", "" },
                    { 25, "Siamês", "" },
                    { 26, "Sphynx", "" }
                });

            migrationBuilder.InsertData(
                table: "Seguradoras",
                columns: new[] { "ID", "Cirurgia_Franquia", "Cirurgia_LimiteAnual", "Coberturas", "DateEdicao", "Desaparecimento_Franquia", "Desaparecimento_LimiteAnual", "Designacao", "Despesas_Veterinarias_Franquia", "Despesas_Veterinarias_LimiteAnual", "Destaque", "Eutanasia_Funeral_Franquia", "Eutanasia_Funeral_LimiteAnual", "Guarda_Franquia", "Guarda_LimiteAnual", "ImagemSeguradora", "Nome", "Observacoes", "Qualidade", "QualidadeDesc", "Responsabilidade_Civil_Franquia", "Responsabilidade_Civil_LimiteAnual", "Vacinas_Franquia", "Vacinas_LimiteAnual" },
                values: new object[,]
                {
                    { 1, "10% rede, 30% fora rede", "Por doença: 500 €. Por acidente: 500 €", "Responsabilidade Civil, Acesso à rede veterinária, Despesas médicas por acidente, Cirurgia, Eutanásia, Desaparecimento e Guarda do animal", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1596), "Sem franquia", "100 €", "Netanimais Domésticos @Maxi", "", "Por doença: acesso à rede. Por acidente: 500 €", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "Sem franquia", "200 €", "Sem franquia", "300 €", "", "Mapfre", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 78, "Boa Qualidade", "50 €", "100.000 €", "", "Cobertura opcional" },
                    { 2, "10% rede, 30% fora rede", "Por doença: 500 €. Por acidente: 500 €", "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Funeral, Desaparecimento e Guarda do Animal", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1676), "Sem franquia", "100 €", "Cães e Gatos Pleno", "", "Acesso à rede", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "Sem franquia", "300 €", "Sem franquia", "300 €", "", "Seguros Continente", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 78, "Boa Qualidade", "50 €", "100.000 €", "", "Oferta vacina anual" },
                    { 3, "10 ou 30%, consoante o tipo de cirurgia", "6.500 € por sinistro e 20.000 € por anuidade; Limites máximos por tipo de cirurgia", "Responsabilidade Civil, Despesas médicas, Cirurgia, Despesas de internamento, Eutanásia, Desaparecimento e Guarda do Animal", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1682), "Sem franquia", "500 €; Máx. 30 dias", "Petki Platinum", "Franquia variável com o tipo de consulta ou exame", "Por doença ou acidente: 500 €", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "Sem franquia", "200 €", "Sem franquia", "500 €", "", "Europ Assistance", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 77, "Boa Qualidade", "", "50.000 €", "", "Acesso à rede" },
                    { 4, "30%", "1.000 €", "Responsabilidade Civil, Despesas veterinárias e Cirurgia", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1687), "", "Cobertura não disponível", "Pet 3 - Exclusivo subscritores", "30%", "250 €", "Os subscritores da DECO PROTESTE beneficiam de um desconto de 10% no prémio ao longo de todo o contrato. O prémio apresentado pressupõe um animal do género masculino e não esterilizado. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "", "Eutanásia incluída nas despesas médicas; Funeral excluído.", "", "Cobertura não disponível", "", "Fidelidade", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 76, "Boa Qualidade", "10% danos, mín. 50 €", "75.000 €", "", "Cobertura opcional" },
                    { 5, "30%", "1.000 €", "Responsabilidade Civil, Despesas veterinárias e Cirurgia", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1692), "", "Cobertura não disponível", "Pet 3", "30%", "250 €", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "", "Eutanásia incluída nas despesas médicas; Funeral excluído.", "", "Cobertura não disponível", "", "Fidelidade", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 76, "Boa Qualidade", "10% danos, mín. 50 €", "75.000 €", "", "Cobertura opcional" },
                    { 6, "10%", "Por acidente ou doença: 1000 €; Máx. 1 750 € ano; Exclusivo rede", "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Eutanásia, Desaparecimento e Guarda do Animal", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1700), "Sem franquia", "150 €", "NPET TOP DECO - Exclusivo subscritores", "", "Acesso à rede", "Produto exclusivo para subscritores da DECO PROTESTE. O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "Sem franquia", "250 €", "Sem franquia", "200 €", "", "NSeguros", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 76, "Boa Qualidade", "50 €", "50.000 €", "", "Acesso à rede" },
                    { 7, "30%", "2.250 €", "Responsabilidade Civil, Despesas veterinárias, Vacinas e Cirurgia", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1710), "", "Cobertura não disponível", "Pet Vital - Exclusivo subscritores", "30%", "750 €", "Os subscritores da DECO PROTESTE beneficiam de um desconto de 10% no prémio ao longo de todo o contrato. O prémio apresentado pressupõe um animal do género masculino e não esterilizado. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "", "Eutanásia incluída nas despesas médicas; Funeral opcional", "", "Cobertura não disponível", "", "Fidelidade", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 76, "Boa Qualidade", "10% danos, mín. 50 €", "200.000 €", "30%", "100 €" },
                    { 8, "30%", "2.250 €", "Responsabilidade Civil, Despesas veterinárias, Vacinas e Cirurgia", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1747), "", "Cobertura não disponível", "Pet Vital", "30%", "750 €", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "", "Eutanásia incluída nas despesas médicas; Funeral opcional", "", "Cobertura não disponível", "", "Fidelidade", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 76, "Boa Qualidade", "10% danos, mín. 50 €", "200.000 €", "30%", "100 €" },
                    { 9, "10% rede, 30% fora rede", "Por doença: 300 €. Por acidente: 300 €", "Responsabilidade Civil, Acesso à rede veterinária, Despesas médicas por acidente, Cirurgia, Eutanásia e Desaparecimento", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1755), "Sem franquia", "50 €", "Netanimais Domésticos @Média", "", "Por doença: acesso à rede. Por acidente: 300 €", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "Sem franquia", "100 €", "", "Cobertura não disponível", "", "Mapfre", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 74, "Boa Qualidade", "50 €", "50.000 €", "", "Cobertura opcional" },
                    { 10, "10 ou 30%, consoante o tipo de cirurgia", "4 600 € por sinistro e 14 000 € por anuidade; Limites máximos por tipo de cirurgia", "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Despesas de internamento, Desaparecimento e Guarda do Animal", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1763), "Sem franquia", "500 €; Máx. 30 dias", "Petki Gold", "", "Acesso à rede", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "", "Cobertura não disponível", "Sem franquia", "500 €", "", "Europ Assistance", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 74, "Boa Qualidade", "", "50.000 €", "", "Acesso à rede" },
                    { 11, "10% rede, 30% fora rede", "Por doença: 300 € Por acidente: 300 €", "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Eutanásia e Desaparecimento", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1772), "Sem franquia", "50 €", "Cães e Gatos Conforto", "", "Acesso à rede", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "Sem franquia", "200 €", "", "Cobertura não disponível", "", "Seguros Continente", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 73, "Boa Qualidade", "50 €", "50.000 €", "", "Oferta vacina anual" },
                    { 12, "10%", "Por acidente ou doença: 1000 €; Máx. 1 750 € ano; Exclusivo rede", "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Desaparecimento e Guarda do animal", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1779), "Sem franquia", "150 €", "NPET TOP - Exclusivo subscritores", "", "Acesso à rede", "Os subscritores da DECO PROTESTE usufruem de um desconto. O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "", "Cobertura não disponível", "Sem franquia", "200 €", "", "NSeguros", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 67, "Boa Qualidade", "50 €", "50.000 €", "", "Acesso à rede" },
                    { 13, "10%", "Por acidentes ou doença: 500 €. Exclusivo rede", "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Desaparecimento e Guarda do animal", new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1789), "Sem franquia", "150 €", "NPET TOP", "", "Acesso à rede", "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.", "", "Cobertura não disponível", "Sem franquia", "200 €", "", "NSeguros", "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.", 67, "Boa Qualidade", "50 €", "50.000 €", "", "Acesso à rede" }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "ID", "NameSpecies" },
                values: new object[,]
                {
                    { 1, "Cão" },
                    { 2, "Gato" }
                });

            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "ID", "WeightDescription" },
                values: new object[,]
                {
                    { 1, "Até 5Kg" },
                    { 2, "Entre 5Kg e 10Kg" },
                    { 3, "Entre 11Kg e 20Kg" },
                    { 4, "Entre 21Kg e 45Kg" },
                    { 5, "Mais de 45Kg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dados_AgeID",
                table: "Dados",
                column: "AgeID");

            migrationBuilder.CreateIndex(
                name: "IX_Dados_RaceID",
                table: "Dados",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Dados_SpeciesID",
                table: "Dados",
                column: "SpeciesID");

            migrationBuilder.CreateIndex(
                name: "IX_Dados_WeightID",
                table: "Dados",
                column: "WeightID");

            migrationBuilder.CreateIndex(
                name: "IX_Premios_DadosID",
                table: "Premios",
                column: "DadosID");

            migrationBuilder.CreateIndex(
                name: "IX_Premios_SeguradoraID",
                table: "Premios",
                column: "SeguradoraID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Premios");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Dados");

            migrationBuilder.DropTable(
                name: "Seguradoras");

            migrationBuilder.DropTable(
                name: "Ages");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Weights");
        }
    }
}
