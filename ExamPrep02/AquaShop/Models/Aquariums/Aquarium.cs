using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private Aquarium()
        {
            this.Decorations = new HashSet<IDecoration>();
            this.Fish = new HashSet<IFish>();
        }
        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        private string name;
        public string Name
        {
            get 
            { 
                return name; 
            }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }
                name = value; 
            }
        }

        public int Capacity { get; }

        public int Comfort => this.Decorations.Sum(x => x.Comfort);

        public ICollection<IDecoration> Decorations { get; }

        public ICollection<IFish> Fish { get; }

        public void AddDecoration(IDecoration decoration)
        {
            this.Decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (this.Fish.Count + 1 > this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            this.Fish.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in this.Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            var sb = new StringBuilder();
            string fishOutput = this.Fish.Count > 0 ? String.Join(", ", this.Fish.Select(f => f.Name)) : "none";
            sb
                .AppendLine($"{this.Name} ({this.GetType().Name}):")
                .AppendLine($"Fish: {fishOutput}")
                .AppendLine($"Decorations: {this.Decorations.Count()}")
                .AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString();
        }

        public bool RemoveFish(IFish fish) => this.Fish.Remove(fish);
    }
}
