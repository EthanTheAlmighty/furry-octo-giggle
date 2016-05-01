using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void _sceneSwapper(int choice)
    {
        switch (choice)
        {
            case 1:
                SceneManager.LoadScene("test scene");
                break;
            case 2:
                SceneManager.LoadScene("Credits");
                break;
            case 3:
                Application.Quit();
                break;
            default:
                break;
        }

    }
}
