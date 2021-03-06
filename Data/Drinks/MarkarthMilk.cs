﻿/*
 * Author: Nick Ruffini
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Drink Markarth Milk!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.05;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 56;
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        /// <summary>
        /// Represents the size of the drink
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
                    price = 1.05;
                    calories = 56;
                }
                else if (value == Size.Medium)
                {
                    price = 1.11;
                    calories = 72;
                }
                else
                {
                    price = 1.22;
                    calories = 93;
                }
            }
        }

        /// <summary>
        /// Represents ice in the drink
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                if (value == true)
                {
                    specialInstructions.Add("Add ice");
                }
                else
                {
                    specialInstructions.Remove("Add ice");
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
            return String.Format("{0} Markarth Milk", size.ToString());
        }
    }
}
