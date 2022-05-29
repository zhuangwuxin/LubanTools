using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Sunny.UI;

namespace LubanService
{
    public static partial class SettingService
    {
        static LubanCommandSetting s_Setting;

        public static event Action<string> OnSaveScript;

        /// <summary>
        /// 当前配置
        /// </summary>
        public static LubanCommandSetting LoadSetting()
        {
            s_Setting = FileService.DeserializeXml<LubanCommandSetting>(FileService.SettingPath);
            SaveScript();
            return s_Setting;
        }

        /// <summary>
        /// 保存配置
        /// </summary>
        public static void SaveSetting()
        {
            SaveScript();
            FileService.SerializeXml(s_Setting, FileService.SettingPath);
        }

        /// <summary>
        /// 加载批处理脚本
        /// </summary>
        /// <returns></returns>
        public static string LoadScript()
        {
            if (!File.Exists(FileService.ScriptFilePath))
            {
                SaveScript();
            }

            return File.ReadAllText(FileService.ScriptFilePath);
        }

        /// <summary>
        /// 保存批处理脚本
        /// </summary>
        public static void SaveScript()
        {
            List<LubanCommand> commands = new List<LubanCommand>();
            Type type = s_Setting.GetType();
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                object obj = field.GetValue(s_Setting);
                if (obj is LubanCommand command)
                {
                    commands.Add(command);
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < commands.Count; i++)
            {
                LubanCommand command = commands[i];
                stringBuilder.AppendLine(command.GetScript(i == commands.Count - 1));
            }

            stringBuilder.AppendLine("pause");

            string script = stringBuilder.ToString();
            OnSaveScript?.Invoke(script);
            File.WriteAllText(FileService.ScriptFilePath, script);
        }
    }
}