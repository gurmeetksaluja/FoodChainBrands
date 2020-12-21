using System;
using System.Collections.Generic;
using System.Text;

namespace FoodChainBrands.Core
{
    public class FoodChainBrands
    {
        public int Id { get; set; }
        public string FoodChainName { get; set; }
        public string FoodChainLogoURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
