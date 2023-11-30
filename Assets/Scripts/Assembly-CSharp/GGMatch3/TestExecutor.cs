using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class TestExecutor : Match3GameListener
	{
		public struct ExecuteArguments
		{
			public int repeatTimes;

			public LevelEditorVisualizer visualizer;
		}

		public struct ResultData
		{
			public int moveCount;

			public int count;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<ResultData> _003C_003E9__13_0;

			internal int _003CDoExecution_003Eb__13_0(ResultData x, ResultData y)
			{
				return 0;
			}
		}

		private sealed class _003CDoExecution_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TestExecutor _003C_003E4__this;

			private LevelEditorVisualizer _003Cvisualizer_003E5__2;

			private DateTime _003CstartTime_003E5__3;

			private int _003CrepeatTimes_003E5__4;

			private int _003Ci_003E5__5;

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
			public _003CDoExecution_003Ed__13(int _003C_003E1__state)
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

		private GameResults results;

		private Dictionary<int, int> countGamesPerMoves;

		private ExecuteArguments arguments;

		private IEnumerator executionEnum;

		private List<GameResults.GameResult> gameResults => null;

		public void OnGameComplete(GameCompleteParams completeParams)
		{
		}

		public void OnGameStarted(GameStartedParams startedParams)
		{
		}

		private void Clear()
		{
		}

		public void StopTesting()
		{
		}

		public void StartTesting(ExecuteArguments arguments)
		{
		}

		private IEnumerator DoExecution()
		{
			return null;
		}

		public void Update()
		{
		}
	}
}
