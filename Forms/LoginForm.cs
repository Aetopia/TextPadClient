using System.Drawing;
using System.Windows.Forms;


class LoginForm : Form
{
    public LoginForm()
    {
        Text = "Login";
        Font = SystemFonts.MessageBoxFont;
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
        statusBar.Controls.Add(button1);

        Button button2 = new()
        {
            Text = "Register",
            Dock = DockStyle.Left
        };
        statusBar.Controls.Add(button2);
    }
}