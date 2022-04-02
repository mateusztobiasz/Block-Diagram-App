
namespace Block_Diagram_App
{
    partial class BloqLab
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
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.rightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.languageGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.englishButton = new System.Windows.Forms.Button();
            this.polishButton = new System.Windows.Forms.Button();
            this.fileGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newSchemaButton = new System.Windows.Forms.Button();
            this.loadSchemaButton = new System.Windows.Forms.Button();
            this.saveSchemaButton = new System.Windows.Forms.Button();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.operationBlockButton = new System.Windows.Forms.RadioButton();
            this.decisionBlockButton = new System.Windows.Forms.RadioButton();
            this.layoutPanel.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.rightLayoutPanel.SuspendLayout();
            this.languageGroup.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.fileGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.editGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.layoutPanel.Controls.Add(this.scrollPanel, 0, 0);
            this.layoutPanel.Controls.Add(this.rightLayoutPanel, 1, 0);
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Size = new System.Drawing.Size(978, 685);
            this.layoutPanel.TabIndex = 0;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.Canvas);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(3, 3);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(722, 679);
            this.scrollPanel.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(716, 667);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            // 
            // rightLayoutPanel
            // 
            this.rightLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightLayoutPanel.ColumnCount = 1;
            this.rightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayoutPanel.Controls.Add(this.languageGroup, 0, 2);
            this.rightLayoutPanel.Controls.Add(this.fileGroup, 0, 0);
            this.rightLayoutPanel.Controls.Add(this.editGroupBox, 0, 1);
            this.rightLayoutPanel.Location = new System.Drawing.Point(731, 3);
            this.rightLayoutPanel.Name = "rightLayoutPanel";
            this.rightLayoutPanel.RowCount = 3;
            this.rightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.94559F));
            this.rightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.05041F));
            this.rightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.rightLayoutPanel.Size = new System.Drawing.Size(244, 679);
            this.rightLayoutPanel.TabIndex = 1;
            // 
            // languageGroup
            // 
            this.languageGroup.Controls.Add(this.tableLayoutPanel3);
            this.languageGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.languageGroup.Location = new System.Drawing.Point(3, 546);
            this.languageGroup.Name = "languageGroup";
            this.languageGroup.Size = new System.Drawing.Size(238, 130);
            this.languageGroup.TabIndex = 2;
            this.languageGroup.TabStop = false;
            this.languageGroup.Text = "Język";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.englishButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.polishButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(232, 104);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // englishButton
            // 
            this.englishButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.englishButton.Enabled = false;
            this.englishButton.Location = new System.Drawing.Point(3, 55);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(226, 46);
            this.englishButton.TabIndex = 1;
            this.englishButton.Text = "Angielski";
            this.englishButton.UseVisualStyleBackColor = true;
            // 
            // polishButton
            // 
            this.polishButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polishButton.Enabled = false;
            this.polishButton.Location = new System.Drawing.Point(3, 3);
            this.polishButton.Name = "polishButton";
            this.polishButton.Size = new System.Drawing.Size(226, 46);
            this.polishButton.TabIndex = 0;
            this.polishButton.Text = "Polski";
            this.polishButton.UseVisualStyleBackColor = true;
            // 
            // fileGroup
            // 
            this.fileGroup.Controls.Add(this.tableLayoutPanel1);
            this.fileGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileGroup.Location = new System.Drawing.Point(3, 3);
            this.fileGroup.Name = "fileGroup";
            this.fileGroup.Size = new System.Drawing.Size(238, 183);
            this.fileGroup.TabIndex = 0;
            this.fileGroup.TabStop = false;
            this.fileGroup.Text = "Plik";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.newSchemaButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadSchemaButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveSchemaButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // newSchemaButton
            // 
            this.newSchemaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSchemaButton.Location = new System.Drawing.Point(3, 3);
            this.newSchemaButton.Name = "newSchemaButton";
            this.newSchemaButton.Size = new System.Drawing.Size(226, 46);
            this.newSchemaButton.TabIndex = 0;
            this.newSchemaButton.Text = "Nowy Schemat";
            this.newSchemaButton.UseVisualStyleBackColor = true;
            this.newSchemaButton.Click += new System.EventHandler(this.newSchemaButton_Click);
            // 
            // loadSchemaButton
            // 
            this.loadSchemaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadSchemaButton.Enabled = false;
            this.loadSchemaButton.Location = new System.Drawing.Point(3, 107);
            this.loadSchemaButton.Name = "loadSchemaButton";
            this.loadSchemaButton.Size = new System.Drawing.Size(226, 47);
            this.loadSchemaButton.TabIndex = 2;
            this.loadSchemaButton.Text = "Wczytaj Schemat";
            this.loadSchemaButton.UseVisualStyleBackColor = true;
            // 
            // saveSchemaButton
            // 
            this.saveSchemaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveSchemaButton.Enabled = false;
            this.saveSchemaButton.Location = new System.Drawing.Point(3, 55);
            this.saveSchemaButton.Name = "saveSchemaButton";
            this.saveSchemaButton.Size = new System.Drawing.Size(226, 46);
            this.saveSchemaButton.TabIndex = 1;
            this.saveSchemaButton.Text = "Zapisz Schemat";
            this.saveSchemaButton.UseVisualStyleBackColor = true;
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.editGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGroupBox.Location = new System.Drawing.Point(3, 192);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(238, 347);
            this.editGroupBox.TabIndex = 1;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edycja";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.operationBlockButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.decisionBlockButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(232, 206);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // operationBlockButton
            // 
            this.operationBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.operationBlockButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operationBlockButton.Checked = true;
            this.operationBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.operationBlockButton.FlatAppearance.BorderSize = 7;
            this.operationBlockButton.Location = new System.Drawing.Point(3, 4);
            this.operationBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operationBlockButton.MaximumSize = new System.Drawing.Size(226, 544);
            this.operationBlockButton.Name = "operationBlockButton";
            this.operationBlockButton.Size = new System.Drawing.Size(226, 95);
            this.operationBlockButton.TabIndex = 0;
            this.operationBlockButton.TabStop = true;
            this.operationBlockButton.Text = "Blok Operacyjny";
            this.operationBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operationBlockButton.UseVisualStyleBackColor = true;
            this.operationBlockButton.CheckedChanged += new System.EventHandler(this.operationBlockButton_CheckedChanged);
            // 
            // decisionBlockButton
            // 
            this.decisionBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.decisionBlockButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decisionBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decisionBlockButton.FlatAppearance.BorderSize = 33;
            this.decisionBlockButton.Location = new System.Drawing.Point(3, 107);
            this.decisionBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decisionBlockButton.MaximumSize = new System.Drawing.Size(226, 546);
            this.decisionBlockButton.Name = "decisionBlockButton";
            this.decisionBlockButton.Size = new System.Drawing.Size(226, 95);
            this.decisionBlockButton.TabIndex = 1;
            this.decisionBlockButton.Text = "Blok Decyzyjny";
            this.decisionBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decisionBlockButton.UseVisualStyleBackColor = true;
            this.decisionBlockButton.CheckedChanged += new System.EventHandler(this.decisionBlockButton_CheckedChanged);
            // 
            // BloqLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 685);
            this.Controls.Add(this.layoutPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BloqLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloqLab";
            this.layoutPanel.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.rightLayoutPanel.ResumeLayout(false);
            this.languageGroup.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.fileGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.editGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.TableLayoutPanel rightLayoutPanel;
        private System.Windows.Forms.GroupBox fileGroup;
        private System.Windows.Forms.Button loadSchemaButton;
        private System.Windows.Forms.Button saveSchemaButton;
        private System.Windows.Forms.Button newSchemaButton;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.GroupBox languageGroup;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button polishButton;
        private System.Windows.Forms.RadioButton decisionBlockButton;
        private System.Windows.Forms.RadioButton operationBlockButton;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

