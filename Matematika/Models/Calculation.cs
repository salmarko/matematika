namespace Matematika.Models
{
    public class Calculation
    {
        public int NumberA { get; set; }
        public int NumberB { get; set; }
        public decimal Answer { get; set; }
        public int PageNumber { get; internal set; }
        public int CurrentScore { get; internal set; }

        public Calculation(int numberA, int numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }

        public int Multiply()
        {
            return NumberA * NumberB;
        }
    }
}
