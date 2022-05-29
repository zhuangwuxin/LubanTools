namespace LubanService
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Navigation = new Sunny.UI.UINavMenu();
            this.TabControl = new Sunny.UI.UITabControl();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.LinkDocument = new Sunny.UI.UILinkLabel();
            this.LinkGithub = new Sunny.UI.UILinkLabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.SystemColors.Control;
            this.Aside.FillColor = System.Drawing.SystemColors.Control;
            this.Aside.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Aside.HotTracking = true;
            this.Aside.HoverColor = System.Drawing.Color.AliceBlue;
            this.Aside.LineColor = System.Drawing.Color.LightGray;
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.ScrollFillColor = System.Drawing.Color.WhiteSmoke;
            this.Aside.SecondBackColor = System.Drawing.SystemColors.ButtonFace;
            this.Aside.SelectedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Aside.SelectedColor2 = System.Drawing.Color.DeepSkyBlue;
            this.Aside.SelectedForeColor = System.Drawing.SystemColors.ControlLight;
            this.Aside.SelectedHighColor = System.Drawing.Color.DeepSkyBlue;
            this.Aside.ShowLines = true;
            this.Aside.Size = new System.Drawing.Size(250, 555);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(1287, 110);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Navigation
            // 
            this.Navigation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Navigation.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.Navigation.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Navigation.FullRowSelect = true;
            this.Navigation.ItemHeight = 50;
            this.Navigation.Location = new System.Drawing.Point(3, 145);
            this.Navigation.Name = "Navigation";
            this.Navigation.ShowLines = false;
            this.Navigation.Size = new System.Drawing.Size(201, 422);
            this.Navigation.Style = Sunny.UI.UIStyle.Custom;
            this.Navigation.TabIndex = 2;
            this.Navigation.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Navigation.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // TabControl
            // 
            this.TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.TabControl.Location = new System.Drawing.Point(201, 145);
            this.TabControl.MainPage = "";
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1083, 422);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.Style = Sunny.UI.UIStyle.Custom;
            this.TabControl.TabIndex = 3;
            this.TabControl.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.BackColor = System.Drawing.SystemColors.Control;
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatar1.Image = global::LubanService.Properties.Resources.luban_logo;
            this.uiAvatar1.Location = new System.Drawing.Point(53, 56);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.TabIndex = 4;
            this.uiAvatar1.Text = "Logo";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.uiLedLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLedLabel1.Location = new System.Drawing.Point(119, 66);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(268, 50);
            this.uiLedLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel1.TabIndex = 5;
            this.uiLedLabel1.Text = "LubanTools";
            this.uiLedLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LinkDocument
            // 
            this.LinkDocument.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.LinkDocument.BackColor = System.Drawing.SystemColors.Control;
            this.LinkDocument.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LinkDocument.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkDocument.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.LinkDocument.Location = new System.Drawing.Point(16, 32);
            this.LinkDocument.Name = "LinkDocument";
            this.LinkDocument.Size = new System.Drawing.Size(146, 22);
            this.LinkDocument.Style = Sunny.UI.UIStyle.Custom;
            this.LinkDocument.TabIndex = 6;
            this.LinkDocument.TabStop = true;
            this.LinkDocument.Text = "Luban使用文档";
            this.LinkDocument.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LinkDocument.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.LinkDocument.Click += new System.EventHandler(this.LinkDocument_Click);
            // 
            // LinkGithub
            // 
            this.LinkGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.LinkGithub.BackColor = System.Drawing.SystemColors.Control;
            this.LinkGithub.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LinkGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkGithub.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.LinkGithub.Location = new System.Drawing.Point(194, 32);
            this.LinkGithub.Name = "LinkGithub";
            this.LinkGithub.Size = new System.Drawing.Size(293, 22);
            this.LinkGithub.Style = Sunny.UI.UIStyle.Custom;
            this.LinkGithub.TabIndex = 7;
            this.LinkGithub.TabStop = true;
            this.LinkGithub.Text = "LubanTools源代码仓库（github）";
            this.LinkGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LinkGithub.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.LinkGithub.Click += new System.EventHandler(this.LinkGithub_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.uiGroupBox1.Controls.Add(this.uiLinkLabel1);
            this.uiGroupBox1.Controls.Add(this.LinkDocument);
            this.uiGroupBox1.Controls.Add(this.LinkGithub);
            this.uiGroupBox1.FillColor = System.Drawing.SystemColors.Control;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(414, 56);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.LightBlue;
            this.uiGroupBox1.Size = new System.Drawing.Size(836, 70);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 8;
            this.uiGroupBox1.Text = "V1.0";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.uiLinkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.uiLinkLabel1.Location = new System.Drawing.Point(517, 32);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(293, 22);
            this.uiLinkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLinkLabel1.TabIndex = 8;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "LubanTools源代码仓库（gitee）";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiLinkLabel1.Click += new System.EventHandler(this.uiLinkLabel1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1287, 700);
            this.ControlBoxFillHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLedLabel1);
            this.Controls.Add(this.uiAvatar1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Navigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.RectColor = System.Drawing.SystemColors.ActiveCaption;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Luban";
            this.TitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1287, 570);
            this.Controls.SetChildIndex(this.Navigation, 0);
            this.Controls.SetChildIndex(this.TabControl, 0);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.uiAvatar1, 0);
            this.Controls.SetChildIndex(this.uiLedLabel1, 0);
            this.Controls.SetChildIndex(this.uiGroupBox1, 0);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Sunny.UI.UINavMenu Navigation;
        private Sunny.UI.UITabControl TabControl;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILedLabel uiLedLabel1;

        #endregion

        private Sunny.UI.UILinkLabel LinkDocument;
        private Sunny.UI.UILinkLabel LinkGithub;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
    }
}

