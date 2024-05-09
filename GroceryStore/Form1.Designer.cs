namespace GroceryStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            addBox = new TextBox();
            RemoveBox = new TextBox();
            Confirmation = new CheckBox();
            Category = new ComboBox();
            button2 = new Button();
            DisplayButton = new Button();
            DisplayBox = new RichTextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(618, 64);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 64);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Add Item";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 145);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Remove Item";
            // 
            // addBox
            // 
            addBox.Location = new Point(421, 62);
            addBox.Name = "addBox";
            addBox.Size = new Size(125, 27);
            addBox.TabIndex = 5;
            // 
            // RemoveBox
            // 
            RemoveBox.Location = new Point(233, 142);
            RemoveBox.Name = "RemoveBox";
            RemoveBox.Size = new Size(125, 27);
            RemoveBox.TabIndex = 6;
            // 
            // Confirmation
            // 
            Confirmation.AutoSize = true;
            Confirmation.Location = new Point(421, 148);
            Confirmation.Name = "Confirmation";
            Confirmation.Size = new Size(127, 24);
            Confirmation.TabIndex = 9;
            Confirmation.Text = "Are you sure??";
            Confirmation.UseVisualStyleBackColor = true;
            Confirmation.CheckedChanged += Confirmation_CheckedChanged;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Pick the Category", "Dairy", "Bakery", "Deli", "Health and Beauty", "Seafood", "Butchery" });
            Category.Location = new Point(96, 56);
            Category.Name = "Category";
            Category.Size = new Size(151, 28);
            Category.TabIndex = 10;
            Category.Text = "Pick the Category";
            // 
            // button2
            // 
            button2.Location = new Point(618, 145);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(187, 273);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(118, 29);
            DisplayButton.TabIndex = 13;
            DisplayButton.Text = "Display Recite";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += button3_Click;
            // 
            // DisplayBox
            // 
            DisplayBox.Location = new Point(96, 318);
            DisplayBox.Name = "DisplayBox";
            DisplayBox.Size = new Size(616, 120);
            DisplayBox.TabIndex = 14;
            DisplayBox.Text = "";
            // 
            // button4
            // 
            button4.Location = new Point(506, 273);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(DisplayBox);
            Controls.Add(DisplayButton);
            Controls.Add(button2);
            Controls.Add(Category);
            Controls.Add(Confirmation);
            Controls.Add(RemoveBox);
            Controls.Add(addBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Grocery Store ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox RemoveBox;
        private CheckBox Confirmation;
        private ComboBox Category;
        private Button button2;
        private Button DisplayButton;
        private TextBox addBox;
        private RichTextBox DisplayBox;
        private Button button4;
    }
}
