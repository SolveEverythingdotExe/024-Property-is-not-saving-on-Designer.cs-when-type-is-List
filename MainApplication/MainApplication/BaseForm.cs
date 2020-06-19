using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class BaseForm : Form
    {
        //we do have a property named "Numbers" and it will
        //appear on the controls that will inherit it, primarily on the properties window
        private List<int> _Numbers = new List<int>();

        //we just need to add this line before our property so that it will save/serialize the value
        //on resource.resx
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<int> Numbers
        {
            get { return _Numbers; }
            set { _Numbers = value; }
        }

        public BaseForm()
        {
            InitializeComponent();
        }
    }
}
