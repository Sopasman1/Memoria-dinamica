namespace Memoria_dinamica
{
    partial class Form1
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
            BtnAddNumber = new Button();
            button2 = new Button();
            listNumber = new ListBox();
            TxtNumber = new TextBox();
            SuspendLayout();
            // 
            // BtnAddNumber
            // 
            BtnAddNumber.Location = new Point(12, 12);
            BtnAddNumber.Name = "BtnAddNumber";
            BtnAddNumber.Size = new Size(119, 23);
            BtnAddNumber.TabIndex = 0;
            BtnAddNumber.Text = "Add Number";
            BtnAddNumber.UseVisualStyleBackColor = true;
            BtnAddNumber.Click += BtnAddNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 151);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 1;
            button2.Text = "Calculate Addition";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listNumber
            // 
            listNumber.FormattingEnabled = true;
            listNumber.ItemHeight = 15;
            listNumber.Location = new Point(154, 50);
            listNumber.Name = "listNumber";
            listNumber.Size = new Size(153, 124);
            listNumber.TabIndex = 2;
            // 
            // TxtNumber
            // 
            TxtNumber.Location = new Point(154, 12);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(153, 23);
            TxtNumber.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 204);
            Controls.Add(TxtNumber);
            Controls.Add(listNumber);
            Controls.Add(button2);
            Controls.Add(BtnAddNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddNumber;
        private Button button2;
        private ListBox listNumber;
        private TextBox TxtNumber;
    }
}
