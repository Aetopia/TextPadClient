using System;
using System.Drawing;
using System.Windows.Forms;

class MainForm : Form
{
    public MainForm()
    {
        Text = "TextPad";
Font = SystemFonts.MessageBoxFont;

        TableLayoutPanel tableLayoutPanel = new()
        {
            Dock = DockStyle.Fill,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        };
        Controls.Add(tableLayoutPanel);

        MenuStrip menuStrip = new();
        tableLayoutPanel.Controls.Add(menuStrip, 0, 0);

        ToolStripButton toolStripButton1 = new() { Text = "New" },
                        toolStripButton2 = new() { Text = "Save" },
                        toolStripButton3 = new() { Text = "Open" };
        menuStrip.Items.Add(toolStripButton1);
        menuStrip.Items.Add(toolStripButton2);
        menuStrip.Items.Add(toolStripButton3);

        TextBox textBox = new()
        {
            Multiline = true,
            Dock = DockStyle.Fill,
            ScrollBars =ScrollBars.Both
        };
        tableLayoutPanel.Controls.Add(textBox, 0, 1);
    }
}