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
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.CtrlPanel = new System.Windows.Forms.Panel();
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
            this.CtrlPanel.Location = new System.Drawing.Point(0, 242);
            this.CtrlPanel.Name = "CtrlPanel";
            this.CtrlPanel.Size = new System.Drawing.Size(554, 48);
            this.CtrlPanel.TabIndex = 1;
            // 
            // TablesView
            // 
            this.TablesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesView.FullRowSelect = true;
            this.TablesView.Location = new System.Drawing.Point(0, 0);
            this.TablesView.Name = "TablesView";
            this.TablesView.Size = new System.Drawing.Size(554, 242);
            this.TablesView.TabIndex = 2;
            this.TablesView.UseCompatibleStateImageBehavior = false;
            this.TablesView.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 290);
            this.Controls.Add(this.TablesView);
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
        private System.Windows.Forms.ListView TablesView;
    }
}

