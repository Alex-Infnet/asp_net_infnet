using System;
namespace ProtocoloHTTP.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public Aluno(int _Id, string _Nome, string _Email)
        {
            Id = _Id;
            Nome = _Nome;
            Email = _Email;
        }
    }
}

