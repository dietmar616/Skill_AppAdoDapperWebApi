using DAL.Interfaces;

namespace DAL.DTO
{
    public class DTOCustomer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? middle_name { get; set; }
        public string Phone { get; set; }
    }
}
