namespace GooseGame.WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtDice1 = new System.Windows.Forms.TextBox();
            this.txtDice2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(25, 27);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(144, 34);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Aggiungi Giocatore";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(248, 33);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(167, 22);
            this.txtPlayer.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(-2, 136);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(570, 182);
            this.txtLog.TabIndex = 2;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(25, 69);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(144, 34);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Muovi Giocatore";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtDice1
            // 
            this.txtDice1.Location = new System.Drawing.Point(248, 69);
            this.txtDice1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDice1.Name = "txtDice1";
            this.txtDice1.Size = new System.Drawing.Size(41, 22);
            this.txtDice1.TabIndex = 1;
            // 
            // txtDice2
            // 
            this.txtDice2.Location = new System.Drawing.Point(297, 69);
            this.txtDice2.Margin = new System.Windows.Forms.Padding(4);
            this.txtDice2.Name = "txtDice2";
            this.txtDice2.Size = new System.Drawing.Size(41, 22);
            this.txtDice2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 321);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtDice2);
            this.Controls.Add(this.txtDice1);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtDice1;
        private System.Windows.Forms.TextBox txtDice2;
    }
}

