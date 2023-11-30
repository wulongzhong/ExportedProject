using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class SwapToMatchAction : BoardAction
	{
		[Serializable]
		public class Settings
		{
			public float slot1LightIntensity;

			public float slot2LightIntensity;
		}

		public struct SwapActionProperties
		{
			public Slot slot1;

			public Slot slot2;

			public bool isInstant;

			public List<LightingBolt> bolts;

			public Match3Game.SwitchSlotsArguments switchSlotsArgument;
		}

		public class PowerupList
		{
			public List<Chip> powerupList;

			private List<Chip> coloredChips;

			public Chip FirstPowerup => null;

			public bool isActivatingPowerup => false;

			public bool isMixingPowerups => false;

			public bool isMixingDiscoBallWithColorElement => false;

			public bool isContainingSingleActivateablePowerup => false;

			public ItemColor mixingColor => default(ItemColor);

			public Chip OtherPowerup(ChipType chipType)
			{
				return null;
			}

			public Chip PowerupOfType(ChipType chipType)
			{
				return null;
			}

			public int CountChipTypes(ChipType chipType1, ChipType chipType2)
			{
				return 0;
			}

			public int CountChipType(ChipType chipType)
			{
				return 0;
			}

			public void Add(Chip chip)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public bool swapForwardComplete;

			internal void _003CDoSwapToMixPowerups_003Eb__0()
			{
			}
		}

		private sealed class _003CDoSwapToMixPowerups_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwapToMatchAction _003C_003E4__this;

			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			public PowerupList powerupList;

			private Match3Game _003Cgame_003E5__2;

			private bool _003ChasCarpet_003E5__3;

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
			public _003CDoSwapToMixPowerups_003Ed__11(int _003C_003E1__state)
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

		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public bool swapForwardComplete;

			internal void _003CDoSwap_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass13_1
		{
			public bool swapBackComplete;

			internal void _003CDoSwap_003Eb__1()
			{
			}
		}

		private sealed class _003CDoSwap_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwapToMatchAction _003C_003E4__this;

			private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

			private _003C_003Ec__DisplayClass13_1 _003C_003E8__2;

			private Match3Game _003Cgame_003E5__2;

			private Chip _003Cchip1_003E5__3;

			private Chip _003Cchip2_003E5__4;

			private PowerupList _003CpowerupList_003E5__5;

			private bool _003CisInstant_003E5__6;

			private SwapChipsAction.SwapChipsParams _003Cp_003E5__7;

			private EnumeratorsList _003CenumList_003E5__8;

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
			public _003CDoSwap_003Ed__13(int _003C_003E1__state)
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

		private Slot slot1;

		private Slot slot2;

		private Lock slotLock;

		private IEnumerator swapEnumerator;

		private SwapActionProperties swapProperties;

		private List<Slot> allSlotsInMatch;

		public Settings settings => null;

		public void Init(SwapActionProperties swapProperties)
		{
		}

		private IEnumerator DoSwapToMixPowerups(PowerupList powerupList)
		{
			return null;
		}

		private IEnumerator DoSwap()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
