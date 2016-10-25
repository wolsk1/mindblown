namespace MindBlown.Derive
{
    public class DerrivativeExpression
    {
        public DerrivativeExpression(
            string expression,
            string byVariable,
            int deriveLevel)
        {
            Expression = expression;
            ByVariable = byVariable;
            DeriveLevel = deriveLevel;
        }

        public string Expression { get; set; }

        public string ByVariable { get; set; }

        public int DeriveLevel { get; set; }
    }
}