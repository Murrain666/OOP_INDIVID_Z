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

namespace OOP_INDIVID_Z
{
    public partial class FClient : Form
    {
        public FClient()
        {
            InitializeComponent();
        }
        private static List<Client> lcl = new List<Client>();
        FileInfo f1 = new FileInfo(@"C:\Users\mayre\Desktop\ClientData.txt");
        FileInfo f2 = new FileInfo(@"C:\Users\mayre\Desktop\ListClient.txt");

        Client cl1;

        internal static List<Client> Lcl { get => lcl; set => lcl = value; }

        private void AddClient_Click(object sender, EventArgs e)
        {
            StreamWriter sw1 = f1.AppendText();
            StreamWriter sw2 = f2.AppendText();
            cl1 = new Client(clname.Text, clbdate.Text, ntel.Text);
            Lcl.Add(cl1);
            sw1.WriteLine(cl1.saveCldata());    //пишем данные клиента (ID, ФИО, дата рождения, номер телефона) в файл ClientData.txt
            sw2.WriteLine(cl1.showcl());        //сохраняем описание клиента в файл ListClient.txt
            listBoxClient.Items.Add(cl1.showcl());  //выводим описание клиента на экран
            sw1.Close();
            sw2.Close();
        }

        private void buttonClCl_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }
    }
}
