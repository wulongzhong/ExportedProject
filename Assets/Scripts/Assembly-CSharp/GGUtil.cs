using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GGUtil
{
	public class ColorProvider
	{
		private Color[] colors;

		public Color GetColor(int index)
		{
			return default(Color);
		}
	}

	public class UIUtil
	{
		private Vector3[] worldCorners;

		public Vector2 GetWorldDimensions(RectTransform trans)
		{
			return default(Vector2);
		}

		public Pair<Vector2, Vector2> GetAABB(List<RectTransform> transforms)
		{
			return null;
		}

		public void PositionRectInsideRect(RectTransform constrainRect, RectTransform rect, Vector2 screenSpacePosition)
		{
		}

		public void RestrictRectTransform(RectTransform rectTrans, RectTransform constrainingRectTrans)
		{
		}

		public void AnchorRectInsideScreen(RectTransform rectTrans, Camera camera)
		{
		}
	}

	public static ColorProvider colorProvider;

	public static UIUtil uiUtil;

	public static bool IsEmptyList<T>(List<T> list)
	{
		return false;
	}

	public static void RemoveNull<T>(List<T> list) where T : class
	{
	}

	public static bool UpdateEnumerator(ref IEnumerator enumerator)
	{
		return false;
	}

	public static void SetScale(Transform transform, Vector3 scale)
	{
	}

	public static void SetFill(Image image, float fillAmount)
	{
	}

	public static void SetSprite(Image image, Sprite sprite)
	{
	}

	public static void SetSprite(List<Image> image, Sprite sprite)
	{
	}

	public static void SetAlpha(Image image, float alpha)
	{
	}

	public static void SetColor(Image image, Color color)
	{
	}

	public static void SetAlpha(CanvasGroup canvasGroup, float alpha)
	{
	}

	public static void MoveNextOrSetNull(ref IEnumerator enumerator)
	{
	}

	public static void Call(Action action)
	{
	}

	public static bool HasText(string text)
	{
		return false;
	}

	public static void ChangeText(List<TextMeshProUGUI> list, string text)
	{
	}

	public static void ChangeText(TextMeshProUGUI label, int text)
	{
	}

	public static void ChangeText(TextMeshProUGUI label, long text)
	{
	}

	public static void ChangeText(TextMeshProUGUI label, string text)
	{
	}

	public static void Show(List<Transform> transform)
	{
	}

	public static void SetActive(List<Transform> transform, bool active)
	{
	}

	public static void Hide(List<GameObject> list)
	{
	}

	public static void Disable(MonoBehaviour beh)
	{
	}

	public static void SetActive(List<GameObject> list, bool active)
	{
	}

	public static void SetActive(Transform[] transform, bool active)
	{
	}

	public static void SetActive(Transform transform, bool active)
	{
	}

	public static void SetActive(ParticleSystem ps, bool active)
	{
	}

	public static void SetActive(MonoBehaviour beh, bool active)
	{
	}

	public static void Hide(List<Transform> list)
	{
	}

	public static void Hide(Transform[] list)
	{
	}

	public static void Hide(List<RectTransform> list)
	{
	}

	public static void Hide(GameObject beh)
	{
	}

	public static void Hide(ParticleSystem particleSystem)
	{
	}

	public static void Hide(MonoBehaviour beh)
	{
	}

	public static void Hide(Transform t)
	{
	}

	public static void Hide(RectTransform t)
	{
	}

	public static void Show(Transform trans)
	{
	}

	public static void Show(ParticleSystem ps)
	{
	}

	public static void Show(TrailRenderer trail)
	{
	}

	public static void SetActive(TrailRenderer trail, bool active)
	{
	}

	public static void Show(GameObject trans)
	{
	}

	public static void Show(RectTransform trans)
	{
	}

	public static void Show(MonoBehaviour beh)
	{
	}

	public static void SetActive(List<RectTransform> transList, bool active)
	{
	}

	public static void SetActive(RectTransform trans, bool active)
	{
	}

	public static bool isPartOfHierarchy(GameObject go)
	{
		return false;
	}

	public static void SetActive(GameObject go, bool active)
	{
	}

	public static float VisualRotationAngleUpAxis(Vector3 vec)
	{
		return 0f;
	}

	public static float Clamp0360(float eulerAngles)
	{
		return 0f;
	}

	public static float SignedAngle(Vector2 from, Vector2 to)
	{
		return 0f;
	}

	public static float SignedArea(List<Vector2> orderedVertices)
	{
		return 0f;
	}

	public static void Shuffle<T>(List<T> list)
	{
	}

	public static void Shuffle<T>(List<T> list, RandomProvider randomProvider)
	{
	}

	public static void Intersection<T>(List<T> a, List<T> b, List<T> resultIn) where T : struct
	{
	}

	public static string FirstCharToUpper(string s)
	{
		return null;
	}

	public static int ToLayer(LayerMask layer)
	{
		return 0;
	}

	public static void SetLayerRecursively(GameObject obj, LayerMask newLayer)
	{
	}

	public static void SetLayerRecursively(GameObject obj, int newLayer)
	{
	}

	public static void CopyWorldTransform(Transform from, Transform to)
	{
	}
}
