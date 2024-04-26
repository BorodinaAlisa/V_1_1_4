namespace design
{
    public partial class CollectionCard : Form
    {
        public CollectionCard()
        {
            InitializeComponent();
            Design();
        }

        public void Design()
        {
            Name.Parent = Picture7;
            Name.BackColor = Color.Transparent;
            ProfileButton.Parent = Picture7;
            ProfileButton.BackColor = Color.Transparent;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            FavButton.Parent = Picture7;
            FavButton.BackColor = Color.Transparent;
            FavButton.FlatAppearance.BorderSize = 0;
            FavButton.FlatStyle = FlatStyle.Flat;
            BlackListButton.Parent = Picture7;
            BlackListButton.BackColor = Color.Transparent;
            BlackListButton.FlatAppearance.BorderSize = 0;
            BlackListButton.FlatStyle = FlatStyle.Flat;
            MyListsButton.Parent = Picture7;
            MyListsButton.BackColor = Color.Transparent;
            MyListsButton.FlatAppearance.BorderSize = 0;
            MyListsButton.FlatStyle = FlatStyle.Flat;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
        }
    }
}
