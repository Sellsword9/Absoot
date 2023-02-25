<<<<<<< HEAD
using System.IO;
using System;
public class Carta 
{
    private Valor v;
    private Palo p;

    public Carta(Valor va, Palo pa)
    {
        this.v = va; 
        this.p = pa; 
    }
    public Carta(int n)
    {
        if (n<0) {throw new Exception("Carta inexistente, numero negativo");}
        if (n==0) {throw new Exception("Carta inexistente, numero cero");}
        if(n>52) {throw new Exception("Carta inexistente, numero mayor a 52");}
        p = 
        n<=13? Palo.C :
        n<=26? Palo.D :
        n<=39? Palo.T : 
        Palo.P;
        n = n % 13;
        if (n == 0) {n = 13;}
        v = 
        n == 1? Valor.A :
        n == 2? Valor.dos :
        n == 3? Valor.tre :
        n == 4? Valor.Cua   :        
        n == 5? Valor.Cin  :
        n == 6? Valor.Sei   :
        n == 7? Valor.Sie   :
        n == 8? Valor.Och   :
        n == 9? Valor.Nue   :
        n == 10? Valor.Die :
        n == 11? Valor.J :
        n == 12? Valor.Q :
        n == 13? Valor.K : 
        Valor.K;
    }
    
    public Valor getValor()
    {
        return v;
    }
    public Palo getPalo()
    {
        return p;
    }

    public int toInt()
    {
        return (int)v;
    }

  
}
=======
using System.IO;
using System;
public class Carta 
{
    private Valor v;
    private Palo p;

    public Carta(Valor va, Palo pa)
    {
        this.v = va; 
        this.p = pa; 
    }
    public Carta(int n)
    {
        if (n<0) {throw new Exception("Carta inexistente, numero negativo");}
        if (n==0) {throw new Exception("Carta inexistente, numero cero");}
        if(n>52) {throw new Exception("Carta inexistente, numero mayor a 52");}
        p = 
        n<=13? Palo.C :
        n<=26? Palo.D :
        n<=39? Palo.T : 
        Palo.P;
        n = n % 13;
        if (n == 0) {n = 13;}
        v = 
        n == 1? Valor.A :
        n == 2? Valor.dos :
        n == 3? Valor.tre :
        n == 4? Valor.Cua   :        
        n == 5? Valor.Cin  :
        n == 6? Valor.Sei   :
        n == 7? Valor.Sie   :
        n == 8? Valor.Och   :
        n == 9? Valor.Nue   :
        n == 10? Valor.Die :
        n == 11? Valor.J :
        n == 12? Valor.Q :
        n == 13? Valor.K : 
        Valor.K;
    }
    
    public Valor getValor()
    {
        return v;
    }
    public Palo getPalo()
    {
        return p;
    }

    public int toInt()
    {
        return (int)v;
    }

  
}
>>>>>>> 33ddc09d9a08aac7057d812d02672065407ffde0
