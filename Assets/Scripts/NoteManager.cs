using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public GameObject CardPrefab;
    public Transform content;
    public Button Button;

    void Start()
    {
        Button.onClick.AddListener(AddNewNote);
    }

    public void AddNewNote()
    {
        GameObject newNote = Instantiate(CardPrefab, content);

        TMP_Text[] texts = newNote.GetComponentsInChildren<TMP_Text>();
        texts[0].text = "Заголовок";
        texts[1].text = "Описание заметки";
    }
}