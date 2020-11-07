using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Shapes;

namespace FirstFantasy.Classes
{
    public class FileManager
    {
        public static String ReadAllFile()
        {
            // File (Todo el archivo) File reader
            // Carácteres de escape
            // otra opción: "C:\\Users\HERNAN GOMEZ\\OneDrive - UPB\\SEMESTRE 2\\Paradigmas programación\\Semestre\\Teoría\\10_02 Herencia y polimorfismo\textfile.txt";
            string path = @"C:\Users\HERNAN GOMEZ\OneDrive - UPB\SEMESTRE 2\Paradigmas programación\Semestre\Teoría\10_02 Herencia y polimorfismo\textfile.txt";

            if (File.Exists(path))
            {
                string allText = File.ReadAllText(path);
                return allText;
            }
            else
            {
                return "Error. File not Found";
            }

        }

        public static String[] ReadAllLines()
        {
            // File (Todo el archivo) File reader
            // Carácteres de escape
            // otra opción: "C:\\Users\HERNAN GOMEZ\\OneDrive - UPB\\SEMESTRE 2\\Paradigmas programación\\Semestre\\Teoría\\10_02 Herencia y polimorfismo\textfile.txt";
            string path = @"C:\Users\--\OneDrive - UPB\SEMESTRE 2\Paradigmas programación\Semestre\Teoría\10_02 Herencia y polimorfismo\textfile.txt";

            if (File.Exists(path))
            {
                string[] allText = File.ReadAllLines(path);
                return allText;
                
            }
            else
            {
                return null;
            }

        }

        public static String ReadStream()
        {
            // File (Todo el archivo) File reader
            // Carácteres de escape
            // otra opción: "C:\\Users\HERNAN GOMEZ\\OneDrive - UPB\\SEMESTRE 2\\Paradigmas programación\\Semestre\\Teoría\\10_02 Herencia y polimorfismo\textfile.txt";
            string path = @"C: \Users\--\OneDrive - UPB\SEMESTRE 2\Paradigmas programación\Semestre\Teoría\10_02 Herencia y polimorfismo\textfile.txt";

            if (File.Exists(path))
            {
                StreamReader textStream = new StreamReader(path); //tome todos los bytes contenidos en el archivo
                string outputText = "";
                string line = "";

                // while (textStream.EndOfStream != true)

                while (textStream.Peek() != -1)
                {
                    line = textStream.ReadLine();
                    outputText += line;
                }

                textStream.Close();
                return outputText;
            }
            else
            {
                return null;
            }

        }

        /*public static void WriteFile(string append)
        {
            
            
            // File (Todo el archivo) File reader
            // Carácteres de escape
            // otra opción: "C:\\Users\HERNAN GOMEZ\\OneDrive - UPB\\SEMESTRE 2\\Paradigmas programación\\Semestre\\Teoría\\10_02 Herencia y polimorfismo\textfile.txt";
            string path = @"C:\Users\HERNAN GOMEZ\OneDrive - UPB\SEMESTRE 2\Paradigmas programación\Semestre\Teoría\10_02 Herencia y polimorfismo\textfile.txt";

            File.AppendAllText(path, append);


        }*/

        // StreamReader (lineas específicas)
    }
}
