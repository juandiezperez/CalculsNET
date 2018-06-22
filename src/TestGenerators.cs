using System;
using System.Collections.Generic;

namespace CalcNet
{
    public static class TestGenerators
    {
        public static void TestThem ()
        {
            List<EquationGenerator> generators = new List<EquationGenerator>();


            generators.Add(new EquationGenerator(Range.DU_10_19, OperationEnum.Addition, Range.U_01_09, Range.DU_10_19));
            generators.Add(new EquationGenerator(Range.U_01_09, OperationEnum.Addition, Range.DU_10_19, Range.DU_10_19));
            generators.Add(new EquationGenerator(Range.DU_10_19, OperationEnum.Addition, Range.U_01_09, Range.DU_20_29));
            generators.Add(new EquationGenerator(Range.DU_10_19, OperationEnum.Substraction, Range.U_01_09, Range.U_01_09));
            generators.Add(new EquationGenerator(Range.DU_10_19, OperationEnum.Substraction, Range.U_01_09, Range.DU_10_19));

            foreach (EquationGenerator g in generators)
            {
                g.Dump();
            }

            PdfBuilder pdf_builder = new PdfBuilder();

            foreach (EquationGenerator g in generators)
            {
                foreach (ElipsisPositionEnum e in Enum.GetValues (typeof (ElipsisPositionEnum)))
                {
                    g.ElipsisPosition = e;
                    pdf_builder.AddEquations(g);
                }
            }


            pdf_builder.Save("coucou.pdf");

        }

    }
}



