namespace Callcenter.Presentation
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlDemos = new System.Windows.Forms.TabControl();
            this.tabPageLoginFace = new System.Windows.Forms.TabPage();
            this.buttonStopSec = new System.Windows.Forms.Button();
            this.buttonStartSec = new System.Windows.Forms.Button();
            this.lblResultSec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxWebCamSec = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxDatabaseSec = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.tabPageFaceDetect = new System.Windows.Forms.TabPage();
            this.buttonStopFace = new System.Windows.Forms.Button();
            this.buttonStartFace = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResultFace = new System.Windows.Forms.Label();
            this.pictureBoxFace = new System.Windows.Forms.PictureBox();
            this.tabPageMood = new System.Windows.Forms.TabPage();
            this.buttonStopMood = new System.Windows.Forms.Button();
            this.buttonStartMood = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxWebCamMood = new System.Windows.Forms.PictureBox();
            this.labelResultMood = new System.Windows.Forms.Label();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInsertLogin = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.tabControlDemos.SuspendLayout();
            this.tabPageLoginFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseSec)).BeginInit();
            this.tabPageFaceDetect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace)).BeginInit();
            this.tabPageMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamMood)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDemos
            // 
            this.tabControlDemos.Controls.Add(this.tabPageLoginFace);
            this.tabControlDemos.Controls.Add(this.tabPageFaceDetect);
            this.tabControlDemos.Controls.Add(this.tabPageMood);
            this.tabControlDemos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDemos.Location = new System.Drawing.Point(0, 0);
            this.tabControlDemos.Name = "tabControlDemos";
            this.tabControlDemos.SelectedIndex = 0;
            this.tabControlDemos.Size = new System.Drawing.Size(1064, 608);
            this.tabControlDemos.TabIndex = 0;
            // 
            // tabPageLoginFace
            // 
            this.tabPageLoginFace.Controls.Add(this.buttonCompare);
            this.tabPageLoginFace.Controls.Add(this.buttonInsertLogin);
            this.tabPageLoginFace.Controls.Add(this.buttonCapture);
            this.tabPageLoginFace.Controls.Add(this.buttonStopSec);
            this.tabPageLoginFace.Controls.Add(this.buttonStartSec);
            this.tabPageLoginFace.Controls.Add(this.lblResultSec);
            this.tabPageLoginFace.Controls.Add(this.label3);
            this.tabPageLoginFace.Controls.Add(this.pictureBoxWebCamSec);
            this.tabPageLoginFace.Controls.Add(this.label2);
            this.tabPageLoginFace.Controls.Add(this.pictureBoxDatabaseSec);
            this.tabPageLoginFace.Controls.Add(this.btnLogin);
            this.tabPageLoginFace.Controls.Add(this.label1);
            this.tabPageLoginFace.Controls.Add(this.textBoxUsername);
            this.tabPageLoginFace.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoginFace.Name = "tabPageLoginFace";
            this.tabPageLoginFace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoginFace.Size = new System.Drawing.Size(1056, 582);
            this.tabPageLoginFace.TabIndex = 0;
            this.tabPageLoginFace.Text = "Validacao de Foto";
            this.tabPageLoginFace.UseVisualStyleBackColor = true;
            // 
            // buttonStopSec
            // 
            this.buttonStopSec.Location = new System.Drawing.Point(344, 31);
            this.buttonStopSec.Name = "buttonStopSec";
            this.buttonStopSec.Size = new System.Drawing.Size(75, 23);
            this.buttonStopSec.TabIndex = 9;
            this.buttonStopSec.Text = "Parar";
            this.buttonStopSec.UseVisualStyleBackColor = true;
            this.buttonStopSec.Click += new System.EventHandler(this.buttonStopSec_Click);
            // 
            // buttonStartSec
            // 
            this.buttonStartSec.Location = new System.Drawing.Point(263, 31);
            this.buttonStartSec.Name = "buttonStartSec";
            this.buttonStartSec.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSec.TabIndex = 8;
            this.buttonStartSec.Text = "Iniciar";
            this.buttonStartSec.UseVisualStyleBackColor = true;
            this.buttonStartSec.Click += new System.EventHandler(this.buttonStartSec_Click);
            // 
            // lblResultSec
            // 
            this.lblResultSec.BackColor = System.Drawing.Color.Gainsboro;
            this.lblResultSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSec.Location = new System.Drawing.Point(24, 481);
            this.lblResultSec.Name = "lblResultSec";
            this.lblResultSec.Size = new System.Drawing.Size(1007, 74);
            this.lblResultSec.TabIndex = 7;
            this.lblResultSec.Text = "Idle";
            this.lblResultSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Imagem WebCam";
            // 
            // pictureBoxWebCamSec
            // 
            this.pictureBoxWebCamSec.Location = new System.Drawing.Point(575, 95);
            this.pictureBoxWebCamSec.Name = "pictureBoxWebCamSec";
            this.pictureBoxWebCamSec.Size = new System.Drawing.Size(456, 373);
            this.pictureBoxWebCamSec.TabIndex = 5;
            this.pictureBoxWebCamSec.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imagem Cadastro";
            // 
            // pictureBoxDatabaseSec
            // 
            this.pictureBoxDatabaseSec.Location = new System.Drawing.Point(24, 95);
            this.pictureBoxDatabaseSec.Name = "pictureBoxDatabaseSec";
            this.pictureBoxDatabaseSec.Size = new System.Drawing.Size(456, 373);
            this.pictureBoxDatabaseSec.TabIndex = 3;
            this.pictureBoxDatabaseSec.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(182, 32);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(24, 34);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(152, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // tabPageFaceDetect
            // 
            this.tabPageFaceDetect.Controls.Add(this.button1);
            this.tabPageFaceDetect.Controls.Add(this.buttonStopFace);
            this.tabPageFaceDetect.Controls.Add(this.buttonStartFace);
            this.tabPageFaceDetect.Controls.Add(this.label5);
            this.tabPageFaceDetect.Controls.Add(this.labelResultFace);
            this.tabPageFaceDetect.Controls.Add(this.pictureBoxFace);
            this.tabPageFaceDetect.Location = new System.Drawing.Point(4, 22);
            this.tabPageFaceDetect.Name = "tabPageFaceDetect";
            this.tabPageFaceDetect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaceDetect.Size = new System.Drawing.Size(1056, 582);
            this.tabPageFaceDetect.TabIndex = 1;
            this.tabPageFaceDetect.Text = "Detecção de Face / Postura";
            this.tabPageFaceDetect.UseVisualStyleBackColor = true;
            // 
            // buttonStopFace
            // 
            this.buttonStopFace.Location = new System.Drawing.Point(489, 37);
            this.buttonStopFace.Name = "buttonStopFace";
            this.buttonStopFace.Size = new System.Drawing.Size(75, 23);
            this.buttonStopFace.TabIndex = 12;
            this.buttonStopFace.Text = "Parar";
            this.buttonStopFace.UseVisualStyleBackColor = true;
            this.buttonStopFace.Click += new System.EventHandler(this.buttonStopFace_Click);
            // 
            // buttonStartFace
            // 
            this.buttonStartFace.Location = new System.Drawing.Point(408, 37);
            this.buttonStartFace.Name = "buttonStartFace";
            this.buttonStartFace.Size = new System.Drawing.Size(75, 23);
            this.buttonStartFace.TabIndex = 11;
            this.buttonStartFace.Text = "Iniciar";
            this.buttonStartFace.UseVisualStyleBackColor = true;
            this.buttonStartFace.Click += new System.EventHandler(this.buttonStartFace_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Imagem WebCam";
            // 
            // labelResultFace
            // 
            this.labelResultFace.BackColor = System.Drawing.Color.Gainsboro;
            this.labelResultFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultFace.Location = new System.Drawing.Point(25, 447);
            this.labelResultFace.Name = "labelResultFace";
            this.labelResultFace.Size = new System.Drawing.Size(1007, 74);
            this.labelResultFace.TabIndex = 9;
            this.labelResultFace.Text = "Idle";
            this.labelResultFace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFace
            // 
            this.pictureBoxFace.Location = new System.Drawing.Point(332, 109);
            this.pictureBoxFace.Name = "pictureBoxFace";
            this.pictureBoxFace.Size = new System.Drawing.Size(387, 312);
            this.pictureBoxFace.TabIndex = 8;
            this.pictureBoxFace.TabStop = false;
            // 
            // tabPageMood
            // 
            this.tabPageMood.Controls.Add(this.button2);
            this.tabPageMood.Controls.Add(this.buttonStopMood);
            this.tabPageMood.Controls.Add(this.buttonStartMood);
            this.tabPageMood.Controls.Add(this.label6);
            this.tabPageMood.Controls.Add(this.pictureBoxWebCamMood);
            this.tabPageMood.Controls.Add(this.labelResultMood);
            this.tabPageMood.Location = new System.Drawing.Point(4, 22);
            this.tabPageMood.Name = "tabPageMood";
            this.tabPageMood.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMood.Size = new System.Drawing.Size(1056, 582);
            this.tabPageMood.TabIndex = 2;
            this.tabPageMood.Text = "Validação de Humor";
            this.tabPageMood.UseVisualStyleBackColor = true;
            // 
            // buttonStopMood
            // 
            this.buttonStopMood.Location = new System.Drawing.Point(484, 58);
            this.buttonStopMood.Name = "buttonStopMood";
            this.buttonStopMood.Size = new System.Drawing.Size(75, 23);
            this.buttonStopMood.TabIndex = 16;
            this.buttonStopMood.Text = "Parar";
            this.buttonStopMood.UseVisualStyleBackColor = true;
            this.buttonStopMood.Click += new System.EventHandler(this.buttonStopMood_Click);
            // 
            // buttonStartMood
            // 
            this.buttonStartMood.Location = new System.Drawing.Point(403, 58);
            this.buttonStartMood.Name = "buttonStartMood";
            this.buttonStartMood.Size = new System.Drawing.Size(75, 23);
            this.buttonStartMood.TabIndex = 15;
            this.buttonStartMood.Text = "Iniciar";
            this.buttonStartMood.UseVisualStyleBackColor = true;
            this.buttonStartMood.Click += new System.EventHandler(this.buttonStartMood_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Imagem WebCam";
            // 
            // pictureBoxWebCamMood
            // 
            this.pictureBoxWebCamMood.Location = new System.Drawing.Point(328, 136);
            this.pictureBoxWebCamMood.Name = "pictureBoxWebCamMood";
            this.pictureBoxWebCamMood.Size = new System.Drawing.Size(387, 312);
            this.pictureBoxWebCamMood.TabIndex = 13;
            this.pictureBoxWebCamMood.TabStop = false;
            // 
            // labelResultMood
            // 
            this.labelResultMood.BackColor = System.Drawing.Color.Gainsboro;
            this.labelResultMood.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMood.Location = new System.Drawing.Point(25, 463);
            this.labelResultMood.Name = "labelResultMood";
            this.labelResultMood.Size = new System.Drawing.Size(1007, 74);
            this.labelResultMood.TabIndex = 12;
            this.labelResultMood.Text = "Idle";
            this.labelResultMood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCapture
            // 
            this.buttonCapture.Location = new System.Drawing.Point(425, 31);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(75, 23);
            this.buttonCapture.TabIndex = 10;
            this.buttonCapture.Text = "Capturar";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Capturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Capturar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInsertLogin
            // 
            this.buttonInsertLogin.Location = new System.Drawing.Point(928, 31);
            this.buttonInsertLogin.Name = "buttonInsertLogin";
            this.buttonInsertLogin.Size = new System.Drawing.Size(103, 23);
            this.buttonInsertLogin.TabIndex = 11;
            this.buttonInsertLogin.Text = "Cadastrar Login";
            this.buttonInsertLogin.UseVisualStyleBackColor = true;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(506, 30);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 12;
            this.buttonCompare.Text = "Comparar";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 608);
            this.Controls.Add(this.tabControlDemos);
            this.Name = "FormMain";
            this.Text = "Demo Callcenter";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlDemos.ResumeLayout(false);
            this.tabPageLoginFace.ResumeLayout(false);
            this.tabPageLoginFace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseSec)).EndInit();
            this.tabPageFaceDetect.ResumeLayout(false);
            this.tabPageFaceDetect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace)).EndInit();
            this.tabPageMood.ResumeLayout(false);
            this.tabPageMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamMood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDemos;
        private System.Windows.Forms.TabPage tabPageLoginFace;
        private System.Windows.Forms.TabPage tabPageFaceDetect;
        private System.Windows.Forms.TabPage tabPageMood;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lblResultSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxWebCamSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxDatabaseSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResultFace;
        private System.Windows.Forms.PictureBox pictureBoxFace;
        private System.Windows.Forms.Label labelResultMood;
        private System.Windows.Forms.Button buttonStopSec;
        private System.Windows.Forms.Button buttonStartSec;
        private System.Windows.Forms.Button buttonStopFace;
        private System.Windows.Forms.Button buttonStartFace;
        private System.Windows.Forms.Button buttonStopMood;
        private System.Windows.Forms.Button buttonStartMood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxWebCamMood;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonInsertLogin;
        private System.Windows.Forms.Button buttonCompare;
    }
}

