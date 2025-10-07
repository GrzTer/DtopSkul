public class City
{
    public string Name { get; set; }
    public int Offset { get; set; }

    public override string ToString()
    {
        return $"{Name} (UTC{(Offset >= 0 ? "+" : "")}{Offset})";
    }
}