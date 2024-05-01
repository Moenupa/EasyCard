using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Text, InputField
using UnityEngine.SceneManagement; // Required for loading scenes

public class MenuManager : MonoBehaviour
{
    public InputField codeInputField;
    public Button enterRoomButton;

    void Start()
    {
        enterRoomButton.onClick.AddListener(EnterCardRoom);
    }

    void EnterCardRoom()
    {
        // You can add code here to validate the entered code
        SceneManager.LoadScene("byqfujian");
    }
}
