namespace design
{
    partial class Favorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite));
            Picture6 = new PictureBox();
            ProfileButton = new Button();
            FavButton = new Button();
            BlackListButton = new Button();
            listView1 = new ListView();
            PhotoList = new ColumnHeader();
            PriceList = new ColumnHeader();
            AddressList = new ColumnHeader();
            NameList = new ColumnHeader();
            MyListsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture6).BeginInit();
            SuspendLayout();
            // 
            // Picture6
            // 
            resources.ApplyResources(Picture6, "Picture6");
            Picture6.Name = "Picture6";
            Picture6.TabStop = false;
            // 
            // ProfileButton
            // 
            resources.ApplyResources(ProfileButton, "ProfileButton");
            ProfileButton.Name = "ProfileButton";
            ProfileButton.UseVisualStyleBackColor = true;
            // 
            // FavButton
            // 
            resources.ApplyResources(FavButton, "FavButton");
            FavButton.BackColor = Color.Transparent;
            FavButton.Name = "FavButton";
            FavButton.UseVisualStyleBackColor = false;
            // 
            // BlackListButton
            // 
            resources.ApplyResources(BlackListButton, "BlackListButton");
            BlackListButton.Name = "BlackListButton";
            BlackListButton.UseVisualStyleBackColor = true;
            BlackListButton.Click += BlackListButton_Click;
            // 
            // listView1
            // 
            resources.ApplyResources(listView1, "listView1");
            listView1.Columns.AddRange(new ColumnHeader[] { PhotoList, PriceList, AddressList, NameList });
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // PhotoList
            // 
            resources.ApplyResources(PhotoList, "PhotoList");
            // 
            // PriceList
            // 
            resources.ApplyResources(PriceList, "PriceList");
            // 
            // AddressList
            // 
            resources.ApplyResources(AddressList, "AddressList");
            // 
            // NameList
            // 
            resources.ApplyResources(NameList, "NameList");
            // 
            // MyListsButton
            // 
            resources.ApplyResources(MyListsButton, "MyListsButton");
            MyListsButton.Name = "MyListsButton";
            MyListsButton.UseVisualStyleBackColor = true;
            // 
            // Favorite
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MyListsButton);
            Controls.Add(listView1);
            Controls.Add(BlackListButton);
            Controls.Add(FavButton);
            Controls.Add(ProfileButton);
            Controls.Add(Picture6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Favorite";
            ((System.ComponentModel.ISupportInitialize)Picture6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture6;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button BlackListButton;
        private ListView listView1;
        private ColumnHeader PhotoList;
        private ColumnHeader NameList;
        private ColumnHeader PriceList;
        private ColumnHeader AddressList;
        private Button MyListsButton;
    }
}