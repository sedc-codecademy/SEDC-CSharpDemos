using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    public interface IMarker
    {
    }

    public interface ICalculator : IMarker
    {
        int Add(int first, int second);
        int Sub(int first, int second);
    }

    public interface IReader : IMarker
    {
        string ReadFile(string filename);
    }
}
