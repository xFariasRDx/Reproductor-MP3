namespace Reproductor_MnM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.PbDetener = new System.Windows.Forms.PictureBox();
            this.PbPausar = new System.Windows.Forms.PictureBox();
            this.PbReproducir = new System.Windows.Forms.PictureBox();
            this.PbCargar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelReproductor = new System.Windows.Forms.Panel();
            this.PbSiguiente = new System.Windows.Forms.PictureBox();
            this.PbAnterior = new System.Windows.Forms.PictureBox();
            this.PbPlayPause = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.macTrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.macTrackStatus = new XComponent.SliderBar.MACTrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelmacTrack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPausar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelReproductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelmacTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstCanciones);
            this.splitContainer1.Panel1.Controls.Add(this.PbDetener);
            this.splitContainer1.Panel1.Controls.Add(this.PbPausar);
            this.splitContainer1.Panel1.Controls.Add(this.PbReproducir);
            this.splitContainer1.Panel1.Controls.Add(this.PbCargar);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.panelReproductor);
            this.splitContainer1.Size = new System.Drawing.Size(860, 453);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstCanciones
            // 
            this.lstCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(153)))), ((int)(((byte)(172)))));
            this.lstCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCanciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 16;
            this.lstCanciones.Location = new System.Drawing.Point(0, 53);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(202, 224);
            this.lstCanciones.TabIndex = 9;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // PbDetener
            // 
            this.PbDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.PbDetener.Image = ((System.Drawing.Image)(resources.GetObject("PbDetener.Image")));
            this.PbDetener.Location = new System.Drawing.Point(154, 3);
            this.PbDetener.Name = "PbDetener";
            this.PbDetener.Size = new System.Drawing.Size(43, 44);
            this.PbDetener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbDetener.TabIndex = 8;
            this.PbDetener.TabStop = false;
            this.PbDetener.Click += new System.EventHandler(this.PbDetener_Click);
            // 
            // PbPausar
            // 
            this.PbPausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.PbPausar.Image = ((System.Drawing.Image)(resources.GetObject("PbPausar.Image")));
            this.PbPausar.Location = new System.Drawing.Point(105, 3);
            this.PbPausar.Name = "PbPausar";
            this.PbPausar.Size = new System.Drawing.Size(43, 44);
            this.PbPausar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbPausar.TabIndex = 7;
            this.PbPausar.TabStop = false;
            this.PbPausar.Click += new System.EventHandler(this.PbPausar_Click);
            // 
            // PbReproducir
            // 
            this.PbReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.PbReproducir.Image = ((System.Drawing.Image)(resources.GetObject("PbReproducir.Image")));
            this.PbReproducir.Location = new System.Drawing.Point(56, 3);
            this.PbReproducir.Name = "PbReproducir";
            this.PbReproducir.Size = new System.Drawing.Size(43, 44);
            this.PbReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbReproducir.TabIndex = 6;
            this.PbReproducir.TabStop = false;
            this.PbReproducir.Click += new System.EventHandler(this.PbReproducir_Click);
            // 
            // PbCargar
            // 
            this.PbCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.PbCargar.Image = ((System.Drawing.Image)(resources.GetObject("PbCargar.Image")));
            this.PbCargar.Location = new System.Drawing.Point(7, 3);
            this.PbCargar.Name = "PbCargar";
            this.PbCargar.Size = new System.Drawing.Size(43, 44);
            this.PbCargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbCargar.TabIndex = 5;
            this.PbCargar.TabStop = false;
            this.PbCargar.Click += new System.EventHandler(this.PbCargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Reproductor_MnM.Properties.Resources.CUTESY_WALLPAPER;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(164, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(371, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panelReproductor
            // 
            this.panelReproductor.AutoSize = true;
            this.panelReproductor.Controls.Add(this.panelmacTrack);
            this.panelReproductor.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelReproductor.Location = new System.Drawing.Point(3, 3);
            this.panelReproductor.Name = "panelReproductor";
            this.panelReproductor.Size = new System.Drawing.Size(633, 453);
            this.panelReproductor.TabIndex = 6;
            // 
            // PbSiguiente
            // 
            this.PbSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("PbSiguiente.Image")));
            this.PbSiguiente.Location = new System.Drawing.Point(316, 21);
            this.PbSiguiente.Name = "PbSiguiente";
            this.PbSiguiente.Size = new System.Drawing.Size(49, 58);
            this.PbSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSiguiente.TabIndex = 3;
            this.PbSiguiente.TabStop = false;
            this.PbSiguiente.Click += new System.EventHandler(this.PbSiguiente_Click);
            // 
            // PbAnterior
            // 
            this.PbAnterior.Image = ((System.Drawing.Image)(resources.GetObject("PbAnterior.Image")));
            this.PbAnterior.Location = new System.Drawing.Point(206, 21);
            this.PbAnterior.Name = "PbAnterior";
            this.PbAnterior.Size = new System.Drawing.Size(49, 58);
            this.PbAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnterior.TabIndex = 2;
            this.PbAnterior.TabStop = false;
            // 
            // PbPlayPause
            // 
            this.PbPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("PbPlayPause.Image")));
            this.PbPlayPause.Location = new System.Drawing.Point(261, 21);
            this.PbPlayPause.Name = "PbPlayPause";
            this.PbPlayPause.Size = new System.Drawing.Size(49, 58);
            this.PbPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPlayPause.TabIndex = 1;
            this.PbPlayPause.TabStop = false;
            this.PbPlayPause.Click += new System.EventHandler(this.PbPlayPause_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // macTrackVolumen
            // 
            this.macTrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.macTrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackVolumen.IndentHeight = 6;
            this.macTrackVolumen.Location = new System.Drawing.Point(413, 43);
            this.macTrackVolumen.Maximum = 100;
            this.macTrackVolumen.Minimum = 0;
            this.macTrackVolumen.Name = "macTrackVolumen";
            this.macTrackVolumen.Size = new System.Drawing.Size(106, 22);
            this.macTrackVolumen.TabIndex = 9;
            this.macTrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackVolumen.TickHeight = 4;
            this.macTrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.macTrackVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(157)))), ((int)(((byte)(158)))));
            this.macTrackVolumen.TrackLineHeight = 3;
            this.macTrackVolumen.TrackLineSelectedColor = System.Drawing.Color.White;
            this.macTrackVolumen.Value = 0;
            this.macTrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackVolumen_ValueChanged);
            // 
            // macTrackStatus
            // 
            this.macTrackStatus.BackColor = System.Drawing.Color.Transparent;
            this.macTrackStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macTrackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackStatus.IndentHeight = 6;
            this.macTrackStatus.Location = new System.Drawing.Point(0, 0);
            this.macTrackStatus.Maximum = 10;
            this.macTrackStatus.Minimum = 0;
            this.macTrackStatus.Name = "macTrackStatus";
            this.macTrackStatus.Size = new System.Drawing.Size(630, 28);
            this.macTrackStatus.TabIndex = 10;
            this.macTrackStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackStatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackStatus.TickHeight = 4;
            this.macTrackStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackStatus.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackStatus.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackStatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(157)))), ((int)(((byte)(158)))));
            this.macTrackStatus.TrackLineHeight = 3;
            this.macTrackStatus.TrackLineSelectedColor = System.Drawing.Color.White;
            this.macTrackStatus.Value = 0;
            this.macTrackStatus.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackStatus_ValueChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(633, 453);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelmacTrack
            // 
            this.panelmacTrack.Controls.Add(this.macTrackStatus);
            this.panelmacTrack.Controls.Add(this.macTrackVolumen);
            this.panelmacTrack.Controls.Add(this.pictureBox3);
            this.panelmacTrack.Controls.Add(this.pictureBox2);
            this.panelmacTrack.Controls.Add(this.PbAnterior);
            this.panelmacTrack.Controls.Add(this.PbPlayPause);
            this.panelmacTrack.Controls.Add(this.PbSiguiente);
            this.panelmacTrack.Location = new System.Drawing.Point(0, 362);
            this.panelmacTrack.Name = "panelmacTrack";
            this.panelmacTrack.Size = new System.Drawing.Size(630, 88);
            this.panelmacTrack.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 453);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M&M";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbDetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPausar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelReproductor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelmacTrack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbDetener;
        private System.Windows.Forms.PictureBox PbPausar;
        private System.Windows.Forms.PictureBox PbReproducir;
        private System.Windows.Forms.PictureBox PbCargar;
        private System.Windows.Forms.PictureBox PbSiguiente;
        private System.Windows.Forms.PictureBox PbAnterior;
        private System.Windows.Forms.PictureBox PbPlayPause;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.Panel panelReproductor;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XComponent.SliderBar.MACTrackBar macTrackStatus;
        private XComponent.SliderBar.MACTrackBar macTrackVolumen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelmacTrack;
    }
}

