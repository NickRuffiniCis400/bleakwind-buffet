﻿/*
 * Author: Nick Ruffini
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Side Dragonborn Waffle Fries
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.42;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 77;
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        /// <summary>
        /// Represents the size of the side
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (value == Size.Small)
                {
                    price = 0.42;
                    calories = 77;
                }
                else if (value == Size.Medium)
                {
                    price = 0.76;
                    calories = 89;
                }
                else
                {
                    price = 0.96;
                    calories = 100;
                }
            }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>(specialInstructions);
            }
        }

        public override string ToString()
        {
            return String.Format("{0} Dragonborn Waffle Fries", size.ToString());
        }
    }
}

