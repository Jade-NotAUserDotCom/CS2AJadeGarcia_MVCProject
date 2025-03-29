
using System.ComponentModel.DataAnnotations;

namespace CS2AJadeGarcia_MVCProject.BusLogic.Model
{
    public class TblStudent
    {
        [Key]
        public int ID { get; set; }

        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int? age { get; set; }
        public string? course { get; set; }
    }
}
