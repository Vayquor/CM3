﻿// Concept Matrix 3.
// Licensed under the MIT license.

namespace ConceptMatrix
{
	public struct Flag
	{
		public static readonly Flag Enabled = new Flag(true);
		public static readonly Flag Disabled = new Flag(false);

		public readonly bool IsEnabled;

		private Flag(bool enabled)
		{
			this.IsEnabled = enabled;
		}

		public static Flag Get(bool enabled)
		{
			return enabled ? Enabled : Disabled;
		}
	}
}
