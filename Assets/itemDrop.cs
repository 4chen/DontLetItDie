using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemDrop : MonoBehaviour
{
    public Sprite _sprite;

    void Start()
    {
        GetComponent<Image>().sprite = _sprite;
        StartCoroutine(MoveAndDie());
    }

    IEnumerator MoveAndDie()
    {
        yield return new WaitForSeconds(.02f);
        GetComponent<RectTransform>().position = new Vector2(GetComponent<RectTransform>().position.x, GetComponent<RectTransform>().position.y + 10);
        GetComponent<CanvasGroup>().alpha = GetComponent<CanvasGroup>().alpha - .05f;

        if (GetComponent<CanvasGroup>().alpha > 0)
        {
            StartCoroutine(MoveAndDie());
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }

}
