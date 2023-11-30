using System.Collections.Generic;
using UnityEngine;

public class CharacterVisualObjectVariation : MonoBehaviour
{
	[SerializeField]
	public CharacterVisualObjectBehaviour visualObjectBehaviour;

	[SerializeField]
	private VisualObjectVariation variation;

	[SerializeField]
	private List<CharacterVisualSprite> sprites;

	public void SetStencilIndex(int stencilIndex)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public void Init(CharacterVisualObjectBehaviour visualObjectBehaviour, VisualObjectVariation variation)
	{
	}

	public CharacterVisualSprite CreateSprite(VisualSprite vSprite)
	{
		return null;
	}
}
