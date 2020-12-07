using System.ComponentModel.DataAnnotations;

namespace PXUK16.Web.Models.Update
{
    public class UpdateManufactory
    {
        public int ManufactoryId { get; set; }

        [Display(Name = "Manafactory Name")]
        [Required(ErrorMessage = "Manafactory Name is required.")]
        public string Name { get; set; }
    }
}
