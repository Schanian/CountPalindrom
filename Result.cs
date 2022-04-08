using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Solution{
internal class Result
{
    //{abcd}  => a=d and b=c
        public static int CountPalindrome(string s)
        {
            if(string.IsNullOrWhiteSpace(s) || s.Length<4){
                return 0;
            }
            char[] chars = s.ToCharArray();
            var counter = 0;
            for(int i= 0; i<chars.Length-3; i++) {
                for(int l=chars.Length-1; l>=i+3 ; l--) {
                    if(chars[i]!=chars[l]){
                        continue;
                    }
                    for(int j=i+1; j<l; j++) 
                    {               
                    for(int k=l-1; k>j; k--) 
                    {           
                            if(chars[j]==chars[k]){                                                 
                                counter++;
                            }
                        }
                    }
                }
            }
            return counter;
        }

    }
}
