using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SQLVendor : IEntity<int>
    {
        public int Id { get; set; }
        public int ToyID { get; set; }

        public IEnumerable<SQLVENDORDet> SQLVENDORDet { get; set; }
    }
}
