﻿using DB_993.Classes;

namespace design
{
    public partial class MarkWindow : Form
    {
        public int IdRealty { get; set; }
        public MarkWindow()
        {
            InitializeComponent();
            Design();
        }
        public MarkWindow(int idRealty)
        {
            InitializeComponent();
            IdRealty = idRealty;
            Design();
        }

        public void Design()
        {
            label1.Parent = Picture9;
            label1.BackColor = Color.Transparent;
            Star1.Parent = Picture9;
            Star1.BackColor = Color.Transparent;
            Star1.FlatAppearance.BorderSize = 0;
            Star1.FlatStyle = FlatStyle.Flat;
            Star2.Parent = Picture9;
            Star2.BackColor = Color.Transparent;
            Star2.FlatAppearance.BorderSize = 0;
            Star2.FlatStyle = FlatStyle.Flat;
            Star3.Parent = Picture9;
            Star3.BackColor = Color.Transparent;
            Star3.FlatAppearance.BorderSize = 0;
            Star3.FlatStyle = FlatStyle.Flat;
            Star4.Parent = Picture9;
            Star4.BackColor = Color.Transparent;
            Star4.FlatAppearance.BorderSize = 0;
            Star4.FlatStyle = FlatStyle.Flat;
            Star5.Parent = Picture9;
            Star5.BackColor = Color.Transparent;
            Star5.FlatAppearance.BorderSize = 0;
            Star5.FlatStyle = FlatStyle.Flat;
            Star11.Parent = Picture9;
            Star11.BackColor = Color.Transparent;
            Star11.FlatAppearance.BorderSize = 0;
            Star11.FlatStyle = FlatStyle.Flat;
            Star22.Parent = Picture9;
            Star22.BackColor = Color.Transparent;
            Star22.FlatAppearance.BorderSize = 0;
            Star22.FlatStyle = FlatStyle.Flat;
            Star33.Parent = Picture9;
            Star33.BackColor = Color.Transparent;
            Star33.FlatAppearance.BorderSize = 0;
            Star33.FlatStyle = FlatStyle.Flat;
            Star44.Parent = Picture9;
            Star44.BackColor = Color.Transparent;
            Star44.FlatAppearance.BorderSize = 0;
            Star44.FlatStyle = FlatStyle.Flat;
            Star55.Parent = Picture9;
            Star55.BackColor = Color.Transparent;
            Star55.FlatAppearance.BorderSize = 0;
            Star55.FlatStyle = FlatStyle.Flat;
        }

        public void MarkInDb(int mark)
        {
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var markInRealty = context.Realtys.FirstOrDefault(m => m.Id == IdRealty);
                markInRealty!.Mark = mark;            
                context.SaveChanges();

            }
        }

        private void Star1_Click(object sender, EventArgs e)
        {
            MarkInDb(0);
            Star1.Hide();
        }

        private void Star2_Click(object sender, EventArgs e)
        {
            MarkInDb(2);
            Star1.Hide();
            Star2.Hide();
        }

        private void Star3_Click(object sender, EventArgs e)
        {
            MarkInDb(3);
            Star1.Hide();
            Star2.Hide();
            Star3.Hide();
        }

        private void Star4_Click(object sender, EventArgs e)
        {
            MarkInDb(4);
            Star1.Hide();
            Star2.Hide();
            Star3.Hide();
            Star4.Hide();
        }

        private void Star5_Click(object sender, EventArgs e)
        {
            MarkInDb(5);
            Star1.Hide();
            Star2.Hide();
            Star3.Hide();
            Star4.Hide();
            Star5.Hide();
        }
    }
}
