using UnityEngine;

public class CharacterVisualSprite : MonoBehaviour
{
	[SerializeField]
	private CharacterVisualObjectVariation variation;

	public SpriteRenderer spriteRenderer;

	public VisualSprite visualSpriteBeh;

	public Transform pivotTransform;

	public Transform spriteTransform;

	public void SetStencilIndex(int stencilIndex)
	{
	}

	public void Init(VisualSprite visualSpriteBeh, CharacterVisualObjectVariation variation)
	{
	}
}
