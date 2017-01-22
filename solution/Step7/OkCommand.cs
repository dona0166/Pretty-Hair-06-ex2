namespace MvvmExercise1.Step7
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

		}

		public bool CanOk(object unused)
		{
			return true;
		}

	}
}
