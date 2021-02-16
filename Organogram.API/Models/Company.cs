using System.Collections.Generic;

namespace ASP_React.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<Branch> Branches { get; set; }
    }
}