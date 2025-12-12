using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columns : MonoBehaviour {

    private void OnTriggerEnter2D(Collider other)
    {
        if (other.GetComponent<bird>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }

}
