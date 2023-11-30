using GGMatch3;
using TMPro;
using UnityEngine;

public class MonsterElementBehaviour : MonoBehaviour
{
	[SerializeField]
	private Transform scalerTransform;

	[SerializeField]
	private SpriteRenderer monsterSprite;

	[SerializeField]
	private TextMeshPro label;

	[SerializeField]
	private Animator monsterAnimator;

	public void Init(LevelDefinition.MonsterElement monsterElement)
	{
	}

	public void SetCount(int countRemaining)
	{
	}

	public void DoEatAnimation()
	{
	}
}
