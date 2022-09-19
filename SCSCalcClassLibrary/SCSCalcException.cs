namespace SCSCalcClassLibrary
{
    public class SCSCalcException : Exception
    {
        public SCSCalcException()
        {
        }

        public SCSCalcException(string message)
            : base(message)
        {
        }

        public SCSCalcException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
