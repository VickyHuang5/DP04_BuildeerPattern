namespace BuilderPattern
{
    internal class AsusComputerBuilder : Builder
    {
        private readonly Computer Product = new Computer();

        public AsusComputerBuilder()
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
            this.Product.Add($"Mother Board:Asus");
            return this;
        }

        public override Computer GetComputer()
        {
            return this.Product;
        }
    }
}