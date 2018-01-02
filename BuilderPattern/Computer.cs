using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Computer
    {
        private IList<string> computerParts = new List<string>();

        public void Add(string part)
        {
            this.computerParts.Add((part));
        }

        public void Show()
        {
            foreach (string part in this.computerParts)
            {
                Console.WriteLine(part);
            }
        }
    }
}