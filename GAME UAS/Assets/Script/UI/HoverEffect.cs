using UnityEngine;
using UnityEngine.EventSystems;

public class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool hover;
    private Vector2 velocity = Vector2.zero;

    void Update()
    {
        if (hover) transform.localScale = Vector2.SmoothDamp(transform.localScale, new Vector2(1.1f, 1.1f), ref velocity, 0.05f);
        else transform.localScale = Vector2.SmoothDamp(transform.localScale, new Vector2(1, 1), ref velocity, 0.05f);
    }

    public void OnPointerEnter(PointerEventData data)
    {
        hover = true;
    }

    public void OnPointerExit(PointerEventData data)
    {
        hover = false;
    }
}
