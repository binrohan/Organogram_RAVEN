using System.Collections.Generic;

namespace ASP_React.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public List<Line> Lines { get; set; }
    }
}