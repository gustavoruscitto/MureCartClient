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
	public partial class frmoc_product_special : Form
	{
		private Model1Entities ctx;
		
		public frmoc_product_special()
		{
			InitializeComponent();
		}
		
		private void frmoc_product_special_Load(object sender, EventArgs e)
		{
			ctx = new Model1Entities();
			ctx.oc_product_special.Load();
			BindingList<oc_product_special> _entities = ctx.oc_product_special.Local.ToBindingList();
			oc_product_specialBindingSource.DataSource = _entities;
			this.product_special_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_product_specialBindingSource, "product_special_id", true ));
			this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_product_specialBindingSource, "product_id", true ));
			this.customer_group_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_product_specialBindingSource, "customer_group_id", true ));
			this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_product_specialBindingSource, "priority", true ));
			this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_product_specialBindingSource, "price", true ));
			this.date_start_dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_product_specialBindingSource, "date_start", true ));
			this.date_end_dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_product_specialBindingSource, "date_end", true ));
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			oc_product_specialBindingSource.EndEdit();
			ctx.SaveChanges();
			
		}
		
		private void frmoc_product_special_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void product_special_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( product_special_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( product_special_idTextBox, "The field product_special_id is required" ); 
			}
			int v;
			string s = product_special_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( product_special_idTextBox, "The field product_special_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( product_special_idTextBox, "" ); } 
		}
		
		private void product_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( product_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( product_idTextBox, "The field product_id is required" ); 
			}
			int v;
			string s = product_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( product_idTextBox, "The field product_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( product_idTextBox, "" ); } 
		}
		
		private void customer_group_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( customer_group_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( customer_group_idTextBox, "The field customer_group_id is required" ); 
			}
			int v;
			string s = customer_group_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( customer_group_idTextBox, "The field customer_group_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( customer_group_idTextBox, "" ); } 
		}
		
		private void priorityTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( priorityTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( priorityTextBox, "The field priority is required" ); 
			}
			int v;
			string s = priorityTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( priorityTextBox, "The field priority must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( priorityTextBox, "" ); } 
		}
		
		private void priceTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( priceTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( priceTextBox, "The field price is required" ); 
			}
			double v;
			string s = priceTextBox.Text;
			if( !double.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( priceTextBox, "The field price must be double." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( priceTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			oc_product_specialBindingSource.AddNew();
		}
	}
}
