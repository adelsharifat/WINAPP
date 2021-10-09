using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISControls.Tab
{
    public class PageViewer:TabControl
    {
        Dictionary<int, TabPage> OpenedTabs = new Dictionary<int, TabPage>();
        
        public TabPage Open(int tabPageId,string viewTypeName)
        {
            viewTypeName = viewTypeName.Replace('-', '_');
            if (OpenedTabs.ContainsKey(tabPageId))
            {
                this.SelectTab(OpenedTabs[tabPageId]);
                return this.SelectedTab;
            }
            else
            {
                if (GetInstance(viewTypeName) == null) return this.SelectedTab;
                TabPage tabPage = new TabPage();
                UserControl viewPage = (UserControl)GetInstance(viewTypeName);
                tabPage.Name = viewPage.Name;
                OpenedTabs.Add(tabPageId, tabPage);                                
                tabPage.Controls.Add(viewPage);
                viewPage.Dock = DockStyle.Fill;
                this.TabPages.Add(tabPage);
                this.SelectTab(tabPage);
                return tabPage;
            }
        }


        public object GetInstance(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }



        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1300 + 40)
            {
                RECT rc = (RECT)m.GetLParam(typeof(RECT));
                rc.Left -= 5;
                rc.Right += 5;
                rc.Top -= 6;
                rc.Bottom += 5;
                Marshal.StructureToPtr(rc, m.LParam, true);
            }
            base.WndProc(ref m);
        }
    }

    public struct RECT
    {
        public int Left, Top, Right, Bottom;
    }
}
