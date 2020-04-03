﻿// Concept Matrix 3.
// Licensed under the MIT license.

namespace ConceptMatrix
{
	using System.Threading.Tasks;
	using ConceptMatrix.Services;

	public interface IServices
	{
		T Get<T>()
			where T : IService;

		Task Add<T>()
			where T : IService, new();
	}
}
