using System;
using System.IO;
using System.Text;

namespace BotAutoTrading.Utils
{
    public  class LogUtil
    {
        public static void WriteLog(string filePath, string message, bool isNewLine = true, bool isDeleteExistFile = false)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                    return;

                if (File.Exists(filePath) && isDeleteExistFile)
                {
                    File.Delete(filePath);
                    File.Create(filePath).Close();
                }
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                string endCoding = "shift_jis";

                using (FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read))
                using (StreamWriter writer = new StreamWriter(file, Encoding.GetEncoding(endCoding)))
                {
                    if (isNewLine)
                        writer.WriteLine(message);
                    else
                        writer.Write(message);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
        }
    }
}
