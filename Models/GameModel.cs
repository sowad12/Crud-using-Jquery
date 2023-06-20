using System.ComponentModel.DataAnnotations;

namespace Game.Model
{
    public class GameModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String Name { get; set; }
     
        public String Type { get; set; }
    
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

		
	}
}
