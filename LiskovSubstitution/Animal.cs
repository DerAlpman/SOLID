namespace SOLID.LiskovSubstitution
{
    internal class Animal
    {
        public string Walk()
        {
            return this.GetType().Name + " moves feet";
        }

        public string Run()
        {
            return this.GetType().Name + " moves feet quickly";
        }

        public virtual string Fly()
        {
            return null;
        }

        public virtual string MakeNoise()
        {
            return null;
        }
    }
}
