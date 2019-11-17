using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public delegate void displayTextDel(string msg);
    enum Case
    {
        Zero,
        firstNum,
        operation1,
        operation2,
        secondNum,
        result
    }
    class Brain
    {
        string mes = "";
        string firstNum = "";
        string secondNum = "";
        string res = "0";
        string operation = "";
        Case mode;
        displayTextDel displayText;
        public Brain(displayTextDel displayText)
        {
            this.displayText = displayText;
            mode = Case.Zero;
        }
        public int HexToDec(string a)
        {
            int b = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] <= '9' && a[i] >= '0')
                b += (Convert.ToInt32(a[i]) - 48)*Convert.ToInt32((Math.Pow(Convert.ToDouble(16), Convert.ToDouble(a.Length-1-i))));
                else
                {
                    b += (Convert.ToInt32(a[i]) - 55) * Convert.ToInt32((Math.Pow(Convert.ToDouble(16), Convert.ToDouble(a.Length - 1 - i))));
                }
            }
            return b;
        }
        public void Process(string btn)
        {
            switch (mode)
            {
                case Case.Zero:
                    if((btn[0] >= 'A' && btn[0] <= 'D')||(btn[0] >= '0' && btn[0] <= '9'))
                    {
                        firstNum += btn;
                        mode = Case.firstNum;
                        mes = firstNum;
                    }
                    else
                    {
                        if (btn[0] == '+' || btn[0] == '*' || btn[0] == '-' || btn[0] == '/' || btn == "GCD")
                        {
                            firstNum = res;
                            operation = btn;
                            mode = Case.operation1;
                        }
                        else
                        {
                            if (btn[0] == '√' || btn == "Bin" || btn == "!" || btn == "HEX")
                            {
                                firstNum = "0";
                                mode = Case.operation2;
                                operation = btn;
                                if (btn == "√") mes = firstNum + btn;
                                else
                                {
                                    if(btn == "HEX")
                                    {
                                        mes = firstNum + "ToDec";
                                    }
                                    else mes = btn + firstNum;
                                }
                            }
                        }

                    }
                    break;
                case Case.firstNum:
                    if ((btn[0] >= 'A' && btn[0] <= 'D') || (btn[0] >= '0' && btn[0] <= '9'))
                    {
                        firstNum += btn;
                        mes = firstNum;
                    }
                    else
                    {
                        if (btn[0] == '+' || btn[0] == '*' || btn[0] == '-' || btn[0] == '/' || btn == "GCD")
                        {
                            mode = Case.operation1;
                            operation = btn;
                        }
                        else
                        {
                            if (btn[0] == '√' || btn == "Bin" || btn == "!" || btn == "HEX")
                            {
                                mode = Case.operation2;
                                operation = btn;
                                if (btn == "HEX")
                                {
                                    mes = firstNum + "ToDec";
                                }
                                else
                                {
                                    if (btn == "√") mes = firstNum + btn;
                                    else mes = btn + firstNum;
                                }
                            }
                        }
                    }
                    break;
                case Case.operation1:
                    if (btn[0] >= '0' && btn[0] <= '9')
                    {
                        secondNum += btn;
                        mode = Case.secondNum;
                        mes = secondNum;
                    }
                    break;
                case Case.operation2:
                    mode = Case.result;
                    if(operation == "√")
                    {
                        double r = Math.Sqrt(Convert.ToDouble(firstNum));
                        res = r.ToString();
                    }
                    if (operation == "!")
                    {
                        int r = 1;
                        for (int i = 1; i <= Convert.ToInt32(firstNum); i++)
                        {
                            r *= i;
                        }
                        res = r.ToString();
                    }
                    if (operation == "HEX")
                    {
                        res = HexToDec(firstNum).ToString();
                    }
                    break;
                case Case.secondNum:
                    if (btn[0] >= '0' && btn[0] <= '9')
                    {
                        secondNum += btn;
                        mes = secondNum;
                    }
                    if(btn == "=")
                    {
                        mode = Case.result;
                        int r = 0;
                        if(operation == "+")
                        {
                            r = (Convert.ToInt32(firstNum) + Convert.ToInt32(secondNum));
                        }
                        if (operation == "-")
                        {
                            r = (Convert.ToInt32(firstNum) - Convert.ToInt32(secondNum));
                        }
                        if (operation == "*")
                        {
                            r = (Convert.ToInt32(firstNum) * Convert.ToInt32(secondNum));
                        }
                        if (operation == "/")
                        {
                            r = (Convert.ToInt32(firstNum) / Convert.ToInt32(secondNum));
                        }
                        if(operation == "GCD")
                        {
                            int a = Convert.ToInt32(firstNum);
                            int b = Convert.ToInt32(secondNum);
                            if(a == 0 || b == 0)
                            {
                                r = Math.Max(a, b);
                            }
                            else
                            {
                                for(int i = 1; i <= Math.Min(a, b); i++)
                                {
                                    if(a%i == 0 && b%i == 0)
                                    {
                                        r = i;
                                    }
                                }
                            }
                        }
                        if (r < 0)
                        {
                            r *= -1;
                            res = r.ToString();
                            res += "-";
                        }
                        else
                        {
                            res = r.ToString();
                        }
                        mes = res;
                        firstNum = "";
                        secondNum = "";
                        operation = "";
                    }
                    break;
                case Case.result:
                    mes = res;
                    mode = Case.Zero;
                    break;
            }
            displayText.Invoke(mes);
        }
    }
}