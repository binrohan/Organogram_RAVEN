using System.Collections.Generic;

namespace ASP_React.Models
{
    public class ProductionUnit
    {
        public int Id { get; set; }
        public string ProductionUnitName { get; set; }
        public List<Section> Sections { get; set; }
    }
}