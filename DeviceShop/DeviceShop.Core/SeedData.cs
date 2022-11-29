using DeviceShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceShop.Core
{
    public class SeedData
    {
         public static void SeedDatabase(DeviceShopContext context)
        {
            context.Database.Migrate();
            if (!context.Devices.Any())
            {
                Category iphones = new Category { Name = "iphones" };
                Category airPods = new Category { Name = "AirPods" };

                context.Devices.AddRange(
                    new Device
                    {
                        Title = "Iphone 11",
                        Price = 800,
                        Description = "New",
                        Rating = 4,
                        Image = "img/device/iphone.jpg",
                        Category = iphones
                    },
                    new Device
                    {
                        Title = "Air Pods",
                        Price = 300,
                        Description = "New",
                        Rating = 5,
                        Image = "img/device/AirPods.jpg",
                        Category = airPods
                    },
                    new Device
                    {
                        Title = "Iphone 13",
                        Price = 1000,
                        Description = "New",
                        Rating = 4,
                        Image = "img/device/Apple_iphone13.jpg",
                        Category = iphones
                    },
                    new Device
                    {
                        Title = "Air Pods Pro",
                        Price = 400,
                        Description = "New",
                        Rating = 5,
                        Image = "img/device/AirPods.jpg",
                        Category = airPods
                    });

                context.SaveChanges();
            }
                
        }
    }
}
