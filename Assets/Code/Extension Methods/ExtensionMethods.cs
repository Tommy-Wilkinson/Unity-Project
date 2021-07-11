using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{
	/// <summary>
	/// Extension method class for Interaction arguments.
	/// </summary>
	/// [Author("Tommy Wilkinson")]


		/// <summary>
		/// Extension method to check if a given layer is present in
		/// a LayerMask. If the Layer is in the LayerMask it returns
		/// true, otherwise false.
		/// </summary>
		/// <param name="mask">LayerMask to use for filtering.</param>
		/// <param name="layer">Target layer you want to check for.</param>
		/// <returns></returns>
		public static bool ContainsLayer(this LayerMask mask, int layer)
		{
			return mask == (mask | (1 << layer));
		}



}
