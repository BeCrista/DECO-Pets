using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DECO_Pets.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRaceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dados_Weights_WeightID",
                table: "Dados");

            migrationBuilder.DropColumn(
                name: "CatRaces",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "DogRaces",
                table: "Races",
                newName: "Descricao");

            migrationBuilder.AddColumn<int>(
                name: "EspeciesID",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "WeightID",
                table: "Dados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 1,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 2,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 3,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 4,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 5,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 6,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 7,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 8,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 9,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 10,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 11,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 12,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 13,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 14,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 15,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 16,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 17,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 18,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 19,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 20,
                column: "EspeciesID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Descricao", "EspeciesID" },
                values: new object[] { "Europeu comum/Sem raça definida", 2 });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Descricao", "EspeciesID" },
                values: new object[] { "Britânico Pêlo Longo", 2 });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Descricao", "EspeciesID" },
                values: new object[] { "Gato Bosques da Noruega", 2 });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Descricao", "EspeciesID" },
                values: new object[] { "Maine Coon", 2 });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Descricao", "EspeciesID" },
                values: new object[] { "Persa", 2 });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Descricao", "EspeciesID" },
                values: new object[] { "Siamês", 2 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "ID", "Descricao", "EspeciesID" },
                values: new object[] { 27, "Sphynx", 2 });

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 11,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 12,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 13,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 14, 12, 40, 26, 430, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.CreateIndex(
                name: "IX_Races_EspeciesID",
                table: "Races",
                column: "EspeciesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dados_Weights_WeightID",
                table: "Dados",
                column: "WeightID",
                principalTable: "Weights",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Species_EspeciesID",
                table: "Races",
                column: "EspeciesID",
                principalTable: "Species",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dados_Weights_WeightID",
                table: "Dados");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Species_EspeciesID",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_EspeciesID",
                table: "Races");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DropColumn(
                name: "EspeciesID",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Races",
                newName: "DogRaces");

            migrationBuilder.AddColumn<string>(
                name: "CatRaces",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "WeightID",
                table: "Dados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 1,
                column: "CatRaces",
                value: "Europeu comum/Sem raça definida");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 2,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 3,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 4,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 5,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 6,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 7,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 8,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 9,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 10,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 11,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 12,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 13,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 14,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 15,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 16,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 17,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 18,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 19,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 20,
                column: "CatRaces",
                value: "");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CatRaces", "DogRaces" },
                values: new object[] { "Britânico Pêlo Longo", "" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CatRaces", "DogRaces" },
                values: new object[] { "Gato Bosques da Noruega", "" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CatRaces", "DogRaces" },
                values: new object[] { "Maine Coon", "" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CatRaces", "DogRaces" },
                values: new object[] { "Persa", "" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CatRaces", "DogRaces" },
                values: new object[] { "Siamês", "" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CatRaces", "DogRaces" },
                values: new object[] { "Sphynx", "" });

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 11,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 12,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 13,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.AddForeignKey(
                name: "FK_Dados_Weights_WeightID",
                table: "Dados",
                column: "WeightID",
                principalTable: "Weights",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
