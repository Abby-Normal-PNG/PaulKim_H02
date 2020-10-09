using UnityEngine;

public class Cube : MonoBehaviour
{

	void Start()
	{
		GenerateColor();
	}

	public void GenerateColor()
	{
		GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
		//LogColor();
	}

	public void ResetColor()
	{
		GetComponent<Renderer>().sharedMaterial.color = Color.white;
		//LogColor();
		Debug.Log("Color Reset");
	}

	public void LogColor()
	{
		Debug.Log("Cube Color: " + GetComponent<Renderer>().sharedMaterial.color);
	}
}
