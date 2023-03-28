using UnityEngine;
using TMPro;
using System.Threading;

public class CreateTextMeshPro : MonoBehaviour
{
    public Vector3 position;
    public Vector2 dimensions;
    public int charIndex;
    string text;

    void Start()
    {
        text = "Health : \nAttack : \nDurability : ";
        GameObject textObject = new GameObject("Bruh");
        textObject.transform.position = position;

        TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
        textMeshPro.text = text;
        textMeshPro.alignment = TextAlignmentOptions.TopLeft;
        textMeshPro.fontSize = 8;
        RectTransform rectTransform = textMeshPro.GetComponent<RectTransform>();
        rectTransform.sizeDelta = dimensions;
        textMeshPro.RegisterDirtyMaterialCallback(() => {
            // Get the position of the character at index charIndex
            TMP_CharacterInfo characterInfo = textMeshPro.textInfo.characterInfo[charIndex];
            Vector3 characterPosition = textMeshPro.transform.TransformPoint(characterInfo.bottomLeft);

            Debug.Log("Position of character at index " + charIndex + " is " + characterPosition);
        });
    }

}