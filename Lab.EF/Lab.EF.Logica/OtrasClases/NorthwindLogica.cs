namespace Lab.EF.Data
{
    public abstract class NorthwindLogica
    {
        protected NorthwindContext northwindContext;

        public NorthwindLogica()
        {
            northwindContext = new NorthwindContext();
        }
    }
}