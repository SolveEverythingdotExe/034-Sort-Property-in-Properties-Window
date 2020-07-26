using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class ParentForm : Form
    {
        //implementation
        private List<Item> _Items = new List<Item>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] //BUGFIX ====> saving of the value is not working
        public List<Item> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }

        public ParentForm()
        {
            InitializeComponent();
        }
    }
}
