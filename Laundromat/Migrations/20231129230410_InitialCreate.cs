using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laundromat.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreName = table.Column<string>(type: "TEXT", nullable: true),
                    StoreAddress = table.Column<string>(type: "TEXT", nullable: true),
                    HoursofOperationstartoftheDay = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HoursofOperationEndoftheDay = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CostToRun = table.Column<decimal>(type: "TEXT", nullable: false),
                    BusinessRevenue = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerLastName = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerSex = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerAge = table.Column<int>(type: "INTEGER", nullable: false),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId");
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentType = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.SerialNumber);
                    table.ForeignKey(
                        name: "FK_Equipment_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentUsages",
                columns: table => new
                {
                    EquipmentUsageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquipmentSerialNumber = table.Column<string>(type: "TEXT", nullable: true),
                    TimeWashCycle = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: true),
                    TypeofEquipmentinUse = table.Column<string>(type: "TEXT", nullable: true),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentUsages", x => x.EquipmentUsageId);
                    table.ForeignKey(
                        name: "FK_EquipmentUsages_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_EquipmentUsages_Equipment_EquipmentSerialNumber",
                        column: x => x.EquipmentSerialNumber,
                        principalTable: "Equipment",
                        principalColumn: "SerialNumber");
                    table.ForeignKey(
                        name: "FK_EquipmentUsages_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StoreId",
                table: "Customers",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_StoreId",
                table: "Equipment",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_CustomerId",
                table: "EquipmentUsages",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_EquipmentSerialNumber",
                table: "EquipmentUsages",
                column: "EquipmentSerialNumber");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_StoreId",
                table: "EquipmentUsages",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentUsages");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
