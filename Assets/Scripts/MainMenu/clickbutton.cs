using UnityEngine;
using System.Collections;

public class clickbutton : MonoBehaviour {

	bool dispmenu = false;
	private Color ourColor;
	public GameObject camert;
	public GameObject targ = null;
	float timemit = 0.0f;

	// Use this for initialization
	void Start () {
		camert = GameObject.Find ("Main Camera");
	
	}
	
	// Update is called once per frame
	void Update () {
		timemit += Time.deltaTime;	
	}

	void OnMouseEnter()
	{

		ourColor = GetComponent<Renderer>().material.GetColor("_Color");

		if(ourColor.a >= 0.659f)
		{
			//Debug.Log("Hello World");
			ourColor.a = 1.0f;
			GetComponent<Renderer>().material.SetColor ("_Color", ourColor);
		}
	}

	void OnMouseOver()
	{
		//if (Input.GetMouseButtonDown (0) /*&& GetComponent<Renderer>().material.GetColor("_Color").a >= 0.65f*/) {
			GetComponent<AudioSource> ().Play ();

			/*if(name == "Options")
			{
				if(!dispmenu)
					dispmenu = true;
				else
					dispmenu = false;
			}
			if(name == "PlayBut")
				GetComponent<FadeAllAndScene>().fader = true;*/

		//}
	}

	void OnMouseExit()
	{
		ourColor = GetComponent<Renderer>().material.GetColor("_Color");
		
		if(ourColor.a >= 0.67f)
		{
			Debug.Log("Hello World");
			ourColor.a = 0.66f;
			GetComponent<Renderer>().material.SetColor ("_Color", ourColor);
		}
	}
}
