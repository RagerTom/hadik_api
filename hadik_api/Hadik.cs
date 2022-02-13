namespace hadik_api
{
    public class Hadik
    {
        public int SavedScore { get; set; }
    
        public int SavedSnakeLenght { get; set; }

        public int SavedSnakePosX { get; set; }

        public int SavedSnakePosY { get; set; }

        public int SavedVelocityX { get; set; }

        public int SavedVelocityY { get; set; }

        public IEnumerable<HadikParts> SavedTail { get; set; }
    }

    public record HadikParts
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
