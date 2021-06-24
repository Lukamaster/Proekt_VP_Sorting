
namespace Proekt_VP_Sorting {
    partial class AddArray {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.tbArray = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Location = new System.Drawing.Point(18, 38);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(105, 17);
            this.radioRandom.TabIndex = 0;
            this.radioRandom.TabStop = true;
            this.radioRandom.Text = "Randomize Array";
            this.radioRandom.UseVisualStyleBackColor = true;
            this.radioRandom.CheckedChanged += new System.EventHandler(this.radioRandom_CheckedChanged);
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(18, 133);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(100, 17);
            this.radioCustom.TabIndex = 1;
            this.radioCustom.TabStop = true;
            this.radioCustom.Text = "Customize Array";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an array";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(23, 304);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(141, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(23, 89);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(179, 20);
            this.nudSize.TabIndex = 5;
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(26, 251);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(100, 20);
            this.tbDelay.TabIndex = 6;
            this.tbDelay.Text = "1";
            this.tbDelay.TextChanged += new System.EventHandler(this.tbDelay_TextChanged);
            // 
            // tbArray
            // 
            this.tbArray.Location = new System.Drawing.Point(26, 186);
            this.tbArray.Name = "tbArray";
            this.tbArray.Size = new System.Drawing.Size(316, 20);
            this.tbArray.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Array";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size of Array";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sort Delay";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 345);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbArray);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioCustom);
            this.Controls.Add(this.radioRandom);
            this.Name = "AddArray";
            this.Text = "AddArray";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.AddArray_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}