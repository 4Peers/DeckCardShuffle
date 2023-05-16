﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Card
    {
        public Card(string name, string suit)
        {
            this.Name = name;
            this.Suit = suit;
        }

        public string? Name { get; }
        public string? Suit { get; }

        public override string ToString()
        {
            return ($"{Suit} Card: {Name}");
        }
    }
}
