namespace MindBlown
{
    public interface IDerivedExpression
    {
        MathExpression Expression { get; set; }
        
        int DeriveLevel { get; set; } 
    }
}