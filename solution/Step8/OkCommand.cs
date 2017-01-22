using System.Windows;

namespace MvvmExercise1.Step8
{
	public class OkCommand
	{
		public DelegateCommand Command { get; private set; }

		public OkCommand()
		{
			this.Command = new DelegateCommand(this.ExecuteOk, this.CanOk);
		}

		public void ExecuteOk(object unused)
		{
			MessageBox.Show("Ok executed");
		}

		public bool CanOk(object unused)
		{
			return true;
		}

	}
}
