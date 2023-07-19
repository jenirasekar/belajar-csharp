namespace HelloWorld
{
    class Forest
    {
        public string? name;
        public string? biome;
        public int trees;
        public int age;
        // static field
        private static int forestsCreated;
        private static string treeFacts;


        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            // Age = 0;
            ForestsCreated += 1;
        }

        // static property
        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Trees
        {
            get { return trees; }
            set { trees = value; }
        }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }

            }
        }

        // automatic property
        // public string Name
        // { get; set; }

        // public int Trees
        // {
        //     get;
        //     set;
        // }

        public static string TreeFacts
        {
            get { return treeFacts; }
        }
        static Forest()
        {
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
            ForestsCreated = 0;
        }
        public static void PrintTreeFacts()
        {
            Console.WriteLine(TreeFacts);
        }

    }
}
