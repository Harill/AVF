
namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class ChestModel
    {
        public int ChestId { get; set; }
        public string ChestName { get; set; }
        public string Description { get; set; }
        public bool ToolActive { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}