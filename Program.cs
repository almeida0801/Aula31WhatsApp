using System;

namespace Aula31WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato1 = new Contato("Oscar", 1777734680);
            Contato contato2 = new Contato("Wilabix", 519773467);
            Contato contato3 = new Contato("Yuri", 319773467);
            Contato contato4 = new Contato("Deide", 1197734699);
            Contato contato5 = new Contato("Costa", 11977678);
            Contato contato6 = new Contato("Jonas", 564787856);
            

            

            Agenda agenda = new Agenda();
            agenda.Cadastrar(contato1);
            agenda.Cadastrar(contato2);
            agenda.Cadastrar(contato3);
            agenda.Cadastrar(contato4);
            agenda.Cadastrar(contato5);
            agenda.Cadastrar(contato6);
            

            agenda.Excluir("Jonas");
            agenda.Listar();
            Mensagem newtexto = new Mensagem();
            newtexto.Destinatario = contato3;
           
            System.Console.WriteLine(newtexto.Enviar(newtexto.Destinatario));
 

            
            
        }
    }
}
