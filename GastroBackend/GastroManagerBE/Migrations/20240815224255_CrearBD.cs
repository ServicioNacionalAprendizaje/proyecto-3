using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GastroManagerBE.Migrations
{
    public partial class CrearBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthdayDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<float>(type: "float", nullable: false),
                    Available = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TableRestaurants",
                columns: table => new
                {
                    TableRestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Available = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableRestaurants", x => x.TableRestaurantId);
                    table.ForeignKey(
                        name: "FK_TableRestaurants_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderCustomers",
                columns: table => new
                {
                    OrderCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TableRestaurantId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCustomers", x => x.OrderCustomerId);
                    table.ForeignKey(
                        name: "FK_OrderCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderCustomers_TableRestaurants_TableRestaurantId",
                        column: x => x.TableRestaurantId,
                        principalTable: "TableRestaurants",
                        principalColumn: "TableRestaurantId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameCustomer = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberGuest = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneCustomer = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReservationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_TableRestaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "TableRestaurants",
                        principalColumn: "TableRestaurantId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PriceProduct = table.Column<float>(type: "float", nullable: false),
                    OrderCustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_OrderCustomers_OrderCustomerId",
                        column: x => x.OrderCustomerId,
                        principalTable: "OrderCustomers",
                        principalColumn: "OrderCustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Fritos", null },
                    { 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Bebidas", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BirthdayDate", "CreatedAt", "CreatedBy", "Email", "Name", "NumberPhone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 6, 10, 5, 20, 48, 608, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Louis38@yahoo.com", "Louis Beatty", "(548) 543-4410 x35802", null },
                    { 2, new DateTime(1967, 8, 19, 13, 39, 37, 908, DateTimeKind.Local).AddTicks(8627), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Walter85@yahoo.com", "Walter Brown", "(588) 292-0948 x30782", null },
                    { 3, new DateTime(1990, 4, 10, 19, 49, 26, 780, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Carlos_Torp@yahoo.com", "Carlos Torp", "(242) 975-7187", null },
                    { 4, new DateTime(2000, 11, 8, 4, 27, 27, 98, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Malcolm.Koepp71@hotmail.com", "Malcolm Koepp", "574.210.7496", null },
                    { 5, new DateTime(1984, 4, 27, 1, 30, 0, 806, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Caleb.Hayes23@gmail.com", "Caleb Hayes", "(624) 639-2607 x8843", null },
                    { 6, new DateTime(1968, 10, 19, 7, 58, 58, 223, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Domingo24@gmail.com", "Domingo Schimmel", "409.485.5541 x55183", null },
                    { 7, new DateTime(1962, 12, 14, 2, 3, 37, 677, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Allen.Kihn8@hotmail.com", "Allen Kihn", "1-422-282-8189 x0674", null },
                    { 8, new DateTime(1980, 3, 19, 22, 47, 24, 716, DateTimeKind.Local).AddTicks(3707), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Blake.Stamm@gmail.com", "Blake Stamm", "724-617-2415", null },
                    { 9, new DateTime(1999, 10, 10, 5, 30, 57, 240, DateTimeKind.Local).AddTicks(5908), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Daisy.Schultz@yahoo.com", "Daisy Schultz", "1-650-567-3969", null },
                    { 10, new DateTime(1985, 12, 24, 19, 52, 13, 199, DateTimeKind.Local).AddTicks(2378), new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Winifred_Kunde89@gmail.com", "Winifred Kunde", "781-592-7163", null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Ibague - Tolima", new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "La casa Familiar", null },
                    { 2, "Cartagena - Bolivar", new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "El sabor de la Calle", null },
                    { 3, "Cartagena - Bolivar", new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "El sabor de la Calle", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "CreatedAt", "CreatedBy", "Email", "Password", "Role", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "yule@gmail.com", "abcd", "Admin", null, "Yule" },
                    { 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "user@gmail.com", "1234", "User", null, "user" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Available", "CategoryId", "CreatedAt", "CreatedBy", "Description", "Image", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Bebida con sabor a cola", "https://images.pexels.com/photos/4389680/pexels-photo-4389680.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Cocacola", 3500f, null },
                    { 2, true, 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Gaseosa Postobon", "https://mandalomarket.com/wp-content/uploads/2024/01/refresco1.jpg", "Manzana", 4000f, null },
                    { 3, true, 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Jugo de sabor Naranja", "https://vixark.b-cdn.net/lp-i-i-g/jugo-de-naranja-hit-1000ml.jpg", "Jugo Hit", 4500f, null },
                    { 4, true, 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Jugo Natural de Matacuya", "https://images.pexels.com/photos/4958875/pexels-photo-4958875.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Jugo Maracuya", 8000f, null },
                    { 5, true, 1, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Carne 150gr - Queso - vegetales", "https://images.pexels.com/photos/1639557/pexels-photo-1639557.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Hamburguesa Secilla", 15000f, null },
                    { 6, true, 1, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "Salchicha Americana", "https://images.pexels.com/photos/4676419/pexels-photo-4676419.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Perro Caliente", 12000f, null }
                });

            migrationBuilder.InsertData(
                table: "TableRestaurants",
                columns: new[] { "TableRestaurantId", "Available", "Capacity", "CreatedAt", "CreatedBy", "Number", "RestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, 6, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "A-1", 1, null },
                    { 2, true, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "A-2", 1, null },
                    { 3, true, 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "A-3", 1, null },
                    { 4, true, 5, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", "A-4", 1, null }
                });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "OrderCustomerId", "Amount", "CreatedAt", "CreatedBy", "CustomerId", "OrderTime", "TableRestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 3, new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 4, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 5, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 6, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 1, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 7, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 8, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 7, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 9, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 10, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 3, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 11, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 12, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 7, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 13, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 6, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 14, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 6, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 15, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 8, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 16, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 17, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 18, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 19, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 20, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 8, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 21, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 5, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 22, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 5, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 23, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 1, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 24, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 7, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 25, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 26, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 1, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 27, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 8, new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 28, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 29, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 30, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 1, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 31, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 32, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 33, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 5, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 34, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 35, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 5, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 36, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 37, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 8, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 38, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 7, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 39, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 5, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 40, 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CreatedAt", "CreatedBy", "OrderCustomerId", "PriceProduct", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 18, 40468f, 1, null },
                    { 2, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 8, 68857f, 3, null },
                    { 3, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 37, 48650f, 1, null },
                    { 4, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 19, 76417f, 1, null },
                    { 5, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 31, 56505f, 3, null },
                    { 6, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 15, 83228f, 2, null },
                    { 7, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 13, 74014f, 5, null },
                    { 8, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 20, 19336f, 4, null },
                    { 9, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, 28295f, 4, null },
                    { 10, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 17, 64514f, 2, null },
                    { 11, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 24, 47870f, 2, null },
                    { 12, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, 17613f, 5, null },
                    { 13, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 39, 40239f, 5, null },
                    { 14, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 32, 43821f, 5, null },
                    { 15, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 39, 71045f, 4, null },
                    { 16, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 20, 19009f, 5, null },
                    { 17, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 18, 83340f, 5, null },
                    { 18, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 30, 60376f, 4, null },
                    { 19, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 11, 39212f, 5, null },
                    { 20, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, 38211f, 3, null },
                    { 21, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 23, 26345f, 4, null },
                    { 22, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 20, 69511f, 1, null },
                    { 23, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 34, 52971f, 5, null },
                    { 24, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 24, 31371f, 5, null },
                    { 25, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 23, 26074f, 4, null },
                    { 26, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 28, 31070f, 2, null },
                    { 27, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 35, 66739f, 2, null },
                    { 28, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 18, 86000f, 1, null },
                    { 29, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 39, 38361f, 2, null },
                    { 30, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 13, 63627f, 4, null },
                    { 31, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, 60511f, 2, null },
                    { 32, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 35, 47124f, 3, null },
                    { 33, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 4, 84570f, 2, null },
                    { 34, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 25, 38760f, 4, null },
                    { 35, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 39, 67394f, 2, null },
                    { 36, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 39, 55588f, 5, null },
                    { 37, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 9, 92749f, 1, null },
                    { 38, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 17, 80194f, 5, null },
                    { 39, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 31, 51691f, 4, null },
                    { 40, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 5, 88667f, 5, null },
                    { 41, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 33, 78145f, 1, null },
                    { 42, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 21, 68756f, 4, null },
                    { 43, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 2, 78885f, 2, null },
                    { 44, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 27, 83656f, 5, null },
                    { 45, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 7, 64633f, 2, null },
                    { 46, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 8, 89680f, 2, null },
                    { 47, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 24, 62291f, 5, null },
                    { 48, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 39, 93243f, 3, null },
                    { 49, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 6, 15337f, 5, null },
                    { 50, new DateTime(2024, 8, 15, 17, 42, 55, 336, DateTimeKind.Utc).AddTicks(6636), "Yuleiny", 37, 16300f, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OrderCustomerId",
                table: "Invoices",
                column: "OrderCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductId",
                table: "Invoices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustomers_CustomerId",
                table: "OrderCustomers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustomers_TableRestaurantId",
                table: "OrderCustomers",
                column: "TableRestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RestaurantId",
                table: "Reservations",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_TableRestaurants_RestaurantId",
                table: "TableRestaurants",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "OrderCustomers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TableRestaurants");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
