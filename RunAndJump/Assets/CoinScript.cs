using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {
    public int CoinCount;
    public GameObject TextObject;
    Text textComponent;

    void Start() {
        textComponent = TextObject.GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Coin") {
            this.CoinCount++;
            textComponent.text = this.CoinCount.ToString();
            Destroy(other.gameObject);
        }
    }
}
