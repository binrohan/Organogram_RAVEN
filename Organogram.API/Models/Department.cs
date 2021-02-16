using System.Collections.Generic;

namespace ASP_React.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<ProductionUnit> ProductionUnits { get; set; }
    }
}