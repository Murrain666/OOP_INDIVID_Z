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
    public partial class FormKV : Form
    {
        public FormKV()
        {
            InitializeComponent();
        }
        private static List<Kvart> lkv = new List<Kvart>();
        FileInfo f1 = new FileInfo(@"C:\Users\mayre\Desktop\KVdata.txt");
        FileInfo f2 = new FileInfo(@"C:\Users\mayre\Desktop\ListKV.txt");

        Kvart kvart1;
        internal static List<Kvart> Lkv => lkv; //для доступа к списку объектов квартир

        private void buttonAddKv_Click(object sender, EventArgs e)
        {
            StreamWriter sw1 = f1.AppendText();
            StreamWriter sw2 = f2.AppendText();
            kvart1 = new Kvart(adres.Text, Convert.ToDouble(s_kv.Text), Convert.ToInt32(n_kv.Text), Convert.ToInt32(v_kv.Text));
            lkv.Add(kvart1);        //экземпляр класса КВАРТИРА записывается в List lkv
            sw1.WriteLine(kvart1.saveKVdata());   //сохраняем данные квартиры (ID, адрес, число комнат, площадь, стоимость с сутки) в файл KVdata.txt
            sw2.WriteLine(kvart1.showkv());   //сохраняем описание квартиры в файл ListKV.txt
            listBoxKv.Items.Add(kvart1.showkv());
            sw1.Close();
            sw2.Close();
        }

        private void buttonClFl_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();  //закрыть форму КВАРТИРЫ
        }
    }
}
