﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 class KodePos
{
    private string[] kelurahan= 
    {
         "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijagra",
        "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"    
            
    };
    private int[] kodePos =
    {
        40266, 40287, 40267, 40256, 40287,
        40286, 40286, 40286, 40272, 40274, 40273
    };

    public int? GetKodePos(String kelurahan)
    {
        for (int i = 0; i < this.kelurahan.Length; i++)
        {
            if (this.kelurahan[i] == kelurahan)
            {
                return this.kodePos[i];
            }
        }
        return null;
    }

}
