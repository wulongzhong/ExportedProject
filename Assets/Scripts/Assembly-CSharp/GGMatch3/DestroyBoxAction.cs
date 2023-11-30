using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class DestroyBoxAction : BoardAction
	{
		[Serializable]
		public class Settings
		{
			public float fromScale;

			public float toScale;

			public float duration;

			public AnimationCurve animationCurve;

			public float fromAlpha;

			public float toAlpha;

			public bool holdGravityOnChip;

			public float holdGravityDuration;
		}

		public struct InitArguments
		{
			public SlotComponent chip;

			public Slot slot;
		}

		private sealed class _003CDoAnimation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DestroyBoxAction _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private float _003Cduration_003E5__3;

			private AnimationCurve _003Ccurve_003E5__4;

			private Match3Board _003Cboard_003E5__5;

			private TransformBehaviour _003CchipTransform_003E5__6;

			private float _003CholdGravityDuration_003E5__7;

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
			public _003CDoAnimation_003Ed__13(int _003C_003E1__state)
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

		private IEnumerator animation;

		private Lock chipLock;

		private InitArguments initArguments;

		public Settings settings => null;

		private SlotComponent chip => null;

		private Slot slot => null;

		public void Init(InitArguments initArguments)
		{
		}

		public override void OnStart(ActionManager manager)
		{
		}

		private IEnumerator DoAnimation()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
