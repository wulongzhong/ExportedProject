using System;
using GGCloth;
using UnityEngine;

public class ClothDemo : MonoBehaviour
{
	public enum AttachPos
	{
		Bottom = 0,
		Center = 1,
		BottomCenter = 2,
		Top = 3,
		WholeCenter = 4
	}

	[SerializeField]
	private bool useLocalPosition;

	[SerializeField]
	private bool isSleeping;

	[SerializeField]
	public bool useMaxDifferenceMagnitude;

	[SerializeField]
	private float maxDifferenceMagnitudeLocal;

	[SerializeField]
	private float maxTimeBeforeSleep;

	[SerializeField]
	private bool sleepAfterTime;

	[SerializeField]
	private AttachPos attachPos;

	[SerializeField]
	private Transform centralTarget;

	[SerializeField]
	private Transform localPositionTarget;

	[SerializeField]
	public bool drawGrid;

	[SerializeField]
	public float scaleOutBy;

	[SerializeField]
	public float stiffnessRandom;

	[SerializeField]
	public Vector3 moveBy;

	[SerializeField]
	private int constraintRelaxationSteps;

	[NonSerialized]
	public SquareCloth cloth;

	[SerializeField]
	private SquareClothRenderer clothRenderer;

	[SerializeField]
	private Vector3 size;

	[SerializeField]
	public Vector3 gravity;

	[SerializeField]
	private float damping;

	[SerializeField]
	private float stiffness;

	[SerializeField]
	private int rowCount;

	[SerializeField]
	private int columnCount;

	[SerializeField]
	private float minMoveDistance;

	[SerializeField]
	private float row;

	[SerializeField]
	private float column;

	[SerializeField]
	public float impulseMult;

	public bool directlyFollow;

	public bool debugOut;

	public float boardScale;

	private float lastMoveTime;

	private MultiPointAttachConstraint positionConstraint;

	private float maxDifferenceMagnitude => 0f;

	public Vector3 centralTargetPosition => default(Vector3);

	private int GetPointIndex(int column, int row, int columnCount)
	{
		return 0;
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateMaterialSettings()
	{
	}

	public void Init()
	{
	}

	public void ScaleOutBy(float scaleOut)
	{
	}

	public void MoveBy(Vector3 offset)
	{
	}

	public void MoveAllBy(Vector3 offset)
	{
	}
}
