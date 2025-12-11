namespace Submarine
{
    internal class FuelDiesel : Fuel
    {
        public override string Type
        {
            get { return "Diesel"; }
        }

        public override string GetType()
        {
            return Type;
        }

        protected override double density
        {
            get { return 1250; }
        }
    }
}