using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikDestekDepartman
{
    public partial class Form1 : Form
    {
        TeknikDepartmanEntities teknik;
        public Form1()
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (teknik=new TeknikDepartmanEntities())
            {
                if (teknik.Users.Any(x=>x.UserName==textBox1.Text))
                {
                    if (teknik.Users.FirstOrDefault(x=>x.UserName==textBox1.Text).Password==textBox2.Text)
                    {
                        Tickettt t = new Tickettt();
                        t.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Yanlış");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı bulunmamaktadır.");
                }
            } 
        }
    }
}
