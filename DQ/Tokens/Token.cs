namespace DQ.Tokens
{
    public abstract class Token
    {
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
    }
}
