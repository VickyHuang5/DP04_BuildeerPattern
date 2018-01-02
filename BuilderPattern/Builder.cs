namespace BuilderPattern
{
    internal abstract class Builder
    {
        public abstract Builder AddRam(int size);

        public abstract Builder AddCpu(string type);

        public abstract Builder AddHd(int size);

        public abstract Builder AddGraphicsCard(string model);

        public abstract Computer GetComputer();
    }
}