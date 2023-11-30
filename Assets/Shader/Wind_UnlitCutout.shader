Shader "Wind/UnlitCutout" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
		_wind_dir ("Wind Direction", Vector) = (0.5,0.05,0.5,0)
		_wind_size ("Wind Wave Size", Range(5, 50)) = 15
		_tree_sway_stutter_influence ("Tree Sway Stutter Influence", Range(0, 1)) = 0.2
		_tree_sway_stutter ("Tree Sway Stutter", Range(0, 10)) = 1.5
		_tree_sway_speed ("Tree Sway Speed", Range(0, 10)) = 1
		_tree_sway_disp ("Tree Sway Displacement", Range(0, 1)) = 0.3
		_branches_disp ("Branches Displacement", Range(0, 0.5)) = 0.3
		_leaves_wiggle_disp ("Leaves Wiggle Displacement", Float) = 0.07
		_leaves_wiggle_speed ("Leaves Wiggle Speed", Float) = 0.01
		_r_influence ("Red Vertex Influence", Range(0, 1)) = 1
		_b_influence ("Blue Vertex Influence", Range(0, 1)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}