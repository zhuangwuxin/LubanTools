namespace LubanService
{
    partial class DashBoardPage
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
            this.components = new System.ComponentModel.Container();
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.ExecuteButton = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.ScriptText = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiStyleManager1
            // 
            this.uiStyleManager1.DPIScale = true;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExecuteButton.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExecuteButton.Location = new System.Drawing.Point(41, 82);
            this.ExecuteButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.RectColor = System.Drawing.Color.MintCream;
            this.ExecuteButton.RectHoverColor = System.Drawing.Color.White;
            this.ExecuteButton.RectPressColor = System.Drawing.Color.White;
            this.ExecuteButton.RectSelectedColor = System.Drawing.Color.White;
            this.ExecuteButton.Size = new System.Drawing.Size(202, 54);
            this.ExecuteButton.Style = Sunny.UI.UIStyle.Custom;
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "开始导表";
            this.ExecuteButton.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExecuteButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(307, 63);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(179, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "批处理";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ScriptText
            // 
            this.ScriptText.BackColor = System.Drawing.SystemColors.Control;
            this.ScriptText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptText.FillColor = System.Drawing.SystemColors.Control;
            this.ScriptText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScriptText.Location = new System.Drawing.Point(311, 91);
            this.ScriptText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScriptText.MinimumSize = new System.Drawing.Size(1, 16);
            this.ScriptText.Multiline = true;
            this.ScriptText.Name = "ScriptText";
            this.ScriptText.ReadOnly = true;
            this.ScriptText.ShortcutsEnabled = false;
            this.ScriptText.ShowScrollBar = true;
            this.ScriptText.ShowText = false;
            this.ScriptText.Size = new System.Drawing.Size(700, 433);
            this.ScriptText.Style = Sunny.UI.UIStyle.Custom;
            this.ScriptText.TabIndex = 3;
            this.ScriptText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScriptText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DashBoardPage
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1037, 555);
            this.Controls.Add(this.ScriptText);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "DashBoardPage";
            this.Padding = new System.Windows.Forms.Padding(0, 54, 0, 0);
            this.PageIndex = 1001;
            this.ShowTitle = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "控制台";
            this.TitleFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.TitleHeight = 50;
            this.ResumeLayout(false);

        }

        private Sunny.UI.UIButton ExecuteButton;
        private Sunny.UI.UIStyleManager uiStyleManager1;

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox ScriptText;
    }
}