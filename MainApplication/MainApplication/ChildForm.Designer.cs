namespace MainApplication
{
    partial class ChildForm
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
            MainApplication.Item item1 = new MainApplication.Item();
            MainApplication.Item item2 = new MainApplication.Item();
            this.SuspendLayout();
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            item1.Description = "This is a test.";
            item1.Text = "SolveEverything.exe";
            item1.Value = 12;
            item2.Description = "This is a test.";
            item2.Text = "test";
            item2.Value = 1;
            this.Items.Add(item1);
            this.Items.Add(item2);
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.ResumeLayout(false);

        }

        #endregion
    }
}