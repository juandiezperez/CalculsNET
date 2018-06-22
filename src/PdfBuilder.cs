using System;
using System.Diagnostics;
using System.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace CalcNet
{
    public class PdfBuilder
    {

        private PdfDocument pdf_document;
        private PdfPage     pdf_page;
        private XGraphics   pdf_graphics;
        private int         pdf_page_nr = 0;

        private XFont font_small  = new XFont("Verdana",  8, XFontStyle.Regular);
        private XFont font_medium = new XFont("Verdana", 14, XFontStyle.Regular);
        private XFont font_big    = new XFont("Verdana", 20, XFontStyle.Regular);

        public string HeaderLeft = string.Empty;
        public string HeaderRight = string.Empty;
        public string FooterLeft = string.Empty;
        public string FooterRight = string.Empty;
        public string Title = "CalcNET " + DateTime.Now.ToString ("g");

        public PdfBuilder ()
        {
            // Create a new PDF document
            pdf_document = new PdfDocument();
        }

        public void Start ()
        {
            pdf_document.Info.Title = Title;
            new_page();
        }

        private const double margin_left = 0.05;
        private const double margin_top  = 0.03;

        private const int num_line = 32;
        private const int num_col = 3;

        private const int first_user_line = 3;
        private const int last_user_line = num_line - 3;

        private double element_width   = ( 1.0 - ( 2.0 * margin_left) ) / num_col;
        private double element_height =  ( 1.0 - ( 2.0 * margin_top ) ) / num_line;

        private int current_col  = 0;

        private int[] current_line;

        private XRect element_rectangle (int line, int col)
        {
            double width  = pdf_page.Width;
            double height = pdf_page.Height;

            double x = (margin_left + ( col * element_width ) ) * width;
            double y = (margin_top  + (line * element_height) ) * height;

            double dx = element_width * width;
            double dy = element_height * height;

            return new XRect(x, y, dx, dy);
        }

        

        private void new_page ()
        {
            // Create an empty page
            pdf_page = pdf_document.AddPage();
            pdf_page_nr++;

            // Get an XGraphics object for drawing
            pdf_graphics = XGraphics.FromPdfPage(pdf_page);

            current_line = new int[num_col];
            for (int c = 0; c < num_col; c++)
                current_line[c] = first_user_line;
            current_col = 0;
            {
                FooterRight = String.Format("Page {0}", pdf_page_nr);

                XStringFormat fmt = XStringFormats.Center;
                
                fmt.Alignment = XStringAlignment.Center;
                if (!String.IsNullOrEmpty(Title))
                    pdf_graphics.DrawString(Title, font_big, XBrushes.Black, element_rectangle (1, 1), fmt);

                fmt.Alignment = XStringAlignment.Near;
                if ( ! String.IsNullOrEmpty(HeaderLeft))
                    pdf_graphics.DrawString(HeaderLeft, font_small, XBrushes.Black, element_rectangle (0, 0), fmt);
                if ( ! String.IsNullOrEmpty(FooterLeft))
                    pdf_graphics.DrawString(FooterLeft, font_small, XBrushes.Black, element_rectangle (num_line-1, 0), fmt);

                fmt.Alignment = XStringAlignment.Far;
                if ( ! String.IsNullOrEmpty(HeaderRight))
                    pdf_graphics.DrawString(HeaderRight, font_small, XBrushes.Black, element_rectangle (0, num_col-1), fmt);
                if ( ! String.IsNullOrEmpty(FooterRight))
                    pdf_graphics.DrawString(FooterRight, font_small, XBrushes.Black, element_rectangle (num_line-1, num_col-1), fmt);


                {
                    double width = pdf_page.Width;
                    double height = pdf_page.Height;

                    double x = margin_left * width;
                    double y = margin_top * height;

                    double dx = (1.0 - ( 2.0 * margin_left ) ) * width;
                    double dy = (1.0 - (2.0 * margin_top) ) * height;

                    pdf_graphics.DrawRectangle (XPens.Black, new XRect(x, y, dx, dy));
                }
            }

        }

        private void next_position()
        {
            current_line [current_col] = current_line[current_col] + 1;
            if (current_line [current_col] >= last_user_line)
            {
                next_column ();
            }
        }

       private void next_column ()
        {
            current_col++;
            if (current_col >= num_col)
            {
                current_col = 0;
                if (current_line[current_col] >= last_user_line)
                {
                    new_page ();
                }
            }
        }

        public void Save(string file_name)
        {
            pdf_document.Save(file_name);
            // ...and start a viewer.
            Process.Start(file_name);
        }


        public void AddEquations (EquationGenerator gen)
        {
            // Draw the text
            pdf_graphics.DrawString(gen.Name,
                font_big,
                XBrushes.Black,
                element_rectangle(current_line[current_col], current_col),
                XStringFormats.Center);
            next_position();
            next_position();

            foreach (Equation eq in gen.Selection)
            {
                pdf_graphics.DrawString(eq.Image(gen.ElipsisPosition), 
                    font_medium, 
                    XBrushes.Black,
                    element_rectangle(current_line[current_col], current_col),
                    XStringFormats.Center);
                next_position();
            }
            next_position ();
            next_column ();
        }
    }
}




