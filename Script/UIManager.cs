using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] List<Transform> filsters=new List<Transform>();

    private delegate void NullFun() ;
    NullFun nullFun;
    GameObject obj;
    int index=0;
    void Start()
    {
        
        DeactivateAll();
        Debug.Log(filsters.Capacity);
       
    }

    void DeactivateAll()
    {
        foreach (Transform item in filsters)
        {
            item.gameObject.SetActive(false);
        }
    }

    public void ActivateNext()
    {
        NextButton();
        
    }

    public void ActivatePrev(){

    
       PreviousButton();
    }

    void NextButton()
    {
        ToggleFilter(index,false);
        index=(index+1)%filsters.Count;
        ToggleFilter(index,true);
        //activateObject.position=new Vector3(activateObject.position.x-0.2f,activateObject.position.y,activateObject.position.z);
    }

    void PreviousButton()
    {
        //activateObject.position=new Vector3(activateObject.position.x+0.2f,activateObject.position.y,activateObject.position.z);
    
         ToggleFilter(index,false);
        if(index>0)
        {
            index--;   
        }else{
            index=filsters.Count;
        }
        ToggleFilter(index,true); 
    }

    void ToggleFilter(int i,bool tog)
    {
        if(tog)
        {
           filsters[i].gameObject.SetActive(true);
        }else{
            filsters[i].gameObject.SetActive(false);
        }
    }
   

   public void QuiteGame()
   {
        Application.Quit();
   }
}
