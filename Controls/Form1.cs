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
        RichTextBox namesList;

        ComboBox fontSize;
        ComboBox fontType;

        public Form1()
        {
            InitializeComponent();
            InitializeTabControl();
            tab1_load();
            tab2_load();
            tab3_load();
        }

        private void InitializeTabControl()
        {
            myTabControl = new TabControl();
            myTabControl.Dock = DockStyle.Fill;
            this.Controls.Add(myTabControl);

            TabPage tabPage1 = new TabPage("Tab 1");
            TabPage tabPage2 = new TabPage("Tab 2");
            TabPage tabPage3 = new TabPage("Tab 3");

            myTabControl.TabPages.Add(tabPage1);
            myTabControl.TabPages.Add(tabPage2);
            myTabControl.TabPages.Add(tabPage3);
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

            tabPage1.Controls.Add(writeName);
            tabPage1.Controls.Add(addName);
            tabPage1.Controls.Add(sortList);
            tabPage1.Controls.Add(names);
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
            TabPage tabPage2 = myTabControl.TabPages[1];
            
        }
        private void tab3_load()
        {

            TabPage tabPage2 = myTabControl.TabPages[2];
           
        }

    }

}