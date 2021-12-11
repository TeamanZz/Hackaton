using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{

    [System.Serializable]
    public class InputElement
    {
        public GameObject Trigger;
        public bool One;
        public bool All;
        public bool Invert;

        public InputElement()
        {
            One = false;
            All = false;
            Invert = false;
        }
    }


    [System.Serializable]
    public class OutputElement
    {
        public GameObject State;
        public bool StayAfterChange;
        public bool Invert;

        public OutputElement()
        {
            StayAfterChange = false;
            Invert = false;
        }
    }

    public List<InputElement> InputList;

    public List<OutputElement> OutputList;

    public void Activate()
    {
        for (int i = 0; i < OutputList.Count; i++)
        {

        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        for (int i = 0; i < InputList.Count; i++)
        {
            if (InputList[i].One)
            {
                Activate();
            }
        }

        int iAll = 0;

        for (int i = 0; i < InputList.Count; i++)
        {
            if (InputList[i].All == true)
            {
                iAll++;
            }
        }

        if (iAll == InputList.Count)
        {
            Activate();
        }
    }
}
