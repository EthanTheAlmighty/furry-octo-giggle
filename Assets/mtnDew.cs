using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mtnDew : MonoBehaviour {

    public mlgVision Instance;

    void OnTriggerEnter(Collider other)
    {
        Instance.hasMtnDew = true;
        this.gameObject.SetActive(false);
    }
}
