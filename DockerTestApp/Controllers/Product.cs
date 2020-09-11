using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DockerTestApp.Controllers
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}