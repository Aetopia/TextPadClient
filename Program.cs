using System;
using System.Windows.Forms;

static class Program
{
    static void Main()
    {
        Application.EnableVisualStyles();
      Console.WriteLine(new LoginForm().GetToken());
    }
}