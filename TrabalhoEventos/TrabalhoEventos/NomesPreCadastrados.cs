using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJogadores
{
    class NomesPreCadastrados
    {
        static NomesPreCadastrados()
        {

            // precadastros dos campeonatos


            Program.ccampeonatos.Add(new CCampeonato()
            {
                nomeDocampeonato = "Cyberathlete Professional League",
                nomeDoJogo = "Cs_Go Online",
                salaDoJogo = "Sala 2 : ps1, ps2, ps3, ps4",
                tipoDeEquipamento = "PlayStation",
                generoDoJogo = "Jogo on-line",
                dataCampeonato = "Qua",
                horaCampeonato = "15: 00",
                premio1 = "120,00",
                premio2 = "100,00",
                premio3 = "070,00",
                nivel = "Medium",      
                quantidadeEquipes = 5,
                taxaEquipe = "30,00"
                
            });

            Program.ccampeonatos.Add(new CCampeonato()
            {
                nomeDocampeonato = "World Cyber Games",
                nomeDoJogo = "Gta San andreas",
                salaDoJogo = "Sala 1 :  pc ",
                tipoDeEquipamento = "Pc",
                generoDoJogo = "Ação",
                dataCampeonato = "Dom",
                horaCampeonato = "22: 00",
                premio1 = "100,00",
                premio2 = "070,00",
                premio3 = "030,00",
                nivel = "Medium",
                quantidadeEquipes = 15,
                taxaEquipe = "15,00"

            });

            Program.ccampeonatos.Add(new CCampeonato()
            {
                nomeDocampeonato = "Electronic Sports World Cup",
                nomeDoJogo = "Fortnite",
                salaDoJogo = "Sala 3 : nitendo Xbox 360, Xbox one",
                tipoDeEquipamento = "Xbox/Nitendo",
                generoDoJogo = "Jogo Online",
                dataCampeonato = "Sex",
                horaCampeonato = "17: 00",
                premio1 = "300,00",
                premio2 = "200,00",
                premio3 = "100,00",
                nivel = "Medium",
                quantidadeEquipes = 40,
                taxaEquipe = "15,00"

            });

            Program.ccampeonatos.Add(new CCampeonato()
            {
                nomeDocampeonato = "Major League Gaming",
                nomeDoJogo = "Point Blank",
                salaDoJogo = "Sala 1 :  pc ",
                tipoDeEquipamento = "Pc",
                generoDoJogo = "Jogo Online",
                dataCampeonato = "Dom",
                horaCampeonato = "21: 00",
                premio1 = "500,00",
                premio2 = "250,00",
                premio3 = "100,00",
                nivel = "Hard",
                quantidadeEquipes = 12,
                taxaEquipe = "50,00"

            });



        }

    }
}
