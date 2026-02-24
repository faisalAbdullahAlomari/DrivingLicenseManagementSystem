namespace PresentationLayer
{
    partial class People
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(People));
            lvPeople = new ListView();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            btnAddPerson = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lvPeople
            // 
            lvPeople.Location = new Point(12, 162);
            lvPeople.Name = "lvPeople";
            lvPeople.Size = new Size(958, 322);
            lvPeople.TabIndex = 0;
            lvPeople.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 125);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(89, 122);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(195, 28);
            cbFilterBy.TabIndex = 2;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 500);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Filter By:";
            // 
            // btnAddPerson
            // 
            btnAddPerson.FlatAppearance.BorderSize = 0;
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Image = (Image)resources.GetObject("btnAddPerson.Image");
            btnAddPerson.Location = new Point(919, 104);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(51, 46);
            btnAddPerson.TabIndex = 4;
            btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(876, 496);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 39);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // People
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnClose);
            Controls.Add(btnAddPerson);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(lvPeople);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "People";
            Text = "Form1";
            Load += People_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvPeople;
        private Label label1;
        private ComboBox cbFilterBy;
        private Label label2;
        private Button btnAddPerson;
        private Button btnClose;
    }
}
