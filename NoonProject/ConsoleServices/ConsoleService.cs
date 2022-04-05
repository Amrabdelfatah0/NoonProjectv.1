﻿using NoonProject.Consts;
using NoonProject.Models;
using NoonProject.Models.Addresss;
using NoonProject.Models.Category;
using NoonProject.Models.Users;
using NoonProject.Repository;
using NoonProject.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.ConsoleServices
{
    public static class ConsoleService
    {

        public static void UserDealing()
        {
            Console.WriteLine($"Welcome {ProjectDetails.ProjectName}\n" +
                $"{ProjectDetails.ProjectVersion}\n" +
                $"{ProjectDetails.ProjectDescription}\n\n");
            SeedDate();
            Console.WriteLine("Are you current user? true or false");
            bool IsCurrent = Convert.ToBoolean(Console.ReadLine());
            User user = new User();
            if (IsCurrent)
            {
                user = LoginForm();
                if (user.userRole.Name == Admin.AdminRole)
                {
                    AdminUserDealing(user);
                }
                else
                {
                    GeneralUserDealing(user);
                }
            }
            else
            {
                user = RegisterUser();
            }
        }

        private static void SeedDate()
        {
            UserService userService = new UserService();

            User user = new User();
            UserRoleService userRoleService = new UserRoleService();

            UserRole UserAmin = new UserRole();
            UserAmin.Name = Admin.AdminRole;
            userRoleService.Add(UserAmin);

            UserRole GeneralUser = new UserRole();
            GeneralUser.Name = "GeneralUser";
            userRoleService.Add(GeneralUser);

            if (!userService.IsExist(Admin.AdminName, Admin.AdminPassword))
            {
                user.UserName = Admin.AdminName;
                user.FirstName = Admin.AdminName;
                user.LastName = Admin.AdminName;
                user.Password = Admin.AdminPassword;
                user.ConfirmPassword = Admin.AdminPassword;
                user.Email = Admin.AdminEmail;
                user.UserRoleId = 1;
                userService.Add(user);
            }
            GovernroteService governroteService = new GovernroteService();
            Governrote governrote = new Governrote();
            governrote.Name = "Cairo";
            governroteService.Add(governrote);
        }

        private static User RegisterUser()
        {
            UserService userService = new UserService();
            User user = new User();
            for (; ; )
            {
                Console.WriteLine("please fill register form\n");

                Console.WriteLine("Insert your first name");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Insert your last name");
                user.LastName = Console.ReadLine();
                Console.WriteLine("Insert your email");
                user.Email = Console.ReadLine();
                Console.WriteLine("Insert your username");
                user.UserName = Console.ReadLine();
                Console.WriteLine("Insert your password");
                user.Password = Console.ReadLine();
                Console.WriteLine("Please Confirm password");
                user.ConfirmPassword = Console.ReadLine();
                user.UserRoleId = 2;
                
                userService.Add(user);
                user = userService.LogIn(user.UserName, user.Password);
                if (user == null)
                {
                    Console.WriteLine("Some thing is wrong please try again");
                }
                else
                {
                    Console.WriteLine($"you has been registered successfuly{user.FullName}");
                    break;
                }
            }
            return user;
        }
        private static void GeneralUserDealing(User user)
        {
            for (; ; )
            {
                if (user == null)
                {

                }
                else
                {
                    // search by filter
                    Console.WriteLine($"Hello {user.FullName}\n");
                    Console.WriteLine("Please insert number of action\n" +
                        "1. view products\n" +
                        "2.ViewProfile \n" +
                        "3. Add products \n"+
                       "4.update profile \n " +
                        "5.Close actions");
                    int ActionNumber = Convert.ToInt32(Console.ReadLine());
                    switch (ActionNumber)
                    {
                        case 1:
                            ViewProducts();
                            break;
                        case 2: ViewProfile(user);
                            break;
                        case 3: AddProduct();
                            break;
                        case 4: UpdateProfile(user);
                            break;
                        default:
                            break;
                    }
                    if (ActionNumber == 5)
                    {
                        break;
                    }
                }
            }
        }
        private static User LoginForm()
        {
            UserService userService = new UserService();
            User user;
            Console.WriteLine("Insert your username");
            string Username = Console.ReadLine();
            Console.WriteLine("Insert your password");
            string Password = Console.ReadLine();

            user = userService.LogIn(Username, Password);
            return user;
        }
        private static void AdminUserDealing(User user)
        {

            Console.WriteLine($"Wellcome {user.FullName}!");
            for (; ; )
            {
                // add attribute , add attribute option,add main category , add subcategory
                Console.WriteLine("Please choose number of action\n-----\n" +
                    "1.Display all product by category id\n" +
                    "2.Insert new product\n" +
                    "3.Active Product\n" +
                    "4.Dective Product\n" +
                    "5.Close actions");
                int Action = Convert.ToInt16(Console.ReadLine());

                switch (Action)
                {
                    case 1:
                        GetAllProduct();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        ActiveProduct();
                        break;
                    case 4:
                        DectiveProduct();
                        break;
                    default:
                        break;
                }
                if (Action == 5)
                {
                    break;
                }
            }
        }
        private static void ViewProfile(User user)
        {
            Console.WriteLine($"first name {user.FirstName}\n" +
                $"last name {user.LastName}\n" +
                $"user name {user.UserName}\n" +
                $"Email {user.Email}\n");
        }
        private static void UpdateProfile(User user)
        {
            ViewProfile(user);
        }

       
        private static void ViewProducts()
        {
            // discplay by category id
            ProductService productService = new ProductService();
            List<Product> products = productService.Get();
            foreach (var product in products)
            {
                DisplayProduct(product);
            }
        }
        private static void DectiveProduct()
        {
            Console.WriteLine("Insert product id ");
            int id = Convert.ToInt16(Console.ReadLine());
            IProduct productService = new ProductService();
            productService.Dective(id);
        }

        private static void ActiveProduct()
        {
            Console.WriteLine("Insert product id ");
            int id = Convert.ToInt16(Console.ReadLine());
            IProduct productService = new ProductService();
            productService.Active(id);
        }

        private static void AddProduct()
        {
            Product product = ProductForm();
            ProductService productService = new ProductService();
            productService.Add(product);

        }

        private static Product ProductForm()
        {
            Product product = new Product();
            Console.WriteLine("Isert name of product");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Isert price");
            product.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Isert Production date");
            product.ProductionDate = Convert.ToDateTime(Console.ReadLine());
            return product;
        }

        private static void GetAllProduct()
        {
            // get all main category : Category id and category name
            // please choose category id
            // get product by category id
            ProductService productService = new ProductService();
            List<Product> products = productService.GetAll();
            Console.WriteLine("All product\n_______________\n");
            foreach (Product product in products)
            {
                DisplayProduct(product, true);
            }
        }

        private static void DisplayProduct(Product product, bool IsAdmin = false)
        {
            if (IsAdmin)
            {
                Console.WriteLine($"id.{product.Id}\n" +
                    $"product name {product.ProductName}\n" +
                    $"price {product.Price}\n" +
                    $"display {product.IsDisplay}\n");
            }
            else
            {
                Console.WriteLine($"id.{product.Id}\n" +
                   $"product name {product.ProductName}\n" +
                   $"price {product.Price}\n\n");
            }
        }
        
    }
}


