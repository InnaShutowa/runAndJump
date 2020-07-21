using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour {
    public Button nextLevelButton;
    public int levelNumber = -1;

    void Start() {
        nextLevelButton.onClick.AddListener(NextLevel);
    }

    public void NextLevel() {
        if (this.levelNumber == 1)
            SceneManager.LoadScene("level_1");
        if (this.levelNumber == 2)
            SceneManager.LoadScene("level_2");
    }

}
