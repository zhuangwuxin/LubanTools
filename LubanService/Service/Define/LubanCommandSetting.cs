using System;
using System.Xml.Serialization;

namespace LubanService
{
    [XmlRoot]
    public class LubanCommandSetting
    {
        /// <summary>
        /// exe路径
        /// </summary>
        [XmlElement]
        public LubanCommand ExePath = new LubanCommand();

        /// <summary>
        /// 导出形式
        /// </summary>
        [XmlElement]
        public LubanCommand OutputMode = new LubanCommand
        {
            command = "-j"
        };

        /// <summary>
        /// root.xml目录
        /// </summary>
        [XmlElement]
        public LubanCommand RootDefinePath = new LubanCommand
        {
            command = "-d"
        };

        /// <summary>
        /// 代码输出目录
        /// </summary>
        [XmlElement]
        public LubanCommand OutputCodePath = new LubanCommand
        {
            command = "--output_code_dir"
        };

        /// <summary>
        /// 资源输出目录
        /// </summary>
        [XmlElement]
        public LubanCommand OutputDataPath = new LubanCommand
        {
            command = "--output_data_dir"
        };

        /// <summary>
        /// 数据配置目录
        /// </summary>
        [XmlElement]
        public LubanCommand DataSourcePath = new LubanCommand
        {
            command = "--input_data_dir"
        };

        /// <summary>
        /// 生成形式
        /// </summary>
        [XmlElement]
        public LubanCommand GenTypes = new LubanCommand
        {
            command = "--gen_types"
        };

        /// <summary>
        /// 生成形式
        /// </summary>
        [XmlElement]
        public LubanCommand Service = new LubanCommand
        {
            command = "-s"
        };
    }

    [Serializable]
    public class LubanCommand
    {
        [XmlAttribute]
        public string command;

        [XmlAttribute]
        public string param;

        public string GetScript(bool isLast)
        {
            if (!isLast)
            {
                return string.IsNullOrEmpty(command) ? $" {param} ^" : $" {command} {param} ^";
            }

            return string.IsNullOrEmpty(command) ? $" {param} ^" : $" {command} {param}";
        }
    }
}