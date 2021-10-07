using CMISUIHelper.UserControls;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIHelper.Infrastructure.Contracts.CustomEventArgs
{
    public class RibbonPageEventArgs:EventArgs
    {

        private RibbonControl rc;

        public RibbonControl RibbonControl
        {
            get { return rc; }
            set { rc = value; }
        }

        private RibbonPageCategory rpc;

        public RibbonPageCategory RibbonPageCategory
        {
            get { return rpc; }
            set { rpc = value; }
        }



        private RibbonPage rp;

        public RibbonPage RibbonPage
        {
            get { return rp; }
            set { rp = value; }
        }

        private ViewTab view;

        public ViewTab View
        {
            get { return view; }
            set { view = value; }
        }

    }
}
