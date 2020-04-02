namespace AppCrush
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.lbCaption = new System.Windows.Forms.Label();
            this.bt_dy = new System.Windows.Forms.Button();
            this.bt_kdy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaption.ForeColor = System.Drawing.Color.Red;
            this.lbCaption.Location = new System.Drawing.Point(12, 9);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(451, 31);
            this.lbCaption.TabIndex = 0;
            this.lbCaption.Text = "Em đồng ý làm người yêu anh nhé !!!";
            // 
            // bt_dy
            // 
            this.bt_dy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dy.Location = new System.Drawing.Point(18, 82);
            this.bt_dy.Name = "bt_dy";
            this.bt_dy.Size = new System.Drawing.Size(167, 46);
            this.bt_dy.TabIndex = 0;
            this.bt_dy.Text = "Đồng ý";
            this.bt_dy.UseVisualStyleBackColor = true;
            this.bt_dy.Click += new System.EventHandler(this.bt_dy_Click);
            // 
            // bt_kdy
            // 
            this.bt_kdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_kdy.Location = new System.Drawing.Point(272, 82);
            this.bt_kdy.Name = "bt_kdy";
            this.bt_kdy.Size = new System.Drawing.Size(205, 46);
            this.bt_kdy.TabIndex = 1;
            this.bt_kdy.Text = "Không đồng ý";
            this.bt_kdy.UseVisualStyleBackColor = true;
            this.bt_kdy.Click += new System.EventHandler(this.bt_kdy_Click);
            this.bt_kdy.MouseLeave += new System.EventHandler(this.bt_kdy_MouseLeave);
            this.bt_kdy.MouseHover += new System.EventHandler(this.bt_kdy_MouseHover);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 157);
            this.Controls.Add(this.bt_kdy);
            this.Controls.Add(this.bt_dy);
            this.Controls.Add(this.lbCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crush";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.Button bt_dy;
        private System.Windows.Forms.Button bt_kdy;
    }
}

