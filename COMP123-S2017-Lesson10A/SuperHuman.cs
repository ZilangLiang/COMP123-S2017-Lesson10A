using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: This is the SuperHuman sub class.
 * Version: 0.7 - Added the GetPowerRank method
 */

namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the SuperHuman sub class.
    /// It inherits from the Human Superclass.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FIELDS
        private List<Power> _powers;

        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // returns a reference to the Powers List
            }
        }


        // CONSTRUCTORS
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes and assigns default values to Class Fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }

        /// <summary>
        /// This private method returns the index of the Power Name in the Powers List if found.
        /// If not found it returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns>This returns an integer related to the index of the Powers List</returns>
        private int _findPowerIndex(string name)
        {
            int index = 0;

            foreach (Power power in this.Powers)
            {
                if(name.Equals(power.Name))
                {
                    break;
                }

                index++;

                if(this.Powers.Count == index)
                {
                    index = -1;
                }
            }

            return index;
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method adds a Power to the Power List
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        public void DisplayPowers()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("Name: " + power.Name + " Rank: " + power.Rank);
            }
        }

        /// <summary>
        /// This method returns the power Rank Number of the Power in the Power List
        /// </summary>
        /// <param name="name"></param>
        /// <returns>This returns the Power Rank Number or 0 if the power is not found</returns>
        public Power GetPower(string name)
        {
            if (this._findPowerIndex(name) != -1)
            {
                return this.Powers[this._findPowerIndex(name)];
            }

            return new Power("Unknown Power", 0);
        }

        // PUBLIC OVERRIDDEN METHODS

        /// <summary>
        /// Overridden the built-in ToString method
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "=====================================\n";
            outputString += "SuperHuman Name: " + this.Name + "\n";
            outputString += "=====================================\n";

            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }

            outputString += "=====================================\n";

            return outputString;
        }

        /// <summary>
        /// This is the DisplaySkills Method.
        /// NEEDS TO BE IMPLEMENTED...
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented!");
        }

        
        public override void Trains()
        {
            Console.WriteLine("To Be Implemented in Subclass");
        }
        

    }
}