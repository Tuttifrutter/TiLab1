using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Schema;

namespace TiLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int chipNum = 0;
        private int langNum = 0;
        private const string rusABC = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
        private const string engABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string textStr = txtBSource.Text;
            string keyStr = txtBKey.Text;
            // проверки на дурака
            Chiper chiper = new ColumnChiper();

            switch (chipNum)
            {
                case 0:
                    chiper = new ColumnChiper();
                    break;
                case 1:
                    chiper = new VigenerChiper();
                    break;
                case 2:
                    chiper = new PlayFairChiper();
                    break;
            }

            if (langNum == 0)
            {
                chiper.ABC = rusABC;
            }
            else
            {
                chiper.ABC = engABC;
            }
            txtBResult.Text = chiper.Encrypt(textStr, keyStr);

        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string chiptextStr = StringCheckAndCorrect(txtBResult.Text,chipNum);
            string keyStr = StringCheckAndCorrect(txtBKey.Text,chipNum);
            // проверки на дурака
            
            Chiper chiper = new ColumnChiper();

            switch (chipNum)
            {
                case 0:
                    chiper = new ColumnChiper();
                    break;
                case 1:
                    chiper = new VigenerChiper();
                    break;
                case 2:
                    chiper = new PlayFairChiper();
                    break;
            }

            if (langNum == 0)
            {
                chiper.ABC = rusABC;
            }
            else
            {
                chiper.ABC = engABC;
            }

            txtBSource.Text = chiper.Decrypt(chiptextStr, keyStr);
        }

        private void RbRus_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                langNum = 0;
            }
        }

        private void RbEng_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                langNum = 1;
            }
        }
        private void RbColumn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                chipNum = 0;
            }
        }

        private void RbVigener_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                chipNum = 1;
            }

        }

        private void RbPlayFair_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                chipNum = 2;
            }

        }

        private string StringCheckAndCorrect(string str, int chipNum)
        {
            str = str.ToUpper();
            if(str.Length == 0)
            {
                MessageBox.Show("!!! Не все поля заполнены !!!");
                return "ТЕСТОВЫЙВАРИАНТ";
            }
                
            if(str.Contains(" "))
            {
                str.Replace(" ", "");
            }

            string str2="";
            for(int i = 0; i<str.Length; i++)
            {
                if((str[i]>='А' && str[i] <= 'Я'|| str[i] == 'Ё') || (str[i] >= 'A' && str[i] <= 'Z') || (chipNum==0 && str[i]=='*'))
                {
                    str2 += str[i];
                }
            }
            str = str2;
            return str;
        }


    }
}
