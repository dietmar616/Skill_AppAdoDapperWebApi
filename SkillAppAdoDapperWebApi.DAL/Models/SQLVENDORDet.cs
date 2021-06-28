using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SQLVENDORDet : IEntity<int>
    {
        public int Id { get; set; }
        public string Individ_or_legal_entity { get; set; }
        public string Phone { get; set; }

        public IEnumerable<SQLVendor> SQLVendor { get; set; }
    }
}
