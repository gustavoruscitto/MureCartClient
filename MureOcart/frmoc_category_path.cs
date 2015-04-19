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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace MureOcart
{
	public partial class frmoc_category_path : Form
	{
		private Model1Entities ctx;
		
		public frmoc_category_path()
		{
			InitializeComponent();
		}
		
		private void frmoc_category_path_Load(object sender, EventArgs e)
		{
			ctx = new Model1Entities();
			ctx.oc_category_path.Load();
			BindingList<oc_category_path> _entities = ctx.oc_category_path.Local.ToBindingList();
			oc_category_pathBindingSource.DataSource = _entities;
			this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_category_pathBindingSource, "category_id", true ));
			this.path_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_category_pathBindingSource, "path_id", true ));
			this.levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_category_pathBindingSource, "level", true ));
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			oc_category_pathBindingSource.EndEdit();
			ctx.SaveChanges();
			
		}
		
		private void frmoc_category_path_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void category_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( category_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( category_idTextBox, "The field category_id is required" ); 
			}
			int v;
			string s = category_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( category_idTextBox, "The field category_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( category_idTextBox, "" ); } 
		}
		
		private void path_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( path_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( path_idTextBox, "The field path_id is required" ); 
			}
			int v;
			string s = path_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( path_idTextBox, "The field path_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( path_idTextBox, "" ); } 
		}
		
		private void levelTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( levelTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( levelTextBox, "The field level is required" ); 
			}
			int v;
			string s = levelTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( levelTextBox, "The field level must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( levelTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			oc_category_pathBindingSource.AddNew();
		}
	}
}
