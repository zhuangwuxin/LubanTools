using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LubanService
{
    public partial class MainWindow : UIHeaderAsideMainFrame
    {
        readonly Dictionary<Type, LubanPage> m_TypePages = new Dictionary<Type, LubanPage>();
        readonly Dictionary<int, LubanPage> m_Pages = new Dictionary<int, LubanPage>();
        readonly Dictionary<Type, int> m_Type2Index = new Dictionary<Type, int>();

        public MainWindow()
        {
            InitializeComponent();

            //设置关联
            Aside.TabControl = MainTabControl;

            //创建页签, symbol来自sunnyUI的icon
            RegisterPage<DashBoardPage>("控制台", 61818);
            RegisterPage<SettingPage>("设置(必要参数)", 61451);
            RegisterPage<ConditionalSettingPage>("设置(可选参数)", 61450);

            //默认选中
            SelectPage<DashBoardPage>();
        }

        void SelectPage<T>() where T : LubanPage
        {
            Type t = typeof(T);
            if (m_Type2Index.TryGetValue(t, out int index))
            {
                Aside.SelectPage(index);
            }
        }

        T GetTabPage<T>(int index) where T : LubanPage
        {
            if (m_Pages.TryGetValue(index, out LubanPage page))
            {
                return page as T;
            }

            return null;
        }

        T GetTabPage<T>() where T : LubanPage
        {
            Type t = typeof(T);
            if (m_TypePages.TryGetValue(t, out LubanPage page))
            {
                return page as T;
            }

            return null;
        }

        void RegisterPage<T>(string name, int symbol, int symbolSize = 24) where T : LubanPage
        {
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            T page = Activator.CreateInstance<T>();
            int index = page.ID;
            if (m_Pages.ContainsKey(index))
            {
                return;
            }

            Type t = typeof(T);
            m_Pages[index] = page;
            m_TypePages[t] = page;
            m_Type2Index[t] = index;
            AddPage(page, index);
            Aside.CreateNode(name, symbol, symbolSize, index);
        }

        private void LinkDocument_Click(object sender, EventArgs e)
        {
            LinkDocument.LinkVisited = true;
            Process.Start("https://focus-creative-games.github.io/lubandoc/Home.html");
        }

        private void LinkGithub_Click(object sender, EventArgs e)
        {
            LinkDocument.LinkVisited = true;
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            LinkDocument.LinkVisited = true;
        }
    }
}