using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Labs_06.models
{
    [Table("Brand")]
    internal class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Required]
        [StringLength(30)]
        public string BrandName { get; set; }

        public List<Product> Products { get; set; }
    }
}
