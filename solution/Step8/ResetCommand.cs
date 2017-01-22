namespace MvvmExercise1.Step8
{
	public class ResetCommand
	{
		public ViewModel ViewModel { get; set; }

		public DelegateCommand Command { get; private set; }

		public ResetCommand()
		{
			this.Command = new DelegateCommand(this.ExecuteReset, this.CanReset);
		}

		public void ExecuteReset(object unused)
		{
			this.ViewModel.AutoStart = false;
			this.ViewModel.Start = false;
			this.ViewModel.DynamicColors = false;
			this.ViewModel.DefaultName = string.Empty;
			this.ViewModel.FontSize = Size.Small;
		}

		public bool CanReset(object unused)
		{
			return true;
		}

	}
}
