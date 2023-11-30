using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CarSubPartInfo
{
	[Serializable]
	public class RotateSettings
	{
		public bool enabled;

		public Vector3 axis;

		public float initialAngle;

		public float outAngle;

		public Vector3 forwardDirection;
	}

	[SerializeField]
	public string nutTransformsPrefix;

	[SerializeField]
	public bool excludeSelfFromAnimation;

	[SerializeField]
	public Vector3 offset;

	[SerializeField]
	public bool stopGoingUnderZero;

	[SerializeField]
	public string displayName;

	[SerializeField]
	public string cameraName;

	[SerializeField]
	public bool showAtStart;

	[SerializeField]
	public bool directControl;

	[SerializeField]
	public bool skipAnimation;

	[SerializeField]
	public bool overrideChangeAnimOffset;

	[SerializeField]
	public bool removing;

	[SerializeField]
	public bool showNutTutorialHand;

	[SerializeField]
	public bool showChangeAnimAfterIn;

	[SerializeField]
	public Vector3 changeAnimOffset;

	[SerializeField]
	public List<string> toSayBefore;

	[SerializeField]
	public bool hideToSayWhenWorking;

	[SerializeField]
	public TalkCharacter character;

	[SerializeField]
	public List<string> toSayBeforeWork;

	[SerializeField]
	public List<InfoBoxDescription> infoBoxes;

	[SerializeField]
	public RotateSettings rotateSettings;

	[SerializeField]
	public PartHinge hinge;

	[SerializeField]
	public DrivePart drivePart;

	public bool useNutOffseting;

	public float nutOffset;

	public bool useForwardNutRotationForOffset;

	[SerializeField]
	public bool letNutsFall;

	[SerializeField]
	public bool changeNutDuration;

	[SerializeField]
	public float nutDuration;

	[SerializeField]
	public bool autoShowNuts;

	[SerializeField]
	public int nutIndexAfterAutoshowBegins;

	[SerializeField]
	private bool changeSfxType;

	[SerializeField]
	public float nutScale;

	[SerializeField]
	private GGSoundSystem.SFXType dragSfxType_;

	public GGSoundSystem.SFXType sfxType => default(GGSoundSystem.SFXType);
}
