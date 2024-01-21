using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalog.Infrastructure.Migrations
{
    public partial class ToInsertDataIntoProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, UrlImage, Stock, DateRegister, CategoryId) " +
                "Values('Coffee Maker', 'Capacity 355ml, color black, material in plastic', 93.49, 'coffeeMaker.jpg', '30', GETDATE(), 3)");

            migrationBuilder.Sql("Insert into Products(Name, Description, Price, UrlImage, Stock, DateRegister, CategoryId) " +
                "Values('Towels Premium', 'Bath Towel, material in cotton, dimensions 30L x 30W Centimetres', 25.99, 'bathTowel.jpg', 100, GETDATE(), 3)");

            migrationBuilder.Sql("Insert into Products(Name, Description, Price, UrlImage, Stock, DateRegister, CategoryId) " +
                "Values('Laptop Inspiron', 'Core i7, 32GB, 4Ram and 120fhd', 789.54, 'laptop.jpg', 10, GETDATE(), 1)");

            migrationBuilder.Sql("Insert into Products(Name, Description, Price, UrlImage, Stock, DateRegister, CategoryId) " +
                "Values('Harry Potter and the Philosopher’s Stone', 'Language english, hardcover 368 pages, weight 1.07 kg', 36.46, 'bookHarryPotter.jpg', 50, GETDATE(), 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
