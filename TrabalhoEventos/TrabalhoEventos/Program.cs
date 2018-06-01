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
        public static List<EquipeConvidado> cadastroEquipeConvidado = new List<EquipeConvidado>();
        public static List<CcFuncAdmin> FAdmin = new List<CcFuncAdmin>();
        public static List<CcFuncJogos> FJogos = new List<CcFuncJogos>();
        public static List<CcFuncTerceirizado> FTerceirizado = new List<CcFuncTerceirizado>();
        public static List<CcFuncAlimentação> FAlimentação = new List<CcFuncAlimentação>();
        public static List<AtendimentoJogador> atendimentoAoJogador = new List<AtendimentoJogador>();
        public static List<Equipamento> cadastroDeEquipamento = new List<Equipamento>();
        public static List<Convidados> cadastroDeConvidados = new List<Convidados>();

        // Alan
        public static List<CCampeonato> ccampeonatos = new List<CCampeonato>();
        public static List<CEquipes> cequipes = new List<CEquipes>();
        public static List<CJogador> cjogadores = new List<CJogador>();
        public static List<CPatrocinador> cpatrocinadores = new List<CPatrocinador>();
        
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
