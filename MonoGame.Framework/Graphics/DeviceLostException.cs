#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2014 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

#region Using Statements
using System;
using System.Runtime.Serialization;
#endregion

namespace Microsoft.Xna.Framework.Graphics
{
	[DataContract]
	public sealed class DeviceLostException : Exception
	{
		public DeviceLostException()
			: base()
		{
		}

		public DeviceLostException(string message)
			: base(message)
		{
		}

		public DeviceLostException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
