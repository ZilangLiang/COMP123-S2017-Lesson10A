using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 20, 2017
 * Description: This is an Interface that defines a Malice Property that
 * must be implemented in any class that subscribes to it.
 * Version: 0.1 - Created IHasMalice interface
 */

namespace COMP123_S2017_Lesson10A
{
    public interface IHasMalice
    {
        // PUBLIC PROPERTIES
        int Malice { get; set; }
    }
}