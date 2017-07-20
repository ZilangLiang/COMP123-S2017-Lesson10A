using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 20, 2017
 * Description: This is the AnitHero class.
 * It extends the SuperHuman class and implements both the IHasKarma and IHasMalice interfaces
 * Version: 0.3 - refactored - removed the ITrainable Interface
 */

namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the AntiHero class.
    /// </summary>
    public class AntiHero : SuperHuman, IHasKarma, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;
        private int _malice;

        // PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }

            set
            {
                this._karma = value;
            }
        }

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
        /// This is the main constructor for the AntiHero class.
        /// It takes three arguments - name (string) - karma (int) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        /// <param name="malice"></param>
        public AntiHero(string name, int karma, int malice) 
            :base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        
        public override void Trains()
        {
            Console.WriteLine("Not Implemented");
        }
        
    }
}