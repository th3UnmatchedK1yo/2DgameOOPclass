using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Character[] Characters { get; private set; }
    public Character CurrentCharacter { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetCharacter(Character character)
    {
        if (character == null)
        {
            Debug.LogError("Attempted to set a null character!");
            return;
        }

        CurrentCharacter = character;
    }
}
