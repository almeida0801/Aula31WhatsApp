namespace Aula31WhatsApp
{
    public class Mensagem
    {
        public string TextoMensagem = "Vamos jogar Ludo?";
        public Contato Destinatario { get; set; }

        public string Enviar(Contato contato)
        {   
            
             return $"Enviar a seguinte mensagem: '{TextoMensagem}' enviando para: {Destinatario.Nome}";
        }
    }
}