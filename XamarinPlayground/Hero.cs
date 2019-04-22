using System;
namespace XamarinPlayground
{
    public class Hero
    {
        public Hero(string name, string logo)
        {
            Name = name;
            Logo = logo;
        }

        public string Name { get; }
        public string Logo { get; }
        public string Image { get; }
    }
}
