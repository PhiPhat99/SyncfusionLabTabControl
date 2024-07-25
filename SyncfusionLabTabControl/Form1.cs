using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncfusionLabTabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // สร้าง TabControl
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill; // ให้ TabControl ขยายเต็มพื้นที่ฟอร์ม

            // สร้าง TabPage แรก
            TabPage tabPage1 = new TabPage("Tab 1");

            // สร้าง Panel
            Panel panel1 = new Panel();
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(20, 20);
            panel1.Size = new Size(200, 150);

            // เพิ่มคอนโทรลลงใน Panel
            Label labelInPanel = new Label();
            labelInPanel.Text = "Label inside Panel";
            labelInPanel.Location = new Point(10, 10);
            panel1.Controls.Add(labelInPanel);

            TextBox textBoxInPanel = new TextBox();
            textBoxInPanel.Location = new Point(10, 40);
            panel1.Controls.Add(textBoxInPanel);

            Button buttonInPanel = new Button();
            buttonInPanel.Text = "Click Me";
            buttonInPanel.Location = new Point(10, 70);
            buttonInPanel.Click += ButtonInPanel_Click;
            panel1.Controls.Add(buttonInPanel);

            // เพิ่ม Panel ลงใน TabPage
            tabPage1.Controls.Add(panel1);

            // สร้าง TabPage ที่สอง
            TabPage tabPage2 = new TabPage("Tab 2");

            Label label2 = new Label();
            label2.Text = "This is Tab 2";
            label2.Location = new Point(20, 20);
            tabPage2.Controls.Add(label2);

            // เพิ่ม TabPages เข้าไปใน TabControl
            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);

            // เพิ่ม TabControl ลงในฟอร์ม
            this.Controls.Add(tabControl);
        }

        private void ButtonInPanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button inside Panel clicked!");
        }
    }
}
