
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler{
   public TabGroup tabGroup;
   public Image backGround;

   private void Start(){
       backGround = GetComponent<Image>();
       tabGroup.Subscribe(this);
   }

   public void OnPointerEnter(PointerEventData eventData){
       tabGroup.OnTabEnter(this);
   }

   public void OnPointerClick(PointerEventData eventData){
       tabGroup.OnTabSelected(this);
   }

   public void OnPointerExit(PointerEventData eventData){
       tabGroup.OnTabExit(this);
   }
}
