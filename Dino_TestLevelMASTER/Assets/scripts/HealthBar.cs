using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour 
{
	public Texture2D frame;
	public Rect framePosition;

	public Texture2D healthBar;
	public Rect HealthBarPosition;

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}

	void OnGUI()
	{
		framePosition.x = (Screen.width - framePosition.width) / 2;
		framePosition.width = Screen.width * 0.39f;
		framePosition.height = Screen.height * 0.049f;
		GUI.DrawTexture (framePosition, frame);
	}
}
