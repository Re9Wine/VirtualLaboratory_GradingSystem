using System.Collections.Generic;

#nullable disable

namespace Domain.Entity
{
    public partial class LaboratoryWork
    {
        public LaboratoryWork()
        {
            Reports = new HashSet<Report>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Objective { get; set; }
        public string Test { get; set; }
        public string SampleReport { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
