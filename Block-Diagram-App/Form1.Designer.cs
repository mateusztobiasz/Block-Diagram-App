
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
            this.textBoxBlock = new System.Windows.Forms.TextBox();
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
            resources.ApplyResources(this.layoutPanel, "layoutPanel");
            this.layoutPanel.Controls.Add(this.editGroupBox, 1, 1);
            this.layoutPanel.Controls.Add(this.PlikGroupBox, 1, 0);
            this.layoutPanel.Controls.Add(this.JezykGroupBox, 1, 2);
            this.layoutPanel.Controls.Add(this.scrollPanel, 0, 0);
            this.layoutPanel.Name = "layoutPanel";
            // 
            // editGroupBox
            // 
            resources.ApplyResources(this.editGroupBox, "editGroupBox");
            this.editGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.textBoxBlock, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // textBoxBlock
            // 
            resources.ApplyResources(this.textBoxBlock, "textBoxBlock");
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.TextChanged += new System.EventHandler(this.textBoxBlock_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.connectBlockButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.operationBlockButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.startBlockButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.endBlockButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.decisionBlockButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.deleteBlockButton, 2, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // connectBlockButton
            // 
            resources.ApplyResources(this.connectBlockButton, "connectBlockButton");
            this.connectBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.connectBlockButton.FlatAppearance.BorderSize = 2;
            this.connectBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.connectBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.connectBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.connectBlockButton.Name = "connectBlockButton";
            this.connectBlockButton.UseVisualStyleBackColor = true;
            // 
            // operationBlockButton
            // 
            resources.ApplyResources(this.operationBlockButton, "operationBlockButton");
            this.operationBlockButton.Checked = true;
            this.operationBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.operationBlockButton.FlatAppearance.BorderSize = 2;
            this.operationBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.operationBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.operationBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.operationBlockButton.Name = "operationBlockButton";
            this.operationBlockButton.TabStop = true;
            this.operationBlockButton.UseVisualStyleBackColor = true;
            this.operationBlockButton.CheckedChanged += new System.EventHandler(this.operationBlockButton_CheckedChanged);
            // 
            // startBlockButton
            // 
            resources.ApplyResources(this.startBlockButton, "startBlockButton");
            this.startBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startBlockButton.FlatAppearance.BorderSize = 2;
            this.startBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startBlockButton.Name = "startBlockButton";
            this.startBlockButton.UseVisualStyleBackColor = true;
            this.startBlockButton.CheckedChanged += new System.EventHandler(this.startBlockButton_CheckedChanged);
            // 
            // endBlockButton
            // 
            resources.ApplyResources(this.endBlockButton, "endBlockButton");
            this.endBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.endBlockButton.FlatAppearance.BorderSize = 2;
            this.endBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.endBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.endBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.endBlockButton.Name = "endBlockButton";
            this.endBlockButton.UseVisualStyleBackColor = true;
            this.endBlockButton.CheckedChanged += new System.EventHandler(this.endBlockButton_CheckedChanged);
            // 
            // decisionBlockButton
            // 
            resources.ApplyResources(this.decisionBlockButton, "decisionBlockButton");
            this.decisionBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decisionBlockButton.FlatAppearance.BorderSize = 2;
            this.decisionBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.decisionBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.decisionBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.decisionBlockButton.Name = "decisionBlockButton";
            this.decisionBlockButton.UseVisualStyleBackColor = true;
            this.decisionBlockButton.CheckedChanged += new System.EventHandler(this.decisionBlockButton_CheckedChanged_1);
            // 
            // deleteBlockButton
            // 
            resources.ApplyResources(this.deleteBlockButton, "deleteBlockButton");
            this.deleteBlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBlockButton.FlatAppearance.BorderSize = 2;
            this.deleteBlockButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteBlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteBlockButton.Name = "deleteBlockButton";
            this.deleteBlockButton.UseVisualStyleBackColor = true;
            this.deleteBlockButton.CheckedChanged += new System.EventHandler(this.deleteBlockButton_CheckedChanged);
            // 
            // PlikGroupBox
            // 
            resources.ApplyResources(this.PlikGroupBox, "PlikGroupBox");
            this.PlikGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.PlikGroupBox.Name = "PlikGroupBox";
            this.PlikGroupBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.loadSchemaButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newSchemaButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveSchemaButton, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // loadSchemaButton
            // 
            resources.ApplyResources(this.loadSchemaButton, "loadSchemaButton");
            this.loadSchemaButton.Name = "loadSchemaButton";
            this.loadSchemaButton.UseVisualStyleBackColor = true;
            this.loadSchemaButton.Click += new System.EventHandler(this.loadSchemaButton_Click);
            // 
            // newSchemaButton
            // 
            resources.ApplyResources(this.newSchemaButton, "newSchemaButton");
            this.newSchemaButton.Name = "newSchemaButton";
            this.newSchemaButton.UseVisualStyleBackColor = true;
            this.newSchemaButton.Click += new System.EventHandler(this.newSchemaButton_Click);
            // 
            // saveSchemaButton
            // 
            resources.ApplyResources(this.saveSchemaButton, "saveSchemaButton");
            this.saveSchemaButton.Name = "saveSchemaButton";
            this.saveSchemaButton.UseVisualStyleBackColor = true;
            this.saveSchemaButton.Click += new System.EventHandler(this.saveSchemaButton_Click);
            // 
            // JezykGroupBox
            // 
            resources.ApplyResources(this.JezykGroupBox, "JezykGroupBox");
            this.JezykGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.JezykGroupBox.Name = "JezykGroupBox";
            this.JezykGroupBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.englishButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.polishButton, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // englishButton
            // 
            resources.ApplyResources(this.englishButton, "englishButton");
            this.englishButton.Name = "englishButton";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // polishButton
            // 
            resources.ApplyResources(this.polishButton, "polishButton");
            this.polishButton.Name = "polishButton";
            this.polishButton.UseVisualStyleBackColor = true;
            this.polishButton.Click += new System.EventHandler(this.polishButton_Click_1);
            // 
            // scrollPanel
            // 
            resources.ApplyResources(this.scrollPanel, "scrollPanel");
            this.scrollPanel.Controls.Add(this.Canvas);
            this.scrollPanel.Name = "scrollPanel";
            this.layoutPanel.SetRowSpan(this.scrollPanel, 3);
            // 
            // Canvas
            // 
            resources.ApplyResources(this.Canvas, "Canvas");
            this.Canvas.Name = "Canvas";
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            // 
            // BloqLab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutPanel);
            this.Name = "BloqLab";
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
        private System.Windows.Forms.RadioButton operationBlockButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton decisionBlockButton;
        private System.Windows.Forms.RadioButton connectBlockButton;
        private System.Windows.Forms.RadioButton deleteBlockButton;
        private System.Windows.Forms.RadioButton endBlockButton;
        private System.Windows.Forms.RadioButton startBlockButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.GroupBox PlikGroupBox;
        private System.Windows.Forms.GroupBox JezykGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button polishButton;
    }
}

