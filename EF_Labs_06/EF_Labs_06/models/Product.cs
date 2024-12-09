using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Labs_06.models
{
    [Table("Product")]
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int productId { get; set; }

        [Required]
        [StringLength(50)]
        public string productName { get; set; }

        [Required]
        [StringLength(15)]
        public string Quantity {  get; set; }

        [Required]
        public decimal price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int BrandId { get; set; }

        [Required]
        public int productTyped {  get; set; }


        //Np
        public Category categpry { get; set; }
        public Brand brand { get; set; }
        public ProductType productType { get; set; }
    }
}
