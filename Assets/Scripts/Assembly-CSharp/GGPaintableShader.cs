using UnityEngine;

public class GGPaintableShader
{
	public static int _Channel;

	public static int _Position;

	public static int _BrushSize;

	public static int _BrushHardness;

	public static int _Color;

	public static int _Texture;

	public static int _MainTex;

	public static int _IlsandMap;

	public static int _TexelSize;

	static GGPaintableShader()
	{
	}

	public static Shader Load(string shaderName)
	{
		return null;
	}

	public static Material Build(Shader shader)
	{
		return null;
	}

	public static Vector4 IndexToVector(int index)
	{
		return default(Vector4);
	}
}
