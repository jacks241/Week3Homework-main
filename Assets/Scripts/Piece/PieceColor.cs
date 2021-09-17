using UnityEngine;

public class PieceColor : MonoBehaviour
{
    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {
        //TODO
        spriteRenderer.sprite = Random()
        
        //spriteRenderer.sprite = ???;
    }
}
