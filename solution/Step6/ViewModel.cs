using System.ComponentModel;

namespace MvvmExercise1.Step6
{
	public class ViewModel : INotifyPropertyChanged
	{
		private readonly Model model;

		public string DefaultName
		{
			get
			{
				return this.model.DefaultName;
			}
			set
			{
				if (this.model.DefaultName != value)
				{
					this.model.DefaultName = value;
					this.OnPropertyChanged("DefaultName");
				}
			}
		}

		public Size FontSize
		{
			get
			{
				return this.model.FontSize;
			}
			set
			{
				if (this.model.FontSize != value)
				{
					this.model.FontSize = value;
					this.OnPropertyChanged("FontSize");
				}
			}
		}

		public bool Start
		{
			get
			{
				return this.model.Start;
			}
			set
			{
				if (this.model.Start != value)
				{
					this.model.Start = value;
					this.OnPropertyChanged("Start");
				}
			}
		}

		public bool AutoStart
		{
			get
			{
				return this.model.AutoStart;
			}
			set
			{
				if (this.model.AutoStart != value)
				{
					this.model.AutoStart = value;
					this.OnPropertyChanged("AutoStart");
				}
			}
		}

		public bool DynamicColors
		{
			get
			{
				return this.model.DynamicColors;
			}
			set
			{
				if (this.model.DynamicColors != value)
				{
					this.model.DynamicColors = value;
					this.OnPropertyChanged("DynamicColors");
				}
			}
		}

		public ViewModel(Model model)
		{
			this.model = model;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}