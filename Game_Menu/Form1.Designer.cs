namespace Game_Menu
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
            this.startbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Teal;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbtn.Location = new System.Drawing.Point(75, 86);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(246, 62);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Start Game";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Teal;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebtn.Location = new System.Drawing.Point(75, 154);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(246, 62);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save Game";
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // loadbtn
            // 
            this.loadbtn.BackColor = System.Drawing.Color.Teal;
            this.loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadbtn.Location = new System.Drawing.Point(75, 222);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(246, 62);
            this.loadbtn.TabIndex = 2;
            this.loadbtn.Text = "Load Game";
            this.loadbtn.UseVisualStyleBackColor = false;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Teal;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Location = new System.Drawing.Point(75, 290);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(246, 62);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

