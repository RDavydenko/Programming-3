using System;

namespace Lab
{
    // Абстрактный класс
    public abstract class Item
    {
        public abstract string Name { get; set; }

        public Item(string name)
        {
            Name = name;
        }
    }
}