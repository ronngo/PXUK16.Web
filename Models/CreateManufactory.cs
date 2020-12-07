using System.ComponentModel.DataAnnotations;

namespace PXUK16.Web.Models.Create
{
    public class CreateManufactory
    {
        [Display(Name = "Manafactory Name")]
        [Required(ErrorMessage = "Manafactory Name is required.")]
        public string Name { get; set; }

    }
}
