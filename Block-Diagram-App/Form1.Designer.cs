
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloqLab));
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.connectBlockButton = new System.Windows.Forms.RadioButton();
            this.operationBlockButton = new System.Windows.Forms.RadioButton();
            this.startBlockButton = new System.Windows.Forms.RadioButton();
            this.endBlockButton = new System.Windows.Forms.RadioButton();
            this.decisionBlockButton = new System.Windows.Forms.RadioButton();
            this.deleteBlockButton = new System.Windows.Forms.RadioButton();
            this.PlikGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loadSchemaButton = new System.Windows.Forms.Button();
            this.newSchemaButton = new System.Windows.Forms.Button();
            this.saveSchemaButton = new System.Windows.Forms.Button();
            this.JezykGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.englishButton = new System.Windows.Forms.Button();
            this.polishButton = new System.Windows.Forms.Button();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.layoutPanel.SuspendLayout();
            this.editGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.PlikGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.JezykGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
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
            this.layoutPanel.Controls.Add(this.editGroupBox, 1, 1);
            this.layoutPanel.Controls.Add(this.PlikGroupBox, 1, 0);
            this.layoutPanel.Controls.Add(this.JezykGroupBox, 1, 2);
            this.layoutPanel.Controls.Add(this.scrollPanel, 0, 0);
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(978, 685);
            this.layoutPanel.TabIndex = 0;
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.editGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGroupBox.Location = new System.Drawing.Point(731, 174);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(244, 370);
            this.editGroupBox.TabIndex = 1;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edycja";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(238, 344);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 202);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 139);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tekst zaznaczonego bloku: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.connectBlockButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.operationBlockButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.startBlockButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.endBlockButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.decisionBlockButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.deleteBlockButton, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(232, 159);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // connectBlockButton
            // 
            this.connectBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.connectBlockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectBlockButton.BackgroundImage")));
            this.connectBlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connectBlockButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.connectBlockButton.FlatAppearance.BorderSize = 2;
            this.connectBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.connectBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.connectBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.connectBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBlockButton.Location = new System.Drawing.Point(157, 4);
            this.connectBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectBlockButton.MaximumSize = new System.Drawing.Size(226, 546);
            this.connectBlockButton.Name = "connectBlockButton";
            this.connectBlockButton.Size = new System.Drawing.Size(72, 71);
            this.connectBlockButton.TabIndex = 6;
            this.connectBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectBlockButton.UseVisualStyleBackColor = true;
            // 
            // operationBlockButton
            // 
            this.operationBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.operationBlockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("operationBlockButton.BackgroundImage")));
            this.operationBlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.operationBlockButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.operationBlockButton.Checked = true;
            this.operationBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.operationBlockButton.FlatAppearance.BorderSize = 2;
            this.operationBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.operationBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.operationBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.operationBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationBlockButton.Image = ((System.Drawing.Image)(resources.GetObject("operationBlockButton.Image")));
            this.operationBlockButton.Location = new System.Drawing.Point(80, 4);
            this.operationBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operationBlockButton.MaximumSize = new System.Drawing.Size(226, 544);
            this.operationBlockButton.Name = "operationBlockButton";
            this.operationBlockButton.Size = new System.Drawing.Size(71, 71);
            this.operationBlockButton.TabIndex = 0;
            this.operationBlockButton.TabStop = true;
            this.operationBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operationBlockButton.UseVisualStyleBackColor = true;
            this.operationBlockButton.CheckedChanged += new System.EventHandler(this.operationBlockButton_CheckedChanged);
            // 
            // startBlockButton
            // 
            this.startBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.startBlockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startBlockButton.BackgroundImage")));
            this.startBlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startBlockButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startBlockButton.FlatAppearance.BorderSize = 2;
            this.startBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBlockButton.Location = new System.Drawing.Point(3, 4);
            this.startBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBlockButton.MaximumSize = new System.Drawing.Size(226, 546);
            this.startBlockButton.Name = "startBlockButton";
            this.startBlockButton.Size = new System.Drawing.Size(71, 71);
            this.startBlockButton.TabIndex = 3;
            this.startBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBlockButton.UseVisualStyleBackColor = true;
            this.startBlockButton.CheckedChanged += new System.EventHandler(this.startBlockButton_CheckedChanged);
            // 
            // endBlockButton
            // 
            this.endBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.endBlockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("endBlockButton.BackgroundImage")));
            this.endBlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.endBlockButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.endBlockButton.FlatAppearance.BorderSize = 2;
            this.endBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.endBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.endBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.endBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBlockButton.Location = new System.Drawing.Point(3, 83);
            this.endBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endBlockButton.MaximumSize = new System.Drawing.Size(226, 546);
            this.endBlockButton.Name = "endBlockButton";
            this.endBlockButton.Size = new System.Drawing.Size(71, 72);
            this.endBlockButton.TabIndex = 4;
            this.endBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endBlockButton.UseVisualStyleBackColor = true;
            this.endBlockButton.CheckedChanged += new System.EventHandler(this.endBlockButton_CheckedChanged);
            // 
            // decisionBlockButton
            // 
            this.decisionBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.decisionBlockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("decisionBlockButton.BackgroundImage")));
            this.decisionBlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.decisionBlockButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decisionBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decisionBlockButton.FlatAppearance.BorderSize = 2;
            this.decisionBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.decisionBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.decisionBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.decisionBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decisionBlockButton.Location = new System.Drawing.Point(80, 83);
            this.decisionBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decisionBlockButton.MaximumSize = new System.Drawing.Size(226, 546);
            this.decisionBlockButton.Name = "decisionBlockButton";
            this.decisionBlockButton.Size = new System.Drawing.Size(71, 72);
            this.decisionBlockButton.TabIndex = 2;
            this.decisionBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decisionBlockButton.UseVisualStyleBackColor = true;
            this.decisionBlockButton.CheckedChanged += new System.EventHandler(this.decisionBlockButton_CheckedChanged_1);
            // 
            // deleteBlockButton
            // 
            this.deleteBlockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.deleteBlockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBlockButton.BackgroundImage")));
            this.deleteBlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteBlockButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBlockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBlockButton.FlatAppearance.BorderSize = 2;
            this.deleteBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBlockButton.Location = new System.Drawing.Point(157, 83);
            this.deleteBlockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBlockButton.MaximumSize = new System.Drawing.Size(226, 546);
            this.deleteBlockButton.Name = "deleteBlockButton";
            this.deleteBlockButton.Size = new System.Drawing.Size(72, 72);
            this.deleteBlockButton.TabIndex = 5;
            this.deleteBlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBlockButton.UseVisualStyleBackColor = true;
            this.deleteBlockButton.CheckedChanged += new System.EventHandler(this.deleteBlockButton_CheckedChanged);
            // 
            // PlikGroupBox
            // 
            this.PlikGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.PlikGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlikGroupBox.Location = new System.Drawing.Point(731, 3);
            this.PlikGroupBox.Name = "PlikGroupBox";
            this.PlikGroupBox.Size = new System.Drawing.Size(244, 165);
            this.PlikGroupBox.TabIndex = 2;
            this.PlikGroupBox.TabStop = false;
            this.PlikGroupBox.Text = "Plik";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.loadSchemaButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newSchemaButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveSchemaButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 139);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // loadSchemaButton
            // 
            this.loadSchemaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadSchemaButton.Enabled = false;
            this.loadSchemaButton.Location = new System.Drawing.Point(3, 95);
            this.loadSchemaButton.Name = "loadSchemaButton";
            this.loadSchemaButton.Size = new System.Drawing.Size(232, 41);
            this.loadSchemaButton.TabIndex = 2;
            this.loadSchemaButton.Text = "Wczytaj Schemat";
            this.loadSchemaButton.UseVisualStyleBackColor = true;
            // 
            // newSchemaButton
            // 
            this.newSchemaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSchemaButton.Location = new System.Drawing.Point(3, 3);
            this.newSchemaButton.Name = "newSchemaButton";
            this.newSchemaButton.Size = new System.Drawing.Size(232, 40);
            this.newSchemaButton.TabIndex = 0;
            this.newSchemaButton.Text = "Nowy Schemat";
            this.newSchemaButton.UseVisualStyleBackColor = true;
            this.newSchemaButton.Click += new System.EventHandler(this.newSchemaButton_Click);
            // 
            // saveSchemaButton
            // 
            this.saveSchemaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveSchemaButton.Enabled = false;
            this.saveSchemaButton.Location = new System.Drawing.Point(3, 49);
            this.saveSchemaButton.Name = "saveSchemaButton";
            this.saveSchemaButton.Size = new System.Drawing.Size(232, 40);
            this.saveSchemaButton.TabIndex = 1;
            this.saveSchemaButton.Text = "Zapisz Schemat";
            this.saveSchemaButton.UseVisualStyleBackColor = true;
            // 
            // JezykGroupBox
            // 
            this.JezykGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.JezykGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JezykGroupBox.Location = new System.Drawing.Point(731, 550);
            this.JezykGroupBox.Name = "JezykGroupBox";
            this.JezykGroupBox.Size = new System.Drawing.Size(244, 132);
            this.JezykGroupBox.TabIndex = 3;
            this.JezykGroupBox.TabStop = false;
            this.JezykGroupBox.Text = "Język";
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 106);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // englishButton
            // 
            this.englishButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.englishButton.Enabled = false;
            this.englishButton.Location = new System.Drawing.Point(3, 56);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(232, 47);
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
            this.polishButton.Size = new System.Drawing.Size(232, 47);
            this.polishButton.TabIndex = 0;
            this.polishButton.Text = "Polski";
            this.polishButton.UseVisualStyleBackColor = true;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.Canvas);
            this.scrollPanel.Location = new System.Drawing.Point(3, 3);
            this.scrollPanel.Name = "scrollPanel";
            this.layoutPanel.SetRowSpan(this.scrollPanel, 3);
            this.scrollPanel.Size = new System.Drawing.Size(722, 679);
            this.scrollPanel.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(716, 670);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
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
            this.editGroupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.PlikGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.JezykGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Button loadSchemaButton;
        private System.Windows.Forms.Button saveSchemaButton;
        private System.Windows.Forms.Button newSchemaButton;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button polishButton;
        private System.Windows.Forms.RadioButton operationBlockButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton decisionBlockButton;
        private System.Windows.Forms.RadioButton connectBlockButton;
        private System.Windows.Forms.RadioButton deleteBlockButton;
        private System.Windows.Forms.RadioButton endBlockButton;
        private System.Windows.Forms.RadioButton startBlockButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox PlikGroupBox;
        private System.Windows.Forms.GroupBox JezykGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

