namespace UniRide
{
    partial class PaginaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaLogin));
            btnLogarApp = new Button();
            btnCadastrarUsuario = new Button();
            LogoApp = new PictureBox();
            lblFrase = new Label();
            lblUnicodetext = new Label();
            panelFundo = new Panel();
            ((System.ComponentModel.ISupportInitialize)LogoApp).BeginInit();
            SuspendLayout();
            // 
            // btnLogarApp
            // 
            btnLogarApp.BackColor = Color.DarkCyan;
            btnLogarApp.FlatStyle = FlatStyle.Popup;
            btnLogarApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogarApp.ForeColor = Color.White;
            btnLogarApp.Location = new Point(82, 297);
            btnLogarApp.Name = "btnLogarApp";
            btnLogarApp.Size = new Size(144, 39);
            btnLogarApp.TabIndex = 4;
            btnLogarApp.Text = "Entrar";
            btnLogarApp.UseVisualStyleBackColor = false;
            btnLogarApp.Click += btnLogarApp_Click;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.BackColor = Color.YellowGreen;
            btnCadastrarUsuario.FlatStyle = FlatStyle.Popup;
            btnCadastrarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarUsuario.ForeColor = Color.White;
            btnCadastrarUsuario.Location = new Point(82, 362);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(144, 43);
            btnCadastrarUsuario.TabIndex = 5;
            btnCadastrarUsuario.Text = "Cadastrar-se";
            btnCadastrarUsuario.UseVisualStyleBackColor = false;
            // 
            // LogoApp
            // 
            LogoApp.BackColor = Color.Transparent;
            LogoApp.BackgroundImage = (Image)resources.GetObject("LogoApp.BackgroundImage");
            LogoApp.BackgroundImageLayout = ImageLayout.Zoom;
            LogoApp.Image = (Image)resources.GetObject("LogoApp.Image");
            LogoApp.Location = new Point(59, -54);
            LogoApp.Name = "LogoApp";
            LogoApp.Size = new Size(204, 243);
            LogoApp.SizeMode = PictureBoxSizeMode.Zoom;
            LogoApp.TabIndex = 6;
            LogoApp.TabStop = false;
            // 
            // lblFrase
            // 
            lblFrase.AutoSize = true;
            lblFrase.BackColor = Color.Transparent;
            lblFrase.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrase.Location = new Point(59, 192);
            lblFrase.Name = "lblFrase";
            lblFrase.Size = new Size(201, 38);
            lblFrase.TabIndex = 7;
            lblFrase.Text = "Bem-vindo ao";
            // 
            // lblUnicodetext
            // 
            lblUnicodetext.AutoSize = true;
            lblUnicodetext.BackColor = Color.Transparent;
            lblUnicodetext.FlatStyle = FlatStyle.Flat;
            lblUnicodetext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnicodetext.ForeColor = Color.DarkCyan;
            lblUnicodetext.Location = new Point(102, 230);
            lblUnicodetext.Name = "lblUnicodetext";
            lblUnicodetext.Size = new Size(100, 31);
            lblUnicodetext.TabIndex = 8;
            lblUnicodetext.Text = "UniRide";
            // 
            // panelFundo
            // 
            panelFundo.BackColor = Color.White;
            panelFundo.Dock = DockStyle.Fill;
            panelFundo.Location = new Point(0, 0);
            panelFundo.Name = "panelFundo";
            panelFundo.Size = new Size(332, 553);
            panelFundo.TabIndex = 9;
            panelFundo.Paint += panelFundo_Paint;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(332, 553);
            Controls.Add(lblUnicodetext);
            Controls.Add(lblFrase);
            Controls.Add(LogoApp);
            Controls.Add(btnCadastrarUsuario);
            Controls.Add(btnLogarApp);
            Controls.Add(panelFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PaginaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniRide";
            Load += PaginaLogin_Load;
            ((System.ComponentModel.ISupportInitialize)LogoApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogarApp;
        private Button btnCadastrarUsuario;
        private PictureBox LogoApp;
        private Label lblFrase;
        private Label lblUnicodetext;
        private Panel panelFundo;
    }
}
