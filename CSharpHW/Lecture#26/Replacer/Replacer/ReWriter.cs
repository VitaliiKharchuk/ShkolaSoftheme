using System.IO;
using System.Text.RegularExpressions;

namespace Replacer
{
    static class ReWriter
    {
        private static object lockObject = new object();
        private static readonly string fileHistoryName = "History.txt";

        public static string OldValue { get; set; }
        public static string NewValue { get; set; }
        public static Extentions Extention { get; set; }

        static ReWriter()
        {
            using (StreamWriter sw = new StreamWriter(fileHistoryName))
            {
                //clean file
            }
        }
        public static void ReWrite(string fileName)
        {
            if (Path.GetExtension(fileName).Equals('.' + Extention.ToString()) || Extention.Equals(Extentions.none))
            {
                var text = Regex.Split(File.ReadAllText(fileName), "\r\n|\r|\n");
                string[] newText = new string[text.Length];

                using (StreamWriter rewriter = new StreamWriter(fileName))
                {
                    lock (lockObject)
                    {
                        using (StreamWriter logger = File.AppendText(fileHistoryName))
                        {
                            logger.WriteLine("Replacment in {0}:", fileName);
                            for (int i = 0; i < text.Length; i++)
                            {
                                newText[i] = text[i].Replace(OldValue, NewValue);
                                if (!newText[i].Equals(text[i]))
                                {
                                    logger.WriteLine("   string '{0}' was  replaced on string '{1}' in  line {2}", OldValue, NewValue, i + 1);
                                }

                                rewriter.WriteLine(newText[i]);
                            }

                            logger.WriteLine();
                        }
                    }
                }
            }
        }
    }
}

