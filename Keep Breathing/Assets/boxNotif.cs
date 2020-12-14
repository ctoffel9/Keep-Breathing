using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxNotif : MonoBehaviour
{
    public Text displayText;
    public chestController CC;
    public GameObject Parent;

    private void Update()
    {
        if (CC.thisIsItemVariant == true)
        {
            displayText.text = "Kamu Mendapatakan " + CC.itemArray[CC.randomR].name;
        } else if (CC.thisIsItemVariant == false)
        {
            displayText.text = "Kamu Mendapatakan " + CC.itemButton.name;
        }
        
    }

    public void hide()
    {
        Parent.SetActive(false);
    }
}
