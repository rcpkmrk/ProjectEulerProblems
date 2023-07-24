using System;
using System.Collections.Generic;
public class Problem45
{
    static void Main()
    {
        long T_max = 1000000;
        for(long T=286; T<T_max; T++)
        {
            for(long P=T/2; P<T; P++)
            {
                long eqn1 = (T*(T+1))/2, eqn2 = (P*(3*P-1))/2;
                if(eqn1 == eqn2)
                {
                    for(long H=T/2; H<P; H++)
                    {
                        long eqn3 = H*(2*H-1);
                        if(eqn1 == eqn3 && eqn2 == eqn3)
                        {   
                            Console.WriteLine("T("+T+"):"+eqn1+" P("+P+"):"+eqn2+" H("+H+"):"+eqn3);
                            return;
                        }    
                    }                    
                }                
            }
        }
    }
}