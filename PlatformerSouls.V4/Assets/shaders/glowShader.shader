Shader "Unlit/glowShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color("Colour", Color) = (1,1,1,1)
        _OutlineThick("outLineThick", float) = 5
    }

    SubShader
    {
        Cull off
        Lighting Off
        ZWrite off
        Blend One OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            sampler2D _MainTex;

            //struct appdata
            //{
            //    float4 vertex : POSITION;
            //    float2 uv : TEXCOORD0;
            //};

            struct v2f
            {
                float4 pos : SV_POSITION;
                half2 uv : TEXTCOORD0;
            };

            v2f vert (appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.texcoord;
                return o;
            }

            float4 _MainTex_TexelSize;
            fixed4 _Color;
            float _OutlineThick;

            fixed4 frag (v2f i) : COLOR
            {
                half4 c = tex2D(_MainTex, i.uv);
                c.rgb *= c.a;
                half4 outlineC = _Color;
                outlineC.a *= ceil(c.a);
                outlineC.rgb *= outlineC.a;

                fixed upAlpha = tex2D(_MainTex, i.uv + fixed2(0, _MainTex_TexelSize.y)*_OutlineThick).a;
                fixed downAlpha = tex2D(_MainTex, i.uv - fixed2(0, _MainTex_TexelSize.y)* _OutlineThick).a;
                fixed rightAlpha = tex2D(_MainTex, i.uv + fixed2(_MainTex_TexelSize.x, 0)* _OutlineThick).a;
                fixed leftAlpha = tex2D(_MainTex, i.uv - fixed2(_MainTex_TexelSize.x, 0)* _OutlineThick).a;

                return lerp(outlineC, c, ceil(upAlpha * downAlpha * rightAlpha * leftAlpha));

            }
            ENDCG
        }
    }
}
