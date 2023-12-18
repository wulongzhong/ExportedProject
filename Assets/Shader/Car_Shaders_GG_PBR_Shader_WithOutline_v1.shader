// Shader "Car_Shaders/GG_PBR_Shader_WithOutline_v1" {
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
// 		_OutlineColor ("Color", Vector) = (1,1,1,1)
// 		_OutlineWidth ("Outline Width", Range(0, 1)) = 0
// 		[HideInInspector] _SrcBlend ("", Float) = 1
// 		[HideInInspector] _DstBlend ("", Float) = 0
// 		[HideInInspector] _ZWrite ("", Float) = 0
// 		_positionOffset ("Position Offset", Vector) = (0,0,0,0)
// 		_scaleMult ("Scale Mult", Vector) = (0,0,0,0)
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
// 	//CustomEditor "GGPBRShaderGUIOutlinev1"
// }

Shader "Car_Shaders/GG_PBR_Shader_WithOutline_v1"
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
    [Enum(UV0,0,UV1,1)] _AOTextureChanel ("AO Texture Chanel", float) = 0
    [Enum(UV0,0,UV1,1)] _AlbedoTextureChanel ("Albedo Texture Chanel", float) = 0
    _OutlineColor ("Color", Color) = (1,1,1,1)
    _OutlineWidth ("Outline Width", Range(0, 1)) = 0
    _GG_LightCube_ ("GG LightCube", Cube) = "white" {}
    [HideInInspector] _SrcBlend ("", float) = 1
    [HideInInspector] _DstBlend ("", float) = 0
    [HideInInspector] _ZWrite ("", float) = 0
    _positionOffset ("Position Offset", Vector) = (0,0,0,0)
    _scaleMult ("Scale Mult", Vector) = (0,0,0,0)
  }
  SubShader
  {
    Tags
    { 
      "QUEUE" = "Transparent"
    }
	Blend [_SrcBlend] [_DstBlend]
    LOD 100
    Pass // ind: 1, name: STENCIL_PASS
    {
      Name "STENCIL_PASS"
      Tags
      { 
        "QUEUE" = "Transparent"
      }
      LOD 100
      ZTest Always
      ZWrite Off
      Stencil
      { 
        Ref 1
        ReadMask 255
        WriteMask 255
        Pass Replace
        Fail Keep
        ZFail Keep
        PassFront Replace
        FailFront Keep
        ZFailFront Keep
        PassBack Replace
        FailBack Keep
        ZFailBack Keep
      } 
      ColorMask 0
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_MatrixVP;
      struct appdata_t
      {
          float4 vertex :POSITION0;
      };
      
      struct OUT_Data_Vert
      {
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float4 vertex :Position;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          out_v.vertex = UnityObjectToClipPos(in_v.vertex);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          out_f.color = float4(0, 0, 0, 0);
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 2, name: OUTLINE
    {
      Name "OUTLINE"
      Tags
      { 
        "QUEUE" = "Transparent"
      }
      LOD 100
      ZWrite Off
      Stencil
      { 
        Ref 1
        ReadMask 255
        WriteMask 255
        Pass Keep
        Fail Keep
        ZFail Keep
        PassFront Keep
        FailFront Keep
        ZFailFront Keep
        PassBack Keep
        FailBack Keep
        ZFailBack Keep
      } 
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_MatrixVP;
      uniform float _OutlineWidth;
      uniform float4 _positionOffset;
      uniform float4 _scaleMult;
      uniform float4 _OutlineColor;
      struct appdata_t
      {
          float4 vertex :POSITION0;
      };
      
      struct OUT_Data_Vert
      {
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float4 vertex :Position;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float u_xlat6;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          u_xlat0.xyz = (in_v.vertex.xyz * _scaleMult.xyz);
          u_xlat6 = (_OutlineWidth + 1);
          u_xlat0.xyz = ((u_xlat0.xyz * float3(u_xlat6, u_xlat6, u_xlat6)) + _positionOffset.xyz);
          out_v.vertex = UnityObjectToClipPos(u_xlat0);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          out_f.color = _OutlineColor;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 3, name: 
    {
      Tags
      { 
        "QUEUE" = "Transparent"
      }
      LOD 100
      ZWrite Off
      Blend Zero Zero
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
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float3 _WorldSpaceCameraPos;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float _GG_Min_Luminosity_;
      uniform float _GG_Luminosity_Pow_;
      uniform float _GG_Irradiance_Luminosity_;
      uniform float4 _Color;
      uniform float4 _GG_AMBIENT_GROUND_;
      uniform float4 _GG_AMBIENT_EQUADOR_;
      uniform float4 _GG_AMBIENT_SKY_;
      uniform float _Roughness;
      uniform float _Metal;
      uniform float _GG_SpecularAmount_;
      uniform float _GG_DiffuseAmount_;
      uniform float3 _BBoxMin_G;
      uniform float3 _BBoxMax_G;
      uniform float3 _EnviCubeMapPos_G;
      uniform samplerCUBE _GG_LightCube_;
      uniform sampler2D _IntegrateBRDF;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
      };
      
      struct OUT_Data_Vert
      {
          float3 texcoord3 :TEXCOORD3;
          float3 texcoord4 :TEXCOORD4;
          float3 texcoord5 :TEXCOORD5;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float3 texcoord3 :TEXCOORD3;
          float3 texcoord4 :TEXCOORD4;
          float3 texcoord5 :TEXCOORD5;
      };
      
      struct OUT_Data_Frag
      {
          float4 color :SV_Target0;
      };
      
      float4 u_xlat0;
      float4 u_xlat1;
      float u_xlat6;
      OUT_Data_Vert vert(appdata_t in_v)
      {
          OUT_Data_Vert out_v;
          out_v.vertex = UnityObjectToClipPos(in_v.vertex);
          u_xlat0.xyz = (in_v.vertex.yyy * conv_mxt4x4_1(unity_ObjectToWorld).xyz);
          u_xlat0.xyz = ((conv_mxt4x4_0(unity_ObjectToWorld).xyz * in_v.vertex.xxx) + u_xlat0.xyz);
          u_xlat0.xyz = ((conv_mxt4x4_2(unity_ObjectToWorld).xyz * in_v.vertex.zzz) + u_xlat0.xyz);
          u_xlat0.xyz = ((conv_mxt4x4_3(unity_ObjectToWorld).xyz * in_v.vertex.www) + u_xlat0.xyz);
          out_v.texcoord3.xyz = u_xlat0.xyz;
          out_v.texcoord4.xyz = (u_xlat0.xyz + (-_WorldSpaceCameraPos.xyz));
          u_xlat0.x = dot(in_v.normal.xyz, conv_mxt4x4_0(unity_WorldToObject).xyz);
          u_xlat0.y = dot(in_v.normal.xyz, conv_mxt4x4_1(unity_WorldToObject).xyz);
          u_xlat0.z = dot(in_v.normal.xyz, conv_mxt4x4_2(unity_WorldToObject).xyz);
          out_v.texcoord5.xyz = normalize(u_xlat0.xyz);
          return out_v;
      }
      
      #define CODE_BLOCK_FRAGMENT
      float4 u_xlat0_d;
      float4 u_xlat16_0;
      float3 u_xlat10_0;
      float3 u_xlat1_d;
      int u_xlati1;
      float4 u_xlat2;
      float2 u_xlat3;
      float3 u_xlat4;
      float3 u_xlat5;
      float3 u_xlat16_6;
      float3 u_xlat16_7;
      float3 u_xlat16_8;
      float3 u_xlat16_9;
      float3 u_xlat10;
      float3 u_xlat10_10;
      float u_xlat31;
      float u_xlat16_36;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = ((-_Roughness) + 1);
          u_xlat0_d.x = (u_xlat0_d.x * 5);
          u_xlat10.x = log2(_GG_Luminosity_Pow_);
          u_xlat0_d.x = (u_xlat10.x * u_xlat0_d.x);
          u_xlat0_d.x = exp2(u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * _GG_Min_Luminosity_);
          u_xlat10.xyz = ((-in_f.texcoord3.xyz) + _BBoxMax_G.xyz);
          u_xlat1_d.x = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
          u_xlat1_d.x = rsqrt(u_xlat1_d.x);
          u_xlat1_d.xyz = (u_xlat1_d.xxx * in_f.texcoord4.xyz);
          u_xlat2.xyz = normalize(in_f.texcoord5.xyz);
          u_xlat3.x = dot(u_xlat1_d.xyz, u_xlat2.xyz);
          u_xlat31 = (u_xlat3.x + u_xlat3.x);
          u_xlat3.x = (-u_xlat3.x);
          u_xlat3.x = clamp(u_xlat3.x, 0, 1);
          u_xlat1_d.xyz = ((u_xlat2.xyz * (-float3(u_xlat31, u_xlat31, u_xlat31))) + u_xlat1_d.xyz);
          u_xlat4.xyz = (float3(1, 1, 1) / u_xlat1_d.xyz);
          u_xlat10.xyz = (u_xlat10.xyz * u_xlat4.xyz);
          u_xlat5.xyz = ((-in_f.texcoord3.xyz) + _BBoxMin_G.xyz);
          u_xlat4.xyz = (u_xlat4.xyz * u_xlat5.xyz);
          u_xlat10.xyz = max(u_xlat10.xyz, u_xlat4.xyz);
          u_xlat10.x = min(u_xlat10.y, u_xlat10.x);
          u_xlat10.x = min(u_xlat10.z, u_xlat10.x);
          u_xlat10.xyz = ((u_xlat1_d.xyz * u_xlat10.xxx) + in_f.texcoord3.xyz);
          u_xlat10.xyz = (u_xlat10.xyz + (-_EnviCubeMapPos_G.xyz));
          u_xlat16_6.x = (_Roughness * 5);
          u_xlat10_10.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat10.xyz, u_xlat16_6.x)).xyz;
          u_xlat0_d.xyz = (u_xlat0_d.xxx * u_xlat10_10.xyz);
          u_xlat16_6.xyz = (u_xlat0_d.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_));
          u_xlat16_36 = ((-u_xlat3.x) + 1);
          u_xlat16_7.x = (u_xlat16_36 * u_xlat16_36);
          u_xlat16_7.x = (u_xlat16_7.x * u_xlat16_7.x);
          u_xlat16_36 = (u_xlat16_36 * u_xlat16_7.x);
          u_xlat16_7.xyz = ((_Color.xyz * _Color.xyz) + float3(-0.140000001, (-0.140000001), (-0.140000001)));
          u_xlat16_7.xyz = ((float3(float3(_Metal, _Metal, _Metal)) * u_xlat16_7.xyz) + float3(0.140000001, 0.140000001, 0.140000001));
          u_xlat16_8.xyz = ((-u_xlat16_7.xyz) + float3(1, 1, 1));
          u_xlat16_7.xyz = ((u_xlat16_8.xyz * float3(u_xlat16_36, u_xlat16_36, u_xlat16_36)) + u_xlat16_7.xyz);
          u_xlat3.y = _Roughness;
          u_xlat10_0.xy = tex2D(_IntegrateBRDF, u_xlat3.xy).xy;
          u_xlat16_8.xyz = ((u_xlat16_7.xyz * u_xlat10_0.xxx) + u_xlat10_0.yyy);
          u_xlat16_7.xyz = ((-u_xlat16_7.xyz) + float3(1, 1, 1));
          u_xlat16_6.xyz = (u_xlat16_6.xyz * u_xlat16_8.xyz);
          u_xlat10_0.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat2.xyz, 6)).xyz;
          u_xlat16_8.xyz = (u_xlat10_0.xyz * float3(float3(_GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_)));
          u_xlat16_8.xyz = (u_xlat16_8.xyz * float3(float3(_GG_DiffuseAmount_, _GG_DiffuseAmount_, _GG_DiffuseAmount_)));
          u_xlat16_9.xyz = (_Color.xyz * _Color.xyz);
          u_xlat16_8.xyz = (u_xlat16_8.xyz * u_xlat16_9.xyz);
          u_xlat16_9.xyz = (u_xlat16_7.xyz * u_xlat16_9.xyz);
          u_xlat16_6.xyz = ((u_xlat16_8.xyz * u_xlat16_7.xyz) + u_xlat16_6.xyz);
          u_xlat16_36 = max(u_xlat2.y, 0);
          u_xlat16_7.x = max((-u_xlat2.y), 0);
          u_xlat0_d = ((-_GG_AMBIENT_EQUADOR_) + _GG_AMBIENT_SKY_);
          u_xlat0_d = ((float4(u_xlat16_36, u_xlat16_36, u_xlat16_36, u_xlat16_36) * u_xlat0_d) + _GG_AMBIENT_EQUADOR_);
          u_xlati1 = int(((0<u_xlat16_7.x))?((-1)):(0));
          u_xlat2 = (u_xlat16_7.xxxx * _GG_AMBIENT_GROUND_);
          u_xlati1 = int(max((-float(u_xlati1)), 0));
          u_xlat1_d.x = float(u_xlati1);
          u_xlat0_d = ((u_xlat1_d.xxxx * u_xlat2) + u_xlat0_d);
          u_xlat16_7.xyz = (u_xlat0_d.xyz * u_xlat16_9.xyz);
          u_xlat16_6.xyz = ((u_xlat16_7.xyz * u_xlat0_d.www) + u_xlat16_6.xyz);
          u_xlat16_0.xyz = sqrt(u_xlat16_6.xyz);
          u_xlat16_0.w = _Color.w;
          out_f.color = u_xlat16_0;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
