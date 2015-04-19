/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* This code is generated by a tool and is provided "as is", without warranty of any kind,
* express or implied, including but not limited to the warranties of merchantability,
* fitness for a particular purpose and non-infringement.
* In no event shall the authors or copyright holders be liable for any claim, damages or
* other liability, whether in an action of contract, tort or otherwise, arising from,
* out of or in connection with the software or the use or other dealings in the software.
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* */

namespace MureOcart
{
	partial class frmoc_category_description
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmoc_category_description));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.oc_category_descriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.category_idLabel = new System.Windows.Forms.Label();
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.language_idLabel = new System.Windows.Forms.Label();
            this.language_idTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.meta_descriptionLabel = new System.Windows.Forms.Label();
            this.meta_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.meta_keywordLabel = new System.Windows.Forms.Label();
            this.meta_keywordTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oc_category_descriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.oc_category_descriptionBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(748, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.Save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.AutoSize = true;
            this.Panel1.Controls.Add(this.category_idLabel);
            this.Panel1.Controls.Add(this.category_idTextBox);
            this.Panel1.Controls.Add(this.language_idLabel);
            this.Panel1.Controls.Add(this.language_idTextBox);
            this.Panel1.Controls.Add(this.nameLabel);
            this.Panel1.Controls.Add(this.nameTextBox);
            this.Panel1.Controls.Add(this.descriptionLabel);
            this.Panel1.Controls.Add(this.descriptionTextBox);
            this.Panel1.Controls.Add(this.meta_descriptionLabel);
            this.Panel1.Controls.Add(this.meta_descriptionTextBox);
            this.Panel1.Controls.Add(this.meta_keywordLabel);
            this.Panel1.Controls.Add(this.meta_keywordTextBox);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(10, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(728, 208);
            this.Panel1.TabIndex = 1;
            // 
            // category_idLabel
            // 
            this.category_idLabel.AutoSize = true;
            this.category_idLabel.Location = new System.Drawing.Point(75, 50);
            this.category_idLabel.Name = "category_idLabel";
            this.category_idLabel.Size = new System.Drawing.Size(62, 13);
            this.category_idLabel.TabIndex = 1;
            this.category_idLabel.Text = "category_id";
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.Location = new System.Drawing.Point(147, 50);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.category_idTextBox.TabIndex = 2;
            this.category_idTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.category_idTextBox_Validating);
            // 
            // language_idLabel
            // 
            this.language_idLabel.AutoSize = true;
            this.language_idLabel.Location = new System.Drawing.Point(72, 76);
            this.language_idLabel.Name = "language_idLabel";
            this.language_idLabel.Size = new System.Drawing.Size(65, 13);
            this.language_idLabel.TabIndex = 3;
            this.language_idLabel.Text = "language_id";
            // 
            // language_idTextBox
            // 
            this.language_idTextBox.Location = new System.Drawing.Point(147, 76);
            this.language_idTextBox.Name = "language_idTextBox";
            this.language_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.language_idTextBox.TabIndex = 4;
            this.language_idTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.language_idTextBox_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(104, 102);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(147, 102);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(386, 50);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(58, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(454, 50);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTextBox_Validating);
            // 
            // meta_descriptionLabel
            // 
            this.meta_descriptionLabel.AutoSize = true;
            this.meta_descriptionLabel.Location = new System.Drawing.Point(357, 76);
            this.meta_descriptionLabel.Name = "meta_descriptionLabel";
            this.meta_descriptionLabel.Size = new System.Drawing.Size(87, 13);
            this.meta_descriptionLabel.TabIndex = 9;
            this.meta_descriptionLabel.Text = "meta_description";
            // 
            // meta_descriptionTextBox
            // 
            this.meta_descriptionTextBox.Location = new System.Drawing.Point(454, 76);
            this.meta_descriptionTextBox.Name = "meta_descriptionTextBox";
            this.meta_descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.meta_descriptionTextBox.TabIndex = 10;
            this.meta_descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.meta_descriptionTextBox_Validating);
            // 
            // meta_keywordLabel
            // 
            this.meta_keywordLabel.AutoSize = true;
            this.meta_keywordLabel.Location = new System.Drawing.Point(368, 102);
            this.meta_keywordLabel.Name = "meta_keywordLabel";
            this.meta_keywordLabel.Size = new System.Drawing.Size(76, 13);
            this.meta_keywordLabel.TabIndex = 11;
            this.meta_keywordLabel.Text = "meta_keyword";
            // 
            // meta_keywordTextBox
            // 
            this.meta_keywordTextBox.Location = new System.Drawing.Point(454, 102);
            this.meta_keywordTextBox.Name = "meta_keywordTextBox";
            this.meta_keywordTextBox.Size = new System.Drawing.Size(100, 20);
            this.meta_keywordTextBox.TabIndex = 12;
            this.meta_keywordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.meta_keywordTextBox_Validating);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 218);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(738, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 208);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 208);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 208);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(748, 10);
            this.panel6.TabIndex = 6;
            // 
            // frmoc_category_description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(748, 243);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "frmoc_category_description";
            this.Text = "Oc_Category_Description";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmoc_category_description_FormClosing);
            this.Load += new System.EventHandler(this.frmoc_category_description_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oc_category_descriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.BindingSource oc_category_descriptionBindingSource;
		private System.Windows.Forms.TextBox category_idTextBox;
		private System.Windows.Forms.Label category_idLabel;
		private System.Windows.Forms.TextBox language_idTextBox;
		private System.Windows.Forms.Label language_idLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox meta_descriptionTextBox;
		private System.Windows.Forms.Label meta_descriptionLabel;
		private System.Windows.Forms.TextBox meta_keywordTextBox;
		private System.Windows.Forms.Label meta_keywordLabel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		
	}
}
