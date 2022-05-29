using System;
using System.Diagnostics;

namespace LubanService
{
    public partial class DashBoardPage : LubanPage
    {
        public DashBoardPage()
        {
            InitializeComponent();
            SettingService.OnSaveScript += script => { ScriptText.Text = script; };
            ScriptText.Text = SettingService.LoadScript();
        }

        public override int ID => 1000;

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            SettingService.SaveSetting();
            SettingService.SaveScript();

            Process process = new Process
            {
                StartInfo =
                {
                    FileName = FileService.ScriptFilePath,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Normal,
                    UseShellExecute = true
                }
            };
            process.Start();
            process.WaitForExit();
        }
    }
}