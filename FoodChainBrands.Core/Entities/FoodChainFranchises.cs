using System;
using System.Collections.Generic;
using System.Text;

namespace FoodChainBrands.Core
{
    public class FoodChainFranchises
    {
        public int Id { get; set; }
        public int FoodChainId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
