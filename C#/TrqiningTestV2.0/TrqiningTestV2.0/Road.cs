﻿using System;


namespace TrqiningTestV2._0
{
    public sealed class Road
    {
    public string Number { get; set; }
        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"Дорога {Number} протяженность {Lenght}";
        }
    }
}
