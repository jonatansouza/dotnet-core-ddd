using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Uf_Municipio_Cep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2b441a98-4345-48b7-865b-ef8c7b68708a"));

            migrationBuilder.CreateTable(
                name: "uf",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Sigla = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "municipio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    CodIBGE = table.Column<int>(nullable: false),
                    UfId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipio_uf_UfId",
                        column: x => x.UfId,
                        principalTable: "uf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cep",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Cep = table.Column<string>(nullable: false),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    MunicipioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cep_municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("e764ec19-0739-43ca-99a9-410959c0fe73"), new DateTime(2021, 7, 28, 0, 57, 5, 702, DateTimeKind.Local).AddTicks(7331), "admin@admin.com", "Admin", new DateTime(2021, 7, 28, 0, 57, 5, 704, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.InsertData(
                table: "uf",
                columns: new[] { "Id", "CreateAt", "Nome", "Sigla", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9686), "São Paulo", "SP", null },
                    { new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9681), "Sergipe", "SE", null },
                    { new Guid("b81f95e0-f226-4afd-9763-290001637ed4"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9676), "Santa Catarina", "SC", null },
                    { new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9671), "Rio Grande do Sul", "RS", null },
                    { new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9666), "Roraima", "RR", null },
                    { new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9662), "Rondônia", "RO", null },
                    { new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9657), "Rio Grande do Norte", "RN", null },
                    { new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9652), "Rio de Janeiro", "RJ", null },
                    { new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9645), "Paraná", "PR", null },
                    { new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9641), "Piauí", "PI", null },
                    { new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9636), "Pernambuco", "PE", null },
                    { new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9632), "Paraíba", "PB", null },
                    { new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9627), "Pará", "PA", null },
                    { new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9621), "Mato Grosso", "MT", null },
                    { new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9617), "Mato Grosso do Sul", "MS", null },
                    { new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9612), "Minas Gerais", "MG", null },
                    { new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9607), "Maranhão", "MA", null },
                    { new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9602), "Goiás", "GO", null },
                    { new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9597), "Espírito Santo", "ES", null },
                    { new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9592), "Distrito Federal", "DF", null },
                    { new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9587), "Ceará", "CE", null },
                    { new Guid("5abca453-d035-4766-a81b-9f73d683a54b"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9583), "Bahia", "BA", null },
                    { new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9578), "Amapá", "AP", null },
                    { new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9573), "Amazonas", "AM", null },
                    { new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9564), "Alagoas", "AL", null },
                    { new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9691), "Tocantins", "TO", null },
                    { new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"), new DateTime(2021, 7, 28, 3, 57, 5, 709, DateTimeKind.Utc).AddTicks(9457), "Acre", "AC", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cep_Cep",
                table: "cep",
                column: "Cep");

            migrationBuilder.CreateIndex(
                name: "IX_cep_MunicipioId",
                table: "cep",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_CodIBGE",
                table: "municipio",
                column: "CodIBGE");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_UfId",
                table: "municipio",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_uf_Sigla",
                table: "uf",
                column: "Sigla",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cep");

            migrationBuilder.DropTable(
                name: "municipio");

            migrationBuilder.DropTable(
                name: "uf");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e764ec19-0739-43ca-99a9-410959c0fe73"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("2b441a98-4345-48b7-865b-ef8c7b68708a"), new DateTime(2021, 7, 27, 17, 18, 43, 593, DateTimeKind.Local).AddTicks(9036), "admin@admin.com", "Admin", new DateTime(2021, 7, 27, 17, 18, 43, 595, DateTimeKind.Local).AddTicks(2874) });
        }
    }
}
