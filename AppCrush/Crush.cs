using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCrush
{
    public partial class Form : System.Windows.Forms.Form
    {
        string fileContent = "content.conf";
        string[] lines = { "Anh đồng ý làm người yêu em nhé <3","Em biết anh sẽ đồng ý mà <3"};
        public Form()
        {
            InitializeComponent();
            if (!File.Exists(fileContent))
            {
                using (File.Create(fileContent)) { };
            }
            else
            {
                string[] readFile = File.ReadAllLines(fileContent);
                MessageBox.Show(readFile.Count().ToString());
                if (readFile.Count() == 2)

                    readFile.CopyTo(lines, 0);
            }
            lbCaption.Text = lines[0];

           
        }

        private void bt_kdy_MouseHover(object sender, EventArgs e)
        {
            bt_kdy.Text = "Đồng ý";
            bt_kdy.ForeColor = Color.Red;
        }

        private void bt_kdy_MouseLeave(object sender, EventArgs e)
        {
            bt_kdy.ForeColor = Color.Black;
            bt_kdy.Text = "Không đồng ý";
        }

        private void bt_dy_Click(object sender, EventArgs e)
        {          
            MessageBox.Show(lines[1]);
        }

        private void bt_kdy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lines[1]);
        }
    }
}
