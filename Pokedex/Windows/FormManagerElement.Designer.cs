namespace Pokedex.Windows
{
    partial class FormManagerElement
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
            label1 = new Label();
            listBoxElements = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            buttonAddElement = new Button();
            buttonEditElement = new Button();
            buttonDeleteElement = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(309, 34);
            label1.Name = "label1";
            label1.Size = new Size(911, 100);
            label1.TabIndex = 0;
            label1.Text = "Gestionnaire des Elements";
            // 
            // listBoxElements
            // 
            listBoxElements.FormattingEnabled = true;
            listBoxElements.Location = new Point(38, 34);
            listBoxElements.Name = "listBoxElements";
            listBoxElements.Size = new Size(245, 404);
            listBoxElements.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(357, 150);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Nom :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 3;
            // 
            // buttonAddElement
            // 
            buttonAddElement.Location = new Point(38, 457);
            buttonAddElement.Name = "buttonAddElement";
            buttonAddElement.Size = new Size(245, 52);
            buttonAddElement.TabIndex = 4;
            buttonAddElement.Text = "Ajouter";
            buttonAddElement.UseVisualStyleBackColor = true;
            // 
            // buttonEditElement
            // 
            buttonEditElement.Location = new Point(357, 191);
            buttonEditElement.Name = "buttonEditElement";
            buttonEditElement.Size = new Size(131, 43);
            buttonEditElement.TabIndex = 5;
            buttonEditElement.Text = "Modifier";
            buttonEditElement.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteElement
            // 
            buttonDeleteElement.Location = new Point(505, 191);
            buttonDeleteElement.Name = "buttonDeleteElement";
            buttonDeleteElement.Size = new Size(131, 43);
            buttonDeleteElement.TabIndex = 6;
            buttonDeleteElement.Text = "Supprimer";
            buttonDeleteElement.UseVisualStyleBackColor = true;
            buttonDeleteElement.Click += button3_Click;
            // 
            // FormManagerElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1295, 565);
            Controls.Add(buttonDeleteElement);
            Controls.Add(buttonEditElement);
            Controls.Add(buttonAddElement);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listBoxElements);
            Controls.Add(label1);
            Name = "FormManagerElement";
            Text = "FormManagerElement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxElements;
        private Label label2;
        private TextBox textBox1;
        private Button buttonAddElement;
        private Button buttonEditElement;
        private Button buttonDeleteElement;
    }
}