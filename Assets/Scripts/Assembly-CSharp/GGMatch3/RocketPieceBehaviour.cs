using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class RocketPieceBehaviour : MonoBehaviour
	{
		private sealed class _003CDoRemoveFromGameAfter_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RocketPieceBehaviour _003C_003E4__this;

			public float duration;

			private float _003Ctime_003E5__2;

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
			public _003CDoRemoveFromGameAfter_003Ed__14(int _003C_003E1__state)
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

		[SerializeField]
		private Transform rotatorTransform;

		[SerializeField]
		private Transform rocketTransform;

		[SerializeField]
		private List<Transform> verticalWidgets;

		[SerializeField]
		private List<Transform> horizontalWidgets;

		public Vector3 localPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 localScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public void SetDirection(IntVector2 direction)
		{
		}

		public void SetDirection(Vector2 direction)
		{
		}

		public void Init()
		{
		}

		public void RemoveFromGameAfter(float duration)
		{
		}

		private IEnumerator DoRemoveFromGameAfter(float duration)
		{
			return null;
		}

		public void RemoveFromGame()
		{
		}
	}
}
