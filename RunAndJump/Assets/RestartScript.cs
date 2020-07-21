using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour {

    public Button restartButton;
    public Button backButton;
    public Button nextLevelButton;

    void Start() {
        restartButton.onClick.AddListener(Restart);
        backButton.onClick.AddListener(Back);
        nextLevelButton.onClick.AddListener(NextLevel);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Finish") {
            Destroy(other.gameObject);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Back() {
        SceneManager.LoadScene("levels");
    }

    public void NextLevel() {
        var currentSceneParts = SceneManager.GetActiveScene().name.Split('_');
        var nextNumber = int.Parse(currentSceneParts[1]) + 1;
        if (nextNumber < 3)
            SceneManager.LoadScene("level_" + nextNumber);
    }

}
