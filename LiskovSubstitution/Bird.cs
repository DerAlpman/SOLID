namespace SOLID.LiskovSubstitution
{
    internal class Bird : Animal
    {
        public override string MakeNoise()
        {
            return this.GetType().Name + " chirps";
        }

        public override string Fly()
        {
            return this.GetType().Name + " flags wings";
        }
    }
}
