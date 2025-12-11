namespace Submarine
{
    internal class FuelNuclear : Fuel
    {
        public override string Type
        {
            get
            {
                return "Nuclear";
            }
        }
        public override string GetType()
        {
            return Type;
        }

        protected override double density
        {
            get { return 1000; }
        }
    }
}