using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UniRide
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {
            CentralizarTodosObjetos();
        }

        private void btnLogarApp_Click(object sender, EventArgs e)
        {

        }

        private void CentralizarTodosObjetos()
        {
            CentralizarObjetos(btnLogarApp);
            CentralizarObjetos(btnCadastrarUsuario);
            CentralizarObjetos(null, LogoApp);
            CentralizarObjetos(null, null, lblUnicodetext);
            CentralizarObjetos(null, null, lblFrase);
        }
        private void CentralizarObjetos(Button? btn = null, PictureBox? pictureBox = null, Label? lbl = null)
        {
            if (btn != null)
                btn.Left = (this.ClientSize.Width - btn.Width) / 2;
            if (pictureBox != null)
                pictureBox.Left = (this.ClientSize.Width - pictureBox.Width) / 2;
            if (lbl != null)
                lbl.Left = (this.ClientSize.Width - lbl.Width) / 2;
        }

        private void panelFundo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, panelFundo.Width, panelFundo.Height);

            LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(0, 170, 200),
                Color.FromArgb(0, 120, 200),
                LinearGradientMode.Vertical);

            g.FillRectangle(brush, rect);
            lblFrase.BackColor = this.BackColor;
            lblUnicodetext.BackColor = this.BackColor;
            LogoApp.BackColor = this.BackColor;

            //        Rectangle card = new Rectangle(10, 40, panelFundo.Width - 20, panelFundo.Height - 80);

            //        GraphicsPath path = new GraphicsPath();
            //        int radius = 40;

            //        path.AddArc(card.X, card.Y, radius, radius, 180, 90);
            //        path.AddArc(card.Right - radius, card.Y, radius, radius, 270, 90);
            //        path.AddArc(card.Right - radius, card.Bottom - radius, radius, radius, 0, 90);
            //        path.AddArc(card.X, card.Bottom - radius, radius, radius, 90, 90);
            //        path.CloseFigure();

            //        g.FillPath(Brushes.White, path);

            //        LinearGradientBrush green = new LinearGradientBrush(
            //new Rectangle(0, panelFundo.Height - 120, panelFundo.Width, 120),
            //Color.LimeGreen,
            //Color.Green,
            //LinearGradientMode.Horizontal);

            //        g.FillEllipse(green, -50, panelFundo.Height - 120, 200, 200);
        }
    }
}
