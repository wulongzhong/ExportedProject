Shader "2DxFX/Standard/EnergyBar" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Color ("_Color", Vector) = (1,1,1,1)
		_Value1 ("_Value1", Range(0, 1)) = 1
		_Value2 ("_Value2", Range(0, 1)) = 1
		_Value3 ("_Value3", Range(0, 1)) = 1
		_Value4 ("_Value4", Range(0, 1)) = 1
		_Value5 ("_Value5", Range(0, 1)) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15
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