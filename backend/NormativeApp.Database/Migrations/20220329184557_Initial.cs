using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeApp.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetRecipesByCategoryName",
                columns: table => new
                {
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GetRecipesWithIngredientCount",
                columns: table => new
                {
                    TotalIngredients = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 1, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 4, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 4, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 4, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 4, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 4, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 4, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 4, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2472), 4, 49.42m, 49, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2523), 8, 46.87m, 11 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2530), 6, 28.48m, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2534), 9, 30.79m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2538), 3, 47.06m, 14 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2545), 9, 46.85m, 37, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2550), 9, 27m, 9, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2554), 3, 9.34m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2558), 3, 34.29m, 22, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2563), 7, 20.98m, 7, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2567), 7, 47.2m, 6, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2572), 5, 46.77m, 36, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2576), 9, 4.59m, 15, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2580), 1, 28.23m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2584), 7, 13.97m, 37 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2588), 6, 33.05m, 47, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2592), 5, 47.87m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2597), 1, 17.81m, 24, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2602), 20.56m, 29 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2606), 3, 5.28m, 25 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2610), 2, 9.12m, 5, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2615), 48.57m, 18, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2619), 8, 44.25m, 7 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2623), 9, 10.43m, 37, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2627), 7, 38.71m, 49 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2631), 4, 35.45m, 19, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2635), 5, 20.08m, 35, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2639), 4, 41.62m, 44 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2644), 1, 39.56m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2648), 8.81m, 40, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2652), 1, 33.74m, 26 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2657), 23.84m, 20, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2660), 7, 26.44m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2665), 40.82m, 31, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2669), 2, 29.63m, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2673), 9, 10.32m, 46, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2678), 2, 44.67m, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2682), 8, 32.11m, 32 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2685), 9, 48.77m, 25, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2690), 6, 17.01m, 15, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2694), 17.96m, 20, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2698), 5, 2.24m, 18, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2702), 2, 7.37m, 23, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2706), 8, 42.82m, 39, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2710), 7, 34.79m, 38 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2713), 2, 40.83m, 22 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2718), 9.55m, 18, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2722), 46.26m, 13, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2726), 8, 20.06m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2730), 8, 31.83m, 16, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2734), 7, 26.11m, 23, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2738), 9, 27.6m, 33 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2743), 10.05m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2747), 1, 29.29m, 44, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2751), 9, 29.56m, 45, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2754), 4, 31.22m, 46, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2758), 6, 48.82m, 32 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2762), 1, 4.55m, 32, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2867), 4, 17.28m, 14, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2872), 6, 18.38m, 24 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2876), 2, 16.14m, 16, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2881), 2, 48.36m, 27 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2885), 4, 16.56m, 17, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2889), 7, 19.3m, 29, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2893), 9, 2.88m, 41, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2899), 6, 16.46m, 28 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2903), 9, 13.54m, 15, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2906), 3, 42.72m, 22, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2910), 1, 35.48m, 26, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2915), 1, 38.96m, 46, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2919), 3, 3.35m, 39, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2923), 2, 22.72m, 19, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2927), 25.1m, 47 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2931), 1, 39.83m, 18, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2935), 8, 33.09m, 16 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2939), 2, 28.8m, 36, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2943), 8, 18.93m, 27 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2947), 9, 45.69m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2951), 8, 7.19m, 14, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2955), 31.7m, 36, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2959), 46.08m, 41, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2963), 6, 48.84m, 46 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2967), 32.22m, 8, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2971), 5, 29.62m, 7, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2975), 2, 5.48m, 22 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2979), 7, 24.82m, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2983), 6, 43.08m, 7 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2987), 8, 13.73m, 16, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2991), 9, 4.57m, 22 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2995), 2, 45.2m, 33, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(2999), 1, 49.95m, 13, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3003), 2, 23.48m, 32 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3007), 2, 8.06m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3011), 7, 28.55m, 27, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3015), 42.07m, 12 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3019), 2, 26.27m, 25, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3023), 8, 14.69m, 16, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3027), 6, 45.79m, 6, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3031), 4, 39.03m, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3035), 8, 1.59m, 15, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3039), 6, 18.52m, 45, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3043), 2, 45.63m, 3, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3047), 6, 10.54m, 25 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3051), 8, 23.53m, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3056), 8, 38.51m, 47, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3060), 4, 40.72m, 40, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3064), 2, 46.62m, 35, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3068), 5, 37.8m, 34, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3072), 7, 14m, 46, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3076), 3, 12.63m, 26, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3080), 4, 24.72m, 22 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3085), 8, 42m, 4, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3089), 4, 10.62m, 32, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3092), 28.51m, 19, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3096), 1, 33.06m, 44, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3100), 6, 38.98m, 13 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3104), 2, 9.73m, 29, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3108), 6, 11.91m, 18, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3112), 6, 37.72m, 40, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3116), 5, 33.92m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3120), 7, 36.92m, 41, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3124), 7, 21.78m, 17, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3128), 1, 43.01m, 26, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3132), 2, 23.05m, 24, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3136), 5, 32.55m, 36 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3140), 4, 47.24m, 13 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3144), 9, 42.83m, 37, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3148), 13.63m, 44 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3152), 3, 22.44m, 35, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3224), 36.21m, 35, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3228), 1, 30.2m, 19, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3232), 1, 10.02m, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3237), 7, 9.41m, 48, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3241), 3, 2.85m, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3245), 9, 41.82m, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3249), 1, 11.1m, 25 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3253), 36.88m, 25 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3257), 3, 32.41m, 35, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3261), 3, 13.79m, 43, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3265), 1, 2.72m, 48, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3269), 7, 44.6m, 23 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3273), 2, 39.18m, 24, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3277), 8, 5.83m, 15, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3282), 9, 15.43m, 17, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3285), 6, 31.02m, 17, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3290), 7, 3.56m, 39, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3294), 1, 24.27m, 21, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3298), 7, 7.56m, 38, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3302), 5, 23.49m, 25, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3306), 2, 21.44m, 3, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3310), 7, 30.71m, 48, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3314), 1, 43.85m, 42 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3318), 2, 12.13m, 40, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3322), 41.1m, 14, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3326), 8, 37.92m, 29, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3330), 2, 7.5m, 41, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3334), 3, 30.62m, 31, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3338), 4, 39.77m, 33, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3342), 8, 14.01m, 33, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3346), 3, 18m, 18, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3350), 4, 16.86m, 35, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3354), 1, 33.21m, 6 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3358), 9, 18.13m, 35, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3362), 5, 30.05m, 28 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3366), 5, 3.22m, 42, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3370), 6, 36.21m, 34, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3374), 8, 7.24m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3378), 9, 37.27m, 14, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3382), 7, 28.09m, 31, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3386), 5, 8.09m, 34, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3390), 6, 15.15m, 39 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3394), 3, 6.93m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3398), 3, 23.06m, 26 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3402), 8, 7.13m, 44, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3406), 17.08m, 31, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3410), 9, 48.03m, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3414), 4, 32.06m, 9, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3418), 5, 49.82m, 44, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3422), 8, 41.62m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3426), 3, 25.96m, 16, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3430), 4, 1.45m, 41, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3434), 3, 11.93m, 49, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3438), 3, 4.68m, 9, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3442), 7, 20.7m, 6, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3446), 8, 15.29m, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3450), 36.64m, 40, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3454), 5, 1.72m, 39 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3458), 4, 10.54m, 38 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3462), 3, 3.48m, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3466), 7, 7.13m, 34, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3470), 9, 40.72m, 32, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3474), 1, 37.81m, 48, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3478), 6, 29.02m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3482), 3, 18.27m, 34, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3486), 5, 43.34m, 35, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3490), 8, 41.61m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3495), 8, 29.3m, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3498), 15.76m, 44, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3502), 7, 19.82m, 34, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3506), 7, 2.91m, 47, 3 });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 473, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4711), 5, 48.06m, 14, 1 },
                    { 474, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4716), 1, 36.53m, 2, 2 },
                    { 475, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4719), 6, 11.76m, 30, 1 },
                    { 478, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4732), 7, 19.18m, 30, 2 },
                    { 477, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4728), 7, 44.68m, 19, 0 },
                    { 472, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4708), 5, 3.06m, 30, 3 },
                    { 476, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4724), 6, 31.44m, 46, 3 },
                    { 471, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4704), 8, 46.26m, 26, 2 },
                    { 479, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4801), 8, 32.42m, 48, 0 },
                    { 469, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4696), 5, 30.56m, 15, 0 },
                    { 468, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4692), 8, 35.39m, 25, 2 },
                    { 467, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4688), 6, 31.73m, 22, 1 },
                    { 466, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4684), 1, 44.04m, 48, 3 },
                    { 465, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4680), 2, 10.94m, 21, 1 },
                    { 464, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4676), 4, 30.42m, 24, 0 },
                    { 463, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4672), 6, 22.75m, 34, 3 },
                    { 462, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4668), 4, 1.86m, 19, 2 },
                    { 470, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4700), 6, 21.99m, 10, 0 },
                    { 480, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4806), 5, 27.46m, 38, 0 },
                    { 201, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3510), 4, 43.41m, 20, 2 },
                    { 482, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4814), 6, 8.23m, 44, 2 },
                    { 461, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4664), 7, 49.08m, 41, 3 },
                    { 500, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4887), 8, 9.36m, 7, 2 },
                    { 499, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4882), 8, 22.92m, 9, 2 },
                    { 498, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4879), 3, 12.82m, 9, 1 },
                    { 497, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4875), 6, 48.58m, 28, 1 },
                    { 496, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4871), 5, 48.29m, 36, 0 },
                    { 495, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4867), 3, 19.41m, 39, 2 },
                    { 494, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4863), 7, 32.59m, 47, 1 },
                    { 481, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4810), 8, 44.49m, 9, 3 },
                    { 493, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4859), 8, 39.96m, 44, 1 },
                    { 491, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4851), 3, 37.94m, 6, 1 },
                    { 490, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4847), 2, 20.83m, 5, 3 },
                    { 489, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4843), 6, 7.57m, 48, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 488, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4839), 8, 20.92m, 25, 0 },
                    { 487, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4835), 1, 9.98m, 21, 2 },
                    { 486, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4831), 1, 40.38m, 38, 0 },
                    { 484, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4822), 6, 15.79m, 29, 2 },
                    { 483, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4818), 8, 31.24m, 1, 2 },
                    { 492, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4855), 4, 49.96m, 25, 3 },
                    { 460, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4660), 5, 17.58m, 43, 3 },
                    { 485, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4826), 6, 27.9m, 15, 2 },
                    { 458, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4652), 5, 24.11m, 35, 1 },
                    { 299, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3975), 3, 37.18m, 30, 1 },
                    { 300, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3979), 8, 1.19m, 41, 0 },
                    { 301, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3983), 2, 42.39m, 25, 0 },
                    { 302, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3987), 8, 16.66m, 28, 3 },
                    { 303, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3991), 3, 33.4m, 33, 1 },
                    { 304, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3995), 1, 8.52m, 16, 0 },
                    { 305, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3999), 8, 30.2m, 24, 3 },
                    { 306, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4003), 8, 32.1m, 1, 0 },
                    { 307, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4007), 8, 29.21m, 48, 3 },
                    { 308, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4011), 9, 34.63m, 48, 1 },
                    { 309, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4015), 4, 29.24m, 21, 1 },
                    { 310, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4019), 6, 17.1m, 15, 3 },
                    { 311, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4023), 7, 25.83m, 36, 3 },
                    { 312, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4027), 6, 32.62m, 32, 0 },
                    { 313, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4031), 2, 10.3m, 37, 3 },
                    { 298, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3971), 7, 13.06m, 11, 3 },
                    { 314, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4035), 7, 23.64m, 43, 1 },
                    { 297, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3967), 8, 5m, 9, 2 },
                    { 295, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3959), 5, 41.18m, 12, 1 },
                    { 280, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3898), 8, 41.02m, 1, 0 },
                    { 281, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3902), 6, 21.52m, 19, 0 },
                    { 282, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3906), 1, 38.74m, 39, 0 },
                    { 283, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3910), 2, 17.41m, 16, 1 },
                    { 284, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3914), 9, 13.34m, 37, 1 },
                    { 285, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3918), 9, 27.15m, 38, 3 },
                    { 286, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3922), 7, 42.61m, 2, 2 },
                    { 287, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3926), 2, 5.67m, 41, 0 },
                    { 288, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3930), 5, 20.43m, 34, 1 },
                    { 289, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3934), 9, 5.77m, 49, 2 },
                    { 290, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3938), 8, 45.77m, 30, 2 },
                    { 291, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3942), 6, 24.85m, 5, 2 },
                    { 292, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3946), 1, 14.65m, 24, 1 },
                    { 293, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3950), 2, 8.08m, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 294, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3954), 1, 33.07m, 8, 0 },
                    { 296, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3963), 8, 38.6m, 39, 0 },
                    { 315, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4039), 4, 26.5m, 19, 3 },
                    { 316, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4043), 3, 19m, 5, 0 },
                    { 317, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4047), 5, 27.34m, 22, 2 },
                    { 338, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4133), 4, 7.9m, 30, 0 },
                    { 339, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4137), 6, 14.62m, 19, 0 },
                    { 340, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4141), 6, 32.55m, 12, 0 },
                    { 341, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4145), 6, 34.71m, 44, 0 },
                    { 342, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4149), 4, 14.43m, 31, 2 },
                    { 343, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4153), 3, 19.69m, 22, 3 },
                    { 344, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4157), 9, 24.21m, 29, 0 },
                    { 345, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4161), 2, 5.89m, 4, 1 },
                    { 346, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4165), 7, 15.04m, 48, 1 },
                    { 347, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4169), 5, 9.47m, 35, 2 },
                    { 348, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4173), 7, 11.87m, 38, 0 },
                    { 349, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4177), 1, 35.39m, 10, 3 },
                    { 350, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4181), 2, 29.73m, 7, 2 },
                    { 351, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4186), 1, 22.24m, 13, 0 },
                    { 352, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4189), 6, 40.46m, 37, 0 },
                    { 337, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4129), 4, 46.28m, 21, 3 },
                    { 336, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4125), 2, 35.8m, 13, 2 },
                    { 335, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4121), 1, 45.35m, 27, 0 },
                    { 334, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4116), 3, 49.23m, 20, 2 },
                    { 318, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4051), 3, 37.29m, 15, 1 },
                    { 319, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4055), 3, 4.27m, 19, 0 },
                    { 320, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4059), 2, 15.39m, 14, 0 },
                    { 321, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4063), 2, 35.99m, 28, 0 },
                    { 322, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4067), 2, 49.88m, 17, 3 },
                    { 323, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4071), 3, 32.15m, 19, 3 },
                    { 324, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4075), 6, 43.66m, 15, 2 },
                    { 279, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3894), 2, 16.82m, 41, 0 },
                    { 325, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4079), 9, 9.53m, 28, 2 },
                    { 327, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4088), 9, 48.66m, 45, 3 },
                    { 328, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4092), 7, 27.95m, 16, 0 },
                    { 329, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4096), 3, 43.46m, 7, 2 },
                    { 330, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4100), 6, 46.33m, 8, 3 },
                    { 331, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4104), 3, 32.84m, 33, 3 },
                    { 332, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4108), 9, 9.27m, 28, 0 },
                    { 333, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4112), 9, 37.21m, 49, 3 },
                    { 326, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4084), 3, 13.24m, 4, 2 },
                    { 278, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3890), 7, 41.17m, 49, 3 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 277, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3886), 9, 45.7m, 15, 3 },
                    { 276, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3882), 9, 6.04m, 35, 2 },
                    { 222, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3596), 8, 30.4m, 3, 1 },
                    { 223, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3600), 1, 25.74m, 32, 1 },
                    { 224, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3638), 1, 36.46m, 25, 3 },
                    { 225, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3642), 6, 45.17m, 41, 1 },
                    { 226, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3646), 1, 29.64m, 11, 3 },
                    { 227, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3650), 7, 30.6m, 3, 2 },
                    { 228, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3654), 4, 34.71m, 23, 3 },
                    { 229, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3658), 9, 15.39m, 47, 2 },
                    { 230, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3662), 5, 3.89m, 40, 2 },
                    { 231, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3666), 9, 25.3m, 38, 1 },
                    { 232, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3670), 2, 2.04m, 20, 3 },
                    { 233, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3674), 3, 48.45m, 49, 1 },
                    { 234, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3678), 5, 45.18m, 43, 2 },
                    { 235, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3682), 4, 2.68m, 6, 3 },
                    { 236, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3687), 4, 26.66m, 44, 0 },
                    { 221, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3592), 1, 10.18m, 4, 1 },
                    { 220, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3587), 7, 48.16m, 43, 3 },
                    { 219, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3583), 9, 40.03m, 42, 1 },
                    { 218, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3579), 5, 34.61m, 40, 1 },
                    { 202, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3515), 1, 23.03m, 9, 3 },
                    { 203, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3519), 3, 7.87m, 8, 2 },
                    { 204, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3523), 1, 14.76m, 8, 2 },
                    { 205, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3527), 1, 29.83m, 49, 1 },
                    { 206, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3531), 1, 3.97m, 2, 2 },
                    { 207, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3535), 8, 45.61m, 14, 2 },
                    { 208, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3540), 9, 9.65m, 33, 1 },
                    { 237, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3690), 1, 35.11m, 38, 1 },
                    { 209, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3544), 2, 13.82m, 42, 0 },
                    { 211, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3552), 5, 13.23m, 45, 3 },
                    { 212, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3556), 8, 2.37m, 20, 2 },
                    { 213, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3560), 9, 25.29m, 4, 2 },
                    { 214, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3564), 4, 26.32m, 18, 3 },
                    { 215, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3568), 8, 31.66m, 9, 3 },
                    { 216, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3572), 7, 38.54m, 39, 2 },
                    { 217, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3575), 6, 43.76m, 24, 3 },
                    { 210, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3548), 5, 26.17m, 21, 1 },
                    { 353, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4194), 2, 12.25m, 42, 3 },
                    { 238, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3695), 3, 15.48m, 3, 1 },
                    { 240, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3702), 9, 41.22m, 34, 2 },
                    { 261, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3788), 6, 13.92m, 22, 3 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 262, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3792), 9, 7.07m, 4, 3 },
                    { 263, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3795), 9, 48.22m, 47, 3 },
                    { 264, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3800), 5, 41.03m, 38, 2 },
                    { 265, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3804), 2, 16.89m, 26, 3 },
                    { 266, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3807), 4, 6.18m, 29, 3 },
                    { 267, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3811), 5, 12.27m, 33, 1 },
                    { 268, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3815), 6, 22.17m, 8, 1 },
                    { 269, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3819), 8, 7.19m, 42, 3 },
                    { 270, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3823), 3, 23.21m, 5, 0 },
                    { 271, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3827), 7, 37.41m, 40, 1 },
                    { 272, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3832), 3, 19.12m, 16, 0 },
                    { 273, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3836), 8, 47.3m, 34, 1 },
                    { 274, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3840), 7, 35.03m, 24, 2 },
                    { 275, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3877), 1, 33.98m, 11, 2 },
                    { 260, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3784), 5, 38.93m, 14, 2 },
                    { 259, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3780), 3, 33.05m, 4, 0 },
                    { 258, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3776), 9, 10.02m, 40, 3 },
                    { 257, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3770), 8, 18.1m, 40, 1 },
                    { 241, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3706), 5, 43.19m, 17, 0 },
                    { 242, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3710), 9, 41.38m, 18, 1 },
                    { 243, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3714), 6, 19.7m, 2, 1 },
                    { 244, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3718), 6, 43.27m, 49, 1 },
                    { 245, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3722), 2, 21.02m, 31, 0 },
                    { 246, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3726), 7, 8.9m, 38, 1 },
                    { 247, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3731), 5, 15.04m, 45, 3 },
                    { 239, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3699), 4, 32.87m, 17, 3 },
                    { 248, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3734), 2, 25.69m, 11, 3 },
                    { 250, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3742), 9, 47.79m, 37, 3 },
                    { 251, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3746), 2, 28.1m, 6, 1 },
                    { 252, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3750), 2, 43.84m, 10, 2 },
                    { 253, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3754), 8, 46.15m, 29, 0 },
                    { 254, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3758), 3, 17.7m, 25, 3 },
                    { 255, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3762), 1, 9.43m, 43, 1 },
                    { 256, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3766), 3, 9.89m, 9, 2 },
                    { 249, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(3739), 4, 45.25m, 5, 1 },
                    { 459, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4656), 1, 9.98m, 42, 3 },
                    { 354, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4198), 1, 44.99m, 47, 1 },
                    { 356, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4206), 4, 35.97m, 1, 1 },
                    { 428, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4530), 1, 18.52m, 4, 1 },
                    { 429, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4535), 9, 25.66m, 21, 2 },
                    { 430, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4539), 1, 23.1m, 6, 2 },
                    { 431, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4543), 1, 28.65m, 20, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 432, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4547), 8, 10.27m, 29, 3 },
                    { 433, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4551), 6, 31.57m, 4, 0 },
                    { 434, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4555), 7, 20.74m, 43, 2 },
                    { 435, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4559), 1, 13.37m, 6, 2 },
                    { 436, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4562), 3, 10.31m, 14, 0 },
                    { 437, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4566), 8, 16.59m, 20, 2 },
                    { 427, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4526), 2, 28.84m, 45, 3 },
                    { 438, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4571), 6, 44.58m, 41, 1 },
                    { 440, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4579), 3, 46.19m, 43, 2 },
                    { 441, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4583), 7, 35.35m, 22, 0 },
                    { 425, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4518), 8, 42.92m, 11, 0 },
                    { 443, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4590), 7, 43.97m, 15, 2 },
                    { 444, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4594), 3, 2.05m, 9, 2 },
                    { 445, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4598), 7, 40.57m, 15, 2 },
                    { 446, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4602), 9, 36.26m, 11, 2 },
                    { 447, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4607), 4, 1.57m, 48, 3 },
                    { 448, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4611), 2, 48.18m, 36, 1 },
                    { 449, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4615), 4, 39.6m, 49, 3 },
                    { 439, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4575), 9, 5.53m, 10, 1 },
                    { 450, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4619), 1, 6.94m, 25, 3 },
                    { 355, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4202), 8, 30.83m, 43, 1 },
                    { 402, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4425), 9, 48.38m, 9, 1 },
                    { 424, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4514), 4, 38.55m, 9, 3 },
                    { 423, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4510), 2, 12.49m, 49, 3 },
                    { 422, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4506), 9, 36.48m, 20, 0 },
                    { 421, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4502), 7, 6.68m, 20, 0 },
                    { 420, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4498), 8, 6.62m, 41, 0 },
                    { 419, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4494), 3, 47.91m, 17, 2 },
                    { 418, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4490), 6, 49.05m, 20, 2 },
                    { 417, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4486), 2, 2.98m, 40, 2 },
                    { 416, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4482), 3, 9.31m, 38, 1 },
                    { 415, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4478), 3, 16.79m, 39, 2 },
                    { 401, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4421), 6, 10.96m, 37, 1 },
                    { 414, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4474), 8, 45.53m, 43, 2 },
                    { 412, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4466), 4, 27.64m, 13, 2 },
                    { 411, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4462), 3, 26.22m, 34, 1 },
                    { 410, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4458), 6, 31.41m, 9, 1 },
                    { 409, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4454), 6, 12.99m, 14, 0 },
                    { 408, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4449), 8, 29.52m, 36, 1 },
                    { 407, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4445), 2, 10.2m, 35, 3 },
                    { 406, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4441), 8, 22.22m, 22, 0 },
                    { 405, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4437), 5, 9.65m, 19, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 404, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4433), 8, 42.85m, 31, 1 },
                    { 403, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4429), 9, 6.38m, 3, 0 },
                    { 413, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4470), 5, 37.13m, 18, 0 },
                    { 451, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4623), 3, 43.53m, 32, 0 },
                    { 442, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4587), 8, 10.12m, 17, 3 },
                    { 453, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4632), 2, 46.45m, 18, 1 },
                    { 379, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4332), 1, 15.51m, 39, 1 },
                    { 378, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4328), 8, 37.97m, 16, 1 },
                    { 377, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4324), 6, 23.41m, 42, 0 },
                    { 376, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4287), 4, 36.36m, 24, 2 },
                    { 375, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4283), 6, 25.86m, 4, 1 },
                    { 374, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4278), 7, 41.32m, 15, 0 },
                    { 373, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4274), 3, 16.11m, 22, 1 },
                    { 372, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4270), 6, 29.66m, 47, 3 },
                    { 371, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4266), 8, 7.38m, 27, 1 },
                    { 370, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4262), 1, 19.72m, 17, 3 },
                    { 369, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4258), 4, 40.96m, 7, 2 },
                    { 368, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4254), 6, 48.44m, 22, 0 },
                    { 367, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4250), 9, 7.01m, 10, 1 },
                    { 366, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4246), 1, 10.29m, 47, 1 },
                    { 365, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4242), 2, 34.03m, 45, 3 },
                    { 364, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4238), 5, 46.32m, 33, 1 },
                    { 363, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4234), 8, 41.35m, 15, 2 },
                    { 362, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4230), 5, 30.13m, 24, 0 },
                    { 361, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4226), 3, 30.6m, 4, 3 },
                    { 360, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4222), 8, 23.58m, 5, 3 },
                    { 359, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4218), 9, 37.42m, 10, 2 },
                    { 358, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4214), 1, 46.21m, 30, 3 },
                    { 357, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4210), 2, 28.31m, 37, 3 },
                    { 380, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4336), 2, 34.91m, 41, 0 },
                    { 452, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4628), 8, 7.8m, 33, 1 },
                    { 426, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4522), 4, 21.1m, 24, 3 },
                    { 385, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4356), 9, 42.22m, 22, 0 },
                    { 394, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4393), 2, 12.05m, 47, 0 },
                    { 393, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4389), 4, 22.08m, 33, 1 },
                    { 392, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4385), 4, 42.99m, 30, 2 },
                    { 391, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4380), 2, 4.18m, 1, 3 },
                    { 390, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4377), 8, 12.44m, 43, 1 },
                    { 389, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4373), 6, 22.41m, 47, 0 },
                    { 388, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4368), 6, 1.6m, 29, 2 },
                    { 387, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4364), 6, 40.99m, 19, 1 },
                    { 386, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4360), 3, 49.84m, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 397, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4405), 1, 27.59m, 14, 1 },
                    { 384, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4352), 8, 45.63m, 39, 2 },
                    { 383, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4348), 9, 11.06m, 30, 1 },
                    { 382, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4344), 4, 14.31m, 47, 2 },
                    { 381, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4340), 3, 4.46m, 30, 3 },
                    { 396, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4401), 5, 22.73m, 42, 2 },
                    { 398, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4409), 6, 31.06m, 9, 0 },
                    { 399, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4413), 7, 1.87m, 9, 3 },
                    { 400, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4417), 2, 18.23m, 27, 2 },
                    { 457, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4648), 8, 39.32m, 10, 1 },
                    { 456, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4644), 9, 11.69m, 45, 1 },
                    { 455, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4639), 3, 43.87m, 1, 2 },
                    { 454, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4636), 7, 16.12m, 45, 3 },
                    { 395, new DateTime(2022, 3, 29, 20, 45, 57, 7, DateTimeKind.Local).AddTicks(4397), 8, 16.09m, 10, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 5, DateTimeKind.Local).AddTicks(8924), 21.3897547756274m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(592), 49.3826376429678m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(673), 17.1358368048146m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(680), 33.5597034690714m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(684), 92.1981341290279m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(692), 72.6253995241716m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 7, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(696), 96.2386028073908m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(700), 80.2900679550553m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(704), 12.8082692296283m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 7, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(710), 52.2136083958734m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(714), 63.9268285571257m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(719), 66.1911543971818m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(723), 9.92391825743202m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "TotalCost" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(727), 50.7611107396712m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(731), 37.5392848530502m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(735), 34.7292729563682m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(739), 99.1295291232548m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(745), 95.39727491252m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(749), 71.409782507182m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(753), 37.3707418480752m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(757), 66.6421359216991m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 7, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(761), 76.6972915105044m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(765), 58.2641640344002m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(769), 83.6455160009886m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(773), 69.4678153532873m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(777), 54.4275402736047m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(781), 2.7720208842177m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(785), 37.5260631197719m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "TotalCost" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(789), 81.6799943142943m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(793), 63.9558821185286m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(797), 68.7112180803489m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(801), 61.8384635503583m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(805), 65.6126001042373m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(810), 66.7644662157467m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(814), 59.1636167495342m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(818), 11.266156728969m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 7, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(822), 7.16430852104179m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 7, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(826), 35.3552143663891m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(830), 50.2904355424877m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(834), 83.9446551031175m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(837), 11.9421838177099m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(841), 23.1468334403573m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 7, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(845), 15.0737241097138m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(849), 36.8863886449888m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(853), 90.3562328737956m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(857), 61.7843641367668m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "TotalCost" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(861), 60.7095012616876m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(900), 60.5658792357733m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(904), 80.334345433551m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 29, 20, 45, 57, 6, DateTimeKind.Local).AddTicks(908), 95.1182776340834m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 85, 6, 19, 124, 148, 240, 222, 50, 193, 199, 52, 128, 12, 83, 235, 234, 137, 213, 225, 81, 93, 182, 16, 234, 202, 5, 22, 221, 177, 4, 0, 58, 27, 191, 58, 112, 149, 165, 239, 1, 202, 239, 135, 186, 122, 31, 19, 11, 223, 187, 68, 189, 19, 85, 73, 55, 59, 176, 114, 50, 248, 224, 42 }, new byte[] { 42, 135, 46, 189, 188, 246, 124, 227, 214, 194, 5, 9, 69, 5, 101, 141, 117, 61, 40, 212, 26, 217, 245, 159, 155, 36, 10, 71, 202, 150, 225, 234, 159, 181, 66, 126, 176, 183, 81, 146, 219, 253, 28, 102, 254, 94, 206, 118, 27, 113, 231, 107, 236, 254, 70, 64, 240, 242, 153, 50, 57, 6, 117, 35, 62, 110, 208, 206, 61, 50, 55, 202, 237, 18, 86, 202, 168, 143, 230, 163, 38, 134, 118, 190, 167, 230, 101, 152, 30, 255, 162, 250, 176, 16, 156, 177, 147, 166, 183, 111, 254, 8, 214, 255, 81, 100, 156, 243, 221, 78, 254, 226, 18, 80, 140, 63, 233, 40, 171, 81, 166, 105, 95, 61, 255, 38, 143, 130 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetRecipesByCategoryName");

            migrationBuilder.DropTable(
                name: "GetRecipesWithIngredientCount");

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 644, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 28, 16, 5, 58, 647, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7890), 7, 1.89m, 19, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7939), 7, 13.92m, 27 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7945), 4, 33.18m, 38 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(7950), 5, 45.63m, 14, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8005), 9, 7.97m, 39 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8013), 5, 22.81m, 16, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8017), 8, 37.85m, 12, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8022), 5, 1.85m, 31, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8026), 9, 24.97m, 29, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8030), 8, 25.85m, 16, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8034), 4, 1.29m, 31, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8039), 6, 3.29m, 21, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8043), 3, 23.32m, 3, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8047), 6, 40.7m, 45, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8051), 5, 3.04m, 40 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8055), 5, 8.12m, 43, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8059), 1, 30.12m, 22, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8064), 8, 23.15m, 42, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8068), 36.82m, 4 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8072), 5, 9.15m, 15 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8076), 1, 40.48m, 34, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8080), 48.59m, 6, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8084), 4, 46.02m, 47 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8088), 7, 17.34m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8092), 2, 33.66m, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8096), 7, 12.49m, 20, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8100), 3, 1.19m, 21, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8104), 2, 6.25m, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8108), 8, 43.32m, 26, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8112), 35.23m, 34, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8116), 2, 41.19m, 31 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8120), 7.18m, 24, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8125), 1, 24.19m, 17, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8129), 36.43m, 33, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8133), 6, 5.47m, 41 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8137), 4, 17.57m, 11, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8142), 1, 49.98m, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8146), 5, 40.35m, 15 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8149), 1, 46.77m, 46, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8154), 4, 34.91m, 20, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8158), 15m, 15, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8161), 1, 18.75m, 4, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8165), 1, 29.56m, 7, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8169), 1, 25.41m, 14, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8173), 6, 19.31m, 9 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8177), 6, 16.95m, 38 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8181), 21.13m, 41, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8185), 49.3m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8189), 2, 4.72m, 12, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8193), 5, 19.2m, 42, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8197), 8, 14.79m, 15, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8201), 4, 48.7m, 36 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8205), 20.7m, 22, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8209), 6, 22.24m, 23, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8213), 1, 11.69m, 24, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8217), 5, 33.32m, 4, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8221), 3, 6.69m, 14 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8225), 4, 32.88m, 48, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8229), 8, 15.39m, 38, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8233), 7, 18.93m, 26 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8237), 1, 7.78m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8241), 6, 29.91m, 10 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8245), 7, 33.25m, 11, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8249), 6, 35.96m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8252), 1, 28.62m, 4, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8258), 8, 41.41m, 33 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8262), 2, 36.8m, 18, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8265), 1, 17.92m, 12, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8269), 8, 36.69m, 15, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8273), 2, 3.76m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8278), 9, 20.1m, 44, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8282), 5, 26.12m, 9, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8286), 9.55m, 19 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8290), 9, 43m, 4, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8294), 3, 39.41m, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8298), 3, 44.22m, 13, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8301), 7, 3.33m, 26 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8305), 7, 31.36m, 18, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8309), 6, 11.82m, 38, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8313), 9.86m, 22, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8381), 3.38m, 3, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8385), 2, 49.56m, 30 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8389), 15.5m, 44, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8393), 8, 42.09m, 31, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8397), 4, 25.92m, 17 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8401), 1, 48.23m, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8405), 2, 1.88m, 30 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8409), 7, 34.33m, 11, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8413), 7, 4.17m, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8417), 3, 35.23m, 9, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8421), 8, 5.4m, 33, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8425), 8, 7.76m, 34 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8429), 3, 38.47m, 26, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8433), 6, 21.93m, 37, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8437), 26.23m, 45 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8441), 3, 17.72m, 30, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8445), 4, 37.68m, 11, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8449), 1, 31.86m, 40, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8453), 6, 46.83m, 21 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8457), 9, 30.58m, 46, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8461), 8, 38.87m, 30, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8465), 3, 42.09m, 27, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8469), 5, 20.31m, 20 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8473), 5, 5.03m, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8477), 9, 28.05m, 35, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8481), 2, 34.9m, 16, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8485), 7, 37.27m, 31, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8489), 6, 43.03m, 17, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8493), 2, 27.45m, 26, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8497), 2, 30.53m, 47, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8501), 8, 29.8m, 23 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8504), 3, 36.93m, 32, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8508), 6, 47.72m, 18, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8513), 7.46m, 36, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8517), 6, 3.14m, 28, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8521), 4, 6.57m, 26 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8525), 6, 8.72m, 7, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8529), 1, 47.54m, 37, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8533), 8, 47.71m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8537), 3, 40.65m, 46, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8541), 1, 8.57m, 12, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8545), 8, 22.53m, 42, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8549), 2, 8.94m, 12, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8553), 4, 12.81m, 39, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8557), 7, 30.26m, 31 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8560), 6, 18.61m, 34 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8564), 6, 23.81m, 15, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8568), 29.09m, 5 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8572), 7, 21.32m, 45, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8578), 1.52m, 42, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8582), 9, 49.59m, 24, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8585), 5, 44.65m, 24 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8589), 5, 41.19m, 9, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8593), 7, 17.18m, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8597), 8, 7.75m, 18 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8601), 4, 14.29m, 47 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8605), 41.85m, 47 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8609), 6, 43.67m, 15, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8613), 5, 46.14m, 31, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8617), 8, 12.4m, 21, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8621), 4, 41.41m, 7 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8625), 8, 13.44m, 32, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8629), 2, 30.58m, 7, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8633), 6, 48.34m, 26, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8637), 8, 34.91m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8641), 9, 1.86m, 40, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8645), 2, 43.94m, 5, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8649), 8, 21.44m, 29, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8653), 4, 22.48m, 22, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8657), 9, 18.15m, 22, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8661), 8, 44.78m, 38, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8665), 7, 45.94m, 14 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8669), 8, 19.71m, 36, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8673), 33.63m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8676), 3, 27.13m, 34, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8680), 4, 10.77m, 32, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8718), 6, 42.49m, 43, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8722), 3, 5.59m, 12, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8726), 9, 24.84m, 44, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8730), 9, 36.38m, 29, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8734), 3, 36.73m, 6, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8738), 3, 37.59m, 27 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8742), 5, 8.9m, 43, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8746), 1, 44.75m, 8 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8750), 3, 4.96m, 39, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8754), 7, 35.65m, 38, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8758), 7, 40.65m, 32, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8762), 8, 6.8m, 30, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8766), 5, 25.88m, 44, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8770), 7, 29.11m, 19, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8773), 1, 48.52m, 29 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8777), 2, 38.21m, 44, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8782), 6, 6.99m, 39 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8786), 7, 25.98m, 10, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8790), 5.34m, 16, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8794), 7, 10.15m, 16 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8797), 2, 29.33m, 49, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8801), 7, 15.33m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8805), 1, 45.87m, 20, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8809), 4, 25.82m, 14, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8813), 3, 30.99m, 34, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8817), 9, 32.55m, 35, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8821), 1, 30.06m, 7, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8825), 1, 39.98m, 31, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8829), 4, 8.94m, 24 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8833), 12.71m, 12, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8837), 3, 19.53m, 47 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8841), 6, 30.32m, 35 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8845), 1, 37.33m, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8849), 5, 42.92m, 20, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8853), 6, 26.32m, 12, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8856), 2, 32.28m, 15, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8860), 7, 46.85m, 37, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8864), 6, 4.61m, 45, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8868), 4, 23.67m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8872), 6, 41.04m, 21, 0 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8876), 2, 16.7m, 38 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8880), 3.4m, 17, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8884), 9, 16.56m, 29, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 649, DateTimeKind.Local).AddTicks(8888), 2, 44.26m, 40, 1 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(4637), 59.2634190145244m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6198), 91.200741720945m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6224), 30.5755097510179m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6229), 41.432707834259m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6234), 52.5716083876656m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6241), 98.0697407308359m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6246), 25.3216929679372m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6250), 58.5737217122566m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6254), 62.4630500192116m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6259), 3.86633877449964m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6264), 66.7702853119794m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6268), 10.7738651818474m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6271), 94.350085365749m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "TotalCost" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6275), 75.6603142678087m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6279), 25.3733078671495m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6283), 18.1545376862188m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6286), 60.749792028102m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6292), 19.0944419680603m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6345), 81.0078674210272m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6351), 92.2933071135978m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6355), 22.2787300805928m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6359), 7.74897919350722m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6363), 63.4297208615717m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6366), 73.0487269456725m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6370), 52.4892538960507m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6374), 48.3360591280908m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6378), 16.4391635323126m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6381), 51.415549982067m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "TotalCost" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6385), 34.4729272399437m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6389), 12.2844952634929m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6392), 35.0167902400795m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6396), 60.5416160102662m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6400), 47.1820451329379m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6405), 19.5506105667682m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6409), 32.8770424601981m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6413), 37.6619503720021m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6417), 80.3286665009002m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6421), 49.7662763426855m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6424), 43.7003279881088m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6428), 59.7268830289724m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6432), 98.5142777341019m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6436), 4.37947945826663m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6440), 66.9263020702294m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6444), 28.0159716503769m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6447), 58.9688080353517m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6451), 58.1942726048614m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "TotalCost" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6455), 42.9682192690522m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6459), 7.31254577139045m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6462), 10.8601302503888m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedDate", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 5, 58, 648, DateTimeKind.Local).AddTicks(6466), 21.1669956669989m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 196, 250, 12, 17, 65, 15, 241, 97, 98, 227, 21, 60, 18, 181, 187, 103, 122, 176, 168, 68, 254, 134, 70, 75, 33, 90, 68, 36, 84, 157, 201, 92, 138, 159, 137, 119, 252, 33, 128, 127, 109, 41, 32, 100, 209, 56, 123, 15, 97, 246, 70, 21, 254, 79, 152, 63, 251, 145, 32, 2, 117, 202, 174 }, new byte[] { 234, 176, 183, 95, 244, 180, 149, 105, 76, 215, 21, 203, 119, 208, 216, 225, 52, 118, 80, 18, 114, 105, 152, 214, 173, 181, 191, 254, 150, 80, 169, 146, 175, 33, 139, 128, 125, 240, 161, 207, 122, 230, 24, 159, 189, 142, 132, 50, 95, 225, 117, 193, 1, 132, 252, 23, 117, 150, 239, 52, 241, 224, 104, 229, 68, 94, 51, 248, 100, 39, 156, 108, 128, 125, 190, 47, 108, 208, 211, 145, 169, 125, 156, 65, 143, 97, 242, 144, 145, 190, 29, 211, 173, 253, 18, 130, 15, 65, 32, 147, 81, 62, 5, 28, 236, 127, 138, 185, 39, 61, 217, 207, 44, 85, 163, 59, 20, 118, 187, 183, 102, 216, 137, 219, 177, 91, 153, 238 } });
        }
    }
}
