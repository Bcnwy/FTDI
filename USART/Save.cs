using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Usart
{
    class Save
    {
        private string filePath;
        private string Header =  "Data" ;
        //private string delimiter = ",";
        StringBuilder sb = new StringBuilder();

        public string FilePath
        {
            get { return filePath; }
            set { filePath = @"C:\" + value + ".csv"; }
        }
        public Save(string path)
        {
            this.filePath = path;
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    sb.AppendLine(Header);
                    File.AppendAllText(filePath, sb.ToString());
                    sb.Remove(0, sb.Length);
                }
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public void SaveToFile(int[] Data)
        {
            foreach(int sample in Data)
            {
               sb.AppendLine(sample.ToString());
            }
            File.AppendAllText(filePath, sb.ToString());
            sb.Remove(0, sb.Length);
        }

        internal void SaveToFile()
        {
            throw new System.NotImplementedException();
        }
    }
}
