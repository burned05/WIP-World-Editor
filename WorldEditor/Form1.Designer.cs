namespace WorldEditor
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label4 = new System.Windows.Forms.Label();
            this.PlacedObjectListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ObjectListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLayerButton = new System.Windows.Forms.Button();
            this.LayerListBox = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.World_Panel = new WorldEditor.Graphics_Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Label4);
            this.splitContainer1.Panel1.Controls.Add(this.PlacedObjectListBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ObjectListBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.AddLayerButton);
            this.splitContainer1.Panel1.Controls.Add(this.LayerListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 741);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 210);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 17);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Placed Objects";
            // 
            // PlacedObjectListBox
            // 
            this.PlacedObjectListBox.FormattingEnabled = true;
            this.PlacedObjectListBox.ItemHeight = 16;
            this.PlacedObjectListBox.Location = new System.Drawing.Point(13, 230);
            this.PlacedObjectListBox.Name = "PlacedObjectListBox";
            this.PlacedObjectListBox.Size = new System.Drawing.Size(216, 276);
            this.PlacedObjectListBox.TabIndex = 5;
            this.PlacedObjectListBox.SelectedIndexChanged += new System.EventHandler(this.PlacedObjectListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Placeable Objects";
            // 
            // ObjectListBox
            // 
            this.ObjectListBox.FormattingEnabled = true;
            this.ObjectListBox.ItemHeight = 16;
            this.ObjectListBox.Location = new System.Drawing.Point(12, 29);
            this.ObjectListBox.Name = "ObjectListBox";
            this.ObjectListBox.Size = new System.Drawing.Size(217, 164);
            this.ObjectListBox.TabIndex = 3;
            this.ObjectListBox.SelectedIndexChanged += new System.EventHandler(this.ObjectListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Layers";
            // 
            // AddLayerButton
            // 
            this.AddLayerButton.Location = new System.Drawing.Point(13, 519);
            this.AddLayerButton.Name = "AddLayerButton";
            this.AddLayerButton.Size = new System.Drawing.Size(81, 24);
            this.AddLayerButton.TabIndex = 1;
            this.AddLayerButton.Text = "Add Layer";
            this.AddLayerButton.UseVisualStyleBackColor = true;
            this.AddLayerButton.Click += new System.EventHandler(this.AddLayerButton_Click);
            // 
            // LayerListBox
            // 
            this.LayerListBox.FormattingEnabled = true;
            this.LayerListBox.ItemHeight = 16;
            this.LayerListBox.Location = new System.Drawing.Point(12, 549);
            this.LayerListBox.Name = "LayerListBox";
            this.LayerListBox.Size = new System.Drawing.Size(227, 180);
            this.LayerListBox.TabIndex = 0;
            this.LayerListBox.SelectedIndexChanged += new System.EventHandler(this.LayerListBox_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.World_Panel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(788, 741);
            this.splitContainer2.SplitterDistance = 550;
            this.splitContainer2.TabIndex = 0;
            // 
            // World_Panel
            // 
            this.World_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.World_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.World_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.World_Panel.Location = new System.Drawing.Point(0, 0);
            this.World_Panel.Name = "World_Panel";
            this.World_Panel.Size = new System.Drawing.Size(788, 550);
            this.World_Panel.TabIndex = 0;
            this.World_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.World_Panel_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Object Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 741);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private WorldEditor.Graphics_Panel World_Panel;
        private System.Windows.Forms.ListBox LayerListBox;
        private System.Windows.Forms.Button AddLayerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ObjectListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ListBox PlacedObjectListBox;
    }
}

