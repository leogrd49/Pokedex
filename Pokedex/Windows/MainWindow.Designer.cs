namespace Pokedex
{
    partial class MainWindow
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
            Pokedex = new Label();
            ElementsManagers = new Button();
            PokemonsManagers = new Button();
            SuspendLayout();
            // 
            // Pokedex
            // 
            Pokedex.AutoSize = true;
            Pokedex.Font = new Font("Segoe UI", 40F);
            Pokedex.ForeColor = SystemColors.ButtonFace;
            Pokedex.Location = new Point(410, 18);
            Pokedex.Name = "Pokedex";
            Pokedex.Size = new Size(286, 89);
            Pokedex.TabIndex = 0;
            Pokedex.Text = "Pokedex";
            Pokedex.Click += label1_Click;
            // 
            // ElementsManagers
            // 
            ElementsManagers.BackColor = Color.IndianRed;
            ElementsManagers.ForeColor = SystemColors.ButtonHighlight;
            ElementsManagers.Location = new Point(64, 52);
            ElementsManagers.Name = "ElementsManagers";
            ElementsManagers.Size = new Size(206, 65);
            ElementsManagers.TabIndex = 1;
            ElementsManagers.Text = "Gestion des Elements";
            ElementsManagers.UseVisualStyleBackColor = false;
            // 
            // PokemonsManagers
            // 
            PokemonsManagers.BackColor = Color.IndianRed;
            PokemonsManagers.ForeColor = SystemColors.ButtonHighlight;
            PokemonsManagers.Location = new Point(813, 52);
            PokemonsManagers.Name = "PokemonsManagers";
            PokemonsManagers.Size = new Size(206, 65);
            PokemonsManagers.TabIndex = 2;
            PokemonsManagers.Text = "Gestion des Pokemons";
            PokemonsManagers.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1095, 620);
            Controls.Add(PokemonsManagers);
            Controls.Add(ElementsManagers);
            Controls.Add(Pokedex);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Pokedex;
        private Button ElementsManagers;
        private Button PokemonsManagers;
    }
}
