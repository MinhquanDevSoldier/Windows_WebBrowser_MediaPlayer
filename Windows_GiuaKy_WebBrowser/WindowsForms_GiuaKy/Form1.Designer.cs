namespace WindowsForms_GiuaKy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.pnWeb = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdress
            // 
            this.txtAdress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAdress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdress.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(125, 6);
            this.txtAdress.MinimumSize = new System.Drawing.Size(4, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(1217, 29);
            this.txtAdress.TabIndex = 2;
            this.txtAdress.Click += new System.EventHandler(this.txtAdress_Click);
            this.txtAdress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdress_MouseClick);
            this.txtAdress.Enter += new System.EventHandler(this.txtAdress_Enter);
            this.txtAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdress_KeyPress);
            this.txtAdress.Leave += new System.EventHandler(this.txtAdress_Leave);
            this.txtAdress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtAdress_MouseMove);
            // 
            // pnWeb
            // 
            this.pnWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnWeb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnWeb.Location = new System.Drawing.Point(0, 40);
            this.pnWeb.Name = "pnWeb";
            this.pnWeb.Size = new System.Drawing.Size(1350, 689);
            this.pnWeb.TabIndex = 3;
            this.pnWeb.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnWeb_ControlAdded);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAdress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 40);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsForms_GiuaKy.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(91, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackgroundImage = global::WindowsForms_GiuaKy.Properties.Resources.go_icon;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGo.Location = new System.Drawing.Point(48, 5);
            this.btnGo.Margin = new System.Windows.Forms.Padding(6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(40, 30);
            this.btnGo.TabIndex = 4;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::WindowsForms_GiuaKy.Properties.Resources.back_icon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(5, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnWeb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(455, 256);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WVN Brower";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Panel pnWeb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button button1;
    }
}

