using System.Windows;

namespace MvvmExercise1.Step8
{
	public class CancelCommand
	{
		public DelegateCommand Command { get; private set; }

		public CancelCommand()
		{
			this.Command = new DelegateCommand(this.ExecuteCancel, this.CanCancel);
		}

		public void ExecuteCancel(object unused)
		{
			MessageBox.Show("Cancel executed");
		}

		public bool CanCancel(object unused)
		{
			return true;
		}

	}
}
