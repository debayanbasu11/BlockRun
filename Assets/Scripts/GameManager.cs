using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 1f;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart",restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel(){
        Debug.Log("Level Won!");
        completeLevelUI.SetActive(true);
    }
}
