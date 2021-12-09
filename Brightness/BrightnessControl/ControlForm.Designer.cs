namespace BrightnessControl
{
  partial class ControlForm
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
      this.trackBarBrightness = new System.Windows.Forms.TrackBar();
      this.lbltitle = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
      this.SuspendLayout();
      // 
      // trackBarBrightness
      // 
      this.trackBarBrightness.Location = new System.Drawing.Point(12, 25);
      this.trackBarBrightness.Maximum = 90;
      this.trackBarBrightness.Minimum = 10;
      this.trackBarBrightness.Name = "trackBarBrightness";
      this.trackBarBrightness.Size = new System.Drawing.Size(260, 45);
      this.trackBarBrightness.TabIndex = 2;
      this.trackBarBrightness.Value = 50;
      this.trackBarBrightness.ValueChanged += new System.EventHandler(this.brightnessBar_ValueChanged);
      // 
      // lbltitle
      // 
      this.lbltitle.AutoSize = true;
      this.lbltitle.Location = new System.Drawing.Point(12, 9);
      this.lbltitle.Name = "lbltitle";
      this.lbltitle.Size = new System.Drawing.Size(92, 13);
      this.lbltitle.TabIndex = 3;
      this.lbltitle.Text = "Brightness Control";
      // 
      // ControlForm
      // 
      this.ClientSize = new System.Drawing.Size(284, 69);
      this.Controls.Add(this.lbltitle);
      this.Controls.Add(this.trackBarBrightness);
      this.Name = "ControlForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlForm_FormClosed_1);
      this.Load += new System.EventHandler(this.ControlForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar trackBarBrightness;
    private System.Windows.Forms.Label lbltitle;
  }
}