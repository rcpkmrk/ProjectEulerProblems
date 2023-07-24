using System;
using System.Collections.Generic;
// Problem 31: Coin Sums
int counter = 1;
for(int a=0; a<=2; a++) {
    for(int b=0; b<=4; b++) {
        for(int c=0; c<=10; c++) {
            for(int d=0; d<=20; d++) {
                for(int e=0; e<=40; e++) {
                    for(int f=0; f<=100; f++) {
                        for(int g=0; g<=200; g++) {                            
                            if(a*100 + b*50 + c*20 + d*10 + e*5 + f*2 + g*1 == 200)
                            {
                                counter++;                                  
                            }                                                           
                        }                        
                    }
                }
            }
        }
    }  
}
Console.WriteLine("# of different way: "+counter);