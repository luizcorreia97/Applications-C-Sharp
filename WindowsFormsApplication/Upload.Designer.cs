namespace WindowsFormsApplication
{
    partial class Upload
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnLoading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpload.Location = new System.Drawing.Point(44, 64);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(113, 38);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(44, 149);
            this.progressBar.MarqueeAnimationSpeed = 1000;
            this.progressBar.Maximum = 100000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(349, 34);
            this.progressBar.TabIndex = 2;
            // 
            // btnLoading
            // 
            this.btnLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoading.Location = new System.Drawing.Point(280, 64);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(113, 38);
            this.btnLoading.TabIndex = 3;
            this.btnLoading.Text = "Loading";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Click += new System.EventHandler(this.button1_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 228);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnUpload);
            this.Name = "Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnLoading;
    }
}