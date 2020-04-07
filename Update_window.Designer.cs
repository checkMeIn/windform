namespace Check_Me_In
{
    partial class Update_window
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
            this.Select_room_CB = new System.Windows.Forms.ComboBox();
            this.Select_a_room = new System.Windows.Forms.Label();
            this.Update_Page = new System.Windows.Forms.Label();
            this.UpdateRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Select_room_CB.Location = new System.Drawing.Point(22, 136);
            this.Select_room_CB.Name = "Select_room_CB";
            this.Select_room_CB.Size = new System.Drawing.Size(121, 21);
            this.Select_room_CB.TabIndex = 0;
            // 
            // Select_a_room
            // 
            this.Select_a_room.AutoSize = true;
            this.Select_a_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_a_room.Location = new System.Drawing.Point(17, 108);
            this.Select_a_room.Name = "Select_a_room";
            this.Select_a_room.Size = new System.Drawing.Size(167, 25);
            this.Select_a_room.TabIndex = 1;
            this.Select_a_room.Text = "Select A Room";
            // 
            // Update_Page
            // 
            this.Update_Page.AutoSize = true;
            this.Update_Page.Font = new System.Drawing.Font("Lucida Bright", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Page.Location = new System.Drawing.Point(189, 27);
            this.Update_Page.Name = "Update_Page";
            this.Update_Page.Size = new System.Drawing.Size(426, 42);
            this.Update_Page.TabIndex = 2;
            this.Update_Page.Text = "Update Room Records";
            // 
            // UpdateRec
            // 
            this.UpdateRec.Location = new System.Drawing.Point(298, 302);
            this.UpdateRec.Name = "UpdateRec";
            this.UpdateRec.Size = new System.Drawing.Size(173, 36);
            this.UpdateRec.TabIndex = 3;
            this.UpdateRec.Text = "Update Records";
            this.UpdateRec.UseVisualStyleBackColor = true;
            // 
            // Update_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateRec);
            this.Controls.Add(this.Update_Page);
            this.Controls.Add(this.Select_a_room);
            this.Controls.Add(this.Select_room_CB);
            this.Name = "Update_window";
            this.Text = "Update_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Select_room_CB;
        private System.Windows.Forms.Label Select_a_room;
        private System.Windows.Forms.Label Update_Page;
        private System.Windows.Forms.Button UpdateRec;
    }
}