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
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
            LoadListClient();       //загружаем список описаний клиентов из файла ListClient
            LoadListKV();           //загружаем список описаний квартир из файла ListKV

        }
        List<string> listkv = new List<string>();
        List<string> listCl = new List<string>();

        public static Client curClient;
        public Kvart curKV;
        public static Dogovor curDgv;
        public static QueueKV queueReq = new QueueKV();
        public static int dlitDgv;

        string curNameCl;
        string curBdateCl;
        string curNtelCl;

        string curAdrKV;
        string curSKV;
        string curNkKV;
        string curVKV;

        private void LoadListKV()
        {
            //читаем описания квартир из файла ListKV.txt
            try
            {
                FileStream fs = new FileStream(@"C:\Users\mayre\Desktop\ListKV.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line;
                while ((line = sr.ReadLine()) != null)
                    listkv.Add(line);
                fs.Close();
            }
            catch
            {
                Console.WriteLine("Нет файла данных");
            }
                        
        }

        private void LoadListClient()
        {
            //читаем описания клиентов из файла ListClient
            try
            {
                FileStream fs = new FileStream(@"C:\Users\mayre\Desktop\ListClient.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line;
                while ((line = sr.ReadLine()) != null)
                    listCl.Add(line);
                fs.Close();
            }
            catch
            {
                Console.WriteLine("Нет файла данных");
            }
                        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //вывести список квартир
            int cnt = listkv.Count;

            for (int j = 0; j < cnt; j++)
            {
                checkedListBoxLKV.Items.Add(listkv[j]);
            }
            cnt = 0;
            //вывести список клиентов
            cnt = listCl.Count;

            for (int j = 0; j < cnt; j++)
            {
                checkedListBoxClients.Items.Add(listCl[j]);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strClient = checkedListBoxClients.Text;
            string[] WordsCl = strClient.Split(' ');
            string curIDcl = WordsCl[1];        //ID выбранного клиента

            string strKV = checkedListBoxLKV.Text;
            string[] WordsKV = strKV.Split(' ');
            string curIDkv = WordsKV[1];        //ID выбранной квартиры

            FileStream fs = new FileStream(@"C:\Users\mayre\Desktop\ClientData.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;

            //читаем данные выбранного клиента из файла ClientData
            
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith(curIDcl))
                    {
                        string[] Words = line.Split(' ');

                        curNameCl = Words[1];      //ФИО выбранного клиента 
                        curBdateCl = Words[2];     //Дата рождения выбранного клиента
                        curNtelCl = Words[3];      //Номер телефона выбранного клиента
                        fs.Close();
                        break;
                    }

                }

            curClient = new Client(curNameCl, curBdateCl, curNtelCl);   //класс выбранный клиент
            curClient.setClID(curIDcl);

            fs = new FileStream(@"C:\Users\mayre\Desktop\KVData.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            line = "";
                        
            //читаем данные выбранной квартиры из файла KVData

            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith(curIDkv))
                {
                    string[] Words = line.Split(' ');

                    curAdrKV = Words[1];        //адрес выбранной квартиры 
                    curSKV = Words[2];          //площадь выбранной квартиры
                    curNkKV = Words[3];         //число комнат в выбранной квартире
                    curVKV = Words[4];          //стоимость в сутки по выбранной квартире
                    fs.Close();
                    break;
                }

            }
                        
            curKV = new Kvart(curAdrKV, Convert.ToDouble(curSKV), Convert.ToInt32(curNkKV), Convert.ToInt32(curVKV)); //класс выбранная квартира
            curKV.setIDkv(Convert.ToInt32(curIDkv));
            queueReq.Add_Item(curKV);       //добавили заявку на текущую квартиру в очередь
            
            dlitDgv = Convert.ToInt32(RentDays.Text);   //длительность договора
                        
        }
    }
}
