#nullable enable
namespace Common
{
    public class Card
    {
        public string? Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public override string ToString()
        {
            return $"Card => {Name}";
        }
    }
}