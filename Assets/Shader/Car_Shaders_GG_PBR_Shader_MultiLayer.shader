// Shader "Car_Shaders/GG_PBR_Shader_MultiLayer" {
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
// 	//CustomEditor "GGPBRShaderGUIMultipleLayers"
// }

Shader "Car_Shaders/GG_PBR_Shader_MultiLayer"
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
	ZWrite [_ZWrite]
	Blend [_SrcBlend] [_DstBlend]
    Pass // ind: 1, name: 
    {
      Tags
      { 
      }
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
      uniform float4 _Color1;
      uniform float _LayerLerpSlider;
      uniform float _Roughness;
      uniform float _Metal;
      uniform float _Roughness1;
      uniform float _Metal1;
      uniform float _GG_SpecularAmount_;
      uniform float _GG_DiffuseAmount_;
      uniform float3 _BBoxMin;
      uniform float3 _BBoxMax;
      uniform float3 _EnviCubeMapPos;
      uniform sampler2D _IntegrateBRDF;
      uniform sampler2D _LayerLerp;
      uniform samplerCUBE _GG_LightCube_;
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
      
      #define CODE_BLOCK_FRAGMENT
      float3 u_xlat0_d;
      float4 u_xlat16_0;
      float3 u_xlat10_0;
      float3 u_xlat1_d;
      float4 u_xlat16_1;
      float3 u_xlat10_1;
      float3 u_xlat2;
      float u_xlat10_2;
      float3 u_xlat16_3;
      float3 u_xlat4;
      float3 u_xlat5;
      float3 u_xlat16_6;
      float3 u_xlat16_7;
      float3 u_xlat16_8;
      float3 u_xlat16_9;
      float3 u_xlat16_10;
      float3 u_xlat16_19;
      float2 u_xlat10_22;
      float u_xlat33;
      float u_xlat34;
      float u_xlat35;
      float u_xlat16_36;
      OUT_Data_Frag frag(v2f in_f)
      {
          OUT_Data_Frag out_f;
          u_xlat0_d.x = dot(in_f.texcoord3.xyz, in_f.texcoord3.xyz);
          u_xlat0_d.x = rsqrt(u_xlat0_d.x);
          u_xlat0_d.xyz = (u_xlat0_d.xxx * in_f.texcoord3.xyz);
          u_xlat1_d.xyz = normalize(in_f.texcoord4.xyz);
          u_xlat2.x = dot(u_xlat0_d.xyz, u_xlat1_d.xyz);
          u_xlat33 = (u_xlat2.x + u_xlat2.x);
          u_xlat2.x = (-u_xlat2.x);
          u_xlat2.x = clamp(u_xlat2.x, 0, 1);
          u_xlat0_d.xyz = ((u_xlat1_d.xyz * (-float3(u_xlat33, u_xlat33, u_xlat33))) + u_xlat0_d.xyz);
          u_xlat10_1.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat1_d.xyz, 6)).xyz;
          u_xlat16_3.xyz = (u_xlat10_1.xyz * float3(float3(_GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_, _GG_Irradiance_Luminosity_)));
          u_xlat16_3.xyz = (u_xlat16_3.xyz * float3(float3(_GG_DiffuseAmount_, _GG_DiffuseAmount_, _GG_DiffuseAmount_)));
          u_xlat1_d.xyz = (float3(1, 1, 1) / u_xlat0_d.xyz);
          u_xlat4.xyz = ((-in_f.texcoord2.xyz) + _BBoxMax.xyz);
          u_xlat4.xyz = (u_xlat1_d.xyz * u_xlat4.xyz);
          u_xlat5.xyz = ((-in_f.texcoord2.xyz) + _BBoxMin.xyz);
          u_xlat1_d.xyz = (u_xlat1_d.xyz * u_xlat5.xyz);
          u_xlat1_d.xyz = max(u_xlat1_d.xyz, u_xlat4.xyz);
          u_xlat33 = min(u_xlat1_d.y, u_xlat1_d.x);
          u_xlat33 = min(u_xlat1_d.z, u_xlat33);
          u_xlat0_d.xyz = ((u_xlat0_d.xyz * float3(u_xlat33, u_xlat33, u_xlat33)) + in_f.texcoord2.xyz);
          u_xlat0_d.xyz = (u_xlat0_d.xyz + (-_EnviCubeMapPos.xyz));
          u_xlat2.yz = (float2(_Roughness, _Roughness1) * float2(_Roughness, _Roughness1));
          u_xlat16_6.xy = (u_xlat2.yz * float2(6, 6));
          u_xlat10_1.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat0_d.xyz, u_xlat16_6.y)).xyz;
          u_xlat10_0.xyz = texCUBElod(_GG_LightCube_, float4(u_xlat0_d.xyz, u_xlat16_6.x)).xyz;
          u_xlat4.xy = float2((((-float2(_Roughness, _Roughness1)) * float2(_Roughness, _Roughness1)) + float2(1, 1)));
          u_xlat33 = log2(_GG_Luminosity_Pow_);
          u_xlat34 = (u_xlat4.y * u_xlat33);
          u_xlat35 = (u_xlat4.x * 5);
          u_xlat33 = (u_xlat33 * u_xlat35);
          u_xlat33 = exp2(u_xlat33);
          u_xlat33 = (u_xlat33 * _GG_Min_Luminosity_);
          u_xlat0_d.xyz = (float3(u_xlat33, u_xlat33, u_xlat33) * u_xlat10_0.xyz);
          u_xlat16_6.xyz = (u_xlat0_d.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_));
          u_xlat0_d.x = (u_xlat34 * 5);
          u_xlat0_d.x = exp2(u_xlat0_d.x);
          u_xlat0_d.x = (u_xlat0_d.x * _GG_Min_Luminosity_);
          u_xlat0_d.xyz = (u_xlat0_d.xxx * u_xlat10_1.xyz);
          u_xlat16_7.xyz = (u_xlat0_d.xyz * float3(_GG_SpecularAmount_, _GG_SpecularAmount_, _GG_SpecularAmount_));
          u_xlat10_0.xy = tex2D(_IntegrateBRDF, u_xlat2.xz).xy;
          u_xlat16_8.xyz = ((-u_xlat2.yzx) + float3(1, 1, 1));
          u_xlat10_22.xy = tex2D(_IntegrateBRDF, u_xlat2.xy).xy;
          u_xlat16_36 = (u_xlat16_8.z * u_xlat16_8.z);
          u_xlat16_36 = (u_xlat16_36 * u_xlat16_36);
          u_xlat16_36 = (u_xlat16_8.z * u_xlat16_36);
          u_xlat16_9.xyz = ((_Color1.xyz * _Color1.xyz) + float3(-0.00999999978, (-0.00999999978), (-0.00999999978)));
          u_xlat16_9.xyz = clamp(u_xlat16_9.xyz, 0, 1);
          u_xlat16_10.xyz = (u_xlat16_9.xyz + float3(-0.0299999993, (-0.0299999993), (-0.0299999993)));
          u_xlat16_9.xyz = (u_xlat16_9.xyz + float3(0.00999999978, 0.00999999978, 0.00999999978));
          u_xlat16_9.xyz = (u_xlat16_3.xyz * u_xlat16_9.xyz);
          u_xlat16_10.xyz = ((float3(float3(_Metal1, _Metal1, _Metal1)) * u_xlat16_10.xyz) + float3(0.0399999991, 0.0399999991, 0.0399999991));
          u_xlat1_d.xyz = max(u_xlat16_8.yyy, u_xlat16_10.xyz);
          u_xlat1_d.xyz = ((-u_xlat16_10.xyz) + u_xlat1_d.xyz);
          u_xlat1_d.xyz = ((u_xlat1_d.xyz * float3(u_xlat16_36, u_xlat16_36, u_xlat16_36)) + u_xlat16_10.xyz);
          u_xlat16_19.xyz = ((u_xlat1_d.xyz * u_xlat10_0.xxx) + u_xlat10_0.yyy);
          u_xlat16_10.xyz = ((-u_xlat1_d.xyz) + float3(1, 1, 1));
          u_xlat16_7.xyz = (u_xlat16_7.xyz * u_xlat16_19.xyz);
          u_xlat16_7.xyz = ((u_xlat16_9.xyz * u_xlat16_10.xyz) + u_xlat16_7.xyz);
          u_xlat16_19.xyz = ((_Color.xyz * _Color.xyz) + float3(-0.00999999978, (-0.00999999978), (-0.00999999978)));
          u_xlat16_19.xyz = clamp(u_xlat16_19.xyz, 0, 1);
          u_xlat16_9.xyz = (u_xlat16_19.xyz + float3(-0.0299999993, (-0.0299999993), (-0.0299999993)));
          u_xlat16_19.xyz = (u_xlat16_19.xyz + float3(0.00999999978, 0.00999999978, 0.00999999978));
          u_xlat16_3.xyz = (u_xlat16_3.xyz * u_xlat16_19.xyz);
          u_xlat16_19.xyz = ((float3(float3(_Metal, _Metal, _Metal)) * u_xlat16_9.xyz) + float3(0.0399999991, 0.0399999991, 0.0399999991));
          u_xlat1_d.xyz = max(u_xlat16_19.xyz, u_xlat16_8.xxx);
          u_xlat1_d.xyz = ((-u_xlat16_19.xyz) + u_xlat1_d.xyz);
          u_xlat1_d.xyz = ((u_xlat1_d.xyz * float3(u_xlat16_36, u_xlat16_36, u_xlat16_36)) + u_xlat16_19.xyz);
          u_xlat16_8.xyz = ((u_xlat1_d.xyz * u_xlat10_22.xxx) + u_xlat10_22.yyy);
          u_xlat16_9.xyz = ((-u_xlat1_d.xyz) + float3(1, 1, 1));
          u_xlat16_6.xyz = (u_xlat16_6.xyz * u_xlat16_8.xyz);
          u_xlat16_0.xyz = ((u_xlat16_3.xyz * u_xlat16_9.xyz) + u_xlat16_6.xyz);
          u_xlat16_1.xyz = ((-u_xlat16_0.xyz) + u_xlat16_7.xyz);
          u_xlat10_2 = tex2D(_LayerLerp, in_f.texcoord.xy).x;
          u_xlat2.x = (u_xlat10_2 * _LayerLerpSlider);
          u_xlat16_0.w = _Color.w;
          u_xlat16_1.w = ((-u_xlat16_0.w) + _Color1.w);
          u_xlat16_0 = ((u_xlat2.xxxx * u_xlat16_1) + u_xlat16_0);
          out_f.color.xyz = sqrt(u_xlat16_0.xyz);
          out_f.color.w = u_xlat16_0.w;
          return out_f;
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
