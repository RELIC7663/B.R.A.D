using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class PathId 
{
    public static int Path = 0;

    public static void PathIdset (int num){
       Path = num;  
    }
    public static int PathIdget (){
      return Path;  
    }
}
