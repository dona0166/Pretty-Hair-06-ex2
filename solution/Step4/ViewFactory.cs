﻿namespace MvvmExercise1.Step4
{
	public class ViewFactory
	{
		public ViewInfrastructure Create()
		{
			Model model = new Model();
			ViewModel viewModel = new ViewModel(model);
			View view = new View();

			return new ViewInfrastructure(view, viewModel, model);
		}
	}
}
