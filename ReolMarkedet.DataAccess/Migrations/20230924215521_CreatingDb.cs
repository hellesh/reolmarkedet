using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReolMarkedet.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreatingDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    saleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<double>(type: "float", nullable: false),
                    discountInPercentage = table.Column<double>(type: "float", nullable: false),
                    priceOfSale = table.Column<double>(type: "float", nullable: false),
                    barcodeInNumbers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.saleId);
                });

            migrationBuilder.CreateTable(
                name: "Shelftenants",
                columns: table => new
                {
                    tenantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    totalSale = table.Column<double>(type: "float", nullable: false),
                    bankAccountDetails = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelftenants", x => x.tenantId);
                });

            migrationBuilder.CreateTable(
                name: "Barcodes",
                columns: table => new
                {
                    barcodeInNumbers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discountInPercentage = table.Column<double>(type: "float", nullable: false),
                    ShelfTenanttenantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcodes", x => x.barcodeInNumbers);
                    table.ForeignKey(
                        name: "FK_Barcodes_Shelftenants_ShelfTenanttenantId",
                        column: x => x.ShelfTenanttenantId,
                        principalTable: "Shelftenants",
                        principalColumn: "tenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payouts",
                columns: table => new
                {
                    payoutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fine = table.Column<double>(type: "float", nullable: false),
                    commission = table.Column<double>(type: "float", nullable: false),
                    totalPayout = table.Column<double>(type: "float", nullable: false),
                    totalSale = table.Column<double>(type: "float", nullable: false),
                    commissionDeduction = table.Column<double>(type: "float", nullable: false),
                    ShelfTenanttenantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payouts", x => x.payoutId);
                    table.ForeignKey(
                        name: "FK_Payouts_Shelftenants_ShelfTenanttenantId",
                        column: x => x.ShelfTenanttenantId,
                        principalTable: "Shelftenants",
                        principalColumn: "tenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BarcodeSale",
                columns: table => new
                {
                    BarcodesbarcodeInNumbers = table.Column<int>(type: "int", nullable: false),
                    SalessaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodeSale", x => new { x.BarcodesbarcodeInNumbers, x.SalessaleId });
                    table.ForeignKey(
                        name: "FK_BarcodeSale_Barcodes_BarcodesbarcodeInNumbers",
                        column: x => x.BarcodesbarcodeInNumbers,
                        principalTable: "Barcodes",
                        principalColumn: "barcodeInNumbers",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BarcodeSale_Sales_SalessaleId",
                        column: x => x.SalessaleId,
                        principalTable: "Sales",
                        principalColumn: "saleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "saleId", "barcodeInNumbers", "discountInPercentage", "price", "priceOfSale" },
                values: new object[,]
                {
                    { 1, 1, 0.0, 100.0, 100.0 },
                    { 2, 2, 50.0, 50.0, 25.0 },
                    { 3, 3, 0.0, 150.0, 150.0 }
                });

            migrationBuilder.InsertData(
                table: "Shelftenants",
                columns: new[] { "tenantId", "bankAccountDetails", "email", "firstName", "lastName", "phone", "totalSale" },
                values: new object[,]
                {
                    { 1, "", "chuck@norris.dk", "Chuck", "Norris", "12345678", 0.0 },
                    { 2, "", "ch@ris.dk", "Chris", "Chrissie", "23456789", 0.0 },
                    { 3, "", "hmm@mmm.dk", "Cri", "sti", "34567890", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Barcodes",
                columns: new[] { "barcodeInNumbers", "ShelfTenanttenantId", "discountInPercentage" },
                values: new object[,]
                {
                    { 1, 1, 0.0 },
                    { 2, 1, 15.0 },
                    { 3, 1, 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Payouts",
                columns: new[] { "payoutId", "ShelfTenanttenantId", "commission", "commissionDeduction", "fine", "totalPayout", "totalSale" },
                values: new object[,]
                {
                    { 1, 1, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { 2, 1, 0.0, 0.0, 350.0, 0.0, 0.0 },
                    { 3, 1, 150.0, 150.0, 0.0, 850.0, 1000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_ShelfTenanttenantId",
                table: "Barcodes",
                column: "ShelfTenanttenantId");

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeSale_SalessaleId",
                table: "BarcodeSale",
                column: "SalessaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Payouts_ShelfTenanttenantId",
                table: "Payouts",
                column: "ShelfTenanttenantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarcodeSale");

            migrationBuilder.DropTable(
                name: "Payouts");

            migrationBuilder.DropTable(
                name: "Barcodes");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Shelftenants");
        }
    }
}
