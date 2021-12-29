using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Model
{
    public class ItemMaster
    {
        //Data Annotations 
        public int Id { get; set; }
        [Required(ErrorMessage = "Item Name Required")]
        [MaxLength(50)]
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public bool Status { get; set; }
    }
}
