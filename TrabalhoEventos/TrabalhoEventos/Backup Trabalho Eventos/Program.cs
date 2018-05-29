using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLivraria
{
    static class Program
    {
        public static List<CcFuncAdmin> FAdmin = new List<CcFuncAdmin>();
        public static List<CcFuncJogos> FJogos = new List<CcFuncJogos>();
        public static List<CcFuncTerceirizado> FTerceirizado = new List<CcFuncTerceirizado>();
        public static List<CcFuncAlimentação> FAlimentação = new List<CcFuncAlimentação>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SistemaFuncionario());
        }
    }
}
