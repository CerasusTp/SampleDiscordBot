namespace SampleDiscordBot
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnBoot = new Button();
            label1 = new Label();
            LblStatus = new Label();
            SuspendLayout();
            // 
            // BtnBoot
            // 
            BtnBoot.Anchor = AnchorStyles.Top;
            BtnBoot.Location = new Point(13, 43);
            BtnBoot.Name = "BtnBoot";
            BtnBoot.Size = new Size(120, 60);
            BtnBoot.TabIndex = 1;
            BtnBoot.Text = "起動";
            BtnBoot.UseVisualStyleBackColor = true;
            BtnBoot.Click += BtnBoot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 2;
            label1.Text = "ステータス";
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(86, 9);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(58, 21);
            LblStatus.TabIndex = 3;
            LblStatus.Text = "起動中";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(LblStatus);
            Controls.Add(label1);
            Controls.Add(BtnBoot);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "起動画面";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnBoot;
        private Label label1;
        private Label LblStatus;
    }
}
