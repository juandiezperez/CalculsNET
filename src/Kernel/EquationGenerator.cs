using System;
using System.Linq;

namespace CalcNet
{
    public class EquationGenerator
    {
        private static Random randomizer = new Random ( DateTime.Now.Millisecond % 997 );

        public string Name = "";
        public Range         LeftRange;
        public Range         RightRange;
        public OperationEnum Operation;
        public Range         ResultRange;
        public ElipsisPositionEnum ElipsisPosition;
        public EquationCollection Solutions;
        public EquationCollection Selection;


        private bool my_selection_randomized = true;
        private int  my_selection_limit = 8;

        public bool Selection_Randomized
        {
            get { return my_selection_randomized; }
            set { my_selection_randomized = value; re_build_selection(); }
        }
        public int  Selection_Limit
        {
            get { return my_selection_limit; }
            set { my_selection_limit = value; re_build_selection(); }
        }

        public EquationGenerator() : this (Range.DU_10_19, OperationEnum.Addition, Range.U_01_09, Range.DU_10_19)
        {
        }

        public EquationGenerator (Range left_range, 
                                  OperationEnum op, 
                                  Range right_range, 
                                  Range result_range)
        {
            LeftRange = left_range;
            RightRange = right_range;
            ResultRange = result_range;
            Operation = op;
            Solutions = generate_equations();
            ElipsisPosition = ElipsisPositionEnum.Result;
            re_build_selection();
        }

        private EquationCollection generate_equations()
        {
            EquationCollection result = new EquationCollection();

            foreach (int term_left in LeftRange.Values)
                foreach (int term_right in RightRange.Values)
                {
                    if (Operation == OperationEnum.Division)
                    {
                        if (term_left % term_right != 0)
                        {
                            continue;
                        }
                    }
                    int term_result = 0;
                    switch (Operation)
                    {
                        case OperationEnum.Addition:       term_result = term_left + term_right; break;
                        case OperationEnum.Substraction:   term_result = term_left - term_right; break;
                        case OperationEnum.Multiplication: term_result = term_left * term_right; break;
                        case OperationEnum.Division:       term_result = term_left / term_right; break;
                    }
                    if (ResultRange.Includes(term_result))
                    {
                        Equation eq = new Equation(term_left, Operation, term_right, term_result);
                        result.Add(eq);
                    }
                }
            return result;
        }

        private void re_build_selection ()
        {
            EquationCollection result = new EquationCollection(Solutions);
            if (Selection_Randomized)
            {
                for (int i=0; i < result.Count; i++)
                {
                    int i0 = randomizer.Next (result.Count);
                    int i1 = randomizer.Next(result.Count);
                    if (i0 != i1)
                    {
                        Equation e = result[i0];
                        result[i0] = result[i1];
                        result[i1] = e;
                    }
                }
            }

            if (Selection_Limit < result.Count)
            {
                result = new EquationCollection(result.Take (Selection_Limit) );
            }

            Selection = result;
        }

        public void Dump (bool detailed = true)
        {
            Log.Debug (this.ToString());
            foreach (Equation eq in Solutions)
                Log.Debug("  {0}", eq.ToString());
        }

        public override string ToString()
        {
            string s = string.Empty;

            s += String.Format("{0}", LeftRange);
            s += String.Format(" ({0}) ", Operation);
            s += String.Format("{0}", RightRange);
            s += String.Format(" = ", Solutions.Count);
            s += String.Format("{0}", ResultRange);

            return s;
        }

        public string SolutionsText
        {
            get
            {
                return string.Format("Solutions:{0}, Selection:{1}", Solutions.Count, Selection.Count);
            }
        }

        public string Image (ElipsisPositionEnum elipsis)
        {
            string s = string.Empty;

            s += String.Format("({0})", LeftRange);
            s += String.Format(" ({0}) ", Tools.OperationChar(Operation) );
            s += String.Format("({0})", RightRange);
            s += String.Format(" = ", Solutions.Count);
            s += String.Format("({0})", ResultRange);

            return s;
        }
    }
}



