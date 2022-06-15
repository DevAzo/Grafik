using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Grafik
{
    /// <summary>
    /// Hauptklasse
    /// </summary>
    public partial class MainDlg : Form
    {
        private int diagramWidth = 500;
        private int diagramHeight = 500;
        private int diagramPosX = 50;
        private int diagramPosY = 50;
        private int diagramDivX = 10;
        private int diagramDivY = 10;
        private int listIndex = 1;
        private int diagramBorderSize = 3;
        private int labelFontSize = 10;
        private bool bDrawUserData = false;

        // Timer
        private bool timerActive = false;

        private int timeInSeconds = 0;

        // Drucken
        private PrintDocument printDocument1 = new PrintDocument();

        private Bitmap memoryImage;

        public MainDlg()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.DefaultPageSettings.Landscape = true;

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            lblUserName.Text = userName;
        }

        private void PaintAll(object sender, PaintEventArgs e)
        {
            DrawGridBorder(e);
            DrawGrid(e);
            DrawGridLabel(e);
            DrawGridName(e);
            DrawUserData(e);
        }

        private void DrawGrid(PaintEventArgs e)
        {
            Pen penHorz;
            penHorz = new Pen(Color.Gray, 1);

            int div = diagramHeight / diagramDivY;
            int posY = diagramPosY + div;

            for (int i = 0; i < (diagramDivY - 1); i++)
            {
                e.Graphics.DrawLine(penHorz, diagramPosX, posY, diagramPosX + diagramWidth, posY);
                posY += div;
            }

            penHorz.Dispose();

            Pen penVert;
            penVert = new Pen(Color.Gray);

            div = diagramWidth / diagramDivX;
            int posX = diagramPosX + div;

            for (int i = 0; i < (diagramDivY - 1); i++)
            {
                e.Graphics.DrawLine(penVert, posX, diagramPosY, posX, diagramPosY + diagramHeight);
                posX += div;
            }
            penVert.Dispose();
        }

        private void DrawGridBorder(PaintEventArgs e)
        {
            Pen pen;
            pen = new Pen(Color.Black, diagramBorderSize);
            Rectangle border = new Rectangle(diagramPosX, diagramPosY, diagramWidth, diagramHeight);
            e.Graphics.DrawRectangle(pen, border);

            pen.Dispose();
        }

        private void DrawGridLabel(PaintEventArgs e)
        {
            int divY = diagramHeight / diagramDivY;
            int divX = diagramWidth / diagramDivX;
            int posY = diagramPosY - 2 * diagramBorderSize;
            int posX = diagramPosX - 2 * diagramBorderSize;
            int xOffset = 20;
            int yOffset = 20;

            for (int i = 0; i <= diagramDivY; i++)
            {
                e.Graphics.DrawString(i.ToString(), new Font("Consolas", labelFontSize, FontStyle.Regular),
                    new SolidBrush(Color.Red), new PointF(diagramPosX - xOffset, posY));

                posY += divY;
            }

            for (int j = 0; j <= diagramDivX; j++)
            {
                e.Graphics.DrawString(j.ToString(), new Font("Consolas", labelFontSize, FontStyle.Regular),
                    new SolidBrush(Color.Red), new PointF(posX, diagramPosY - yOffset));
                posX += divX;
            }
        }

        private void DrawGridName(PaintEventArgs e)
        {
            e.Graphics.DrawString("X-Achse", new Font("Consolas", labelFontSize, FontStyle.Bold),
                new SolidBrush(Color.Black), new PointF(diagramPosX + (diagramWidth / 2), diagramPosY / 4));

            int offsetX = 40;
            int offsetY = diagramPosY + (diagramHeight / 2) - 2 * diagramBorderSize;

            e.Graphics.DrawString("Y", new Font("Consolas", labelFontSize, FontStyle.Bold),
               new SolidBrush(Color.Black), new PointF(diagramPosX - offsetX, offsetY));
        }

        private void DrawUserData(PaintEventArgs e)
        {
            if (bDrawUserData == false) return;

            foreach (ListViewItem itemRow in this.listView.Items)
            {
                String sStile = itemRow.SubItems[1].Text;
                String sColor = itemRow.SubItems[6].Text;

                Int32.TryParse(itemRow.SubItems[2].Text, out int startX);
                Int32.TryParse(itemRow.SubItems[3].Text, out int startY);
                Int32.TryParse(itemRow.SubItems[4].Text, out int stopX);
                Int32.TryParse(itemRow.SubItems[5].Text, out int stopY);

                int offset = diagramPosX;

                Pen pen = new Pen(GetColor(sColor), diagramBorderSize);

                switch (sStile)
                {
                    case "Linie": break;
                    case "Striche":
                        {
                            float[] dashValues = { 4, 4 };
                            pen.DashPattern = dashValues;
                            break;
                        }
                    case "Punkte":
                        {
                            float[] dashValues = { 1, 1 };
                            pen.DashPattern = dashValues;
                            break;
                        }
                    default: break;
                }

                e.Graphics.DrawLine(pen, (startX * offset) + offset, startY * offset + offset, stopX * offset + offset, stopY * offset + offset);
                pen.Dispose();
            }
        }

        private Color GetColor(String sColor)
        {
            switch (sColor)
            {
                case "Rot": return Color.Red;
                case "Blau": return Color.Blue;
                case "Grün": return Color.Green;
                case "Schwarz": return Color.Black;
                default: return Color.Black;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bDrawUserData = true;
            Invalidate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (timerActive == false)
            {
                timerActive = true;
                timer1.Start();
            }

            ListViewItem i = new ListViewItem(listIndex.ToString());

            i.SubItems.Add(cbxStil.Text);
            i.SubItems.Add(cbxStartX.Text);
            i.SubItems.Add(cbxStartY.Text);
            i.SubItems.Add(cbxStopX.Text);
            i.SubItems.Add(cbxStopY.Text);
            i.SubItems.Add(cbxFarbe.Text);
            listView.Items.Add(i);

            listIndex += 1;

            ResetEingabe();
        }

        private void ResetEingabe()
        {
            cbxStil.SelectedIndex = -1;
            cbxStartX.SelectedIndex = -1;
            cbxStartY.SelectedIndex = -1;
            cbxStopX.SelectedIndex = -1;
            cbxStopY.SelectedIndex = -1;
            cbxFarbe.SelectedIndex = -1;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Timer stoppen
            timer1.Stop();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnFertig.Enabled = false;

            CaptureScreen();

            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

            // preview the assigned document or you can create a different previewButton for it
            printPrvDlg.Document = printDocument1;
            printPrvDlg.Width = 800;
            printPrvDlg.Height = 600;
            printPrvDlg.Scale(new SizeF(2, 2));
            printPrvDlg.ShowDialog(); // this shows the preview and then show the Printer Dlg below

            PrintDialog printdlg = new PrintDialog();
            printdlg.Document = printDocument1;

            if (printdlg.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();

            // liefert die aktuelle Auflösung des Bildschirms, auch wenn
            // der Benutzer dies verstellt hat, z.B. auf 125%

            // Rectangle resolution = Screen.PrimaryScreen.Bounds;

            Size s = new Size(this.Width, this.Height);
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView.SelectedItems)
            {
                listView.Items.Remove(eachItem);
            }
        }

        private void btnFertig_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnFertig.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeInSeconds += 1;
            lblTimer.Text = timeInSeconds.ToString() + " sec.";
        }
    }
}