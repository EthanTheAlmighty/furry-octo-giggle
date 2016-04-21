// by @torahhorse

using UnityEngine;
using System.Collections;

public class LockMouse : MonoBehaviour
{	
	void Start()
	{
		LockCursor(false);
	}

    void Update()
    {
        if  ( Input.GetKeyDown(KeyCode.Escape) )
        {
        	LockCursor(!Cursor.visible);
        }
    }
    
    public void LockCursor(bool lockCursor)
    {
        //Screen.lockCursor = lockCursor;
        Cursor.visible = lockCursor;
    }
}