using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SQLTOYDet : IEntity<int>
    {
    
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<SQLToy> SQLToy { get; set; }

    }
}
