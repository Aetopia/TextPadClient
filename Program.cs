using System;
using System.Windows.Forms;
using System.Net.Http;

static class Program
{
  static void Main()
  {
    Application.EnableVisualStyles();
    HttpClient httpClient = new();
    string token = new LoginForm(httpClient).GetToken();
    if (token != null)
      new MainForm(httpClient, token).ShowDialog();
  }
}