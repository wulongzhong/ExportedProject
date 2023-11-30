using System;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectsDB : ScriptableObject
{
	[Serializable]
	public class SceneDependencies
	{
		public string name;

		public string assetsPath;

		public List<SceneObjectInfo> objectInfos;
	}

	[Serializable]
	public class MarginsInfo
	{
		public int totalWidth;

		public int leftMargin;

		public int rightMargin;

		public int totalHeight;

		public int bottomMargin;

		public int topMargin;

		public Vector2 visibleScenePercent => default(Vector2);

		public Vector2 marginsOffset => default(Vector2);
	}

	[Serializable]
	public class SceneObjectInfo
	{
		public enum AnimationType
		{
			ScaleAnimation = 0
		}

		public string objectName;

		public string displayName;

		public List<string> backwardDependencies;

		public SingleCurrencyPrice price;

		public bool autoSelect;

		public List<string> toSayAfterOpen;

		public int groupIndex;

		public bool isMarkersAbove;

		public string thumbnailNamePrefix;

		public string iconSpriteName;

		public AnimationType animationType;

		public string animationSettingsName;

		public bool usedDashedLineForIconHandlePosition;

		public bool hideCharacterWhenSelectingVariations;

		public bool isVisualObjectOverriden;

		public DecoratingSceneConfig.VisualObjectOverride objectOverride;

		public string sceneName;
	}

	public List<SceneDependencies> scenes;

	public MarginsInfo maxMargins;

	public MarginsInfo minMargins;

	private static SceneObjectsDB _instance;

	public static SceneObjectsDB instance => null;
}
