using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_INDIVID_Z
{
    public class Client
    {
        private string clID;            //ID клиента
        private string clname;          //ФИО клиента
        private string clbdate;         //дата рождения
        private string ntel;            //номер телефона
        public static int nextID = 0;
        private string opis_cl;         //описание клиента
        private string dataCltoFile;    //данные клиента для записи в файл

        public Client(string clname, string clbdate, string ntel)
        {
            this.clname = clname;
            this.clbdate = clbdate;
            this.ntel = ntel;
            nextID++;
            this.clID = clname[0] + nextID.ToString();
            this.opis_cl = $"ID {this.clID} ФИО {this.clname} дата рождения: {this.clbdate}, номер телефона {this.ntel}";
            this.dataCltoFile = $"{this.clID} {this.clname} {this.clbdate} {this.ntel}";
        }

        public string getclID()
        {
            return clID;
        }
        public void setClID(string tID)
        {
            clID = tID;
        }

        public void setclkvr()
        {
            // задать рейтинг квартиры
        }
        public string showcl()
        {
            return this.opis_cl;    //возвращает текстовое описание клиента
        }
        public string saveCldata()
        {
            return this.dataCltoFile;   //возвращает данные клиента для записи в файл
        }

    }
}
