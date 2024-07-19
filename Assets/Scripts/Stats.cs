using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
   
    public float VidaPorDefecto = 100;
    public float DañoPorDefecto = 20;
    

    private float VidaActual;
    private float DañoAcutal;


    private void Start()
    {
        VidaActual = VidaPorDefecto;
        DañoAcutal = DañoPorDefecto;
    }


    public void Modify(int Amount)
    {
        VidaActual += Amount;
        
    }

    public void ModifyDamage(int Amount)
    {
        DañoAcutal += Amount;
        Invoke(nameof(ModifyDaño), 20);

    }

    public void ModifyDaño()
    {
        DañoAcutal = DañoPorDefecto;
    }

    public void ModifySpeed()
    {

    }



    
    




}
