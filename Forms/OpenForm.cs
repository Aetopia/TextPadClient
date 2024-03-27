using System.Drawing;
using System.Windows.Forms;

class OpenForm : Form
{
    public OpenForm()
    {
        Text = "Open";
        Font = SystemFonts.MessageBoxFont;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MinimizeBox = MaximizeBox = false;
        ClientSize = new(952 / 2, 513 / 2);

        TableLayoutPanel tableLayoutPanel = new() { Dock = DockStyle.Fill, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single };
        Controls.Add(tableLayoutPanel);


        ListBox listBox = new()
        {
            Dock = DockStyle.Fill,
            Margin = new(0)
        };

        tableLayoutPanel.RowStyles.Add(new(SizeType.Percent, 89));
        tableLayoutPanel.Controls.Add(listBox);

        Button button = new()
        {
            Text = "Open",
            Anchor = AnchorStyles.Right
        };
        button.Click += (sender, e) =>
        {
            DialogResult = 0;
            Close();
        };
        tableLayoutPanel.RowStyles.Add(new(SizeType.Percent, 11));
        tableLayoutPanel.Controls.Add(button);

    }
}