using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiered.Presentation
{
    public enum Command
    {
        InvalidCommand = 0,
        FindPerson = 1,
        ListPersons = 2,
        ListPersonsLastName = 3,
        AddPerson = 4,
        ExitCommand = 5
    }
}
