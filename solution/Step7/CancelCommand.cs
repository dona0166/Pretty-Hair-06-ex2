namespace MvvmExercise1.Step7
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

		}

		public bool CanCancel(object unused)
		{
			return true;
		}

	}
}
