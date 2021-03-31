using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    public class Client
    {
        private string _cpf;
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Cpf 
        {
            get 
            {
                return _cpf;
            }
            set
            {
                // If in future have a logical of validation
                _cpf = value;
            } 
        }

        public Client(string name, string occupation, string cpf)
        {
            Name = name;
            Occupation = occupation;
            Cpf = cpf;
        }

        public override bool Equals(object obj)
        {
            Client other = obj as Client;

            if (!(obj is Client))
            {
                throw new Exception("Object not is a object Client");
            }
            return Cpf == other.Cpf;
        }
    }
}
