using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public class ReportMetaData
    {
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "По какой работе сделан отчет")]
        public int IdLaboratoryWork { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Отчет")]
        [FileExtensions(Extensions = ".docs", ErrorMessage = "Неподдерживаемый тип файла")]
        public string Content { get; set; }

        [Display(Name = "Оценка за тест")]
        [Range(0, 5, ErrorMessage = "Градация оценки: от {0} до {1}")]
        public int? TestGrade { get; set; }

        [Display(Name = "Оценка за выполнение работы")]
        [Range(0, 5, ErrorMessage = "Градация оценки: от {0} до {1}")]
        public int? WorkGrade { get; set; }
    }
}
