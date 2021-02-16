using System.Collections.Generic;

namespace ASP_React.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public List<Department> Departments { get; set; }
    }
}