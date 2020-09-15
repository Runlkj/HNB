using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicNB.AAs.Dto
{
    public class CreateUpdateAADto:EntityDto<int>
    {
        public int AAId { get; set; }

        [Required]
        public int MyProperty1 { get; set; }
        [Required]
        public int MyProperty2 { get; set; }
        [Required]
        public DateTime MyProperty3 { get; set; } = DateTime.Now;
        public int MyProperty4 { get; set; }
    }
}
