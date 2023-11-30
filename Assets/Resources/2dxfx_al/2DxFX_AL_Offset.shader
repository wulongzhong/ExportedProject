Shader "2DxFX/AL/Offset" {
	Properties {
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("_Color", Vector) = (1,1,1,1)
		_OffsetX ("Offset X", Range(0, 1)) = 1
		_OffsetY ("Offset Y", Range(0, 1)) = 1
		_ZoomX ("Zoom X", Range(0, 1)) = 1
		_ZoomY ("Zoom Y", Range(0, 1)) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
		[HideInInspector] _SrcBlend ("_SrcBlend", Float) = 0
		[HideInInspector] _DstBlend ("_DstBlend", Float) = 0
		[HideInInspector] _BlendOp ("_BlendOp", Float) = 0
		[HideInInspector] _Z ("_Z", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Sprites/Default"
}