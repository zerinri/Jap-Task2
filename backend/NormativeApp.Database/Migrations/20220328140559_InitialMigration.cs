using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeApp.Database.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseUnitMeasure = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MostUsedIngredients",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsageCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitMeasure = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 28, 16, 5, 58, 644, DateTimeKind.Local).AddTicks(5668), "Breakfast" },
                    { 2, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(346), "Lunch" },
                    { 3, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(430), "Dinner" },
                    { 4, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(436), "Brunch" },
                    { 5, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(440), "Snack" },
                    { 6, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(443), "Midnight snack" },
                    { 7, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(445), "Healty snack" },
                    { 8, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(448), "Dessert" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "PurchasePrice", "PurchaseQuantity", "PurchaseUnitMeasure" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9260), "Peppers", 15m, 5m, 0 },
                    { 8, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9257), "Tomato", 10m, 5m, 0 },
                    { 7, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9254), "Meat", 20m, 1m, 0 },
                    { 6, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9251), "Salt", 2m, 70m, 1 },
                    { 2, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9237), "Pepper", 4m, 10m, 1 },
                    { 4, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9244), "Cheese", 15m, 100m, 1 },
                    { 3, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9241), "Oil", 7m, 1m, 2 },
                    { 10, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9264), "Mushrooms", 25m, 20m, 1 },
                    { 1, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9217), "Flour", 10m, 1m, 0 },
                    { 5, new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9248), "Sugar", 3m, 80m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 79, 196, 250, 12, 17, 65, 15, 241, 97, 98, 227, 21, 60, 18, 181, 187, 103, 122, 176, 168, 68, 254, 134, 70, 75, 33, 90, 68, 36, 84, 157, 201, 92, 138, 159, 137, 119, 252, 33, 128, 127, 109, 41, 32, 100, 209, 56, 123, 15, 97, 246, 70, 21, 254, 79, 152, 63, 251, 145, 32, 2, 117, 202, 174 }, new byte[] { 234, 176, 183, 95, 244, 180, 149, 105, 76, 215, 21, 203, 119, 208, 216, 225, 52, 118, 80, 18, 114, 105, 152, 214, 173, 181, 191, 254, 150, 80, 169, 146, 175, 33, 139, 128, 125, 240, 161, 207, 122, 230, 24, 159, 189, 142, 132, 50, 95, 225, 117, 193, 1, 132, 252, 23, 117, 150, 239, 52, 241, 224, 104, 229, 68, 94, 51, 248, 100, 39, 156, 108, 128, 125, 190, 47, 108, 208, 211, 145, 169, 125, 156, 65, 143, 97, 242, 144, 145, 190, 29, 211, 173, 253, 18, 130, 15, 65, 32, 147, 81, 62, 5, 28, 236, 127, 138, 185, 39, 61, 217, 207, 44, 85, 163, 59, 20, 118, 187, 183, 102, 216, 137, 219, 177, 91, 153, 238 }, "admin" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "TotalCost" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6234), "Lorem Ipsum", "Spagete5", 52.5716083876656m },
                    { 23, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6363), "Lorem Ipsum", "Musaka23", 63.4297208615717m },
                    { 25, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6370), "Lorem Ipsum", "Palacinke25", 52.4892538960507m },
                    { 26, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6374), "Lorem Ipsum", "Spagete26", 48.3360591280908m },
                    { 30, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6389), "Lorem Ipsum", "Musaka30", 12.2844952634929m },
                    { 34, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6405), "Lorem Ipsum", "Makarone34", 19.5506105667682m },
                    { 35, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6409), "Lorem Ipsum", "Pizza35", 32.8770424601981m },
                    { 36, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6413), "Lorem Ipsum", "Pita36", 37.6619503720021m },
                    { 37, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6417), "Lorem Ipsum", "Musaka37", 80.3286665009002m },
                    { 38, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6421), "Lorem Ipsum", "Ustipci38", 49.7662763426855m },
                    { 47, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6455), "Lorem Ipsum", "Spagete47", 42.9682192690522m },
                    { 2, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6198), "Lorem Ipsum", "Musaka2", 91.200741720945m },
                    { 3, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6224), "Lorem Ipsum", "Ustipci3", 30.5755097510179m },
                    { 6, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6241), "Lorem Ipsum", "Makarone6", 98.0697407308359m },
                    { 7, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6246), "Lorem Ipsum", "Pizza7", 25.3216929679372m },
                    { 16, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6283), "Lorem Ipsum", "Musaka16", 18.1545376862188m },
                    { 24, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6366), "Lorem Ipsum", "Ustipci24", 73.0487269456725m },
                    { 31, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6392), "Lorem Ipsum", "Ustipci31", 35.0167902400795m },
                    { 39, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6424), "Lorem Ipsum", "Palacinke39", 43.7003279881088m },
                    { 40, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6428), "Lorem Ipsum", "Spagete40", 59.7268830289724m },
                    { 44, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6444), "Lorem Ipsum", "Musaka44", 28.0159716503769m },
                    { 46, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6451), "Lorem Ipsum", "Palacinke46", 58.1942726048614m },
                    { 22, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6359), "Lorem Ipsum", "Pita22", 7.74897919350722m },
                    { 21, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6355), "Lorem Ipsum", "Pizza21", 22.2787300805928m },
                    { 20, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6351), "Lorem Ipsum", "Makarone20", 92.2933071135978m },
                    { 12, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6268), "Lorem Ipsum", "Spagete12", 10.7738651818474m },
                    { 9, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6254), "Lorem Ipsum", "Musaka9", 62.4630500192116m },
                    { 13, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6271), "Lorem Ipsum", "Makarone13", 94.350085365749m },
                    { 15, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6279), "Lorem Ipsum", "Pita15", 25.3733078671495m },
                    { 17, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6286), "Lorem Ipsum", "Ustipci17", 60.749792028102m },
                    { 18, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6292), "Lorem Ipsum", "Palacinke18", 19.0944419680603m },
                    { 27, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6378), "Lorem Ipsum", "Makarone27", 16.4391635323126m },
                    { 29, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6385), "Lorem Ipsum", "Pita29", 34.4729272399437m },
                    { 32, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6396), "Lorem Ipsum", "Palacinke32", 60.5416160102662m },
                    { 42, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6436), "Lorem Ipsum", "Pizza42", 4.37947945826663m },
                    { 43, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6440), "Lorem Ipsum", "Pita43", 66.9263020702294m },
                    { 48, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6459), "Lorem Ipsum", "Makarone48", 7.31254577139045m },
                    { 45, 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6447), "Lorem Ipsum", "Ustipci45", 58.9688080353517m },
                    { 4, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6229), "Lorem Ipsum", "Palacinke4", 41.432707834259m },
                    { 11, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6264), "Lorem Ipsum", "Palacinke11", 66.7702853119794m },
                    { 14, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6275), "Lorem Ipsum", "Pizza14", 75.6603142678087m },
                    { 19, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6345), "Lorem Ipsum", "Spagete19", 81.0078674210272m }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "TotalCost" },
                values: new object[,]
                {
                    { 28, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6381), "Lorem Ipsum", "Pizza28", 51.415549982067m },
                    { 33, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6400), "Lorem Ipsum", "Spagete33", 47.1820451329379m },
                    { 41, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6432), "Lorem Ipsum", "Makarone41", 98.5142777341019m },
                    { 50, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6466), "Lorem Ipsum", "Pita50", 21.1669956669989m },
                    { 8, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6250), "Lorem Ipsum", "Pita8", 58.5737217122566m },
                    { 10, 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6259), "Lorem Ipsum", "Ustipci10", 3.86633877449964m },
                    { 1, 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(4637), "Lorem Ipsum", "Pita1", 59.2634190145244m },
                    { 49, 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6462), "Lorem Ipsum", "Pizza49", 10.8601302503888m }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 25, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8092), 2, 33.66m, 5, 0 },
                    { 181, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8813), 3, 30.99m, 34, 1 },
                    { 105, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8477), 9, 28.05m, 35, 3 },
                    { 182, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8817), 9, 32.55m, 35, 1 },
                    { 188, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8841), 6, 30.32m, 35, 0 },
                    { 52, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8201), 4, 48.7m, 36, 3 },
                    { 114, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8513), 7, 7.46m, 36, 3 },
                    { 153, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8669), 8, 19.71m, 36, 1 },
                    { 94, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8433), 6, 21.93m, 37, 0 },
                    { 118, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8529), 1, 47.54m, 37, 1 },
                    { 193, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8860), 7, 46.85m, 37, 1 },
                    { 3, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7945), 4, 33.18m, 38, 3 },
                    { 46, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8177), 6, 16.95m, 38, 1 },
                    { 59, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8229), 8, 15.39m, 38, 0 },
                    { 79, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8309), 6, 11.82m, 38, 1 },
                    { 151, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8661), 8, 44.78m, 38, 0 },
                    { 166, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8754), 7, 35.65m, 38, 2 },
                    { 197, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8876), 2, 16.7m, 38, 0 },
                    { 23, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8084), 4, 46.02m, 47, 2 },
                    { 110, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8497), 2, 30.53m, 47, 1 },
                    { 136, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8601), 4, 14.29m, 47, 1 },
                    { 137, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8605), 6, 41.85m, 47, 3 },
                    { 155, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8676), 3, 27.13m, 34, 1 },
                    { 187, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8837), 3, 19.53m, 47, 0 },
                    { 126, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8560), 6, 18.61m, 34, 0 },
                    { 30, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8112), 5, 35.23m, 34, 2 },
                    { 17, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8059), 1, 30.12m, 22, 3 },
                    { 53, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8205), 7, 20.7m, 22, 3 },
                    { 80, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8313), 6, 9.86m, 22, 0 },
                    { 149, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8653), 4, 22.48m, 22, 1 },
                    { 150, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8657), 9, 18.15m, 22, 0 },
                    { 54, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8209), 6, 22.24m, 23, 0 },
                    { 111, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8501), 8, 29.8m, 23, 2 },
                    { 86, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8401), 1, 48.23m, 25, 1 },
                    { 29, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8108), 8, 43.32m, 26, 1 },
                    { 60, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8233), 7, 18.93m, 26, 2 },
                    { 77, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8301), 7, 3.33m, 26, 0 },
                    { 93, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8429), 3, 38.47m, 26, 2 },
                    { 109, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8493), 2, 27.45m, 26, 0 },
                    { 116, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8521), 4, 6.57m, 26, 3 },
                    { 144, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8633), 6, 48.34m, 26, 2 },
                    { 82, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8385), 2, 49.56m, 30, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 87, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8405), 2, 1.88m, 30, 2 },
                    { 96, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8441), 3, 17.72m, 30, 0 },
                    { 101, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8461), 8, 38.87m, 30, 2 },
                    { 168, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8762), 8, 6.8m, 30, 0 },
                    { 21, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8076), 1, 40.48m, 34, 3 },
                    { 92, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8425), 8, 7.76m, 34, 2 },
                    { 196, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8872), 6, 41.04m, 21, 0 },
                    { 24, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8088), 7, 17.34m, 2, 3 },
                    { 119, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8533), 8, 47.71m, 2, 2 },
                    { 107, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8485), 7, 37.27m, 31, 3 },
                    { 125, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8557), 7, 30.26m, 31, 3 },
                    { 134, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8593), 7, 17.18m, 31, 1 },
                    { 139, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8613), 5, 46.14m, 31, 3 },
                    { 184, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8825), 1, 39.98m, 31, 0 },
                    { 5, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8005), 9, 7.97m, 39, 2 },
                    { 124, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8553), 4, 12.81m, 39, 1 },
                    { 165, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8750), 3, 4.96m, 39, 2 },
                    { 173, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8782), 6, 6.99m, 39, 1 },
                    { 15, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8051), 5, 3.04m, 40, 2 },
                    { 98, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8449), 1, 31.86m, 40, 3 },
                    { 146, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8641), 9, 1.86m, 40, 2 },
                    { 200, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8888), 2, 44.26m, 40, 1 },
                    { 71, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8278), 9, 20.1m, 44, 0 },
                    { 83, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8389), 6, 15.5m, 44, 2 },
                    { 159, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8726), 9, 24.84m, 44, 0 },
                    { 169, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8766), 5, 25.88m, 44, 3 },
                    { 172, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8777), 2, 38.21m, 44, 3 },
                    { 39, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8149), 1, 46.77m, 46, 2 },
                    { 100, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8457), 9, 30.58m, 46, 0 },
                    { 120, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8537), 3, 40.65m, 46, 3 },
                    { 84, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8393), 8, 42.09m, 31, 0 },
                    { 70, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8273), 2, 3.76m, 2, 1 },
                    { 31, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8116), 2, 41.19m, 31, 3 },
                    { 8, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8022), 5, 1.85m, 31, 2 },
                    { 154, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8673), 3, 33.63m, 2, 0 },
                    { 195, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8868), 4, 23.67m, 2, 3 },
                    { 13, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8043), 3, 23.32m, 3, 3 },
                    { 81, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8381), 3, 3.38m, 3, 3 },
                    { 22, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8080), 4, 48.59m, 6, 3 },
                    { 161, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8734), 3, 36.73m, 6, 2 },
                    { 43, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8165), 1, 29.56m, 7, 2 },
                    { 117, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8525), 6, 8.72m, 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 141, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8621), 4, 41.41m, 7, 0 },
                    { 143, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8629), 2, 30.58m, 7, 3 },
                    { 183, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8821), 1, 30.06m, 7, 3 },
                    { 6, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8013), 5, 22.81m, 16, 2 },
                    { 10, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8030), 8, 25.85m, 16, 2 },
                    { 106, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8481), 2, 34.9m, 16, 0 },
                    { 175, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8790), 8, 5.34m, 16, 3 },
                    { 176, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8794), 7, 10.15m, 16, 1 },
                    { 32, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8120), 4, 7.18m, 24, 0 },
                    { 55, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8213), 1, 11.69m, 24, 3 },
                    { 131, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8582), 9, 49.59m, 24, 1 },
                    { 132, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8585), 5, 44.65m, 24, 3 },
                    { 185, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8829), 4, 8.94m, 24, 2 },
                    { 11, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8034), 4, 1.29m, 31, 2 },
                    { 140, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8617), 8, 12.4m, 21, 0 },
                    { 99, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8453), 6, 46.83m, 21, 0 },
                    { 27, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8100), 3, 1.19m, 21, 2 },
                    { 2, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7939), 7, 13.92m, 27, 1 },
                    { 102, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8465), 3, 42.09m, 27, 0 },
                    { 162, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8738), 3, 37.59m, 27, 2 },
                    { 9, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8026), 9, 24.97m, 29, 3 },
                    { 148, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8649), 8, 21.44m, 29, 1 },
                    { 160, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8730), 9, 36.38m, 29, 1 },
                    { 171, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8773), 1, 48.52m, 29, 0 },
                    { 199, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8884), 9, 16.56m, 29, 2 },
                    { 112, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8504), 3, 36.93m, 32, 0 },
                    { 142, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8625), 8, 13.44m, 32, 1 },
                    { 156, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8680), 4, 10.77m, 32, 1 },
                    { 167, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8758), 7, 40.65m, 32, 3 },
                    { 18, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8064), 8, 23.15m, 42, 1 },
                    { 50, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8193), 5, 19.2m, 42, 0 },
                    { 122, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8545), 8, 22.53m, 42, 1 },
                    { 130, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8578), 7, 1.52m, 42, 3 },
                    { 16, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8055), 5, 8.12m, 43, 0 },
                    { 157, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8718), 6, 42.49m, 43, 3 },
                    { 163, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8742), 5, 8.9m, 43, 2 },
                    { 14, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8047), 6, 40.7m, 45, 0 },
                    { 37, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8142), 1, 49.98m, 45, 3 },
                    { 135, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8597), 8, 7.75m, 18, 1 },
                    { 95, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8437), 2, 26.23m, 45, 0 },
                    { 113, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8508), 6, 47.72m, 18, 3 },
                    { 67, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8262), 2, 36.8m, 18, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 75, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8294), 3, 39.41m, 5, 2 },
                    { 128, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8568), 4, 29.09m, 5, 1 },
                    { 147, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8645), 2, 43.94m, 5, 3 },
                    { 45, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8173), 6, 19.31m, 9, 0 },
                    { 72, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8282), 5, 26.12m, 9, 1 },
                    { 90, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8417), 3, 35.23m, 9, 2 },
                    { 133, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8589), 5, 41.19m, 9, 3 },
                    { 76, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8298), 3, 44.22m, 13, 2 },
                    { 20, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8072), 5, 9.15m, 15, 3 },
                    { 38, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8146), 5, 40.35m, 15, 1 },
                    { 41, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8158), 7, 15m, 15, 2 },
                    { 51, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8197), 8, 14.79m, 15, 0 },
                    { 69, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8269), 8, 36.69m, 15, 0 },
                    { 127, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8564), 6, 23.81m, 15, 3 },
                    { 138, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8609), 6, 43.67m, 15, 0 },
                    { 192, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8856), 2, 32.28m, 15, 3 },
                    { 33, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8125), 1, 24.19m, 17, 0 },
                    { 85, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8397), 4, 25.92m, 17, 2 },
                    { 108, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8489), 6, 43.03m, 17, 3 },
                    { 198, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8880), 7, 3.4m, 17, 1 },
                    { 28, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8104), 2, 6.25m, 18, 3 },
                    { 78, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8305), 7, 31.36m, 18, 1 },
                    { 129, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8572), 7, 21.32m, 45, 3 },
                    { 194, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8864), 6, 4.61m, 45, 0 },
                    { 145, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8637), 8, 34.91m, 1, 0 },
                    { 89, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8413), 7, 4.17m, 8, 1 },
                    { 104, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8473), 5, 5.03m, 8, 3 },
                    { 164, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8746), 1, 44.75m, 8, 3 },
                    { 61, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8237), 1, 7.78m, 10, 3 },
                    { 62, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8241), 6, 29.91m, 10, 1 },
                    { 64, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8249), 6, 35.96m, 10, 3 },
                    { 174, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8786), 7, 25.98m, 10, 1 },
                    { 7, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8017), 8, 37.85m, 12, 0 },
                    { 49, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8189), 2, 4.72m, 12, 3 },
                    { 68, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8265), 1, 17.92m, 12, 2 },
                    { 121, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8541), 1, 8.57m, 12, 2 },
                    { 123, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8549), 2, 8.94m, 12, 1 },
                    { 158, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8722), 3, 5.59m, 12, 2 },
                    { 186, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8833), 9, 12.71m, 12, 2 },
                    { 191, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8853), 6, 26.32m, 12, 1 },
                    { 26, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8096), 7, 12.49m, 20, 0 },
                    { 40, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8154), 4, 34.91m, 20, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 103, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8469), 5, 20.31m, 20, 0 },
                    { 179, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8805), 1, 45.87m, 20, 2 },
                    { 190, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8849), 5, 42.92m, 20, 1 },
                    { 12, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8039), 6, 3.29m, 21, 1 },
                    { 48, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8185), 8, 49.3m, 8, 2 },
                    { 47, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8181), 6, 21.13m, 41, 0 },
                    { 35, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8133), 6, 5.47m, 41, 0 },
                    { 91, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8421), 8, 5.4m, 33, 1 },
                    { 19, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8068), 4, 36.82m, 4, 2 },
                    { 42, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8161), 1, 18.75m, 4, 2 },
                    { 56, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8217), 5, 33.32m, 4, 0 },
                    { 65, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8252), 1, 28.62m, 4, 2 },
                    { 74, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8290), 9, 43m, 4, 0 },
                    { 36, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8137), 4, 17.57m, 11, 2 },
                    { 63, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8245), 7, 33.25m, 11, 2 },
                    { 88, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8409), 7, 34.33m, 11, 3 },
                    { 97, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8445), 4, 37.68m, 11, 0 },
                    { 4, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7950), 5, 45.63m, 14, 0 },
                    { 58, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8225), 4, 32.88m, 48, 2 },
                    { 44, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8169), 1, 25.41m, 14, 1 },
                    { 152, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8665), 7, 45.94m, 14, 2 },
                    { 180, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8809), 4, 25.82m, 14, 2 },
                    { 1, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7890), 7, 1.89m, 19, 0 },
                    { 73, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8286), 8, 9.55m, 19, 3 },
                    { 170, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8770), 7, 29.11m, 19, 0 },
                    { 115, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8517), 6, 3.14m, 28, 0 },
                    { 178, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8801), 7, 15.33m, 28, 1 },
                    { 189, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8845), 1, 37.33m, 28, 3 },
                    { 34, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8129), 4, 36.43m, 33, 1 },
                    { 66, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8258), 8, 41.41m, 33, 0 },
                    { 57, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8221), 3, 6.69m, 14, 2 },
                    { 177, new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8797), 2, 29.33m, 49, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MostUsedIngredients");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
