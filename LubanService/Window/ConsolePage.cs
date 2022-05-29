using System;
using System.Diagnostics;
using System.Windows.Forms;

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
            if (!SettingService.CheckScript())
            {
                MessageBox.Show("请完善必要参数后再进行导表操作");
                return;
            }

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