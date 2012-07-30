using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Slb.InversionOptimization.InversionManagerFormsApplication
{
    public partial class InversionManagerForm : Form
    {

        private InvokeFac.Lambda1Inp<ListViewItem, ListViewItem> listViewInversionItemsAdd;
        private Dictionary<ListViewItem, IInversion> listViewItemDict = new Dictionary<ListViewItem, IInversion>();
        private IRobotServiceAdapter robotServiceAdapter;

        public InversionManagerForm(IRobotServiceAdapter robotServiceAdapter)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.robotServiceAdapter = robotServiceAdapter;
            listViewInversionItemsAdd = InvokeFac.makeLambda1InpInvoke<ListViewItem, ListViewItem>(listViewInversion.Items.Add, this);
            
        }

        /// <summary>
        /// make a ListViewItem, associate the ListViewItem to IItem using listViewItemDict
        /// </summary>
        /// <param name="item">item to put on the itemlist of the room</param>
        /// <returns>new ListViewItem</returns>
        private ListViewItem MakeListViewItem(IInversion inversion)
        {
            //TODO: check if item is already in list
            ListViewItem listviewitem = new ListViewItem("An inversion");
            listViewItemDict.Add(listviewitem, inversion);
            return listviewitem;
        }

        private void btn_Init_Click(object sender, EventArgs e)
        {
            IInversion inversion = new Inversion(Guid.NewGuid(), "12345 is an accessCode", null);
            
            robotServiceAdapter.InitInversion(Guid.NewGuid(), inversion.InversionID, Guid.NewGuid());

            listViewInversionItemsAdd(MakeListViewItem(inversion));
        }

    }
}
