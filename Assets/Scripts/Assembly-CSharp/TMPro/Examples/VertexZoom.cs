using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace TMPro.Examples
{
	public class VertexZoom : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public List<float> modifiedCharScale;

			public Comparison<int> _003C_003E9__0;

			internal int _003CAnimateVertexColors_003Eb__0(int a, int b)
			{
				return 0;
			}
		}

		private sealed class _003CAnimateVertexColors_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VertexZoom _003C_003E4__this;

			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			private TMP_TextInfo _003CtextInfo_003E5__2;

			private TMP_MeshInfo[] _003CcachedMeshInfoVertexData_003E5__3;

			private List<int> _003CscaleSortingOrder_003E5__4;

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
			public _003CAnimateVertexColors_003Ed__10(int _003C_003E1__state)
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

		public float AngleMultiplier;

		public float SpeedMultiplier;

		public float CurveScale;

		private TMP_Text m_TextComponent;

		private bool hasTextChanged;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
}
