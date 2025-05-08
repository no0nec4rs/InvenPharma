namespace InvenPharma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnLogin = new Button();
            btnRegistrarMedicamento = new Button();
            tnMostrarMedicamentos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, -56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1191, 675);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Inter Thin", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 9);
            label1.Name = "label1";
            label1.Size = new Size(435, 93);
            label1.TabIndex = 2;
            label1.Text = "InvenPharma";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Inter Light", 15F);
            btnLogin.Location = new Point(12, 149);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(396, 101);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistrarMedicamento
            // 
            btnRegistrarMedicamento.Font = new Font("Inter Light", 15.2F);
            btnRegistrarMedicamento.Location = new Point(12, 256);
            btnRegistrarMedicamento.Name = "btnRegistrarMedicamento";
            btnRegistrarMedicamento.Size = new Size(396, 101);
            btnRegistrarMedicamento.TabIndex = 4;
            btnRegistrarMedicamento.Text = "Registrar Medicamentos";
            btnRegistrarMedicamento.UseVisualStyleBackColor = true;
            btnRegistrarMedicamento.Click += btnRegistrarMedicamento_Click;
            // 
            // tnMostrarMedicamentos
            // 
            tnMostrarMedicamentos.Font = new Font("Inter Light", 15.2F);
            tnMostrarMedicamentos.Location = new Point(12, 363);
            tnMostrarMedicamentos.Name = "tnMostrarMedicamentos";
            tnMostrarMedicamentos.Size = new Size(396, 101);
            tnMostrarMedicamentos.TabIndex = 5;
            tnMostrarMedicamentos.Text = "Mostrar Medicamentos";
            tnMostrarMedicamentos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1272, 608);
            Controls.Add(tnMostrarMedicamentos);
            Controls.Add(btnRegistrarMedicamento);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "t";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLogin;
        private Button btnRegistrarMedicamento;
        private Button tnMostrarMedicamentos;
    }
}
