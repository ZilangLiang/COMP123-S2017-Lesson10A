using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 18, 2017
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * and implements the IHasMalice interface
 * Version: 0.3 - refactored - removed the ITrainable Interface
 */

namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the SuperVillain Class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }

        // CONSTRUCTORS 

        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }

        
        public override void Trains()
        {
            Console.WriteLine("Not Implemented");
        }
        

    }
}