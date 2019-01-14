using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // Convention on events: 1st parameter sent is sender and second parameter has all needed information about event
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
}
