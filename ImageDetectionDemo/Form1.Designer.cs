namespace ImageDetectionDemo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.facedetected = new System.Windows.Forms.Label();
            this.blurrylabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contrastlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 533);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Face Detected";
            // 
            // facedetected
            // 
            this.facedetected.AutoSize = true;
            this.facedetected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facedetected.Location = new System.Drawing.Point(257, 533);
            this.facedetected.Name = "facedetected";
            this.facedetected.Padding = new System.Windows.Forms.Padding(5);
            this.facedetected.Size = new System.Drawing.Size(10, 35);
            this.facedetected.TabIndex = 2;
            // 
            // blurrylabel
            // 
            this.blurrylabel.AutoSize = true;
            this.blurrylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blurrylabel.Location = new System.Drawing.Point(257, 612);
            this.blurrylabel.Name = "blurrylabel";
            this.blurrylabel.Padding = new System.Windows.Forms.Padding(5);
            this.blurrylabel.Size = new System.Drawing.Size(10, 35);
            this.blurrylabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 612);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(78, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blurry";
            // 
            // contrastlabel
            // 
            this.contrastlabel.AutoSize = true;
            this.contrastlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastlabel.Location = new System.Drawing.Point(257, 689);
            this.contrastlabel.Name = "contrastlabel";
            this.contrastlabel.Padding = new System.Windows.Forms.Padding(5);
            this.contrastlabel.Size = new System.Drawing.Size(10, 35);
            this.contrastlabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 689);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(104, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contrast";
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(9, 11);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(640, 480);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 772);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.contrastlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blurrylabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.facedetected);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Face Detection Demo";
            this.Load += new System.EventHandler(this.formload);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blurrylabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contrastlabel;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox imageBox;
        public System.Windows.Forms.Label facedetected;
    }
}

