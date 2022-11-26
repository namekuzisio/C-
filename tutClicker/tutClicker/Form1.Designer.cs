namespace tutClicker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbToggle = new System.Windows.Forms.CheckBox();
            this.sldCPS = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.lbCPS = new System.Windows.Forms.Label();
            this.LeftClicker = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.cbSiftD = new System.Windows.Forms.CheckBox();
            this.btBind = new System.Windows.Forms.Button();
            this.Bind = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbToggle
            // 
            resources.ApplyResources(this.cbToggle, "cbToggle");
            this.cbToggle.Name = "cbToggle";
            this.cbToggle.UseVisualStyleBackColor = true;
            // 
            // sldCPS
            // 
            resources.ApplyResources(this.sldCPS, "sldCPS");
            this.sldCPS.Maximum = 20;
            this.sldCPS.Minimum = 5;
            this.sldCPS.Name = "sldCPS";
            this.sldCPS.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.sldCPS.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sldCPS.Value = 10;
            this.sldCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sldCPS_Scroll);
            // 
            // lbCPS
            // 
            resources.ApplyResources(this.lbCPS, "lbCPS");
            this.lbCPS.Name = "lbCPS";
            // 
            // LeftClicker
            // 
            this.LeftClicker.Enabled = true;
            this.LeftClicker.Tick += new System.EventHandler(this.LeftClicker_Tick);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // cbSiftD
            // 
            resources.ApplyResources(this.cbSiftD, "cbSiftD");
            this.cbSiftD.Name = "cbSiftD";
            this.cbSiftD.UseVisualStyleBackColor = true;
            // 
            // btBind
            // 
            resources.ApplyResources(this.btBind, "btBind");
            this.btBind.Name = "btBind";
            this.btBind.UseVisualStyleBackColor = true;
            this.btBind.Click += new System.EventHandler(this.btBind_Click);
            this.btBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btBind_KeyUp);
            // 
            // Bind
            // 
            this.Bind.Enabled = true;
            this.Bind.Interval = 150;
            this.Bind.Tick += new System.EventHandler(this.Bind_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBind);
            this.Controls.Add(this.cbSiftD);
            this.Controls.Add(this.lbCPS);
            this.Controls.Add(this.sldCPS);
            this.Controls.Add(this.cbToggle);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbToggle;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar sldCPS;
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.Timer LeftClicker;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.CheckBox cbSiftD;
        private System.Windows.Forms.Button btBind;
        private System.Windows.Forms.Timer Bind;
    }
}

