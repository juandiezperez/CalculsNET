using System.Collections.Generic;

namespace CalcNet
{
    public class EquationCollection  : List<Equation>
    {
        public EquationCollection ()
        {
        }

        public EquationCollection ( IEnumerable<Equation> another )
        {
            this.AddRange(another);
        }
    }
}



