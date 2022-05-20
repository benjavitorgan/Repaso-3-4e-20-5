using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{
    public GameObject prefab;
    public Text inputCloneAmount;
    public InputField IField;
    public Text displayClonesLeft;
    int counter;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonePrefab ()
    {
        if (inputCloneAmount.text != "")
        {
            IField.readOnly = true;
            int cloneAmount = int.Parse(inputCloneAmount.text);
            if (counter < cloneAmount)
            {
                GameObject clon;
                clon = Instantiate(prefab);
                Destroy(clon, 2);
                counter++;
                displayClonesLeft.text = (cloneAmount - counter).ToString();
            } else
            {
                displayClonesLeft.text = "¡Ya llego al maximo!";
            }
        } else
        {
            displayClonesLeft.text = "¡ERROR! Ingrese un valor";
        }
        
    }
}
