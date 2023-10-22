using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKArtDAL.Models
{
    public class Category
    {
        public Category() {
        Products =new HashSet<Product>();
        }
        public byte categoryId { get; set; }
        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
