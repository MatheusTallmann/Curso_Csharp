using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    public class Prova
    {
        public string Prova2(List<string> letras)
        {
            var palavra = new StringBuilder();
                        
            foreach (var item in letras)
            {
                palavra.Append(item);
            }

            
            return palavra.ToString();

            // return String.Join("", letras);
        }
    }
}