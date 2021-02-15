using System.Text;

namespace TiLab1
{
    public class ColumnChiper:Chiper
    {
        private int[] GetKeyNumEncrypt(string key) //номера символов в ключе относительно алфавита
        {
            char c = (char)2000;
            int[] keynumArr = new int[key.Length];

            StringBuilder _key = new StringBuilder(key);
            for (int i = 0; i < _key.Length; i++)
            {
                int min = i;
                for (int j = 0; j < _key.Length; j++)
                {
                    if (_key[j] != c)
                    {
                        min = j;
                        break;
                    }
                }

                for (int j = 0; j < _key.Length; j++)
                {
                    if ((int)_key[j] < (int)_key[min])
                    {
                        min = j;
                    }
                }
                keynumArr[i] = min;
                _key[min] = c;
            }
            return keynumArr;
        }
        private int[] GetKeyNumDecrypt(string key) //номера символов в ключе относительно алфавита
        {
            int[] keynumArr = new int[key.Length];
            StringBuilder _key = new StringBuilder(key);

            for (int i = 0; i < _key.Length; i++)
            {
                int min = 0;
                for (int j = 0; j < _key.Length; j++)
                {
                    if ((int)_key[i] > (int)_key[j])
                    {
                        min++;
                    }
                    else if (((int)_key[i] == (int)_key[j]) && (i > j))
                    {
                        min++;
                    }
                }
                keynumArr[i] = min;
            }
            return keynumArr;
        }

        public override string Encrypt(string text, string key)
        {
            string chiptext = "";
            int[] keynumArr = GetKeyNumEncrypt(key); //номера символов в ключе относительно алфавита
            int k = 0;
            int m = 0;
            int columnhight;
            if(text.Length % key.Length == 0)    // высчитываем высоту столбцов в зависимости от кратности ключа тексту
            {
                columnhight = text.Length / key.Length;
            }
            else
            {
                columnhight = text.Length / key.Length +1;
            }

            char[,] arr = new char[columnhight, key.Length];
            while (m < text.Length)    //выставляем текст построчно с длинной key.length
            {
                int l = 0;
                while (l < key.Length && m < text.Length)
                {    
                    arr[k, l] = text[m];
                    l++;
                    m++;
                }
                k++;
            }
        

            for (int i = 0; i < columnhight; i++)  //заменяем пустые значения массива на *
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (arr[i, j] == '\0')
                        arr[i, j] = '*';
                }         
            }

            for (int i = 0; i < keynumArr.Length; i++)  // выводим столбцы по порядку относительно keynumArr[] 
            {
                int number = keynumArr[i];
                for (int j = 0; j < columnhight; j++)
                        chiptext += arr[j, number];

            }
            return chiptext;
        }

        public override string Decrypt(string chiptext, string key)
        {
            string text = "";
            int[] keynumArr = GetKeyNumDecrypt(key); // номера символов в ключе относительно алфавита
            int k = 0;
            int m = 0;
            if(chiptext.Length % key.Length!=0)   // проверка на кратность шифротекста ключу
                while(chiptext.Length % key.Length != 0)
                {
                    chiptext += "*";
                }
            char[,] arr = new char[chiptext.Length / key.Length, key.Length];
            while (m < chiptext.Length)           //разносим шифротекст по столбцам
            {
                int l = 0;
                while (l < chiptext.Length / key.Length)
                {
                    arr[l, k] = chiptext[m];
                    l++;
                    m++;
                }
                k++;
            }


            char[,] arr2 = new char[chiptext.Length / key.Length, key.Length];
            for (int i = 0; i < key.Length; i++)  // переставляем столбцы местами
            {
                int number = keynumArr[i];
                for (int j = 0; j < chiptext.Length / key.Length; j++)
                {
                   arr2[j,i] = arr[j, number];
                }       
            }

            for (int j = 0; j < chiptext.Length/key.Length; j++) //выводим читая построчно
            {
                for (int i = 0; i < key.Length; i++)
                {
                    text += arr2[j,i];
                }
            }
            return text;
        }
    }
}
