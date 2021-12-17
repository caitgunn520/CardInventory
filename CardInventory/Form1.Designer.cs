
namespace CardInventory
{
    partial class Form1
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.healthInput = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.powLabel = new System.Windows.Forms.Label();
            this.powInput = new System.Windows.Forms.NumericUpDown();
            this.descripLabel = new System.Windows.Forms.Label();
            this.descripInput = new System.Windows.Forms.TextBox();
            this.cardList = new System.Windows.Forms.TextBox();
            this.cardListLabel = new System.Windows.Forms.Label();
            this.cardDisplay = new System.Windows.Forms.Panel();
            this.powerDisplay = new System.Windows.Forms.Label();
            this.healthDisplay = new System.Windows.Forms.Label();
            this.descripDisplay = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.viewPreviewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.selectInput = new System.Windows.Forms.TextBox();
            this.removeSelectButton = new System.Windows.Forms.Button();
            this.viewSelectButton = new System.Windows.Forms.Button();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.nameSearchTrue = new System.Windows.Forms.CheckBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.healthSearch = new System.Windows.Forms.NumericUpDown();
            this.healthSearchTrue = new System.Windows.Forms.CheckBox();
            this.powerSearch = new System.Windows.Forms.NumericUpDown();
            this.powerSearchTrue = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.healthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powInput)).BeginInit();
            this.cardDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(86, 43);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(152, 20);
            this.nameInput.TabIndex = 0;
            // 
            // healthInput
            // 
            this.healthInput.Location = new System.Drawing.Point(86, 91);
            this.healthInput.Name = "healthInput";
            this.healthInput.Size = new System.Drawing.Size(41, 20);
            this.healthInput.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name: ";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(31, 93);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(44, 13);
            this.healthLabel.TabIndex = 3;
            this.healthLabel.Text = "Health: ";
            // 
            // powLabel
            // 
            this.powLabel.AutoSize = true;
            this.powLabel.Location = new System.Drawing.Point(142, 93);
            this.powLabel.Name = "powLabel";
            this.powLabel.Size = new System.Drawing.Size(43, 13);
            this.powLabel.TabIndex = 4;
            this.powLabel.Text = "Power: ";
            // 
            // powInput
            // 
            this.powInput.Location = new System.Drawing.Point(191, 91);
            this.powInput.Name = "powInput";
            this.powInput.Size = new System.Drawing.Size(47, 20);
            this.powInput.TabIndex = 5;
            // 
            // descripLabel
            // 
            this.descripLabel.AutoSize = true;
            this.descripLabel.Location = new System.Drawing.Point(9, 138);
            this.descripLabel.Name = "descripLabel";
            this.descripLabel.Size = new System.Drawing.Size(66, 13);
            this.descripLabel.TabIndex = 6;
            this.descripLabel.Text = "Description: ";
            // 
            // descripInput
            // 
            this.descripInput.Location = new System.Drawing.Point(86, 135);
            this.descripInput.Multiline = true;
            this.descripInput.Name = "descripInput";
            this.descripInput.Size = new System.Drawing.Size(152, 85);
            this.descripInput.TabIndex = 7;
            // 
            // cardList
            // 
            this.cardList.Location = new System.Drawing.Point(615, 33);
            this.cardList.Multiline = true;
            this.cardList.Name = "cardList";
            this.cardList.Size = new System.Drawing.Size(150, 174);
            this.cardList.TabIndex = 8;
            // 
            // cardListLabel
            // 
            this.cardListLabel.AutoSize = true;
            this.cardListLabel.Location = new System.Drawing.Point(550, 36);
            this.cardListLabel.Name = "cardListLabel";
            this.cardListLabel.Size = new System.Drawing.Size(54, 13);
            this.cardListLabel.TabIndex = 9;
            this.cardListLabel.Text = "Card List: ";
            // 
            // cardDisplay
            // 
            this.cardDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardDisplay.Controls.Add(this.powerDisplay);
            this.cardDisplay.Controls.Add(this.healthDisplay);
            this.cardDisplay.Controls.Add(this.descripDisplay);
            this.cardDisplay.Controls.Add(this.nameDisplay);
            this.cardDisplay.Location = new System.Drawing.Point(355, 43);
            this.cardDisplay.Name = "cardDisplay";
            this.cardDisplay.Size = new System.Drawing.Size(138, 203);
            this.cardDisplay.TabIndex = 10;
            // 
            // powerDisplay
            // 
            this.powerDisplay.Location = new System.Drawing.Point(116, 178);
            this.powerDisplay.Name = "powerDisplay";
            this.powerDisplay.Size = new System.Drawing.Size(17, 20);
            this.powerDisplay.TabIndex = 3;
            // 
            // healthDisplay
            // 
            this.healthDisplay.Location = new System.Drawing.Point(3, 178);
            this.healthDisplay.Name = "healthDisplay";
            this.healthDisplay.Size = new System.Drawing.Size(17, 23);
            this.healthDisplay.TabIndex = 2;
            // 
            // descripDisplay
            // 
            this.descripDisplay.Location = new System.Drawing.Point(22, 97);
            this.descripDisplay.Name = "descripDisplay";
            this.descripDisplay.Size = new System.Drawing.Size(95, 66);
            this.descripDisplay.TabIndex = 1;
            // 
            // nameDisplay
            // 
            this.nameDisplay.Location = new System.Drawing.Point(6, 7);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(127, 13);
            this.nameDisplay.TabIndex = 0;
            this.nameDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(86, 254);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(152, 31);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add Card";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewPreviewButton
            // 
            this.viewPreviewButton.Location = new System.Drawing.Point(86, 291);
            this.viewPreviewButton.Name = "viewPreviewButton";
            this.viewPreviewButton.Size = new System.Drawing.Size(152, 39);
            this.viewPreviewButton.TabIndex = 12;
            this.viewPreviewButton.Text = "Show Preview";
            this.viewPreviewButton.UseVisualStyleBackColor = true;
            this.viewPreviewButton.Click += new System.EventHandler(this.viewPreviewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(86, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(152, 31);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save All Cards";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(86, 373);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(152, 33);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "Load Saved Cards";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // selectInput
            // 
            this.selectInput.Location = new System.Drawing.Point(355, 291);
            this.selectInput.Name = "selectInput";
            this.selectInput.Size = new System.Drawing.Size(138, 20);
            this.selectInput.TabIndex = 15;
            // 
            // removeSelectButton
            // 
            this.removeSelectButton.Location = new System.Drawing.Point(431, 336);
            this.removeSelectButton.Name = "removeSelectButton";
            this.removeSelectButton.Size = new System.Drawing.Size(62, 27);
            this.removeSelectButton.TabIndex = 16;
            this.removeSelectButton.Text = "Remove";
            this.removeSelectButton.UseVisualStyleBackColor = true;
            this.removeSelectButton.Click += new System.EventHandler(this.removeSelectButton_Click);
            // 
            // viewSelectButton
            // 
            this.viewSelectButton.Location = new System.Drawing.Point(355, 336);
            this.viewSelectButton.Name = "viewSelectButton";
            this.viewSelectButton.Size = new System.Drawing.Size(60, 27);
            this.viewSelectButton.TabIndex = 17;
            this.viewSelectButton.Text = "View";
            this.viewSelectButton.UseVisualStyleBackColor = true;
            this.viewSelectButton.Click += new System.EventHandler(this.viewSelectButton_Click);
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(591, 254);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(104, 20);
            this.nameSearch.TabIndex = 18;
            // 
            // nameSearchTrue
            // 
            this.nameSearchTrue.AutoSize = true;
            this.nameSearchTrue.Location = new System.Drawing.Point(708, 256);
            this.nameSearchTrue.Name = "nameSearchTrue";
            this.nameSearchTrue.Size = new System.Drawing.Size(54, 17);
            this.nameSearchTrue.TabIndex = 19;
            this.nameSearchTrue.Text = "Name";
            this.nameSearchTrue.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(595, 222);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(100, 13);
            this.searchLabel.TabIndex = 20;
            this.searchLabel.Text = "Search based on... ";
            // 
            // healthSearch
            // 
            this.healthSearch.Location = new System.Drawing.Point(591, 302);
            this.healthSearch.Name = "healthSearch";
            this.healthSearch.Size = new System.Drawing.Size(47, 20);
            this.healthSearch.TabIndex = 21;
            // 
            // healthSearchTrue
            // 
            this.healthSearchTrue.AutoSize = true;
            this.healthSearchTrue.Location = new System.Drawing.Point(653, 304);
            this.healthSearchTrue.Name = "healthSearchTrue";
            this.healthSearchTrue.Size = new System.Drawing.Size(57, 17);
            this.healthSearchTrue.TabIndex = 22;
            this.healthSearchTrue.Text = "Health";
            this.healthSearchTrue.UseVisualStyleBackColor = true;
            // 
            // powerSearch
            // 
            this.powerSearch.Location = new System.Drawing.Point(591, 336);
            this.powerSearch.Name = "powerSearch";
            this.powerSearch.Size = new System.Drawing.Size(47, 20);
            this.powerSearch.TabIndex = 23;
            // 
            // powerSearchTrue
            // 
            this.powerSearchTrue.AutoSize = true;
            this.powerSearchTrue.Location = new System.Drawing.Point(653, 337);
            this.powerSearchTrue.Name = "powerSearchTrue";
            this.powerSearchTrue.Size = new System.Drawing.Size(56, 17);
            this.powerSearchTrue.TabIndex = 24;
            this.powerSearchTrue.Text = "Power";
            this.powerSearchTrue.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(591, 373);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 42);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.powerSearchTrue);
            this.Controls.Add(this.powerSearch);
            this.Controls.Add(this.healthSearchTrue);
            this.Controls.Add(this.healthSearch);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.nameSearchTrue);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.viewSelectButton);
            this.Controls.Add(this.removeSelectButton);
            this.Controls.Add(this.selectInput);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.viewPreviewButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cardDisplay);
            this.Controls.Add(this.cardListLabel);
            this.Controls.Add(this.cardList);
            this.Controls.Add(this.descripInput);
            this.Controls.Add(this.descripLabel);
            this.Controls.Add(this.powInput);
            this.Controls.Add(this.powLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.healthInput);
            this.Controls.Add(this.nameInput);
            this.Name = "Form1";
            this.Text = "Card Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.healthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powInput)).EndInit();
            this.cardDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healthSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.NumericUpDown healthInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label powLabel;
        private System.Windows.Forms.NumericUpDown powInput;
        private System.Windows.Forms.Label descripLabel;
        private System.Windows.Forms.TextBox descripInput;
        private System.Windows.Forms.TextBox cardList;
        private System.Windows.Forms.Label cardListLabel;
        private System.Windows.Forms.Panel cardDisplay;
        private System.Windows.Forms.Label nameDisplay;
        private System.Windows.Forms.Label powerDisplay;
        private System.Windows.Forms.Label healthDisplay;
        private System.Windows.Forms.Label descripDisplay;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewPreviewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox selectInput;
        private System.Windows.Forms.Button removeSelectButton;
        private System.Windows.Forms.Button viewSelectButton;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.CheckBox nameSearchTrue;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.NumericUpDown healthSearch;
        private System.Windows.Forms.CheckBox healthSearchTrue;
        private System.Windows.Forms.NumericUpDown powerSearch;
        private System.Windows.Forms.CheckBox powerSearchTrue;
        private System.Windows.Forms.Button searchButton;
    }
}

