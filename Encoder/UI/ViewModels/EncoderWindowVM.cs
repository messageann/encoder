﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using WPFCoreEx.Bases;

namespace UI.ViewModels
{
	public class EncoderWindowVM : INotifyPropertyChanged
	{
		public string Title => "Encoder";

		#region NOTIFS
		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion //NOTIFS
	}
}
