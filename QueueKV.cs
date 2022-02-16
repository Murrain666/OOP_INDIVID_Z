using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_INDIVID_Z
{
    public class QueueKV
    {
        List<Kvart> list_kv = new List<Kvart>();

        
        public void Add_Item(Kvart kv)
        {
            list_kv.Add(kv);
        }

        public Kvart Del_Item()
        {
            Kvart kv = list_kv[0];
            list_kv.RemoveAt(0);
            return kv;
        }

        public string ShowlistKV()
        {
            string str = "";
            foreach(Kvart kv in list_kv)
            {
                str += $" {kv.showkv()} ";
            }
            return str;

        }
    }
}
