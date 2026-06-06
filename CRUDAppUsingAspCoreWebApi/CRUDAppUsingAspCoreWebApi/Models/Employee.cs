using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingAspCoreWebApi.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string married { get; set; }
        [Required]
        public int salary { get; set; }
        [Required]
        public string department { get; set; }
        [Required]
        public string descrption { get; set; }
        }

    }
