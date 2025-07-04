﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Project2144.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2144.Products.Dto
{
    public class ProductDto : EntityDto<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
