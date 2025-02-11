namespace CW
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
            this.components = new System.ComponentModel.Container();
            this.OG = new Emgu.CV.UI.ImageBox();
            this.Res = new Emgu.CV.UI.ImageBox();
            this.Load = new System.Windows.Forms.Button();
            this.Brightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contrast = new System.Windows.Forms.TrackBar();
            this.AquarelleFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BlurBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OG
            // 
            this.OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OG.Location = new System.Drawing.Point(12, 12);
            this.OG.Name = "OG";
            this.OG.Size = new System.Drawing.Size(500, 500);
            this.OG.TabIndex = 2;
            this.OG.TabStop = false;
            // 
            // Res
            // 
            this.Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Res.Location = new System.Drawing.Point(783, 12);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(500, 500);
            this.Res.TabIndex = 3;
            this.Res.TabStop = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(586, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(125, 50);
            this.Load.TabIndex = 4;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Brightness
            // 
            this.Brightness.Location = new System.Drawing.Point(537, 246);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(218, 56);
            this.Brightness.TabIndex = 5;
            this.Brightness.Scroll += new System.EventHandler(this.Brightness_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brightness:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contrast:";
            // 
            // Contrast
            // 
            this.Contrast.Location = new System.Drawing.Point(540, 333);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(218, 56);
            this.Contrast.TabIndex = 7;
            this.Contrast.Value = 5;
            this.Contrast.Scroll += new System.EventHandler(this.Contrast_Scroll);
            // 
            // AquarelleFilter
            // 
            this.AquarelleFilter.Location = new System.Drawing.Point(586, 109);
            this.AquarelleFilter.Name = "AquarelleFilter";
            this.AquarelleFilter.Size = new System.Drawing.Size(125, 50);
            this.AquarelleFilter.TabIndex = 10;
            this.AquarelleFilter.Text = "Add Mask";
            this.AquarelleFilter.UseVisualStyleBackColor = true;
            this.AquarelleFilter.Click += new System.EventHandler(this.AquarelleFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aquarelle Filter:";
            // 
            // BlurBar
            // 
            this.BlurBar.Location = new System.Drawing.Point(537, 423);
            this.BlurBar.Name = "BlurBar";
            this.BlurBar.Size = new System.Drawing.Size(218, 56);
            this.BlurBar.TabIndex = 12;
            this.BlurBar.Scroll += new System.EventHandler(this.BlurBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Blur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(555, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "-----Adjust your Picture-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BlurBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AquarelleFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.OG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox OG;
        private Emgu.CV.UI.ImageBox Res;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TrackBar Brightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Contrast;
        private System.Windows.Forms.Button AquarelleFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar BlurBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

