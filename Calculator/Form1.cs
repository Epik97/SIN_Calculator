// Это програма написава в учебных целя Смирнов Юрий Сергеевич

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double _currentValue = 0;
        private double _storedValue = 0;
        private string _operation = "";
        private double _savedResult = 0;
        float a, b, c;
        int count;
        bool znak = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblResult.Text += btn.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            lblResult.Text = a.ToString() + "+";
            znak = true;

            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            lblResult.Text = a.ToString() + "-";
            znak = true;

            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            lblResult.Text = a.ToString() + "*";
            znak = true;

           
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            lblResult.Text = a.ToString() + "/";
            znak = true;

            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calculate();
            lblResult.Text = "";

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblResult.Text = "";
        }

        private void PerformOperation(bool equalsPressed = false)
        {
            if (double.TryParse(lblResult.Text, out _currentValue))
            {
                switch (_operation)
                {
                    case "+":
                        _storedValue += _currentValue;
                        break;
                    case "-":
                        _storedValue -= _currentValue;
                        break;
                    case "*":
                        _storedValue *= _currentValue;
                        break;
                    case "/":
                        if (_currentValue != 0)
                            _storedValue /= _currentValue;
                        else                        
                           MessageBox.Show("Division by zero is not allowed.");
                        break;
                    default:
                        _storedValue = _currentValue;
                        break;
                }

                lblResult.Text = equalsPressed ? _storedValue.ToString() : "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
           

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;

        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    if (b == 0)
                        MessageBox.Show("На ноль делить нельзя.");
                    break;            
                                        
                default:
                    break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lblResult.Text = _savedResult.ToString();
            MessageBox.Show("Результат загружен");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _savedResult = float.Parse(textBox1.Text);
            MessageBox.Show("Результат сохранён");
            

        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
    }
}
