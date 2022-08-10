
namespace ADhoc.Entities
{
    public class URI1171    
    {
        public int Number { get; set; }
        public int TotalNumber { get; set;}
        public int CountNumber {get; set;}
        public List<URI1171> NumbersList = new List<URI1171>();
        public URI1171(int number)
        {
            this.Number = number;
        }
        
    }
}