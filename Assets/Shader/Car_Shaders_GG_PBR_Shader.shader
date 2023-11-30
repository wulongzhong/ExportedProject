Shader "Car_Shaders/GG_PBR_Shader" {
	Properties {
		[Enum(Opague,0,Transparent,1, ClearCoat,2, Glass, 3, ClearCoatAdditive, 4)] _RenderMode ("Render Mode", Float) = 0
		_AO ("Ambient Occlusion", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,1)
		_Metal ("Metal", Range(0, 0.99)) = 0
		_Roughness ("Roughness", Range(0, 0.99)) = 0
		_AlbedoTexture ("Albedo Texture", 2D) = "white" {}
		_MetalTexture ("Metal Texture", 2D) = "white" {}
		_RoughnessTexture ("Roughness Texture", 2D) = "white" {}
		_IntegrateBRDF ("Integrate BRDF", 2D) = "white" {}
		_ClearCoatAmount ("Clear Coat Amount", Range(0, 1)) = 1
		[Enum(UV0,0,UV1,1)] _AOTextureChanel ("AO Texture Chanel", Float) = 0
		[Enum(UV0,0,UV1,1)] _AlbedoTextureChanel ("Albedo Texture Chanel", Float) = 0
		[HideInInspector] _BBoxMin ("Env Box Min", Vector) = (0,0,0,1)
		[HideInInspector] _BBoxMax ("Env Box Max", Vector) = (10,10,10,1)
		[HideInInspector] _EnviCubeMapPos ("Cube Map Pos", Vector) = (0,0,0,1)
		[HideInInspector] _SrcBlend ("", Float) = 1
		[HideInInspector] _DstBlend ("", Float) = 0
		[HideInInspector] _ZWrite ("", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a;
		}
		ENDCG
	}
	//CustomEditor "GGPBRShaderGUI"
}