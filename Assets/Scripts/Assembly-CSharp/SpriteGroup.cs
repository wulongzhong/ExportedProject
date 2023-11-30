using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SpriteGroup : MonoBehaviour
{
	[SerializeField]
	private List<SpriteRenderer> sprites;

	[SerializeField]
	private float alphaValue;

	private void OnDidApplyAnimationProperties()
	{
	}
}
