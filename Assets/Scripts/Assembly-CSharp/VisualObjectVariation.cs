using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class VisualObjectVariation : MonoBehaviour
{
	private sealed class _003CDoScaleAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VisualObjectVariation _003C_003E4__this;

		public float delay;

		public bool hide;

		private List<VisualSprite> _003CanimatedSprites_003E5__2;

		private DecoratingSceneConfig.ScaleAnimationSettings _003Cconfig_003E5__3;

		private float _003Ctime_003E5__4;

		private Vector3 _003CstartScale_003E5__5;

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
		public _003CDoScaleAnimation_003Ed__16(int _003C_003E1__state)
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

	public Sprite savedThumbnailSprite;

	public List<VisualSprite> sprites;

	[NonSerialized]
	public GraphicsSceneConfig.Variation variation;

	public VisualObjectBehaviour visualObjectBehaviour;

	private IEnumerator animationEnum;

	public Sprite thumbnailSprite => null;

	public void SetActive(bool isActive)
	{
	}

	public void SetVariationActive(string variationName)
	{
	}

	public void Hide()
	{
	}

	public VisualSprite CreateSprite(GraphicsSceneConfig.VisualSprite vSprite)
	{
		return null;
	}

	public void Init(VisualObjectBehaviour visualObjectBehaviour, GraphicsSceneConfig.Variation variation)
	{
	}

	public void DestroySelf()
	{
	}

	public static void Destroy(GameObject obj)
	{
	}

	private void ResetSprites()
	{
	}

	public void ScaleAnimation(float delay, bool hide = false)
	{
	}

	private IEnumerator DoScaleAnimation(float delay, bool hide)
	{
		return null;
	}

	private void Update()
	{
	}
}
