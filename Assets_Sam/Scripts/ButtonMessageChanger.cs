using UnityEngine;
using TMPro;
using UnityEngine.UI; // Required for Button component

public class ButtonMessageChanger : MonoBehaviour
{
    // The TextMeshPro Button prefab
    public Button buttonPrefab;

    // The TextMeshPro Text prefab
    public TextMeshProUGUI textPrefab;

    // The message to display when the button is clicked
    public string message;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure buttonPrefab and textPrefab are assigned
        if (buttonPrefab != null && textPrefab != null)
        {
            // Add a listener to the button, so it calls the ChangeTextMessage function when clicked
            buttonPrefab.onClick.AddListener(ChangeTextMessage);
        }
        else
        {
            Debug.LogError("Button or Text prefab is not assigned!");
        }
    }

    // Function to change the text in the TextMeshProUGUI text box
    void ChangeTextMessage()
    {
        if (textPrefab != null)
        {
            // Set the text of the textPrefab to the message
            textPrefab.text = message;
        }
    }
}
