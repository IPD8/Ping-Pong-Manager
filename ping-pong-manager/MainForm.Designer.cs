namespace ping_pong_control
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.CtrlPanel = new System.Windows.Forms.Panel();
            this.largeImages = new System.Windows.Forms.ImageList(this.components);
            this.smallImages = new System.Windows.Forms.ImageList(this.components);
            this.QueueView = new System.Windows.Forms.ListView();
            this.TablesView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // CtrlPanel
            // 
            this.CtrlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CtrlPanel.Location = new System.Drawing.Point(0, 329);
            this.CtrlPanel.Name = "CtrlPanel";
            this.CtrlPanel.Size = new System.Drawing.Size(804, 45);
            this.CtrlPanel.TabIndex = 1;
            // 
            // largeImages
            // 
            this.largeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImages.ImageStream")));
            this.largeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImages.Images.SetKeyName(0, "table");
            // 
            // smallImages
            // 
            this.smallImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImages.ImageStream")));
            this.smallImages.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImages.Images.SetKeyName(0, "table");
            // 
            // QueueView
            // 
            this.QueueView.Dock = System.Windows.Forms.DockStyle.Right;
            this.QueueView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueView.FullRowSelect = true;
            this.QueueView.LargeImageList = this.largeImages;
            this.QueueView.Location = new System.Drawing.Point(573, 0);
            this.QueueView.Name = "QueueView";
            this.QueueView.Size = new System.Drawing.Size(231, 329);
            this.QueueView.SmallImageList = this.smallImages;
            this.QueueView.TabIndex = 3;
            this.QueueView.UseCompatibleStateImageBehavior = false;
            this.QueueView.View = System.Windows.Forms.View.Details;
            // 
            // TablesView
            // 
            this.TablesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablesView.FullRowSelect = true;
            this.TablesView.LargeImageList = this.largeImages;
            this.TablesView.Location = new System.Drawing.Point(0, 0);
            this.TablesView.Name = "TablesView";
            this.TablesView.Size = new System.Drawing.Size(573, 329);
            this.TablesView.SmallImageList = this.smallImages;
            this.TablesView.TabIndex = 4;
            this.TablesView.UseCompatibleStateImageBehavior = false;
            this.TablesView.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 374);
            this.Controls.Add(this.TablesView);
            this.Controls.Add(this.QueueView);
            this.Controls.Add(this.CtrlPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping-Pong Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Panel CtrlPanel;
        private System.Windows.Forms.ImageList largeImages;
        private System.Windows.Forms.ImageList smallImages;
        private System.Windows.Forms.ListView QueueView;
        private System.Windows.Forms.ListView TablesView;
    }
}

