using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{
    Transform me;
    public Transform player;

	// Use this for initialization
	void Start ()
    {
        me = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        me.LookAt(player);     
	}

}
