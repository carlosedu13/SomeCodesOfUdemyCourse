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
        }
    }
}
