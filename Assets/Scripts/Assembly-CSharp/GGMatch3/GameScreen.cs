using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GGMatch3
{
	public class GameScreen : MonoBehaviour, IRemoveFromHistoryEventListener
	{
		public class GameProgress
		{
			public Match3Game game;

			public GameCompleteParams completeParams;

			public bool isDone;

			public Vector3 offset;
		}

		public class StageState
		{
			public List<GameProgress> gameProgressList;

			public IEnumerator runnerEnumerator;

			public MultiLevelGoals goals;

			public int currentGameProgressIndex;

			public int hammersUsed;

			public int powerHammersUsed;

			public int additionalMoves => 0;

			public int userMovesCount => 0;

			public int userScore => 0;

			public int MovesRemaining => 0;

			public GameProgress currentGameProgress => null;

			public GameProgress GameProgressForGame(Match3Game game)
			{
				return null;
			}
		}

		public class Match3GameScene
		{
			public Scene scene;

			public Match3GameStarter starter;

			public Match3GameScene(Scene scene, Match3GameStarter starter)
			{
			}
		}

		[Serializable]
		public class MultiLevelAanimationSettings
		{
			public float durationPerScreen;

			public AnimationCurve moveAnimationCurve;

			public float initialDelay;
		}

		private sealed class _003CDoLoadGameScene_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameScreen _003C_003E4__this;

			private AsyncOperation _003CasyncOperation_003E5__2;

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
			public _003CDoLoadGameScene_003Ed__38(int _003C_003E1__state)
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

		private sealed class _003CGameRunner_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameScreen _003C_003E4__this;

			private BuyPowerupDialog _003Cdialog_003E5__2;

			private List<GameProgress> _003CgameProgressList_003E5__3;

			private bool _003CisBoostersPlaced_003E5__4;

			private int _003Ci_003E5__5;

			private GameProgress _003CgameProgress_003E5__6;

			private Match3Game _003Cgame_003E5__7;

			private bool _003CisFirstGame_003E5__8;

			private MultiLevelAanimationSettings _003CanimSettings_003E5__9;

			private Vector3 _003CstartOffset_003E5__10;

			private Vector3 _003CendOffset_003E5__11;

			private float _003Ctime_003E5__12;

			private float _003CtotalDuration_003E5__13;

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
			public _003CGameRunner_003Ed__43(int _003C_003E1__state)
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
		private ComponentPool shadowPool;

		[SerializeField]
		private Transform conffettiParticle;

		[SerializeField]
		private Transform background;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private List<RectTransform> visibleObjects;

		[SerializeField]
		public string gameSceneName;

		[SerializeField]
		public GoalsPanel goalsPanel;

		[SerializeField]
		public PowerupsPanel powerupsPanel;

		[SerializeField]
		public ShuffleContainer shuffleContainer;

		public MovesContainer movesContainer;

		[SerializeField]
		public WellDoneContainer wellDoneContainer;

		[SerializeField]
		public GameTapToContinueContainer tapToContinueContainer;

		[SerializeField]
		private TextMeshProUGUI levelLabel;

		[SerializeField]
		public TutorialHandController tutorialHand;

		[SerializeField]
		public RankedBoostersStartAnimation rankedBoostersStartAnimation;

		[SerializeField]
		private List<RectTransform> hideAll;

		[SerializeField]
		private VisualStyleSet loadingStyle;

		[SerializeField]
		private VisualStyleSet loadedStyle;

		[SerializeField]
		public InputHandler inputHandler;

		[SerializeField]
		public PowerupPlacementHandler powerupPlacement;

		[SerializeField]
		public RectTransform gamePlayAreaContainer;

		[SerializeField]
		public RectTransform tutorialMask;

		[SerializeField]
		public RectTransform exitButton;

		private Match3GameParams initParams;

		private IEnumerator loadingGameSceneEnum;

		public StageState stageState;

		private Match3GameScene gameScene;

		private bool isStarterLoaded => false;

		private LevelDefinition CloneLevelAndApplyChanges(LevelDefinition level, Match3GameParams initParams)
		{
			return null;
		}

		public void Show(Match3GameParams initParams)
		{
		}

		public void OnRemovedFromNavigationHistory()
		{
		}

		private void Init()
		{
		}

		public void DestroyCreatedGameObjects()
		{
		}

		private void LoadGameScene()
		{
		}

		private IEnumerator DoLoadGameScene()
		{
			return null;
		}

		private Vector2 ScreenWorldSize()
		{
			return default(Vector2);
		}

		public void ShowConfetti()
		{
		}

		private void StartGame()
		{
		}

		private IEnumerator GameRunner()
		{
			return null;
		}

		public void Callback_ShowActivatePowerup(PowerupsPanelPowerup panelPowerup)
		{
		}

		public void Match3GameCallback_OnGameOutOfMoves(GameCompleteParams completeParams)
		{
		}

		private void OutOfMovesCallback_OnPlayOnOfferYes(OutOfMovesDialog dialog)
		{
		}

		private void OutOfMovesCallback_OnPlayOnOfferNo(OutOfMovesDialog dialog)
		{
		}

		public void Match3GameCallback_OnGameWon(GameCompleteParams completeParams)
		{
		}

		public void HideVisibleObjects()
		{
		}

		public void HideAll()
		{
		}

		private void Update()
		{
		}

		public void ButtonCallback_OnExitButtonPressed()
		{
		}

		private void ExitGameConfirmDialogCallback_OnExit(bool shouldExit)
		{
		}
	}
}
