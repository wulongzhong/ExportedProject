using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class CollectPointsAction : BoardAction
	{
		public struct InitArguments
		{
			public int count;

			public int matchesCount;

			public Vector3 localPosition;

			public Match3Game game;

			public bool isBlocker;

			public ItemColor itemColor;

			public void SetCount(int desiredCount, int numMatches)
			{
			}
		}

		[Serializable]
		public class Settings
		{
			[Serializable]
			public class ColorForItemColor
			{
				[SerializeField]
				public ItemColor itemColor;

				[SerializeField]
				public Color color;
			}

			public bool enabled;

			public bool enableForPowerupCreate;

			public bool enableForPowerupBlow;

			public bool enableForGoals;

			public int blockerCount;

			public int count;

			public int powerupCount;

			public float fadeFrom;

			public float fadeTo;

			public float scaleFrom;

			public float scaleTo;

			public float scaleToEnd;

			public float scaleToBlocker;

			public int maxMatches;

			public AnimationCurve scaleCurve;

			public float appearDuration;

			public Vector3 travelOffset;

			public float travelDuration;

			public AnimationCurve travelFadeCurve;

			public float finalAlpha;

			[SerializeField]
			private List<ColorForItemColor> itemColors;

			public Color GetColor(ItemColor itemColor)
			{
				return default(Color);
			}
		}

		private sealed class _003CMove_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectPointsAction _003C_003E4__this;

			private Settings _003Csettings_003E5__2;

			private Vector3 _003CstartPos_003E5__3;

			private Vector3 _003CendPos_003E5__4;

			private float _003Ctime_003E5__5;

			private float _003Cduration_003E5__6;

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
			public _003CMove_003Ed__14(int _003C_003E1__state)
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

		private sealed class _003CAppear_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectPointsAction _003C_003E4__this;

			private Settings _003Csettings_003E5__2;

			private Vector3 _003CstartScale_003E5__3;

			private Vector3 _003CendScale_003E5__4;

			private float _003Ctime_003E5__5;

			private float _003Cduration_003E5__6;

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
			public _003CAppear_003Ed__15(int _003C_003E1__state)
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

		private sealed class _003CDoAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectPointsAction _003C_003E4__this;

			private IEnumerator _003Canimation_003E5__2;

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
			public _003CDoAnimation_003Ed__16(int _003C_003E1__state)
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

		private float deltaTime;

		private IEnumerator animationEnum;

		private InitArguments initArguments;

		private static List<Slot> slotsWithGoals;

		private TransformBehaviour transformToMove;

		private Settings settings => null;

		public static void OnBlockerDestroy(Slot slot, SlotDestroyParams destroyParams)
		{
		}

		public static void OnIslandDestroy(DestroyMatchingIslandAction.InitArguments arguments)
		{
		}

		public static void OnChipDestroy(Chip chip, SlotDestroyParams destroyParams)
		{
		}

		public static void OnSlotDestroy(Slot slot, SlotDestroyParams destroyParams)
		{
		}

		public void Init(InitArguments initArguments)
		{
		}

		private IEnumerator Move()
		{
			return null;
		}

		private IEnumerator Appear()
		{
			return null;
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
