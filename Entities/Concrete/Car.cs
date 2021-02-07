using System;
namespace Entities.Concrete
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public double RentPrice { get; set; }
        public string Description { get; set; }
    }
}
