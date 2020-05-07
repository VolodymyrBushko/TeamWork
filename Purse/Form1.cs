using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCardDll;
using Money;
using CreditCardGid;

namespace Purse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //sasasa
           
            //asadawwd
            ///www
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditCardGid.CreditCard creditCard = new CreditCard();
            creditCard.Number_Credit_Card();
        }
    }
}
