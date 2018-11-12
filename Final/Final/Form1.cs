using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var a = this.PointToScreen(label1.Location);
            a = panel1.PointToClient(a);
            label1.Parent = panel1;
         
            label1.BackColor = Color.Transparent;
           

            roundedButton1.TabStop = false;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.FlatAppearance.BorderSize = 0;

            roundedButton2.TabStop = false;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.FlatAppearance.BorderSize = 0;

            roundedButton3.TabStop = false;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.FlatAppearance.BorderSize = 0;

            roundedButton4.TabStop = false;
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.FlatAppearance.BorderSize = 0;

            roundedButton5.TabStop = false;
            roundedButton5.FlatStyle = FlatStyle.Flat;
            roundedButton5.FlatAppearance.BorderSize = 0;

            roundedButton6.TabStop = false;
            roundedButton6.FlatStyle = FlatStyle.Flat;
            roundedButton6.FlatAppearance.BorderSize = 0;

            roundedButton7.TabStop = false;
            roundedButton7.FlatStyle = FlatStyle.Flat;
            roundedButton7.FlatAppearance.BorderSize = 0;

            roundedButton8.TabStop = false;
            roundedButton8.FlatStyle = FlatStyle.Flat;
            roundedButton8.FlatAppearance.BorderSize = 0;

            roundedButton9.TabStop = false;
            roundedButton9.FlatStyle = FlatStyle.Flat;
            roundedButton9.FlatAppearance.BorderSize = 0;


            roundedButton10.TabStop = false;
            roundedButton10.FlatStyle = FlatStyle.Flat;
            roundedButton10.FlatAppearance.BorderSize = 0;

            roundedButton11.TabStop = false;
            roundedButton11.FlatStyle = FlatStyle.Flat;
            roundedButton11.FlatAppearance.BorderSize = 0;

            roundedButton12.TabStop = false;
            roundedButton12.FlatStyle = FlatStyle.Flat;
            roundedButton12.FlatAppearance.BorderSize = 0;

            roundedButton13.TabStop = false;
            roundedButton13.FlatStyle = FlatStyle.Flat;
            roundedButton13.FlatAppearance.BorderSize = 0;

            roundedButton14.TabStop = false;
            roundedButton14.FlatStyle = FlatStyle.Flat;
            roundedButton14.FlatAppearance.BorderSize = 0;
            roundedButton15.TabStop = false;
            roundedButton15.FlatStyle = FlatStyle.Flat;
            roundedButton15.FlatAppearance.BorderSize = 0;

            roundedButton16.TabStop = false;
            roundedButton16.FlatStyle = FlatStyle.Flat;
            roundedButton16.FlatAppearance.BorderSize = 0;

            roundedButton21.TabStop = false;
            roundedButton21.FlatStyle = FlatStyle.Flat;
            roundedButton21.FlatAppearance.BorderSize = 0;

            roundedButton22.TabStop = false;
            roundedButton22.FlatStyle = FlatStyle.Flat;
            roundedButton22.FlatAppearance.BorderSize = 0;

            roundedButton23.TabStop = false;
            roundedButton23.FlatStyle = FlatStyle.Flat;
            roundedButton23.FlatAppearance.BorderSize = 0;

            roundedButton24.TabStop = false;
            roundedButton24.FlatStyle = FlatStyle.Flat;
            roundedButton24.FlatAppearance.BorderSize = 0;

            roundedButton25.TabStop = false;
            roundedButton25.FlatStyle = FlatStyle.Flat;
            roundedButton25.FlatAppearance.BorderSize = 0;

            roundedButton26.TabStop = false;
            roundedButton26.FlatStyle = FlatStyle.Flat;
            roundedButton26.FlatAppearance.BorderSize = 0;

            roundedButton27.TabStop = false;
            roundedButton27.FlatStyle = FlatStyle.Flat;
            roundedButton27.FlatAppearance.BorderSize = 0;

            roundedButton28.TabStop = false;
            roundedButton28.FlatStyle = FlatStyle.Flat;
            roundedButton28.FlatAppearance.BorderSize = 0;

            roundedButton29.TabStop = false;
            roundedButton29.FlatStyle = FlatStyle.Flat;
            roundedButton29.FlatAppearance.BorderSize = 0;

            roundedButton210.TabStop = false;
            roundedButton210.FlatStyle = FlatStyle.Flat;
            roundedButton210.FlatAppearance.BorderSize = 0;

            roundedButton211.TabStop = false;
            roundedButton211.FlatStyle = FlatStyle.Flat;
            roundedButton211.FlatAppearance.BorderSize = 0;

            roundedButton212.TabStop = false;
            roundedButton212.FlatStyle = FlatStyle.Flat;
            roundedButton212.FlatAppearance.BorderSize = 0;

            roundedButton213.TabStop = false;
            roundedButton213.FlatStyle = FlatStyle.Flat;
            roundedButton213.FlatAppearance.BorderSize = 0;

            roundedButton214.TabStop = false;
            roundedButton214.FlatStyle = FlatStyle.Flat;
            roundedButton214.FlatAppearance.BorderSize = 0;

            roundedButton215.TabStop = false;
            roundedButton215.FlatStyle = FlatStyle.Flat;
            roundedButton215.FlatAppearance.BorderSize = 0;

            roundedButton216.TabStop = false;
            roundedButton216.FlatStyle = FlatStyle.Flat;
            roundedButton216.FlatAppearance.BorderSize = 0;



        }

        private void roundedButton9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void roundedButton24_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    class RoundedButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();

            return GraphPath;
        }
           

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 30);
           

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }

    class RoundedButton2 : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();

            return GraphPath;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 10);


            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
