﻿// Concept Matrix 3.
// Licensed under the MIT license.

namespace ConceptMatrix.Modules
{
	using System.Threading.Tasks;

	public interface IModule
	{
		/// <summary>
		/// Called when the module is loaded into memory during service initialization.
		/// </summary>
		Task Initialize();

		/// <summary>
		/// Called once all services are ready.
		/// </summary>
		Task Start();

		/// <summary>
		/// Called as the application quits.
		/// </summary>
		Task Shutdown();
	}
}
