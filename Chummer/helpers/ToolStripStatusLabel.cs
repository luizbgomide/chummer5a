using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chummer.helpers
{
	// ReSharper disable once InconsistentNaming
	public class ToolStripStatusLabel : System.Windows.Forms.ToolStripStatusLabel, IBindableComponent
	{
		#region IBindableComponent Members
	
		private BindingContext _bindingContext;
		private ControlBindingsCollection _dataBindings;

		public BindingContext BindingContext
		{
			get { return _bindingContext ?? (_bindingContext = new BindingContext()); }
			set
			{
				_bindingContext = value;
			}
		}
		
		public ControlBindingsCollection DataBindings => _dataBindings ?? (_dataBindings = new ControlBindingsCollection(this));

		#endregion
	}
}
