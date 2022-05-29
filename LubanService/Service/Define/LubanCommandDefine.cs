using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;

namespace LubanService
{
    [XmlRoot("Define")]
    public class LubanCommandDefine
    {
        public List<LubanCommandTemplate> Commands = new List<LubanCommandTemplate>();
    }

    [Serializable]
    public class LubanCommandTemplate
    {
        [XmlAttribute]
        public string Name;

        [XmlAttribute]
        public string Params;

        [XmlAttribute]
        public string Desc;

        public void Deserialize(JToken source)
        {
            if (source == null)
            {
                return;
            }

            Name = source[nameof(Name)]?.ToString();
            Params = source[nameof(Params)]?.ToString();
            Desc = source[nameof(Desc)]?.ToString();
        }

        public JToken Serialize()
        {
            JObject command = new JObject
            {
                {nameof(Name), Name},
                {nameof(Params), Name},
                {nameof(Desc), Desc}
            };
            return command;
        }

        public static LubanCommandTemplate Empty = new LubanCommandTemplate();

        public static List<LubanCommandTemplate> TemplateCommands = new List<LubanCommandTemplate>
        {
            new LubanCommandTemplate
            {
                Name = "-h",
                Params = "--host <host>",
                Desc = "可选参数。 luban-server的地址。默认为 127.0.0.1"
            },
            new LubanCommandTemplate
            {
                Name = "-p",
                Params = "--port <port>",
                Desc = "可选参数。 luban-server的端口。默认为 8899"
            },
            new LubanCommandTemplate
            {
                Name = "-j",
                Params = "--job <job>",
                Desc = "必选参数。 生成类型。目前支持的生成类型有: cfg,proto,db。 生成配置请取cfg。"
            },
            new LubanCommandTemplate
            {
                Name = "-l",
                Params = "--loglevel <log level>",
                Desc = "可选参数。 日志级别。默认为INFO。有效值有: TRACE,DEBUG,INFO,WARN,ERROR,FATAL,OFF"
            },
            new LubanCommandTemplate
            {
                Name = "-c",
                Params = "-cachemetafile <meta file>",
                Desc = "可选参数。 meta缓存文件名。 默认为 .cache.meta"
            },
            new LubanCommandTemplate
            {
                Name = "-w",
                Params = "--watch <dir1;dir2...>",
                Desc =
                    "可选参数。 监测目录或者目录列表，以逗号';'分隔。当开启此选项后，生成结束后不会退出程序，而是进入自动生成模式。监听到目标目录发生变化后，自动重新运行生成。省去改动后手动运行生成脚本的麻烦。"
            },
            new LubanCommandTemplate
            {
                Name = "--generateonly",
                Params = "",
                Desc = "可选参数。  仅生成。不从服务器下载生成结果。可以用于检查服务器是否能成功生成。"
            },
            new LubanCommandTemplate
            {
                Name = "-h",
                Params = "--help",
                Desc = "可选参数。显示帮助信息"
            },
            new LubanCommandTemplate
            {
                Name = "-d",
                Params = "--define_file <root file>",
                Desc = "必选参数。 根定义文件名"
            },
            new LubanCommandTemplate
            {
                Name = "--input_data_dir",
                Params = "<input data dir>",
                Desc = "必选参数。 配置数据文件根目录。"
            },
            new LubanCommandTemplate
            {
                Name = "--input:convert:dir",
                Params = "<dir>",
                Desc = "可选参数。 执行json、lua、xlsx之类数据格式转换时，提供的数据源，覆盖table中默认的input参数。"
            },
            new LubanCommandTemplate
            {
                Name = "-c",
                Params = "--output_code_dir <output code dir>",
                Desc = "可选参数。 生成代码文件的目录。"
            },
            new LubanCommandTemplate
            {
                Name = "-s",
                Params = "---service",
                Desc = "必选参数。生成分组目标。一般来说，会定义client,server,editor等好几个目标，不同目标的生成内容不同。"
            },
            new LubanCommandTemplate
            {
                Name = "--gen_types",
                Params = "<type1,type2,,,>",
                Desc =
                    "必选参数。生成任务类型。既可以是生成代码也可以是生成数据或者其他。目前支持的有 code_cs_bin,code_cs_unity_bin,code_cs_dotnet_json,code_cs_unity_json,code_cs_unity_editor_json,code_lua_bin,code_java_bin,code_go_bin,code_go_json,code_cpp_bin,code_cpp_ue_editor_json,code_python27_json,code_python3_json，code_typescript_bin,code_typescript_json,code_rust_json,code_protobuf2,code_protobuf3,code_template,code_flatbuffers,data_bin,data_lua,data_json,data_json_monolithic,data_yaml,data_template,data_protobuf_bin,data_protobuf_json,data_flatbuffers_json,convert_json,convert_lua,convert_xlsx,convert_template"
            },
            new LubanCommandTemplate
            {
                Name = "--validate_root_dir",
                Params = "<path validate root dir>",
                Desc = "可选参数。 配置path检查的根目录。"
            },
            new LubanCommandTemplate
            {
                Name = "--output_data_dir",
                Params = "<output data dir>",
                Desc = "可选参数。 导出的数据文件的目录。只生成代码时可不指定。"
            },
            new LubanCommandTemplate
            {
                Name = "--output:data:compact_json",
                Params = "",
                Desc = "可选参数。默认导出的json格式为对齐后的优雅格式，使用此参数后导出紧凑的不带空格和换行的格式。"
            },
            new LubanCommandTemplate
            {
                Name = "--output:data:file_extension",
                Params = "<output data file extension>",
                Desc = " 可选参数。 导出数据文件的后缀。默认按照生成类型自动选择。"
            },
            new LubanCommandTemplate
            {
                Name = "--output:exclude_tags",
                Params = "<tag1,tag2>",
                Desc = "可选参数。 导出时排除包含这些tag的数据"
            },
            new LubanCommandTemplate
            {
                Name = "--output:tables",
                Params = "<table1,table2...>",
                Desc = "可选参数。手动指定导出哪些表。覆盖group中设置"
            },
            new LubanCommandTemplate
            {
                Name = "--output:include_tables",
                Params = "<table1,table2...>",
                Desc = "可选参数。除了group中设置外，额外新增表。"
            },
            new LubanCommandTemplate
            {
                Name = "--output:exclude_tables",
                Params = "<table1,table2...>",
                Desc = "可选参数。排除group中指定的表。"
            },
            new LubanCommandTemplate
            {
                Name = "--output:convert:file_extension",
                Params = "<extension>",
                Desc = "可选参数。 convert数据文件的后缀。默认按照模板名猜测。"
            },
            new LubanCommandTemplate
            {
                Name = "--template:code:dir",
                Params = "<dir name> ",
                Desc = "可选参数。自定义额外代码模板的目录名"
            },
            new LubanCommandTemplate
            {
                Name = "--template:data:file",
                Params = "<template name>",
                Desc = "可选参数。数据模板的名称（不包含后缀），当gen_types包含 data_template时必须指定。"
            },
            new LubanCommandTemplate
            {
                Name = "--template:convert:file",
                Params = "<template name>",
                Desc = "可选参数。convert模板的名称（不包含后缀），当gen_types包含convert_template时必须指定。"
            },
            new LubanCommandTemplate
            {
                Name = "--naming_convention:module",
                Params = "<convention>",
                Desc =
                    "可选参数。生成代码中模板名的命名约定，可用值为 language_recommend,none,camelCase,PascalCase,under_scores。 默认为language_recommend，即选择与相应语言推荐的命名约定风格。 此选项目前未生效。"
            },
            new LubanCommandTemplate
            {
                Name = "--naming_convention:bean_member",
                Params = "<convention>",
                Desc =
                    "可选参数。生成代码中bean类型字段名的命名约定，可用值为 language_recommend,none,camelCase,PascalCase,under_scores。 默认为language_recommend。"
            },
            new LubanCommandTemplate
            {
                Name = "--naming_convention:enum_member",
                Params =
                    "可选参数。生成代码中enum类型名的命名约定，可用值为 language_recommend,none,camelCase,PascalCase,under_scores。 默认为language_recommend。此选项目前未生效。",
                Desc = "可选参数。 日志级别。默认为INFO。有效值有: TRACE,DEBUG,INFO,WARN,ERROR,FATAL,OFF"
            },
            new LubanCommandTemplate
            {
                Name = "--access_bean_member",
                Params = "<access mode>",
                Desc =
                    "可选参数。 bean属性的访问方式。可用值为language_recommend,variable,getter_setter,property。默认为 language_recommend。此字段目前未生效。"
            },
            new LubanCommandTemplate
            {
                Name = "--l10n:timezone",
                Params = "<timezone>",
                Desc = "可选参数。 指定所在时区。影响datetime类型转换为utc时间。 默认为中国北京时间。"
            },
            new LubanCommandTemplate
            {
                Name = "--l10n:input_text_files",
                Params = "<file1,file2..>",
                Desc = "可选参数。 本地化的文本映射表。可以有多个。"
            },
            new LubanCommandTemplate
            {
                Name = "--l10n:text_field_name",
                Params = "<field name>",
                Desc = "可选参数。 文本映射表中，目标映射列的列名，默认为text"
            },
            new LubanCommandTemplate
            {
                Name = "--l10n:output_not_translated_text_file",
                Params = "<file>",
                Desc = "可选参数。 未被本地化映射的text key和value的输出文件。不提供该参数则不生成"
            },
            new LubanCommandTemplate
            {
                Name = "--l10n:patch ",
                Params = "<patch name> ",
                Desc = " 可选参数。当前需要生成的分支名称。"
            },
            new LubanCommandTemplate
            {
                Name = "--l10n:patch_input_data_dir",
                Params = "<patch data root dir>",
                Desc = "可选参数。分支数据的根目录。"
            },
            new LubanCommandTemplate
            {
                Name = "--typescript:bright_require_path",
                Params = "<path>",
                Desc = "可选参数。生成typescript代码引用的bright模块的路径"
            },
            new LubanCommandTemplate
            {
                Name = "--typescript:bright_package_name",
                Params = "<packet>",
                Desc = "可选参数。生成typescript代码以包形式引用bright库的路径"
            },
            new LubanCommandTemplate
            {
                Name = "--typescript:use_puerts_bytebuf",
                Params = "",
                Desc = "可选参数。生成typescript代码中使用puerts中导入的c# Bytebuf类。"
            },
            new LubanCommandTemplate
            {
                Name = "--cs:use_unity_vector",
                Params = "",
                Desc = "可选参数。生成c#代码中，使用UnityEngine.Vector{2,3,4}作为Vector数据类型。"
            },
            new LubanCommandTemplate
            {
                Name = "--go:bright_module_name ",
                Params = "<module path>",
                Desc = "可选参数。生成go代码时，bright module的import目录。"
            },
            new LubanCommandTemplate
            {
                Name = "--external:selectors",
                Params = "<selector1,selector2 ...>",
                Desc = "可选参数。 外部类选择器，可以多个。selector必须是root.xml中externalselector中定义的选择器之一。"
            },
        };
    }
}