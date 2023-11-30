using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	public class DemoPlayerControllerScript : MonoBehaviour
	{
		public Text SpellLabel;

		public float Speed;

		public float RotateSpeed;

		public LightningSpellScript[] Spells;

		private int spellIndex;

		private bool spellMouseButtonDown;

		private GameObject rightHand;

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool GuiElementShouldPassThrough()
		{
			return false;
		}

		private void UpdateSpell()
		{
		}

		private void ChangeSpell(int dir)
		{
		}

		public void PreviousSpell()
		{
		}

		public void NextSpell()
		{
		}
	}
}
