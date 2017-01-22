namespace MvvmExercise1.Step8
{
	public class ViewFactory
	{
		public ViewInfrastructure Create()
		{
			ResetCommand resetCommand = new ResetCommand();
			OkCommand okCommand = new OkCommand();
			CancelCommand cancelCommand = new CancelCommand();

			Model model = new Model();
			ViewModel viewModel = new ViewModel(model, resetCommand.Command, okCommand.Command, cancelCommand.Command);
			View view = new View();

			resetCommand.ViewModel = viewModel;

			return new ViewInfrastructure(view, viewModel, model);
		}
	}
}
