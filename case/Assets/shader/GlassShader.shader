Shader "Custom/GlassShader"
{
    SubShader
    {
        Tags { "RenderType"="Geometry-1" }

		Stencil
		{
			Ref 1
			Comp Always
			Pass Replace
		}

		ColorMask 0
		Zwrite Off

		CGPROGRAM
		#pragma surface surf Standard

		sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            o.Albedo = tex2D(_MainTex,In.uv_MainTex.rgb);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
