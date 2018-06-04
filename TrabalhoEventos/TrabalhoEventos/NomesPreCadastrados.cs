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

            //Pré cadastros dos cla

            Program.cequipes.Add(new CEquipes() 
            {
                NomeDaEquipe = "Turma Cobol",
                EstadoOrigem = "São Paulo",
                CidadeOrigem = "Osasco",
                NomeLider = "Mariano",
                CpfLider = "789.247.321-78",
                TelefoneLider = "11 34491-2928",
                Pesquisa = "max 1:00 Hr",
                FraseCla = "sei lá nunca programei em cobool",
                ParticipouDoJogo = false,
                GeneroJogo = "Jogo on-line",
                QuantidadeIntegrantes = 5,
                FraseTaca = "___________C#"

            });

            Program.cequipes.Add(new CEquipes() 
            {
                NomeDaEquipe = "Turma de C#",
                EstadoOrigem = "Santa Catarina",
                CidadeOrigem = "Blumenau",
                NomeLider = "Francisco",
                CpfLider = "496.489.458-96",
                TelefoneLider = "47 99816-1423",
                Pesquisa = "max 5:00 Hr",
                FraseCla = "if (C# >>>>> Java) {Sempre};",
                ParticipouDoJogo = true,
                GeneroJogo = "Fps",
                QuantidadeIntegrantes = 18,
                FraseTaca = ">>>>>>>>>>>>>"

            });

            Program.cequipes.Add(new CEquipes() 
            {
                NomeDaEquipe = "Turma de Java",
                EstadoOrigem = "Parana",
                CidadeOrigem = "Curitiba",
                NomeLider = "Ralph",
                CpfLider = "506.987.963-87",
                TelefoneLider = "37 99758-6874",
                Pesquisa = "+ 5:00HR ",
                FraseCla = "mimimi mimi mimi mimi",
                ParticipouDoJogo = false,
                GeneroJogo = "Estrategia",
                QuantidadeIntegrantes = 15,
                FraseTaca = "JV__________________"

            });

            Program.cjogadores.Add(new CJogador()
            {
                 NomeJogador = "Alan Eduardo Alves",
                 DataNascimento = "27/12/2000",
                 Cpf = "493.488.908-67",
                 Rg = "47.651.245-1",
                 Telefone = "14 99816-1423",
                 TelefoneEmergencia = "14 3491-3426",
                 FalarCom = "Denise",
                 Endereco = "Rua Antonio Valverde",
                 NumeroCasa = 1240,
                 Email = "Alaneduardoalves2018@Gmail.com",
                 NomeEquipe = "C# >>>> JV",
                 Estado = "São Paulo",
                 Cidade = "Osasco",
                
            });

            Program.cjogadores.Add(new CJogador()
            {
                 NomeJogador = "Gabriela Da Silva",
                 DataNascimento = "06/05/1997",
                 Cpf = "478.321.852-73",
                 Rg = "33.227.887-6",
                 Telefone = "61 4789-9874",
                 TelefoneEmergencia = "61 98745-8725",
                 FalarCom = "Heloisa",
                 Endereco = "Av. Waldemar",
                 NumeroCasa = 45,
                 Email = "gabrieldasilva@hotmail.com",
                 NomeEquipe = "Não Intendo",
                 Estado = "Parana",
                 Cidade = "Curitiba",
                
            });

            Program.cjogadores.Add(new CJogador()
            {
                 NomeJogador = "Gabriel Vieira de Oliveira",
                 DataNascimento = "12/01/2001",
                 Cpf = "147.896.486-83",
                 Rg = "50.239.306-3",
                 Telefone = "11 99658-8754",
                 TelefoneEmergencia = "11 2626-9845",
                 FalarCom = "Daniel",
                 Endereco = "Rua Armando Sala",
                 NumeroCasa = 70,
                 Email = "c#>Jv2018@outlook.com",
                 NomeEquipe = "Os vingadores",
                 Estado = "Acre",
                 Cidade = "Terra dos dinossauros",
                
            });

            Program.cjogadores.Add(new CJogador()
            {
                 NomeJogador = "Maria Eduarda Santos",
                 DataNascimento = "31/10/1996",
                 Cpf = "123.456.789-36",
                 Rg = "42.823.887-7",
                 Telefone = "78 99745-9872",
                 TelefoneEmergencia = "78 5874-9823",
                 FalarCom = "Arthur",
                 Endereco = "Rua Antonio Zendrom",
                 NumeroCasa = 1896,
                 Email = "MariaeduardaSantos@bool.com",
                 NomeEquipe = "Americam Pie",
                 Estado = "Blumenau",
                 Cidade = "Santa catarina",
                
            });

            Program.cjogadores.Add(new CJogador()
            {
                 NomeJogador = "Rafael Junio Pereira Crispim",
                 DataNascimento = "18/07/2000",
                 Cpf = "741.852.963-73",
                 Rg = "10.466.142-2",
                 Telefone = "47 3441-2988",
                 TelefoneEmergencia = "47 3569-9875",
                 FalarCom = "C# >> JV",
                 Endereco = "Av Amazonas",
                 NumeroCasa = 75354,
                 Email = "C#>JVC#>JV@Gmail.com.br",
                 NomeEquipe = "Sem limites",
                 Estado = "Mato Grosso",
                 Cidade = "Ceilandia",
                
            });

            Program.cpatrocinadores.Add(new CPatrocinador() 
            {
                NomeDoPatrocinador = "Adidas",
                Telefone = "11 3485-9874",
                Cpf = "60.225.194/0001-55",
                NomeDaEquipeSendoPatrocinada = "C# >> Java",
                TipoPatrocinio = "Equipamento",
                Estado = "São Paulo",
                Cidade = "Baixada Santista",
            });

            Program.cpatrocinadores.Add(new CPatrocinador() 
            {
                NomeDoPatrocinador = "Canue",
                Telefone = "47 99748-7846",
                Cpf = "04.885.325/0001-50",
                NomeDaEquipeSendoPatrocinada = "Os Vingadores",
                TipoPatrocinio = "Vestiario",
                Estado = "Blumenau",
                Cidade = "Santa Catarina",
            });


        }

    }
}
