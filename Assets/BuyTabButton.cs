using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BuyTabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler{
    public BuyTabGroup buyTabGroup;
    public Image backGround;
    public BuyPanelDetails buyPanelDetails;
    public int id;
    private void Start(){
        backGround = GetComponent<Image>();
        buyTabGroup.Subscribe(this);
    }

    public void OnPointerEnter(PointerEventData eventData){
        buyTabGroup.OnTabEnter(this);
    }

    public void OnPointerClick(PointerEventData eventData){
        buyTabGroup.OnTabSelected(this);
        Debug.Log(id);
        buyPanelDetails.LoadContent(id);
    }

    public void OnPointerExit(PointerEventData eventData){
        buyTabGroup.OnTabExit(this);
    }
}
