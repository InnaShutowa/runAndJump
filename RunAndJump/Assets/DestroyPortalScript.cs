using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPortalScript : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("here");
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("fucking");
        if (other.tag == "Finish") {
            Destroy(other.gameObject);
        }
    }
}
