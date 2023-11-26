using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Controls
{
    public partial class Form1 : Form
    {
        TabControl myTabControl;

        TextBox writeName;
        Button addName;
        Button sortList;
        RichTextBox names;

        ComboBox fontSize;
        ComboBox fontType;
        RadioButton radioButton1;
        RadioButton radioButton2;
        RadioButton radioButton3;
        RadioButton radioButton4;
        RichTextBox formatText;

        List<string> nameList1 = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InitializeTabControl();
            tab1_load();
            tab2_load();

            fontType.SelectedItem = "Times New Roman";
        }

        private void InitializeTabControl()
        {
            myTabControl = new TabControl();
            myTabControl.Dock = DockStyle.Fill;
            this.Controls.Add(myTabControl);

            TabPage tabPage1 = new TabPage("Tab 1");
            TabPage tabPage2 = new TabPage("Tab 2");
            myTabControl.TabPages.Add(tabPage1);
            myTabControl.TabPages.Add(tabPage2);
        }

        private void tab1_load()
        {
            writeName = new TextBox();
            writeName.Text = "Write name";
            writeName.Location = new Point(20, 100);
            writeName.Size = new Size(290, 200);
            writeName.Click += writeName_Click;
            writeName.Focus();

            addName = new Button();
            addName.Text = "Add name";
            addName.Location = new Point(20, 150);
            addName.Size = new Size(100, 30);
            addName.Click += addName_Click;

            sortList = new Button();
            sortList.Text = "Sort names";
            sortList.Location = new Point(130, 150);
            sortList.Size = new Size(100, 30);
            sortList.Click += sortList_Click;

            names = new RichTextBox();
            names.Location = new Point(350, 100);
            names.Size = new Size(350, 300);
            names.ReadOnly = false;

            tab1.Controls.Add(writeName);
            tab1.Controls.Add(addName);
            tab1.Controls.Add(sortList);
            tab1.Controls.Add(names);
        }

        private void writeName_Click(object sender, EventArgs e)
        {
            writeName.SelectAll();
        }

        private void addName_Click(object sender, EventArgs e)
        {
            string newName = writeName.Text;
            names.AppendText(newName + "\n");
            writeName.Clear();
        }

        private void sortList_Click(object sender, EventArgs e)
        {
            string[] namesArray = names.Lines;
            Array.Sort(namesArray);
            names.Lines = namesArray;
        }

        private void tab2_load()
        {
            Panel panel = new Panel();
            panel.AutoSize = true;

            fontSize = new ComboBox();
            fontSize.Location = new Point(10, 50);
            for (int i = 10; i < 25; i += 2)
            {
                fontSize.Items.Add(i.ToString());
            }
            fontSize.SelectedIndex = 0;
            fontSize.SelectedIndexChanged += fontChange;
            panel.Controls.Add(fontSize);

            fontType = new ComboBox();
            fontType.Location = new Point(fontSize.Location.X, fontSize.Location.Y + 35);
            fontType.Items.Add("Times New Roman");
            fontType.Items.Add("Verdana");
            fontType.Items.Add("Georgia");
            fontType.SelectedIndexChanged += fontChange;
            panel.Controls.Add(fontType);

            formatText = new RichTextBox();
            formatText.Size = new Size(350, 300);
            formatText.Location = new Point(fontSize.Width + 40, fontSize.Location.Y);
            formatText.Text = "Format me!";
            string font = fontType.SelectedItem?.ToString();
            panel.Controls.Add(formatText);

            radioButton1 = new RadioButton();
            radioButton1.Location = new Point(fontType.Location.X, fontType.Location.Y + 40);
            radioButton1.Text = ("No type");
            panel.Controls.Add(radioButton1);
            radioButton1.CheckedChanged += fontChange;
            radioButton1.Checked = true;

            radioButton2 = new RadioButton();
            radioButton2.Location = new Point(radioButton1.Location.X, radioButton1.Location.Y + 20);
            radioButton2.Text = ("Bold");
            panel.Controls.Add(radioButton2);
            radioButton2.CheckedChanged += fontChange;

            radioButton3 = new RadioButton();
            radioButton3.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y + 20);
            radioButton3.Text = ("Cursive");
            panel.Controls.Add(radioButton3);
            radioButton3.CheckedChanged += fontChange;

            radioButton4 = new RadioButton();
            radioButton4.Location = new Point(radioButton3.Location.X, radioButton3.Location.Y + 20);
            radioButton4.Text = ("Underline");
            panel.Controls.Add(radioButton4);
            radioButton4.CheckedChanged += fontChange;

            panel.Location = new Point(ClientSize.Width / 2 - panel.Width / 2, ClientSize.Height / 2 - panel.Width / 2);

            tab2.Controls.Add(fontSize);
            tab2.Controls.Add(fontType);
            tab2.Controls.Add(radioButton1);
            tab2.Controls.Add(radioButton2);
            tab2.Controls.Add(radioButton3);
            tab2.Controls.Add(radioButton4);
            tab2.Controls.Add(formatText);
        }

        private void fontChange(object? sender, EventArgs e)
        {
                string font = fontType.SelectedItem?.ToString();
                int Size;
                int.TryParse(fontSize.SelectedItem.ToString(), out Size);
                if (radioButton1.Checked)
                {
                    formatText.Font = new Font(font, Size);
                }
                else if (radioButton2.Checked)
                {
                    formatText.Font = new Font(font, Size, FontStyle.Bold);
                }
                else if (radioButton3.Checked)
                {
                    formatText.Font = new Font(font, Size, FontStyle.Italic);
                }
                else if (radioButton4.Checked)
                {
                    formatText.Font = new Font(font, Size, FontStyle.Underline);
                }
        }

    }
}