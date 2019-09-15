using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class TImer : MonoBehaviour
{
    bool loadingStarted = false;
    float secondsLeft = 0;
	public int end_level_in=100;

    void Start()
    {	//specify the exact time required to do the simulation YOU CAN ADD YOUR OWN IN UNITY 5.6.6 editor
		StartCoroutine(DelayLoadLevel(end_level_in));
    }

    IEnumerator DelayLoadLevel(float seconds)
    {	// A simple script to decrement the counter
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

		//Quit the application Once the timer is reached
		Application.Quit();
	}
	//Show the time remaining in GUI display
	void OnGUI() { if (loadingStarted) { GUIStyle style = new GUIStyle(); style.normal.textColor = Color.yellow; style.fontSize = 30; style.alignment = TextAnchor.UpperRight; GUI.Label(new Rect(Screen.width - 100, 0, 100, 40), secondsLeft.ToString(), style); } }
}