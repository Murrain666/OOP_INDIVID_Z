using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_INDIVID_Z
{
    public class Dogovor
    {
        private string dog_Cl;  //Данные клиента
        private string dog_Kv;  //Данные квартиры
        private double st_Kv;   //Стоимость квартиры в сутки
        private int dog_dn;     //количество дней аренды квартиры
        private string text_dog;    //текст договора
        private int dog_sm;         //сумма договора

        public Dogovor(Client Cl1, Kvart Kv1, int dog_dn)
        {
            this.dog_Cl = Cl1.showcl();
            this.dog_Kv = Kv1.showkv();
            this.st_Kv = Kv1.getStKv();
            this.dog_dn = dog_dn;
            this.dog_sm = (int)(st_Kv * dog_dn);
            this.text_dog = $"Договор аренды Данные клиента: {this.dog_Cl} Данные квартиры: {this.dog_Kv} срок договора {this.dog_dn} дней, стоимость аренды {this.dog_sm}";
            
        }

        public string getDog()
        {
            return this.text_dog;
        }
    }
}
