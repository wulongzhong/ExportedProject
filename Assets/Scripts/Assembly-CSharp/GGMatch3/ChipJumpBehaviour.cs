using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class ChipJumpBehaviour
	{
		[Serializable]
		public class Settings
		{
			public Vector3 startOffset;

			public Vector3 offset;

			public bool useStartScale;

			public Vector3 startScale;

			public Vector3 scale;

			public float rotationAngle;

			public float duration;

			public AnimationCurve animationCurve;

			public float delay;

			public float delayPerX;
		}

		private sealed class _003CDoAnimateJump_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Chip chip;

			public ChipJumpBehaviour _003C_003E4__this;

			private Match3Game _003Cgame_003E5__2;

			private TransformBehaviour _003Ct_003E5__3;

			private float _003Ctime_003E5__4;

			private float _003CtotalDuration_003E5__5;

			private float _003CinitialDelay_003E5__6;

			private float _003CprevTime_003E5__7;

			private float _003CprevRepetition_003E5__8;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CDoAnimateJump_003Ed__9(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public bool isActive;

		private Settings settings;

		private IEnumerator animation;

		private float deltaTime;

		public void Init(Settings settings)
		{
		}

		private void SetOffset(TransformBehaviour t, Vector3 offset)
		{
		}

		private void SetScale(TransformBehaviour t, Vector3 scale)
		{
		}

		private void SetRotation(TransformBehaviour t, float angle)
		{
		}

		private IEnumerator DoAnimateJump(Chip chip)
		{
			return null;
		}

		public void Update(Chip chip, float deltaTime)
		{
		}
	}
}
