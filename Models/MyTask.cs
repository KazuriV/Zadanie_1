using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PD1_PZ_109602_202103.Models
{
    public class MyTask
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Nazwa zadania")]
        public string TaskName { get; set; }
        [Display(Name = "Opis zadania")]
        public string Description { get; set; }
        [Display(Name = "Gotowe")]
        public bool Done { get; set; }

    }
}
