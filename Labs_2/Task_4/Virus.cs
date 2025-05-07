using System;
using System.Collections.Generic;

namespace Task_4
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public object Clone()
        {
            Virus clone = new Virus(Name, Species, Weight, Age);
            foreach (var child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }
            return clone;
        }

        public void PrintInfo(string indent = "")
        {
            Console.WriteLine($"{indent}Name: {Name}, Species: {Species}, Weight: {Weight} kg, Age: {Age} years");
            if (Children.Count > 0)
            {
                Console.WriteLine($"{indent}  Children:");
                foreach (var child in Children)
                {
                    child.PrintInfo(indent + "    ");
                }
            }
        }
    }
}


