using DAL.Interfaces;
using System;

namespace DAL.DTO
{
    public class DTOOrder 
    {
        public int Id { get; set; }
        public int ToyID { get; set; }
        public int CustomerID { get; set; }
        public DateTime order_date { get; set; }
    }
}
