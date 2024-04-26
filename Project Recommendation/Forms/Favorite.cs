using DB_993.Classes;
using DB_993.Resourse;

namespace design
{
    public partial class Favorite : Form
    {
        public int IdRealryForFav { get; set; }
        public List<Realty>? ListRealty { get; set; }
        public Favorite()
        {

            InitializeComponent();
            LoadData();
            Design();
        }
        public Favorite(int idRealty)
        {
            IdRealryForFav = idRealty;
            FillTableFavourites();
            InitializeComponent();
            Design();

        }

        private void Design()
        {
            ProfileButton.Parent = Picture6;
            ProfileButton.BackColor = Color.Transparent;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            FavButton.Parent = Picture6;
            FavButton.BackColor = Color.Transparent;
            FavButton.FlatAppearance.BorderSize = 0;
            FavButton.FlatStyle = FlatStyle.Flat;
            BlackListButton.Parent = Picture6;
            BlackListButton.BackColor = Color.Transparent;
            BlackListButton.FlatAppearance.BorderSize = 0;
            BlackListButton.FlatStyle = FlatStyle.Flat;
            MyListsButton.Parent = Picture6;
            MyListsButton.BackColor = Color.Transparent;
            MyListsButton.FlatAppearance.BorderSize = 0;
            MyListsButton.FlatStyle = FlatStyle.Flat;
        }

        private void FillTableFavourites()
        {
            using (var context = new ApplicationContex())
            {
                var existingUser = context.Favourites.FirstOrDefault(fav => fav.Id_Realty == IdRealryForFav);
                if (existingUser != null)
                {
                    MessageBox.Show(FavoriteLocal.FavoriteText);
                    return;
                }
                var newFav = new Favourites
                {
                    Id_Realty = IdRealryForFav
                };
                context.Favourites.Add(newFav);
                context.SaveChanges();
            }
        }
        private void LoadData()
        {
            using (var context = new ApplicationContex())
            {
                var imageList = new ImageList();
                imageList.ImageSize = new Size(100, 100);
                var tableFav = context.Favourites.ToList();
                var listRealty = new List<Realty>();
                for (int i = 0; i < tableFav.Count; i++)
                {
                    var itemRealty = context.Realtys.FirstOrDefault(realty => realty.Id == tableFav[i].Id_Realty);
                    listRealty.Add(itemRealty!);
                }
                ListRealty = listRealty;
                for (int i = 0; i < listRealty.Count; i++)
                {
                    imageList.Images.Add(new Bitmap(listRealty[i].PhotoRealty!));
                }
                listView1.SmallImageList = imageList;

                for (int i = 0; i < listRealty.Count; i++)
                {
                    var listViewItem = new ListViewItem(new string[] { String.Empty, listRealty[i].Price.ToString()!,
                        listRealty[i].Address!, listRealty[i].NameRealty!});
                    listViewItem.ImageIndex = i;
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void BlackListButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            using (var context = new ApplicationContex())
            {
                var fav = context.Favourites.ToList();
                for (int i = 0; i < fav!.Count; i++)
                {
                    if (fav != null)
                    {
                        context.Favourites.Remove(fav[i]);
                        context.SaveChanges();
                    }
                }

            }
        }
    }
}
