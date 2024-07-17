using System.Diagnostics;

namespace fort.winforms
{
  public partial class Form1 : Form
  {
    bool isRunning;
    List<char> keys;
    Random rng;
    public Form1()
    {
      isRunning = false;
      keys = new() { 'w', 'a', 's', 'd', ' ' };
      rng = new();
      InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void buttonRun_Click(object sender, EventArgs e)
    {
      var sw = new Stopwatch();
      isRunning = true;
      buttonRun.Enabled = false;
      buttonStop.Enabled = true;
      buttonRun.BackColor = Color.DarkGray;
      buttonStop.BackColor = Color.Red;
      int secs = (int)comboBoxKeys.SelectedItem! * 1000;
      while (isRunning)
      {
        sw.Restart();
        while (isRunning && sw.ElapsedMilliseconds < secs)
        {
          char key = keys[rng.Next(keys.Count)];
          SendKeys.SendWait((key).ToString());
          Application.DoEvents();
          while (sw.ElapsedMilliseconds % 10 != 0)
          {
            Application.DoEvents();
          }
        }
        
      }
    }

    private void checkBoxW_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxW.Checked)
      {
        keys.Add('w');
      }
      else
      {
        keys.Remove('w');
      }
    }

    private void checkBoxA_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxA.Checked)
      {
        keys.Add('a');
      }
      else
      {
        keys.Remove('a');
      }
    }

    private void checkBoxS_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxS.Checked)
      {
        keys.Add('s');
      }
      else
      {
        keys.Remove('s');
      }
    }

    private void checkBoxD_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxD.Checked)
      {
        keys.Add('d');
      }
      else
      {
        keys.Remove('d');
      }
    }

    private void checkBoxSpace_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxSpace.Checked)
      {
        keys.Add(' ');
      }
      else
      {
        keys.Remove(' ');
      }
    }

    private void buttonStop_Click(object sender, EventArgs e)
    {
      isRunning = false;
      buttonRun.Enabled = true;
      buttonStop.Enabled = false;
      buttonStop.BackColor = Color.DarkGray;
      buttonRun.BackColor = Color.Green;
    }
  }
}
