
namespace TrackingProgressInDevEducation.Forms
{
    partial class Menu
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
            this.CreateGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateGroup
            // 
            this.CreateGroup.Location = new System.Drawing.Point(349, 165);
            this.CreateGroup.Name = "CreateGroup";
            this.CreateGroup.Size = new System.Drawing.Size(89, 47);
            this.CreateGroup.TabIndex = 0;
            this.CreateGroup.Text = "Создать группу";
            this.CreateGroup.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateGroup);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateGroup;
    }
}