using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
   
    public float VidaPorDefecto = 100;
    public float Da�oPorDefecto = 20;
    

    private float VidaActual;
    private float Da�oAcutal;


    private void Start()
    {
        VidaActual = VidaPorDefecto;
        Da�oAcutal = Da�oPorDefecto;
    }


    public void Modify(int Amount)
    {
        VidaActual += Amount;
        
    }

    public void ModifyDamage(int Amount)
    {
        Da�oAcutal += Amount;
        Invoke(nameof(ModifyDa�o), 20);

    }

    public void ModifyDa�o()
    {
        Da�oAcutal = Da�oPorDefecto;
    }

    public void ModifySpeed()
    {

    }



    
    




}
