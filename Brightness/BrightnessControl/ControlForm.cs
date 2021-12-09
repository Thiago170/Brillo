using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrightnessControl
{
  public partial class ControlForm : Form
  {
    public Program program;
    public ControlForm()
    {
      InitializeComponent();
    }
  
    void UpdateBrightness()
    {
      float f = trackBarBrightness.Value * 0.01f;
      if (f < 0.5f)
      {
        program.screenForm.Opacity = 1 - 2 * f;
        program.screenForm.BackColor = Color.Black;
      }
      else
      {
        program.screenForm.Opacity = 2 * (f - 0.5f);
        program.screenForm.BackColor = Color.White;
      }
    }
    private void brightnessBar_ValueChanged(object sender, EventArgs e)
    {
      UpdateBrightness();
    }

    private void ControlForm_FormClosed_1(object sender, FormClosedEventArgs e)
    {
      program.ExitThread();
    }

    private void ControlForm_Load(object sender, EventArgs e)
    {
      UpdateBrightness();
    }
  }
}
