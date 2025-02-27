using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace LogarSystema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iniciar();
        }
        static void Iniciar()
        {
            if (File.Exists("usuario.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("usuario.txt", FileMode.Open);
                List<Google> usuarios = (List<Google>)converter.Deserialize(bin);
                bin.Close();
                if (usuarios.Count > 0 && usuarios != null) 
                {
                    Usuario.LerAdd();
                }
                else
                {
                    
                    Google.adiconarGoogle();
                }

            }
            else
            {
                Google.adiconarGoogle();

            }
        }
    }
}
