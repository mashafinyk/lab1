using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BouquetMVC.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    material = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    startdate = table.Column<DateTime>(name: "start date", type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(name: "end date", type: "datetime2", nullable: false),
                    discountpercent = table.Column<int>(name: "discount percent", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    phonenumber = table.Column<string>(name: "phone number", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    openingtime = table.Column<string>(name: "opening time", type: "nvarchar(max)", nullable: false),
                    closingtime = table.Column<string>(name: "closing time", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfFlower",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    height = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfFlower", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phonenumber = table.Column<string>(name: "phone number", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bouquet",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    promotionid = table.Column<int>(name: "promotion id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bouquet", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bouquet_Promotion",
                        column: x => x.promotionid,
                        principalTable: "Promotion",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    shopid = table.Column<int>(name: "shop id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.id);
                    table.ForeignKey(
                        name: "FK_Delivery_Shop",
                        column: x => x.shopid,
                        principalTable: "Shop",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActiveCart",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    creationdate = table.Column<DateTime>(name: "creation date", type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    userid = table.Column<int>(name: "user id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveCart", x => x.id);
                    table.ForeignKey(
                        name: "FK_ActiveCart_User",
                        column: x => x.userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    userid = table.Column<int>(name: "user id", type: "int", nullable: false),
                    shopid = table.Column<int>(name: "shop id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orders_Shop",
                        column: x => x.shopid,
                        principalTable: "Shop",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Orders_User",
                        column: x => x.userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    buildingnumber = table.Column<string>(name: "building number", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    userid = table.Column<int>(name: "user id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserAddress_User",
                        column: x => x.userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BouquetAndFlower",
                columns: table => new
                {
                    flowerid = table.Column<int>(name: "flower id", type: "int", nullable: false),
                    bouquetid = table.Column<int>(name: "bouquet id", type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BouquetAndFlower", x => new { x.bouquetid, x.flowerid });
                    table.ForeignKey(
                        name: "FK_BouquetAndFlower_Bouquet",
                        column: x => x.bouquetid,
                        principalTable: "Bouquet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BouquetAndFlower_Flower",
                        column: x => x.flowerid,
                        principalTable: "TypeOfFlower",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderBouquet",
                columns: table => new
                {
                    orderid = table.Column<int>(name: "order id", type: "int", nullable: false),
                    bouquetid = table.Column<int>(name: "bouquet id", type: "int", nullable: false),
                    packageid = table.Column<int>(name: "package id", type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBouquet", x => new { x.orderid, x.bouquetid, x.packageid });
                    table.ForeignKey(
                        name: "FK_OrderBouquet_Bouquet",
                        column: x => x.bouquetid,
                        principalTable: "Bouquet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderBouquet_Orders",
                        column: x => x.orderid,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderBouquet_Package",
                        column: x => x.packageid,
                        principalTable: "Package",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    amount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    orderid = table.Column<int>(name: "order id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payment_Orders",
                        column: x => x.orderid,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rating = table.Column<int>(type: "int", nullable: true),
                    comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    orderid = table.Column<int>(name: "order id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.id);
                    table.ForeignKey(
                        name: "FK_Response_Orders",
                        column: x => x.orderid,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveCart_user id",
                table: "ActiveCart",
                column: "user id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bouquet_promotion id",
                table: "Bouquet",
                column: "promotion id");

            migrationBuilder.CreateIndex(
                name: "IX_BouquetAndFlower_flower id",
                table: "BouquetAndFlower",
                column: "flower id");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_shop id",
                table: "Delivery",
                column: "shop id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBouquet_bouquet id",
                table: "OrderBouquet",
                column: "bouquet id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBouquet_package id",
                table: "OrderBouquet",
                column: "package id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_shop id",
                table: "Orders",
                column: "shop id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_user id",
                table: "Orders",
                column: "user id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_order id",
                table: "Payment",
                column: "order id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Response_order id",
                table: "Response",
                column: "order id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_email",
                table: "User",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_login",
                table: "User",
                column: "login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_user id",
                table: "UserAddress",
                column: "user id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveCart");

            migrationBuilder.DropTable(
                name: "BouquetAndFlower");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "OrderBouquet");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "TypeOfFlower");

            migrationBuilder.DropTable(
                name: "Bouquet");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
