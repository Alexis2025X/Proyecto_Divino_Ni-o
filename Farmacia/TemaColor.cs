using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Farmacia
{
    class TemaColor
    {
        public static void colorBtn(Button control)
        {
            Color fondo = Color.FromArgb(0, 160, 255);
            Color text = Color.White;
            control.ForeColor = text;
            control.BackColor = fondo;
            control.FlatStyle = FlatStyle.Popup;

            int BorderRadius = 30;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, BorderRadius, BorderRadius), 180, 90);
            path.AddArc(new Rectangle(control.Width - BorderRadius, 0, BorderRadius, BorderRadius), 270, 90);
            path.AddArc(new Rectangle(control.Width - BorderRadius, control.Height - BorderRadius, BorderRadius, BorderRadius), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - BorderRadius, BorderRadius, BorderRadius), 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }
        public static void colorLbl(Label control)
        {
            Color text = Color.White;
            control.ForeColor = text;

        }
        public static void colorCombo(ComboBox control)
        {
            Color text = Color.White;
            Color fondo = Color.FromArgb(38, 199, 255);
            control.ForeColor = text;
            control.BackColor = fondo;
        }
        public static void colorTextBox(TextBox control)
        {
            Color text = Color.White;
            Color fondo = Color.FromArgb(38, 199, 255);
            control.ForeColor = text;
            control.BackColor = fondo;

        }
        public static void colorFondoVentana(Form control)
        {

            Color fondo = Color.FromArgb(0, 55, 133);

            control.BackColor = fondo;


        }
        public static void colorDataGrid(DataGridView control)
        {
            Color fondoCeldas = Color.FromArgb(0, 55, 133);
            Color text = Color.White;
            Color fondo = Color.FromArgb(38, 199, 255);
            Color encabezado = Color.FromArgb(0, 91, 255);

            control.EnableHeadersVisualStyles = false;
            control.ColumnHeadersDefaultCellStyle.ForeColor = text;
            control.ColumnHeadersDefaultCellStyle.BackColor = encabezado;
            control.DefaultCellStyle.ForeColor = Color.Black;
            control.DefaultCellStyle.BackColor = fondo;
            control.BackgroundColor = fondoCeldas;

            control.DefaultCellStyle.SelectionBackColor = encabezado;
            control.DefaultCellStyle.SelectionForeColor = text;
        }
    }
}
