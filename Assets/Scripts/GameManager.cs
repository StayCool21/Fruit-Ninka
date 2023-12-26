using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Image fadeImage;
    private int score;

    private Blade blade;
    private Spawner spawner;

    private void Awake() {
        blade = FindObjectOfType<Blade>();
        spawner = FindObjectOfType<Spawner>();
    }

    private void Start() {
        NewGame();
    }

    private void NewGame() {
        // probably will need to call this for menu implementation in future
        Time.timeScale = 1f;

        blade.enabled = true;
        spawner.enabled = true;

        score = 0;
        scoreText.text = score.ToString();
        ClearScene();
    }

    private void ClearScene() {
        Fruit[] fruits = FindObjectsOfType<Fruit>();

        foreach (Fruit fruit in fruits) {
            Destroy(fruit.gameObject);
        }

        Bomb[] bombs = FindObjectsOfType<Bomb>();

        foreach (Bomb bomb in bombs) {
            Destroy(bomb.gameObject);
        }
    }
    
    public void IncreaseScore(int amount) {
        // increment score
        score += amount;
        scoreText.text = score.ToString();
    }

    public void Explode() {
        // disable blade and disable any fruit from spawning
        blade.enabled = false;
        spawner.enabled = false;

        StartCoroutine(ExplodeSequence());
    }

    private IEnumerator ExplodeSequence() {
        float elapsed = 0f;
        float duration = 0.5f;

        while (elapsed < duration) {
            float t = Mathf.Clamp01(elapsed / duration);
            fadeImage.color = Color.Lerp(Color.clear, Color.white, t);
            
            Time.timeScale = 1f - t;
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }

        yield return new WaitForSecondsRealtime(1f);

        elapsed = 0f;

        NewGame(); // instead we could also exit back to main screen and start from there...

        while (elapsed < duration) {
            float t = Mathf.Clamp01(elapsed / duration);
            fadeImage.color = Color.Lerp(Color.white, Color.clear, t);
        
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }
    }
}
