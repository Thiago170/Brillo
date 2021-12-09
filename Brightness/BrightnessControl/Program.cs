using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BrightnessControl
{
  public class Program : ApplicationContext
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Program());
    }

    public ControlForm controlForm = new ControlForm();
    public Brightness screenForm = new Brightness();
    Program()
    {
      controlForm.program = screenForm.program = this;
      controlForm.Show();
      screenForm.Show();
    }

  }
}
