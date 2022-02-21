using System.ComponentModel.DataAnnotations;

namespace hadik_api
{
    public class HadikParts
    {
        [Key]

        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
