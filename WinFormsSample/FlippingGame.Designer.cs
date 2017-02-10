namespace WinFormsSample {
    partial class FlippingGame {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bankrollLabel = new System.Windows.Forms.Label();
            this.wagerBox = new System.Windows.Forms.NumericUpDown();
            this.guessHeadsRadio = new System.Windows.Forms.RadioButton();
            this.guessTailsRadio = new System.Windows.Forms.RadioButton();
            this.flipButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.resultLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flippingBox = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wagerBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.resultLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flippingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wager:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Guess:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bankroll:";
            // 
            // bankrollLabel
            // 
            this.bankrollLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bankrollLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.bankrollLabel, 2);
            this.bankrollLabel.Location = new System.Drawing.Point(68, 3);
            this.bankrollLabel.Margin = new System.Windows.Forms.Padding(3);
            this.bankrollLabel.Name = "bankrollLabel";
            this.bankrollLabel.Size = new System.Drawing.Size(11, 12);
            this.bankrollLabel.TabIndex = 5;
            this.bankrollLabel.Text = "?";
            // 
            // wagerBox
            // 
            this.wagerBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.SetColumnSpan(this.wagerBox, 2);
            this.wagerBox.Location = new System.Drawing.Point(68, 21);
            this.wagerBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wagerBox.Name = "wagerBox";
            this.wagerBox.Size = new System.Drawing.Size(75, 21);
            this.wagerBox.TabIndex = 6;
            this.wagerBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guessHeadsRadio
            // 
            this.guessHeadsRadio.AutoSize = true;
            this.guessHeadsRadio.Checked = true;
            this.guessHeadsRadio.Location = new System.Drawing.Point(68, 48);
            this.guessHeadsRadio.Name = "guessHeadsRadio";
            this.guessHeadsRadio.Size = new System.Drawing.Size(53, 16);
            this.guessHeadsRadio.TabIndex = 7;
            this.guessHeadsRadio.TabStop = true;
            this.guessHeadsRadio.Text = "Heads";
            this.guessHeadsRadio.UseVisualStyleBackColor = true;
            // 
            // guessTailsRadio
            // 
            this.guessTailsRadio.AutoSize = true;
            this.guessTailsRadio.Location = new System.Drawing.Point(127, 48);
            this.guessTailsRadio.Name = "guessTailsRadio";
            this.guessTailsRadio.Size = new System.Drawing.Size(53, 16);
            this.guessTailsRadio.TabIndex = 7;
            this.guessTailsRadio.Text = "Tails";
            this.guessTailsRadio.UseVisualStyleBackColor = true;
            // 
            // flipButton
            // 
            this.flipButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flipButton.Location = new System.Drawing.Point(192, 26);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(59, 21);
            this.flipButton.TabIndex = 2;
            this.flipButton.Text = "Flip!";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultLayout, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 132);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.flipButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.guessHeadsRadio, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.guessTailsRadio, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.bankrollLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.wagerBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 67);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // resultLayout
            // 
            this.resultLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLayout.AutoSize = true;
            this.resultLayout.ColumnCount = 2;
            this.resultLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultLayout.Controls.Add(this.flippingBox, 0, 0);
            this.resultLayout.Controls.Add(this.resultLabel, 1, 0);
            this.resultLayout.Location = new System.Drawing.Point(90, 82);
            this.resultLayout.Name = "resultLayout";
            this.resultLayout.RowCount = 1;
            this.resultLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultLayout.Size = new System.Drawing.Size(79, 47);
            this.resultLayout.TabIndex = 1;
            // 
            // flippingBox
            // 
            this.flippingBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flippingBox.Image = global::WinFormsSample.Properties.Resources.ajax_loader;
            this.flippingBox.Location = new System.Drawing.Point(3, 8);
            this.flippingBox.Name = "flippingBox";
            this.flippingBox.Size = new System.Drawing.Size(32, 30);
            this.flippingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.flippingBox.TabIndex = 9;
            this.flippingBox.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(41, 5);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 37);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "?";
            // 
            // FlippingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(288, 144);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlippingGame";
            this.Text = "Coin Flipping Game";
            this.Load += new System.EventHandler(this.FlippingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wagerBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.resultLayout.ResumeLayout(false);
            this.resultLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flippingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bankrollLabel;
        private System.Windows.Forms.NumericUpDown wagerBox;
        private System.Windows.Forms.RadioButton guessHeadsRadio;
        private System.Windows.Forms.RadioButton guessTailsRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox flippingBox;
        private System.Windows.Forms.TableLayoutPanel resultLayout;
    }
}

