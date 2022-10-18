using System.Windows.Forms;

namespace FrontendDesktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_solo = new System.Windows.Forms.PictureBox();
            this.pb_duo = new System.Windows.Forms.PictureBox();
            this.pb_placar = new System.Windows.Forms.PictureBox();
            this.pb_cores = new System.Windows.Forms.PictureBox();
            this.tm_solo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_solo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_duo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_placar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cores)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_solo
            // 
            this.pb_solo.Image = ((System.Drawing.Image)(resources.GetObject("pb_solo.Image")));
            this.pb_solo.Location = new System.Drawing.Point(548, 85);
            this.pb_solo.Name = "pb_solo";
            this.pb_solo.Size = new System.Drawing.Size(150, 73);
            this.pb_solo.TabIndex = 4;
            this.pb_solo.TabStop = false;
            this.pb_solo.Click += new System.EventHandler(this.pb_solo_Click);
            this.pb_solo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_solo_MouseClick);
            this.pb_solo.MouseEnter += new System.EventHandler(this.pb_solo_MouseEnter);
            this.pb_solo.MouseLeave += new System.EventHandler(this.pb_solo_MouseLeave);
            // 
            // pb_duo
            // 
            this.pb_duo.Image = ((System.Drawing.Image)(resources.GetObject("pb_duo.Image")));
            this.pb_duo.Location = new System.Drawing.Point(548, 178);
            this.pb_duo.Name = "pb_duo";
            this.pb_duo.Size = new System.Drawing.Size(150, 73);
            this.pb_duo.TabIndex = 5;
            this.pb_duo.TabStop = false;
            this.pb_duo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_duo_MouseClick);
            this.pb_duo.MouseEnter += new System.EventHandler(this.pb_duo_MouseEnter);
            this.pb_duo.MouseLeave += new System.EventHandler(this.pb_duo_MouseLeave);
            // 
            // pb_placar
            // 
            this.pb_placar.Image = global::FrontendDesktop.Properties.Resources.placar_fix_2;
            this.pb_placar.Location = new System.Drawing.Point(548, 271);
            this.pb_placar.Name = "pb_placar";
            this.pb_placar.Size = new System.Drawing.Size(150, 73);
            this.pb_placar.TabIndex = 6;
            this.pb_placar.TabStop = false;
            this.pb_placar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_placar_MouseClick);
            this.pb_placar.MouseEnter += new System.EventHandler(this.pb_placar_MouseEnter);
            this.pb_placar.MouseLeave += new System.EventHandler(this.pb_placar_MouseLeave);
            // 
            // pb_cores
            // 
            this.pb_cores.Image = global::FrontendDesktop.Properties.Resources.cores_fix_2;
            this.pb_cores.Location = new System.Drawing.Point(548, 363);
            this.pb_cores.Name = "pb_cores";
            this.pb_cores.Size = new System.Drawing.Size(150, 73);
            this.pb_cores.TabIndex = 7;
            this.pb_cores.TabStop = false;
            this.pb_cores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_cores_MouseClick);
            this.pb_cores.MouseEnter += new System.EventHandler(this.pb_cores_MouseEnter);
            this.pb_cores.MouseLeave += new System.EventHandler(this.pb_cores_MouseLeave);
            // 
            // tm_solo
            // 
            this.tm_solo.Interval = 500;
            this.tm_solo.Tick += new System.EventHandler(this.tm_solo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pb_cores);
            this.Controls.Add(this.pb_placar);
            this.Controls.Add(this.pb_duo);
            this.Controls.Add(this.pb_solo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_solo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_duo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_placar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pb_solo;
        private PictureBox pb_duo;
        private PictureBox pb_placar;
        private PictureBox pb_cores;
        private System.Windows.Forms.Timer tm_solo;
        private TrackBar trackBar1;
    }
}