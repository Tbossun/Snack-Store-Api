﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnackStore.Data.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 1, "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/spring roll.jpg", "Spring Roll", 7.9900000000000002, "" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 2, "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/idli.jpg", "Idli", 8.9900000000000002, "" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 3, "Appetizer", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/pani puri.jpg", "Panu Puri", 8.9900000000000002, "Best Seller" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 4, "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/hakka noodles.jpg", "Hakka Noodles", 10.99, "" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 5, "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/malai kofta.jpg", "Malai Kofta", 12.99, "Top Rated" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 6, "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/paneer pizza.jpg", "Paneer Pizza", 11.99, "" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 7, "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/paneer tikka.jpg", "Paneer Tikka", 13.99, "Chef's Special" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 8, "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/carrot love.jpg", "Carrot Love", 4.9900000000000002, "" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 9, "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/rasmalai.jpg", "Rasmalai", 4.9900000000000002, "Chef's Special" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 10, "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://redmangoimages.blob.core.windows.net/redmango/sweet rolls.jpg", "Sweet Rolls", 3.9900000000000002, "Top Rated" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
