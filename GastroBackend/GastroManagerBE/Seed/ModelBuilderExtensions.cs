using GastroManagerBE.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroManagerBE.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var random = new Random();
            var start = new DateTime(1995, 1, 1);
            var startYear = new DateTime(2024, 1, 1);
            var range = (DateTime.Today - start).Days;
            var daysOfYear = (DateTime.Today - startYear).Days;
            var id = 1;
            var _CratedBy = "Yuleiny";
            var _CreatedAt = DateTime.UtcNow.AddHours(-5);

            #region Categoria
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    Name = "Fritos",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Bebidas",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region Customer
            id = 1;
            var fakerCustomer = new Bogus.Faker<Customer>()
               .RuleFor(x => x.CustomerId, f => id++)
               .RuleFor(x => x.Name, f => f.Person.FullName)
               .RuleFor(x => x.NumberPhone, f => f.Person.Phone)
               .RuleFor(x => x.Email, f => f.Person.Email)
               .RuleFor(x => x.BirthdayDate, f => f.Person.DateOfBirth)
               .RuleFor(x => x.CreatedAt, _CreatedAt)
               .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var add in fakerCustomer.Generate(10))
                modelBuilder.Entity<Customer>().HasData(add);
            #endregion

            #region Product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    Name = "Cocacola",
                    Description = "Bebida con sabor a cola",
                    Image = "https://images.pexels.com/photos/4389680/pexels-photo-4389680.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Available = true,
                    CategoryId = 2,
                    Price = 3500,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Manzana",
                    Description = "Gaseosa Postobon",
                    Image = "https://mandalomarket.com/wp-content/uploads/2024/01/refresco1.jpg",
                    Available = true,
                    CategoryId = 2,
                    Price = 4000,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Jugo Hit",
                    Description = "Jugo de sabor Naranja",
                    Image = "https://vixark.b-cdn.net/lp-i-i-g/jugo-de-naranja-hit-1000ml.jpg",
                    Available = true,
                    CategoryId = 2,
                    Price = 4500,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Jugo Maracuya",
                    Description = "Jugo Natural de Matacuya",
                    Image = "https://images.pexels.com/photos/4958875/pexels-photo-4958875.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Available = true,
                    CategoryId = 2,
                    Price = 8000,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Product()
                {
                    ProductId = 5,
                    Name = "Hamburguesa Secilla",
                    Description = "Carne 150gr - Queso - vegetales",
                    Image = "https://images.pexels.com/photos/1639557/pexels-photo-1639557.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Available = true,
                    CategoryId = 1,
                    Price = 15000,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Product()
                {
                    ProductId = 6,
                    Name = "Perro Caliente",
                    Description = "Salchicha Americana",
                    Image = "https://images.pexels.com/photos/4676419/pexels-photo-4676419.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Available = true,
                    CategoryId = 1,
                    Price = 12000,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region Restaurant
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant()
                {
                    RestaurantId = 1,
                    Name = "La casa Familiar",
                    Address = "Ibague - Tolima",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Restaurant()
                {
                    RestaurantId = 2,
                    Name = "El sabor de la Calle",
                    Address = "Cartagena - Bolivar",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new Restaurant()
                {
                    RestaurantId = 3,
                    Name = "El sabor de la Calle",
                    Address = "Cartagena - Bolivar",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region TableRestaurant
            modelBuilder.Entity<TableRestaurant>().HasData(
                new TableRestaurant() 
                {
                    TableRestaurantId = 1,
                    RestaurantId = 1,
                    Available = true,
                    Capacity = 6,
                    Number = "A-1",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new TableRestaurant()
                {
                    TableRestaurantId = 2,
                    RestaurantId = 1,
                    Available = true,
                    Capacity = 4,
                    Number = "A-2",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new TableRestaurant()
                {
                    TableRestaurantId = 3,
                    RestaurantId = 1,
                    Available = true,
                    Capacity = 2,
                    Number = "A-3",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new TableRestaurant()
                {
                    TableRestaurantId = 4,
                    RestaurantId = 1,
                    Available = true,
                    Capacity = 5,
                    Number = "A-4",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region OdernCustomer
            id = 1;
            var fakerOrdenCustomer = new Bogus.Faker<OrderCustomer>()
               .RuleFor(x => x.OrderCustomerId, f => id++)
               .RuleFor(x => x.Amount, random.Next(1,8))
               .RuleFor(x => x.OrderTime, f => startYear.AddDays(random.Next(15,180)))
               .RuleFor(x => x.CustomerId, f => random.Next(1,10))
               .RuleFor(x => x.TableRestaurantId, f => random.Next(1,4))
               .RuleFor(x => x.CreatedAt, _CreatedAt)
               .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var add in fakerOrdenCustomer.Generate(40))
                modelBuilder.Entity<OrderCustomer>().HasData(add);
            #endregion

            #region Invoice
            id = 1;
            var fakerInvoice = new Bogus.Faker<Invoice>()
               .RuleFor(x => x.InvoiceId, f => id++)
               .RuleFor(x => x.PriceProduct, f => id++)
               .RuleFor(x => x.OrderCustomerId, f => random.Next(1, 40))
               .RuleFor(x => x.ProductId, f => random.Next(1, 6))
               .RuleFor(x => x.PriceProduct, f => random.Next(15000, 100000))
               .RuleFor(x => x.CreatedAt, _CreatedAt)
               .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var add in fakerInvoice.Generate(50))
                modelBuilder.Entity<Invoice>().HasData(add);
            #endregion

            #region User
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = 1,
                    Username = "Yule",
                    Email = "yule@gmail.com",
                    Password = "abcd",
                    Role = "Admin",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new User()
                {
                    UserId = 2,
                    Username = "user",
                    Email = "user@gmail.com",
                    Password = "1234",
                    Role = "User",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

        }
    }
}
