namespace Check_Me_In
{
    partial class check_in_form
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
            this.checkIn_Page = new System.Windows.Forms.Label();
            this.Select_room_CB = new System.Windows.Forms.ComboBox();
            this.Select_a_room = new System.Windows.Forms.Label();
            this.bookin = new System.Windows.Forms.Button();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.date_in = new System.Windows.Forms.Label();
            this.date_out = new System.Windows.Forms.Label();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.L_Name = new System.Windows.Forms.TextBox();
            this.FirstNameLB = new System.Windows.Forms.Label();
            this.LastNameLB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.MalecheckBox = new System.Windows.Forms.CheckBox();
            this.femalecheckBox = new System.Windows.Forms.CheckBox();
            this.Rate = new System.Windows.Forms.Label();
            this.Ratebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkIn_Page
            // 
            this.checkIn_Page.AutoSize = true;
            this.checkIn_Page.Font = new System.Drawing.Font("Lucida Bright", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_Page.Location = new System.Drawing.Point(286, 24);
            this.checkIn_Page.Name = "checkIn_Page";
            this.checkIn_Page.Size = new System.Drawing.Size(305, 42);
            this.checkIn_Page.TabIndex = 4;
            this.checkIn_Page.Text = "Check  In Guest";
            // 
            // Select_room_CB
            // 
            this.Select_room_CB.FormattingEnabled = true;
            this.Select_room_CB.Items.AddRange(new object[] {
            "1 room",
            "2 room",
            "3 room",
            "4 room",
            "5 room",
            "6 room"});
            this.Select_room_CB.Location = new System.Drawing.Point(23, 89);
            this.Select_room_CB.Name = "Select_room_CB";
            this.Select_room_CB.Size = new System.Drawing.Size(121, 21);
            this.Select_room_CB.TabIndex = 5;
            // 
            // Select_a_room
            // 
            this.Select_a_room.AutoSize = true;
            this.Select_a_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_a_room.Location = new System.Drawing.Point(1, 61);
            this.Select_a_room.Name = "Select_a_room";
            this.Select_a_room.Size = new System.Drawing.Size(167, 25);
            this.Select_a_room.TabIndex = 6;
            this.Select_a_room.Text = "Select A Room";
            // 
            // bookin
            // 
            this.bookin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookin.Location = new System.Drawing.Point(305, 389);
            this.bookin.Name = "bookin";
            this.bookin.Size = new System.Drawing.Size(159, 49);
            this.bookin.TabIndex = 7;
            this.bookin.Text = "Book In Guest";
            this.bookin.UseVisualStyleBackColor = true;
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(23, 249);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(200, 20);
            this.dateIn.TabIndex = 8;
            this.dateIn.ValueChanged += new System.EventHandler(this.dateIn_ValueChanged);
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(23, 347);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(200, 20);
            this.dateOut.TabIndex = 9;
            this.dateOut.ValueChanged += new System.EventHandler(this.dateOut_ValueChanged);
            // 
            // date_in
            // 
            this.date_in.AutoSize = true;
            this.date_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.Location = new System.Drawing.Point(23, 230);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(61, 18);
            this.date_in.TabIndex = 10;
            this.date_in.Text = "Date In";
            this.date_in.Click += new System.EventHandler(this.date_in_Click);
            // 
            // date_out
            // 
            this.date_out.AutoSize = true;
            this.date_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_out.Location = new System.Drawing.Point(23, 326);
            this.date_out.Name = "date_out";
            this.date_out.Size = new System.Drawing.Size(75, 18);
            this.date_out.TabIndex = 11;
            this.date_out.Text = "Date Out";
            this.date_out.Click += new System.EventHandler(this.date_out_Click);
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(338, 161);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(159, 20);
            this.F_Name.TabIndex = 12;
            this.F_Name.TextChanged += new System.EventHandler(this.F_Name_TextChanged);
            // 
            // L_Name
            // 
            this.L_Name.Location = new System.Drawing.Point(532, 161);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(159, 20);
            this.L_Name.TabIndex = 13;
            // 
            // FirstNameLB
            // 
            this.FirstNameLB.AutoSize = true;
            this.FirstNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLB.Location = new System.Drawing.Point(335, 136);
            this.FirstNameLB.Name = "FirstNameLB";
            this.FirstNameLB.Size = new System.Drawing.Size(91, 18);
            this.FirstNameLB.TabIndex = 14;
            this.FirstNameLB.Text = "First Name";
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LastNameLB.Location = new System.Drawing.Point(534, 136);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(89, 18);
            this.LastNameLB.TabIndex = 15;
            this.LastNameLB.Text = "Last Name";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gender.Location = new System.Drawing.Point(335, 219);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 18);
            this.Gender.TabIndex = 16;
            this.Gender.Text = "Gender";
            // 
            // MalecheckBox
            // 
            this.MalecheckBox.AutoSize = true;
            this.MalecheckBox.Location = new System.Drawing.Point(404, 220);
            this.MalecheckBox.Name = "MalecheckBox";
            this.MalecheckBox.Size = new System.Drawing.Size(49, 17);
            this.MalecheckBox.TabIndex = 17;
            this.MalecheckBox.Text = "Male";
            this.MalecheckBox.UseVisualStyleBackColor = true;
            // 
            // femalecheckBox
            // 
            this.femalecheckBox.AutoSize = true;
            this.femalecheckBox.Location = new System.Drawing.Point(459, 222);
            this.femalecheckBox.Name = "femalecheckBox";
            this.femalecheckBox.Size = new System.Drawing.Size(60, 17);
            this.femalecheckBox.TabIndex = 18;
            this.femalecheckBox.Text = "Female";
            this.femalecheckBox.UseVisualStyleBackColor = true;
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rate.Location = new System.Drawing.Point(23, 141);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(57, 18);
            this.Rate.TabIndex = 19;
            this.Rate.Text = "Rate $";
            // 
            // Ratebox
            // 
            this.Ratebox.Location = new System.Drawing.Point(23, 177);
            this.Ratebox.Name = "Ratebox";
            this.Ratebox.Size = new System.Drawing.Size(159, 20);
            this.Ratebox.TabIndex = 20;
            // 
            // check_in_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ratebox);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.femalecheckBox);
            this.Controls.Add(this.MalecheckBox);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastNameLB);
            this.Controls.Add(this.FirstNameLB);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.date_out);
            this.Controls.Add(this.date_in);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.bookin);
            this.Controls.Add(this.Select_a_room);
            this.Controls.Add(this.Select_room_CB);
            this.Controls.Add(this.checkIn_Page);
            this.Name = "check_in_form";
            this.Text = "check_in_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkIn_Page;
        private System.Windows.Forms.ComboBox Select_room_CB;
        private System.Windows.Forms.Label Select_a_room;
        private System.Windows.Forms.Button bookin;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Label date_in;
        private System.Windows.Forms.Label date_out;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.TextBox L_Name;
        private System.Windows.Forms.Label FirstNameLB;
        private System.Windows.Forms.Label LastNameLB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.CheckBox MalecheckBox;
        private System.Windows.Forms.CheckBox femalecheckBox;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.TextBox Ratebox;
    }
}