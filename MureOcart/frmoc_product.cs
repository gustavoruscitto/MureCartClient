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
	public partial class frmoc_product : Form
	{
		private Model1Entities ctx;
		
		public frmoc_product()
		{
			InitializeComponent();
		}
		
		private void frmoc_product_Load(object sender, EventArgs e)
		{
			ctx = new Model1Entities();
			ctx.oc_product.Load();
			BindingList<oc_product> _entities = ctx.oc_product.Local.ToBindingList();
			oc_productBindingSource.DataSource = _entities;
			this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "product_id", true ));
			this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "model", true ));
			this.skuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "sku", true ));
			this.upcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "upc", true ));
			this.eanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "ean", true ));
			this.janTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "jan", true ));
			this.isbnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "isbn", true ));
			this.mpnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "mpn", true ));
			this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "location", true ));
			this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "quantity", true ));
			this.stock_status_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "stock_status_id", true ));
			this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "image", true ));
			this.manufacturer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "manufacturer_id", true ));
			this.shippingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.oc_productBindingSource, "shipping", true));
			this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "price", true ));
			this.pointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "points", true ));
			this.tax_class_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "tax_class_id", true ));
			this.date_available_dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "date_available", true ));
			this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "weight", true ));
			this.weight_class_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "weight_class_id", true ));
			this.lengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "length", true ));
			this.widthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "width", true ));
			this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "height", true ));
			this.length_class_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "length_class_id", true ));
			this.subtractCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.oc_productBindingSource, "subtract", true));
			this.minimumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "minimum", true ));
			this.sort_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "sort_order", true ));
			this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.oc_productBindingSource, "status", true));
			this.date_added_dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "date_added", true ));
			this.date_modified_dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "date_modified", true ));
			this.viewedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "viewed", true ));
			this.quantity_setTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oc_productBindingSource, "quantity_set", true ));
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			oc_productBindingSource.EndEdit();
			ctx.SaveChanges();
			
		}
		
		private void frmoc_product_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
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
		
		private void modelTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( modelTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( modelTextBox, "The field model is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( modelTextBox, "" ); } 
		}
		
		private void skuTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( skuTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( skuTextBox, "The field sku is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( skuTextBox, "" ); } 
		}
		
		private void upcTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( upcTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( upcTextBox, "The field upc is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( upcTextBox, "" ); } 
		}
		
		private void eanTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( eanTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( eanTextBox, "The field ean is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( eanTextBox, "" ); } 
		}
		
		private void janTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( janTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( janTextBox, "The field jan is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( janTextBox, "" ); } 
		}
		
		private void isbnTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( isbnTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( isbnTextBox, "The field isbn is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( isbnTextBox, "" ); } 
		}
		
		private void mpnTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( mpnTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( mpnTextBox, "The field mpn is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( mpnTextBox, "" ); } 
		}
		
		private void locationTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( locationTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( locationTextBox, "The field location is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( locationTextBox, "" ); } 
		}
		
		private void quantityTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( quantityTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( quantityTextBox, "The field quantity is required" ); 
			}
			int v;
			string s = quantityTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( quantityTextBox, "The field quantity must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( quantityTextBox, "" ); } 
		}
		
		private void stock_status_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( stock_status_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( stock_status_idTextBox, "The field stock_status_id is required" ); 
			}
			int v;
			string s = stock_status_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( stock_status_idTextBox, "The field stock_status_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( stock_status_idTextBox, "" ); } 
		}
		
		private void imageTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( imageTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( imageTextBox, "The field image is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( imageTextBox, "" ); } 
		}
		
		private void manufacturer_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( manufacturer_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( manufacturer_idTextBox, "The field manufacturer_id is required" ); 
			}
			int v;
			string s = manufacturer_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( manufacturer_idTextBox, "The field manufacturer_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( manufacturer_idTextBox, "" ); } 
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
		
		private void pointsTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( pointsTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( pointsTextBox, "The field points is required" ); 
			}
			int v;
			string s = pointsTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( pointsTextBox, "The field points must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( pointsTextBox, "" ); } 
		}
		
		private void tax_class_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( tax_class_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( tax_class_idTextBox, "The field tax_class_id is required" ); 
			}
			int v;
			string s = tax_class_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( tax_class_idTextBox, "The field tax_class_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( tax_class_idTextBox, "" ); } 
		}
		
		private void weightTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( weightTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( weightTextBox, "The field weight is required" ); 
			}
			double v;
			string s = weightTextBox.Text;
			if( !double.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( weightTextBox, "The field weight must be double." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( weightTextBox, "" ); } 
		}
		
		private void weight_class_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( weight_class_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( weight_class_idTextBox, "The field weight_class_id is required" ); 
			}
			int v;
			string s = weight_class_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( weight_class_idTextBox, "The field weight_class_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( weight_class_idTextBox, "" ); } 
		}
		
		private void lengthTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( lengthTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( lengthTextBox, "The field length is required" ); 
			}
			double v;
			string s = lengthTextBox.Text;
			if( !double.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( lengthTextBox, "The field length must be double." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( lengthTextBox, "" ); } 
		}
		
		private void widthTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( widthTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( widthTextBox, "The field width is required" ); 
			}
			double v;
			string s = widthTextBox.Text;
			if( !double.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( widthTextBox, "The field width must be double." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( widthTextBox, "" ); } 
		}
		
		private void heightTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( heightTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( heightTextBox, "The field height is required" ); 
			}
			double v;
			string s = heightTextBox.Text;
			if( !double.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( heightTextBox, "The field height must be double." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( heightTextBox, "" ); } 
		}
		
		private void length_class_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( length_class_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( length_class_idTextBox, "The field length_class_id is required" ); 
			}
			int v;
			string s = length_class_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( length_class_idTextBox, "The field length_class_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( length_class_idTextBox, "" ); } 
		}
		
		private void minimumTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( minimumTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( minimumTextBox, "The field minimum is required" ); 
			}
			int v;
			string s = minimumTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( minimumTextBox, "The field minimum must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( minimumTextBox, "" ); } 
		}
		
		private void sort_orderTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( sort_orderTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( sort_orderTextBox, "The field sort_order is required" ); 
			}
			int v;
			string s = sort_orderTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( sort_orderTextBox, "The field sort_order must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( sort_orderTextBox, "" ); } 
		}
		
		private void viewedTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( viewedTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( viewedTextBox, "The field viewed is required" ); 
			}
			int v;
			string s = viewedTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( viewedTextBox, "The field viewed must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( viewedTextBox, "" ); } 
		}
		
		private void quantity_setTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( quantity_setTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( quantity_setTextBox, "The field quantity_set is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( quantity_setTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			oc_productBindingSource.AddNew();
		}
	}
}
