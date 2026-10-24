using UnityEngine;

public class TurretSlot : MonoBehaviour
{
    [SerializeField] Sprite placeableSprite;
    [SerializeField] Sprite nonplaceableSprite;
    [SerializeField] bool isPlaceable = true;

    void OnValidate()
    {
        if (placeableSprite == null) Debug.LogError($"{nameof(placeableSprite)} is not assigned.", this);
        if (nonplaceableSprite == null) Debug.LogError($"{nameof(nonplaceableSprite)} is not assigned.", this);
        if (GetComponent<SpriteRenderer>() == null) Debug.LogError("SpriteRenderer component is missing");
    }

    void Start()
    {
        UpdateSprite();
    }

    public void SetPlaceableState(bool val)
    {
        if (val == isPlaceable)
        {
            return;
        }

        isPlaceable = val;
        UpdateSprite();
    }

    void UpdateSprite()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        if (isPlaceable)
        {
            renderer.sprite = placeableSprite;
        }
        else
        {
            renderer.sprite = nonplaceableSprite;
        }
    }
}
