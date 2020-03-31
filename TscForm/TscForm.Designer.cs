namespace TscForm
{
    partial class TscForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TscForm));
            this.axMsTscAxNotSafeForScripting1 = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.axMsTscAxNotSafeForScripting1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMsTscAxNotSafeForScripting1
            // 
            this.axMsTscAxNotSafeForScripting1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMsTscAxNotSafeForScripting1.Enabled = true;
            this.axMsTscAxNotSafeForScripting1.Location = new System.Drawing.Point(0, 0);
            this.axMsTscAxNotSafeForScripting1.Name = "axMsTscAxNotSafeForScripting1";
            this.axMsTscAxNotSafeForScripting1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsTscAxNotSafeForScripting1.OcxState")));
            this.axMsTscAxNotSafeForScripting1.Size = new System.Drawing.Size(640, 431);
            this.axMsTscAxNotSafeForScripting1.TabIndex = 1;
            // 
            // TscForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 431);
            this.Controls.Add(this.axMsTscAxNotSafeForScripting1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TscForm";
            this.Text = "远程桌面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TscForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TscForm_FormClosed);
            this.Load += new System.EventHandler(this.TscForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axMsTscAxNotSafeForScripting1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting axMsTscAxNotSafeForScripting1;

    }
}