﻿// Concept Matrix 3.
// Licensed under the MIT license.

namespace ConceptMatrix.PoseModule
{
	using System.Threading.Tasks;
	using ConceptMatrix.Modules;
	using ConceptMatrix.PoseModule.Pages;

	public class Module : IModule
	{
		public Task Initialize()
		{
			Services.Add<SkeletonService>();
			Services.Add<PoseService>();

			IViewService viewService = Services.Get<IViewService>();
			viewService.AddPage<PosePage>("Pose", "running");
			viewService.AddPage<PositionPage>("Positioning", "globe");

			return Task.CompletedTask;
		}

		public Task Start()
		{
			return Task.CompletedTask;
		}

		public Task Shutdown()
		{
			return Task.CompletedTask;
		}
	}
}