using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool _gameHasEnded = false;
    public float RestartDelay = 3f;
    public new Light light;
    public float Duration = 3.0F;
    public TextMesh _text;

    void Start()
    {
        _text.text = " ";
    }

    public void EndGame()
    {
        if (_gameHasEnded == false)
        {
            _gameHasEnded = true;
            Debug.Log("Game over");
            LightChange();
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {
        _text.text = "You lose";
        ScoreCallback.CurrentSpeed = -0.1f;
        ScoreCallback.GameArePlaying = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//        SceneManager.LoadScene("Racing");
    }

    void LightChange()
    {
        float phi = Time.time / Duration * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * 0.1F + 0.1F;
        light.intensity = amplitude;
    }
}