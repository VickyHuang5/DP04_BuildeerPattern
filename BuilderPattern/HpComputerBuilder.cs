namespace BuilderPattern
{
    internal class HpComputerBuilder : Builder
    {
        private readonly Computer Product = new Computer();

        public HpComputerBuilder()
        {
            this.AddMb();
        }

        public override Builder AddRam(int size)
        {
            this.Product.Add($"RAM:{size}G");
            return this;
        }

        public override Builder AddCpu(string model)
        {
            this.Product.Add($"CPU:{model}");
            return this;
        }

        public override Builder AddHd(int size)
        {
            this.Product.Add($"HD:{size}G");
            return this;
        }

        public override Builder AddGraphicsCard(string model)
        {
            this.Product.Add($"Graphics Card:{model}");
            return this;
        }

        private Builder AddMb()
        {
            this.Product.Add($"Mother Board:HP");
            return this;
        }

        public override Computer GetComputer()
        {
            return this.Product;
        }
    }
}