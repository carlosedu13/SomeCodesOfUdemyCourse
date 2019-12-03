using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UdemyTesteCS
{
    public static class StringExtension
    {
        public static string ParseHome (this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class ManipulandoArquivos1
    {
        public static void ExcluirSeExistir(params string[] paths)
        {
            foreach (var path in paths)
            {
                FileInfo archive = new FileInfo(path);

                if (archive.Exists)
                    archive.Delete();
            }
        }

        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é ");
                    sw.WriteLine("o nosso");
                    sw.WriteLine(" primeiro arquivo");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Something");
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            FileInfo arquivoInfo = new FileInfo(path);
            Console.WriteLine(arquivoInfo.Name);
            Console.WriteLine(arquivoInfo.IsReadOnly);
            Console.WriteLine(arquivoInfo.FullName);
            Console.WriteLine(arquivoInfo.Extension);

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
                dirInfo.Create();

            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
                Console.WriteLine(arquivo);

            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
                Console.WriteLine(pasta);

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.HasExtension(path));
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetPathRoot(path));
        }
    }
}
