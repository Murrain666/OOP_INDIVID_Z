using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_INDIVID_Z
{
    public class Kvart
    {
        private int ID_kv;  //ID квартиры, присваивается в классе
        private string adres;   //адрес квартиры, вводится с формы
        private double s_kv;    //площадь квартиры, вводится с формы
        private int n_kv;       //количество комнат, вводится с формы
        private int v_kv;       //стоимость аренды квартиры в сутки, вводится с формы
        public string opis_kv;  //описание квартиры, формируется
        public string dataKVtoFile;  //данные квартиры для записи в файл
        public bool st_kv = false;  //статус квартиры свободна = false, занята = true
        public double r_kv = 0;     //оценка квартиры (рейтинг), воодится/рассчитывается
        public static int nextID = 0; //вспомогательная для расчета ID квартиры

        public Kvart(string adres, double s_kv, int n_kv, int v_kv)
        {
            this.adres = adres;
            this.s_kv = s_kv;
            this.n_kv = n_kv;
            this.v_kv = v_kv;
            nextID++;
            this.ID_kv = nextID;
            this.opis_kv = $"Квартира {this.ID_kv} по адресу: {this.adres}, количество комнат {this.n_kv}, площадь {this.s_kv}, стоимость аренды в сутки {this.v_kv}";
            this.dataKVtoFile = $"{this.ID_kv} {this.adres} {this.n_kv} {this.s_kv} {this.v_kv}";
        }

        public int getIDkv()
        {
            //возвращает ID квартиры
            return this.ID_kv;
        }
        public int getStKv()
        {
            //возвращает ставку аренды в сутки
            return this.v_kv;
        }
        public string showkv()
        {
            // показать описание выбранной квартиры
            return this.opis_kv;
        }
        public string saveKVdata()
        {
            // возвращает данные квартиры для архивирования в файл
            return this.dataKVtoFile;
        }
        public double getrkv()
        {
            return this.r_kv;
            // возвращает оценку (рейтинг) квартиры
        }
        
        public void setIDkv(int cID) => ID_kv = cID;
        public bool rentkv()
        {
            // добавить рейтинг
            r_kv += 0.1;
            // установить статус занята
            st_kv = true;
            return st_kv;
        }

       
    }
}
