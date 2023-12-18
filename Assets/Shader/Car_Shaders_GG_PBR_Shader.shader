// Shader "Car_Shaders/GG_PBR_Shader" {
// 	Properties {
// 		[Enum(Opague,0,Transparent,1, ClearCoat,2, Glass, 3, ClearCoatAdditive, 4)] _RenderMode ("Render Mode", Float) = 0
// 		_AO ("Ambient Occlusion", 2D) = "white" {}
// 		_Color ("Color", Vector) = (1,1,1,1)
// 		_Metal ("Metal", Range(0, 0.99)) = 0
// 		_Roughness ("Roughness", Range(0, 0.99)) = 0
// 		_AlbedoTexture ("Albedo Texture", 2D) = "white" {}
// 		_MetalTexture ("Metal Texture", 2D) = "white" {}
// 		_RoughnessTexture ("Roughness Texture", 2D) = "white" {}
// 		_IntegrateBRDF ("Integrate BRDF", 2D) = "white" {}
// 		_ClearCoatAmount ("Clear Coat Amount", Range(0, 1)) = 1
// 		[Enum(UV0,0,UV1,1)] _AOTextureChanel ("AO Texture Chanel", Float) = 0
// 		[Enum(UV0,0,UV1,1)] _AlbedoTextureChanel ("Albedo Texture Chanel", Float) = 0
// 		[HideInInspector] _BBoxMin ("Env Box Min", Vector) = (0,0,0,1)
// 		[HideInInspector] _BBoxMax ("Env Box Max", Vector) = (10,10,10,1)
// 		[HideInInspector] _EnviCubeMapPos ("Cube Map Pos", Vector) = (0,0,0,1)
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
// 	//CustomEditor "GGPBRShaderGUI"
// }

Shader "Car_Shaders/GG_PBR_Shader"
{
  Properties
  {
    [Enum(Opague,0,Transparent,1, ClearCoat,2, Glass, 3, ClearCoatAdditive, 4)] _RenderMode ("Render Mode", float) = 0
    _AO ("Ambient Occlusion", 2D) = "white" {}
    _Color ("Color", Color) = (1,1,1,1)
    _Metal ("Metal", Range(0, 0.99)) = 0
    _Roughness ("Roughness", Range(0, 0.99)) = 0
    _AlbedoTexture ("Albedo Texture", 2D) = "white" {}
    _MetalTexture ("Metal Texture", 2D) = "white" {}
    _RoughnessTexture ("Roughness Texture", 2D) = "white" {}
    _IntegrateBRDF ("Integrate BRDF", 2D) = "white" {}
    _ClearCoatAmount ("Clear Coat Amount", Range(0, 1)) = 1
	_GG_LightCube_ ("GG LightCube", Cube) = "white" {}
    [Enum(UV0,0,UV1,1)] _AOTextureChanel ("AO Texture Chanel", float) = 0
    [Enum(UV0,0,UV1,1)] _AlbedoTextureChanel ("Albedo Texture Chanel", float) = 0
    [HideInInspector] _BBoxMin ("Env Box Min", Vector) = (0,0,0,1)
    [HideInInspector] _BBoxMax ("Env Box Max", Vector) = (10,10,10,1)
    [HideInInspector] _EnviCubeMapPos ("Cube Map Pos", Vector) = (0,0,0,1)
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
      
      
      #define CODE_BLOCK_VERTEX
      //uniform float3 _WorldSpaceCameraPos;
      //uniform float4x4 unity_ObjectToWorld;
      //uniform float4x4 unity_WorldToObject;
      //uniform float4x4 unity_MatrixVP;
      uniform float _GG_Min_Luminosity_;
      uniform float _GG_Luminosity_Pow_;
      uniform float _GG_Irradiance_Luminosity_;
      uniform float4 _Color;
      uniform float _Roughness;
      uniform float _Metal;
      uniform float _GG_SpecularAmount_;
      uniform float _GG_DiffuseAmount_;
      uniform float3 _BBoxMin;
      uniform float3 _BBoxMax;
      uniform float3 _EnviCubeMapPos;
      uniform sampler2D _IntegrateBRDF;
      uniform samplerCUBE _GG_LightCube_;
      struct appdata_t
      {
          float4 vertex :POSITION0;
          float3 normal :NORMAL0;
      };
      
      struct OUT_Data_Vert
      {
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float3 texcoord4 :TEXCOORD4;
          float4 vertex :SV_POSITION;
      };
      
      struct v2f
      {
          float3 texcoord2 :TEXCOORD2;
          float3 texcoord3 :TEXCOORD3;
          float3 texcoord4 :TEXCOORD4;
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
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float4 u_xlat16_0;
      float2 u_xlat10_0;
      float3 u_xlat1_d;
      float3 u_xlat10_1;
      float2 u_xlat2;
      float3 u_xlat16_3;
      float3 u_xlat4;
      float3 u_xlat5;
      float3 u_xlat16_6;
      float3 u_xlat16_7;
      float3 u_xlat16_8;
      float3 u_xlat9;
      float3 u_xlat10_9;
      float3 u_xlat16_16;
      float u_xlat28;
      float u_xlat16_30;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = (((-_Roughness) * _Roughness) + 1);
          u_xlat0_d.x = (u_xlat0_d.x * 5);
          u_xlat9.x = log2(_GG_Luminosity_Pow_);
          u_xlat0_d.x = (u_xlat9.x * u_xlat0_d.x);
          u_xlat0_d.x = exp2(u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * _GG_Min_Luminosity_);
          u_xlat9.x = dot(in_f.texcoord3.xyz, in_f.texcoord3.xyz);
          u_xlat9.x = rsqrt(u_xlat9.x);
          u_xlat9.xyz = (u_xlat9.xxx * in_f.texcoord3.xyz);
          u_xlat1_d.x = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
          u_xlat1_d.x = rsqrt(u_xlat1_d.x);
          u_xlat1_d.xyz = (u_xlat1_d.xxx * in_f.texcoord4.xyz);
          u_xlat2.x = dot(u_xlat9.xyz, u_xlat1_d.xyz);
          u_xlat28 = (u_xlat2.x + u_xlat2.x);
          u_xlat2.x = (-u_xlat2.x);
          u_xlat2.x = clamp(u_xlat2.x, 0, 1);
          u_xlat9.xyz = ((u_xlat1_d.xyz * (-float3(u_xlat28, u_xlat28, u_xlat28))) + u_xlat9.xyz);
          u_xlat10_1.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat1_d.xyz, 6)).xyz;
          u_xlat16_3.xyz = (u_xlat10_1.xyz * float3(float3(_GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_)));
          u_xlat16_3.xyz = (u_xlat16_3.xyz * float3(float3(_GG_DiffuseAmount_, _GG_DiffuseAmount_, _GG_DiffuseAmount_)));
          u_xlat1_d.xyz = (float3(1, 1, 1) / u_xlat9.xyz);
          u_xlat4.xyz = ((-in_f.texcoord2.xyz) + _BBoxMax.xyz);
          u_xlat4.xyz = (u_xlat1_d.xyz * u_xlat4.xyz);
          u_xlat5.xyz = ((-in_f.texcoord2.xyz) + _BBoxMin.xyz);
          u_xlat1_d.xyz = (u_xlat1_d.xyz * u_xlat5.xyz);
          u_xlat1_d.xyz = max(u_xlat1_d.xyz, u_xlat4.xyz);
          u_xlat1_d.x = min(u_xlat1_d.y, u_xlat1_d.x);
          u_xlat1_d.x = min(u_xlat1_d.z, u_xlat1_d.x);
          u_xlat9.xyz = ((u_xlat9.xyz * u_xlat1_d.xxx) + in_f.texcoord2.xyz);
          u_xlat9.xyz = (u_xlat9.xyz + (-_EnviCubeMapPos.xyz));
          u_xlat2.y = (_Roughness * _Roughness);
          u_xlat16_30 = (u_xlat2.y * 5);
          u_xlat10_9.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat9.xyz, u_xlat16_30)).xyz;
          u_xlat0_d.xyz = (u_xlat0_d.xxx * u_xlat10_9.xyz);
          u_xlat16_6.xyz = (u_xlat0_d.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_));
          u_xlat10_0.xy = tex2D(_IntegrateBRDF, u_xlat2.xy).xy;
          u_xlat16_7.xy = ((-u_xlat2.yx) + float2(1, 1));
          u_xlat16_30 = (u_xlat16_7.y * u_xlat16_7.y);
          u_xlat16_30 = (u_xlat16_30 * u_xlat16_30);
          u_xlat16_30 = (u_xlat16_7.y * u_xlat16_30);
          u_xlat16_16.xyz = ((_Color.xyz * _Color.xyz) + float3(-0.00999999978, (-0.00999999978), (-0.00999999978)));
          u_xlat16_16.xyz = clamp(u_xlat16_16.xyz, 0, 1);
          u_xlat16_8.xyz = (u_xlat16_16.xyz + float3(-0.0299999993, (-0.0299999993), (-0.0299999993)));
          u_xlat16_16.xyz = (u_xlat16_16.xyz + float3(0.00999999978, 0.00999999978, 0.00999999978));
          u_xlat16_3.xyz = (u_xlat16_3.xyz * u_xlat16_16.xyz);
          u_xlat16_16.xyz = ((float3(float3(_Metal, _Metal, _Metal)) * u_xlat16_8.xyz) + float3(0.0399999991, 0.0399999991, 0.0399999991));
          u_xlat1_d.xyz = max(u_xlat16_16.xyz, u_xlat16_7.xxx);
          u_xlat1_d.xyz = ((-u_xlat16_16.xyz) + u_xlat1_d.xyz);
          u_xlat1_d.xyz = ((u_xlat1_d.xyz * float3(u_xlat16_30, u_xlat16_30, u_xlat16_30)) + u_xlat16_16.xyz);
          u_xlat16_7.xyz = ((u_xlat1_d.xyz * u_xlat10_0.xxx) + u_xlat10_0.yyy);
          u_xlat16_8.xyz = ((-u_xlat1_d.xyz) + float3(1, 1, 1));
          u_xlat16_6.xyz = (u_xlat16_6.xyz * u_xlat16_7.xyz);
          u_xlat16_3.xyz = ((u_xlat16_3.xyz * u_xlat16_8.xyz) + u_xlat16_6.xyz);
          u_xlat16_0.xyz = sqrt(u_xlat16_3.xyz);
          u_xlat16_0.w = _Color.w;
          out_f.color = u_xlat16_0;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
