﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodChainBrandsNetCore
{
    public class FoodChainModel
    {
        public int Id { get; set; }
        [Required]
        public string FoodChainName { get; set; }
        public string FoodChainLogoURL { get; set; }
        public  string Description{ get; set; }
    }
}
