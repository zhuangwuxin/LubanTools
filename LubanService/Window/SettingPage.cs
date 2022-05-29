using System;
using System.Collections.Generic;

namespace LubanService
{
    public partial class SettingPage : LubanPage
    {
        readonly LubanCommandSetting m_Setting;

        public SettingPage()
        {
            InitializeComponent();

            m_Setting = SettingService.LoadSetting();
            ExePathText.Text = m_Setting.ExePath.param;
            ResOutputDirText.Text = m_Setting.OutputDataPath.param;
            CodeOutputDirText.Text = m_Setting.OutputCodePath.param;
            DataSourceDirText.Text = m_Setting.DataSourcePath.param;
            RootDefineText.Text = m_Setting.RootDefinePath.param;
            GenTypeText.Text = m_Setting.GenTypes.param;
            GenTypeText.TextChanged += OnGenTextChange;
            OutputModeCombo.Items.AddRange(new object[] {"cfg --", "proto --", "db --"});
            OutputModeCombo.TextChanged += OnOutputModeTextChange;
            if (!string.IsNullOrEmpty(m_Setting.OutputMode.param))
            {
                OutputModeCombo.SelectedItem = m_Setting.OutputMode.param;
            }
            else
            {
                OutputModeCombo.SelectedIndex = 0;
            }

            ServiceCombo.Items.AddRange(new object[] {"client", "server", "all"});
            ServiceCombo.TextChanged += ServiceCheckBoxOnTextChanged;
            if (!string.IsNullOrEmpty(m_Setting.Service.param))
            {
                ServiceCombo.SelectedItem = m_Setting.Service.param;
            }
            else
            {
                ServiceCombo.SelectedIndex = 0;
            }
        }

        void ServiceCheckBoxOnTextChanged(object sender, EventArgs e)
        {
            m_Setting.Service.param = ServiceCombo.SelectedText;
            SettingService.SaveSetting();
        }

        void OnOutputModeTextChange(object sender, EventArgs e)
        {
            m_Setting.OutputMode.param = OutputModeCombo.SelectedText;
            SettingService.SaveSetting();
        }

        void OnGenTextChange(object sender, EventArgs e)
        {
            m_Setting.GenTypes.param = GenTypeText.Text;
            SettingService.SaveSetting();
        }

        public override int ID => 1001;

        private void ExePathButton_Click(object sender, EventArgs e)
        {
            string path = FileService.OpenFileSelection("请选择导表exe路径");
            ExePathText.Text = path;
            m_Setting.ExePath.param = path;
            SettingService.SaveSetting();
        }

        private void ResOutputDirButton_Click(object sender, EventArgs e)
        {
            string path = FileService.OpenDirectorySelection("请选择资源输出路径");
            ResOutputDirText.Text = path;
            m_Setting.OutputDataPath.param = path;
            SettingService.SaveSetting();
        }

        private void CodeOutputDirButton_Click(object sender, EventArgs e)
        {
            string path = FileService.OpenDirectorySelection("请选择代码输出路径");
            CodeOutputDirText.Text = path;
            m_Setting.OutputCodePath.param = path;
            SettingService.SaveSetting();
        }

        private void DataSourceDirButton_Click(object sender, EventArgs e)
        {
            string path = FileService.OpenDirectorySelection("请选择数据表输配置根目录");
            DataSourceDirText.Text = path;
            m_Setting.DataSourcePath.param = path;
            SettingService.SaveSetting();
        }

        private void RootDefineButton_Click(object sender, EventArgs e)
        {
            string path = FileService.OpenFileSelection("请选择root.xml路径");
            RootDefineText.Text = path;
            m_Setting.RootDefinePath.param = path;
            SettingService.SaveSetting();
        }
    }
}