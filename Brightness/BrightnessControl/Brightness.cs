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
  public partial class Brightness : Form
  {

    public Program program;
    public Brightness()
    {
      InitializeComponent();
    }
    private void ScreenForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      program.ExitThread();
    }
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 0x0084) // WM_NCHITTEST
        m.Result = (IntPtr)(-1); // HTTRANSPARENT
      else
        base.WndProc(ref m);
    }
  }
}
