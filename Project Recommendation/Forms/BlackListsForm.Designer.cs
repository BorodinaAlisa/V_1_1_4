namespace design
{
    partial class BlackList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackList));
            MyListsButton = new Button();
            BlackListButton = new Button();
            FavButton = new Button();
            ProfileButton = new Button();
            Picture6 = new PictureBox();
            listView1 = new ListView();
            PhotoList = new ColumnHeader();
            PriceList = new ColumnHeader();
            AddressList = new ColumnHeader();
            NameList = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)Picture6).BeginInit();
            SuspendLayout();
            // 
            // MyListsButton
            // 
            MyListsButton.Image = (Image)resources.GetObject("MyListsButton.Image");
            MyListsButton.Location = new Point(581, 13);
            MyListsButton.Margin = new Padding(3, 4, 3, 4);
            MyListsButton.Name = "MyListsButton";
            MyListsButton.Size = new Size(58, 58);
            MyListsButton.TabIndex = 16;
            MyListsButton.UseVisualStyleBackColor = true;
            // 
            // BlackListButton
            // 
            BlackListButton.Image = (Image)resources.GetObject("BlackListButton.Image");
            BlackListButton.Location = new Point(479, 13);
            BlackListButton.Margin = new Padding(3, 4, 3, 4);
            BlackListButton.Name = "BlackListButton";
            BlackListButton.Size = new Size(58, 58);
            BlackListButton.TabIndex = 15;
            BlackListButton.UseVisualStyleBackColor = true;
            BlackListButton.Click += BlackListButton_Click;
            // 
            // FavButton
            // 
            FavButton.Image = (Image)resources.GetObject("FavButton.Image");
            FavButton.Location = new Point(247, 13);
            FavButton.Margin = new Padding(3, 4, 3, 4);
            FavButton.Name = "FavButton";
            FavButton.Size = new Size(58, 58);
            FavButton.TabIndex = 14;
            FavButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            ProfileButton.FlatStyle = FlatStyle.Popup;
            ProfileButton.Image = (Image)resources.GetObject("ProfileButton.Image");
            ProfileButton.Location = new Point(149, 13);
            ProfileButton.Margin = new Padding(3, 4, 3, 4);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(58, 58);
            ProfileButton.TabIndex = 13;
            ProfileButton.UseVisualStyleBackColor = true;
            // 
            // Picture6
            // 
            Picture6.BackgroundImageLayout = ImageLayout.Center;
            Picture6.Image = (Image)resources.GetObject("Picture6.Image");
            Picture6.Location = new Point(-3, -2);
            Picture6.Margin = new Padding(3, 4, 3, 4);
            Picture6.Name = "Picture6";
            Picture6.Size = new Size(797, 850);
            Picture6.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture6.TabIndex = 12;
            Picture6.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { PhotoList, PriceList, AddressList, NameList });
            listView1.Location = new Point(32, 140);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(729, 678);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // PhotoList
            // 
            PhotoList.Text = "Изображение";
            PhotoList.Width = 120;
            // 
            // PriceList
            // 
            PriceList.Text = "Цена";
            PriceList.Width = 220;
            // 
            // AddressList
            // 
            AddressList.Text = "Адрес";
            AddressList.Width = 260;
            // 
            // NameList
            // 
            NameList.Text = "Название";
            NameList.Width = 120;
            // 
            // BlackList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 846);
            Controls.Add(listView1);
            Controls.Add(MyListsButton);
            Controls.Add(BlackListButton);
            Controls.Add(FavButton);
            Controls.Add(ProfileButton);
            Controls.Add(Picture6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BlackList";
            ((System.ComponentModel.ISupportInitialize)Picture6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button MyListsButton;
        private System.Windows.Forms.Button BlackListButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.PictureBox Picture6;
        private ListView listView1;
        private ColumnHeader PhotoList;
        private ColumnHeader PriceList;
        private ColumnHeader AddressList;
        private ColumnHeader NameList;
    }
}