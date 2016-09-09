namespace Lesson1B
{
    partial class StartForm
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(81, 218);
            this.ClickMeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(112, 36);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "Click me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            this.ClickMeButton.MouseEnter += new System.EventHandler(this.ClickMeButton_MouseEnter);
            this.ClickMeButton.MouseLeave += new System.EventHandler(this.ClickMeButton_MouseLeave);
            this.ClickMeButton.MouseHover += new System.EventHandler(this.ClickMeButton_MouseHover);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(177, 64);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 25);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Click += new System.EventHandler(this.MessageLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(248, 218);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 36);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 331);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.Text = "Start Form";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

