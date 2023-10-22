using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKArtDAL.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MinLength(1),MaxLength(50)]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName="Numeric(8)")]
        public decimal Price { get; set; }

        [ForeignKey("CategoryId")]
        public byte CategoryId { get; set; }
        [Required]
        public int QuantityAvailable { get; set; }
        public Category Categories { get; set; }
    }
}
