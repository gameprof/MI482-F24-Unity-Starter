using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    
    [SerializeField] private TMP_Text scoreText;
    private                  int      score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore() {
        score += 1;
        scoreText.text = score.ToString();
    }
}
