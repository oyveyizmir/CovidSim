using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSim.Model2D.Walk
{
    public class AlternativeWalk : IWalkStrategy
    {
        public class Item
        {
            double probability = 1;

            public double Probability
            {
                get => probability;

                set
                {
                    if (value < 0 || value > 1)
                        throw new ArgumentException("Probability");
                    probability = value;
                }
            }

            public IWalkSettings Config { get; set; }
        }

        public class Settings : IWalkSettings
        {
            public List<Item> Items { get; private set; } = new List<Item>();

            public IWalkStrategy CreateWalkStrategy() => new AlternativeWalk(this);

            internal Item Last => Items[Items.Count - 1];

            public void Add(double probability, IWalkSettings settings)
            {
                Items.Add(new Item()
                {
                    Probability = probability,
                    Config = settings
                });
            }

            public void Validate()
            {
                if (Items.Count == 0)
                    throw new ValidationException("At lease one item is required");

                double prevProbability = double.MinValue;

                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items[i];
                    if (i < Items.Count - 1 && item.Probability <= prevProbability)
                        throw new ValidationException($"Probability {item.Probability} should be greater than previos value ({prevProbability})");
                    item.Config.Validate();
                    prevProbability = item.Probability;
                }
            }
        }

        public Settings Config { get; private set; } = new Settings();

        List<IWalkStrategy> walks = new List<IWalkStrategy>();

        public AlternativeWalk(Settings config) => Config = config;

        public void Initialize()
        {
            Config.Validate();
            Config.Last.Probability = 1;

            for (int i = 0; i < Config.Items.Count; i++)
            {
                IWalkStrategy walk = Config.Items[i].Config.CreateWalkStrategy();
                walks.Add(walk);
            }
        }

        public Point GetMoveVector()
        {
            double probability = RandomUtils.GetDouble();

            for (int i = 0; i < Config.Items.Count; i++)
                if (probability < Config.Items[i].Probability)
                    return walks[i].GetMoveVector();

            throw new InvalidOperationException("Did not find walk strategy");
        }
    }
}
