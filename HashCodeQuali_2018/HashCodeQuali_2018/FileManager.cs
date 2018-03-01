using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCodeQuali_2018
{
    class FileManager
    {
        private static string currentDirectory = "C:\\Users\\Dell E6430u\\Documents\\Dima\\__HASHCODE";
        private static string currentFile;


        public static string[] getInputs()
        {
            return Directory.GetFiles(currentDirectory + "\\inputs", "*.in");
        }


        public static string getOutputFileName(string version = null)
        {

            var str = string.Format("{0}\\outputs\\{2}\\{1}.out", currentDirectory, currentFile, version ?? ".");
            Directory.CreateDirectory(Path.GetDirectoryName(str));
            return str;
        }
        public static StreamWriter createOutput(string version = null)
        {
            
            return File.CreateText(getOutputFileName(version));
        }
        public static string[] getAllLines(int inputNumber)
        {
            string path = getInputs()[inputNumber];
            currentFile = Path.GetFileNameWithoutExtension(path);
            return File.ReadAllLines(path);
        }

        public static int[] GetIntArray(string str)
        {
            return Array.ConvertAll(str.Split(' '), num => Int32.Parse(num));
        }
        public static IEnumerable<int> GetIntIEnumerable(string str)
        {
            foreach (string s in str.Split(' '))
            {
                yield return Int32.Parse(s);
            }
        }
    }
}
