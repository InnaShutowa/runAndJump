using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadEndScript : MonoBehaviour {

    public GameObject panel;
    public GameObject TextObject;
    public GameObject nextLevel;
    Text textComponent;
    //запустится если 2D collider попал в триггер
    void OnTriggerEnter2D(Collider2D other) {
        //проверка, имеет ли объект тэг Player
        if (other.tag == "Player") {
            //ппосмотреть название текущей сцены и загрузить её (reload)
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            panel.gameObject.SetActive(true);

            textComponent = TextObject.GetComponent<Text>();
            if (transform.tag == "Dead") {
                textComponent.text = "К сожалению, вы проиграли... Попробуйте еще раз, у вас обязательно получится!";
            } else if (transform.tag == "Finish") {
                textComponent.text = "Поздравляем с победой!";
                nextLevel.gameObject.SetActive(true);
            }
        }
    }

}