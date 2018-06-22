using System;

namespace CalcNet
{
    public class Equation
    {
        public readonly int LeftTerm;
        public readonly OperationEnum Operation;
        public readonly int RightTerm;
        public readonly int Result;

        public Equation (int left, OperationEnum op, int right, int res)
        {
            LeftTerm = left;
            Operation = op;
            RightTerm = right;
            Result = res;
        }

        public override string ToString()
        {
            String s = string.Empty;

            s += String.Format("{0,3}", LeftTerm);
            s += String.Format(" {0} ", Tools.OperationChar(Operation));
            s += String.Format("{0,3}", RightTerm);
            s += String.Format(" {0} ", Tools.EqualChar);
            s += String.Format("{0,3}", Result);

            return s;
        }

        public string Image (ElipsisPositionEnum elipsis_position)
        {
            string left = String.Format("{0}", LeftTerm);
            string right = String.Format("{0}", RightTerm);
            string res = String.Format("{0}", Result);

            switch (elipsis_position)
            {
                case ElipsisPositionEnum.Left: left = Tools.Elipsis; break;
                case ElipsisPositionEnum.Right: right = Tools.Elipsis; break;
                case ElipsisPositionEnum.Result: res = Tools.Elipsis; break;
            }

            return string.Format ("{0}  {1}  {2}  {3}  {4}",
                left,
                Tools.OperationChar (Operation),
                right,
                Tools.EqualChar,
                res);
        }
    }
}



