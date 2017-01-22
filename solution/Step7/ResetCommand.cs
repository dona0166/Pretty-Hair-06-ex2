namespace MvvmExercise1.Step7
{
	public class ResetCommand
	{
		public DelegateCommand Command { get; private set; }

		public ResetCommand()
		{
			this.Command = new DelegateCommand(this.ExecuteReset, this.CanReset);
		}

		public void ExecuteReset(object unused)
		{

		}

		public bool CanReset(object unused)
		{
			return true;
		}

	}
}
