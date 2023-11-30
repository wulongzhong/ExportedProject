using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenListDialogItem : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI label;

	[SerializeField]
	private Image spriteImage;

	[SerializeField]
	private Sprite defaultSprite;

	[SerializeField]
	private Image bckImage;

	[NonSerialized]
	private Action<OpenListDialogItem> onClick;

	private OpenListDialog.ListItem _003Citem_003Ek__BackingField;

	public OpenListDialog.ListItem item
	{
		get
		{
			return default(OpenListDialog.ListItem);
		}
		protected set
		{
		}
	}

	public void Init(OpenListDialog.ListItem item, Action<OpenListDialogItem> onClick)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void ButtonCallback_OnClick()
	{
	}
}
