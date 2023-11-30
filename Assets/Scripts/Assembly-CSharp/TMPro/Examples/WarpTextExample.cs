using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace TMPro.Examples
{
	public class WarpTextExample : MonoBehaviour
	{
		private sealed class _003CWarpText_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WarpTextExample _003C_003E4__this;

			private float _003Cold_CurveScale_003E5__2;

			private AnimationCurve _003Cold_curve_003E5__3;

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
			public _003CWarpText_003Ed__8(int _003C_003E1__state)
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

		private TMP_Text m_TextComponent;

		public AnimationCurve VertexCurve;

		public float AngleMultiplier;

		public float SpeedMultiplier;

		public float CurveScale;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		private IEnumerator WarpText()
		{
			return null;
		}
	}
}
