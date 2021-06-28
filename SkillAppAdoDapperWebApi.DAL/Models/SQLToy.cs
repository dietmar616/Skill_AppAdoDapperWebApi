using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SQLToy : IEntity<int>
    {
        public int Id { get; set; }
        public int VendorID { get; set; }
        public string Name { get; set; }

        public IEnumerable<SQLOrder> SQLOrder { get; set; }

        public IEnumerable<SQLTOYDet> SQLTOYDet { get; set; }
    }
    
    
}
