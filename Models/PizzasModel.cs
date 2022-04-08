﻿namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public float FinalPrice { get; set; }

        // Topping Choice Props
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperonni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
    }
}
