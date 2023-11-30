using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBeamSpellScript : LightningSpellScript
	{
		public LightningBoltPathScriptBase LightningPathScript;

		public float EndPointRandomization;

		public Action<RaycastHit> CollisionCallback;

		private void CheckCollision()
		{
		}

		protected override void Start()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected override void OnCastSpell()
		{
		}

		protected override void OnStopSpell()
		{
		}
	}
}
