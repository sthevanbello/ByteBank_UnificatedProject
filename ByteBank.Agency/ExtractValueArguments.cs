using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Agency
{
    public class ExtractValueArgumentsURL
    {
        private readonly string _arguments;
        public string URL { get; }

        public ExtractValueArgumentsURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("The argument cannot be null or empty", nameof(url));
            }

            URL = url;
            int interrogationIndex = url.IndexOf('?');
            _arguments = url.Substring(interrogationIndex + 1);
        }

        public string GetValue(string nameParameter)
        {
            string ArgumentToUpper = _arguments.ToUpper();
            nameParameter = nameParameter.ToUpper();

            string term = nameParameter + "=";

            int indexTerm = ArgumentToUpper.IndexOf(term);

            string result = _arguments.Substring(indexTerm + term.Length);

            int indexE = result.IndexOf('&');

            if (indexE < 0)
            {
                return result;
            }


            return result.Remove(indexE);
        }

    }
}

