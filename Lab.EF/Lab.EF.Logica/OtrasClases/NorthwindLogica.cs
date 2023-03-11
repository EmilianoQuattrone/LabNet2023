namespace Lab.EF.Data
{
    public abstract class NorthwindLogica
    {
        protected readonly NorthwindContext northwindContext;

        public NorthwindLogica()
        {
            northwindContext = new NorthwindContext();
        }
    }
}