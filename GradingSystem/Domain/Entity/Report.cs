﻿using Domain.MetaData;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Domain.Entity
{
    [MetadataType(typeof(ReportMetaData))]
    public partial class Report
    {
        public int Id { get; set; }
        public int IdLaboratoryWork { get; set; }
        public string Content { get; set; }
        public int? TestGrade { get; set; }
        public int? WorkGrade { get; set; }

        public virtual LaboratoryWork IdLaboratoryWorkNavigation { get; set; }
    }
}
