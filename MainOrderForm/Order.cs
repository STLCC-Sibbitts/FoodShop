using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MainOrderForm
{
	public class Order : INotifyPropertyChanged
	{ 
		/// <summary>
		/// The constructor is private to enforce the factory pattern
		/// </summary>
		private Order()
        {
			_employeeId = "Joe Hight";
			_displayName = "314-291-5555";
        }

        /// <summary>
		/// This is the public factory method.
        /// </summary>
        /// <returns>a single Order instance</returns>
 
		public static Order CreateNewOrder()
        {
			return new Order();
        }

		private string _employeeId;
		private string _displayName;

		public string DisplayName
		{
			get
			{
				return _displayName;
			}
			set
			{
				if ( value != this._displayName )
				{
					this._displayName = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string EmployeeId
		{
			get
			{
				return this._employeeId;
			}
			set
			{
				if ( value != this._employeeId )
				{
					this._employeeId = value;
					NotifyPropertyChanged();
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// This method is called by the Set accessor of each property.
		/// The CallerMemberName attribute that is applied to the optional propertyName 
		/// parameter causes the property name of the caller to be substituted as an argument.
		/// </summary>
		/// <param name="propertyName"></param>
		private void NotifyPropertyChanged( [CallerMemberName] String propertyName = "" )
		{
			if ( PropertyChanged != null )
			{
				PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
			}
		}
	}
}
