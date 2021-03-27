using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BotAutoTrading.Utils
{
    public class Utilities
    {
        public static void OpenFileByNotepad(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return;
                }

                var shellType = Type.GetTypeFromProgID("Wscript.Shell");
                dynamic shell = Activator.CreateInstance(shellType);
                //oShell.Run strArgs, 0, false

                var startArgs = new ProcessStartInfo
                {
                    Arguments = filePath,
                    FileName = "notepad.exe",
                    WorkingDirectory = Path.GetDirectoryName(filePath),
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                var shellProcess = Process.Start(startArgs);
                shellProcess.Close();
            }
            catch
            {

            }
        }

        public static DateTime TimeSpanToDate(Int64 timeSpan)
        {
            //TimeSpan span = TimeSpan.FromTicks(timeSpan * TimeSpan.TicksPerSecond);
            DateTime t = new DateTime(1970, 1, 1).AddMilliseconds(timeSpan);
            return TimeZone.CurrentTimeZone.ToLocalTime(t);
        }

        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }

        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }

            return objectOut;
        }
    }
}
