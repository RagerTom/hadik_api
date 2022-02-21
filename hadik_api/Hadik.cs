using System.ComponentModel.DataAnnotations;

namespace hadik_api
{
    public class Hadik
    {
        [Key]

        public int Id { get; set; } 
        public int SavedScore { get; set; }
        public int SavedSnakeLenght { get; set; }

        public int SavedSnakePosX { get; set; }

        public int SavedSnakePosY { get; set; }

        public int SavedVelocityX { get; set; }

        public int SavedVelocityY { get; set; }
    }
}
