using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class DiscoBallDestroyAction : BoardAction
	{
		public class DiscoParams
		{
			public Match3Game game;

			public Slot originSlot;

			public Chip originBomb;

			public List<Slot> affectedSlotsList;

			public bool replaceWithBombs;

			public ChipType bombType;

			public Chip otherBomb;

			public bool isInstant;

			public bool isHavingCarpet;

			public List<LightingBolt> bolts;

			public float affectorDuration;

			public ItemColor itemColor;

			public bool hasBolts => false;

			public void InitWithItemColor(Slot originSlot, Match3Game game, ItemColor itemColor, bool replaceWithBombs)
			{
			}
		}

		[Serializable]
		public class Settings
		{
			public FloatRange amplitudeRange;

			public float angleSpeed;

			public float delayBetweenAffectedSlots;

			public float initialShakeTime;

			public float shakeTimeForSlot;

			public float minTotalDuration;

			public float touchSlotLightIntensity;

			public float shockWaveOffset;

			public bool useCameraShake;

			public GeneralSettings.CameraShakeSettings cameraShake;
		}

		private sealed class _003CShakeChip_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Chip chip;

			public DiscoBallDestroyAction _003C_003E4__this;

			public float delay;

			public bool replaceWithBomb;

			public float duration;

			private TransformBehaviour _003Cbeh_003E5__2;

			private float _003Ctime_003E5__3;

			private Vector3 _003Cdirection_003E5__4;

			private Vector3 _003CstartPostion_003E5__5;

			private float _003Camplitude_003E5__6;

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
			public _003CShakeChip_003Ed__15(int _003C_003E1__state)
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

		private sealed class _003CShakeSlot_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DiscoBallDestroyAction _003C_003E4__this;

			public float delay;

			public Slot slot;

			public bool replaceWithBomb;

			public float duration;

			public float lightIntensityWhenStart;

			private float _003Ctime_003E5__2;

			private TransformBehaviour _003Cbeh_003E5__3;

			private Vector3 _003Cdirection_003E5__4;

			private Vector3 _003CstartPostion_003E5__5;

			private float _003Camplitude_003E5__6;

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
			public _003CShakeSlot_003Ed__16(int _003C_003E1__state)
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

		private sealed class _003CDestroyAnimation_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DiscoBallDestroyAction _003C_003E4__this;

			private Settings _003Csettings_003E5__2;

			private List<Slot> _003CaffectedSlots_003E5__3;

			private EnumeratorsList _003CenumList_003E5__4;

			private bool _003CisHavingCarpet_003E5__5;

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
			public _003CDestroyAnimation_003Ed__17(int _003C_003E1__state)
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

		private DiscoParams discoParams;

		private Lock slotLock;

		private Lock stopGeneratorsLock;

		private SlotComponentLock slotComponentLock;

		private List<Slot> allLockedSlots;

		private List<Chip> allAffectedChips;

		private IEnumerator destroyAnimation;

		private Chip originChip;

		private Slot otherBombSlot;

		private Settings settings => null;

		public void Init(DiscoParams discoParams)
		{
		}

		private IEnumerator ShakeChip(Chip chip, float delay, float duration, bool replaceWithBomb)
		{
			return null;
		}

		private IEnumerator ShakeSlot(Slot slot, float delay, float duration, bool replaceWithBomb, float lightIntensityWhenStart)
		{
			return null;
		}

		private IEnumerator DestroyAnimation()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		private void AffectOuterCircleWithExplosion(IntVector2 center, int radius, float shockWaveOffset)
		{
		}
	}
}
