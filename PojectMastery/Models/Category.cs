﻿namespace PojectMastery.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }

        public Category() {}
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
