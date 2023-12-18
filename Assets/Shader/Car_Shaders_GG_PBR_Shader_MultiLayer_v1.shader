// Shader "Car_Shaders/GG_PBR_Shader_MultiLayer_v1" {
// 	Properties {
// 		[Enum(Opague,0,Transparent,1, ClearCoat,2)] _RenderMode ("Render Mode", Float) = 0
// 		_AO ("Ambient Occlusion", 2D) = "white" {}
// 		_LayerLerpSlider ("Layer Lerp Slider", Range(0, 1)) = 1
// 		_LayerLerp ("Layer Lerp", 2D) = "white" {}
// 		_Color ("Color", Vector) = (1,1,1,1)
// 		_Metal ("Metal", Range(0, 0.99)) = 0
// 		_Roughness ("Roughness", Range(0, 0.99)) = 0
// 		_AlbedoTexture ("Albedo Texture", 2D) = "white" {}
// 		_MetalTexture ("Metal Texture", 2D) = "white" {}
// 		_RoughnessTexture ("Roughness Texture", 2D) = "white" {}
// 		_ClearCoatAmount ("Clear Coat Amount", Range(0, 1)) = 1
// 		[Enum(Opague,0,Transparent,1, ClearCoat,2)] _RenderMode1 ("Render Mode", Float) = 0
// 		_Color1 ("Color", Vector) = (1,1,1,1)
// 		_Metal1 ("Metal", Range(0, 0.99)) = 0
// 		_Roughness1 ("Roughness", Range(0, 0.99)) = 0
// 		_AlbedoTexture1 ("Albedo Texture", 2D) = "white" {}
// 		_MetalTexture1 ("Metal Texture", 2D) = "white" {}
// 		_RoughnessTexture1 ("Roughness Texture", 2D) = "white" {}
// 		_ClearCoatAmount1 ("Clear Coat Amount", Range(0, 1)) = 1
// 		_IntegrateBRDF ("Integrate BRDF", 2D) = "white" {}
// 		[Enum(UV0,0,UV1,1)] _AOTextureChanel ("AO Texture Chanel", Float) = 0
// 		[Enum(UV0,0,UV1,1)] _AlbedoTextureChanel ("Albedo Texture Chanel", Float) = 0
// 		[HideInInspector] _SrcBlend ("", Float) = 1
// 		[HideInInspector] _DstBlend ("", Float) = 0
// 		[HideInInspector] _ZWrite ("", Float) = 0
// 	}
// 	//DummyShaderTextExporter
// 	SubShader{
// 		Tags { "RenderType"="Opaque" }
// 		LOD 200
// 		CGPROGRAM
// #pragma surface surf Standard
// #pragma target 3.0

// 		fixed4 _Color;
// 		struct Input
// 		{
// 			float2 uv_MainTex;
// 		};
		
// 		void surf(Input IN, inout SurfaceOutputStandard o)
// 		{
// 			o.Albedo = _Color.rgb;
// 			o.Alpha = _Color.a;
// 		}
// 		ENDCG
// 	}
// 	//CustomEditor "GGPBRShaderGUIMultipleLayers"
// }

Shader "Car_Shaders/GG_PBR_Shader_MultiLayer_v1"
{
  Properties
  {
	[Enum(Opague,0,Transparent,1, ClearCoat,2)] _RenderMode ("Render Mode", float) = 0
	_AO ("Ambient Occlusion", 2D) = "white" {}
	_LayerLerpSlider ("Layer Lerp Slider", Range(0, 1)) = 1
	_LayerLerp ("Layer Lerp", 2D) = "white" {}
	_Color ("Color", Color) = (1,1,1,1)
	_Metal ("Metal", Range(0, 0.99)) = 0
	_Roughness ("Roughness", Range(0, 0.99)) = 0
	_AlbedoTexture ("Albedo Texture", 2D) = "white" {}
	_MetalTexture ("Metal Texture", 2D) = "white" {}
	_RoughnessTexture ("Roughness Texture", 2D) = "white" {}
	_ClearCoatAmount ("Clear Coat Amount", Range(0, 1)) = 1
	[Enum(Opague,0,Transparent,1, ClearCoat,2)] _RenderMode1 ("Render Mode", float) = 0
	_Color1 ("Color", Color) = (1,1,1,1)
	_Metal1 ("Metal", Range(0, 0.99)) = 0
	_Roughness1 ("Roughness", Range(0, 0.99)) = 0
	_AlbedoTexture1 ("Albedo Texture", 2D) = "white" {}
	_MetalTexture1 ("Metal Texture", 2D) = "white" {}
	_RoughnessTexture1 ("Roughness Texture", 2D) = "white" {}
	_ClearCoatAmount1 ("Clear Coat Amount", Range(0, 1)) = 1
	_IntegrateBRDF ("Integrate BRDF", 2D) = "white" {}
	_GG_LightCube_ ("GG LightCube", Cube) = "white" {}
	[Enum(UV0,0,UV1,1)] _AOTextureChanel ("AO Texture Chanel", float) = 0
	[Enum(UV0,0,UV1,1)] _AlbedoTextureChanel ("Albedo Texture Chanel", float) = 0
	[HideInInspector] _SrcBlend ("", float) = 1
	[HideInInspector] _DstBlend ("", float) = 0
	[HideInInspector] _ZWrite ("", float) = 0
  }
  SubShader
  {
    Tags
    { 
    }
    Pass // ind: 1, name: 
    {
		Tags
		{ 
		}
		ZWrite [_ZWrite]
		Blend [_SrcBlend] [_DstBlend]
		// m_ProgramMask = 6
		CGPROGRAM
		//#pragma target 4.0
		
		#pragma vertex vert
		#pragma fragment frag
		
		#include "UnityCG.cginc"
		#define conv_mxt4x4_0(mat4x4) float4(mat4x4[0].x,mat4x4[1].x,mat4x4[2].x,mat4x4[3].x)
		#define conv_mxt4x4_1(mat4x4) float4(mat4x4[0].y,mat4x4[1].y,mat4x4[2].y,mat4x4[3].y)
		#define conv_mxt4x4_2(mat4x4) float4(mat4x4[0].z,mat4x4[1].z,mat4x4[2].z,mat4x4[3].z)
		#define conv_mxt4x4_3(mat4x4) float4(mat4x4[0].w,mat4x4[1].w,mat4x4[2].w,mat4x4[3].w)
		
		
		#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
		#if HLSLCC_ENABLE_UNIFORM_BUFFERS
		#define UNITY_UNIFORM
		#else
		#define UNITY_UNIFORM uniform
		#endif
		#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
		#if UNITY_SUPPORTS_UNIFORM_LOCATION
		#define UNITY_LOCATION(x) layout(location = x)
		#define UNITY_BINDING(x) layout(binding = x, std140)
		#else
		#define UNITY_LOCATION(x)
		#define UNITY_BINDING(x) layout(std140)
		#endif

		struct appdata_t
		{
			float4 vertex :POSITION0;
			float3 normal :NORMAL0;
			float4 texcoord :TEXCOORD0;
		};
		
		struct OUT_Data_Vert
		{
			float4 texcoord :TEXCOORD0;
			float4 texcoord1 :TEXCOORD1;
			float3 texcoord2 :TEXCOORD2;
			float3 texcoord3 :TEXCOORD3;
			float3 texcoord4 :TEXCOORD4;
			float4 vertex :SV_POSITION;
		};
		
		struct v2f
		{
			float4 texcoord :TEXCOORD0;
			float4 texcoord1 :TEXCOORD1;
			float3 texcoord2 :TEXCOORD2;
			float3 texcoord3 :TEXCOORD3;
			float3 texcoord4 :TEXCOORD4;
		};
		
		struct OUT_Data_Frag
		{
			float4 color :SV_Target0;
		};

		OUT_Data_Vert vert(appdata_t in_v)
		{
			OUT_Data_Vert out_v;

			float4 u_xlat0;
			float4 u_xlat1;

			out_v.vertex = UnityObjectToClipPos(in_v.vertex);
			out_v.texcoord = in_v.texcoord;
			out_v.texcoord1 = in_v.texcoord;
			u_xlat0.xyz = (in_v.vertex.yyy * conv_mxt4x4_1(unity_ObjectToWorld).xyz);
			u_xlat0.xyz = ((conv_mxt4x4_0(unity_ObjectToWorld).xyz * in_v.vertex.xxx) + u_xlat0.xyz);
			u_xlat0.xyz = ((conv_mxt4x4_2(unity_ObjectToWorld).xyz * in_v.vertex.zzz) + u_xlat0.xyz);
			u_xlat0.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
			out_v.texcoord2.xyz = u_xlat0.xyz;
			out_v.texcoord3.xyz = (u_xlat0.xyz + (-_WorldSpaceCameraPos.xyz));
			out_v.texcoord4.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
			out_v.texcoord4.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
			out_v.texcoord4.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
			return out_v;
		}
      
		#ifdef GL_EXT_shader_texture_lod
		#extension GL_EXT_shader_texture_lod : enable
		#endif
		
		#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
		#if HLSLCC_ENABLE_UNIFORM_BUFFERS
		#define UNITY_UNIFORM
		#else
		#define UNITY_UNIFORM uniform
		#endif
		#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
		#if UNITY_SUPPORTS_UNIFORM_LOCATION
		#define UNITY_LOCATION(x) layout(location = x)
		#define UNITY_BINDING(x) layout(binding = x, std140)
		#else
		#define UNITY_LOCATION(x)
		#define UNITY_BINDING(x) layout(std140)
		#endif
		uniform 	 float _GG_Min_Luminosity_;
		uniform 	 float _GG_Luminosity_Pow_;
		uniform 	 float _GG_Irradiance_Luminosity_;
		uniform 	 float4 _Color;
		uniform 	 float4 _Color1;
		uniform 	 float _LayerLerpSlider;
		uniform 	 float _ClearCoatAmount;
		uniform 	 float _ClearCoatAmount1;
		uniform 	float _Roughness;
		uniform 	float _Metal;
		uniform 	 float _GG_SpecularAmount_;
		uniform 	 float _GG_DiffuseAmount_;
		uniform 	float4 _GG_AMBIENT_GROUND_;
		uniform 	float4 _GG_AMBIENT_EQUADOR_;
		uniform 	float4 _GG_AMBIENT_SKY_;
		uniform 	 float3 _BBoxMin_G;
		uniform 	 float3 _BBoxMax_G;
		uniform 	 float3 _EnviCubeMapPos_G;
		uniform  samplerCUBE _GG_LightCube_;
		uniform  sampler2D _IntegrateBRDF;
		uniform  sampler2D _AlbedoTexture;
		uniform  sampler2D _MetalTexture1;
		uniform  sampler2D _RoughnessTexture1;
		uniform  sampler2D _AlbedoTexture1;
		uniform  sampler2D _LayerLerp;
		uniform  sampler2D _AO;

		OUT_Data_Frag frag(v2f in_f)
		{
			OUT_Data_Frag out_f;

			float3 u_xlat0;
			float4 u_xlat16_0;
			float3 u_xlat1;
			float4 u_xlat16_1;
			float4 u_xlat2;
			float u_xlat16_2;
			float3 u_xlat3;
			float3 u_xlat4;
			float4 u_xlat16_4;
			float4 u_xlat5;
			float3 u_xlat16_6;
			float3 u_xlat16_7;
			float3 u_xlat16_8;
			float3 u_xlat16_9;
			float3 u_xlat16_10;
			float3 u_xlat16_11;
			float3 u_xlat16_21;
			float u_xlat36;
			float u_xlat16_36;
			int u_xlati36;
			float u_xlat37;
			float u_xlat16_42;
			float u_xlat16_43;

			float _GG_Min_Luminosity_ = 0.5;
			float _GG_Luminosity_Pow_ =1.2;
			float _GG_Irradiance_Luminosity_ = 0.5;

			float4 _GG_AMBIENT_GROUND_ = float4(0.07843138,0.07843138,0.08627451,1);
			float4 _GG_AMBIENT_EQUADOR_ = float4(0.5019608,0.5019608,0.5019608,0.5019608);
			float4 _GG_AMBIENT_SKY_ = float4(0.9921569,0.9803922,0.909804,1);
			float _GG_SpecularAmount_ = 0.5;
			float _GG_DiffuseAmount_ = 0.5;
			float3 _BBoxMin_G = float3(-10,-10,-10);
			float3 _BBoxMax_G = float3(10,10,10);
			float3 _EnviCubeMapPos_G = float3(0,3,0);

			u_xlat0.xyz = (-in_f.texcoord2.xyz) + _BBoxMax_G.xyz;
			u_xlat36 = dot(in_f.texcoord3.xyz, in_f.texcoord3.xyz);
			u_xlat36 = rsqrt(u_xlat36);
			u_xlat1.xyz = float3(u_xlat36, u_xlat36, u_xlat36) * in_f.texcoord3.xyz;
			u_xlat36 = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
			u_xlat36 = rsqrt(u_xlat36);
			u_xlat2.xyz = float3(u_xlat36, u_xlat36, u_xlat36) * in_f.texcoord4.xyz;
			u_xlat3.x = dot(u_xlat1.xyz, u_xlat2.xyz);
			u_xlat36 = u_xlat3.x + u_xlat3.x;
			u_xlat3.x = (-u_xlat3.x);
		#ifdef UNITY_ADRENO_ES3
			u_xlat3.x = min(max(u_xlat3.x, 0.0), 1.0);
		#else
			u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
		#endif
			u_xlat1.xyz = u_xlat2.xyz * (-float3(u_xlat36, u_xlat36, u_xlat36)) + u_xlat1.xyz;
			u_xlat4.xyz = float3(1.0, 1.0, 1.0) / u_xlat1.xyz;
			u_xlat0.xyz = u_xlat0.xyz * u_xlat4.xyz;
			u_xlat5.xyz = (-in_f.texcoord2.xyz) + _BBoxMin_G.xyz;
			u_xlat4.xyz = u_xlat4.xyz * u_xlat5.xyz;
			u_xlat0.xyz = max(u_xlat0.xyz, u_xlat4.xyz);
			u_xlat0.x = min(u_xlat0.y, u_xlat0.x);
			u_xlat0.x = min(u_xlat0.z, u_xlat0.x);
			u_xlat0.xyz = u_xlat1.xyz * u_xlat0.xxx + in_f.texcoord2.xyz;
			u_xlat0.xyz = u_xlat0.xyz + (-_EnviCubeMapPos_G.xyz);
			u_xlat3.z = tex2D(_RoughnessTexture1, in_f.texcoord.xy).z;
			u_xlat16_6.x = u_xlat3.z * 5.0;
			u_xlat16_1.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat0.xyz, u_xlat16_6.x)).xyz;
			u_xlat36 = (-u_xlat3.z) + 1.0;
			u_xlat37 = log2(_GG_Luminosity_Pow_);
			u_xlat36 = u_xlat36 * u_xlat37;
			u_xlat36 = u_xlat36 * 5.0;
			u_xlat36 = exp2(u_xlat36);
			u_xlat36 = u_xlat36 * _GG_Min_Luminosity_;
			u_xlat1.xyz = float3(u_xlat36, u_xlat36, u_xlat36) * u_xlat16_1.xyz;
			u_xlat16_6.xyz = u_xlat1.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_);
			u_xlat16_42 = (-u_xlat3.z) + 1.0;
			u_xlat16_1.xy = tex2D(_IntegrateBRDF, u_xlat3.xz).xy;
			u_xlat16_36 = tex2D(_MetalTexture1, in_f.texcoord.xy).x;
			u_xlat16_4 = tex2D(_AlbedoTexture1, in_f.texcoord.xy);
			u_xlat16_4 = u_xlat16_4 * _Color1;
			u_xlat16_7.xyz = u_xlat16_4.xyz * u_xlat16_4.xyz + float3(-0.00999999978, -0.00999999978, -0.00999999978);
		#ifdef UNITY_ADRENO_ES3
			u_xlat16_7.xyz = min(max(u_xlat16_7.xyz, 0.0), 1.0);
		#else
			u_xlat16_7.xyz = clamp(u_xlat16_7.xyz, 0.0, 1.0);
		#endif
			u_xlat16_8.xyz = u_xlat16_7.xyz + float3(-0.0299999993, -0.0299999993, -0.0299999993);
			u_xlat16_7.xyz = u_xlat16_7.xyz + float3(0.00999999978, 0.00999999978, 0.00999999978);
			u_xlat16_8.xyz = float3(u_xlat16_36, u_xlat16_36, u_xlat16_36) * u_xlat16_8.xyz + float3(0.0399999991, 0.0399999991, 0.0399999991);
			u_xlat5.xyz = max(float3(u_xlat16_42, u_xlat16_42, u_xlat16_42), u_xlat16_8.xyz);
			u_xlat5.xyz = (-u_xlat16_8.xyz) + u_xlat5.xyz;
			u_xlat16_42 = (-u_xlat3.x) + 1.0;
			u_xlat16_43 = u_xlat16_42 * u_xlat16_42;
			u_xlat16_43 = u_xlat16_43 * u_xlat16_43;
			u_xlat16_42 = u_xlat16_42 * u_xlat16_43;
			u_xlat5.xyz = u_xlat5.xyz * float3(u_xlat16_42, u_xlat16_42, u_xlat16_42) + u_xlat16_8.xyz;
			u_xlat16_8.xyz = u_xlat5.xyz * u_xlat16_1.xxx + u_xlat16_1.yyy;
			u_xlat16_9.xyz = (-u_xlat5.xyz) + float3(1.0, 1.0, 1.0);
			u_xlat16_43 = u_xlat16_1.y + u_xlat16_1.x;
			u_xlat16_10.xyz = u_xlat16_6.xyz * float3(u_xlat16_43, u_xlat16_43, u_xlat16_43);
			u_xlat16_6.xyz = u_xlat16_6.xyz * u_xlat16_8.xyz;
			u_xlat16_8.xyz = u_xlat16_10.xyz * float3(float3(_ClearCoatAmount1, _ClearCoatAmount1, _ClearCoatAmount1));
			u_xlat16_1.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat2.xyz, 6.0)).xyz;
			u_xlat16_10.xyz = u_xlat16_1.xyz * float3(float3(_GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_));
			u_xlat16_10.xyz = u_xlat16_10.xyz * float3(float3(_GG_DiffuseAmount_, _GG_DiffuseAmount_, _GG_DiffuseAmount_));
			u_xlat16_11.xyz = u_xlat16_7.xyz * u_xlat16_10.xyz;
			u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_9.xyz;
			u_xlat16_6.xyz = u_xlat16_11.xyz * u_xlat16_9.xyz + u_xlat16_6.xyz;
			u_xlat16_9.xy = (-float2(_ClearCoatAmount, _ClearCoatAmount1)) + float2(1.0, 1.0);
			u_xlat16_6.xyz = u_xlat16_9.yyy * u_xlat16_6.xyz + u_xlat16_8.xyz;
			u_xlat16_43 = max(u_xlat2.y, 0.0);
			u_xlat16_8.x = max((-u_xlat2.y), 0.0);
			u_xlat2 = (-_GG_AMBIENT_EQUADOR_) + _GG_AMBIENT_SKY_;
			u_xlat2 = float4(u_xlat16_43, u_xlat16_43, u_xlat16_43, u_xlat16_43) * u_xlat2 + _GG_AMBIENT_EQUADOR_;
		#ifdef UNITY_ADRENO_ES3
			{ bool cond = 0.0<u_xlat16_8.x; u_xlati36 = int(!!cond ? 0xFFFFFFFFu : uint(0)); }
		#else
			u_xlati36 = int((0.0<u_xlat16_8.x) ? 0xFFFFFFFFu : uint(0));
		#endif
			u_xlat5 = u_xlat16_8.xxxx * _GG_AMBIENT_GROUND_;
			u_xlati36 = max((-u_xlati36), 0);
			u_xlat36 = float(u_xlati36);
			u_xlat2 = float4(u_xlat36, u_xlat36, u_xlat36, u_xlat36) * u_xlat5 + u_xlat2;
			u_xlat16_7.xyz = u_xlat2.xyz * u_xlat16_7.xyz;
			u_xlat16_4.xyz = u_xlat16_7.xyz * u_xlat2.www + u_xlat16_6.xyz;
			u_xlat16_6.x = _Roughness * 5.0;
			u_xlat16_0.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat0.xyz, u_xlat16_6.x)).xyz;
			u_xlat36 = (-_Roughness) + 1.0;
			u_xlat36 = u_xlat36 * 5.0;
			u_xlat36 = u_xlat37 * u_xlat36;
			u_xlat36 = exp2(u_xlat36);
			u_xlat36 = u_xlat36 * _GG_Min_Luminosity_;
			u_xlat0.xyz = float3(u_xlat36, u_xlat36, u_xlat36) * u_xlat16_0.xyz;
			u_xlat16_6.xyz = u_xlat0.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_);
			u_xlat3.y = _Roughness;
			u_xlat16_0.xy = tex2D(_IntegrateBRDF, u_xlat3.xy).xy;
			u_xlat16_7.x = u_xlat16_0.y + u_xlat16_0.x;
			u_xlat16_7.xyz = u_xlat16_6.xyz * u_xlat16_7.xxx;
			u_xlat16_7.xyz = u_xlat16_7.xyz * float3(float3(_ClearCoatAmount, _ClearCoatAmount, _ClearCoatAmount));
			u_xlat16_43 = (-_Roughness) + 1.0;
			u_xlat16_1 = tex2D(_AlbedoTexture, in_f.texcoord.xy);
			u_xlat16_1 = u_xlat16_1 * _Color;
			u_xlat16_8.xyz = u_xlat16_1.xyz * u_xlat16_1.xyz + float3(-0.00999999978, -0.00999999978, -0.00999999978);
		#ifdef UNITY_ADRENO_ES3
			u_xlat16_8.xyz = min(max(u_xlat16_8.xyz, 0.0), 1.0);
		#else
			u_xlat16_8.xyz = clamp(u_xlat16_8.xyz, 0.0, 1.0);
		#endif
			u_xlat16_21.xyz = u_xlat16_8.xyz + float3(-0.0299999993, -0.0299999993, -0.0299999993);
			u_xlat16_8.xyz = u_xlat16_8.xyz + float3(0.00999999978, 0.00999999978, 0.00999999978);
			u_xlat16_21.xyz = float3(float3(_Metal, _Metal, _Metal)) * u_xlat16_21.xyz + float3(0.0399999991, 0.0399999991, 0.0399999991);
			u_xlat3.xyz = max(float3(u_xlat16_43, u_xlat16_43, u_xlat16_43), u_xlat16_21.xyz);
			u_xlat3.xyz = (-u_xlat16_21.xyz) + u_xlat3.xyz;
			u_xlat3.xyz = u_xlat3.xyz * float3(u_xlat16_42, u_xlat16_42, u_xlat16_42) + u_xlat16_21.xyz;
			u_xlat16_21.xyz = u_xlat3.xyz * u_xlat16_0.xxx + u_xlat16_0.yyy;
			u_xlat16_11.xyz = (-u_xlat3.xyz) + float3(1.0, 1.0, 1.0);
			u_xlat16_6.xyz = u_xlat16_6.xyz * u_xlat16_21.xyz;
			u_xlat16_21.xyz = u_xlat16_8.xyz * u_xlat16_10.xyz;
			u_xlat16_8.xyz = u_xlat16_8.xyz * u_xlat16_11.xyz;
			u_xlat16_6.xyz = u_xlat16_21.xyz * u_xlat16_11.xyz + u_xlat16_6.xyz;
			u_xlat16_6.xyz = u_xlat16_9.xxx * u_xlat16_6.xyz + u_xlat16_7.xyz;
			u_xlat16_7.xyz = u_xlat2.xyz * u_xlat16_8.xyz;
			u_xlat16_1.xyz = u_xlat16_7.xyz * u_xlat2.www + u_xlat16_6.xyz;
			u_xlat16_0 = (-u_xlat16_1) + u_xlat16_4;
			u_xlat16_2 = tex2D(_LayerLerp, in_f.texcoord.xy).x;
			u_xlat2.x = u_xlat16_2 * _LayerLerpSlider;
			u_xlat16_0 = u_xlat2.xxxx * u_xlat16_0 + u_xlat16_1;
			u_xlat16_2 = tex2D(_AO, in_f.texcoord1.xy).y;
			u_xlat16_6.xyz = u_xlat16_0.xyz * float3(u_xlat16_2, u_xlat16_2, u_xlat16_2);
			out_f.color.w = u_xlat16_0.w;
			u_xlat16_6.xyz = float3(u_xlat16_2, u_xlat16_2, u_xlat16_2) * u_xlat16_6.xyz;
			out_f.color.xyz = sqrt(u_xlat16_6.xyz);
			out_f.color.w = u_xlat16_0.w;
			return out_f;
		}
      
      
      	ENDCG
      
    } // end phase
  }
  FallBack Off
}
