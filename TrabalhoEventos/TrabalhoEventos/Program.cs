using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJogadores;

namespace SistemaJogadores
{
    static class Program
    {
        public static List<Equipamento> cadastroDeEquipamento = new List<Equipamento>();
        public static List<Convidados> cadastroDeConvidados = new List<Convidados>();
        public static List<CCampeonato> ccampeonatos = new List<CCampeonato>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AngryNerds());
        }
    }
}
