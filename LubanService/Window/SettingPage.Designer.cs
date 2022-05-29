namespace LubanService
{
    partial class SettingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.ExePathText = new Sunny.UI.UITextBox();
            this.ExePathButton = new Sunny.UI.UIButton();
            this.GenTypeText = new Sunny.UI.UITextBox();
            this.ResOutputDirButton = new Sunny.UI.UIButton();
            this.DataSourceDirButton = new Sunny.UI.UIButton();
            this.RootDefineButton = new Sunny.UI.UIButton();
            this.CodeOutputDirText = new Sunny.UI.UITextBox();
            this.RootDefineText = new Sunny.UI.UITextBox();
            this.DataSourceDirText = new Sunny.UI.UITextBox();
            this.CodeOutputDirButton = new Sunny.UI.UIButton();
            this.ResOutputDirText = new Sunny.UI.UITextBox();
            this.OutputModeCombo = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.ServiceCombo = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(601, 295);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(395, 33);
            this.uiLabel1.TabIndex = 21;
            this.uiLabel1.Text = "代码生成相关, 例如：code_cs_unity_json,data_json";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ExePathText
            // 
            this.ExePathText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExePathText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExePathText.Location = new System.Drawing.Point(45, 65);
            this.ExePathText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExePathText.MinimumSize = new System.Drawing.Size(1, 16);
            this.ExePathText.Name = "ExePathText";
            this.ExePathText.ShowText = false;
            this.ExePathText.Size = new System.Drawing.Size(649, 36);
            this.ExePathText.TabIndex = 10;
            this.ExePathText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExePathText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ExePathButton
            // 
            this.ExePathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExePathButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExePathButton.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.ExePathButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExePathButton.Location = new System.Drawing.Point(718, 65);
            this.ExePathButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ExePathButton.Name = "ExePathButton";
            this.ExePathButton.RectColor = System.Drawing.Color.White;
            this.ExePathButton.Size = new System.Drawing.Size(278, 36);
            this.ExePathButton.Style = Sunny.UI.UIStyle.Custom;
            this.ExePathButton.TabIndex = 11;
            this.ExePathButton.Text = "LubanClientServer.exe路径选择";
            this.ExePathButton.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExePathButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ExePathButton.Click += new System.EventHandler(this.ExePathButton_Click);
            // 
            // GenTypeText
            // 
            this.GenTypeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GenTypeText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenTypeText.Location = new System.Drawing.Point(45, 295);
            this.GenTypeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenTypeText.MinimumSize = new System.Drawing.Size(1, 16);
            this.GenTypeText.Name = "GenTypeText";
            this.GenTypeText.ShowText = false;
            this.GenTypeText.Size = new System.Drawing.Size(527, 33);
            this.GenTypeText.TabIndex = 19;
            this.GenTypeText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenTypeText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ResOutputDirButton
            // 
            this.ResOutputDirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResOutputDirButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResOutputDirButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResOutputDirButton.Location = new System.Drawing.Point(718, 252);
            this.ResOutputDirButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ResOutputDirButton.Name = "ResOutputDirButton";
            this.ResOutputDirButton.Size = new System.Drawing.Size(278, 33);
            this.ResOutputDirButton.Style = Sunny.UI.UIStyle.Custom;
            this.ResOutputDirButton.TabIndex = 15;
            this.ResOutputDirButton.Text = "资源导出目录";
            this.ResOutputDirButton.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResOutputDirButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ResOutputDirButton.Click += new System.EventHandler(this.ResOutputDirButton_Click);
            // 
            // DataSourceDirButton
            // 
            this.DataSourceDirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataSourceDirButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataSourceDirButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataSourceDirButton.Location = new System.Drawing.Point(718, 208);
            this.DataSourceDirButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.DataSourceDirButton.Name = "DataSourceDirButton";
            this.DataSourceDirButton.Size = new System.Drawing.Size(278, 38);
            this.DataSourceDirButton.Style = Sunny.UI.UIStyle.Custom;
            this.DataSourceDirButton.TabIndex = 17;
            this.DataSourceDirButton.Text = "配置数据目录";
            this.DataSourceDirButton.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataSourceDirButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.DataSourceDirButton.Click += new System.EventHandler(this.DataSourceDirButton_Click);
            // 
            // RootDefineButton
            // 
            this.RootDefineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RootDefineButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.RootDefineButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RootDefineButton.Location = new System.Drawing.Point(718, 165);
            this.RootDefineButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.RootDefineButton.Name = "RootDefineButton";
            this.RootDefineButton.Size = new System.Drawing.Size(278, 34);
            this.RootDefineButton.Style = Sunny.UI.UIStyle.Custom;
            this.RootDefineButton.TabIndex = 20;
            this.RootDefineButton.Text = "root.xml文件路径";
            this.RootDefineButton.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RootDefineButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.RootDefineButton.Click += new System.EventHandler(this.RootDefineButton_Click);
            // 
            // CodeOutputDirText
            // 
            this.CodeOutputDirText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeOutputDirText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeOutputDirText.Location = new System.Drawing.Point(45, 114);
            this.CodeOutputDirText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeOutputDirText.MinimumSize = new System.Drawing.Size(1, 16);
            this.CodeOutputDirText.Name = "CodeOutputDirText";
            this.CodeOutputDirText.ShowText = false;
            this.CodeOutputDirText.Size = new System.Drawing.Size(649, 39);
            this.CodeOutputDirText.TabIndex = 12;
            this.CodeOutputDirText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CodeOutputDirText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RootDefineText
            // 
            this.RootDefineText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RootDefineText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RootDefineText.Location = new System.Drawing.Point(45, 165);
            this.RootDefineText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RootDefineText.MinimumSize = new System.Drawing.Size(1, 16);
            this.RootDefineText.Name = "RootDefineText";
            this.RootDefineText.ShowText = false;
            this.RootDefineText.Size = new System.Drawing.Size(649, 33);
            this.RootDefineText.TabIndex = 14;
            this.RootDefineText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.RootDefineText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DataSourceDirText
            // 
            this.DataSourceDirText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataSourceDirText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataSourceDirText.Location = new System.Drawing.Point(45, 208);
            this.DataSourceDirText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataSourceDirText.MinimumSize = new System.Drawing.Size(1, 16);
            this.DataSourceDirText.Name = "DataSourceDirText";
            this.DataSourceDirText.ShowText = false;
            this.DataSourceDirText.Size = new System.Drawing.Size(649, 29);
            this.DataSourceDirText.TabIndex = 16;
            this.DataSourceDirText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataSourceDirText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CodeOutputDirButton
            // 
            this.CodeOutputDirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CodeOutputDirButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.CodeOutputDirButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeOutputDirButton.Location = new System.Drawing.Point(718, 114);
            this.CodeOutputDirButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.CodeOutputDirButton.Name = "CodeOutputDirButton";
            this.CodeOutputDirButton.Size = new System.Drawing.Size(278, 39);
            this.CodeOutputDirButton.Style = Sunny.UI.UIStyle.Custom;
            this.CodeOutputDirButton.TabIndex = 13;
            this.CodeOutputDirButton.Text = "代码导出目录";
            this.CodeOutputDirButton.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeOutputDirButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CodeOutputDirButton.Click += new System.EventHandler(this.CodeOutputDirButton_Click);
            // 
            // ResOutputDirText
            // 
            this.ResOutputDirText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResOutputDirText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResOutputDirText.Location = new System.Drawing.Point(45, 247);
            this.ResOutputDirText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResOutputDirText.MinimumSize = new System.Drawing.Size(1, 16);
            this.ResOutputDirText.Name = "ResOutputDirText";
            this.ResOutputDirText.ShowText = false;
            this.ResOutputDirText.Size = new System.Drawing.Size(649, 34);
            this.ResOutputDirText.TabIndex = 18;
            this.ResOutputDirText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResOutputDirText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // OutputModeCombo
            // 
            this.OutputModeCombo.DataSource = null;
            this.OutputModeCombo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.OutputModeCombo.FillColor = System.Drawing.Color.White;
            this.OutputModeCombo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OutputModeCombo.Location = new System.Drawing.Point(45, 350);
            this.OutputModeCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputModeCombo.MinimumSize = new System.Drawing.Size(63, 0);
            this.OutputModeCombo.Name = "OutputModeCombo";
            this.OutputModeCombo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.OutputModeCombo.Size = new System.Drawing.Size(649, 37);
            this.OutputModeCombo.TabIndex = 22;
            this.OutputModeCombo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputModeCombo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(718, 350);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(278, 37);
            this.uiLabel2.TabIndex = 23;
            this.uiLabel2.Text = "生成类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ServiceCombo
            // 
            this.ServiceCombo.DataSource = null;
            this.ServiceCombo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ServiceCombo.FillColor = System.Drawing.Color.White;
            this.ServiceCombo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServiceCombo.Location = new System.Drawing.Point(45, 414);
            this.ServiceCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServiceCombo.MinimumSize = new System.Drawing.Size(63, 0);
            this.ServiceCombo.Name = "ServiceCombo";
            this.ServiceCombo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ServiceCombo.Size = new System.Drawing.Size(649, 37);
            this.ServiceCombo.TabIndex = 24;
            this.ServiceCombo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServiceCombo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(718, 414);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(278, 37);
            this.uiLabel3.TabIndex = 25;
            this.uiLabel3.Text = "分组目标";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SettingPage
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1037, 555);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.ServiceCombo);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.OutputModeCombo);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ExePathText);
            this.Controls.Add(this.ExePathButton);
            this.Controls.Add(this.GenTypeText);
            this.Controls.Add(this.ResOutputDirButton);
            this.Controls.Add(this.DataSourceDirButton);
            this.Controls.Add(this.RootDefineButton);
            this.Controls.Add(this.CodeOutputDirText);
            this.Controls.Add(this.RootDefineText);
            this.Controls.Add(this.DataSourceDirText);
            this.Controls.Add(this.CodeOutputDirButton);
            this.Controls.Add(this.ResOutputDirText);
            this.Name = "SettingPage";
            this.Padding = new System.Windows.Forms.Padding(0, 54, 0, 0);
            this.ShowTitle = true;
            this.Text = "必要设置";
            this.TitleFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.TitleHeight = 50;
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox ExePathText;
        private Sunny.UI.UIButton ExePathButton;
        private Sunny.UI.UITextBox GenTypeText;
        private Sunny.UI.UIButton ResOutputDirButton;
        private Sunny.UI.UIButton DataSourceDirButton;
        private Sunny.UI.UIButton RootDefineButton;
        private Sunny.UI.UITextBox CodeOutputDirText;
        private Sunny.UI.UITextBox RootDefineText;
        private Sunny.UI.UITextBox DataSourceDirText;
        private Sunny.UI.UIButton CodeOutputDirButton;
        private Sunny.UI.UITextBox ResOutputDirText;
        private Sunny.UI.UIComboBox OutputModeCombo;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox ServiceCombo;
        private Sunny.UI.UILabel uiLabel3;
    }
}