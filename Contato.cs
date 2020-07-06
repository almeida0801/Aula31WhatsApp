  
namespace Aula31WhatsApp
{
    public class Contato
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }   

        public Contato(string _nome, int _telefone)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
        }
    }
}