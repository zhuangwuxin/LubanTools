using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Sunny.UI;

namespace LubanService
{
    public static class FileService
    {
        const string CONFIG_DIR = "Config";
        const string CONFIG_FILE = "Setting.xml";
        const string USING_COMMANDS = "UsingComands.xml";
        const string SCRIPT_FILE = "Generate.bat";

        static readonly Dictionary<Type, XmlSerializer> s_XmlSerializers = new Dictionary<Type, XmlSerializer>();

        /// <summary>
        /// 脚本
        /// </summary>
        public static string ScriptFilePath => GetFilePath(SCRIPT_FILE);

        /// <summary>
        /// 当前的使用命令配置
        /// </summary>
        public static string SettingPath => GetFilePath(USING_COMMANDS);

        /// <summary>
        /// 命令模板配置
        /// </summary>
        public static string CommandTemplateFilePath => GetFilePath(CONFIG_FILE);

        static string GetFilePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return string.Empty;
            }

            string dir = Directory.GetCurrentDirectory();
            string configDir = Path.Combine(dir, CONFIG_DIR);
            if (!Directory.Exists(configDir))
            {
                Directory.CreateDirectory(configDir);
            }

            string path = Path.Combine(configDir, fileName);
            return path;
        }

        /// <summary>
        /// 文件夹选择器
        /// </summary>
        /// <param name="title"></param>
        /// <param name="onSelect"></param>
        /// <param name="onCancel"></param>
        public static void OpenDirectorySelection(string title, Action<string> onSelect, Action onCancel = null)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog {Description = title};
            DialogResult result = dialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    onSelect?.Invoke(dialog.SelectedPath);
                    return;
                case DialogResult.Cancel:
                    onCancel?.Invoke();
                    break;
            }
        }

        /// <summary>
        /// 文件选择器
        /// </summary>
        /// <param name="title"></param>
        public static string OpenFileSelection(string title)
        {
            OpenFileDialog dialog = new OpenFileDialog {Multiselect = false, Title = title, Filter = "所有文件(*.*)|*.*"};
            DialogResult result = dialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                {
                    return dialog.FileName;
                }
                case DialogResult.Cancel:
                    break;
            }

            return string.Empty;
        }

        /// <summary>
        /// 目录选择器
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string OpenDirectorySelection(string title)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog {Description = title};
            DialogResult result = dialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    return dialog.SelectedPath;
                case DialogResult.Cancel:
                    break;
            }

            return string.Empty;
        }


        /// <summary>
        /// 保存到xml
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        public static void SerializeXml(this object data, string path)
        {
            if (string.IsNullOrEmpty(path) || data == null)
            {
                return;
            }

            string directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory))
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }

            using (StreamWriter stream = new StreamWriter(path))
            {
                XmlSerializer serializer = GetXmlSerializer(data.GetType());
                serializer.Serialize(stream, data);
            }
        }

        /// <summary>
        /// 写入XML
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        /// <typeparam name="T"></typeparam>
        public static void SerializeXml<T>(T data, string path) where T : class
        {
            if (string.IsNullOrEmpty(path) || data == null)
            {
                return;
            }

            string directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory))
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }

            using (StreamWriter stream = new StreamWriter(path))
            {
                XmlSerializer serializer = GetXmlSerializer<T>();
                serializer.Serialize(stream, data);
            }
        }

        /// <summary>
        /// 从Xml加载对象，没有则会创建xml
        /// </summary>
        /// <param name="absPath">绝对路径</param>
        /// <param name="autoCreate">是否自动创建</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeXml<T>(string absPath, bool autoCreate = true) where T : class, new()
        {
            if (string.IsNullOrEmpty(absPath))
            {
                return null;
            }

            XmlSerializer serializer = GetXmlSerializer<T>();
            if (autoCreate)
            {
                string directory = Path.GetDirectoryName(absPath);
                if (directory != null)
                {
                    //检查文件夹
                    if (!File.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    //检查文件
                    if (!File.Exists(absPath))
                    {
                        using (StreamWriter stream = new StreamWriter(absPath))
                        {
                            serializer.Serialize(stream, new T());
                        }
                    }
                }
            }

            T ret = null;
            using (StreamReader stream = new StreamReader(absPath))
            {
                ret = serializer.Deserialize(stream) as T;
            }

            return ret;
        }

        public static XmlSerializer GetXmlSerializer(Type type)
        {
            if (type == null)
            {
                return default;
            }

            XmlSerializer serializer;
            if (s_XmlSerializers.ContainsKey(type))
            {
                serializer = s_XmlSerializers[type];
            }
            else
            {
                serializer = new XmlSerializer(type);
                s_XmlSerializers[type] = serializer;
            }

            return serializer;
        }

        /// <summary>
        /// 获取对象Xml序列化器
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static XmlSerializer GetXmlSerializer<T>()
        {
            return GetXmlSerializer(typeof(T));
        }
    }
}