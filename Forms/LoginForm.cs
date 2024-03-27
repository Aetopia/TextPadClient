using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;

class LoginForm : Form
{
    public FormUrlEncodedContent Token = null;

    public LoginForm()
    {
        Text = "Login";
        Font = SystemFonts.MessageBoxFont;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MinimizeBox = MaximizeBox = false;
        ClientSize = new(800 / 4, (int)(600 / 4.6));

        TableLayoutPanel tableLayoutPanel = new() { Dock = DockStyle.Fill };
        Controls.Add(tableLayoutPanel);

        tableLayoutPanel.Controls.Add(new Label
        {
            Text = "Username",
            AutoSize = true,
            TextAlign = ContentAlignment.BottomLeft
        });

        TextBox textBox1 = new() { Dock = DockStyle.Fill };
        tableLayoutPanel.Controls.Add(textBox1);

        tableLayoutPanel.Controls.Add(new Label
        {
            Text = "Password",
            AutoSize = true,
            TextAlign = ContentAlignment.BottomLeft
        });

        TextBox textBox2 = new()
        {
            UseSystemPasswordChar = true,
            Dock = DockStyle.Fill
        };
        tableLayoutPanel.Controls.Add(textBox2);

        StatusBar statusBar = new() { };
        Controls.Add(statusBar);

        Button button1 = new()
        {
            Text = "Login",
            Dock = DockStyle.Right
        };
        button1.Click += (sender, e) =>
        {
            DialogResult = DialogResult.OK;
            Close();
        };
        statusBar.Controls.Add(button1);

        Button button2 = new()
        {
            Text = "Register",
            Dock = DockStyle.Left
        };
        button2.Click += (sender, e) =>
        {
            DialogResult = DialogResult.Yes;
            Close();
        };
        statusBar.Controls.Add(button2);

        FormClosed += (sender, e) =>
        {
            Token = new FormUrlEncodedContent(
                new Dictionary<string, string>
                {
                    { "username", textBox1.Text },
                    { "password", textBox2.Text }
                });
        };

        CenterToScreen();
        ShowDialog();
    }
}