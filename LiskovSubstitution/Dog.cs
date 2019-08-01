namespace SOLID.LiskovSubstitution
{
    internal class Dog : Animal
    {
        public override string MakeNoise()
        {
            return this.GetType().Name + " barks";
        }
    }
}
