using System.ComponentModel.DataAnnotations;

namespace MyWebsiteMvc.Models
{
    public class ListOne
    {
        [Key]
        public int ID { get; set; }

        [Required]

        public string ItemName { get; set; }

        [Required]
        public string Title {  get; set; }

        [Required]
        public string Description { get; set; }




    }
}
