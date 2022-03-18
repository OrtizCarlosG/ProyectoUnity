using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update

    public Transform canvas;
    public Transform old;
    public CharacterInventory characterInventory;
    public Item item;
    public string typeList;

    void Start()
    {
        characterInventory = GameObject.FindWithTag("Player").GetComponent<CharacterInventory>();
        if (typeList.Equals(string.Empty))
            typeList = "Ground";
        canvas = GameObject.Find("Canvas").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        old = transform.parent;
        transform.SetParent(canvas);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == canvas)
            transform.SetParent(old);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
            characterInventory.RemoveItem(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.transform.GetComponent<Image>().color = new Color32(200, 200, 200, 150);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.transform.GetComponent<Image>().color = new Color32(150, 150, 150, 150);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
