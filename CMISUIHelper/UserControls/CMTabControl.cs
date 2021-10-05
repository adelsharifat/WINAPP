using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISUIHelper.UserControls
{
    public class CMTabControl : TabControl
    {
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
