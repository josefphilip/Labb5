namespace Labb5
{
    partial class imageCounter
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.extractURLBTN = new System.Windows.Forms.Button();
            this.saveImagesBTN = new System.Windows.Forms.Button();
            this.labelImagesFound = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richtextboxURLS = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 12);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(695, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // extractURLBTN
            // 
            this.extractURLBTN.Location = new System.Drawing.Point(713, 9);
            this.extractURLBTN.Name = "extractURLBTN";
            this.extractURLBTN.Size = new System.Drawing.Size(75, 23);
            this.extractURLBTN.TabIndex = 1;
            this.extractURLBTN.Text = "Extract";
            this.extractURLBTN.UseVisualStyleBackColor = true;
            this.extractURLBTN.Click += new System.EventHandler(this.extractURLBTN_Click);
            // 
            // saveImagesBTN
            // 
            this.saveImagesBTN.Location = new System.Drawing.Point(697, 412);
            this.saveImagesBTN.Name = "saveImagesBTN";
            this.saveImagesBTN.Size = new System.Drawing.Size(91, 23);
            this.saveImagesBTN.TabIndex = 3;
            this.saveImagesBTN.Text = "Save Images";
            this.saveImagesBTN.UseVisualStyleBackColor = true;
            this.saveImagesBTN.Click += new System.EventHandler(this.saveImagesBTN_Click);
            // 
            // labelImagesFound
            // 
            this.labelImagesFound.AutoSize = true;
            this.labelImagesFound.Location = new System.Drawing.Point(12, 422);
            this.labelImagesFound.Name = "labelImagesFound";
            this.labelImagesFound.Size = new System.Drawing.Size(74, 13);
            this.labelImagesFound.TabIndex = 4;
            this.labelImagesFound.Text = "Images found:";
            this.labelImagesFound.Click += new System.EventHandler(this.labelImagesFound_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // richtextboxURLS
            // 
            this.richtextboxURLS.Location = new System.Drawing.Point(12, 38);
            this.richtextboxURLS.Name = "richtextboxURLS";
            this.richtextboxURLS.Size = new System.Drawing.Size(773, 368);
            this.richtextboxURLS.TabIndex = 5;
            this.richtextboxURLS.Text = "";
            // 
            // imageCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richtextboxURLS);
            this.Controls.Add(this.labelImagesFound);
            this.Controls.Add(this.saveImagesBTN);
            this.Controls.Add(this.extractURLBTN);
            this.Controls.Add(this.textBoxURL);
            this.Name = "imageCounter";
            this.Text = "ImageScraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button extractURLBTN;
        private System.Windows.Forms.Button saveImagesBTN;
        private System.Windows.Forms.Label labelImagesFound;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richtextboxURLS;
    }
}

