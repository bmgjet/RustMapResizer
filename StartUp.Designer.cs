
namespace MapResizer
{
    partial class MapResizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapResizer));
            this.convertbttn = new System.Windows.Forms.Button();
            this.newsizelable = new System.Windows.Forms.Label();
            this.newsize = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // convertbttn
            // 
            this.convertbttn.Location = new System.Drawing.Point(26, 12);
            this.convertbttn.Name = "convertbttn";
            this.convertbttn.Size = new System.Drawing.Size(212, 94);
            this.convertbttn.TabIndex = 0;
            this.convertbttn.Text = "Convert";
            this.convertbttn.UseVisualStyleBackColor = true;
            this.convertbttn.Click += new System.EventHandler(this.convertbttn_Click);
            // 
            // newsizelable
            // 
            this.newsizelable.AutoSize = true;
            this.newsizelable.Location = new System.Drawing.Point(21, 115);
            this.newsizelable.Name = "newsizelable";
            this.newsizelable.Size = new System.Drawing.Size(108, 25);
            this.newsizelable.TabIndex = 2;
            this.newsizelable.Text = "New Size:";
            // 
            // newsize
            // 
            this.newsize.Location = new System.Drawing.Point(153, 112);
            this.newsize.Mask = "00000";
            this.newsize.Name = "newsize";
            this.newsize.Size = new System.Drawing.Size(85, 31);
            this.newsize.TabIndex = 3;
            this.newsize.Text = "1000";
            // 
            // MapResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 166);
            this.Controls.Add(this.newsize);
            this.Controls.Add(this.newsizelable);
            this.Controls.Add(this.convertbttn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapResizer";
            this.Text = "MapResizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertbttn;
        private System.Windows.Forms.Label newsizelable;
        private System.Windows.Forms.MaskedTextBox newsize;
    }
}

