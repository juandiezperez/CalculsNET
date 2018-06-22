namespace CalcNet
{
    public static class Tools
    {
        public static string OperationChar(OperationEnum op)
        {
            switch (op)
            {
                case OperationEnum.Addition: return "+";
                case OperationEnum.Substraction: return "-";
                case OperationEnum.Multiplication: return "x";
                case OperationEnum.Division: return ":";
            }
            return "?";
        }

        public static OperationEnum StringToOperation (string str)
        {
            if (str == "+") return OperationEnum.Addition;
            if (str == "-") return OperationEnum.Substraction;
            if (str == "*") return OperationEnum.Multiplication;
            if (str == "/") return OperationEnum.Division;

            throw new System.Exception("Cannot convert '" + str + "' to OperationEnum.");
        }

        public static string EqualChar
        {
            get
            {
                return "=";
            }
        }

        public static string Elipsis
        {
            get
            {
                return "...";
            }
        }

    }
}



