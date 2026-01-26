//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ClgApp
{
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Branch { get; set; }
        [Required]

        public string College {  get; set; }
        [Required]

        public string City {  get; set; }
        [Required]

        public string state {  get; set; }
    }
}
