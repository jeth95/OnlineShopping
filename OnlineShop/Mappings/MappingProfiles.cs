using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using OnlineShop.ViewModels;
using OnlineShop.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace OnlineShop.Mappings
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles ()
        {
            CreateMap<Product, ProductViewModel>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(product =>
                    product.Images,
                    opt => opt.Ignore());
        }

        //private string[] Split(string value)
        //{
        //    return value.Split(";");
        //}
    }
}
