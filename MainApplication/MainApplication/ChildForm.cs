namespace MainApplication
{
    //this childform, inherits from BaseForm
    //so the "Numbers" property will appear on properties window
    public partial class ChildForm : MainApplication.BaseForm
    {
        public ChildForm()
        {
            InitializeComponent();
        }
    }
    //It works!
}
