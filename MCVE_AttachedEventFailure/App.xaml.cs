using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MCVE_AttachedEventFailure {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		//Field Value
		private RelayCommand testCommand = new RelayCommand(( ) => MessageBox.Show("Event Captured!", "Success!"));
		public RelayCommand TestCommand => testCommand;
	}
}