// Upgrade NOTE: commented out 'float3 _WorldSpaceCameraPos', a built-in variable

// Shader "Car_Shaders/GG_PBR_Shader_v1" {
// 	Properties {
// 		[Enum(No,0,Yes,1)] _UseLigtmap ("Use Lightmap", Float) = 0
// 		[Enum(Opague,0,Transparent,1, ClearCoat,2, Glass, 3, Flakes, 4)] _RenderMode ("Render Mode", Float) = 0
// 		[Enum(Cubemap,0,CubemapAndSun,1, OnlySun,2, OnlyAmbient,3)] _LightMode ("Light Mode", Float) = 0
// 		_AO ("Ambient Occlusion", 2D) = "white" {}
// 		_Color ("Color", Vector) = (1,1,1,1)
// 		_ColorFlake ("Color Flake", Vector) = (1,1,1,1)
// 		_FlakeIntensity ("Flake Intensity", Range(0, 10)) = 1
// 		_Metal ("Metal", Range(0, 0.99)) = 0
// 		_Roughness ("Roughness", Range(0, 0.99)) = 0
// 		_AlbedoTexture ("Albedo Texture", 2D) = "white" {}
// 		_NormalTexture ("Normal Texture", 2D) = "bump" {}
// 		_NormalStrength ("Normal Strength", Range(0, 4)) = 1
// 		_NormalScale ("Normal Scale", Range(0, 1000)) = 1
// 		_MetalTexture ("Metal Texture", 2D) = "white" {}
// 		_RoughnessTexture ("Roughness Texture", 2D) = "white" {}
// 		_IntegrateBRDF ("Integrate BRDF", 2D) = "white" {}
// 		_ClearCoatAmount ("Clear Coat Amount", Range(0, 1)) = 1
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
// 	//CustomEditor "GGPBRShaderGUIv1"
// }

Shader "Car_Shaders/GG_PBR_Shader_v1"
{
  Properties
  {
    [Enum(No,0,Yes,1)] _UseLigtmap ("Use Lightmap", float) = 0
    [Enum(Opague,0,Transparent,1, ClearCoat,2, Glass, 3, Flakes, 4)] _RenderMode ("Render Mode", float) = 0
    [Enum(Cubemap,0,CubemapAndSun,1, OnlySun,2, OnlyAmbient,3)] _LightMode ("Light Mode", float) = 0
    _AO ("Ambient Occlusion", 2D) = "white" {}
    _Color ("Color", Color) = (1,1,1,1)
    _ColorFlake ("Color Flake", Color) = (1,1,1,1)
    _FlakeIntensity ("Flake Intensity", Range(0, 10)) = 1
    _Metal ("Metal", Range(0, 0.99)) = 0
    _Roughness ("Roughness", Range(0, 0.99)) = 0
    _AlbedoTexture ("Albedo Texture", 2D) = "white" {}
    _NormalTexture ("Normal Texture", 2D) = "bump" {}
    _NormalStrength ("Normal Strength", Range(0, 4)) = 1
    _NormalScale ("Normal Scale", Range(0, 1000)) = 1
    _MetalTexture ("Metal Texture", 2D) = "white" {}
    _RoughnessTexture ("Roughness Texture", 2D) = "white" {}
    _IntegrateBRDF ("Integrate BRDF", 2D) = "white" {}
    _ClearCoatAmount ("Clear Coat Amount", Range(0, 1)) = 1
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
          float4 tangent :TANGENT0;
          float4 texcoord :TEXCOORD0;
      };
      
      struct OUT_Data_Vert
      {
          float4 texcoord1 :TEXCOORD1;
          float4 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float3 texcoord4 :TEXCOORD4;
          float3 texcoord5 :TEXCOORD5;
          float3 texcoord6 :TEXCOORD6;
          float3 texcoord7 :TEXCOORD7;
          float3 texcoord8 :TEXCOORD8;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float4 texcoord1 :TEXCOORD1;
          float4 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float3 texcoord4 :TEXCOORD4;
          float3 texcoord5 :TEXCOORD5;
          float3 texcoord6 :TEXCOORD6;
          float3 texcoord7 :TEXCOORD7;
          float3 texcoord8 :TEXCOORD8;
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
          float3 u_xlat2;
          float3 u_xlat3;
          float u_xlat12;

          out_v.vertex = UnityObjectToClipPos(in_v.vertex);
          out_v.texcoord1 = in_v.texcoord;
          out_v.texcoord2 = in_v.texcoord;
          
          u_xlat0.xyz = (in_v.vertex.yyy * conv_mxt4x4_1(unity_ObjectToWorld).xyz);
          u_xlat0.xyz = ((conv_mxt4x4_0(unity_ObjectToWorld).xyz * in_v.vertex.xxx) + u_xlat0.xyz);
          u_xlat0.xyz = ((conv_mxt4x4_2(unity_ObjectToWorld).xyz * in_v.vertex.zzz) + u_xlat0.xyz);
          u_xlat0.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);

          out_v.texcoord3.xyz = u_xlat0.xyz;
          out_v.texcoord4.xyz = u_xlat0.xyz + (-_WorldSpaceCameraPos.xyz);

          u_xlat0.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat0.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat0.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);

          u_xlat12 = dot(u_xlat0.xyz, u_xlat0.xyz);
          u_xlat12 = sqrt(u_xlat12);
          u_xlat0.xyz = float3(u_xlat12, u_xlat12, u_xlat12) * u_xlat0.xyz;

          out_v.texcoord5.xyz = UnityObjectToWorldNormal(in_v.normal);


          u_xlat1.xyz = in_v.tangent.yyy * unity_ObjectToWorld[1].yzx;
          u_xlat1.xyz = unity_ObjectToWorld[0].yzx * in_v.tangent.xxx + u_xlat1.xyz;
          u_xlat1.xyz = unity_ObjectToWorld[2].yzx * in_v.tangent.zzz + u_xlat1.xyz;
          u_xlat12 = dot(u_xlat1.xyz, u_xlat1.xyz);
          u_xlat12 = rsqrt(u_xlat12);
          u_xlat1.xyz = float3(u_xlat12, u_xlat12, u_xlat12) * u_xlat1.xyz;
          u_xlat2.xyz = u_xlat0.zxy * u_xlat1.xyz;
          u_xlat2.xyz = u_xlat0.yzx * u_xlat1.yzx + (-u_xlat2.xyz);
          u_xlat12 = in_v.tangent.w * unity_WorldTransformParams.w;
          u_xlat2.xyz = float3(u_xlat12, u_xlat12, u_xlat12) * u_xlat2.xyz;
          u_xlat3.y = u_xlat2.x;
          u_xlat3.z = u_xlat0.x;
          u_xlat3.x = u_xlat1.z;

          out_v.texcoord6.xyz = UnityObjectToWorldDir(in_v.tangent.xyz);
        //   out_v.texcoord6.xyz = cross(out_v.texcoord5.xyz, UnityObjectToWorldDir(in_v.tangent.xyz)) * u_xlat12;
          
          u_xlat0.x = u_xlat1.y;
          u_xlat1.z = u_xlat0.y;
          u_xlat1.y = u_xlat2.y;
          u_xlat0.y = u_xlat2.z;
          out_v.texcoord8.xyz = u_xlat0.xyz;
          out_v.texcoord7.xyz = u_xlat1.xyz;

          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT

      // precision highp float;
      // precision highp int;
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
      uniform float _GG_Min_Luminosity_ = 10;
      uniform float _GG_Luminosity_Pow_ = 10;
      uniform float _GG_Irradiance_Luminosity_ = 10;
      uniform float4 _Color;
      uniform float4 _ColorFlake;
      uniform float _FlakeIntensity;
      uniform float _NormalStrength;
      uniform float _NormalScale;
      uniform float _ClearCoatAmount;
      uniform float4 _GG_AMBIENT_GROUND_ = float4(0.07843138,0.07843138,0.08627451,1);
      uniform float4 _GG_AMBIENT_EQUADOR_ = float4(0.5019608,0.5019608,0.5019608,0.5019608);
      uniform float4 _GG_AMBIENT_SKY_ = float4(0.9921569,0.9803922,0.909804,1);
      uniform float _Roughness;
      uniform float _Metal;
      uniform float _GG_SpecularAmount_ = 10;
      uniform float _GG_DiffuseAmount_ = 10;
      uniform float3 _BBoxMin_G = float3(-10,-10,-10);
      uniform float3 _BBoxMax_G = float3(10,10,10);
      uniform float3 _EnviCubeMapPos_G = float3(1,1,1);

      uniform sampler2D _NormalTexture;
      uniform sampler2D _AlbedoTexture;
      uniform sampler2D _MetalTexture;
      uniform sampler2D _RoughnessTexture;
      uniform samplerCUBE _GG_LightCube_;
      uniform sampler2D _IntegrateBRDF;
      uniform sampler2D _AO;

      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;

          float u_xlat0;
          float3 u_xlat16_1;
          float3 u_xlat2;
          float3 u_xlat16_2;
          float3 u_xlat3;
          float3 u_xlat4;
          float4 u_xlat16_4;
          float4 u_xlat5;
          float3 u_xlat16_5;
          float3 u_xlat6;
          float4 u_xlat7;
          float3 u_xlat8;
          float3 u_xlat16_9;
          float3 u_xlat16_10;
          float3 u_xlat16_11;
          float3 u_xlat16_12;
          float3 u_xlat16_13;
          float2 u_xlat14;
          float u_xlat16_14;
          float2 u_xlat28;
          float2 u_xlat16_28;
          int u_xlati28;
          float u_xlat42;
          float u_xlat16_43;
          float u_xlat16_44;
          float u_xlat16_51;

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


          u_xlat0 = log2(_GG_Luminosity_Pow_);
          u_xlat14.y = tex2D(_RoughnessTexture, in_f.texcoord1.xy).z;
          u_xlat42 = (-u_xlat14.y) + 1.0;
          u_xlat42 = u_xlat42 * 5.0;
          u_xlat0 = u_xlat0 * u_xlat42;
          u_xlat0 = exp2(u_xlat0);
          u_xlat0 = u_xlat0 * _GG_Min_Luminosity_;
          u_xlat16_1.x = u_xlat14.y * 5.0;
          u_xlat42 = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
          u_xlat42 = rsqrt(u_xlat42);
          u_xlat2.xyz = float3(u_xlat42, u_xlat42, u_xlat42) * in_f.texcoord4.xyz;
          u_xlat42 = dot(in_f.texcoord5.xyz, in_f.texcoord5.xyz);
          u_xlat42 = rsqrt(u_xlat42);
          u_xlat3.xyz = float3(u_xlat42, u_xlat42, u_xlat42) * in_f.texcoord5.xyz;
          u_xlat14.x = dot(u_xlat2.xyz, u_xlat3.xyz);
          u_xlat42 = u_xlat14.x + u_xlat14.x;
          u_xlat14.x = (-u_xlat14.x);
      #ifdef UNITY_ADRENO_ES3
          u_xlat14.x = min(max(u_xlat14.x, 0.0), 1.0);
      #else
          u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
      #endif
          u_xlat4.xyz = u_xlat3.xyz * (-float3(u_xlat42, u_xlat42, u_xlat42)) + u_xlat2.xyz;
          u_xlat5.xyz = float3(1.0, 1.0, 1.0) / u_xlat4.xyz;
          u_xlat6.xyz = (-in_f.texcoord3.xyz) + _BBoxMax_G.xyz;
          u_xlat7.xyz = u_xlat5.xyz * u_xlat6.xyz;
          u_xlat8.xyz = (-in_f.texcoord3.xyz) + _BBoxMin_G.xyz;
          u_xlat5.xyz = u_xlat5.xyz * u_xlat8.xyz;
          u_xlat5.xyz = max(u_xlat5.xyz, u_xlat7.xyz);
          u_xlat42 = min(u_xlat5.y, u_xlat5.x);
          u_xlat42 = min(u_xlat5.z, u_xlat42);
          u_xlat4.xyz = u_xlat4.xyz * float3(u_xlat42, u_xlat42, u_xlat42) + in_f.texcoord3.xyz;
          u_xlat4.xyz = u_xlat4.xyz + (-_EnviCubeMapPos_G.xyz);
          u_xlat16_4.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat4.xyz, u_xlat16_1.x)).xyz;
          u_xlat4.xyz = float3(u_xlat0, u_xlat0, u_xlat0) * u_xlat16_4.xyz;
          u_xlat16_1.xyz = u_xlat4.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_);
          u_xlat16_9.xyz = u_xlat16_1.xyz * u_xlat16_1.xyz;
          u_xlat16_28.xy = tex2D(_IntegrateBRDF, u_xlat14.xy).xy;
          u_xlat16_43 = (-u_xlat14.x) + 1.0;
          u_xlat16_51 = u_xlat16_28.y + u_xlat16_28.x;
          u_xlat16_9.xyz = float3(u_xlat16_51, u_xlat16_51, u_xlat16_51) * u_xlat16_9.xyz;
          u_xlat16_9.xyz = u_xlat16_9.xyz * float3(float3(_ClearCoatAmount, _ClearCoatAmount, _ClearCoatAmount));
          u_xlat16_14 = tex2D(_AO, in_f.texcoord2.xy).y;
          u_xlat16_9.xyz = float3(u_xlat16_14, u_xlat16_14, u_xlat16_14) * u_xlat16_9.xyz;
          u_xlat16_51 = u_xlat16_43 * u_xlat16_43;
          u_xlat16_51 = u_xlat16_51 * u_xlat16_51;
          u_xlat16_43 = u_xlat16_43 * u_xlat16_51;
          u_xlat16_44 = tex2D(_MetalTexture, in_f.texcoord1.xy).x;
          u_xlat16_4 = tex2D(_AlbedoTexture, in_f.texcoord1.xy);
          u_xlat16_4 = u_xlat16_4 * _Color;

        //   //

          u_xlat16_10.xyz = u_xlat16_4.xyz * u_xlat16_4.xyz + float3(-0.140000001, -0.140000001, -0.140000001);
          u_xlat16_10.xyz = float3(u_xlat16_44, u_xlat16_44, u_xlat16_44) * u_xlat16_10.xyz + float3(0.140000001, 0.140000001, 0.140000001);
          u_xlat16_11.xyz = (-u_xlat16_10.xyz) + float3(1.0, 1.0, 1.0);
          u_xlat16_10.xyz = u_xlat16_11.xyz * float3(u_xlat16_43, u_xlat16_43, u_xlat16_43) + u_xlat16_10.xyz;
          u_xlat16_11.xyz = (-u_xlat16_10.xyz) + float3(1.0, 1.0, 1.0);
          u_xlat16_10.xyz = u_xlat16_10.xyz * u_xlat16_28.xxx + u_xlat16_28.yyy;
          u_xlat16_5.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat3.xyz, 6.0)).xyz;
          u_xlat16_12.xyz = u_xlat16_5.xyz * float3(float3(_GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_));
          u_xlat16_12.xyz = u_xlat16_12.xyz * float3(float3(_GG_DiffuseAmount_, _GG_DiffuseAmount_, _GG_DiffuseAmount_));
          u_xlat16_13.xyz = u_xlat16_4.xyz * u_xlat16_4.xyz;
          u_xlat16_12.xyz = u_xlat16_12.xyz * u_xlat16_13.xyz;
          u_xlat16_13.xyz = u_xlat16_11.xyz * u_xlat16_13.xyz;
          u_xlat16_11.xyz = u_xlat16_12.xyz * u_xlat16_11.xyz + u_xlat16_9.xyz;
          u_xlat16_1.xyz = u_xlat16_1.xyz * u_xlat16_10.xyz + u_xlat16_11.xyz;
          u_xlat16_43 = max(u_xlat3.y, 0.0);
          u_xlat5 = (-_GG_AMBIENT_EQUADOR_) + _GG_AMBIENT_SKY_;
          u_xlat5 = float4(u_xlat16_43, u_xlat16_43, u_xlat16_43, u_xlat16_43) * u_xlat5 + _GG_AMBIENT_EQUADOR_;
          u_xlat16_43 = max((-u_xlat3.y), 0.0);

          u_xlati28 = int((0.0<u_xlat16_43) ? 0xFFFFFFFFu : uint(0));
          
          u_xlat7 = float4(u_xlat16_43, u_xlat16_43, u_xlat16_43, u_xlat16_43) * _GG_AMBIENT_GROUND_;
          u_xlati28 = max((-u_xlati28), 0);
          u_xlat28.x = float(u_xlati28);
          u_xlat5 = u_xlat28.xxxx * u_xlat7 + u_xlat5;
          u_xlat16_10.xyz = u_xlat5.xyz * u_xlat16_13.xyz;
          u_xlat16_1.xyz = u_xlat16_10.xyz * u_xlat5.www + u_xlat16_1.xyz;
          u_xlat28.xy = in_f.texcoord1.xy * float2(float2(_NormalScale, _NormalScale));
          u_xlat16_5.xyz = tex2D(_NormalTexture, u_xlat28.xy).xyz;
          u_xlat5.xyz = u_xlat16_5.xyz + float3(-0.5, -0.5, -1.0);
          u_xlat5.xyz = float3(float3(_NormalStrength, _NormalStrength, _NormalStrength)) * u_xlat5.xyz + float3(0.5, 0.5, 1.0);

          
          u_xlat16_10.xyz = u_xlat5.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
          u_xlat16_11.x = dot(in_f.texcoord6.xyz, u_xlat16_10.xyz);
          u_xlat16_11.y = dot(in_f.texcoord7.xyz, u_xlat16_10.xyz);
          u_xlat16_11.z = dot(in_f.texcoord8.xyz, u_xlat16_10.xyz);
          u_xlat28.x = dot(u_xlat16_11.xyz, u_xlat16_11.xyz);
          u_xlat28.x = rsqrt(u_xlat28.x);
          u_xlat5.xyz = u_xlat28.xxx * u_xlat16_11.xyz;
          u_xlat28.x = dot(u_xlat2.xyz, u_xlat5.xyz);
          u_xlat28.x = u_xlat28.x + u_xlat28.x;
          u_xlat2.xyz = u_xlat5.xyz * (-u_xlat28.xxx) + u_xlat2.xyz;
          u_xlat28.x = dot(u_xlat5.xyz, u_xlat3.xyz);
          u_xlat28.x = -abs(u_xlat28.x) + 1.0;
          u_xlat28.x = u_xlat28.x * 5.0;
          u_xlat28.x = min(u_xlat28.x, 1.0);
          u_xlat3.xyz = float3(1.0, 1.0, 1.0) / u_xlat2.xyz;
          u_xlat5.xyz = u_xlat3.xyz * u_xlat6.xyz;
          u_xlat3.xyz = u_xlat3.xyz * u_xlat8.xyz;
          u_xlat3.xyz = max(u_xlat3.xyz, u_xlat5.xyz);
          u_xlat42 = min(u_xlat3.y, u_xlat3.x);
          u_xlat42 = min(u_xlat3.z, u_xlat42);
          u_xlat2.xyz = u_xlat2.xyz * float3(u_xlat42, u_xlat42, u_xlat42) + in_f.texcoord3.xyz;
          u_xlat2.xyz = u_xlat2.xyz + (-_EnviCubeMapPos_G.xyz);
          u_xlat16_2.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat2.xyz, 0)).xyz;
          u_xlat2.xyz = float3(u_xlat0, u_xlat0, u_xlat0) * u_xlat16_2.xyz;
          u_xlat16_10.xyz = u_xlat2.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_);
          u_xlat16_9.xyz = u_xlat16_9.xyz * u_xlat16_10.xyz + u_xlat16_10.xyz;
          u_xlat16_10.xyz = _ColorFlake.xyz * float3(_FlakeIntensity, _FlakeIntensity, _FlakeIntensity);
          u_xlat16_9.xyz = u_xlat16_9.xyz * u_xlat16_10.xyz;
          u_xlat16_1.xyz = u_xlat16_9.xyz * u_xlat28.xxx + u_xlat16_1.xyz;
          u_xlat16_1.xyz = float3(u_xlat16_14, u_xlat16_14, u_xlat16_14) * u_xlat16_1.xyz;
          u_xlat16_4.xyz = sqrt(u_xlat16_1.xyz);
          out_f.color.xyz = u_xlat16_4;

        // out_f.color.x = log2(_GG_Luminosity_Pow_);
        // out_f.color.y = log2(_GG_Luminosity_Pow_);
        // out_f.color.z = log2(_GG_Luminosity_Pow_);
        // out_f.color.w = 1;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
