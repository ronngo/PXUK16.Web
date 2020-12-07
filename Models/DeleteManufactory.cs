using System.ComponentModel.DataAnnotations;

namespace PXUK16.Web.Models.Delete
{
    public class DeleteManufactory
    {
        [Display(Name = "Manafactory Id")]
        [Required(ErrorMessage = "Manafactory Id is required.")]
        public int ManufactoryId { get; set; }
    }
}
