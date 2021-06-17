
namespace HandBookApp
{
    partial class ChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddOperator = new System.Windows.Forms.Button();
            this.btnAddRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(936, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnAddOperator
            // 
            this.btnAddOperator.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOperator.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddOperator.FlatAppearance.BorderSize = 2;
            this.btnAddOperator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOperator.Font = new System.Drawing.Font("Stencil Std", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOperator.ForeColor = System.Drawing.Color.Purple;
            this.btnAddOperator.Location = new System.Drawing.Point(328, 199);
            this.btnAddOperator.Name = "btnAddOperator";
            this.btnAddOperator.Size = new System.Drawing.Size(334, 56);
            this.btnAddOperator.TabIndex = 4;
            this.btnAddOperator.Text = "Add Operator";
            this.btnAddOperator.UseVisualStyleBackColor = false;
            // 
            // btnAddRec
            // 
            this.btnAddRec.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRec.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddRec.FlatAppearance.BorderSize = 2;
            this.btnAddRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRec.Font = new System.Drawing.Font("Stencil Std", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRec.ForeColor = System.Drawing.Color.Purple;
            this.btnAddRec.Location = new System.Drawing.Point(328, 344);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(334, 56);
            this.btnAddRec.TabIndex = 5;
            this.btnAddRec.Text = "Add Record";
            this.btnAddRec.UseVisualStyleBackColor = false;
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnAddRec);
            this.Controls.Add(this.btnAddOperator);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddOperator;
        private System.Windows.Forms.Button btnAddRec;
    }
}