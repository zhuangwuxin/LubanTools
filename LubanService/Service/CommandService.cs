using System.Collections.Generic;
using System.IO;

namespace LubanService
{
    public class CommandService : BaseService<CommandService>
    {
        protected override void Init()
        {
            InitializeScript();
        }

        readonly Dictionary<string, int> m_Name2Index = new Dictionary<string, int>();

        /// <summary>
        /// 全部命令
        /// </summary>
        public List<LubanCommandTemplate> Commands = new List<LubanCommandTemplate>();

        /// <summary>
        /// 查询命令
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public LubanCommandTemplate FindCommand(int index)
        {
            if (index < 0 || index >= Commands.Count)
            {
                return LubanCommandTemplate.Empty;
            }

            return Commands[index];
        }

        /// <summary>
        /// 查询命令
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public LubanCommandTemplate FindCommand(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return LubanCommandTemplate.Empty;
            }

            if (m_Name2Index.TryGetValue(name, out int index))
            {
                return Commands[index];
            }

            return LubanCommandTemplate.Empty;
        }

        /// <summary>
        /// 保存命令配置
        /// </summary>
        public void SaveCommands()
        {
            LubanCommandDefine define = new LubanCommandDefine();
            define.Commands.AddRange(Commands);
            string path = FileService.CommandTemplateFilePath;
            FileService.SerializeXml(define, path);
        }

        void InitializeScript()
        {
            m_Name2Index.Clear();
            string path = FileService.CommandTemplateFilePath;
            if (!File.Exists(path))
            {
                LubanCommandDefine template = new LubanCommandDefine();
                template.Commands.AddRange(LubanCommandTemplate.TemplateCommands);
                FileService.SerializeXml(template, FileService.CommandTemplateFilePath);
            }

            LubanCommandDefine define = FileService.DeserializeXml<LubanCommandDefine>(path);
            for (int index = 0; index < define.Commands.Count; index++)
            {
                LubanCommandTemplate command = define.Commands[index];
                Commands.Add(command);
                m_Name2Index[command.Name] = Commands.Count - 1;
            }
        }
    }

   

   
}