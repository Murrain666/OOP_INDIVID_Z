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
    public partial class FInit : Form

    {
        //FClient frClient;
        FMNG frMNG;
        FUser frUser;
        public FInit()
        {
            InitializeComponent();
            //frClient = new FClient();
            frMNG = new FMNG();
            frUser = new FUser();

        }
        private static string pin_manager = "151617";
        private void buttonIn_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text == pin_manager)
            {
                frMNG.Show();
                textBoxPIN.Clear();
            }
            else
            {
                frUser.Show();
            }
            
        }
    }
}
