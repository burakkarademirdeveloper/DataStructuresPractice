public class ToDo
{
    public string Describe { get; set; }
    public Double Time { get; set; }
    public override string ToString()
    {
        return $"{Describe,-50} {Time,-10}";
    }
}