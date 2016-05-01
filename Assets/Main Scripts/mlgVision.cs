using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mlgVision : MonoBehaviour
{
    Image vision;

    public bool hasDorito;
    public bool hasMtnDew;

	// Use this for initialization
	void Start ()
    {
        vision = this.GetComponentInChildren<Image>();
        vision.enabled = false;

	}

    void Update()
    {
        if(hasDorito && hasMtnDew)
        {
            vision.enabled = true;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        vision.color = new Color(Random.Range(0.0F, 1.0F), Random.Range(0.0F, 1.0F), Random.Range(0.0F, 1.0F), 0.3f);
	}
}
