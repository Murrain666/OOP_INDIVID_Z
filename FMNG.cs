using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_INDIVID_Z
{
    public partial class FMNG : Form
    {
        FClient frClient;
        FormKV frKV;
        public static Dogovor curDgv;

        public FMNG()
        {
            InitializeComponent();
            frClient = new FClient();       //форма для ввода данных клиентов
            frKV = new FormKV();            //форма для ввода данных о квартирах
        }

        private void linkLabel_AddClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frClient.Show();
        }

        private void linkLabel_AddKV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frKV.Show();
        }

        private void buttonToDgv_Click(object sender, EventArgs e)
        {
            //утвердить заявку клиента из очереди
            Kvart kv = FUser.queueReq.Del_Item();

            listBox1.Items.Add(item: $"Заявка клиента {FUser.curClient.showcl()} утверждена");
            listBox1.Items.Add(item: $"Квартира {kv.showkv()}");
            
            curDgv = new Dogovor(FUser.curClient, kv, FUser.dlitDgv);   //класс Договор с текущими Клиентом и Квартирой
            listBox1.Items.Add(curDgv.getDog());
        }

        private void linkLabel_Reqs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //показать список заявок
            listBox1.Items.Add(FUser.queueReq.ShowlistKV());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //заявка отклонена
            Kvart kv = FUser.queueReq.Del_Item();
            listBox1.Items.Add(item: $"Заявка клиента {FUser.curClient.showcl()} отклонена");
            listBox1.Items.Add(item: $"Квартира {kv.showkv()}");
        }
    }
}
