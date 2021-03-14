using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        
        public int BrandId { get; set; }
       
        public int ColorId { get; set; }
       
        public int CarId { get; set; } //PrimaryKey
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        

    }
}
