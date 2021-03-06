using System;

namespace RoleTop.Models {
    public class Cliente {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public string Email { get; set; }

        public DateTime dataNascimento { get; set; }
        public uint TipoUsuario {get;set;}
        public int TipoUsusario { get; internal set; }

        public Cliente (string Nome, string endereco, string telefone, string senha, string email, DateTime dataNascimento) {

            this.Nome = Nome;
            this.Endereco = endereco ;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;
            this.dataNascimento = dataNascimento;
        }

        public Cliente()
        {
            
        }
    }
}