using System;
using System.Windows.Forms;

static class Program
{
    static void Main()
    {
        Application.EnableVisualStyles();
        new MainForm().ShowDialog();
    }
}