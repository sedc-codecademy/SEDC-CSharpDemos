using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        private List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            var btnClick = new Button();
            btnClick.Font = new Font("Microsoft Sans Serif", 48F);
            btnClick.Location = new Point(83, 12);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(300, 283);
            btnClick.Text = "Click Me";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += buttonClicked;
            Controls.Add(btnClick);
            buttons.Add(btnClick);

            btnClick = new Button();
            btnClick.Font = new Font("Microsoft Sans Serif", 48F);
            btnClick.Location = new Point(390, 12);
            btnClick.Name = "btnClick2";
            btnClick.Size = new Size(300, 283);
            btnClick.Text = "Click Me 2";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += buttonClicked;

            btnClick.KeyDown += buttonClicked;

            Controls.Add(btnClick);
            buttons.Add(btnClick);

            
        }

        private void buttonClicked(object o, EventArgs e)
        {
            foreach (var formButton in buttons)
            {
                formButton.BackColor = SystemColors.Control;
            }

            Button button = (Button) o;
            button.BackColor = Color.SeaGreen;
            
            lblOutput.Text += "BOO";
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
