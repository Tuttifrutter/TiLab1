using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TiLab1
{
    public class PlayFairChiper : Chiper
    {
        public override string Encrypt(string originalText, string secretKey)
        {
            string chiptext="";
            int k = 0;
            string matrixalphabet = Uniq(secretKey + abc.Replace("J",""));
            char[,] arr = new char[5,5];
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    arr[i, j] = matrixalphabet[k];
                    k++;
                }
            }

            string M = originalText;
            if (M.Contains("J"))
                M.Replace('J', 'I');
            if(M.Length%2 != 0)   // пункт 5
            {
                M += 'X';            
            }

            int i1 = 0, i2 = 0, j1 = 0, j2 = 0;
            char c1='*', c2='*';
            for (int l=0; l< M.Length; l=l+2)
            {
                if (M[l] == M[l + 1])  // пункт 4 
                {
                    string dep = "" + M[l + 1];
                    string rep = "X" + M[l + 1];
                    M.Replace(dep, rep);
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (M[l] == arr[i,j])
                        {
                            i1 = i;
                            j1 = j;
                        }
                        if (M[l+1] == arr[i,j])
                        {
                            i2 = i;
                            j2 = j;
                        }
                    }
                }

                if(i1==i2) //пункт 1
                {
                    c1 = arr[i1, (j1 + 1) % 5];
                    c2 = arr[i2, (j2 + 1) % 5];
                }

                if (j1 == j2) //пункт 2
                {
                    c1 = arr[(i1+1)%5,j1];
                    c2 = arr[(i2+1)%5,j2];
                }

                if (j1 != j2 && i1 != i2) //пункт 3
                {
                    c1 = arr[i1, j2];
                    c2 = arr[i2, j1];
                }
                chiptext = chiptext + c1 + c2;

            }
            


            return chiptext;
        }
        private static string Uniq(string s)
        {
            List<char> used = new List<char>();
            StringBuilder uniq = new StringBuilder();
            foreach (char i in s)
            {
                if (used.IndexOf(i) == -1)
                {
                    used.Add(i);
                    uniq.Append(i);
                }
            }
            return uniq.ToString();
        }

        public override string Decrypt(string chipText, string secretKey)
        {
            string originaltext = "";
            int k = 0;
            string matrixalphabet = Uniq(secretKey + abc.Replace("J", ""));
            char[,] arr = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = matrixalphabet[k];
                    k++;
                }
            }

            string C = chipText;
            if (C.Contains("J"))
                C.Replace('J', 'I');
            if (C.Length % 2 != 0)   // пункт 5
            {
                MessageBox.Show("Шифротекст некорректной длины"); 
            }

            int i1 = 0, i2 = 0, j1 = 0, j2 = 0;
            char m1 = '*', m2 = '*';
            for (int l = 0; l < C.Length-1; l += 2)
            {
                if (C[l] == C[l + 1])  // пункт 4 
                {
                    string dep = "" + C[l + 1];
                    string rep = "X" + C[l + 1];
                    C.Replace(dep, rep);
                } 
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (C[l] == arr[i, j])
                        {
                            i1 = i;
                            j1 = j;
                        }
                        if (C[l + 1] == arr[i, j])
                        {
                            i2 = i;
                            j2 = j;
                        }
                    }
                }

                if (i1 == i2) //пункт 1
                {
                    m1 = arr[i1, (j1 - 1 + 5) % 5];
                    m2 = arr[i2, (j2 - 1 + 5) % 5];
                }

                if (j1 == j2) //пункт 2
                {
                    m1 = arr[(i1 - 1 + 5) % 5, j1];
                    m2 = arr[(i2 - 1 + 5) % 5, j2];
                }

                if (j1 != j2 && i1 != i2) //пункт 3
                {
                    m1 = arr[i1, j2];
                    m2 = arr[i2, j1];
                }
                originaltext = originaltext + m1 + m2;
            }
            return originaltext;
        }
    }
}
