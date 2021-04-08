using System;
using System.Collections.Generic; //para usar lista

namespace ProjetoAgenda
{
    class Program
    {
        static Evento obterDadosEvento()
        {
            string titulo;
            Data dtEvento;
            Horario hrEvento;
            
            Console.WriteLine("Digite o nome do Evento: ");
            titulo = Console.ReadLine();
            
            dtEvento = obterData();

            hrEvento = obterHorario();

            return new Evento(titulo,dtEvento,hrEvento);
        }
        static Data obterData()
        {
            //Data d;   //não precisa de variável auxiliar
            int dia,mes,ano;
            Console.Write("\nDigite o dia do evento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o mês do evento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o ano do evento: ");
            ano = int.Parse(Console.ReadLine());
            return new Data(dia,mes,ano); //setando a variável
            //return d;
            
        }
        static Horario obterHorario()
        {
            int hora,minutos;
            Console.Write("\nDigite o horário do evento em\nHoras: ");
            hora = int.Parse(Console.ReadLine());
            Console.Write("\nMinutos: ");
            minutos = int.Parse(Console.ReadLine());
            return new Horario(hora,minutos);
        }
        static void mostrarMenu()
        {
            Console.WriteLine("\n\nOpções\n");
            Console.WriteLine("1) Adicionar evento");
            Console.WriteLine("2) Listar todos os eventos");
            Console.WriteLine("3) Sair\n");
        }
        static void Main(string[] args)
        {
            int resp=0;
            
            List<Evento> agenda = new List<Evento>(); //lista é melhor que vetor pq não preciso especificar um tamanho, ela vai crescendo e diminuindo
            
            while(resp!=3)
            {
                try
                {
                    mostrarMenu(); //não usar o THIS quando for chamar métodos estáticos
                    Console.Write("Opção desejada: ");
                    resp = int.Parse(Console.ReadLine());
                    switch(resp)
                    {
                        case 1: //adicionar
                            Evento evt = obterDadosEvento();
                            agenda.Add(evt);
                            break;
                        case 2: //Listar todos
                            Console.WriteLine("\n");
                            foreach(Evento x in agenda)    //usado pra listas -> não precisa de contador
                            {
                                Console.WriteLine("Título: {0}\nData: {1}/{2}/{3}\nHorário: {4}:{5}\n",x.getDescricao(),x.getData().getDia(),x.getData().getMes(),x.getData().getAno(),x.getHora().getHoras(),x.getHora().getMinutos());
                            }
                            break;
                        case 3: //nada, vai sair
                            break;
                        default: 
                            throw new Exception("Opção inválida!"); //vai cair no catch
                    }
                }
                catch(Exception ex) //catch faz a tratação de erro      //ex é apenas uma var que vai pegar a exceção
                {
                    Console.WriteLine("Houve um erro!: {0}",ex.Message);
                    Console.WriteLine("Pressione <ENTER> para continuar..\n");
                    Console.ReadKey();
                }
            }
        }
    }
}