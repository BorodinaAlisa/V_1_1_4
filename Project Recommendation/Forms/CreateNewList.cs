namespace design
{
    public partial class CreateNewList : Form
    {
        public CreateNewList()
        {
            InitializeComponent();
            Design();
        }

        public void Design()
        {
            Text1.Parent = Picture5;
            Text1.BackColor = Color.Transparent;
            Text2.Parent = Picture5;
            Text2.BackColor = Color.Transparent;
        }
    }
}
