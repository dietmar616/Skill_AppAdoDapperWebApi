using DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SQLOrder: IEntity<int>
    {
        public int Id { get; set; }
        public int ToyID { get; set; }
        public int CustomerID { get; set; }
        public DateTime order_date { get; set; }

        public  SQLCustomer SQLCustomer { get; set; }


        public SQLToy SQLToy { get; set; }

        public Users Users { get; set; }
    }
}
