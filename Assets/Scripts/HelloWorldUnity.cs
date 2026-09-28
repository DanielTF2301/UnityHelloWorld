using UnityEngine;

public class HelloWorldUnity : MonoBehaviour
{
    [Header("Player Settings")]
    [Tooltip("Enter the player's name here")]
    [SerializeField] private string playerName;
    [Tooltip("Enter the player's score here")]
    [Range(0, 100)]
    [SerializeField] private int playerScore;

    [HideInInspector] public bool isPlayer;
    

    void Start()
    {
        Debug.Log("Hello " + playerName + "!");
    }

    void Update()
    {
        
    }
}
