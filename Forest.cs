namespace HelloWorld
{
    class Forest
    {
        public string? name;
        public string? biome;
        public int trees;
        public int age;

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

    }
}
