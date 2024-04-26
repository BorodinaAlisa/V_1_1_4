using DB_993.Classes;

namespace design
{
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
        }
        public Card(Realty realties)
        {
            InitializeComponent();
            AddressText.Text = realties.Address;
            SquareText.Text = realties.Square.ToString() + " м^2";
            PriceText.Text = realties.Price.ToString() + " руб";
            FloorText.Text = realties.Floor.ToString();
        }
    }
}
