using System;

namespace BuilderPattern
{
    internal class Director
    {
        public void Construct(Builder builder, string[] args)
        {
            builder.AddCpu(args[0])
                .AddRam(Convert.ToInt32(args[1]))
                .AddHd(Convert.ToInt32(args[2]))
                .AddGraphicsCard(args[3]);  
        }
    }
}