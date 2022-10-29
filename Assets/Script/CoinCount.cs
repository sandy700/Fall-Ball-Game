using UnityEngine;
using TMPro;
public class CoinCount : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    void OnTriggerEnter(Collider other){
            Debug.Log("HO RHA HAI");
            score += 10;
            scoreText.text = "Score: " + score+"";
    }
    
}