
using DAL.Interfaces;
using DAL.Models;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    namespace DAL.Models
{ 
    public partial class Users : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Users() { }

        public IEnumerable<SQLOrder> SQLOrder { get; set; }
    }
}
