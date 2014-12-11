using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace QLGV.Utilities
{
    public class FileUtilities
    {
        public string GetFileNameFromFileUri(string fileUri)
        {
            string[] elements = fileUri.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            return elements[elements.Length - 1];
        }

        public string GetDirectoryUriByFileUri(string fileUri)
        {
            return fileUri.Substring(0, fileUri.LastIndexOf('\\'));
        }

        public string GetFileExtendFromURI(string uri)
        {
            string[] element = uri.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            return element[element.Length - 1];
        }

        /// <summary>
        /// Show Open a file dialog, choose fileType
        /// </summary>
        /// <param name="fileType"></param>
        public string ShowOpenFileDialog(string fileFilter)
        {
            string fileName = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = fileFilter;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            return fileName;
        }

        /// <summary>
        /// Show Save file dialog (cant create file), choose file type
        /// </summary>
        /// <param name="fileType"></param>
        public string ShowSaveFileDialog(string fileFilter)
        {
            string fileName = string.Empty;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = fileFilter;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFile.FileName;
            }
            return fileName;
        }

        public void SaveTextFile(string fileName, string textContent)
        {
            TextWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.Write(textContent);
            writer.Close();
        }

        public void SaveTextFile(string fileName, string[] textArray)
        {
            TextWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            if (textArray == null || textArray.Length <= 0)
            {
                writer.WriteLine();
            }
            else
            {
                for (int i = 0; i < textArray.Length; i++)
                {
                    writer.WriteLine(textArray[i]);
                }
            }
            writer.Close();
        }

        public string ReadTextFile(string fileName)
        {
            string textContence = string.Empty;
            using (TextReader reader = new StreamReader(fileName, Encoding.UTF8))
            {
                textContence = reader.ReadToEnd();
                reader.Close();
            }
            return textContence;
        }

        public int ReadCountLinesTextFile(string fileName)
        {
            int count = 0;
            String lineText = string.Empty;
            using (TextReader reader = new StreamReader(fileName, Encoding.UTF8))
            {
                while ((lineText = reader.ReadLine()) != null)
                {
                    if (lineText.Trim().Length != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public String[] ReadLinesTextFile(string fileName)
        {
            String[] output = null;
            String lineText = string.Empty;
            ArrayList list = new ArrayList();
            using (TextReader reader = new StreamReader(fileName, Encoding.UTF8))
            {
                while ((lineText = reader.ReadLine()) != null)
                {
                    if (lineText.Trim().Length != 0)
                    {
                        list.Add(lineText);
                    }
                }
            }

            if (list != null && list.Count > 0)
            {
                Array arr = list.ToArray(typeof(string));
                output = new String[arr.Length];
                Array.Copy(arr, output, arr.Length);
            }

            //Cách này dễ bị "Out Of Memory" nếu file có nhiều câu (hàng triệu câu)
            //String str = ReadTextFile(fileName);
            //output = str.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            return output;
        }

        public void CreateFile(string fileName)
        {
            if (fileName != string.Empty)
            {
                FileStream stream = File.Create(fileName);
                stream.Close();
            }
        }

        public void RenameFile(string oldFileName, string newFileName)
        {
            File.Move(oldFileName, newFileName);
        }

        public void DeleteFile(string fileName)
        {
            if (fileName != string.Empty)
            {
                File.Delete(fileName);
            }
        }

        public void CopyFile(string oldFileName, string newFileName)
        {
            File.Copy(oldFileName, newFileName, true);
        }

        public bool CheckFileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public bool CheckDirectoryExists(string directoryName)
        {
            if (directoryName != string.Empty &&
                Directory.Exists(directoryName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckDirectoryExistsByFileName(string fileName)
        {
            if (fileName != string.Empty && fileName.IndexOf('\\') != -1 &&
                Directory.Exists(fileName.Substring(0, fileName.LastIndexOf('\\'))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateDirectory(string directoryName)
        {
            if (directoryName != string.Empty)
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        /// <summary>
        /// Append Text to *.txt file by Write()
        /// </summary>
        /// <param name="fileName">File Name</param>
        /// <param name="appendText">Content text</param>
        public void WriteAppendTextFile(string fileName, string appendText)
        {
            TextWriter tw = new StreamWriter(fileName, true, Encoding.UTF8);
            tw.Write(appendText);
            tw.Close();
        }

        /// <summary>
        /// Append Text to *.txt file by WriteLine()
        /// </summary>
        /// <param name="fileName">File Name</param>
        /// <param name="appendText">Content text</param>
        public void WriteLineAppendTextFile(string fileName, string appendText)
        {
            TextWriter tw = new StreamWriter(fileName, true, Encoding.UTF8);
            tw.WriteLine();
            tw.WriteLine(appendText);
            tw.Close();
        }
    }
}
