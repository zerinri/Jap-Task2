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
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                values: new object[] { 1, new byte[] { 130, 230, 110, 223, 78, 5, 81, 29, 236, 154, 163, 194, 76, 30, 162, 175, 122, 126, 139, 222, 182, 206, 38, 238, 225, 150, 234, 12, 14, 162, 59, 9, 138, 115, 139, 139, 168, 207, 187, 117, 178, 217, 8, 88, 123, 223, 110, 170, 252, 82, 131, 148, 76, 187, 77, 83, 131, 205, 20, 165, 148, 220, 23, 23 }, new byte[] { 83, 148, 42, 10, 208, 218, 214, 125, 182, 166, 70, 197, 255, 225, 135, 227, 32, 6, 85, 182, 124, 137, 230, 26, 175, 85, 244, 185, 138, 145, 242, 196, 67, 82, 155, 235, 196, 97, 39, 39, 55, 76, 35, 131, 37, 151, 57, 14, 196, 43, 211, 173, 44, 80, 184, 78, 42, 252, 147, 90, 118, 113, 87, 73, 173, 215, 254, 68, 80, 255, 229, 236, 57, 13, 247, 87, 28, 97, 177, 251, 65, 137, 3, 53, 62, 171, 86, 143, 206, 242, 241, 207, 228, 157, 147, 199, 150, 132, 41, 161, 129, 6, 247, 123, 136, 183, 180, 34, 107, 225, 86, 225, 1, 118, 140, 15, 149, 161, 38, 32, 112, 236, 210, 168, 225, 147, 44, 169 }, "admin" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "TotalCost" },
                values: new object[,]
                {
                    { 10, 1, "Lorem Ipsum", "Ustipci10", 71.6665302932572m },
                    { 49, 4, "Lorem Ipsum", "Pizza49", 56.5364353603387m },
                    { 2, 5, "Lorem Ipsum", "Musaka2", 47.3568257071808m },
                    { 5, 5, "Lorem Ipsum", "Spagete5", 15.7656881929215m },
                    { 8, 5, "Lorem Ipsum", "Pita8", 98.7749801607686m },
                    { 18, 5, "Lorem Ipsum", "Palacinke18", 78.6573787073872m },
                    { 33, 5, "Lorem Ipsum", "Spagete33", 51.7221134331646m },
                    { 42, 5, "Lorem Ipsum", "Pizza42", 7.58055034865651m },
                    { 13, 6, "Lorem Ipsum", "Makarone13", 21.6121651351509m },
                    { 14, 6, "Lorem Ipsum", "Pizza14", 18.3817661024545m },
                    { 31, 6, "Lorem Ipsum", "Ustipci31", 94.0662834532868m },
                    { 40, 6, "Lorem Ipsum", "Spagete40", 14.0362582751719m },
                    { 43, 6, "Lorem Ipsum", "Pita43", 61.2379986914983m },
                    { 48, 6, "Lorem Ipsum", "Makarone48", 31.8081724498459m },
                    { 1, 7, "Lorem Ipsum", "Pita1", 6.64578542050244m },
                    { 3, 7, "Lorem Ipsum", "Ustipci3", 40.2214907972242m },
                    { 12, 7, "Lorem Ipsum", "Spagete12", 36.8851583883563m },
                    { 17, 7, "Lorem Ipsum", "Ustipci17", 85.2455402110915m },
                    { 20, 7, "Lorem Ipsum", "Makarone20", 15.3192273566123m },
                    { 24, 7, "Lorem Ipsum", "Ustipci24", 53.8398340157419m },
                    { 25, 7, "Lorem Ipsum", "Palacinke25", 70.7057249386356m },
                    { 26, 7, "Lorem Ipsum", "Spagete26", 64.8193160909318m },
                    { 47, 4, "Lorem Ipsum", "Spagete47", 2.6080111854747m },
                    { 39, 4, "Lorem Ipsum", "Palacinke39", 97.634757450146m },
                    { 27, 4, "Lorem Ipsum", "Makarone27", 19.8556055458522m },
                    { 22, 4, "Lorem Ipsum", "Pita22", 44.0966255558173m },
                    { 11, 1, "Lorem Ipsum", "Palacinke11", 69.919637619946m },
                    { 15, 1, "Lorem Ipsum", "Pita15", 16.3156293320077m },
                    { 45, 1, "Lorem Ipsum", "Ustipci45", 24.328000234127m },
                    { 50, 1, "Lorem Ipsum", "Pita50", 83.481853784752m },
                    { 16, 2, "Lorem Ipsum", "Musaka16", 30.7129034915533m },
                    { 30, 2, "Lorem Ipsum", "Musaka30", 34.096263727218m },
                    { 34, 2, "Lorem Ipsum", "Makarone34", 85.5946054093514m },
                    { 38, 2, "Lorem Ipsum", "Ustipci38", 41.961828815733m },
                    { 41, 2, "Lorem Ipsum", "Makarone41", 16.3613898830309m },
                    { 46, 2, "Lorem Ipsum", "Palacinke46", 41.2028383050127m },
                    { 35, 7, "Lorem Ipsum", "Pizza35", 3.32411325132666m },
                    { 6, 3, "Lorem Ipsum", "Makarone6", 5.51331974450188m },
                    { 23, 3, "Lorem Ipsum", "Musaka23", 70.7898888912936m },
                    { 28, 3, "Lorem Ipsum", "Pizza28", 23.8613103962789m },
                    { 29, 3, "Lorem Ipsum", "Pita29", 40.9142497190806m },
                    { 32, 3, "Lorem Ipsum", "Palacinke32", 46.3083552519364m }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "TotalCost" },
                values: new object[,]
                {
                    { 36, 3, "Lorem Ipsum", "Pita36", 79.0832716529646m },
                    { 44, 3, "Lorem Ipsum", "Musaka44", 30.1307553086107m },
                    { 4, 4, "Lorem Ipsum", "Palacinke4", 79.3339044346166m },
                    { 7, 4, "Lorem Ipsum", "Pizza7", 87.3800784979854m },
                    { 9, 4, "Lorem Ipsum", "Musaka9", 16.0458055618432m },
                    { 19, 4, "Lorem Ipsum", "Spagete19", 26.0717335604465m },
                    { 21, 3, "Lorem Ipsum", "Pizza21", 86.6838741789962m },
                    { 37, 7, "Lorem Ipsum", "Musaka37", 53.6170164736067m }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 42, 9, 30.82m, 10, 2 },
                    { 212, 2, 32.22m, 14, 1 },
                    { 139, 6, 40.81m, 14, 3 },
                    { 129, 6, 36.46m, 14, 1 },
                    { 78, 5, 49.06m, 14, 0 },
                    { 451, 5, 38.8m, 13, 1 },
                    { 450, 4, 15.55m, 13, 0 },
                    { 402, 3, 34.24m, 13, 3 },
                    { 297, 2, 11.67m, 13, 2 },
                    { 138, 1, 3.04m, 13, 0 },
                    { 262, 7, 35.67m, 42, 3 },
                    { 215, 5, 40.94m, 42, 3 },
                    { 86, 2, 24.16m, 42, 3 },
                    { 43, 6, 16.55m, 42, 2 },
                    { 1, 8, 36.9m, 42, 0 },
                    { 497, 2, 46.92m, 33, 3 },
                    { 366, 2, 15.44m, 33, 0 },
                    { 159, 3, 10.99m, 33, 0 },
                    { 154, 1, 10.98m, 33, 2 },
                    { 485, 8, 33.2m, 18, 2 },
                    { 468, 7, 48.49m, 18, 1 },
                    { 418, 6, 17.83m, 18, 1 },
                    { 331, 7, 48.77m, 18, 1 },
                    { 191, 3, 49.78m, 18, 2 },
                    { 180, 4, 44.9m, 18, 0 },
                    { 142, 4, 16.02m, 18, 0 },
                    { 17, 6, 33.76m, 18, 3 },
                    { 474, 2, 23.96m, 8, 3 },
                    { 357, 7, 18.81m, 14, 3 },
                    { 305, 9, 12.61m, 8, 2 },
                    { 375, 5, 42.32m, 14, 3 },
                    { 457, 3, 35.46m, 14, 1 },
                    { 386, 9, 22.77m, 43, 1 },
                    { 311, 7, 25.31m, 43, 3 },
                    { 254, 1, 28.76m, 43, 3 },
                    { 247, 7, 35.37m, 43, 2 },
                    { 239, 1, 24.62m, 43, 0 },
                    { 221, 5, 3.49m, 43, 3 },
                    { 205, 9, 33.56m, 43, 2 },
                    { 181, 8, 21.91m, 43, 0 },
                    { 436, 2, 23.54m, 40, 3 },
                    { 384, 1, 41.07m, 40, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 296, 7, 27.33m, 40, 0 },
                    { 245, 4, 43.86m, 40, 1 },
                    { 237, 9, 29.79m, 40, 2 },
                    { 194, 3, 13.06m, 40, 3 },
                    { 155, 8, 20.49m, 40, 3 },
                    { 473, 6, 47.49m, 31, 1 },
                    { 429, 3, 20.56m, 31, 1 },
                    { 372, 6, 31.35m, 31, 3 },
                    { 278, 1, 7.51m, 31, 2 },
                    { 238, 7, 13.83m, 31, 1 },
                    { 223, 6, 3.64m, 31, 1 },
                    { 150, 5, 49.89m, 31, 1 },
                    { 144, 8, 21.57m, 31, 3 },
                    { 120, 6, 28.26m, 31, 2 },
                    { 111, 7, 31.27m, 31, 0 },
                    { 96, 5, 46.43m, 31, 1 },
                    { 26, 1, 29.66m, 31, 0 },
                    { 420, 6, 34.08m, 14, 2 },
                    { 303, 5, 19.72m, 8, 1 },
                    { 258, 4, 24.57m, 8, 3 },
                    { 137, 5, 45.93m, 8, 0 },
                    { 19, 9, 10.11m, 49, 3 },
                    { 494, 4, 7.95m, 47, 1 },
                    { 398, 8, 38.48m, 47, 0 },
                    { 264, 1, 16.64m, 47, 1 },
                    { 178, 9, 38.92m, 47, 0 },
                    { 218, 1, 2.92m, 39, 3 },
                    { 217, 1, 4.1m, 39, 0 },
                    { 179, 6, 7.24m, 39, 3 },
                    { 130, 8, 1.29m, 39, 0 },
                    { 112, 4, 7.92m, 39, 2 },
                    { 66, 3, 13.7m, 39, 1 },
                    { 34, 6, 39.99m, 39, 2 },
                    { 3, 3, 5.11m, 39, 1 },
                    { 499, 2, 15.18m, 27, 3 },
                    { 449, 3, 4.23m, 27, 0 },
                    { 445, 8, 11.15m, 27, 1 },
                    { 380, 8, 3.59m, 27, 2 },
                    { 334, 4, 2.79m, 27, 2 },
                    { 234, 6, 34.93m, 27, 3 },
                    { 203, 1, 35.95m, 27, 0 },
                    { 184, 1, 3.9m, 27, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 23, 6, 41.21m, 27, 3 },
                    { 15, 2, 35.59m, 27, 1 },
                    { 11, 9, 48.31m, 27, 3 },
                    { 478, 8, 19.81m, 22, 3 },
                    { 453, 5, 38.76m, 22, 3 },
                    { 452, 7, 45.55m, 22, 0 },
                    { 81, 3, 14.26m, 49, 3 },
                    { 93, 7, 15.79m, 49, 1 },
                    { 126, 5, 10.36m, 49, 0 },
                    { 171, 3, 1.35m, 49, 1 },
                    { 117, 4, 2.91m, 8, 0 },
                    { 8, 8, 27.43m, 8, 0 },
                    { 425, 6, 2.61m, 5, 0 },
                    { 377, 7, 40.12m, 5, 0 },
                    { 374, 2, 10.16m, 5, 2 },
                    { 371, 9, 46.53m, 5, 0 },
                    { 293, 4, 21.71m, 5, 2 },
                    { 286, 8, 40.66m, 5, 1 },
                    { 133, 7, 17.01m, 5, 1 },
                    { 47, 5, 18.85m, 5, 3 },
                    { 479, 8, 13.75m, 2, 2 },
                    { 460, 5, 16.47m, 2, 1 },
                    { 442, 7, 33.13m, 2, 2 },
                    { 433, 3, 22.11m, 43, 1 },
                    { 390, 3, 4.63m, 2, 2 },
                    { 368, 1, 47.28m, 2, 1 },
                    { 363, 4, 47.64m, 2, 2 },
                    { 341, 8, 36.25m, 2, 3 },
                    { 300, 5, 29.48m, 2, 1 },
                    { 105, 3, 2.22m, 2, 2 },
                    { 75, 3, 48.44m, 2, 1 },
                    { 489, 5, 23.8m, 49, 0 },
                    { 367, 9, 11.76m, 49, 0 },
                    { 361, 3, 34.41m, 49, 2 },
                    { 323, 7, 38.46m, 49, 2 },
                    { 294, 5, 9.2m, 49, 1 },
                    { 248, 8, 25.85m, 49, 2 },
                    { 211, 2, 38.79m, 49, 3 },
                    { 381, 4, 18.93m, 2, 1 },
                    { 369, 7, 24.3m, 22, 2 },
                    { 476, 5, 24.09m, 43, 3 },
                    { 99, 9, 48.23m, 48, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 487, 5, 23.74m, 25, 3 },
                    { 448, 2, 33.03m, 25, 2 },
                    { 434, 1, 9.75m, 25, 0 },
                    { 412, 2, 41.7m, 25, 1 },
                    { 411, 7, 30.03m, 25, 1 },
                    { 327, 5, 19.73m, 25, 2 },
                    { 322, 6, 26.87m, 25, 2 },
                    { 302, 7, 48.76m, 25, 0 },
                    { 290, 8, 37.6m, 25, 3 },
                    { 283, 5, 17.73m, 25, 3 },
                    { 280, 9, 16.25m, 25, 3 },
                    { 222, 4, 40.89m, 25, 2 },
                    { 113, 8, 24.07m, 25, 3 },
                    { 88, 8, 6.14m, 25, 2 },
                    { 79, 2, 1.49m, 25, 0 },
                    { 63, 7, 25.93m, 25, 3 },
                    { 12, 2, 47.33m, 25, 0 },
                    { 5, 4, 33.76m, 25, 2 },
                    { 455, 4, 13.97m, 24, 1 },
                    { 193, 1, 25.89m, 24, 0 },
                    { 166, 6, 20.06m, 24, 0 },
                    { 125, 2, 25.84m, 24, 0 },
                    { 83, 4, 32.41m, 24, 1 },
                    { 67, 4, 41.72m, 24, 1 },
                    { 439, 9, 30.88m, 20, 1 },
                    { 437, 3, 15.14m, 20, 2 },
                    { 432, 6, 1.23m, 20, 2 },
                    { 488, 4, 17.22m, 25, 2 },
                    { 330, 8, 26.96m, 20, 0 },
                    { 14, 5, 38.96m, 26, 3 },
                    { 59, 5, 6.72m, 26, 0 },
                    { 383, 4, 10.54m, 37, 3 },
                    { 362, 2, 19.86m, 37, 2 },
                    { 340, 9, 12.31m, 37, 3 },
                    { 338, 5, 30.57m, 37, 2 },
                    { 309, 8, 43.5m, 37, 0 },
                    { 288, 7, 49.84m, 37, 3 },
                    { 274, 2, 7.13m, 37, 3 },
                    { 244, 2, 43.14m, 37, 2 },
                    { 214, 3, 45.9m, 37, 2 },
                    { 187, 9, 5.2m, 37, 3 },
                    { 183, 4, 23.85m, 37, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 141, 7, 31.91m, 37, 3 },
                    { 114, 3, 17.08m, 37, 3 },
                    { 77, 1, 19.9m, 37, 2 },
                    { 24, 1, 37.15m, 37, 0 },
                    { 414, 9, 42.86m, 35, 3 },
                    { 321, 4, 42m, 35, 0 },
                    { 284, 9, 27.62m, 35, 3 },
                    { 230, 5, 49.99m, 35, 0 },
                    { 57, 8, 5.1m, 35, 2 },
                    { 39, 3, 28.71m, 35, 0 },
                    { 419, 7, 27.62m, 26, 0 },
                    { 392, 5, 2.76m, 26, 1 },
                    { 373, 9, 47.42m, 26, 2 },
                    { 291, 4, 34.29m, 26, 1 },
                    { 251, 7, 14.22m, 26, 3 },
                    { 135, 5, 35.66m, 26, 0 },
                    { 37, 1, 22.47m, 26, 3 },
                    { 315, 4, 6.98m, 20, 0 },
                    { 189, 7, 41.89m, 20, 2 },
                    { 169, 9, 11.95m, 20, 0 },
                    { 256, 5, 7.35m, 3, 3 },
                    { 204, 3, 4.19m, 3, 3 },
                    { 165, 1, 47.9m, 3, 3 },
                    { 52, 7, 23.74m, 3, 2 },
                    { 50, 9, 1.02m, 3, 1 },
                    { 472, 3, 48.72m, 1, 2 },
                    { 428, 9, 41.6m, 1, 3 },
                    { 332, 4, 45.63m, 1, 2 },
                    { 281, 7, 10.97m, 1, 0 },
                    { 242, 4, 48.42m, 1, 1 },
                    { 101, 5, 18.63m, 1, 1 },
                    { 91, 3, 8.54m, 1, 0 },
                    { 89, 1, 19.79m, 1, 3 },
                    { 481, 6, 22.77m, 48, 2 },
                    { 447, 9, 47.96m, 48, 2 },
                    { 421, 6, 32.56m, 48, 1 },
                    { 389, 4, 46.63m, 48, 1 },
                    { 328, 1, 34.61m, 48, 1 },
                    { 314, 5, 10.31m, 48, 0 },
                    { 306, 2, 9.89m, 48, 0 },
                    { 304, 2, 38.09m, 48, 1 },
                    { 301, 7, 27.38m, 48, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 295, 1, 35.71m, 48, 2 },
                    { 282, 2, 5.84m, 48, 0 },
                    { 279, 2, 24.56m, 48, 2 },
                    { 261, 6, 17.02m, 48, 2 },
                    { 128, 6, 12.86m, 48, 3 },
                    { 259, 6, 22.24m, 3, 2 },
                    { 312, 5, 46.84m, 3, 1 },
                    { 348, 2, 14.94m, 3, 2 },
                    { 353, 8, 47.19m, 3, 3 },
                    { 119, 2, 30.64m, 20, 2 },
                    { 109, 1, 32.2m, 20, 0 },
                    { 28, 8, 33.93m, 20, 2 },
                    { 482, 5, 14.93m, 17, 1 },
                    { 441, 9, 4.63m, 17, 1 },
                    { 272, 6, 24.26m, 17, 0 },
                    { 246, 1, 29.09m, 17, 2 },
                    { 228, 9, 29.21m, 17, 3 },
                    { 219, 5, 31.23m, 17, 3 },
                    { 30, 1, 49.15m, 17, 1 },
                    { 13, 7, 25.15m, 17, 2 },
                    { 498, 1, 7.74m, 12, 2 },
                    { 466, 3, 31.85m, 12, 1 },
                    { 35, 4, 41.48m, 48, 0 },
                    { 456, 8, 49.76m, 12, 3 },
                    { 427, 6, 49.51m, 12, 3 },
                    { 370, 6, 26.49m, 12, 0 },
                    { 270, 8, 16.82m, 12, 2 },
                    { 266, 3, 38.93m, 12, 1 },
                    { 227, 1, 2.37m, 12, 2 },
                    { 167, 1, 6.05m, 12, 3 },
                    { 100, 7, 29.62m, 12, 0 },
                    { 25, 2, 12.3m, 12, 3 },
                    { 7, 3, 36.32m, 12, 1 },
                    { 461, 9, 28.73m, 3, 3 },
                    { 405, 8, 39.49m, 3, 3 },
                    { 378, 1, 35.34m, 3, 3 },
                    { 356, 3, 46.65m, 3, 0 },
                    { 431, 9, 34.79m, 12, 2 },
                    { 298, 8, 31.93m, 22, 2 },
                    { 269, 7, 40.82m, 22, 2 },
                    { 229, 3, 7.32m, 22, 1 },
                    { 174, 4, 12.45m, 41, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 163, 5, 14.32m, 41, 2 },
                    { 158, 6, 49.24m, 41, 1 },
                    { 108, 3, 27.14m, 41, 1 },
                    { 98, 6, 41.06m, 41, 1 },
                    { 70, 1, 9.89m, 41, 3 },
                    { 62, 1, 30.96m, 41, 1 },
                    { 404, 8, 39.78m, 38, 3 },
                    { 326, 4, 24.25m, 38, 1 },
                    { 276, 8, 8.14m, 38, 2 },
                    { 152, 7, 26.8m, 38, 1 },
                    { 151, 8, 8.64m, 38, 2 },
                    { 102, 4, 27.19m, 38, 3 },
                    { 61, 5, 14.53m, 38, 2 },
                    { 32, 7, 25.11m, 38, 1 },
                    { 467, 5, 26.68m, 34, 3 },
                    { 408, 6, 13.77m, 34, 2 },
                    { 396, 6, 11.2m, 34, 1 },
                    { 359, 5, 8.08m, 34, 2 },
                    { 350, 8, 20.14m, 34, 2 },
                    { 299, 9, 44.53m, 34, 3 },
                    { 240, 6, 21.96m, 34, 2 },
                    { 225, 3, 49.14m, 34, 0 },
                    { 106, 3, 32.07m, 34, 1 },
                    { 94, 1, 5.25m, 34, 2 },
                    { 46, 8, 6.13m, 34, 3 },
                    { 2, 3, 32.68m, 34, 3 },
                    { 185, 6, 16.14m, 41, 2 },
                    { 500, 1, 14.29m, 30, 0 },
                    { 287, 5, 45.17m, 41, 2 },
                    { 496, 3, 43.9m, 41, 2 },
                    { 277, 9, 47.24m, 21, 3 },
                    { 235, 6, 11.36m, 21, 0 },
                    { 224, 2, 21.26m, 21, 3 },
                    { 157, 7, 1.6m, 21, 1 },
                    { 71, 2, 45.84m, 21, 2 },
                    { 40, 2, 23.7m, 21, 0 },
                    { 407, 2, 19.99m, 6, 3 },
                    { 351, 6, 23.87m, 6, 2 },
                    { 319, 6, 49.62m, 6, 2 },
                    { 210, 4, 47.23m, 6, 2 },
                    { 176, 8, 49.64m, 6, 2 },
                    { 168, 7, 32.18m, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 124, 7, 28.59m, 6, 3 },
                    { 121, 2, 40.81m, 6, 1 },
                    { 115, 1, 41.92m, 6, 3 },
                    { 87, 8, 18.55m, 6, 1 },
                    { 69, 2, 6.54m, 6, 0 },
                    { 58, 8, 4.66m, 6, 3 },
                    { 403, 3, 42.62m, 46, 2 },
                    { 387, 8, 35.92m, 46, 3 },
                    { 292, 1, 36.1m, 46, 0 },
                    { 253, 8, 44.77m, 46, 1 },
                    { 209, 6, 13.11m, 46, 3 },
                    { 207, 8, 40.81m, 46, 1 },
                    { 164, 5, 45.94m, 46, 3 },
                    { 162, 4, 33.76m, 46, 0 },
                    { 116, 6, 41.84m, 46, 0 },
                    { 459, 3, 6.64m, 41, 1 },
                    { 354, 7, 30.71m, 30, 2 },
                    { 273, 9, 38.5m, 30, 2 },
                    { 161, 3, 1.37m, 30, 0 },
                    { 275, 4, 19.34m, 15, 2 },
                    { 271, 6, 22.46m, 15, 1 },
                    { 226, 8, 29.16m, 15, 1 },
                    { 216, 7, 28.6m, 15, 2 },
                    { 192, 5, 14.21m, 15, 2 },
                    { 97, 6, 9.33m, 15, 3 },
                    { 9, 1, 19.14m, 15, 2 },
                    { 443, 2, 24.32m, 11, 0 },
                    { 347, 6, 10.75m, 11, 3 },
                    { 320, 8, 30.36m, 11, 0 },
                    { 201, 8, 11.9m, 11, 1 },
                    { 170, 1, 43.39m, 11, 2 },
                    { 68, 5, 28.4m, 11, 3 },
                    { 51, 9, 33.29m, 11, 1 },
                    { 48, 9, 42.26m, 11, 2 },
                    { 490, 9, 20.13m, 10, 3 },
                    { 471, 3, 34.13m, 10, 3 },
                    { 465, 1, 30.6m, 10, 1 },
                    { 415, 6, 2.26m, 10, 1 },
                    { 399, 3, 6.93m, 10, 1 },
                    { 263, 8, 42.11m, 10, 0 },
                    { 249, 7, 42.74m, 10, 2 },
                    { 195, 9, 40.63m, 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 175, 8, 36.71m, 10, 0 },
                    { 123, 6, 15.6m, 10, 0 },
                    { 82, 3, 23.62m, 10, 0 },
                    { 60, 6, 9.17m, 10, 1 },
                    { 307, 2, 4.18m, 15, 0 },
                    { 316, 1, 36.18m, 15, 0 },
                    { 325, 7, 1.94m, 15, 0 },
                    { 344, 6, 16.77m, 15, 0 },
                    { 20, 6, 12.47m, 30, 1 },
                    { 495, 3, 44.94m, 16, 2 },
                    { 454, 2, 26.73m, 16, 3 },
                    { 438, 9, 11.96m, 16, 2 },
                    { 400, 6, 19.85m, 16, 1 },
                    { 364, 5, 7.38m, 16, 1 },
                    { 335, 2, 21.51m, 16, 2 },
                    { 200, 2, 47.62m, 16, 3 },
                    { 173, 1, 30.33m, 16, 1 },
                    { 127, 1, 28.21m, 16, 1 },
                    { 55, 4, 48.06m, 16, 0 },
                    { 44, 2, 12.8m, 16, 0 },
                    { 36, 9, 4.18m, 16, 2 },
                    { 289, 9, 15.08m, 21, 1 },
                    { 33, 6, 35.73m, 16, 0 },
                    { 18, 3, 21.53m, 16, 2 },
                    { 491, 3, 24.34m, 45, 1 },
                    { 422, 7, 17.93m, 45, 0 },
                    { 410, 5, 25.41m, 45, 0 },
                    { 394, 6, 14.76m, 45, 1 },
                    { 329, 2, 44.5m, 45, 0 },
                    { 255, 7, 1.57m, 45, 2 },
                    { 149, 7, 3.77m, 45, 3 },
                    { 132, 7, 47.42m, 45, 1 },
                    { 107, 9, 16.11m, 45, 1 },
                    { 21, 9, 40m, 45, 3 },
                    { 440, 8, 15.52m, 15, 2 },
                    { 352, 4, 30.11m, 15, 3 },
                    { 22, 3, 18.22m, 16, 0 },
                    { 324, 8, 2.63m, 21, 2 },
                    { 349, 1, 25.53m, 21, 0 },
                    { 430, 1, 40.12m, 21, 3 },
                    { 182, 5, 15.94m, 9, 1 },
                    { 134, 1, 4.39m, 9, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 118, 3, 3.82m, 9, 1 },
                    { 477, 8, 5.85m, 7, 3 },
                    { 470, 1, 20.52m, 7, 1 },
                    { 469, 3, 26.12m, 7, 2 },
                    { 464, 8, 15.64m, 7, 0 },
                    { 406, 1, 40.16m, 7, 0 },
                    { 346, 2, 25.51m, 7, 3 },
                    { 336, 8, 26.57m, 7, 3 },
                    { 333, 2, 13.65m, 7, 1 },
                    { 206, 9, 15.84m, 7, 0 },
                    { 196, 7, 21.57m, 7, 0 },
                    { 145, 9, 2.1m, 7, 1 },
                    { 92, 5, 43.14m, 7, 3 },
                    { 74, 8, 39.89m, 7, 2 },
                    { 45, 7, 31.55m, 7, 3 },
                    { 385, 5, 42.31m, 4, 1 },
                    { 345, 7, 23.13m, 4, 1 },
                    { 250, 2, 5.83m, 4, 2 },
                    { 241, 8, 3.09m, 4, 3 },
                    { 90, 5, 30.31m, 4, 3 },
                    { 56, 5, 1.95m, 4, 3 },
                    { 49, 1, 6.62m, 4, 2 },
                    { 38, 6, 46.17m, 4, 0 },
                    { 29, 9, 10.17m, 4, 1 },
                    { 6, 4, 27.14m, 4, 2 },
                    { 199, 1, 45.51m, 9, 3 },
                    { 257, 9, 38.57m, 9, 1 },
                    { 267, 5, 30.7m, 9, 3 },
                    { 310, 6, 9.48m, 9, 3 },
                    { 198, 9, 16.59m, 22, 2 },
                    { 197, 4, 37.43m, 22, 2 },
                    { 190, 2, 14.75m, 22, 0 },
                    { 177, 7, 1.55m, 22, 0 },
                    { 160, 2, 47.15m, 22, 1 },
                    { 156, 9, 13.24m, 22, 0 },
                    { 143, 6, 8.82m, 22, 3 },
                    { 16, 9, 26.13m, 22, 1 },
                    { 4, 7, 7.87m, 22, 0 },
                    { 475, 8, 40.4m, 19, 1 },
                    { 401, 9, 16.57m, 19, 0 },
                    { 379, 4, 30.41m, 19, 2 },
                    { 317, 9, 34.05m, 19, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 462, 3, 40.63m, 44, 3 },
                    { 313, 5, 4.27m, 19, 1 },
                    { 148, 8, 49.01m, 19, 1 },
                    { 110, 5, 44.6m, 19, 1 },
                    { 104, 6, 48.97m, 19, 0 },
                    { 80, 3, 14.9m, 19, 1 },
                    { 76, 1, 14.69m, 19, 1 },
                    { 54, 3, 23.72m, 19, 0 },
                    { 53, 8, 24.94m, 19, 0 },
                    { 492, 9, 12.05m, 9, 1 },
                    { 423, 1, 34.74m, 9, 2 },
                    { 413, 4, 26.86m, 9, 2 },
                    { 355, 4, 19.08m, 9, 1 },
                    { 343, 8, 17.65m, 9, 3 },
                    { 342, 4, 23.1m, 9, 1 },
                    { 260, 8, 4.52m, 19, 2 },
                    { 484, 6, 6.54m, 37, 2 },
                    { 416, 4, 4.14m, 44, 3 },
                    { 146, 7, 44.81m, 44, 3 },
                    { 65, 2, 40.95m, 29, 3 },
                    { 382, 1, 31.77m, 28, 2 },
                    { 339, 2, 3.93m, 28, 3 },
                    { 318, 7, 37.19m, 28, 0 },
                    { 308, 6, 41.66m, 28, 1 },
                    { 243, 8, 46.39m, 28, 3 },
                    { 208, 2, 41.26m, 28, 1 },
                    { 172, 4, 6.51m, 28, 3 },
                    { 140, 3, 36.42m, 28, 3 },
                    { 122, 9, 35.33m, 28, 0 },
                    { 73, 7, 45.83m, 28, 2 },
                    { 72, 7, 17.55m, 28, 3 },
                    { 64, 8, 19.28m, 28, 0 },
                    { 31, 8, 4.11m, 28, 3 },
                    { 483, 8, 43.85m, 23, 2 },
                    { 480, 4, 2.01m, 23, 0 },
                    { 426, 1, 21.9m, 23, 3 },
                    { 395, 2, 36.3m, 23, 2 },
                    { 391, 9, 49.93m, 23, 0 },
                    { 365, 4, 30.06m, 23, 1 },
                    { 265, 6, 49.85m, 23, 3 },
                    { 236, 1, 33.98m, 23, 2 },
                    { 213, 2, 26.66m, 23, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 202, 5, 18.06m, 23, 0 },
                    { 84, 4, 1.13m, 23, 0 },
                    { 10, 7, 38.89m, 23, 0 },
                    { 458, 2, 8.93m, 21, 1 },
                    { 186, 7, 24.8m, 29, 1 },
                    { 231, 6, 17.76m, 29, 2 },
                    { 268, 6, 36.95m, 29, 0 },
                    { 360, 1, 16.71m, 29, 3 },
                    { 136, 5, 3.81m, 44, 2 },
                    { 131, 1, 49.5m, 44, 1 },
                    { 27, 7, 3.03m, 44, 1 },
                    { 446, 6, 13.92m, 36, 0 },
                    { 409, 2, 27.72m, 36, 0 },
                    { 388, 4, 44.09m, 36, 3 },
                    { 376, 8, 15.44m, 36, 3 },
                    { 285, 1, 31.48m, 36, 3 },
                    { 252, 9, 10.06m, 36, 2 },
                    { 220, 1, 30.54m, 36, 1 },
                    { 41, 3, 1.59m, 36, 1 },
                    { 463, 7, 8.72m, 32, 1 },
                    { 444, 1, 15.53m, 32, 2 },
                    { 337, 8, 26.94m, 44, 3 },
                    { 435, 2, 7.02m, 32, 2 },
                    { 397, 8, 40.04m, 32, 3 },
                    { 393, 6, 42.55m, 32, 3 },
                    { 358, 2, 18m, 32, 2 },
                    { 233, 7, 32.72m, 32, 0 },
                    { 232, 5, 45.09m, 32, 2 },
                    { 188, 4, 6.24m, 32, 0 },
                    { 153, 5, 26.1m, 32, 2 },
                    { 147, 7, 31.95m, 32, 3 },
                    { 103, 6, 22.1m, 32, 2 },
                    { 95, 3, 43.61m, 32, 0 },
                    { 85, 8, 36.42m, 32, 1 },
                    { 486, 6, 3.78m, 29, 2 },
                    { 424, 1, 37.99m, 29, 0 },
                    { 417, 6, 20.78m, 32, 3 },
                    { 493, 4, 25.19m, 37, 2 }
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

            var s1 = @"Create procedure [dbo].[dbo_spCategory_GetRecipeByCategory]
            as
            begin  select Categories.name as CategoryName,Recipes.Name as RecipeName,TotalCost
            from Categories
            INNER JOIN Recipes
            ON Recipes.CategoryId = Categories.Id
            ORDER by categoryId,TotalCost;
            end";
            var s2 = @"Create procedure [dbo].[dbo_spRecipeIngredient_GetRecipeWithIngredientCount]
            AS
            BEGIN
            SELECT count(ingredientId)as TotalIngredients,Name,RecipeId,Recipes.TotalCost
            FROM RecipeIngredients
            INNER JOIN Recipes
            ON RecipeIngredients.RecipeId=Recipes.Id
            GROUP BY RecipeId, Name, TotalCost
            HAVING count(ingredientId) >= 10
            ORDER BY TotalCost;
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

            migrationBuilder.Sql(s1);
            migrationBuilder.Sql(s2);
            migrationBuilder.Sql(s3);
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
