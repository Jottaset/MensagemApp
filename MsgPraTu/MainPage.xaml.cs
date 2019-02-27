using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MsgPraTu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void EscolherOpcao(Object Sender, EventArgs e) {

            string O = "";
            int Op = 0;

            Random random = new Random();

            Op = random.Next(1, 5);

            switch (Op)
            {
                case 1: O = "Uma palavra grosseira, uma expressão bizarra, ensinou-me por vezes mais do que dez belas frases.";
                    break;

                case 2: O = "Frases! Frases! Como se o conforto de todos, diante de um fato que não se explica, diante de um mal que nos consome, " +
                	        "não fosse encontrar uma palavra que não diz nada e na qual nos tranquilizamos!";
                    break;

                case 3: O = "Escrevo como se estivesse dormindo e sonhando: as frases desconexas como no sonho. É difícil ,estando acordado, " +
                	        "sonhar livremente nos meus remotos mistérios.";
                    break;

                case 4: O = "A internet é o unico lugar do mundo que poetas mortos continuam fazendo frases.";
                    break;

                case 5: O = "Se você tenta controlar aquilo que não lhe pertence,\nperde o que lhe pertence.";
                    break;
            }

            label_Op.Text = O;

        }
    }
}
