///////////////////////////////////////////
//  CameraFilterPack v2.0 - by VETASOFT 2015 ///
///////////////////////////////////////////
using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
[AddComponentMenu ("Camera Filter Pack/FX/Screens")]
public class CameraFilterPack_FX_Screens : MonoBehaviour {
#region Variables
public Shader SCShader;
private float TimeX = 1.0f;
private Vector4 ScreenResolution;
private Material SCMaterial;
[Range(0f, 256f)]
public float Tiles = 8f;
[Range(0f, 5f)]
public float Speed = 0.25f;
[Range(-1f, 1f)]
public float PosX = 0f;
[Range(-1f, 1f)]
public float PosY = 0f;
public static float ChangeValue;
public static float ChangeValue2;
public static float ChangeValue3;
public static float ChangeValue4;
#endregion
#region Properties
Material material
{
get
{
if(SCMaterial == null)
{
SCMaterial = new Material(SCShader);
SCMaterial.hideFlags = HideFlags.HideAndDontSave;
}
return SCMaterial;
}
}
#endregion
void Start ()
{
ChangeValue = Tiles;
ChangeValue2 = Speed;
ChangeValue3 = PosX;
ChangeValue4 = PosY;
SCShader = Shader.Find("CameraFilterPack/FX_Screens");
if(!SystemInfo.supportsImageEffects)
{
enabled = false;
return;
}
}

void OnRenderImage (RenderTexture sourceTexture, RenderTexture destTexture)
{
if(SCShader != null)
{
TimeX+=Time.deltaTime;
if (TimeX>100)  TimeX=0;
material.SetFloat("_TimeX", TimeX);
material.SetFloat("_Value", Tiles);
material.SetFloat("_Value2", Speed);
material.SetFloat("_Value3", PosX);
material.SetFloat("_Value4", PosY);
material.SetVector("_ScreenResolution",new Vector4(sourceTexture.width,sourceTexture.height,0.0f,0.0f));
Graphics.Blit(sourceTexture, destTexture, material);
}
else
{
Graphics.Blit(sourceTexture, destTexture);
}
}
void OnValidate()
{
		ChangeValue=Tiles;
		ChangeValue2=Speed;
		ChangeValue3=PosX;
		ChangeValue4=PosY;
}
void Update ()
{
if (Application.isPlaying)
{
Tiles = ChangeValue;
Speed = ChangeValue2;
PosX = ChangeValue3;
PosY = ChangeValue4;
}
#if UNITY_EDITOR
if (Application.isPlaying!=true)
{
SCShader = Shader.Find("CameraFilterPack/FX_Screens");
}
#endif
}
void OnDisable ()
{
if(SCMaterial)
{
DestroyImmediate(SCMaterial);
}
}
}
