using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeApp.Database.Migrations
{
    public partial class Initial : Migration
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
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
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" },
                    { 4, "Brunch" },
                    { 5, "Snack" },
                    { 6, "Midnight snack" },
                    { 7, "Healty snack" },
                    { 8, "Dessert" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "PurchasePrice", "PurchaseQuantity", "PurchaseUnitMeasure" },
                values: new object[,]
                {
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peppers", 15m, 5m, 0 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato", 10m, 5m, 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", 20m, 1m, 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salt", 2m, 70m, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepper", 4m, 10m, 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheese", 15m, 100m, 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oil", 7m, 1m, 2 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mushrooms", 25m, 20m, 1 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flour", 10m, 1m, 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sugar", 3m, 80m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 164, 201, 217, 188, 136, 240, 202, 196, 240, 83, 104, 201, 83, 29, 56, 117, 227, 29, 199, 119, 24, 32, 103, 26, 254, 204, 226, 203, 100, 181, 165, 199, 122, 42, 182, 60, 233, 66, 6, 148, 22, 166, 161, 81, 123, 72, 50, 214, 153, 201, 211, 19, 135, 69, 254, 53, 98, 83, 156, 175, 93, 140, 71, 79 }, new byte[] { 47, 91, 248, 247, 16, 73, 61, 32, 161, 221, 29, 14, 164, 37, 225, 101, 28, 106, 187, 153, 203, 204, 153, 132, 227, 173, 139, 98, 11, 31, 156, 194, 63, 140, 97, 10, 213, 203, 20, 106, 101, 16, 203, 233, 118, 242, 217, 237, 92, 155, 155, 37, 74, 122, 64, 128, 68, 106, 239, 139, 87, 190, 91, 96, 200, 37, 243, 114, 95, 240, 207, 67, 222, 56, 254, 71, 17, 171, 252, 13, 212, 8, 28, 138, 214, 143, 98, 213, 209, 101, 242, 54, 125, 231, 192, 87, 64, 255, 99, 135, 104, 64, 181, 38, 31, 109, 79, 166, 69, 181, 143, 93, 93, 32, 55, 196, 233, 182, 241, 121, 211, 77, 90, 233, 43, 38, 153, 4 }, "admin" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Lorem Ipsum", "Pita1" },
                    { 21, 5, "Lorem Ipsum", "Pizza21" },
                    { 35, 5, "Lorem Ipsum", "Pizza35" },
                    { 47, 5, "Lorem Ipsum", "Spagete47" },
                    { 6, 6, "Lorem Ipsum", "Makarone6" },
                    { 7, 6, "Lorem Ipsum", "Pizza7" },
                    { 10, 6, "Lorem Ipsum", "Ustipci10" },
                    { 12, 6, "Lorem Ipsum", "Spagete12" },
                    { 14, 6, "Lorem Ipsum", "Pizza14" },
                    { 25, 6, "Lorem Ipsum", "Palacinke25" },
                    { 34, 6, "Lorem Ipsum", "Makarone34" },
                    { 36, 6, "Lorem Ipsum", "Pita36" },
                    { 40, 6, "Lorem Ipsum", "Spagete40" },
                    { 49, 6, "Lorem Ipsum", "Pizza49" },
                    { 3, 7, "Lorem Ipsum", "Ustipci3" },
                    { 13, 7, "Lorem Ipsum", "Makarone13" },
                    { 15, 7, "Lorem Ipsum", "Pita15" },
                    { 20, 7, "Lorem Ipsum", "Makarone20" },
                    { 22, 7, "Lorem Ipsum", "Pita22" },
                    { 24, 7, "Lorem Ipsum", "Ustipci24" },
                    { 37, 7, "Lorem Ipsum", "Musaka37" },
                    { 43, 7, "Lorem Ipsum", "Pita43" },
                    { 18, 5, "Lorem Ipsum", "Palacinke18" },
                    { 17, 5, "Lorem Ipsum", "Ustipci17" },
                    { 9, 5, "Lorem Ipsum", "Musaka9" },
                    { 4, 5, "Lorem Ipsum", "Palacinke4" },
                    { 5, 1, "Lorem Ipsum", "Spagete5" },
                    { 16, 1, "Lorem Ipsum", "Musaka16" },
                    { 19, 1, "Lorem Ipsum", "Spagete19" },
                    { 32, 1, "Lorem Ipsum", "Palacinke32" },
                    { 46, 1, "Lorem Ipsum", "Palacinke46" },
                    { 48, 1, "Lorem Ipsum", "Makarone48" },
                    { 11, 2, "Lorem Ipsum", "Palacinke11" },
                    { 27, 2, "Lorem Ipsum", "Makarone27" },
                    { 38, 2, "Lorem Ipsum", "Ustipci38" },
                    { 39, 2, "Lorem Ipsum", "Palacinke39" },
                    { 44, 7, "Lorem Ipsum", "Musaka44" },
                    { 45, 2, "Lorem Ipsum", "Ustipci45" },
                    { 29, 3, "Lorem Ipsum", "Pita29" },
                    { 30, 3, "Lorem Ipsum", "Musaka30" },
                    { 8, 4, "Lorem Ipsum", "Pita8" },
                    { 23, 4, "Lorem Ipsum", "Musaka23" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 26, 4, "Lorem Ipsum", "Spagete26" },
                    { 28, 4, "Lorem Ipsum", "Pizza28" },
                    { 31, 4, "Lorem Ipsum", "Ustipci31" },
                    { 33, 4, "Lorem Ipsum", "Spagete33" },
                    { 41, 4, "Lorem Ipsum", "Makarone41" },
                    { 42, 4, "Lorem Ipsum", "Pizza42" },
                    { 2, 3, "Lorem Ipsum", "Musaka2" },
                    { 50, 7, "Lorem Ipsum", "Pita50" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 115, 1, 77m, 1, 1 },
                    { 152, 7, 88m, 14, 2 },
                    { 148, 3, 13m, 14, 1 },
                    { 131, 9, 32m, 14, 0 },
                    { 117, 3, 91m, 14, 0 },
                    { 9, 4, 56m, 14, 1 },
                    { 441, 6, 73m, 12, 2 },
                    { 420, 5, 88m, 12, 1 },
                    { 415, 2, 21m, 12, 2 },
                    { 350, 8, 48m, 12, 2 },
                    { 341, 5, 88m, 12, 3 },
                    { 334, 3, 46m, 12, 2 },
                    { 288, 7, 12m, 12, 0 },
                    { 216, 2, 15m, 12, 0 },
                    { 170, 3, 52m, 12, 1 },
                    { 150, 4, 70m, 12, 3 },
                    { 140, 2, 55m, 12, 1 },
                    { 41, 7, 28m, 12, 3 },
                    { 38, 2, 94m, 12, 2 },
                    { 24, 2, 82m, 12, 0 },
                    { 19, 5, 31m, 12, 3 },
                    { 490, 2, 23m, 10, 3 },
                    { 438, 2, 18m, 10, 2 },
                    { 360, 7, 94m, 10, 0 },
                    { 330, 4, 59m, 10, 1 },
                    { 236, 7, 66m, 10, 2 },
                    { 189, 7, 94m, 10, 3 },
                    { 167, 7, 69m, 10, 2 },
                    { 176, 5, 71m, 14, 3 },
                    { 440, 3, 18m, 7, 0 },
                    { 180, 9, 27m, 14, 2 },
                    { 392, 7, 27m, 14, 0 },
                    { 442, 8, 48m, 36, 3 },
                    { 378, 1, 60m, 36, 2 },
                    { 352, 5, 61m, 36, 2 },
                    { 270, 3, 36m, 36, 1 },
                    { 172, 5, 70m, 36, 0 },
                    { 146, 4, 56m, 36, 1 },
                    { 144, 8, 81m, 36, 2 },
                    { 68, 4, 58m, 36, 3 },
                    { 36, 3, 54m, 36, 2 },
                    { 33, 8, 17m, 36, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 359, 6, 17m, 34, 2 },
                    { 345, 1, 42m, 34, 0 },
                    { 302, 3, 83m, 34, 0 },
                    { 107, 6, 28m, 34, 2 },
                    { 73, 2, 40m, 34, 2 },
                    { 67, 1, 47m, 34, 0 },
                    { 58, 7, 95m, 34, 1 },
                    { 15, 8, 45m, 34, 2 },
                    { 8, 1, 58m, 34, 2 },
                    { 475, 9, 67m, 25, 0 },
                    { 389, 6, 61m, 25, 3 },
                    { 304, 2, 51m, 25, 3 },
                    { 246, 1, 43m, 25, 1 },
                    { 198, 8, 73m, 25, 0 },
                    { 30, 3, 66m, 25, 0 },
                    { 428, 9, 30m, 14, 3 },
                    { 421, 8, 64m, 14, 1 },
                    { 339, 2, 77m, 14, 3 },
                    { 329, 1, 70m, 7, 0 },
                    { 244, 5, 49m, 7, 2 },
                    { 166, 6, 15m, 7, 3 },
                    { 27, 8, 81m, 35, 3 },
                    { 13, 7, 67m, 35, 1 },
                    { 499, 7, 25m, 21, 1 },
                    { 497, 3, 31m, 21, 3 },
                    { 437, 6, 56m, 21, 2 },
                    { 372, 1, 11m, 21, 0 },
                    { 356, 4, 42m, 21, 1 },
                    { 328, 2, 23m, 21, 2 },
                    { 326, 2, 24m, 21, 1 },
                    { 297, 9, 77m, 21, 3 },
                    { 286, 3, 30m, 21, 3 },
                    { 248, 5, 67m, 21, 2 },
                    { 100, 7, 33m, 21, 0 },
                    { 76, 6, 26m, 21, 1 },
                    { 71, 5, 55m, 21, 3 },
                    { 22, 5, 31m, 21, 0 },
                    { 468, 6, 18m, 18, 0 },
                    { 462, 4, 50m, 18, 2 },
                    { 449, 2, 90m, 18, 1 },
                    { 439, 1, 64m, 18, 2 },
                    { 434, 3, 11m, 18, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 400, 8, 14m, 18, 3 },
                    { 391, 8, 31m, 18, 2 },
                    { 379, 6, 55m, 18, 3 },
                    { 373, 2, 68m, 18, 3 },
                    { 370, 3, 88m, 18, 2 },
                    { 368, 6, 54m, 18, 2 },
                    { 45, 1, 60m, 35, 2 },
                    { 188, 7, 22m, 35, 1 },
                    { 202, 2, 98m, 35, 2 },
                    { 214, 5, 27m, 35, 0 },
                    { 435, 5, 58m, 6, 1 },
                    { 223, 5, 43m, 6, 0 },
                    { 203, 3, 42m, 6, 0 },
                    { 179, 2, 42m, 6, 2 },
                    { 177, 1, 51m, 6, 1 },
                    { 128, 9, 71m, 6, 2 },
                    { 49, 1, 41m, 6, 3 },
                    { 20, 4, 50m, 6, 1 },
                    { 494, 4, 65m, 47, 1 },
                    { 484, 1, 22m, 47, 3 },
                    { 431, 3, 82m, 47, 0 },
                    { 399, 7, 58m, 47, 0 },
                    { 382, 5, 25m, 47, 3 },
                    { 25, 9, 93m, 40, 3 },
                    { 307, 2, 22m, 47, 1 },
                    { 252, 6, 24m, 47, 2 },
                    { 224, 1, 57m, 47, 2 },
                    { 197, 7, 67m, 47, 1 },
                    { 163, 5, 34m, 47, 3 },
                    { 134, 6, 85m, 47, 0 },
                    { 492, 1, 75m, 35, 1 },
                    { 482, 5, 65m, 35, 0 },
                    { 457, 9, 61m, 35, 3 },
                    { 448, 3, 28m, 35, 3 },
                    { 416, 9, 72m, 35, 0 },
                    { 403, 8, 92m, 35, 0 },
                    { 238, 3, 34m, 35, 0 },
                    { 221, 9, 83m, 35, 0 },
                    { 255, 7, 74m, 47, 1 },
                    { 355, 2, 95m, 18, 1 },
                    { 93, 4, 30m, 40, 2 },
                    { 129, 4, 40m, 40, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 338, 5, 44m, 24, 1 },
                    { 294, 3, 38m, 24, 2 },
                    { 232, 7, 89m, 24, 1 },
                    { 212, 4, 98m, 24, 3 },
                    { 169, 8, 57m, 24, 3 },
                    { 74, 1, 47m, 24, 1 },
                    { 14, 1, 86m, 24, 1 },
                    { 393, 6, 47m, 22, 2 },
                    { 384, 9, 26m, 22, 3 },
                    { 374, 4, 34m, 22, 2 },
                    { 331, 5, 59m, 22, 1 },
                    { 300, 5, 64m, 22, 3 },
                    { 173, 2, 35m, 22, 3 },
                    { 139, 7, 39m, 22, 2 },
                    { 119, 1, 40m, 22, 0 },
                    { 109, 5, 78m, 22, 0 },
                    { 64, 3, 11m, 22, 0 },
                    { 35, 9, 31m, 22, 2 },
                    { 430, 6, 54m, 20, 1 },
                    { 419, 8, 23m, 20, 0 },
                    { 361, 2, 13m, 20, 1 },
                    { 183, 1, 80m, 20, 3 },
                    { 63, 7, 14m, 20, 0 },
                    { 29, 3, 94m, 20, 2 },
                    { 480, 5, 68m, 15, 2 },
                    { 479, 3, 13m, 15, 2 },
                    { 429, 1, 32m, 15, 3 },
                    { 411, 9, 21m, 24, 2 },
                    { 425, 8, 18m, 15, 2 },
                    { 452, 2, 66m, 24, 3 },
                    { 485, 6, 64m, 24, 0 },
                    { 281, 2, 13m, 44, 3 },
                    { 156, 5, 95m, 44, 0 },
                    { 112, 4, 83m, 44, 1 },
                    { 61, 6, 15m, 44, 1 },
                    { 42, 7, 85m, 44, 3 },
                    { 474, 6, 85m, 43, 1 },
                    { 461, 1, 61m, 43, 2 },
                    { 396, 4, 15m, 43, 3 },
                    { 394, 2, 90m, 43, 2 },
                    { 364, 4, 36m, 43, 3 },
                    { 247, 5, 26m, 43, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 225, 6, 99m, 43, 0 },
                    { 209, 3, 97m, 43, 0 },
                    { 191, 1, 85m, 43, 0 },
                    { 106, 2, 88m, 43, 1 },
                    { 70, 1, 36m, 43, 1 },
                    { 53, 6, 27m, 43, 3 },
                    { 47, 5, 90m, 43, 3 },
                    { 6, 1, 29m, 43, 1 },
                    { 498, 2, 81m, 37, 0 },
                    { 271, 3, 85m, 37, 1 },
                    { 228, 5, 70m, 37, 1 },
                    { 207, 7, 95m, 37, 3 },
                    { 185, 3, 95m, 37, 2 },
                    { 121, 9, 41m, 37, 1 },
                    { 87, 4, 61m, 37, 3 },
                    { 32, 5, 61m, 37, 1 },
                    { 471, 8, 49m, 24, 3 },
                    { 414, 4, 43m, 15, 0 },
                    { 367, 4, 88m, 15, 3 },
                    { 305, 5, 35m, 15, 1 },
                    { 186, 4, 76m, 3, 0 },
                    { 145, 2, 21m, 3, 0 },
                    { 133, 6, 54m, 3, 1 },
                    { 116, 7, 47m, 3, 0 },
                    { 103, 2, 83m, 3, 0 },
                    { 90, 6, 97m, 3, 0 },
                    { 60, 2, 68m, 3, 0 },
                    { 410, 7, 97m, 49, 3 },
                    { 249, 1, 18m, 49, 3 },
                    { 241, 3, 70m, 49, 2 },
                    { 235, 6, 48m, 49, 1 },
                    { 215, 2, 56m, 49, 1 },
                    { 94, 2, 29m, 49, 0 },
                    { 91, 5, 57m, 49, 2 },
                    { 86, 9, 27m, 49, 3 },
                    { 57, 3, 46m, 49, 3 },
                    { 54, 2, 72m, 49, 2 },
                    { 44, 1, 70m, 49, 1 },
                    { 456, 1, 34m, 40, 3 },
                    { 445, 3, 98m, 40, 0 },
                    { 405, 4, 62m, 40, 2 },
                    { 327, 7, 26m, 40, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 319, 2, 10m, 40, 2 },
                    { 313, 9, 28m, 40, 3 },
                    { 310, 8, 68m, 40, 1 },
                    { 237, 4, 29m, 40, 3 },
                    { 220, 9, 99m, 40, 0 },
                    { 194, 5, 67m, 3, 2 },
                    { 218, 8, 19m, 3, 3 },
                    { 227, 8, 45m, 3, 3 },
                    { 239, 4, 19m, 3, 3 },
                    { 192, 3, 11m, 15, 2 },
                    { 141, 1, 42m, 15, 2 },
                    { 138, 9, 44m, 15, 2 },
                    { 113, 7, 98m, 15, 0 },
                    { 96, 4, 18m, 15, 0 },
                    { 85, 5, 72m, 15, 0 },
                    { 39, 5, 69m, 15, 3 },
                    { 465, 7, 62m, 13, 2 },
                    { 369, 5, 69m, 13, 0 },
                    { 362, 4, 16m, 13, 1 },
                    { 314, 4, 81m, 13, 3 },
                    { 284, 3, 91m, 13, 1 },
                    { 280, 1, 73m, 13, 2 },
                    { 122, 6, 11m, 40, 3 },
                    { 273, 8, 63m, 13, 2 },
                    { 256, 4, 31m, 13, 0 },
                    { 233, 2, 85m, 13, 1 },
                    { 165, 6, 28m, 13, 2 },
                    { 110, 6, 74m, 13, 1 },
                    { 83, 3, 26m, 13, 3 },
                    { 469, 6, 43m, 3, 3 },
                    { 432, 2, 44m, 3, 3 },
                    { 418, 5, 99m, 3, 1 },
                    { 353, 4, 30m, 3, 2 },
                    { 347, 9, 75m, 3, 1 },
                    { 274, 7, 43m, 3, 0 },
                    { 262, 8, 94m, 3, 0 },
                    { 250, 1, 98m, 3, 0 },
                    { 259, 4, 80m, 13, 3 },
                    { 258, 6, 61m, 18, 0 },
                    { 231, 1, 89m, 18, 2 },
                    { 137, 7, 47m, 18, 0 },
                    { 433, 7, 26m, 38, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 422, 4, 84m, 38, 3 },
                    { 346, 5, 25m, 38, 2 },
                    { 268, 9, 74m, 38, 2 },
                    { 28, 9, 92m, 38, 0 },
                    { 21, 2, 64m, 38, 3 },
                    { 427, 6, 64m, 27, 0 },
                    { 390, 5, 19m, 27, 3 },
                    { 160, 3, 82m, 27, 2 },
                    { 118, 6, 43m, 27, 3 },
                    { 23, 5, 41m, 27, 0 },
                    { 11, 9, 96m, 27, 3 },
                    { 4, 2, 21m, 27, 0 },
                    { 409, 7, 19m, 11, 2 },
                    { 366, 8, 61m, 11, 0 },
                    { 333, 4, 22m, 11, 1 },
                    { 332, 8, 54m, 11, 2 },
                    { 318, 7, 20m, 11, 0 },
                    { 276, 6, 69m, 11, 0 },
                    { 263, 3, 93m, 11, 0 },
                    { 217, 1, 49m, 11, 1 },
                    { 190, 5, 38m, 11, 2 },
                    { 147, 9, 70m, 11, 1 },
                    { 95, 7, 81m, 11, 2 },
                    { 80, 7, 56m, 11, 1 },
                    { 77, 3, 54m, 11, 3 },
                    { 51, 2, 63m, 11, 2 },
                    { 453, 1, 94m, 38, 3 },
                    { 481, 2, 38m, 48, 1 },
                    { 483, 3, 35m, 38, 2 },
                    { 40, 5, 89m, 39, 1 },
                    { 426, 9, 76m, 2, 1 },
                    { 395, 3, 62m, 2, 3 },
                    { 358, 6, 20m, 2, 3 },
                    { 336, 1, 82m, 2, 0 },
                    { 175, 4, 48m, 2, 1 },
                    { 164, 2, 90m, 2, 0 },
                    { 161, 1, 38m, 2, 2 },
                    { 157, 5, 59m, 2, 0 },
                    { 154, 1, 54m, 2, 3 },
                    { 120, 3, 28m, 2, 0 },
                    { 82, 8, 36m, 2, 3 },
                    { 75, 9, 53m, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 66, 7, 63m, 2, 1 },
                    { 2, 2, 46m, 2, 3 },
                    { 296, 6, 65m, 45, 0 },
                    { 267, 9, 62m, 45, 0 },
                    { 266, 1, 30m, 45, 0 },
                    { 184, 4, 82m, 45, 3 },
                    { 151, 2, 88m, 45, 1 },
                    { 124, 6, 12m, 45, 2 },
                    { 101, 8, 20m, 45, 0 },
                    { 17, 6, 50m, 45, 1 },
                    { 436, 4, 54m, 39, 0 },
                    { 301, 2, 85m, 39, 3 },
                    { 211, 9, 14m, 39, 1 },
                    { 108, 8, 94m, 39, 2 },
                    { 48, 2, 62m, 39, 3 },
                    { 16, 1, 25m, 39, 1 },
                    { 472, 5, 14m, 48, 1 },
                    { 324, 2, 95m, 48, 2 },
                    { 303, 5, 15m, 48, 0 },
                    { 489, 1, 41m, 16, 3 },
                    { 460, 5, 18m, 16, 0 },
                    { 386, 6, 60m, 16, 0 },
                    { 351, 3, 40m, 16, 0 },
                    { 317, 6, 74m, 16, 1 },
                    { 279, 1, 57m, 16, 2 },
                    { 264, 8, 20m, 16, 3 },
                    { 205, 2, 58m, 16, 2 },
                    { 204, 1, 28m, 16, 2 },
                    { 193, 5, 97m, 16, 3 },
                    { 81, 4, 62m, 16, 2 },
                    { 43, 6, 29m, 16, 2 },
                    { 397, 6, 37m, 5, 3 },
                    { 357, 2, 39m, 5, 3 },
                    { 240, 4, 70m, 5, 0 },
                    { 219, 7, 78m, 5, 2 },
                    { 187, 4, 86m, 5, 3 },
                    { 181, 3, 32m, 5, 1 },
                    { 123, 1, 48m, 5, 1 },
                    { 79, 5, 27m, 5, 2 },
                    { 50, 5, 73m, 5, 3 },
                    { 3, 5, 35m, 5, 2 },
                    { 1, 9, 88m, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 486, 8, 88m, 1, 2 },
                    { 342, 2, 54m, 1, 3 },
                    { 213, 2, 72m, 1, 0 },
                    { 199, 2, 85m, 1, 1 },
                    { 89, 3, 62m, 19, 1 },
                    { 127, 2, 85m, 19, 0 },
                    { 171, 4, 38m, 19, 1 },
                    { 261, 6, 72m, 19, 3 },
                    { 295, 3, 31m, 48, 3 },
                    { 234, 5, 42m, 48, 2 },
                    { 226, 9, 95m, 48, 1 },
                    { 125, 9, 39m, 48, 2 },
                    { 69, 6, 54m, 48, 1 },
                    { 65, 4, 71m, 48, 2 },
                    { 455, 2, 12m, 46, 1 },
                    { 404, 2, 16m, 46, 3 },
                    { 257, 7, 72m, 46, 1 },
                    { 253, 5, 48m, 46, 3 },
                    { 222, 6, 68m, 46, 0 },
                    { 153, 6, 53m, 46, 1 },
                    { 62, 8, 91m, 46, 3 },
                    { 37, 1, 18m, 29, 3 },
                    { 55, 6, 18m, 46, 0 },
                    { 487, 2, 38m, 32, 2 },
                    { 450, 8, 78m, 32, 2 },
                    { 424, 5, 14m, 32, 0 },
                    { 309, 4, 98m, 32, 2 },
                    { 289, 3, 25m, 32, 1 },
                    { 272, 2, 20m, 32, 0 },
                    { 242, 4, 12m, 32, 2 },
                    { 206, 8, 26m, 32, 0 },
                    { 72, 5, 74m, 32, 1 },
                    { 477, 7, 50m, 19, 1 },
                    { 423, 6, 44m, 19, 3 },
                    { 398, 3, 45m, 19, 1 },
                    { 275, 4, 12m, 19, 1 },
                    { 52, 4, 64m, 46, 0 },
                    { 195, 9, 21m, 29, 0 },
                    { 291, 9, 81m, 29, 2 },
                    { 299, 3, 85m, 29, 2 },
                    { 298, 8, 53m, 4, 3 },
                    { 283, 5, 35m, 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 174, 1, 45m, 4, 0 },
                    { 26, 4, 71m, 4, 2 },
                    { 464, 5, 79m, 42, 1 },
                    { 388, 3, 95m, 42, 1 },
                    { 337, 8, 19m, 42, 3 },
                    { 104, 3, 13m, 42, 2 },
                    { 88, 8, 97m, 42, 0 },
                    { 401, 3, 43m, 41, 0 },
                    { 321, 7, 47m, 41, 2 },
                    { 320, 5, 50m, 41, 3 },
                    { 312, 2, 41m, 41, 0 },
                    { 243, 6, 35m, 41, 2 },
                    { 162, 9, 23m, 41, 1 },
                    { 136, 6, 88m, 41, 1 },
                    { 98, 7, 75m, 41, 2 },
                    { 78, 8, 48m, 41, 3 },
                    { 56, 9, 24m, 41, 1 },
                    { 446, 8, 75m, 33, 2 },
                    { 380, 5, 15m, 33, 1 },
                    { 363, 9, 22m, 33, 1 },
                    { 340, 9, 86m, 33, 3 },
                    { 287, 6, 32m, 33, 3 },
                    { 254, 6, 87m, 33, 3 },
                    { 208, 6, 15m, 33, 0 },
                    { 182, 4, 24m, 33, 0 },
                    { 306, 8, 10m, 4, 0 },
                    { 371, 3, 20m, 4, 1 },
                    { 443, 9, 75m, 4, 3 },
                    { 444, 4, 34m, 4, 2 },
                    { 130, 4, 52m, 18, 2 },
                    { 500, 9, 93m, 17, 2 },
                    { 495, 7, 56m, 17, 2 },
                    { 454, 6, 74m, 17, 0 },
                    { 412, 2, 19m, 17, 3 },
                    { 381, 6, 63m, 17, 1 },
                    { 282, 2, 68m, 17, 3 },
                    { 265, 6, 27m, 17, 0 },
                    { 251, 6, 95m, 17, 1 },
                    { 230, 6, 58m, 17, 2 },
                    { 201, 2, 67m, 17, 0 },
                    { 135, 6, 69m, 17, 2 },
                    { 97, 8, 64m, 17, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 102, 3, 42m, 33, 1 },
                    { 59, 7, 52m, 17, 0 },
                    { 10, 6, 89m, 17, 2 },
                    { 496, 1, 97m, 9, 2 },
                    { 476, 5, 42m, 9, 3 },
                    { 451, 5, 55m, 9, 0 },
                    { 383, 1, 75m, 9, 3 },
                    { 316, 6, 89m, 9, 1 },
                    { 315, 6, 85m, 9, 2 },
                    { 311, 4, 98m, 9, 2 },
                    { 292, 8, 79m, 9, 1 },
                    { 229, 2, 37m, 9, 0 },
                    { 132, 2, 89m, 9, 3 },
                    { 491, 9, 52m, 4, 3 },
                    { 467, 1, 31m, 4, 3 },
                    { 31, 2, 65m, 17, 1 },
                    { 365, 2, 38m, 44, 2 },
                    { 473, 2, 88m, 31, 2 },
                    { 269, 4, 75m, 31, 2 },
                    { 105, 2, 25m, 23, 3 },
                    { 46, 6, 83m, 23, 2 },
                    { 34, 5, 99m, 23, 0 },
                    { 5, 2, 21m, 23, 3 },
                    { 493, 1, 32m, 8, 2 },
                    { 478, 9, 60m, 8, 2 },
                    { 407, 4, 67m, 8, 1 },
                    { 293, 4, 13m, 8, 2 },
                    { 278, 5, 27m, 8, 1 },
                    { 260, 3, 14m, 8, 0 },
                    { 149, 4, 39m, 8, 3 },
                    { 413, 5, 69m, 30, 3 },
                    { 387, 1, 67m, 30, 3 },
                    { 344, 7, 16m, 30, 0 },
                    { 343, 1, 82m, 30, 3 },
                    { 335, 4, 76m, 30, 3 },
                    { 322, 2, 26m, 30, 1 },
                    { 290, 7, 96m, 30, 0 },
                    { 285, 5, 65m, 30, 0 },
                    { 200, 3, 13m, 30, 3 },
                    { 178, 1, 20m, 30, 3 },
                    { 143, 1, 73m, 30, 2 },
                    { 7, 3, 49m, 30, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 466, 7, 57m, 29, 2 },
                    { 447, 5, 12m, 29, 0 },
                    { 354, 5, 23m, 29, 2 },
                    { 323, 1, 58m, 29, 1 },
                    { 111, 4, 26m, 23, 2 },
                    { 126, 5, 69m, 23, 2 },
                    { 142, 6, 80m, 23, 1 },
                    { 159, 4, 61m, 23, 2 },
                    { 92, 5, 50m, 31, 2 },
                    { 18, 1, 13m, 31, 3 },
                    { 459, 4, 35m, 28, 1 },
                    { 385, 1, 65m, 28, 3 },
                    { 375, 5, 83m, 28, 3 },
                    { 210, 5, 12m, 28, 3 },
                    { 12, 5, 59m, 28, 0 },
                    { 488, 1, 84m, 26, 3 },
                    { 470, 6, 48m, 26, 0 },
                    { 376, 2, 73m, 26, 1 },
                    { 349, 8, 67m, 26, 0 },
                    { 348, 5, 95m, 26, 2 },
                    { 325, 8, 30m, 26, 1 },
                    { 408, 4, 44m, 31, 1 },
                    { 277, 3, 78m, 26, 3 },
                    { 158, 9, 50m, 26, 2 },
                    { 155, 3, 38m, 26, 2 },
                    { 114, 5, 48m, 26, 2 },
                    { 99, 4, 43m, 26, 0 },
                    { 84, 4, 75m, 26, 3 },
                    { 463, 5, 27m, 23, 0 },
                    { 458, 2, 95m, 23, 3 },
                    { 417, 8, 17m, 23, 1 },
                    { 406, 4, 10m, 23, 1 },
                    { 377, 5, 78m, 23, 0 },
                    { 308, 8, 28m, 23, 0 },
                    { 245, 3, 76m, 23, 1 },
                    { 168, 9, 40m, 23, 1 },
                    { 196, 2, 75m, 26, 2 },
                    { 402, 4, 27m, 44, 0 }
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

            var s1 = @"CREATE PROCEDURE [dbo].[dbo_spCategory_GetRecipeByCategory]
            AS
            BEGIN SELECT Categories.Name as CategoryName,Recipes.Name as RecipeName,
            SUM(dbo.CalculateTotalCosts(RecipeIngredients.Quantity, Ingredients.PurchasePrice, Ingredients.PurchaseQuantity,Ingredients.PurchaseUnitMeasure, RecipeIngredients.UnitMeasure)) 
            AS TotalCost
            FROM Ingredients
            JOIN RecipeIngredients
            ON Ingredients.Id = RecipeIngredients.IngredientId
            join Recipes
            on Recipes.Id = RecipeIngredients.RecipeId
            join Categories
            on Categories.Id = Recipes.CategoryId
            GROUP BY Categories.Name,Recipes.Name
            ORDER by Categories.Name, TotalCost desc;
            END";

            var s2 = @"Create procedure [dbo].[dbo_spRecipeIngredient_GetRecipeWithIngredientCount]
            AS
            BEGIN
            SELECT count(RecipeIngredients.IngredientId) as TotalIngredients,Recipes.Name,RecipeId,
            SUM(dbo.CalculateTotalCosts(RecipeIngredients.Quantity, Ingredients.PurchasePrice, Ingredients.PurchaseQuantity,Ingredients.PurchaseUnitMeasure,RecipeIngredients.UnitMeasure)) 
            AS TotalCost
            FROM Ingredients
            JOIN RecipeIngredients
            ON Ingredients.Id = RecipeIngredients.IngredientId
            join Recipes
            on Recipes.Id = RecipeIngredients.RecipeId
            join Categories
            on Categories.Id = Recipes.CategoryId
            GROUP BY RecipeId, Recipes.Name
            ORDER by TotalCost desc;
            END";

            var s3 = @"Create PROCEDURE [dbo].[dbo_spRecipeIngredients_FilterIngredients](
            @minCount AS DECIMAL
            ,@maxCount AS DECIMAL
	        ,@unitMeasure AS INT)
            AS
            BEGIN
            SELECT Count(IngredientId) as UsageCount,Ingredients.Name FROM RecipeIngredients
            Inner Join Ingredients
            ON  IngredientId = Ingredients.id 
            GROUP BY Name,UnitMeasure
            Having Count(IngredientId) >= @minCount AND
	        Count(IngredientId) <= @maxCount AND
            UnitMeasure LIKE @unitMeasure  
            ORDER BY UsageCount DESC
            END";

            var s4 = @"CREATE FUNCTION [dbo].[CalculateTotalCosts]
            (
              @recipesIngredientQuantity decimal
            , @ingredientPurchasedPrice decimal
            , @ingredientPurchasedQuantity decimal
            , @ingredientUnit int
            , @recipesIngredientUnit int
            )
            RETURNS float
            AS
            BEGIN
            DECLARE @TotalCost float;
            SELECT @TotalCost = CASE

            WHEN @ingredientUnit = 1 and @recipesIngredientUnit = 1 or @ingredientUnit = 3 and @recipesIngredientUnit = 3 or @ingredientUnit = 1 and @recipesIngredientUnit = 3
            THEN
            (@recipesIngredientQuantity / 1000) * (@ingredientPurchasedPrice / (@ingredientPurchasedQuantity / 1000)) 

            WHEN @recipesIngredientUnit = 1 OR @recipesIngredientUnit = 3 
            THEN
            (@recipesIngredientQuantity / 1000) * (@ingredientPurchasedPrice / (@ingredientPurchasedQuantity)) 

            WHEN @ingredientUnit = 1 OR @ingredientUnit = 3 
            THEN
            (@recipesIngredientQuantity ) * (@ingredientPurchasedPrice / (@ingredientPurchasedQuantity / 1000)) 

            ELSE
            @recipesIngredientQuantity * (@ingredientPurchasedPrice / @ingredientPurchasedQuantity)
            END 
            RETURN @TotalCost
            END";

            migrationBuilder.Sql(s1);
            migrationBuilder.Sql(s2);
            migrationBuilder.Sql(s3);
            migrationBuilder.Sql(s4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
