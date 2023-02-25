<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaType : CartaContainer
{
   public List<Carta> CartasEnMesa;
   public MesaType(List<Carta> cartasEnMesa)
   {
     this.CartasEnMesa = cartasEnMesa;
   }

    public override Carta CartaDefinir()
    {
        throw new System.NotImplementedException();
    }

    public override int CartaMasAlta()
    {
        throw new System.NotImplementedException();
    }

    public override Mano mejorMano()
    {
        throw new System.NotImplementedException();
    }

    public override List<Carta> totalCartas()
    {
        return CartasEnMesa;
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaType : CartaContainer
{
   public List<Carta> CartasEnMesa;
   public MesaType(List<Carta> cartasEnMesa)
   {
     this.CartasEnMesa = cartasEnMesa;
   }

    public override Carta CartaDefinir()
    {
        throw new System.NotImplementedException();
    }

    public override int CartaMasAlta()
    {
        throw new System.NotImplementedException();
    }

    public override Mano mejorMano()
    {
        throw new System.NotImplementedException();
    }

    public override List<Carta> totalCartas()
    {
        return CartasEnMesa;
    }
}
>>>>>>> 33ddc09d9a08aac7057d812d02672065407ffde0
