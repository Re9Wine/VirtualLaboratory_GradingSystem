using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public class LaboratoryWorkMetaData
    {
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Название работы")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Название работы должна быть длинной от {0} до {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Номер")]
        [Range(1, 100, ErrorMessage = "Номер работы варируется от {0} до {1}")]
        public int Number { get; set; }

        [Display(Name = "Цель")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Цель работы должна быть длинной от {0} до {1}")]
        public string Objective { get; set; }

        [Display(Name = "Тест по теме")]
        [FileExtensions(Extensions = ".json", ErrorMessage = "Неподдерживаемый тип файла")]
        public string Test { get; set; }

        [Display(Name = "Образец отчета")]
        [FileExtensions(Extensions = ".docs", ErrorMessage = "Неподдерживаемый тип файла")]
        public string SampleReport { get; set; }
    }
}
