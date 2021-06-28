using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SQLCustomer : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? middle_name { get; set; }
        public string Phone { get; set; }
        public IEnumerable<SQLOrder> SQLOrder { get; set; }
    }
}
